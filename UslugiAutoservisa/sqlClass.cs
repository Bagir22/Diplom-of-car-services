using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace UslugiAutoservisa
{
    static class sqlClass
    {
        static string path = "server = localhost;port = 3306;user = root; password = root; database = uslugiautoservisa;";

        static public MySqlConnection Connection = new MySqlConnection(path);
    }
}
