namespace UslugiAutoservisa
{
    partial class EmployeesForm
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
            this.employeesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmEmployessRb = new System.Windows.Forms.RadioButton();
            this.notConfirmEmployeesRb = new System.Windows.Forms.RadioButton();
            this.allEmployeesRb = new System.Windows.Forms.RadioButton();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeesPanel
            // 
            this.employeesPanel.AutoScroll = true;
            this.employeesPanel.Location = new System.Drawing.Point(14, 110);
            this.employeesPanel.Name = "employeesPanel";
            this.employeesPanel.Size = new System.Drawing.Size(482, 305);
            this.employeesPanel.TabIndex = 0;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(12, 45);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(75, 20);
            this.SearchLabel.TabIndex = 35;
            this.SearchLabel.Text = "Поиск:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.SearchTextBox.Location = new System.Drawing.Point(14, 68);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(281, 27);
            this.SearchTextBox.TabIndex = 34;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            this.SearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyDown);
            // 
            // ConfirmEmployessRb
            // 
            this.ConfirmEmployessRb.AutoSize = true;
            this.ConfirmEmployessRb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmEmployessRb.Location = new System.Drawing.Point(299, 38);
            this.ConfirmEmployessRb.Name = "ConfirmEmployessRb";
            this.ConfirmEmployessRb.Size = new System.Drawing.Size(163, 24);
            this.ConfirmEmployessRb.TabIndex = 36;
            this.ConfirmEmployessRb.Text = "Подтвержден";
            this.ConfirmEmployessRb.UseVisualStyleBackColor = true;
            this.ConfirmEmployessRb.CheckedChanged += new System.EventHandler(this.ConfirmEmployessRb_CheckedChanged);
            // 
            // notConfirmEmployeesRb
            // 
            this.notConfirmEmployeesRb.AutoSize = true;
            this.notConfirmEmployeesRb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notConfirmEmployeesRb.Location = new System.Drawing.Point(299, 68);
            this.notConfirmEmployeesRb.Name = "notConfirmEmployeesRb";
            this.notConfirmEmployeesRb.Size = new System.Drawing.Size(192, 24);
            this.notConfirmEmployeesRb.TabIndex = 37;
            this.notConfirmEmployeesRb.Text = "Не подтвержден";
            this.notConfirmEmployeesRb.UseVisualStyleBackColor = true;
            this.notConfirmEmployeesRb.CheckedChanged += new System.EventHandler(this.notConfirmEmployeesRb_CheckedChanged);
            // 
            // allEmployeesRb
            // 
            this.allEmployeesRb.AutoSize = true;
            this.allEmployeesRb.Checked = true;
            this.allEmployeesRb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allEmployeesRb.Location = new System.Drawing.Point(300, 12);
            this.allEmployeesRb.Name = "allEmployeesRb";
            this.allEmployeesRb.Size = new System.Drawing.Size(63, 24);
            this.allEmployeesRb.TabIndex = 38;
            this.allEmployeesRb.TabStop = true;
            this.allEmployeesRb.Text = "Все";
            this.allEmployeesRb.UseVisualStyleBackColor = true;
            this.allEmployeesRb.CheckedChanged += new System.EventHandler(this.allEmployeesRb_CheckedChanged);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.LightYellow;
            this.BackBtn.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackBtn.Location = new System.Drawing.Point(437, 422);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(57, 21);
            this.BackBtn.TabIndex = 39;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 456);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.allEmployeesRb);
            this.Controls.Add(this.notConfirmEmployeesRb);
            this.Controls.Add(this.ConfirmEmployessRb);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.employeesPanel);
            this.Controls.Add(this.SearchTextBox);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeesForm";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.emloyeesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel employeesPanel;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.RadioButton ConfirmEmployessRb;
        private System.Windows.Forms.RadioButton notConfirmEmployeesRb;
        private System.Windows.Forms.RadioButton allEmployeesRb;
        private System.Windows.Forms.Button BackBtn;
    }
}