namespace UslugiAutoservisa
{
    partial class StoragePartsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoragePartsForm));
            this.logoPbox = new System.Windows.Forms.PictureBox();
            this.SortLabel = new System.Windows.Forms.Label();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SortComboBox = new System.Windows.Forms.ComboBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.partsTable = new System.Windows.Forms.DataGridView();
            this.addPartsBtn = new System.Windows.Forms.Button();
            this.deletePartsBtn = new System.Windows.Forms.Button();
            this.changeDataBtn = new System.Windows.Forms.Button();
            this.PartsTypeControlBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsTable)).BeginInit();
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
            this.logoPbox.TabIndex = 52;
            this.logoPbox.TabStop = false;
            // 
            // SortLabel
            // 
            this.SortLabel.AutoSize = true;
            this.SortLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortLabel.Location = new System.Drawing.Point(372, 9);
            this.SortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SortLabel.Name = "SortLabel";
            this.SortLabel.Size = new System.Drawing.Size(43, 18);
            this.SortLabel.TabIndex = 51;
            this.SortLabel.Text = "Тип:";
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchLabel.Location = new System.Drawing.Point(83, 13);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(64, 18);
            this.SearchLabel.TabIndex = 50;
            this.SearchLabel.Text = "Поиск:";
            // 
            // SortComboBox
            // 
            this.SortComboBox.BackColor = System.Drawing.Color.Ivory;
            this.SortComboBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortComboBox.FormattingEnabled = true;
            this.SortComboBox.Location = new System.Drawing.Point(376, 38);
            this.SortComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.SortComboBox.Name = "SortComboBox";
            this.SortComboBox.Size = new System.Drawing.Size(154, 26);
            this.SortComboBox.TabIndex = 49;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.Color.Ivory;
            this.SearchTextBox.Location = new System.Drawing.Point(87, 37);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(280, 26);
            this.SearchTextBox.TabIndex = 48;
            // 
            // partsTable
            // 
            this.partsTable.AllowUserToDeleteRows = false;
            this.partsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.partsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsTable.Location = new System.Drawing.Point(12, 82);
            this.partsTable.Name = "partsTable";
            this.partsTable.RowHeadersWidth = 51;
            this.partsTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.partsTable.Size = new System.Drawing.Size(518, 435);
            this.partsTable.TabIndex = 53;
            // 
            // addPartsBtn
            // 
            this.addPartsBtn.BackColor = System.Drawing.Color.LightYellow;
            this.addPartsBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPartsBtn.Location = new System.Drawing.Point(547, 82);
            this.addPartsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addPartsBtn.Name = "addPartsBtn";
            this.addPartsBtn.Size = new System.Drawing.Size(132, 61);
            this.addPartsBtn.TabIndex = 54;
            this.addPartsBtn.Text = "Добавить запчасть";
            this.addPartsBtn.UseVisualStyleBackColor = false;
            // 
            // deletePartsBtn
            // 
            this.deletePartsBtn.BackColor = System.Drawing.Color.LightYellow;
            this.deletePartsBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deletePartsBtn.Location = new System.Drawing.Point(547, 390);
            this.deletePartsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deletePartsBtn.Name = "deletePartsBtn";
            this.deletePartsBtn.Size = new System.Drawing.Size(132, 61);
            this.deletePartsBtn.TabIndex = 55;
            this.deletePartsBtn.Text = "Удалить запчасть";
            this.deletePartsBtn.UseVisualStyleBackColor = false;
            // 
            // changeDataBtn
            // 
            this.changeDataBtn.BackColor = System.Drawing.Color.LightYellow;
            this.changeDataBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeDataBtn.Location = new System.Drawing.Point(547, 151);
            this.changeDataBtn.Margin = new System.Windows.Forms.Padding(4);
            this.changeDataBtn.Name = "changeDataBtn";
            this.changeDataBtn.Size = new System.Drawing.Size(132, 61);
            this.changeDataBtn.TabIndex = 56;
            this.changeDataBtn.Text = "Изменить данные";
            this.changeDataBtn.UseVisualStyleBackColor = false;
            // 
            // PartsTypeControlBtn
            // 
            this.PartsTypeControlBtn.BackColor = System.Drawing.Color.LightYellow;
            this.PartsTypeControlBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PartsTypeControlBtn.Location = new System.Drawing.Point(547, 459);
            this.PartsTypeControlBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PartsTypeControlBtn.Name = "PartsTypeControlBtn";
            this.PartsTypeControlBtn.Size = new System.Drawing.Size(132, 61);
            this.PartsTypeControlBtn.TabIndex = 57;
            this.PartsTypeControlBtn.Text = "Управление категориями";
            this.PartsTypeControlBtn.UseVisualStyleBackColor = false;
            this.PartsTypeControlBtn.Click += new System.EventHandler(this.PartsTypeControlBtn_Click);
            // 
            // StoragePartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 533);
            this.Controls.Add(this.PartsTypeControlBtn);
            this.Controls.Add(this.changeDataBtn);
            this.Controls.Add(this.deletePartsBtn);
            this.Controls.Add(this.addPartsBtn);
            this.Controls.Add(this.partsTable);
            this.Controls.Add(this.logoPbox);
            this.Controls.Add(this.SortLabel);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SortComboBox);
            this.Controls.Add(this.SearchTextBox);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StoragePartsForm";
            this.Text = "Склад запчастей";
            this.Load += new System.EventHandler(this.StoragePartsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPbox;
        private System.Windows.Forms.Label SortLabel;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.ComboBox SortComboBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridView partsTable;
        private System.Windows.Forms.Button addPartsBtn;
        private System.Windows.Forms.Button deletePartsBtn;
        private System.Windows.Forms.Button changeDataBtn;
        private System.Windows.Forms.Button PartsTypeControlBtn;
    }
}