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
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
        }

        MySqlDataAdapter adapter;
        MySqlDataReader reader;
        MySqlConnection connection = sqlClass.Connection;
        DataTable AppointmentsDt = new DataTable();
        private void timer1_Tick(object sender, EventArgs e)
        {
            appointmentDisplay();
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            statusComboBox.SelectedIndex = 0;
            appointmentDisplay();
        }

        void appointmentDisplay()
        {
            try
            {
                AppointmentsPanel.Controls.Clear();
                AppointmentsDt.Rows.Clear();
                using (connection)
                {
                    string sqlString = $"select * from `ЗаписиНаУслугиView` ";                       

                        if (statusComboBox.SelectedIndex != 0)                        
                            if (statusComboBox.SelectedIndex == 1)
                                sqlString += "where `Статус` = 1 ";
                            else if (statusComboBox.SelectedIndex == 2)
                                sqlString += "where `Статус` = 2 ";     
                            else
                                sqlString += "where `Статус` = 3 ";
                        else
                            sqlString += "where (`Статус` = 1 or `Статус` = 2 or `Статус` = 3) ";

                        if (searchTextBox.Text.Length != 0)
                            sqlString += $"and (`Наименование услуги` like '%{searchTextBox.Text}%' " +
                                $"or `фио клиента` like '%{searchTextBox.Text}%') ";

                        if (Program.position == 2)
                        {
                            string fio = $"{Program.lastName} {Program.firstName} {Program.patronymicName}";
                            sqlString += $" and `фио клиента` like '%{fio}%' ";
                        }

                    sqlString += "order by concat(`Дата оказания услуги`, ' ',`Время оказания услуги`); ";

                    using (adapter = new MySqlDataAdapter(sqlString, connection))
                    {
                        adapter.Fill(AppointmentsDt);
                    }
                }

                foreach (DataRow row in AppointmentsDt.Rows)
                {
                    int Id = (int)row[0];
                    string Name = (string)row[1];
                    string cusFio = (string)row[2];
                    string empFio = (string)row[3];
                    string Email = (string)row[4];
                    string Phone = (string)row[5];
                    DateTime date = (DateTime)row[6];
                    TimeSpan time = TimeSpan.Parse(row[7].ToString());
                    int status = (int)row[8];
                    AppointmentUC appointment = new AppointmentUC(Id,Name, cusFio, empFio, Email,
                        Phone, date, time, status);
                    AppointmentsPanel.Controls.Add(appointment);
                }

                appointmentsCountLabel.Text = $"Всего записей: {AppointmentsDt.Rows.Count}";
            }
            catch (Exception ex)
            {
                this.Close();      
                MessageBox.Show(ex.Message, "Записи на сегодня и завтра не найдены");
            }

            if (AppointmentsDt.Rows.Count == 0)
            {
                this.Close();
                MessageBox.Show("Записи на сегодня и завтра не найдены");
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            appointmentDisplay();
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)            
                appointmentDisplay();            
        }

        private void AppointmentsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
