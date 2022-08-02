using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace UslugiAutoservisa
{
    public partial class AdditionalServiceImagesForm : Form
    {

        MySqlDataAdapter adapter;
        MySqlConnection connection = sqlClass.Connection;
        int serviceId;
        string serviceName;
        public AdditionalServiceImagesForm(int Id, string service)
        {
            InitializeComponent();
            serviceId = Id;
            serviceName = service;
        }

        private void AdditionalServiceImagesForm_Load(object sender, EventArgs e)
        {
            DataTable ImagesDt = new DataTable();
            string stringSql = "SELECT * FROM допизображенияуслуги " +
                $"where Услуга = {serviceId};";

            ServiceNameLabel.Text = serviceName;

            adapter = new MySqlDataAdapter(stringSql, connection);
            adapter.Fill(ImagesDt);

            if(ImagesDt.Rows.Count != 0)
            {
                foreach (DataRow row in ImagesDt.Rows)
                {
                    try
                    {
                        PictureBox pictureBox = new PictureBox();
                        string imgName = row[1].ToString();
                        Bitmap image = new Bitmap(Image.FromFile($"{Directory.GetCurrentDirectory()}\\" +
                                                    $"Images\\{imgName}"));
                        pictureBox.Name = imgName;
                        pictureBox.Image = image;
                        pictureBox.Height = 150;
                        pictureBox.Width = 150;
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.BorderStyle = BorderStyle.FixedSingle;
                        additionalImagesPanel.Controls.Add(pictureBox);
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка");
                    }
                }
            }
            else
            {
                this.Close();
                MessageBox.Show("У услуги нет дополнительных изображений");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
