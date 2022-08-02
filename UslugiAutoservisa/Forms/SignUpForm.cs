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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        MySqlConnection connection = sqlClass.Connection;
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (LastNameTextBox.Text.Length != 0 && LastNameTextBox.Text.Length != 0
                && PatronymicTextBox.Text.Length != 0 && emailTextBox.Text.Length != 0
                && phoneTextBox.Text.Length == 13 && genderComboBox.SelectedIndex != -1)
                {
                    if (!IsValidEmail(emailTextBox.Text))
                        MessageBox.Show("Email введен не корректно");
                    if (employeeRb.Checked && PwdTextBox.Text.Length == 0)
                        MessageBox.Show("Пароль не введен");
                    if (employeeRb.Checked && positionTextBox.Text.Length == 0)
                        MessageBox.Show("Должность не введена");

                    string sqlString = createSqlstring();
                    MySqlCommand cmd = new MySqlCommand(sqlString, connection);
                    connection.Open();
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        if (employeeRb.Checked)
                            MessageBox.Show("Сотрудник добавлен");
                        else
                            MessageBox.Show("Клиент добавлен");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                        MessageBox.Show("Произошла ошибк при регистрации");
                    connection.Close();
                }
                else
                    MessageBox.Show("Не все данные введены");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Не получилось зарегистировать");
            }
        }

        string createSqlstring()
        {
            string sqlString = "";
            string pwd = CreateMD5(PwdTextBox.Text);
            if (employeeRb.Checked)
            {
                sqlString += "INSERT INTO `сотрудники` (`Фамилия`, `Имя`, " +
                    "`Отчество`, `пол`, `Телефон`, `Дата рождения`, " +
                    "`Email`, `Должность`, `Пароль`, " +
                    "`Дата регистрации`) VALUES " +
                    $"('{LastNameTextBox.Text}', '{FirstNameTextBox.Text}', " +
                    $"'{PatronymicTextBox.Text}', '{genderComboBox.SelectedItem}', " +
                    $"'{phoneTextBox.Text}', '{birthDtp.Value.ToString("yyyy-MM-dd")}', " +
                    $"'{emailTextBox.Text}', '{positionTextBox.Text}', " +
                    $"'{pwd}', '{DateTime.Now.Date.ToString("yyyy-MM-dd")}');";
            }
            else
            {
                sqlString += "INSERT INTO `клиенты` (`Фамилия`, `Имя`, " +
                    "`Отчество`, `Пол`, `Телефон`, `Дата рождения`, " +
                    "`Email`, `Дата регистрации`) VALUES " +
                    $"('{LastNameTextBox.Text}', '{FirstNameTextBox.Text}', " +
                    $"'{PatronymicTextBox.Text}', '{genderComboBox.SelectedItem}', " +
                    $"'{phoneTextBox.Text}', '{birthDtp.Value.ToString("yyyy-MM-dd")}', " +
                    $"'{DateTime.Now.Date.ToString("yyyy-MM-dd")}');";
            }

            return sqlString;
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
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


        private void employeeRb_CheckedChanged(object sender, EventArgs e)
        {
            if (employeeRb.Checked)
            {
                PwdLabel.Visible = true;
                PwdTextBox.PasswordChar = '*';
                PwdTextBox.Visible = true;
                showPasswordLabel.Visible = true;
                positionTextBox.Visible = true;
                positionLabel.Visible = true;
            }
            else
            {
                PwdLabel.Visible = false;
                PwdTextBox.Visible = false;
                showPasswordLabel.Visible = false;
                positionTextBox.Visible = false;
                positionLabel.Visible = false;
            }
        }

        private void showPasswordLabel_Click(object sender, EventArgs e)
        {
            if (showPasswordLabel.Text == "Показать пароль")
            {
                PwdTextBox.PasswordChar = '\0';
                showPasswordLabel.Text = "Скрыть пароль";
            }
            else
            {
                PwdTextBox.PasswordChar = '*';
                showPasswordLabel.Text = "Показать пароль";
            }
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void PwdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
