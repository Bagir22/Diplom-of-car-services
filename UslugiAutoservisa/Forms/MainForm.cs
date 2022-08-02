using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UslugiAutoservisa
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        MySqlDataAdapter adapter;
        MySqlConnection connection = sqlClass.Connection;
        DataTable ServicesDt = new DataTable();
        string imagesFolder = Directory.GetCurrentDirectory();
        public static string serviceName;
        int page = 1;
        int countPages = 1;
        private void MainForm_Load(object sender, EventArgs e)
        {            
            SortComboBox.SelectedIndex = 0;
            checkAuth();
            servicesDisplay();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!checkAuth())
            {
                LogInForm logInForm = new LogInForm();
                if (logInForm.ShowDialog() == DialogResult.OK)
                {
                    checkAuth();
                    servicesDisplay();
                }
            }    
            else
            {
                Program.isAuthorized = false;
                Program.lastName = "";
                Program.firstName = "";
                Program.patronymicName = "";
                Program.position = 0;
                checkAuth();
                servicesDisplay();
            }
        }

        bool checkAuth()
        {
            if (Program.isAuthorized == true)
            {
                userInfoGroupBox.Visible = true;
                LoginButton.Text = "Выход";
                lastNameLabel.Text = Program.lastName;
                firstNameLabel.Text = Program.firstName;
                patronymicNameLabel.Text = Program.patronymicName;
                if (Program.position == 0 || Program.checkAccount == false)
                {
                    userPositionLabel.Text = "Не подтвержденный\nаккаунт";
                }
                if (Program.position == 2 && Program.checkAccount == true)
                {
                    userPositionLabel.Text = "Клиент";
                    appointmentsBtn.Visible = true;
                    AppointmentHistroryBtn.Visible = true;
                }                    
                if (Program.position == 3 && Program.checkAccount == true)
                {
                    userPositionLabel.Text = "Сотрудник";
                    appointmentsBtn.Visible = true;
                    AppointmentHistroryBtn.Visible = true;
                    customersFormBtn.Visible = true;                    
                }
                if (Program.position == 4 && Program.checkAccount == true)
                {
                    userPositionLabel.Text = "Администратор";
                    appointmentsBtn.Visible = true;
                    customersFormBtn.Visible = true;
                    employeesBtn.Visible = true;
                    addServiceBtn.Visible = true;
                    AppointmentHistroryBtn.Visible = true;
                    PartsStorageBtn.Visible = true;
                }

                return true;
            }
            else
            {
                addServiceBtn.Visible = false;
                userInfoGroupBox.Visible = false;
                LoginButton.Text = "Вход";
                appointmentsBtn.Visible = false;
                customersFormBtn.Visible = false;
                employeesBtn.Visible = false;
                AppointmentHistroryBtn.Visible = false;
                PartsStorageBtn.Visible = false;
                return false;
            }
        }

        void servicesDisplay(int page = 1)
        {
            servicesPanel.Controls.Clear();
            ServicesDt.Clear();

            Control c = this.Controls.Find("pageListUC", true).FirstOrDefault();
            if (c != null)
                this.Controls.Remove(c);
            
            string SqlString = "SELECT * from услуги ";



            if (SearchTextBox.Text.Length != 0)    
                SqlString += $"where (`Наименование услуги` like '%{SearchTextBox.Text}%' " +
                    $"or `Описание услуги` like '%{SearchTextBox.Text}%')";          
            
            if (SortComboBox.SelectedIndex == 1)
                SqlString += $" order by `Стоимость(руб)` ASC";
            else if (SortComboBox.SelectedIndex == 2)
                SqlString += $" order by `Стоимость(руб)` DESC";

            adapter = new MySqlDataAdapter(SqlString, connection);
            adapter.Fill(ServicesDt);

            if(ServicesDt.Rows.Count%10 == 0)
                countPages = ServicesDt.Rows.Count / 10;
            else
                countPages = ServicesDt.Rows.Count / 10 + 1;
            pageListUC pageListUC = new pageListUC(page, countPages);
            pageListUC.Location = new Point(12, 455);
            this.Controls.Add(pageListUC);
            pageListUC.onLinkLabelClick += new pageListUC.CallFormMethod(pageListUC_onlinkLabelClick);

            if (ServicesDt.Rows.Count != 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    try
                    {
                        DataRow row = ServicesDt.Rows[(page - 1) * 10 + i];
                        int ServiceID = (int)row[0];
                        string ServiceText = row[1].ToString();
                        int TimeValue = (int)row[3];
                        int PriceValue = (int)row[4];
                        string ImageLocation = row[2].ToString();
                        ServiceUC service = new ServiceUC(ServiceID, ServiceText, TimeValue,
                            PriceValue, ImageLocation);
                        servicesPanel.Controls.Add(service);                       
                    }
                    catch
                    {

                    }
                    currentPage.Text = $"Страница: {page}/{countPages}";
                }
                servicesCountLabel.Text = $"Всего услуг:" +
                    $" {ServicesDt.Rows.Count}";
            }
            else
            {
                MessageBox.Show("Услуги не найдены");
                SearchTextBox.Text = "";                
                SortComboBox.SelectedIndex = 0;
                servicesDisplay();
            }
        }

        void checkAllComboBoxes()
        {
            if (SortComboBox.SelectedIndex != -1)
            {
                //page = 1;
                //render(page);
                servicesDisplay();
            }
        }
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            //Долго грузиться
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkAllComboBoxes();
        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkAllComboBoxes();
        }

        void pageListUC_onlinkLabelClick(object obj, int page)
        {
            servicesDisplay(page);
        }
        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                servicesDisplay();
            }
        }

        private void appointmentsBtn_Click(object sender, EventArgs e)
        {
            AppointmentForm form = new AppointmentForm();
            form.ShowDialog();
        }

        private void addServiceBtn_Click(object sender, EventArgs e)
        {
            AddServiceForm form = new AddServiceForm(addServiceBtn);
            form.ShowDialog();

        }

        private void AppointmentHistroryBt_Click(object sender, EventArgs e)
        {
            AppointmentHistoryForm form = new AppointmentHistoryForm();
            form.ShowDialog();
        }

        private void employeesBtn_Click(object sender, EventArgs e)
        {
            EmployeesForm form = new EmployeesForm();
            if (form.ShowDialog() == DialogResult.Cancel)
                checkAuth();
        }

        private void customersFormBtn_Click(object sender, EventArgs e)
        {
            CustomersForm form = new CustomersForm();
            if (form.ShowDialog() == DialogResult.Cancel)            
                checkAuth();                         
        }

        private void servicesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PartsStorageBtn_Click(object sender, EventArgs e)
        {
            StoragePartsForm form = new StoragePartsForm();
            form.ShowDialog();
        }
    }
}
