namespace UslugiAutoservisa
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.LogInBtn = new System.Windows.Forms.Button();
            this.SignUpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.employeeRb = new System.Windows.Forms.RadioButton();
            this.CustomerRb = new System.Windows.Forms.RadioButton();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PwdOrBirthLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.PwdOrBirthTextBox = new System.Windows.Forms.TextBox();
            this.showPasswordLabel = new System.Windows.Forms.Label();
            this.birthDtp = new System.Windows.Forms.DateTimePicker();
            this.logoPbox = new System.Windows.Forms.PictureBox();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPbox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogInBtn
            // 
            this.LogInBtn.BackColor = System.Drawing.Color.LightYellow;
            this.LogInBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogInBtn.Location = new System.Drawing.Point(165, 117);
            this.LogInBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(141, 35);
            this.LogInBtn.TabIndex = 0;
            this.LogInBtn.Text = "Вход";
            this.LogInBtn.UseVisualStyleBackColor = false;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // SignUpLinkLabel
            // 
            this.SignUpLinkLabel.AutoSize = true;
            this.SignUpLinkLabel.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignUpLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.SignUpLinkLabel.Location = new System.Drawing.Point(201, 156);
            this.SignUpLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SignUpLinkLabel.Name = "SignUpLinkLabel";
            this.SignUpLinkLabel.Size = new System.Drawing.Size(93, 14);
            this.SignUpLinkLabel.TabIndex = 1;
            this.SignUpLinkLabel.TabStop = true;
            this.SignUpLinkLabel.Text = "Регистрация";
            this.SignUpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUpLinkLabel_LinkClicked);
            // 
            // employeeRb
            // 
            this.employeeRb.AutoSize = true;
            this.employeeRb.Checked = true;
            this.employeeRb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeRb.Location = new System.Drawing.Point(12, 65);
            this.employeeRb.Name = "employeeRb";
            this.employeeRb.Size = new System.Drawing.Size(132, 24);
            this.employeeRb.TabIndex = 2;
            this.employeeRb.TabStop = true;
            this.employeeRb.Text = "Сотрудник";
            this.employeeRb.UseVisualStyleBackColor = true;
            this.employeeRb.CheckedChanged += new System.EventHandler(this.employeeRb_CheckedChanged);
            // 
            // CustomerRb
            // 
            this.CustomerRb.AutoSize = true;
            this.CustomerRb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerRb.Location = new System.Drawing.Point(12, 91);
            this.CustomerRb.Name = "CustomerRb";
            this.CustomerRb.Size = new System.Drawing.Size(98, 24);
            this.CustomerRb.TabIndex = 3;
            this.CustomerRb.Text = "Клиент";
            this.CustomerRb.UseVisualStyleBackColor = true;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(162, 11);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(146, 20);
            this.LoginLabel.TabIndex = 4;
            this.LoginLabel.Text = "Логин(Email):";
            // 
            // PwdOrBirthLabel
            // 
            this.PwdOrBirthLabel.AutoSize = true;
            this.PwdOrBirthLabel.Location = new System.Drawing.Point(162, 56);
            this.PwdOrBirthLabel.Name = "PwdOrBirthLabel";
            this.PwdOrBirthLabel.Size = new System.Drawing.Size(88, 20);
            this.PwdOrBirthLabel.TabIndex = 5;
            this.PwdOrBirthLabel.Text = "Пароль:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.BackColor = System.Drawing.Color.Ivory;
            this.loginTextBox.Location = new System.Drawing.Point(165, 30);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(141, 27);
            this.loginTextBox.TabIndex = 6;
            // 
            // PwdOrBirthTextBox
            // 
            this.PwdOrBirthTextBox.BackColor = System.Drawing.Color.Ivory;
            this.PwdOrBirthTextBox.Location = new System.Drawing.Point(165, 75);
            this.PwdOrBirthTextBox.Name = "PwdOrBirthTextBox";
            this.PwdOrBirthTextBox.PasswordChar = '*';
            this.PwdOrBirthTextBox.Size = new System.Drawing.Size(141, 27);
            this.PwdOrBirthTextBox.TabIndex = 7;
            // 
            // showPasswordLabel
            // 
            this.showPasswordLabel.AutoSize = true;
            this.showPasswordLabel.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showPasswordLabel.Location = new System.Drawing.Point(163, 101);
            this.showPasswordLabel.Name = "showPasswordLabel";
            this.showPasswordLabel.Size = new System.Drawing.Size(123, 14);
            this.showPasswordLabel.TabIndex = 8;
            this.showPasswordLabel.Text = "Показать пароль";
            this.showPasswordLabel.Click += new System.EventHandler(this.showPasswordLabel_Click);
            // 
            // birthDtp
            // 
            this.birthDtp.CalendarMonthBackground = System.Drawing.Color.Ivory;
            this.birthDtp.CalendarTrailingForeColor = System.Drawing.Color.Ivory;
            this.birthDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDtp.Location = new System.Drawing.Point(165, 75);
            this.birthDtp.MaxDate = new System.DateTime(2022, 4, 26, 0, 0, 0, 0);
            this.birthDtp.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.birthDtp.Name = "birthDtp";
            this.birthDtp.Size = new System.Drawing.Size(141, 27);
            this.birthDtp.TabIndex = 26;
            this.birthDtp.Value = new System.DateTime(2022, 4, 26, 0, 0, 0, 0);
            this.birthDtp.Visible = false;
            // 
            // logoPbox
            // 
            this.logoPbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoPbox.Image = global::UslugiAutoservisa.Properties.Resources.logo;
            this.logoPbox.Location = new System.Drawing.Point(12, 9);
            this.logoPbox.Name = "logoPbox";
            this.logoPbox.Size = new System.Drawing.Size(50, 50);
            this.logoPbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPbox.TabIndex = 27;
            this.logoPbox.TabStop = false;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.LightYellow;
            this.BackBtn.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackBtn.Location = new System.Drawing.Point(12, 129);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(57, 21);
            this.BackBtn.TabIndex = 28;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 175);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.logoPbox);
            this.Controls.Add(this.birthDtp);
            this.Controls.Add(this.showPasswordLabel);
            this.Controls.Add(this.PwdOrBirthTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.PwdOrBirthLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.CustomerRb);
            this.Controls.Add(this.employeeRb);
            this.Controls.Add(this.SignUpLinkLabel);
            this.Controls.Add(this.LogInBtn);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogInForm";
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.LinkLabel SignUpLinkLabel;
        private System.Windows.Forms.RadioButton employeeRb;
        private System.Windows.Forms.RadioButton CustomerRb;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PwdOrBirthLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox PwdOrBirthTextBox;
        private System.Windows.Forms.Label showPasswordLabel;
        private System.Windows.Forms.DateTimePicker birthDtp;
        private System.Windows.Forms.PictureBox logoPbox;
        private System.Windows.Forms.Button BackBtn;
    }
}