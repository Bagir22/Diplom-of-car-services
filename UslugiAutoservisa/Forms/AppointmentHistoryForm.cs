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
    public partial class AppointmentHistoryForm : Form
    {
        public AppointmentHistoryForm()
        {
            InitializeComponent();
        }

        MySqlDataAdapter adapter;
        MySqlDataReader reader;
        MySqlConnection connection = sqlClass.Connection;
        DataTable AppointmentsDt = new DataTable();

        int page = 1;
        int countPages = 1;

        private void AppointmentHistoryForm_Load(object sender, EventArgs e)
        {
            periodStart.Value = DateTime.Today.AddMonths(-1);
            periodEnd.Value = DateTime.Now;
            statusComboBox.SelectedIndex = 0;
            appointmentDisplay();
        }

        void appointmentDisplay(int page = 1)
        {
            try
            {
                if (periodStart.Value >= periodEnd.Value)
                {
                    MessageBox.Show("Не верный фильтр даты услуг");
                    periodStart.Value = DateTime.Today.AddMonths(-1);
                    periodEnd.Value = DateTime.Now;
                    appointmentDisplay();
                }

                AppointmentsPanel.Controls.Clear();
                AppointmentsDt.Clear();

                Control c = this.Controls.Find("pageListUC", true).FirstOrDefault();
                if (c != null)
                    this.Controls.Remove(c);

                using (connection)
                {
                    string StringSql = $"SELECT * FROM uslugiautoservisa.записинауслугиview " +                        
                        $"where (`Дата оказания услуги` between '{periodStart.Value.ToString("yyyy.MM.dd")}' " +
                        $"and '{periodEnd.Value.ToString("yyyy.MM.dd")}') ";

                        if (statusComboBox.SelectedIndex == 0)
                            StringSql += $"and (`Статус` = 4 or `Статус` = 5) ";
                        else if (statusComboBox.SelectedIndex == 1)
                            StringSql += $"and `Статус` = 4 ";
                        else
                            StringSql += $"and `Статус` = 5 ";

                        if (SearchTextBox.Text.Length != 0)
                            StringSql += $" and (`Наименование услуги` like '%{SearchTextBox.Text}%' " +
                                $"or `фио клиента` like '%{SearchTextBox.Text}%') ";

                        if (Program.position == 2)
                        {
                            string fio = $"{Program.lastName}{Program.firstName}{Program.patronymicName}";
                            StringSql += $" and `фио клиента` like '%{fio}%' ";
                        }                    

                    StringSql += $"order by concat(`Дата оказания услуги`, ' ',`Время оказания услуги`); "; ;
                    
                    using (adapter = new MySqlDataAdapter(StringSql, connection))
                    {
                        adapter.Fill(AppointmentsDt);
                    }
                }

                if (AppointmentsDt.Rows.Count % 10 == 0)
                    countPages = AppointmentsDt.Rows.Count / 10;
                else
                    countPages = AppointmentsDt.Rows.Count / 10 + 1;
                pageListUC pageListUC = new pageListUC(page, countPages);
                pageListUC.Location = new Point(15, 482);
                this.Controls.Add(pageListUC);
                pageListUC.onLinkLabelClick += new pageListUC.CallFormMethod(pageListUC_onlinkLabelClick);

                if (AppointmentsDt.Rows.Count != 0)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        try
                        {
                            DataRow row = AppointmentsDt.Rows[(page - 1) * 10 + i];
                            int Id = (int)row[0];
                            string Name = (string)row[1];
                            string cusFio = (string)row[2];
                            string empFio = (string)row[3];
                            string Email = (string)row[4];
                            string Phone = (string)row[5];
                            DateTime date = (DateTime)row[6];
                            TimeSpan time = TimeSpan.Parse(row[7].ToString());
                            int status = (int)row[8];
                            AppointmentUC appointment = new AppointmentUC(Id, Name, cusFio,
                                empFio, Email,
                                Phone, date, time, status);
                            AppointmentsPanel.Controls.Add(appointment);                            
                        }
                        catch (Exception ex)
                        {
                            
                        }
                    }                    
                }
                currentPage.Text = $"Страница: {page}/{countPages}";
                appointmentsCountLabel.Text = $"Всего записей:" +
                    $" {AppointmentsDt.Rows.Count}";
            }
            catch
            {

            }

            if (AppointmentsDt.Rows.Count == 0)
            {                
                MessageBox.Show("Записи на это период не найдены");
            }
        }      

        private void periodStart_ValueChanged(object sender, EventArgs e)
        {
            page = 1;
            appointmentDisplay(page);
        }

        private void periodEnd_ValueChanged(object sender, EventArgs e)
        {
            page = 1;
            appointmentDisplay(page);
        }

        void pageListUC_onlinkLabelClick(object obj, int page)
        {
            appointmentDisplay(page);
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                page = 1;
                appointmentDisplay(page);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            page = 1;
            appointmentDisplay(page);
        }
    }
}
