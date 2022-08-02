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
    public partial class PartsTypeControlForm : Form
    {
        MySqlDataReader reader;
        MySqlDataAdapter adapter;
        MySqlCommand command;
        DataTable PartsDt = new DataTable();
        MySqlConnection connection = sqlClass.Connection;
        public PartsTypeControlForm()
        {
            InitializeComponent();
        }

        private void PartsTypeControlBtn_Load(object sender, EventArgs e)
        {
            string sqlString = "SELECT Тип FROM uslugiautoservisa.`типы запчастей`;";
            command = new MySqlCommand(sqlString, connection);
            adapter = new MySqlDataAdapter(command);
            adapter.Fill(PartsDt);

            partsTypeTable.DataSource = PartsDt;
        }
    }
}
