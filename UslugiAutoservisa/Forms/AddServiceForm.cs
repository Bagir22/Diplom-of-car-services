using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace UslugiAutoservisa
{
    public partial class AddServiceForm : Form
    {
        int serviceNum;
        string serviceImg = "";
        string sqlString;

        MySqlConnection connection = sqlClass.Connection;
        MySqlCommand command;
        MySqlDataReader reader;
        
        public AddServiceForm(Button btn, int serviceNumber = 0)
        {
            InitializeComponent();

            if (btn.Name == "addServiceBtn")
            {
                ServiceNumber.Visible = true;
                ServiceNumberLabel.Visible = true;
                EditBtn.Enabled = false;

                sqlString = "Select max(id) from услуги";
                command = new MySqlCommand(sqlString, connection);
                int maxId = 0;
                connection.Open();
                using (connection)
                {                   
                    maxId = Convert.ToInt32(command.ExecuteScalar());                    
                    maxId += 1;                    
                }
                connection.Close();
                serviceNum = maxId;
                ServiceNumber.Value = serviceNum;                
            }
            else if (btn.Name == "editServiceBtn")
            {
                serviceNum = serviceNumber;
                AddBtn.Enabled = false;
                try
                {
                    using (connection)
                    {
                        string StringSql = $"Select * from услуги where `id` = {serviceNum}";
                        using (command = new MySqlCommand(StringSql, connection))
                        {
                            sqlClass.Connection.Open();
                            using (reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    ServiceNumber.Value = Convert.ToInt32(reader.GetValue(0));
                                    ServiceName.Text = reader.GetValue(1).ToString();
                                    ServiceImage.ImageLocation = $@"{Directory.GetCurrentDirectory()}\Images\{reader.GetValue(2)}";
                                    ServicePrice.Value = Convert.ToInt32(reader.GetValue(4));
                                    ServiceTime.Value = Convert.ToInt32(reader.GetValue(3));                                    
                                    Description.Text = reader.GetValue(5).ToString();
                                }
                            }
                        }
                        StringSql = $"SELECT * FROM допизображенияуслуги where Услуга = '{serviceNum}';";
                        using (command = new MySqlCommand(StringSql,connection))
                        {
                            using (reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        try
                                        {
                                            PictureBox pictureBox = new PictureBox();
                                            Bitmap image = new Bitmap($@"{Directory.GetCurrentDirectory()}\Images\{reader.GetValue(1)}");
                                            pictureBox.Name = reader.GetValue(1).ToString();
                                            pictureBox.Image = image;
                                            pictureBox.Height = 75;
                                            pictureBox.Width = 75;
                                            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                                            pictureBox.BorderStyle = BorderStyle.FixedSingle;
                                            AdditionalImagePanel.Controls.Add(pictureBox);
                                        }
                                        catch
                                        {
                                            MessageBox.Show("Не удалось загрузить все дополнительные изображения");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    this.Close();
                    MessageBox.Show(ex.Message, "Не получилось загрузить данные об услуге");
                }
            }

            partsTypeCmb.Items.Add("Все");
            sqlString = "SELECT * FROM uslugiautoservisa.`типы запчастей`";
            command = new MySqlCommand(sqlString, connection);
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                {
                    partsTypeCmb.Items.Add(reader.GetValue(1).ToString());
                }
            connection.Close();
            partsTypeCmb.SelectedIndex = 0;

            sqlString = "SELECT * FROM uslugiautoservisa.`склад запчастей`";
            command = new MySqlCommand(sqlString, connection);
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                {
                    possPartsLb.Items.Add($"{reader.GetValue(1)} || " +
                        $"{reader.GetValue(2)}");
                }
            connection.Close();
        }            

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ServiceName.Text.Length != 0 && ServiceTime.Value != 0 && ServicePrice.Value != 0)
                {
                    using (connection)
                    {
                        string StringSql = $"Select * From услуги where `Наименование услуги` = '{ServiceName.Text}'";
                        using (command = new MySqlCommand(StringSql, connection))
                        {
                            connection.Open();
                            using (reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                    MessageBox.Show("Такая услуга уже существует");
                                else
                                {
                                    reader.Close();
                                    reader.Dispose();
                                    StringSql = $"INSERT INTO `услуги`" +
                                        $" (`Наименование услуги`, `Главное изображение`, `Длительность(мин)`, `Стоимость(руб)`," +
                                        $" `Описание услуги`) VALUES " +
                                        $"('{ServiceName.Text}'," +
                                        $" '{serviceImg}', '{ServiceTime.Value}', " +
                                        $" '{ServicePrice.Value}', '{Description.Text}');";
                                    command = new MySqlCommand(StringSql, connection);                                   
                                    
                                    try
                                    {
                                        if (!File.Exists($"{Directory.GetCurrentDirectory()}\\Images\\" +
                                            $"{serviceImg}") && serviceImg != "")
                                            ServiceImage.Image.Save($"{Directory.GetCurrentDirectory()}\\" +
                                                $"Images\\{serviceImg.Split('\\').Last()}",
                                                System.Drawing.Imaging.ImageFormat.Jpeg);                                        

                                        if (command.ExecuteNonQuery() == 1)
                                            MessageBox.Show("Услуга добавлена");

                                        if (AdditionalImagePanel.Controls.Count != 0)
                                            SaveAdditionalImages(ServiceName.Text);

                                        this.Close();
                                    }
                                    catch (Exception ex)
                                    {                                        
                                        MessageBox.Show("Не получилось добавить услугу");
                                    }
                                }
                            }                            
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Введите данные");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не получилось добавить услугу");
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string ServiceImg = Path.GetFileName(ServiceImage.ImageLocation.ToString());
                using (connection)
                {
                    string StringSql = $"UPDATE `услуги` SET `Наименование услуги` = '{ServiceName.Text}'," +
                                $" `Главное изображение` = '{serviceImg.Split('\\').Last()}', " +
                                $"`Длительность(мин)` = '{ServiceTime.Value}'," +
                                $" `Стоимость(руб)` = '{ServicePrice.Value}', " +
                                $" `Описание услуги` =  '{Description.Text}' where id = {serviceNum}";

                    using (command = new MySqlCommand(StringSql, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Услуга обновлена");
                    }
                    if (AdditionalImagePanel.Controls.Count != 0)
                        SaveAdditionalImages(ServiceName.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не получилось изменить услугу");
            }
        }

        private void AddAdditionalImage_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.Title = "Основное изображене услуги";
                    dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;...";
                    dlg.Multiselect = true;
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        foreach (string imgPath in dlg.FileNames)
                        {
                            try
                            {
                                PictureBox pictureBox = new PictureBox();
                                Bitmap image = new Bitmap(imgPath);
                                pictureBox.Name = imgPath;
                                pictureBox.Image = image;
                                pictureBox.Height = 50;
                                pictureBox.Width = 50;
                                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                                pictureBox.BorderStyle = BorderStyle.FixedSingle;
                                AdditionalImagePanel.Controls.Add(pictureBox);
                            }
                            catch
                            {
                                MessageBox.Show("Ошибка");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не получилось добавить изображение");
            }
        }

        void SaveAdditionalImages(string ServiceName)
        {
            try
            {
                int i = 1;
                foreach (PictureBox image in AdditionalImagePanel.Controls)
                {
                    if (image is PictureBox)
                    {
                        string StringSql = $"INSERT INTO допизображенияуслуги " +
                            $"(`Услуга`, `Изображение`) " +
                            $"VALUES ('{serviceNum}', '{serviceNum}#{i}.jpg');";
                        command = new MySqlCommand(StringSql, connection);
                        command.ExecuteNonQuery();
                        if (!File.Exists($"{Directory.GetCurrentDirectory()}\\Images\\" +
                                           $"{serviceNum}#{i}"))                           
                            (image as PictureBox).Image.Save($"{Directory.GetCurrentDirectory()}\\" +
                                                $"Images\\{serviceNum}#{i}.JPG",
                                                System.Drawing.Imaging.ImageFormat.Jpeg);
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не удалось добавить дополнительные изображения");
            }
        }

        private void ServiceImage_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Основное изображене услуги";
                dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;...";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    ServiceImage.ImageLocation = dlg.FileName;
                    serviceImg = dlg.FileName.Split('\\').Last();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ServiceImage_Click(object sender, EventArgs e)
        {

        }        

        private void AddServiceForm_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void possPartsLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void possPartsLb_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                addedpartsLb.Items.Add(possPartsLb.Items[e.Index].ToString());
        }
    }
}
