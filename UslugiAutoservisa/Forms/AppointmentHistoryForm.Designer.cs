namespace UslugiAutoservisa
{
    partial class AppointmentHistoryForm
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
            this.AppointmentsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.periodStart = new System.Windows.Forms.DateTimePicker();
            this.periodEnd = new System.Windows.Forms.DateTimePicker();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.currentPage = new System.Windows.Forms.Label();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.appointmentsCountLabel = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AppointmentsPanel
            // 
            this.AppointmentsPanel.AutoScroll = true;
            this.AppointmentsPanel.Location = new System.Drawing.Point(15, 99);
            this.AppointmentsPanel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.AppointmentsPanel.Name = "AppointmentsPanel";
            this.AppointmentsPanel.Size = new System.Drawing.Size(547, 371);
            this.AppointmentsPanel.TabIndex = 29;
            // 
            // periodStart
            // 
            this.periodStart.Location = new System.Drawing.Point(15, 29);
            this.periodStart.Name = "periodStart";
            this.periodStart.Size = new System.Drawing.Size(154, 21);
            this.periodStart.TabIndex = 30;
            this.periodStart.ValueChanged += new System.EventHandler(this.periodStart_ValueChanged);
            // 
            // periodEnd
            // 
            this.periodEnd.Location = new System.Drawing.Point(15, 69);
            this.periodEnd.Name = "periodEnd";
            this.periodEnd.Size = new System.Drawing.Size(154, 21);
            this.periodEnd.TabIndex = 31;
            this.periodEnd.ValueChanged += new System.EventHandler(this.periodEnd_ValueChanged);
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startLabel.Location = new System.Drawing.Point(15, 13);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(19, 13);
            this.startLabel.TabIndex = 32;
            this.startLabel.Text = "С:";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endLabel.Location = new System.Drawing.Point(15, 53);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(28, 13);
            this.endLabel.TabIndex = 33;
            this.endLabel.Text = "По:";
            // 
            // currentPage
            // 
            this.currentPage.AutoSize = true;
            this.currentPage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentPage.Location = new System.Drawing.Point(472, 486);
            this.currentPage.Name = "currentPage";
            this.currentPage.Size = new System.Drawing.Size(73, 13);
            this.currentPage.TabIndex = 44;
            this.currentPage.Text = "Страница:";
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(179, 9);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(50, 13);
            this.SearchLabel.TabIndex = 46;
            this.SearchLabel.Text = "Поиск:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.Color.White;
            this.SearchTextBox.Location = new System.Drawing.Point(182, 29);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(151, 21);
            this.SearchTextBox.TabIndex = 45;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            this.SearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyDown);
            // 
            // appointmentsCountLabel
            // 
            this.appointmentsCountLabel.AutoSize = true;
            this.appointmentsCountLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appointmentsCountLabel.Location = new System.Drawing.Point(441, 499);
            this.appointmentsCountLabel.Name = "appointmentsCountLabel";
            this.appointmentsCountLabel.Size = new System.Drawing.Size(104, 13);
            this.appointmentsCountLabel.TabIndex = 47;
            this.appointmentsCountLabel.Text = "Всего записей:";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.LightYellow;
            this.BackBtn.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackBtn.Location = new System.Drawing.Point(506, 13);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(57, 21);
            this.BackBtn.TabIndex = 48;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLabel.Location = new System.Drawing.Point(179, 53);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(54, 13);
            this.StatusLabel.TabIndex = 50;
            this.StatusLabel.Text = "Статус:";
            // 
            // statusComboBox
            // 
            this.statusComboBox.Items.AddRange(new object[] {
            "Все",
            "Отменен",
            "Выполнен"});
            this.statusComboBox.Location = new System.Drawing.Point(182, 69);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(151, 21);
            this.statusComboBox.TabIndex = 49;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // AppointmentHistoryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(576, 533);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.appointmentsCountLabel);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.currentPage);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.periodEnd);
            this.Controls.Add(this.periodStart);
            this.Controls.Add(this.AppointmentsPanel);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "AppointmentHistoryForm";
            this.Text = "Журнал записей";
            this.Load += new System.EventHandler(this.AppointmentHistoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel AppointmentsPanel;
        private System.Windows.Forms.DateTimePicker periodStart;
        private System.Windows.Forms.DateTimePicker periodEnd;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label currentPage;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label appointmentsCountLabel;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
    }
}