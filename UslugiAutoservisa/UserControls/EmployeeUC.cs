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
    public partial class EmployeeUC : UserControl
    {
        MySqlConnection connection = sqlClass.Connection;
        MySqlCommand command;

        int employeeId;
        string FIO;
        string employeePhone;
        string employeeEmail;
        DateTime birth;
        string employeePosition;
        string employeeGender;
        bool confirm;
        DateTime registrationDate;
        public EmployeeUC(int id, string Fio,string gender, string phone,
            string email, DateTime birthDate, string position, 
            bool acc_confirm, DateTime regDate)
        {
            InitializeComponent();
            employeeId = id;
            FIO = Fio;
            employeeGender = gender;
            employeePhone = phone;
            employeeEmail = email;
            birth = birthDate;         
            employeePosition = position;
            confirm = acc_confirm;
            registrationDate = regDate;
        }

        private void EmployeeUC_Load(object sender, EventArgs e)
        {
            birthDtp.MaxDate = DateTime.Now;
            fioTextBox.Text = FIO;
            if (employeeGender.ToUpper() == "М")
            {
                genderCmb.SelectedIndex = 0;                
            }                
            else if (employeeGender.ToUpper() == "Ж")
            {
                genderCmb.SelectedIndex = 1;                
            }
            phoneTextBox.Text = employeePhone;
            emailTextBox.Text = employeeEmail;
            birthDtp.Value = birth;
            positionTextBox.Text = employeePosition;
            regDateDtp.Value = registrationDate;
            if (confirm)
                accConfirmCmb.SelectedIndex = 0;
            else
                accConfirmCmb.SelectedIndex = 1;             
        }

        bool someChanges()
        { 
            if (fioTextBox.Text != FIO |
                phoneTextBox.Text != employeePhone |                
                emailTextBox.Text != employeeEmail |
                birthDtp.Value != birth |
                positionTextBox.Text != employeePosition |
                (genderCmb.SelectedIndex == 0 && employeeGender.ToUpper() == "Ж") |                
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

        private void fioTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            someChanges();
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

        private void positionTextBox_TextChanged(object sender, EventArgs e)
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

        private void regDateDtp_KeyDown(object sender, KeyEventArgs e)
        {
            someChanges();
        }

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            if (someChanges())
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

                    string sqlString = "UPDATE `сотрудники` SET " +
                        $"`Фамилия` = '{secondName}', " +
                        $"`Имя` = '{firstName}', " +
                        $"`Отчество` = '{patronymicName}', " +
                        $"`пол` = '{gender}', " +
                        $"`Телефон` = '{phoneTextBox.Text}', " +
                        $"`Дата рождения` = '{birthDtp.Value.ToString("yyyy-MM-dd")}', " +
                        $"`Email` = '{emailTextBox.Text}', " +
                        $"`Подтверждение` = '{confirm}' " +
                        $"WHERE (`﻿id` = '{employeeId}');";
                    command = new MySqlCommand(sqlString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();                                                       
                    connection.Close();

                    if (positionTextBox.Text != employeePosition)
                    {
                        if (positionTextBox.Text == "Администратор")
                            sqlString = "UPDATE `сотрудники` SET " +
                                $"`Должность` = '3' " +
                                $"WHERE (`﻿id` = '{employeeId}');";
                        else
                            sqlString = "UPDATE `сотрудники` SET " +
                                $"`Должность` = '3' " +
                                $"WHERE (`﻿id` = '{employeeId}');";
                        command = new MySqlCommand(sqlString, connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    MessageBox.Show("Данные сотрудника изменены");
                }
                catch
                {
                    MessageBox.Show("Не получилось изменить данные сотрудника");
                }
            }
        }
    }
}
