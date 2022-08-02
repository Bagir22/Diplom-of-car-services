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
    public partial class EmployeesForm : Form
    {
        MySqlConnection connection = sqlClass.Connection;
        MySqlCommand command = null;
        MySqlDataAdapter adapter = null;
        DataTable employeesDt = new DataTable();
        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void emloyeesForm_Load(object sender, EventArgs e)
        {
            employeesDisplay();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        void employeesDisplay()
        {
            employeesDt.Rows.Clear();
            employeesPanel.Controls.Clear();

            string sqlString = "SELECT ﻿id, concat(Фамилия, Имя, Отчество) as фио, " +
                "пол, Телефон, `Дата рождения`, Email, " +
                "`Дата регистрации`, Подтверждение, Роль FROM сотрудники " +
                "inner join `роли пользователей` on сотрудники.Должность = `роли пользователей`.`ID роли` ";

            if (ConfirmEmployessRb.Checked == true)
                sqlString += "where Подтверждение = 1 ";
            else if (notConfirmEmployeesRb.Checked == true )
                sqlString += "where Подтверждение = 0 ";

            if (SearchTextBox.Text != "")
                if (allEmployeesRb.Checked == true)
                    sqlString += $"where concat(Фамилия, Имя, Отчество) like '%{SearchTextBox.Text}%' " +
                        $"or Телефон like '%{SearchTextBox.Text}%' " +
                        $"or Email like '%{SearchTextBox.Text}%' ";

            adapter = new MySqlDataAdapter(sqlString, connection);
            adapter.Fill(employeesDt);

            if(employeesDt.Rows.Count != 0)
                foreach (DataRow row in employeesDt.Rows)
                {
                    int id = Convert.ToInt32(row["﻿id"]);
                    string fio = (string)row["фио"];
                    string gender = (string)row["пол"];
                    string phone = (string)row["телефон"];
                    DateTime birth = Convert.ToDateTime(row["Дата рождения"]);
                    string email = (string)row["email"];
                    string position = (string)row["Роль"];
                    DateTime regDate = Convert.ToDateTime(row["Дата регистрации"]);
                    bool accConfirm = (bool)row["Подтверждение"];

                    EmployeeUC employee = new EmployeeUC(id, fio, gender, phone,
                        email, birth, position, accConfirm, regDate);
                    employeesPanel.Controls.Add(employee);
                }
            else
            {
                MessageBox.Show("Сотрудников с такими данными не найдено");
                SearchTextBox.Text = "";
                allEmployeesRb.Checked = true;
                employeesDisplay();
            }
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                employeesDisplay();
            }            
        }

        private void allEmployeesRb_CheckedChanged(object sender, EventArgs e)
        {
            employeesDisplay();
        }

        private void ConfirmEmployessRb_CheckedChanged(object sender, EventArgs e)
        {
            employeesDisplay();
        }

        private void notConfirmEmployeesRb_CheckedChanged(object sender, EventArgs e)
        {
            employeesDisplay();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
