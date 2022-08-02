namespace UslugiAutoservisa
{
    partial class makeAppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(makeAppointmentForm));
            this.Minutes = new System.Windows.Forms.NumericUpDown();
            this.Hours = new System.Windows.Forms.NumericUpDown();
            this.MinutesLabel = new System.Windows.Forms.Label();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.RecordTime = new System.Windows.Forms.Label();
            this.RecordDate = new System.Windows.Forms.Label();
            this.FIO = new System.Windows.Forms.Label();
            this.FIOCmb = new System.Windows.Forms.ComboBox();
            this.ServiceTimeLabel = new System.Windows.Forms.Label();
            this.ServiceNameLabel = new System.Windows.Forms.Label();
            this.RecordDateDtp = new System.Windows.Forms.DateTimePicker();
            this.logoPbox = new System.Windows.Forms.PictureBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.empCmb = new System.Windows.Forms.ComboBox();
            this.RecordClientBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.partsGroupBox = new System.Windows.Forms.GroupBox();
            this.possPartsLb = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.partsTypeCmb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPbox)).BeginInit();
            this.partsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Minutes
            // 
            this.Minutes.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minutes.Location = new System.Drawing.Point(357, 143);
            this.Minutes.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(110, 24);
            this.Minutes.TabIndex = 45;
            // 
            // Hours
            // 
            this.Hours.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hours.Location = new System.Drawing.Point(238, 143);
            this.Hours.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Hours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(110, 24);
            this.Hours.TabIndex = 44;
            this.Hours.ValueChanged += new System.EventHandler(this.Hours_ValueChanged);
            // 
            // MinutesLabel
            // 
            this.MinutesLabel.AutoSize = true;
            this.MinutesLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinutesLabel.Location = new System.Drawing.Point(354, 166);
            this.MinutesLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MinutesLabel.Name = "MinutesLabel";
            this.MinutesLabel.Size = new System.Drawing.Size(68, 17);
            this.MinutesLabel.TabIndex = 43;
            this.MinutesLabel.Text = "минуты";
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HoursLabel.Location = new System.Drawing.Point(235, 166);
            this.HoursLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(49, 17);
            this.HoursLabel.TabIndex = 42;
            this.HoursLabel.Text = "часы";
            // 
            // RecordTime
            // 
            this.RecordTime.AutoSize = true;
            this.RecordTime.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecordTime.Location = new System.Drawing.Point(70, 145);
            this.RecordTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.RecordTime.Name = "RecordTime";
            this.RecordTime.Size = new System.Drawing.Size(119, 17);
            this.RecordTime.TabIndex = 41;
            this.RecordTime.Text = "Время записи";
            // 
            // RecordDate
            // 
            this.RecordDate.AutoSize = true;
            this.RecordDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecordDate.Location = new System.Drawing.Point(70, 117);
            this.RecordDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.RecordDate.Name = "RecordDate";
            this.RecordDate.Size = new System.Drawing.Size(106, 17);
            this.RecordDate.TabIndex = 40;
            this.RecordDate.Text = "Дата записи";
            // 
            // FIO
            // 
            this.FIO.AutoSize = true;
            this.FIO.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIO.Location = new System.Drawing.Point(70, 46);
            this.FIO.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(195, 34);
            this.FIO.TabIndex = 39;
            this.FIO.Text = "Фамилия Имя Отчество\r\nклиента";
            // 
            // FIOCmb
            // 
            this.FIOCmb.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOCmb.FormattingEnabled = true;
            this.FIOCmb.Location = new System.Drawing.Point(275, 51);
            this.FIOCmb.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.FIOCmb.Name = "FIOCmb";
            this.FIOCmb.Size = new System.Drawing.Size(192, 25);
            this.FIOCmb.TabIndex = 37;
            // 
            // ServiceTimeLabel
            // 
            this.ServiceTimeLabel.AutoSize = true;
            this.ServiceTimeLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceTimeLabel.Location = new System.Drawing.Point(70, 188);
            this.ServiceTimeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ServiceTimeLabel.Name = "ServiceTimeLabel";
            this.ServiceTimeLabel.Size = new System.Drawing.Size(232, 17);
            this.ServiceTimeLabel.TabIndex = 36;
            this.ServiceTimeLabel.Text = "Продолжительность услуги";
            // 
            // ServiceNameLabel
            // 
            this.ServiceNameLabel.AutoSize = true;
            this.ServiceNameLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceNameLabel.Location = new System.Drawing.Point(70, 12);
            this.ServiceNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ServiceNameLabel.MaximumSize = new System.Drawing.Size(395, 0);
            this.ServiceNameLabel.Name = "ServiceNameLabel";
            this.ServiceNameLabel.Size = new System.Drawing.Size(181, 17);
            this.ServiceNameLabel.TabIndex = 35;
            this.ServiceNameLabel.Text = "Наименование услуги";
            // 
            // RecordDateDtp
            // 
            this.RecordDateDtp.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecordDateDtp.Location = new System.Drawing.Point(238, 111);
            this.RecordDateDtp.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.RecordDateDtp.Name = "RecordDateDtp";
            this.RecordDateDtp.Size = new System.Drawing.Size(229, 24);
            this.RecordDateDtp.TabIndex = 34;
            this.RecordDateDtp.ValueChanged += new System.EventHandler(this.RecordDateDtp_ValueChanged);
            // 
            // logoPbox
            // 
            this.logoPbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoPbox.Image = global::UslugiAutoservisa.Properties.Resources.logo;
            this.logoPbox.Location = new System.Drawing.Point(12, 12);
            this.logoPbox.Name = "logoPbox";
            this.logoPbox.Size = new System.Drawing.Size(50, 50);
            this.logoPbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPbox.TabIndex = 46;
            this.logoPbox.TabStop = false;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.LightYellow;
            this.BackBtn.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackBtn.Location = new System.Drawing.Point(581, 233);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(57, 21);
            this.BackBtn.TabIndex = 47;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(70, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Сотрудник:";
            // 
            // empCmb
            // 
            this.empCmb.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.empCmb.FormattingEnabled = true;
            this.empCmb.Location = new System.Drawing.Point(238, 84);
            this.empCmb.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.empCmb.Name = "empCmb";
            this.empCmb.Size = new System.Drawing.Size(229, 25);
            this.empCmb.TabIndex = 48;
            // 
            // RecordClientBtn
            // 
            this.RecordClientBtn.BackColor = System.Drawing.Color.LightYellow;
            this.RecordClientBtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecordClientBtn.Location = new System.Drawing.Point(73, 208);
            this.RecordClientBtn.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.RecordClientBtn.Name = "RecordClientBtn";
            this.RecordClientBtn.Size = new System.Drawing.Size(152, 53);
            this.RecordClientBtn.TabIndex = 38;
            this.RecordClientBtn.Text = "Записать клиента";
            this.RecordClientBtn.UseVisualStyleBackColor = false;
            this.RecordClientBtn.Click += new System.EventHandler(this.RecordClientBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightYellow;
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(235, 208);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 53);
            this.button1.TabIndex = 50;
            this.button1.Text = "Отменить запись";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // partsGroupBox
            // 
            this.partsGroupBox.Controls.Add(this.possPartsLb);
            this.partsGroupBox.Controls.Add(this.label4);
            this.partsGroupBox.Controls.Add(this.partsTypeCmb);
            this.partsGroupBox.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partsGroupBox.Location = new System.Drawing.Point(484, 51);
            this.partsGroupBox.Name = "partsGroupBox";
            this.partsGroupBox.Size = new System.Drawing.Size(155, 175);
            this.partsGroupBox.TabIndex = 56;
            this.partsGroupBox.TabStop = false;
            this.partsGroupBox.Text = "Подходящие запчасти";
            this.partsGroupBox.Enter += new System.EventHandler(this.partsGroupBox_Enter);
            // 
            // possPartsLb
            // 
            this.possPartsLb.FormattingEnabled = true;
            this.possPartsLb.HorizontalScrollbar = true;
            this.possPartsLb.Location = new System.Drawing.Point(6, 83);
            this.possPartsLb.Name = "possPartsLb";
            this.possPartsLb.Size = new System.Drawing.Size(140, 76);
            this.possPartsLb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Тип:";
            // 
            // partsTypeCmb
            // 
            this.partsTypeCmb.Location = new System.Drawing.Point(7, 53);
            this.partsTypeCmb.Name = "partsTypeCmb";
            this.partsTypeCmb.Size = new System.Drawing.Size(142, 24);
            this.partsTypeCmb.TabIndex = 0;
            // 
            // makeAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(651, 267);
            this.Controls.Add(this.partsGroupBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empCmb);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.logoPbox);
            this.Controls.Add(this.Minutes);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.MinutesLabel);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.RecordTime);
            this.Controls.Add(this.RecordDate);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.RecordClientBtn);
            this.Controls.Add(this.FIOCmb);
            this.Controls.Add(this.ServiceTimeLabel);
            this.Controls.Add(this.ServiceNameLabel);
            this.Controls.Add(this.RecordDateDtp);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "makeAppointmentForm";
            this.Text = "Запись на услугу";
            this.Load += new System.EventHandler(this.makeAppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPbox)).EndInit();
            this.partsGroupBox.ResumeLayout(false);
            this.partsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown Minutes;
        private System.Windows.Forms.NumericUpDown Hours;
        private System.Windows.Forms.Label MinutesLabel;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.Label RecordTime;
        private System.Windows.Forms.Label RecordDate;
        private System.Windows.Forms.Label FIO;
        private System.Windows.Forms.ComboBox FIOCmb;
        private System.Windows.Forms.Label ServiceTimeLabel;
        private System.Windows.Forms.Label ServiceNameLabel;
        private System.Windows.Forms.DateTimePicker RecordDateDtp;
        private System.Windows.Forms.PictureBox logoPbox;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox empCmb;
        private System.Windows.Forms.Button RecordClientBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox partsGroupBox;
        private System.Windows.Forms.CheckedListBox possPartsLb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox partsTypeCmb;
    }
}