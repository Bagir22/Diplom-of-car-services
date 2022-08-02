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
    public partial class CustomersForm : Form
    {
        MySqlConnection connection = sqlClass.Connection;
        MySqlCommand command = null;
        MySqlDataAdapter adapter = null;
        DataTable customersDt = new DataTable();
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            customersDisplay();
        }

        void customersDisplay()
        {
            customersDt.Rows.Clear();
            customersPanel.Controls.Clear();

            string sqlString = "SELECT id, concat(Фамилия, ' ', Имя, ' ', Отчество) as фио, " +
                "Пол, Телефон, `Дата рождения`, Email, " +
                "`Дата регистрации`, Подтверждение FROM клиенты ";

            if (ConfirmCustomersRb.Checked == true)
                sqlString += "where Подтверждение = 1 ";
            else if (notConfirmCustomersRb.Checked == true)
                sqlString += "where Подтверждение = 0 ";

            if (SearchTextBox.Text != "")
                if (allCustomersRb.Checked == true)
                    sqlString += $"where concat(Фамилия, ' ', Имя, ' ', Отчество) like '%{SearchTextBox.Text}%' " +
                        $"or Телефон like '%{SearchTextBox.Text}%' " +
                        $"or Email like '%{SearchTextBox.Text}%' ";

            adapter = new MySqlDataAdapter(sqlString, connection);
            adapter.Fill(customersDt);

            if (customersDt.Rows.Count != 0)
            {
                foreach (DataRow row in customersDt.Rows)
                {
                    try
                    {
                        int id = (int)row[0];
                        string fio = (string)row["фио"];
                        string gender = (string)row["пол"];
                        string phone = (string)row["телефон"];
                        DateTime birth = Convert.ToDateTime(row["Дата рождения"]);
                        string email = (string)row["email"];
                        DateTime regDate = Convert.ToDateTime(row["Дата регистрации"]);
                        bool accConfirm = (bool)row["Подтверждение"];

                        CustomerUC employee = new CustomerUC(id, fio, gender, phone,
                            email, birth, accConfirm, regDate);
                        customersPanel.Controls.Add(employee);
                    }
                    catch
                    {

                    }
                }
                customersCountLabel.Text = $"Всего клиентов: {customersDt.Rows.Count}";
            }                
            else
            {
                MessageBox.Show("Клиентов с такими данными не найдено");
                SearchTextBox.Text = "";
                allCustomersRb.Checked = true;
                customersDisplay();
            }
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                customersDisplay();
            }
        }

        private void allCustomersRb_CheckedChanged(object sender, EventArgs e)
        {
            customersDisplay();
        }

        private void ConfirmCustomersRb_CheckedChanged(object sender, EventArgs e)
        {
            customersDisplay();
        }

        private void notConfirmCustomersRb_CheckedChanged(object sender, EventArgs e)
        {
            customersDisplay();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
