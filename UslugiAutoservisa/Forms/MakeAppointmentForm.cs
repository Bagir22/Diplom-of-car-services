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

namespace UslugiAutoservisa
{
    public partial class makeAppointmentForm : Form
    {
        int ServiceId;
        int customerId;
        string sqlString;
        int ordId = 0;
        int[] partId;
        public makeAppointmentForm(int serId, int cusId = 0)
        {
            InitializeComponent();
            ServiceId = serId;
            customerId = cusId;
        }

        MySqlConnection connection = sqlClass.Connection;
        MySqlCommand command;
        MySqlDataReader reader;
        private void makeAppointmentForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (connection)
                {
                    string StringSql = $"SELECT concat(`Фамилия`,`Имя`,`Отчество`) FROM клиенты";
                    connection.Open();
                    using (command = new MySqlCommand(StringSql, connection))
                    {
                        using (reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                FIOCmb.Items.Add(reader.GetValue(0));
                            }
                        }
                    }

                    StringSql = $"SELECT concat(`Фамилия`,`Имя`,`Отчество`) FROM сотрудники";                    
                    using (command = new MySqlCommand(StringSql, connection))
                    {
                        using (reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                empCmb.Items.Add(reader.GetValue(0));
                            }
                        }
                    }


                    StringSql = $"SELECT `Наименование услуги`, `Длительность(мин)` FROM услуги where " +
                        $"id = {ServiceId}";
                    using (command = new MySqlCommand(StringSql, connection))
                    {
                        using (reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ServiceNameLabel.Text += $": {reader.GetValue(0)}";
                                ServiceTimeLabel.Text += $": {reader.GetValue(1)}";
                            }
                        }
                    }
                    connection.Close();
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

                sqlString = "SELECT * FROM uslugiautoservisa.`склад запчастей` where id in (2,3)";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не удалось загрузить форму записи клиентов");
            }
            RecordDateDtp.MinDate = DateTime.Now;

            if (Program.position == 2)
            {
                FIOCmb.Enabled = false;
                FIOCmb.SelectedIndex = customerId - 1;
            }
        }

        private void RecordClientBtn_Click(object sender, EventArgs e)
        {
             try
            {
                if (FIOCmb.SelectedIndex == -1)
                    MessageBox.Show("Выберите клиента для записи");                
                else
                {
                    using (connection)
                    {
                        string hours = Hours.Value.ToString().PadLeft(2, '0');
                        string minutes = Minutes.Value.ToString().PadLeft(2, '0');
                                                   
                        if (minutes.Length == 1)
                            minutes.Insert(1, "0");

                        int status = 2;
                        if (Program.position == 2)
                            status = 1;

                        string StringSql = "INSERT INTO `заказы` " +
                            "(`id услуги`, `id клиента`, `id сотрудника`,`Дата оказания услуги`, `Время оказания услуги`, `Статус`)" +
                            $" VALUES ('{ServiceId}', '{FIOCmb.SelectedIndex+1}', {empCmb.SelectedIndex+1}," +
                            $"'{RecordDateDtp.Value.ToString("yyyy-MM-dd")}', " +
                            $"'{hours}:{minutes}:00', {status});";
                        connection.Open();
                        using (command = new MySqlCommand(StringSql, connection))
                            command.ExecuteNonQuery();
                        connection.Close();
                        for(int i = 0; i < possPartsLb.Items.Count; i++)
                        {
                            StringSql = "INSERT INTO `запчасти заказы` " +
                            "(`id заказа`, `id запчасти`)" +
                            $" VALUES ('{ordId}', '{partId[i]}');";
                            connection.Open();
                            using (command = new MySqlCommand(StringSql, connection))
                                command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    MessageBox.Show("Клиент записан на услугу");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не удалось записать клиента");
            }
        }

        private void RecordDateDtp_ValueChanged(object sender, EventArgs e)
        {
            if (RecordDateDtp.Value.Date.Date == DateTime.Now.Date.Date)
            {
                Hours.Minimum = DateTime.Now.Hour;
                Minutes.Minimum = DateTime.Now.Minute;
                Hours.Value = DateTime.Now.Hour;
                Minutes.Value = DateTime.Now.Minute;
            }
            else
            {                
                Hours.Minimum = 8;
                Minutes.Minimum = 0;

                Hours.Maximum = 20;
                Minutes.Maximum = 59;

                Hours.Value = Hours.Minimum;
                Minutes.Value = Minutes.Minimum;                
            }
        }

        private void Hours_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void partsGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
