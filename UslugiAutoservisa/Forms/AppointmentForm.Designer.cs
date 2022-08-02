namespace UslugiAutoservisa
{
    partial class AppointmentForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AppointmentsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.logoPbox = new System.Windows.Forms.PictureBox();
            this.appointmentsCountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPbox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AppointmentsPanel
            // 
            this.AppointmentsPanel.AutoScroll = true;
            this.AppointmentsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AppointmentsPanel.Location = new System.Drawing.Point(12, 68);
            this.AppointmentsPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AppointmentsPanel.Name = "AppointmentsPanel";
            this.AppointmentsPanel.Size = new System.Drawing.Size(550, 352);
            this.AppointmentsPanel.TabIndex = 28;
            this.AppointmentsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AppointmentsPanel_Paint);
            // 
            // statusComboBox
            // 
            this.statusComboBox.Items.AddRange(new object[] {
            "Все",
            "Не подтвержден",
            "Ожидает",
            "В работе"});
            this.statusComboBox.Location = new System.Drawing.Point(259, 29);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 21);
            this.statusComboBox.TabIndex = 29;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLabel.Location = new System.Drawing.Point(256, 13);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(54, 13);
            this.StatusLabel.TabIndex = 30;
            this.StatusLabel.Text = "Статус:";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.LightYellow;
            this.BackBtn.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackBtn.Location = new System.Drawing.Point(505, 13);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(57, 21);
            this.BackBtn.TabIndex = 31;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchLabel.Location = new System.Drawing.Point(68, 13);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(50, 13);
            this.SearchLabel.TabIndex = 32;
            this.SearchLabel.Text = "Поиск:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.Ivory;
            this.searchTextBox.Location = new System.Drawing.Point(68, 29);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(184, 21);
            this.searchTextBox.TabIndex = 33;
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
            // 
            // logoPbox
            // 
            this.logoPbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoPbox.Location = new System.Drawing.Point(12, 12);
            this.logoPbox.Name = "logoPbox";
            this.logoPbox.Size = new System.Drawing.Size(50, 50);
            this.logoPbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPbox.TabIndex = 34;
            this.logoPbox.TabStop = false;
            // 
            // appointmentsCountLabel
            // 
            this.appointmentsCountLabel.AutoSize = true;
            this.appointmentsCountLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appointmentsCountLabel.Location = new System.Drawing.Point(439, 428);
            this.appointmentsCountLabel.Name = "appointmentsCountLabel";
            this.appointmentsCountLabel.Size = new System.Drawing.Size(104, 13);
            this.appointmentsCountLabel.TabIndex = 47;
            this.appointmentsCountLabel.Text = "Всего записей:";
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.appointmentsCountLabel);
            this.Controls.Add(this.logoPbox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.AppointmentsPanel);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AppointmentForm";
            this.Text = " Активные записи";
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel AppointmentsPanel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.PictureBox logoPbox;
        private System.Windows.Forms.Label appointmentsCountLabel;
    }
}