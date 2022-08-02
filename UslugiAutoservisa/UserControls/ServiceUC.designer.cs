namespace UslugiAutoservisa
{
    partial class ServiceUC
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
            this.ServiceImage = new System.Windows.Forms.PictureBox();
            this.Service = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.FullPrice = new System.Windows.Forms.Label();
            this.makeAppointmentBtn = new System.Windows.Forms.Button();
            this.editServiceBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ServiceImage
            // 
            this.ServiceImage.Location = new System.Drawing.Point(12, 14);
            this.ServiceImage.Name = "ServiceImage";
            this.ServiceImage.Size = new System.Drawing.Size(130, 120);
            this.ServiceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ServiceImage.TabIndex = 0;
            this.ServiceImage.TabStop = false;
            this.ServiceImage.Click += new System.EventHandler(this.ServiceImage_Click);
            this.ServiceImage.DoubleClick += new System.EventHandler(this.ServiceImage_DoubleClick);
            // 
            // Service
            // 
            this.Service.AutoSize = true;
            this.Service.Location = new System.Drawing.Point(176, 14);
            this.Service.Name = "Service";
            this.Service.Size = new System.Drawing.Size(0, 13);
            this.Service.TabIndex = 1;
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.Location = new System.Drawing.Point(176, 86);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(0, 13);
            this.Discount.TabIndex = 3;
            // 
            // FullPrice
            // 
            this.FullPrice.AutoSize = true;
            this.FullPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullPrice.Location = new System.Drawing.Point(176, 50);
            this.FullPrice.Name = "FullPrice";
            this.FullPrice.Size = new System.Drawing.Size(0, 13);
            this.FullPrice.TabIndex = 6;
            // 
            // makeAppointmentBtn
            // 
            this.makeAppointmentBtn.Location = new System.Drawing.Point(214, 107);
            this.makeAppointmentBtn.Name = "makeAppointmentBtn";
            this.makeAppointmentBtn.Size = new System.Drawing.Size(153, 29);
            this.makeAppointmentBtn.TabIndex = 7;
            this.makeAppointmentBtn.Text = "Записать на услугу";
            this.makeAppointmentBtn.UseVisualStyleBackColor = true;
            this.makeAppointmentBtn.Click += new System.EventHandler(this.makeAppointmentBtn_Click);
            // 
            // editServiceBtn
            // 
            this.editServiceBtn.Location = new System.Drawing.Point(368, 107);
            this.editServiceBtn.Name = "editServiceBtn";
            this.editServiceBtn.Size = new System.Drawing.Size(132, 29);
            this.editServiceBtn.TabIndex = 8;
            this.editServiceBtn.Text = "Редактировать";
            this.editServiceBtn.UseVisualStyleBackColor = true;
            this.editServiceBtn.Click += new System.EventHandler(this.editServiceBtn_Click);
            // 
            // ServiceUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.editServiceBtn);
            this.Controls.Add(this.makeAppointmentBtn);
            this.Controls.Add(this.FullPrice);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.Service);
            this.Controls.Add(this.ServiceImage);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "ServiceUC";
            this.Size = new System.Drawing.Size(503, 142);
            this.Load += new System.EventHandler(this.ServiceUC_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ServiceUC_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ServiceImage;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.Label Service;
        private System.Windows.Forms.Label FullPrice;
        private System.Windows.Forms.Button makeAppointmentBtn;
        private System.Windows.Forms.Button editServiceBtn;
    }
}
