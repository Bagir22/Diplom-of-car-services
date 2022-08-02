namespace UslugiAutoservisa
{
    partial class CustomerUC
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.genderCmb = new System.Windows.Forms.ComboBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.saveChangesBtn = new System.Windows.Forms.Button();
            this.accConfirmCmb = new System.Windows.Forms.ComboBox();
            this.regDateLabel = new System.Windows.Forms.Label();
            this.birthLabel = new System.Windows.Forms.Label();
            this.regDateDtp = new System.Windows.Forms.DateTimePicker();
            this.accConfirmLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.birthDtp = new System.Windows.Forms.DateTimePicker();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // genderCmb
            // 
            this.genderCmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genderCmb.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genderCmb.Items.AddRange(new object[] {
            "Муж.",
            "Жен."});
            this.genderCmb.Location = new System.Drawing.Point(341, 55);
            this.genderCmb.Name = "genderCmb";
            this.genderCmb.Size = new System.Drawing.Size(107, 21);
            this.genderCmb.TabIndex = 35;
            this.genderCmb.SelectedIndexChanged += new System.EventHandler(this.genderCmb_SelectedIndexChanged);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genderLabel.Location = new System.Drawing.Point(338, 33);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(36, 13);
            this.genderLabel.TabIndex = 34;
            this.genderLabel.Text = "Пол:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(52, 52);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(147, 21);
            this.emailTextBox.TabIndex = 32;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(74, 28);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(125, 21);
            this.phoneTextBox.TabIndex = 31;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_TextChanged);
            // 
            // fioTextBox
            // 
            this.fioTextBox.Location = new System.Drawing.Point(43, 5);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(156, 21);
            this.fioTextBox.TabIndex = 30;
            this.fioTextBox.TextChanged += new System.EventHandler(this.fioTextBox_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(306, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Удалить аккаунт";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveChangesBtn.Location = new System.Drawing.Point(136, 121);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(164, 23);
            this.saveChangesBtn.TabIndex = 28;
            this.saveChangesBtn.Text = "Сохранить изменения";
            this.saveChangesBtn.UseVisualStyleBackColor = true;
            this.saveChangesBtn.Visible = false;
            this.saveChangesBtn.Click += new System.EventHandler(this.saveChangesBtn_Click);
            // 
            // accConfirmCmb
            // 
            this.accConfirmCmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accConfirmCmb.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accConfirmCmb.Items.AddRange(new object[] {
            "Подтверждена",
            "Не подтверждена"});
            this.accConfirmCmb.Location = new System.Drawing.Point(208, 55);
            this.accConfirmCmb.Name = "accConfirmCmb";
            this.accConfirmCmb.Size = new System.Drawing.Size(121, 21);
            this.accConfirmCmb.TabIndex = 27;
            this.accConfirmCmb.SelectedIndexChanged += new System.EventHandler(this.accConfirmCmb_SelectedIndexChanged);
            // 
            // regDateLabel
            // 
            this.regDateLabel.AutoSize = true;
            this.regDateLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regDateLabel.Location = new System.Drawing.Point(205, 78);
            this.regDateLabel.Name = "regDateLabel";
            this.regDateLabel.Size = new System.Drawing.Size(128, 13);
            this.regDateLabel.TabIndex = 26;
            this.regDateLabel.Text = "Дата регистрации:";
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthLabel.Location = new System.Drawing.Point(3, 78);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(115, 13);
            this.birthLabel.TabIndex = 25;
            this.birthLabel.Text = "Дата рождения:";
            // 
            // regDateDtp
            // 
            this.regDateDtp.Enabled = false;
            this.regDateDtp.Location = new System.Drawing.Point(208, 94);
            this.regDateDtp.Name = "regDateDtp";
            this.regDateDtp.Size = new System.Drawing.Size(137, 21);
            this.regDateDtp.TabIndex = 24;
            this.regDateDtp.ValueChanged += new System.EventHandler(this.regDateDtp_ValueChanged);
            // 
            // accConfirmLabel
            // 
            this.accConfirmLabel.AutoSize = true;
            this.accConfirmLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accConfirmLabel.Location = new System.Drawing.Point(205, 33);
            this.accConfirmLabel.Name = "accConfirmLabel";
            this.accConfirmLabel.Size = new System.Drawing.Size(119, 13);
            this.accConfirmLabel.TabIndex = 23;
            this.accConfirmLabel.Text = "Подтверждение:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.Location = new System.Drawing.Point(3, 55);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(47, 13);
            this.emailLabel.TabIndex = 21;
            this.emailLabel.Text = "Email:";
            // 
            // birthDtp
            // 
            this.birthDtp.Location = new System.Drawing.Point(6, 94);
            this.birthDtp.Name = "birthDtp";
            this.birthDtp.Size = new System.Drawing.Size(137, 21);
            this.birthDtp.TabIndex = 20;
            this.birthDtp.ValueChanged += new System.EventHandler(this.birthDtp_ValueChanged);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.Location = new System.Drawing.Point(3, 33);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(69, 13);
            this.phoneLabel.TabIndex = 19;
            this.phoneLabel.Text = "Телефон:";
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOLabel.Location = new System.Drawing.Point(3, 8);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(39, 13);
            this.FIOLabel.TabIndex = 18;
            this.FIOLabel.Text = "ФИО:";
            // 
            // CustomerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.genderCmb);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.fioTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.saveChangesBtn);
            this.Controls.Add(this.accConfirmCmb);
            this.Controls.Add(this.regDateLabel);
            this.Controls.Add(this.birthLabel);
            this.Controls.Add(this.regDateDtp);
            this.Controls.Add(this.accConfirmLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.birthDtp);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.FIOLabel);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CustomerUC";
            this.Size = new System.Drawing.Size(458, 148);
            this.Load += new System.EventHandler(this.CustomerUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox genderCmb;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button saveChangesBtn;
        private System.Windows.Forms.ComboBox accConfirmCmb;
        private System.Windows.Forms.Label regDateLabel;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.DateTimePicker regDateDtp;
        private System.Windows.Forms.Label accConfirmLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.DateTimePicker birthDtp;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label FIOLabel;
    }
}
