namespace UslugiAutoservisa
{
    partial class CustomersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.allCustomersRb = new System.Windows.Forms.RadioButton();
            this.notConfirmCustomersRb = new System.Windows.Forms.RadioButton();
            this.ConfirmCustomersRb = new System.Windows.Forms.RadioButton();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.customersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.customersCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // allCustomersRb
            // 
            this.allCustomersRb.AutoSize = true;
            this.allCustomersRb.Checked = true;
            this.allCustomersRb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allCustomersRb.Location = new System.Drawing.Point(301, 12);
            this.allCustomersRb.Name = "allCustomersRb";
            this.allCustomersRb.Size = new System.Drawing.Size(57, 21);
            this.allCustomersRb.TabIndex = 44;
            this.allCustomersRb.TabStop = true;
            this.allCustomersRb.Text = "Все";
            this.allCustomersRb.UseVisualStyleBackColor = true;
            this.allCustomersRb.CheckedChanged += new System.EventHandler(this.allCustomersRb_CheckedChanged);
            // 
            // notConfirmCustomersRb
            // 
            this.notConfirmCustomersRb.AutoSize = true;
            this.notConfirmCustomersRb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notConfirmCustomersRb.Location = new System.Drawing.Point(301, 45);
            this.notConfirmCustomersRb.Name = "notConfirmCustomersRb";
            this.notConfirmCustomersRb.Size = new System.Drawing.Size(162, 21);
            this.notConfirmCustomersRb.TabIndex = 43;
            this.notConfirmCustomersRb.Text = "Не подтвержден";
            this.notConfirmCustomersRb.UseVisualStyleBackColor = true;
            this.notConfirmCustomersRb.CheckedChanged += new System.EventHandler(this.notConfirmCustomersRb_CheckedChanged);
            // 
            // ConfirmCustomersRb
            // 
            this.ConfirmCustomersRb.AutoSize = true;
            this.ConfirmCustomersRb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmCustomersRb.Location = new System.Drawing.Point(301, 28);
            this.ConfirmCustomersRb.Name = "ConfirmCustomersRb";
            this.ConfirmCustomersRb.Size = new System.Drawing.Size(138, 21);
            this.ConfirmCustomersRb.TabIndex = 42;
            this.ConfirmCustomersRb.Text = "Подтвержден";
            this.ConfirmCustomersRb.UseVisualStyleBackColor = true;
            this.ConfirmCustomersRb.CheckedChanged += new System.EventHandler(this.ConfirmCustomersRb_CheckedChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(11, 26);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(62, 17);
            this.SearchLabel.TabIndex = 41;
            this.SearchLabel.Text = "Поиск:";
            // 
            // customersPanel
            // 
            this.customersPanel.AutoScroll = true;
            this.customersPanel.Location = new System.Drawing.Point(14, 81);
            this.customersPanel.Name = "customersPanel";
            this.customersPanel.Size = new System.Drawing.Size(482, 461);
            this.customersPanel.TabIndex = 39;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.SearchTextBox.Location = new System.Drawing.Point(13, 45);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(281, 24);
            this.SearchTextBox.TabIndex = 40;
            this.SearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyDown);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.LightYellow;
            this.BackBtn.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackBtn.Location = new System.Drawing.Point(439, 549);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(57, 21);
            this.BackBtn.TabIndex = 45;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // customersCountLabel
            // 
            this.customersCountLabel.AutoSize = true;
            this.customersCountLabel.Location = new System.Drawing.Point(11, 552);
            this.customersCountLabel.Name = "customersCountLabel";
            this.customersCountLabel.Size = new System.Drawing.Size(144, 17);
            this.customersCountLabel.TabIndex = 46;
            this.customersCountLabel.Text = "Всего клиентов: ";
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 575);
            this.Controls.Add(this.customersCountLabel);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.allCustomersRb);
            this.Controls.Add(this.notConfirmCustomersRb);
            this.Controls.Add(this.ConfirmCustomersRb);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.customersPanel);
            this.Controls.Add(this.SearchTextBox);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CustomersForm";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton allCustomersRb;
        private System.Windows.Forms.RadioButton notConfirmCustomersRb;
        private System.Windows.Forms.RadioButton ConfirmCustomersRb;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.FlowLayoutPanel customersPanel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label customersCountLabel;
    }
}