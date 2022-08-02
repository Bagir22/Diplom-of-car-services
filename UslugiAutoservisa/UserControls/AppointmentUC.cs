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
    public partial class AppointmentUC : UserControl
    {
        int AppointmentId;
        string AppointmentName;
        MySqlConnection connection = sqlClass.Connection;
        public AppointmentUC(int id, string Name, string cusFio, string empFio, 
            string ClientEmail, string Phone, 
            DateTime date, TimeSpan time, int status)
        {
            InitializeComponent();

            DateTime fullTime = DateTime.ParseExact($"{date.Date.ToString("yyyy-MM-dd")}" +
                $" {time}", "yyyy-MM-dd HH:mm:ss",
                                       System.Globalization.CultureInfo.InvariantCulture);
            TimeSpan TimeLeft = fullTime.Subtract(DateTime.Now);
            AppointmentId = id;
            AppointmentName = Name;
            ServiceNameLabel.Text += Name;
            FIOLabel.Text += cusFio;
            empLabel.Text += empFio;
            Email.Text += ClientEmail;
            PhoneNumberLabel.Text += Phone;
            ServiceDate.Text += date.ToString("yyyy-MM-dd");
            ServiceTimeLabel.Text += $" {time.Hours.ToString().PadLeft(2,'0')}:" +
                $"{time.Minutes.ToString().PadLeft(2, '0')}";
            TimeLeftLabel.Text += $" {TimeLeft.Hours}:{TimeLeft.Minutes}";
            if(TimeLeft.Hours == 0 && TimeLeft.Minutes < 60)
                TimeLeftLabel.ForeColor = Color.Red;


            if (status == 1)
                statusComboBox.SelectedIndex = 0;
            else if (status == 2)            
                statusComboBox.SelectedIndex = 1;                                       
            else if (status == 3)
            {
                statusComboBox.SelectedIndex = 2;
                TimeLeftLabel.Visible = false;
            }                
            else if (status == 4)
                statusComboBox.SelectedIndex = 3;
            else if (status == 5)
                statusComboBox.SelectedIndex = 4;

        }

        private void RecordUC_Load(object sender, EventArgs e)
        {
            this.Font = new Font("Candara", 10);            
            if (this.Parent.Parent.Name == "AppointmentHistoryForm")
            {
                deleteBtn.Visible = false;
                TimeLeftLabel.Visible = false;
                statusComboBox.Enabled = false;                
            }
            statusComboBox.SelectionLength = 0;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string sqlString =  $"DELETE FROM `заказы` WHERE " +
                $"`﻿id` = '{AppointmentId}';";
            MySqlCommand cmd = new MySqlCommand(sqlString, connection);
            connection.Open();
            if (cmd.ExecuteNonQuery() == 1)
                MessageBox.Show("Запись удалена");
            else
                MessageBox.Show("Не получилось удалить запись");
            connection.Close();
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (statusComboBox.SelectedIndex == 3 ||
            //    statusComboBox.SelectedIndex == 4)
            //{
            //    string sqlString = "UPDATE `оказанные услуги` SET " +
            //        $"`Статус` = '{statusComboBox.SelectedIndex}' WHERE " +
            //        $"(`﻿id` = '{AppointmentId}') and " +
            //        $"(`Услуга` = '{AppointmentName}');";
            //    this.Dispose();
            //}
        }
    }
}
