using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UslugiAutoservisa
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        static public int id = 0;
        static public bool isAuthorized;
        static public string lastName;
        static public string firstName; 
        static public string patronymicName;
        static public int position = 0;
        static public bool checkAccount;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
