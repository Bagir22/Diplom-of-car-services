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
    public partial class StoragePartsForm : Form
    {
        MySqlDataAdapter adapter;
        MySqlDataReader reader;
        MySqlCommand command;
        MySqlConnection connection = sqlClass.Connection;
        DataTable PartsDt = new DataTable();
        string sqlString;

        public StoragePartsForm()
        {
            InitializeComponent();

            PartsDt.Rows.Clear();
            partsTable.Rows.Clear();

            SortComboBox.Items.Add("Все");
            sqlString = "SELECT * FROM uslugiautoservisa.`типы запчастей`";
            command = new MySqlCommand(sqlString, connection);
            connection.Open();
            reader = command.ExecuteReader();            
            if (reader.HasRows)
                while (reader.Read())
                {
                    SortComboBox.Items.Add(reader.GetValue(1).ToString());
                }
            connection.Close();
            SortComboBox.SelectedIndex = 0;

            sqlString = "SELECT * FROM uslugiautoservisa.запчастиview;";
            adapter = new MySqlDataAdapter(sqlString, connection);
            adapter.Fill(PartsDt);
            if(PartsDt.Rows.Count != 0)
            {
                partsTable.DataSource = PartsDt;                
            }
            else
            {
                MessageBox.Show("Запчасти не найдены");
                SortComboBox.SelectedIndex = 0;
;            }

        }

        private void StoragePartsForm_Load(object sender, EventArgs e)
        {

        }

        private void PartsTypeControlBtn_Click(object sender, EventArgs e)
        {
            PartsTypeControlForm form = new PartsTypeControlForm();
            form.ShowDialog();
        }
    }
}
