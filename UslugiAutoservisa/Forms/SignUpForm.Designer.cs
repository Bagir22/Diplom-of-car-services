namespace UslugiAutoservisa
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.CustomerRb = new System.Windows.Forms.RadioButton();
            this.employeeRb = new System.Windows.Forms.RadioButton();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.PatronymicNameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.birthLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.showPasswordLabel = new System.Windows.Forms.Label();
            this.PwdTextBox = new System.Windows.Forms.TextBox();
            this.PwdLabel = new System.Windows.Forms.Label();
            this.birthDtp = new System.Windows.Forms.DateTimePicker();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.logoPbox = new System.Windows.Forms.PictureBox();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPbox)).BeginInit();
            this.SuspendLayout();
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.BackColor = System.Drawing.Color.LightYellow;
            this.SignUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpBtn.Location = new System.Drawing.Point(118, 254);
            this.SignUpBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(226, 28);
            this.SignUpBtn.TabIndex = 0;
            this.SignUpBtn.Text = "Зарегистрироваться";
            this.SignUpBtn.UseVisualStyleBackColor = false;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // CustomerRb
            // 
            this.CustomerRb.AutoSize = true;
            this.CustomerRb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerRb.Location = new System.Drawing.Point(71, 217);
            this.CustomerRb.Name = "CustomerRb";
            this.CustomerRb.Size = new System.Drawing.Size(98, 24);
            this.CustomerRb.TabIndex = 5;
            this.CustomerRb.Text = "Клиент";
            this.CustomerRb.UseVisualStyleBackColor = true;
            // 
            // employeeRb
            // 
            this.employeeRb.AutoSize = true;
            this.employeeRb.Checked = true;
            this.employeeRb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeRb.Location = new System.Drawing.Point(71, 191);
            this.employeeRb.Name = "employeeRb";
            this.employeeRb.Size = new System.Drawing.Size(132, 24);
            this.employeeRb.TabIndex = 4;
            this.employeeRb.TabStop = true;
            this.employeeRb.Text = "Сотрудник";
            this.employeeRb.UseVisualStyleBackColor = true;
            this.employeeRb.CheckedChanged += new System.EventHandler(this.employeeRb_CheckedChanged);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(68, 12);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(105, 20);
            this.LastNameLabel.TabIndex = 6;
            this.LastNameLabel.Text = "Фамилия:";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.BackColor = System.Drawing.Color.Ivory;
            this.LastNameTextBox.Location = new System.Drawing.Point(71, 31);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(103, 27);
            this.LastNameTextBox.TabIndex = 7;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.BackColor = System.Drawing.Color.Ivory;
            this.FirstNameTextBox.Location = new System.Drawing.Point(71, 75);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(103, 27);
            this.FirstNameTextBox.TabIndex = 9;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(68, 56);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(56, 20);
            this.FirstNameLabel.TabIndex = 8;
            this.FirstNameLabel.Text = "Имя:";
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.BackColor = System.Drawing.Color.Ivory;
            this.PatronymicTextBox.Location = new System.Drawing.Point(71, 120);
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(103, 27);
            this.PatronymicTextBox.TabIndex = 11;
            // 
            // PatronymicNameLabel
            // 
            this.PatronymicNameLabel.AutoSize = true;
            this.PatronymicNameLabel.Location = new System.Drawing.Point(68, 101);
            this.PatronymicNameLabel.Name = "PatronymicNameLabel";
            this.PatronymicNameLabel.Size = new System.Drawing.Size(105, 20);
            this.PatronymicNameLabel.TabIndex = 10;
            this.PatronymicNameLabel.Text = "Отчество:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(219, 12);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(69, 20);
            this.EmailLabel.TabIndex = 12;
            this.EmailLabel.Text = "Email:";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(219, 58);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(102, 20);
            this.PhoneNumberLabel.TabIndex = 14;
            this.PhoneNumberLabel.Text = "Телефон:";
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthLabel.Location = new System.Drawing.Point(68, 146);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(139, 17);
            this.birthLabel.TabIndex = 16;
            this.birthLabel.Text = "Дата рождения:";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(219, 101);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(54, 20);
            this.genderLabel.TabIndex = 18;
            this.genderLabel.Text = "Пол:";
            // 
            // showPasswordLabel
            // 
            this.showPasswordLabel.AutoSize = true;
            this.showPasswordLabel.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showPasswordLabel.Location = new System.Drawing.Point(220, 238);
            this.showPasswordLabel.Name = "showPasswordLabel";
            this.showPasswordLabel.Size = new System.Drawing.Size(123, 14);
            this.showPasswordLabel.TabIndex = 24;
            this.showPasswordLabel.Text = "Показать пароль";
            this.showPasswordLabel.Click += new System.EventHandler(this.showPasswordLabel_Click);
            // 
            // PwdTextBox
            // 
            this.PwdTextBox.BackColor = System.Drawing.Color.Ivory;
            this.PwdTextBox.Location = new System.Drawing.Point(222, 212);
            this.PwdTextBox.Name = "PwdTextBox";
            this.PwdTextBox.PasswordChar = '*';
            this.PwdTextBox.Size = new System.Drawing.Size(100, 27);
            this.PwdTextBox.TabIndex = 23;
            this.PwdTextBox.TextChanged += new System.EventHandler(this.PwdTextBox_TextChanged);
            // 
            // PwdLabel
            // 
            this.PwdLabel.AutoSize = true;
            this.PwdLabel.Location = new System.Drawing.Point(219, 193);
            this.PwdLabel.Name = "PwdLabel";
            this.PwdLabel.Size = new System.Drawing.Size(88, 20);
            this.PwdLabel.TabIndex = 22;
            this.PwdLabel.Text = "Пароль:";
            // 
            // birthDtp
            // 
            this.birthDtp.CalendarMonthBackground = System.Drawing.Color.Ivory;
            this.birthDtp.CalendarTitleBackColor = System.Drawing.Color.Ivory;
            this.birthDtp.CalendarTrailingForeColor = System.Drawing.Color.Ivory;
            this.birthDtp.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.birthDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDtp.Location = new System.Drawing.Point(71, 162);
            this.birthDtp.MaxDate = new System.DateTime(2022, 4, 26, 0, 0, 0, 0);
            this.birthDtp.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.birthDtp.Name = "birthDtp";
            this.birthDtp.Size = new System.Drawing.Size(103, 27);
            this.birthDtp.TabIndex = 25;
            this.birthDtp.Value = new System.DateTime(2022, 4, 26, 0, 0, 0, 0);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.Ivory;
            this.emailTextBox.Location = new System.Drawing.Point(222, 30);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 27);
            this.emailTextBox.TabIndex = 13;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BackColor = System.Drawing.Color.Ivory;
            this.phoneTextBox.Location = new System.Drawing.Point(222, 75);
            this.phoneTextBox.Mask = "0(000)0000000";
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 27);
            this.phoneTextBox.TabIndex = 26;
            // 
            // genderComboBox
            // 
            this.genderComboBox.BackColor = System.Drawing.Color.Ivory;
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.Items.AddRange(new object[] {
            "м",
            "ж"});
            this.genderComboBox.Location = new System.Drawing.Point(222, 120);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(100, 26);
            this.genderComboBox.TabIndex = 27;
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(219, 143);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(125, 20);
            this.positionLabel.TabIndex = 28;
            this.positionLabel.Text = "Должность:";
            // 
            // positionTextBox
            // 
            this.positionTextBox.BackColor = System.Drawing.Color.Ivory;
            this.positionTextBox.Location = new System.Drawing.Point(222, 162);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(100, 27);
            this.positionTextBox.TabIndex = 29;
            // 
            // logoPbox
            // 
            this.logoPbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoPbox.Image = global::UslugiAutoservisa.Properties.Resources.logo;
            this.logoPbox.Location = new System.Drawing.Point(12, 12);
            this.logoPbox.Name = "logoPbox";
            this.logoPbox.Size = new System.Drawing.Size(50, 50);
            this.logoPbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPbox.TabIndex = 30;
            this.logoPbox.TabStop = false;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.LightYellow;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackBtn.Location = new System.Drawing.Point(12, 261);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(57, 21);
            this.BackBtn.TabIndex = 31;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(357, 290);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.logoPbox);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.birthDtp);
            this.Controls.Add(this.showPasswordLabel);
            this.Controls.Add(this.PwdTextBox);
            this.Controls.Add(this.PwdLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.birthLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PatronymicTextBox);
            this.Controls.Add(this.PatronymicNameLabel);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.CustomerRb);
            this.Controls.Add(this.employeeRb);
            this.Controls.Add(this.SignUpBtn);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignUpForm";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.RadioButton CustomerRb;
        private System.Windows.Forms.RadioButton employeeRb;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.Label PatronymicNameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label showPasswordLabel;
        private System.Windows.Forms.TextBox PwdTextBox;
        private System.Windows.Forms.Label PwdLabel;
        private System.Windows.Forms.DateTimePicker birthDtp;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.MaskedTextBox phoneTextBox;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.PictureBox logoPbox;
        private System.Windows.Forms.Button BackBtn;
    }
}