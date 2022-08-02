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
    public partial class CustomerUC : UserControl
    {
        MySqlConnection connection = sqlClass.Connection;
        MySqlCommand command;

        int customerId;
        string FIO;
        string customerPhone;
        string customerEmail;
        DateTime birth;        
        string customerGender;
        bool confirm;
        DateTime registrationDate;
        public CustomerUC(int id, string Fio, string gender, string phone,
            string email, DateTime birthDate,
            bool acc_confirm, DateTime regDate)
        {
            InitializeComponent();
            customerId = id;
            FIO = Fio;
            customerGender = gender;
            customerPhone = phone;
            customerEmail = email;
            birth = birthDate;            
            confirm = acc_confirm;
            registrationDate = regDate;
        }

        private void CustomerUC_Load(object sender, EventArgs e)
        {
            birthDtp.MaxDate = DateTime.Now;
            fioTextBox.Text = FIO;
            if (customerGender.ToUpper() == "М")
            {
                genderCmb.SelectedIndex = 0;
            }
            else if (customerGender.ToUpper() == "Ж")
            {
                genderCmb.SelectedIndex = 1;
            }
            phoneTextBox.Text = customerPhone;
            emailTextBox.Text = customerEmail;
            birthDtp.Value = birth;            
            regDateDtp.Value = registrationDate;
            if (confirm)
                accConfirmCmb.SelectedIndex = 0;
            else
                accConfirmCmb.SelectedIndex = 1;
        }

        bool someChanges()
        {
            if (fioTextBox.Text != FIO |
                phoneTextBox.Text != customerPhone |
                emailTextBox.Text != customerEmail |
                birthDtp.Value != birth |                
                (genderCmb.SelectedIndex == 0 && customerGender.ToUpper() == "Ж") |
                (accConfirmCmb.SelectedIndex == 1 && confirm))
            {
                saveChangesBtn.Visible = true;
                return true;
            }
            else
            {
                saveChangesBtn.Visible = false;
                return false;
            }
        }

        private void fioTextBox_TextChanged(object sender, EventArgs e)
        {
            someChanges();
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            someChanges();
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            someChanges();
        }

        private void birthDtp_ValueChanged(object sender, EventArgs e)
        {
            someChanges();
        }

        private void regDateDtp_ValueChanged(object sender, EventArgs e)
        {
            someChanges();
        }

        private void accConfirmCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            someChanges();
        }

        private void genderCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            someChanges();
        }

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            if(someChanges())
            {
                try
                {
                    string firstName = fioTextBox.Text.Split(' ')[1];
                    string secondName = fioTextBox.Text.Split(' ')[0];
                    string patronymicName = fioTextBox.Text.Split(' ')[2];
                    string gender = "", confirm = "";

                    if (genderCmb.SelectedIndex == 0)
                        gender = "м";
                    else
                        gender = "ж";

                    if (accConfirmCmb.SelectedIndex == 0)
                        confirm = "1";
                    else
                        confirm = "0";

                    string sqlString = "UPDATE `клиенты` SET " +
                        $"`Фамилия` = '{secondName}', " +
                        $"`Имя` = '{firstName}', " +
                        $"`Отчество` = '{patronymicName}', " +
                        $"`пол` = '{gender}', " +
                        $"`Телефон` = '{phoneTextBox.Text}', " +
                        $"`Дата рождения` = '{birthDtp.Value.ToString("yyyy-MM-dd")}', " +
                        $"`Email` = '{emailTextBox.Text}', " +
                        $"`Подтверждение` = '{confirm}' " +
                        $"WHERE (id = '{customerId}');";
                    command = new MySqlCommand(sqlString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                
                    MessageBox.Show("Данные клиента изменены");
                }
                catch
                {
                    MessageBox.Show("Не получилось изменить данные сотрудника");
                }
            }
        }
    }
}
