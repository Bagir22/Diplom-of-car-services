namespace UslugiAutoservisa
{
    partial class EmployeeUC
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
            this.FIOLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.birthDtp = new System.Windows.Forms.DateTimePicker();
            this.emailLabel = new System.Windows.Forms.Label();
            this.accConfirmLabel = new System.Windows.Forms.Label();
            this.regDateDtp = new System.Windows.Forms.DateTimePicker();
            this.birthLabel = new System.Windows.Forms.Label();
            this.regDateLabel = new System.Windows.Forms.Label();
            this.accConfirmCmb = new System.Windows.Forms.ComboBox();
            this.saveChangesBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.genderCmb = new System.Windows.Forms.ComboBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOLabel.Location = new System.Drawing.Point(12, 9);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(39, 13);
            this.FIOLabel.TabIndex = 0;
            this.FIOLabel.Text = "ФИО:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.Location = new System.Drawing.Point(12, 34);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(69, 13);
            this.phoneLabel.TabIndex = 1;
            this.phoneLabel.Text = "Телефон:";
            // 
            // birthDtp
            // 
            this.birthDtp.Location = new System.Drawing.Point(15, 95);
            this.birthDtp.Name = "birthDtp";
            this.birthDtp.Size = new System.Drawing.Size(137, 21);
            this.birthDtp.TabIndex = 2;
            this.birthDtp.ValueChanged += new System.EventHandler(this.birthDtp_ValueChanged);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.Location = new System.Drawing.Point(12, 56);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(47, 13);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email:";
            // 
            // accConfirmLabel
            // 
            this.accConfirmLabel.AutoSize = true;
            this.accConfirmLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accConfirmLabel.Location = new System.Drawing.Point(214, 34);
            this.accConfirmLabel.Name = "accConfirmLabel";
            this.accConfirmLabel.Size = new System.Drawing.Size(119, 13);
            this.accConfirmLabel.TabIndex = 5;
            this.accConfirmLabel.Text = "Подтверждение:";
            // 
            // regDateDtp
            // 
            this.regDateDtp.Enabled = false;
            this.regDateDtp.Location = new System.Drawing.Point(217, 95);
            this.regDateDtp.Name = "regDateDtp";
            this.regDateDtp.Size = new System.Drawing.Size(137, 21);
            this.regDateDtp.TabIndex = 6;
            this.regDateDtp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.regDateDtp_KeyDown);
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthLabel.Location = new System.Drawing.Point(12, 79);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(115, 13);
            this.birthLabel.TabIndex = 7;
            this.birthLabel.Text = "Дата рождения:";
            // 
            // regDateLabel
            // 
            this.regDateLabel.AutoSize = true;
            this.regDateLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regDateLabel.Location = new System.Drawing.Point(214, 79);
            this.regDateLabel.Name = "regDateLabel";
            this.regDateLabel.Size = new System.Drawing.Size(128, 13);
            this.regDateLabel.TabIndex = 8;
            this.regDateLabel.Text = "Дата регистрации:";
            // 
            // accConfirmCmb
            // 
            this.accConfirmCmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accConfirmCmb.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accConfirmCmb.Items.AddRange(new object[] {
            "Подтверждена",
            "Не подтверждена"});
            this.accConfirmCmb.Location = new System.Drawing.Point(217, 56);
            this.accConfirmCmb.Name = "accConfirmCmb";
            this.accConfirmCmb.Size = new System.Drawing.Size(121, 21);
            this.accConfirmCmb.TabIndex = 9;
            this.accConfirmCmb.SelectedIndexChanged += new System.EventHandler(this.accConfirmCmb_SelectedIndexChanged);
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveChangesBtn.Location = new System.Drawing.Point(145, 122);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(164, 23);
            this.saveChangesBtn.TabIndex = 10;
            this.saveChangesBtn.Text = "Сохранить изменения";
            this.saveChangesBtn.UseVisualStyleBackColor = true;
            this.saveChangesBtn.Visible = false;
            this.saveChangesBtn.Click += new System.EventHandler(this.saveChangesBtn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(315, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Удалить аккаунт";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // fioTextBox
            // 
            this.fioTextBox.Location = new System.Drawing.Point(52, 6);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(156, 21);
            this.fioTextBox.TabIndex = 12;
            this.fioTextBox.TextChanged += new System.EventHandler(this.fioTextBox_TextChanged);
            this.fioTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fioTextBox_KeyDown);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(83, 29);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(125, 21);
            this.phoneTextBox.TabIndex = 13;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(61, 53);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(147, 21);
            this.emailTextBox.TabIndex = 14;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genderLabel.Location = new System.Drawing.Point(347, 34);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(36, 13);
            this.genderLabel.TabIndex = 16;
            this.genderLabel.Text = "Пол:";
            // 
            // genderCmb
            // 
            this.genderCmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genderCmb.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genderCmb.Items.AddRange(new object[] {
            "Муж.",
            "Жен."});
            this.genderCmb.Location = new System.Drawing.Point(350, 56);
            this.genderCmb.Name = "genderCmb";
            this.genderCmb.Size = new System.Drawing.Size(107, 21);
            this.genderCmb.TabIndex = 17;
            this.genderCmb.SelectedIndexChanged += new System.EventHandler(this.genderCmb_SelectedIndexChanged);
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.positionLabel.Location = new System.Drawing.Point(214, 9);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(82, 13);
            this.positionLabel.TabIndex = 4;
            this.positionLabel.Text = "Должность";
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(302, 6);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(155, 21);
            this.positionTextBox.TabIndex = 15;
            this.positionTextBox.TextChanged += new System.EventHandler(this.positionTextBox_TextChanged);
            // 
            // EmployeeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.genderCmb);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.positionTextBox);
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
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.birthDtp);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.FIOLabel);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EmployeeUC";
            this.Size = new System.Drawing.Size(467, 150);
            this.Load += new System.EventHandler(this.EmployeeUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FIOLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.DateTimePicker birthDtp;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label accConfirmLabel;
        private System.Windows.Forms.DateTimePicker regDateDtp;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.Label regDateLabel;
        private System.Windows.Forms.ComboBox accConfirmCmb;
        private System.Windows.Forms.Button saveChangesBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.ComboBox genderCmb;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.TextBox positionTextBox;
    }
}
