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
using System.Security.Cryptography;

namespace UslugiAutoservisa
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        MySqlConnection connection = sqlClass.Connection;
        private void LogInBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (loginTextBox.Text.Length != 0 &&
                (employeeRb.Checked && PwdOrBirthTextBox.Text.Length != 0) ||
                CustomerRb.Checked)
                {
                    string pwd = CreateMD5(PwdOrBirthTextBox.Text);
                    string sqlString = "";
                    if (employeeRb.Checked)
                        sqlString += "Select * from сотрудники where Email =" +
                            $"'{loginTextBox.Text}' and Пароль = '{pwd}'";

                    else
                        sqlString += "Select * from Клиенты where Email =" +
                                $"'{loginTextBox.Text}' and `Дата рождения` = " +
                                $"'{birthDtp.Value.ToString("yyyy-MM-dd")}'";


                    MySqlCommand cmd = new MySqlCommand(sqlString, connection);
                    connection.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            Program.isAuthorized = true;
                            while (dr.Read())
                            {
                                Program.id = (int)dr.GetValue(0);
                                Program.lastName = dr["Фамилия"].ToString();
                                Program.firstName = dr["Имя"].ToString();
                                Program.patronymicName = dr["Отчество"].ToString();

                                if (employeeRb.Checked)
                                    Program.position = Convert.ToInt32(dr["Должность"]);

                                if (CustomerRb.Checked)
                                    Program.position = 2;

                                if (Convert.ToInt16(dr["Подтверждение"]) == 1)
                                    Program.checkAccount = true;
                                else
                                    Program.checkAccount = false;

                                this.DialogResult = DialogResult.OK;
                            }
                        }
                        else
                            MessageBox.Show("Введены не верные данные");
                    }
                    connection.Close();
                }
                else
                    MessageBox.Show("Не все данные введены");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void SignUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }

        private void employeeRb_CheckedChanged(object sender, EventArgs e)
        {
            if (employeeRb.Checked)
            {
                PwdOrBirthLabel.Text = "Пароль:";
                showPasswordLabel.Text = "Показать пароль";
                PwdOrBirthTextBox.PasswordChar = '*';
                showPasswordLabel.Visible = true;
                birthDtp.Visible = false;
                PwdOrBirthTextBox.Visible = true;

            }
            else
            {
                PwdOrBirthLabel.Text = "Дата рождения:";
                PwdOrBirthTextBox.PasswordChar = '\0';
                PwdOrBirthTextBox.Visible = false;
                birthDtp.Visible = true;
                showPasswordLabel.Visible = false;
            }
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void showPasswordLabel_Click(object sender, EventArgs e)
        {
            if(showPasswordLabel.Text == "Показать пароль")
            {
                PwdOrBirthTextBox.PasswordChar = '\0';
                showPasswordLabel.Text = "Скрыть пароль";
            }
            else
            {
                PwdOrBirthTextBox.PasswordChar = '*';
                showPasswordLabel.Text = "Показать пароль";
            }            
        }

        public static string CreateMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes($"abc{input}def");
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
