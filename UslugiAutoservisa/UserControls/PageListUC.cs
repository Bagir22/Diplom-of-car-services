using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UslugiAutoservisa
{
    public partial class pageListUC : UserControl
    {
        private int _currentPage;
        private int _countPages;

        public delegate void CallFormMethod(object obj, int page);
        public event CallFormMethod onLinkLabelClick;
        public pageListUC(int currentPage, int countPage)
        {
            InitializeComponent();

            _currentPage = currentPage;
            _countPages = countPage;

            int step = 8;
            for (int i = 1; i < _countPages + 1; i++)
            {
                int size = 0;
                if (i < 10)
                    size = 8;
                else
                    size = 15;
                LinkLabel linkLabel = new LinkLabel
                {
                    Text = i.ToString(),
                    Name = i.ToString(),
                    Font = new Font("Verdana",
                            8, FontStyle.Regular,
                            GraphicsUnit.Point, ((byte)(204))),
                    Location = new Point(step, 4),
                    LinkColor = Color.Black,
                    Visible = true,
                    Size = new Size(size,15)
                };
                linkLabel.BringToFront();
                linkLabel.Click += new EventHandler(lebel_Click);
                if (i < 10)
                {
                    step += 8;
                    if (i != _countPages)
                        this.Size = new Size(this.Width += 8, this.Size.Height);
                }
                else if (i >= 10)
                {
                    step += 15;
                    if (i != _countPages)
                        this.Size = new Size(this.Width += 20, this.Size.Height);
                }
                this.Controls.Add(linkLabel);
                 
                              
            }            
        }

        private void lebel_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(sender.ToString().Split(':')[1]);
            onLinkLabelClick(sender, page);
        }

        private void pageListUC_Load(object sender, EventArgs e)
        {
            
        }

        private void ForwardLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_currentPage != _countPages)
            {
                ++_currentPage;
                onLinkLabelClick(this,_currentPage);
            }                
        }

        private void BackLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_currentPage != 1)
            {
                --_currentPage;
                onLinkLabelClick(this, _currentPage);
            }                         
        }
    }
}
