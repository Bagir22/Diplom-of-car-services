namespace UslugiAutoservisa
{
    partial class PartsTypeControlForm
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
            this.logoPbox = new System.Windows.Forms.PictureBox();
            this.changeDataBtn = new System.Windows.Forms.Button();
            this.partsTypeTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.logoPbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsTypeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPbox
            // 
            this.logoPbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoPbox.Image = global::UslugiAutoservisa.Properties.Resources.logo;
            this.logoPbox.Location = new System.Drawing.Point(13, 13);
            this.logoPbox.Margin = new System.Windows.Forms.Padding(4);
            this.logoPbox.Name = "logoPbox";
            this.logoPbox.Size = new System.Drawing.Size(62, 62);
            this.logoPbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPbox.TabIndex = 53;
            this.logoPbox.TabStop = false;
            // 
            // changeDataBtn
            // 
            this.changeDataBtn.BackColor = System.Drawing.Color.LightYellow;
            this.changeDataBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeDataBtn.Location = new System.Drawing.Point(13, 106);
            this.changeDataBtn.Margin = new System.Windows.Forms.Padding(4);
            this.changeDataBtn.Name = "changeDataBtn";
            this.changeDataBtn.Size = new System.Drawing.Size(145, 61);
            this.changeDataBtn.TabIndex = 57;
            this.changeDataBtn.Text = "Применить изменения";
            this.changeDataBtn.UseVisualStyleBackColor = false;
            // 
            // partsTypeTable
            // 
            this.partsTypeTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partsTypeTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.partsTypeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsTypeTable.Location = new System.Drawing.Point(165, 17);
            this.partsTypeTable.Name = "partsTypeTable";
            this.partsTypeTable.RowHeadersWidth = 51;
            this.partsTypeTable.Size = new System.Drawing.Size(197, 150);
            this.partsTypeTable.TabIndex = 58;
            // 
            // PartsTypeControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 175);
            this.Controls.Add(this.partsTypeTable);
            this.Controls.Add(this.changeDataBtn);
            this.Controls.Add(this.logoPbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PartsTypeControlForm";
            this.Text = "Управление категориями запчастей";
            this.Load += new System.EventHandler(this.PartsTypeControlBtn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsTypeTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPbox;
        private System.Windows.Forms.Button changeDataBtn;
        private System.Windows.Forms.DataGridView partsTypeTable;
    }
}