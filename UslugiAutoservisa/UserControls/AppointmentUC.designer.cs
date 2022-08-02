namespace UslugiAutoservisa
{
    partial class AppointmentUC
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
            this.ServiceNameLabel = new System.Windows.Forms.Label();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.ServiceDate = new System.Windows.Forms.Label();
            this.ServiceTimeLabel = new System.Windows.Forms.Label();
            this.TimeLeftLabel = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.empLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ServiceNameLabel
            // 
            this.ServiceNameLabel.AutoSize = true;
            this.ServiceNameLabel.Location = new System.Drawing.Point(5, 4);
            this.ServiceNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServiceNameLabel.Name = "ServiceNameLabel";
            this.ServiceNameLabel.Size = new System.Drawing.Size(140, 13);
            this.ServiceNameLabel.TabIndex = 0;
            this.ServiceNameLabel.Text = "Наименование услуги:";
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.Location = new System.Drawing.Point(5, 27);
            this.FIOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FIOLabel.MaximumSize = new System.Drawing.Size(270, 0);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(89, 13);
            this.FIOLabel.TabIndex = 1;
            this.FIOLabel.Text = "ФИО клиента:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(4, 66);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(43, 13);
            this.Email.TabIndex = 2;
            this.Email.Text = "Email:";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(4, 88);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(108, 13);
            this.PhoneNumberLabel.TabIndex = 3;
            this.PhoneNumberLabel.Text = "Номер телефона:";
            // 
            // ServiceDate
            // 
            this.ServiceDate.AutoSize = true;
            this.ServiceDate.Location = new System.Drawing.Point(289, 66);
            this.ServiceDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServiceDate.Name = "ServiceDate";
            this.ServiceDate.Size = new System.Drawing.Size(82, 13);
            this.ServiceDate.TabIndex = 4;
            this.ServiceDate.Text = "Дата услуги:";
            // 
            // ServiceTimeLabel
            // 
            this.ServiceTimeLabel.AutoSize = true;
            this.ServiceTimeLabel.Location = new System.Drawing.Point(289, 81);
            this.ServiceTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServiceTimeLabel.Name = "ServiceTimeLabel";
            this.ServiceTimeLabel.Size = new System.Drawing.Size(91, 13);
            this.ServiceTimeLabel.TabIndex = 5;
            this.ServiceTimeLabel.Text = "Время услуги:";
            // 
            // TimeLeftLabel
            // 
            this.TimeLeftLabel.AutoSize = true;
            this.TimeLeftLabel.Location = new System.Drawing.Point(289, 106);
            this.TimeLeftLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeLeftLabel.Name = "TimeLeftLabel";
            this.TimeLeftLabel.Size = new System.Drawing.Size(183, 13);
            this.TimeLeftLabel.TabIndex = 6;
            this.TimeLeftLabel.Text = "Оставшееся время до услуги:";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.LightYellow;
            this.deleteBtn.Location = new System.Drawing.Point(386, 122);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(116, 23);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Удалить запись";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(5, 109);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(51, 13);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Статус:";
            // 
            // statusComboBox
            // 
            this.statusComboBox.Items.AddRange(new object[] {
            "Не подтвержден",
            "Ожидает",
            "В работе",
            "Отменен",
            "Выполнен"});
            this.statusComboBox.Location = new System.Drawing.Point(65, 106);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 21);
            this.statusComboBox.TabIndex = 9;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // empLabel
            // 
            this.empLabel.AutoSize = true;
            this.empLabel.Location = new System.Drawing.Point(289, 27);
            this.empLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empLabel.MaximumSize = new System.Drawing.Size(230, 0);
            this.empLabel.Name = "empLabel";
            this.empLabel.Size = new System.Drawing.Size(110, 13);
            this.empLabel.TabIndex = 10;
            this.empLabel.Text = "ФИО сотрудника:";
            // 
            // AppointmentUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.empLabel);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.TimeLeftLabel);
            this.Controls.Add(this.ServiceTimeLabel);
            this.Controls.Add(this.ServiceDate);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.FIOLabel);
            this.Controls.Add(this.ServiceNameLabel);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AppointmentUC";
            this.Size = new System.Drawing.Size(516, 149);
            this.Load += new System.EventHandler(this.RecordUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ServiceNameLabel;
        private System.Windows.Forms.Label FIOLabel;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label ServiceDate;
        private System.Windows.Forms.Label ServiceTimeLabel;
        private System.Windows.Forms.Label TimeLeftLabel;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label empLabel;
    }
}
