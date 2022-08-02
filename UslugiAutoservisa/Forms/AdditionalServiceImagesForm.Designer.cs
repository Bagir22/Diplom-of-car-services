namespace UslugiAutoservisa
{
    partial class AdditionalServiceImagesForm
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
            this.ServiceNameLabel = new System.Windows.Forms.Label();
            this.additionalImagesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ServiceNameLabel
            // 
            this.ServiceNameLabel.AutoSize = true;
            this.ServiceNameLabel.Location = new System.Drawing.Point(12, 13);
            this.ServiceNameLabel.Name = "ServiceNameLabel";
            this.ServiceNameLabel.Size = new System.Drawing.Size(93, 13);
            this.ServiceNameLabel.TabIndex = 0;
            this.ServiceNameLabel.Text = "ServiceName";
            // 
            // additionalImagesPanel
            // 
            this.additionalImagesPanel.AutoScroll = true;
            this.additionalImagesPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.additionalImagesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.additionalImagesPanel.Location = new System.Drawing.Point(0, 41);
            this.additionalImagesPanel.Name = "additionalImagesPanel";
            this.additionalImagesPanel.Size = new System.Drawing.Size(340, 312);
            this.additionalImagesPanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightYellow;
            this.button1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(283, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 21);
            this.button1.TabIndex = 30;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdditionalServiceImagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(343, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.additionalImagesPanel);
            this.Controls.Add(this.ServiceNameLabel);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AdditionalServiceImagesForm";
            this.Text = "Дополнительные изображения услуги";
            this.Load += new System.EventHandler(this.AdditionalServiceImagesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ServiceNameLabel;
        private System.Windows.Forms.FlowLayoutPanel additionalImagesPanel;
        private System.Windows.Forms.Button button1;
    }
}