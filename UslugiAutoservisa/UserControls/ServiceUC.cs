using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace UslugiAutoservisa
{
    public partial class ServiceUC : UserControl
    {
        MySqlCommand Command;
        MySqlDataReader Reader;
        int ServiceId;
        string ServiceText;
        int TimeValue;
        int PriceValue;        
        string ImageLocationText;
        public ServiceUC(int serId,string Service, int Time,int Price, string ImageLocation)
        {
            InitializeComponent();
            TimeValue = Time;
            ServiceText = Service;
            PriceValue = Price;            
            ImageLocationText = ImageLocation;
            ServiceId = serId;
        }

        private void ServiceUC_Load(object sender, EventArgs e)
        {
            this.Font = new Font("Verdana", 8);
            Service.Text = ServiceText;         
            FullPrice.Text = $"{PriceValue} рублей за {TimeValue} минут";
            ServiceImage.ImageLocation = $@"{Directory.GetCurrentDirectory()}\Images\{ImageLocationText}";

            if (Program.position == 1 || !Program.checkAccount)
            {
                makeAppointmentBtn.Enabled = false;
                editServiceBtn.Enabled = false;
            }                        
            if (Program.position == 2 && Program.checkAccount)            
                editServiceBtn.Enabled = false;     
        }

        private void ServiceUC_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void makeAppointmentBtn_Click(object sender, EventArgs e)
        {
            makeAppointmentForm form = new makeAppointmentForm(ServiceId, Program.id);
            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Клиент записан");
            }
        }

        private void editServiceBtn_Click(object sender, EventArgs e)
        {
            AddServiceForm form = new AddServiceForm(editServiceBtn, ServiceId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void ServiceImage_DoubleClick(object sender, EventArgs e)
        {
            AdditionalServiceImagesForm form = new AdditionalServiceImagesForm(ServiceId, ServiceText);
            form.ShowDialog();
        }

        private void ServiceImage_Click(object sender, EventArgs e)
        {

        }
    }
}
