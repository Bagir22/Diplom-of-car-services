namespace UslugiAutoservisa
{
    partial class AddServiceForm
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
            this.AddAdditionalImage = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.AdditionalImagePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ServiceNumberLabel = new System.Windows.Forms.Label();
            this.ServiceNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ServiceTimeLabel = new System.Windows.Forms.Label();
            this.ServiceTime = new System.Windows.Forms.NumericUpDown();
            this.ServicePriceLabel = new System.Windows.Forms.Label();
            this.ServicePrice = new System.Windows.Forms.NumericUpDown();
            this.ServiceNameLabel = new System.Windows.Forms.Label();
            this.ServiceName = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.ServiceImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.logoPbox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.partsGroupBox = new System.Windows.Forms.GroupBox();
            this.partsTypeCmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addedpartsLb = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.possPartsLb = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServicePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPbox)).BeginInit();
            this.partsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddAdditionalImage
            // 
            this.AddAdditionalImage.BackColor = System.Drawing.Color.White;
            this.AddAdditionalImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddAdditionalImage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAdditionalImage.Location = new System.Drawing.Point(188, 254);
            this.AddAdditionalImage.Name = "AddAdditionalImage";
            this.AddAdditionalImage.Size = new System.Drawing.Size(146, 89);
            this.AddAdditionalImage.TabIndex = 49;
            this.AddAdditionalImage.Text = "Добавить дополнительное изображение";
            this.AddAdditionalImage.UseVisualStyleBackColor = false;
            this.AddAdditionalImage.Click += new System.EventHandler(this.AddAdditionalImage_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.White;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(595, 316);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 48;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(351, 28);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(157, 100);
            this.Description.TabIndex = 47;
            this.Description.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AdditionalImagePanel
            // 
            this.AdditionalImagePanel.AutoScroll = true;
            this.AdditionalImagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdditionalImagePanel.Location = new System.Drawing.Point(188, 147);
            this.AdditionalImagePanel.Name = "AdditionalImagePanel";
            this.AdditionalImagePanel.Size = new System.Drawing.Size(320, 88);
            this.AdditionalImagePanel.TabIndex = 50;
            // 
            // ServiceNumberLabel
            // 
            this.ServiceNumberLabel.AutoSize = true;
            this.ServiceNumberLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceNumberLabel.Location = new System.Drawing.Point(68, 12);
            this.ServiceNumberLabel.Name = "ServiceNumberLabel";
            this.ServiceNumberLabel.Size = new System.Drawing.Size(84, 17);
            this.ServiceNumberLabel.TabIndex = 46;
            this.ServiceNumberLabel.Text = "№ услуги";
            // 
            // ServiceNumber
            // 
            this.ServiceNumber.BackColor = System.Drawing.Color.White;
            this.ServiceNumber.Enabled = false;
            this.ServiceNumber.Location = new System.Drawing.Point(68, 33);
            this.ServiceNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ServiceNumber.Name = "ServiceNumber";
            this.ServiceNumber.ReadOnly = true;
            this.ServiceNumber.Size = new System.Drawing.Size(72, 24);
            this.ServiceNumber.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(348, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Описание услуги:";
            // 
            // ServiceTimeLabel
            // 
            this.ServiceTimeLabel.AutoSize = true;
            this.ServiceTimeLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceTimeLabel.Location = new System.Drawing.Point(10, 171);
            this.ServiceTimeLabel.Name = "ServiceTimeLabel";
            this.ServiceTimeLabel.Size = new System.Drawing.Size(175, 17);
            this.ServiceTimeLabel.TabIndex = 41;
            this.ServiceTimeLabel.Text = "Длительность(Мин):";
            // 
            // ServiceTime
            // 
            this.ServiceTime.Location = new System.Drawing.Point(13, 187);
            this.ServiceTime.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.ServiceTime.Name = "ServiceTime";
            this.ServiceTime.Size = new System.Drawing.Size(152, 24);
            this.ServiceTime.TabIndex = 40;
            // 
            // ServicePriceLabel
            // 
            this.ServicePriceLabel.AutoSize = true;
            this.ServicePriceLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServicePriceLabel.Location = new System.Drawing.Point(10, 131);
            this.ServicePriceLabel.Name = "ServicePriceLabel";
            this.ServicePriceLabel.Size = new System.Drawing.Size(99, 17);
            this.ServicePriceLabel.TabIndex = 39;
            this.ServicePriceLabel.Text = "Стоимость:";
            // 
            // ServicePrice
            // 
            this.ServicePrice.Location = new System.Drawing.Point(13, 147);
            this.ServicePrice.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.ServicePrice.Name = "ServicePrice";
            this.ServicePrice.Size = new System.Drawing.Size(152, 24);
            this.ServicePrice.TabIndex = 38;
            // 
            // ServiceNameLabel
            // 
            this.ServiceNameLabel.AutoSize = true;
            this.ServiceNameLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceNameLabel.Location = new System.Drawing.Point(9, 65);
            this.ServiceNameLabel.Name = "ServiceNameLabel";
            this.ServiceNameLabel.Size = new System.Drawing.Size(187, 17);
            this.ServiceNameLabel.TabIndex = 37;
            this.ServiceNameLabel.Text = "Наименование услуги:";
            // 
            // ServiceName
            // 
            this.ServiceName.Location = new System.Drawing.Point(12, 81);
            this.ServiceName.Multiline = true;
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.Size = new System.Drawing.Size(152, 47);
            this.ServiceName.TabIndex = 36;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.White;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBtn.Location = new System.Drawing.Point(12, 254);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(152, 42);
            this.AddBtn.TabIndex = 35;
            this.AddBtn.Text = "Добавить услугу";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.White;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditBtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditBtn.Location = new System.Drawing.Point(13, 302);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(151, 41);
            this.EditBtn.TabIndex = 34;
            this.EditBtn.Text = "Редактировать услугу";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // ServiceImage
            // 
            this.ServiceImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServiceImage.Location = new System.Drawing.Point(188, 28);
            this.ServiceImage.Name = "ServiceImage";
            this.ServiceImage.Size = new System.Drawing.Size(100, 100);
            this.ServiceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ServiceImage.TabIndex = 33;
            this.ServiceImage.TabStop = false;
            this.ServiceImage.Click += new System.EventHandler(this.ServiceImage_Click);
            this.ServiceImage.DoubleClick += new System.EventHandler(this.ServiceImage_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(185, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Изображение:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // logoPbox
            // 
            this.logoPbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoPbox.Image = global::UslugiAutoservisa.Properties.Resources.logo;
            this.logoPbox.Location = new System.Drawing.Point(12, 12);
            this.logoPbox.Name = "logoPbox";
            this.logoPbox.Size = new System.Drawing.Size(50, 50);
            this.logoPbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPbox.TabIndex = 53;
            this.logoPbox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(185, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "Дополнительные изображения:";
            // 
            // partsGroupBox
            // 
            this.partsGroupBox.Controls.Add(this.possPartsLb);
            this.partsGroupBox.Controls.Add(this.label5);
            this.partsGroupBox.Controls.Add(this.label4);
            this.partsGroupBox.Controls.Add(this.partsTypeCmb);
            this.partsGroupBox.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partsGroupBox.Location = new System.Drawing.Point(529, 12);
            this.partsGroupBox.Name = "partsGroupBox";
            this.partsGroupBox.Size = new System.Drawing.Size(155, 284);
            this.partsGroupBox.TabIndex = 55;
            this.partsGroupBox.TabStop = false;
            this.partsGroupBox.Text = "Добавление запчастей";
            // 
            // partsTypeCmb
            // 
            this.partsTypeCmb.Location = new System.Drawing.Point(7, 53);
            this.partsTypeCmb.Name = "partsTypeCmb";
            this.partsTypeCmb.Size = new System.Drawing.Size(142, 24);
            this.partsTypeCmb.TabIndex = 0;
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
            // addedpartsLb
            // 
            this.addedpartsLb.FormattingEnabled = true;
            this.addedpartsLb.HorizontalScrollbar = true;
            this.addedpartsLb.ItemHeight = 17;
            this.addedpartsLb.Location = new System.Drawing.Point(351, 267);
            this.addedpartsLb.Name = "addedpartsLb";
            this.addedpartsLb.Size = new System.Drawing.Size(157, 72);
            this.addedpartsLb.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(348, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "Добавленные запчасти:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Возможные:";
            // 
            // possPartsLb
            // 
            this.possPartsLb.FormattingEnabled = true;
            this.possPartsLb.HorizontalScrollbar = true;
            this.possPartsLb.Location = new System.Drawing.Point(9, 119);
            this.possPartsLb.Name = "possPartsLb";
            this.possPartsLb.Size = new System.Drawing.Size(140, 148);
            this.possPartsLb.TabIndex = 4;
            this.possPartsLb.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.possPartsLb_ItemCheck);
            this.possPartsLb.SelectedIndexChanged += new System.EventHandler(this.possPartsLb_SelectedIndexChanged);
            // 
            // AddServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 351);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.partsGroupBox);
            this.Controls.Add(this.addedpartsLb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logoPbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddAdditionalImage);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.AdditionalImagePanel);
            this.Controls.Add(this.ServiceNumberLabel);
            this.Controls.Add(this.ServiceNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServiceTimeLabel);
            this.Controls.Add(this.ServiceTime);
            this.Controls.Add(this.ServicePriceLabel);
            this.Controls.Add(this.ServicePrice);
            this.Controls.Add(this.ServiceNameLabel);
            this.Controls.Add(this.ServiceName);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.ServiceImage);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddServiceForm";
            this.Text = "Добавление услуги";
            this.Load += new System.EventHandler(this.AddServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServicePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPbox)).EndInit();
            this.partsGroupBox.ResumeLayout(false);
            this.partsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddAdditionalImage;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FlowLayoutPanel AdditionalImagePanel;
        private System.Windows.Forms.Label ServiceNumberLabel;
        private System.Windows.Forms.NumericUpDown ServiceNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ServiceTimeLabel;
        private System.Windows.Forms.NumericUpDown ServiceTime;
        private System.Windows.Forms.Label ServicePriceLabel;
        private System.Windows.Forms.NumericUpDown ServicePrice;
        private System.Windows.Forms.Label ServiceNameLabel;
        private System.Windows.Forms.TextBox ServiceName;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.PictureBox ServiceImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox logoPbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox partsGroupBox;
        private System.Windows.Forms.CheckedListBox possPartsLb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox partsTypeCmb;
        private System.Windows.Forms.ListBox addedpartsLb;
        private System.Windows.Forms.Label label6;
    }
}