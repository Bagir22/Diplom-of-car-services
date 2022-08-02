namespace UslugiAutoservisa
{
    partial class pageListUC
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
            this.ForwardLabel = new System.Windows.Forms.LinkLabel();
            this.BackLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ForwardLabel
            // 
            this.ForwardLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ForwardLabel.AutoSize = true;
            this.ForwardLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForwardLabel.LinkColor = System.Drawing.Color.Black;
            this.ForwardLabel.Location = new System.Drawing.Point(16, 0);
            this.ForwardLabel.Name = "ForwardLabel";
            this.ForwardLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ForwardLabel.Size = new System.Drawing.Size(14, 16);
            this.ForwardLabel.TabIndex = 0;
            this.ForwardLabel.TabStop = true;
            this.ForwardLabel.Text = ">";
            this.ForwardLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForwardLabel_LinkClicked);
            // 
            // BackLabel
            // 
            this.BackLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BackLabel.AutoSize = true;
            this.BackLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackLabel.LinkColor = System.Drawing.Color.Black;
            this.BackLabel.Location = new System.Drawing.Point(0, 0);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BackLabel.Size = new System.Drawing.Size(14, 16);
            this.BackLabel.TabIndex = 1;
            this.BackLabel.TabStop = true;
            this.BackLabel.Text = "<";
            this.BackLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BackLabel_LinkClicked);
            // 
            // pageListUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BackLabel);
            this.Controls.Add(this.ForwardLabel);
            this.Name = "pageListUC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(33, 19);
            this.Load += new System.EventHandler(this.pageListUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel ForwardLabel;
        private System.Windows.Forms.LinkLabel BackLabel;
    }
}
