namespace UslugiAutoservisa
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LoginButton = new System.Windows.Forms.Button();
            this.userInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.userPositionLabel = new System.Windows.Forms.Label();
            this.patronymicNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.SortLabel = new System.Windows.Forms.Label();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SortComboBox = new System.Windows.Forms.ComboBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.servicesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.appointmentsBtn = new System.Windows.Forms.Button();
            this.customersFormBtn = new System.Windows.Forms.Button();
            this.employeesBtn = new System.Windows.Forms.Button();
            this.currentPage = new System.Windows.Forms.Label();
            this.addServiceBtn = new System.Windows.Forms.Button();
            this.AppointmentHistroryBtn = new System.Windows.Forms.Button();
            this.servicesCountLabel = new System.Windows.Forms.Label();
            this.logoPbox = new System.Windows.Forms.PictureBox();
            this.PartsStorageBtn = new System.Windows.Forms.Button();
            this.userInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPbox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.LightYellow;
            this.LoginButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.Location = new System.Drawing.Point(695, 16);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(130, 51);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Вход";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // userInfoGroupBox
            // 
            this.userInfoGroupBox.Controls.Add(this.userPositionLabel);
            this.userInfoGroupBox.Controls.Add(this.patronymicNameLabel);
            this.userInfoGroupBox.Controls.Add(this.firstNameLabel);
            this.userInfoGroupBox.Controls.Add(this.lastNameLabel);
            this.userInfoGroupBox.Location = new System.Drawing.Point(695, 82);
            this.userInfoGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userInfoGroupBox.Name = "userInfoGroupBox";
            this.userInfoGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userInfoGroupBox.Size = new System.Drawing.Size(132, 101);
            this.userInfoGroupBox.TabIndex = 1;
            this.userInfoGroupBox.TabStop = false;
            // 
            // userPositionLabel
            // 
            this.userPositionLabel.AutoSize = true;
            this.userPositionLabel.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userPositionLabel.Location = new System.Drawing.Point(9, 76);
            this.userPositionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userPositionLabel.Name = "userPositionLabel";
            this.userPositionLabel.Size = new System.Drawing.Size(0, 12);
            this.userPositionLabel.TabIndex = 3;
            // 
            // patronymicNameLabel
            // 
            this.patronymicNameLabel.AutoSize = true;
            this.patronymicNameLabel.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymicNameLabel.Location = new System.Drawing.Point(9, 56);
            this.patronymicNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patronymicNameLabel.Name = "patronymicNameLabel";
            this.patronymicNameLabel.Size = new System.Drawing.Size(0, 12);
            this.patronymicNameLabel.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameLabel.Location = new System.Drawing.Point(9, 36);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(0, 12);
            this.firstNameLabel.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameLabel.Location = new System.Drawing.Point(9, 16);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(0, 12);
            this.lastNameLabel.TabIndex = 0;
            // 
            // SortLabel
            // 
            this.SortLabel.AutoSize = true;
            this.SortLabel.Location = new System.Drawing.Point(374, 11);
            this.SortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SortLabel.Name = "SortLabel";
            this.SortLabel.Size = new System.Drawing.Size(131, 20);
            this.SortLabel.TabIndex = 35;
            this.SortLabel.Text = "Сортировка:";
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(85, 15);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(75, 20);
            this.SearchLabel.TabIndex = 33;
            this.SearchLabel.Text = "Поиск:";
            // 
            // SortComboBox
            // 
            this.SortComboBox.BackColor = System.Drawing.Color.Ivory;
            this.SortComboBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortComboBox.FormattingEnabled = true;
            this.SortComboBox.Items.AddRange(new object[] {
            "Нет",
            "По возрастанию",
            "По Убыванию"});
            this.SortComboBox.Location = new System.Drawing.Point(378, 40);
            this.SortComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SortComboBox.Name = "SortComboBox";
            this.SortComboBox.Size = new System.Drawing.Size(154, 26);
            this.SortComboBox.TabIndex = 32;
            this.SortComboBox.SelectedIndexChanged += new System.EventHandler(this.SortComboBox_SelectedIndexChanged);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.Color.Ivory;
            this.SearchTextBox.Location = new System.Drawing.Point(89, 39);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(280, 27);
            this.SearchTextBox.TabIndex = 30;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            this.SearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyDown);
            // 
            // servicesPanel
            // 
            this.servicesPanel.AutoScroll = true;
            this.servicesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.servicesPanel.Location = new System.Drawing.Point(15, 94);
            this.servicesPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.servicesPanel.Name = "servicesPanel";
            this.servicesPanel.Size = new System.Drawing.Size(668, 600);
            this.servicesPanel.TabIndex = 36;
            this.servicesPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.servicesPanel_Paint);
            // 
            // appointmentsBtn
            // 
            this.appointmentsBtn.BackColor = System.Drawing.Color.LightYellow;
            this.appointmentsBtn.Location = new System.Drawing.Point(695, 191);
            this.appointmentsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.appointmentsBtn.Name = "appointmentsBtn";
            this.appointmentsBtn.Size = new System.Drawing.Size(132, 61);
            this.appointmentsBtn.TabIndex = 38;
            this.appointmentsBtn.Text = "Активные записи";
            this.appointmentsBtn.UseVisualStyleBackColor = false;
            this.appointmentsBtn.Visible = false;
            this.appointmentsBtn.Click += new System.EventHandler(this.appointmentsBtn_Click);
            // 
            // customersFormBtn
            // 
            this.customersFormBtn.BackColor = System.Drawing.Color.LightYellow;
            this.customersFormBtn.Location = new System.Drawing.Point(695, 630);
            this.customersFormBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customersFormBtn.Name = "customersFormBtn";
            this.customersFormBtn.Size = new System.Drawing.Size(132, 65);
            this.customersFormBtn.TabIndex = 41;
            this.customersFormBtn.Text = "Клиенты";
            this.customersFormBtn.UseVisualStyleBackColor = false;
            this.customersFormBtn.Visible = false;
            this.customersFormBtn.Click += new System.EventHandler(this.customersFormBtn_Click);
            // 
            // employeesBtn
            // 
            this.employeesBtn.BackColor = System.Drawing.Color.LightYellow;
            this.employeesBtn.Location = new System.Drawing.Point(695, 558);
            this.employeesBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.employeesBtn.Name = "employeesBtn";
            this.employeesBtn.Size = new System.Drawing.Size(132, 65);
            this.employeesBtn.TabIndex = 42;
            this.employeesBtn.Text = "Сотрудники";
            this.employeesBtn.UseVisualStyleBackColor = false;
            this.employeesBtn.Visible = false;
            this.employeesBtn.Click += new System.EventHandler(this.employeesBtn_Click);
            // 
            // currentPage
            // 
            this.currentPage.AutoSize = true;
            this.currentPage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentPage.Location = new System.Drawing.Point(539, 710);
            this.currentPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentPage.Name = "currentPage";
            this.currentPage.Size = new System.Drawing.Size(91, 17);
            this.currentPage.TabIndex = 43;
            this.currentPage.Text = "Страница:";
            // 
            // addServiceBtn
            // 
            this.addServiceBtn.BackColor = System.Drawing.Color.LightYellow;
            this.addServiceBtn.Location = new System.Drawing.Point(695, 329);
            this.addServiceBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addServiceBtn.Name = "addServiceBtn";
            this.addServiceBtn.Size = new System.Drawing.Size(130, 62);
            this.addServiceBtn.TabIndex = 44;
            this.addServiceBtn.Text = "Добавить услугу";
            this.addServiceBtn.UseVisualStyleBackColor = false;
            this.addServiceBtn.Click += new System.EventHandler(this.addServiceBtn_Click);
            // 
            // AppointmentHistroryBtn
            // 
            this.AppointmentHistroryBtn.BackColor = System.Drawing.Color.LightYellow;
            this.AppointmentHistroryBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.AppointmentHistroryBtn.FlatAppearance.BorderSize = 5;
            this.AppointmentHistroryBtn.Location = new System.Drawing.Point(695, 260);
            this.AppointmentHistroryBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AppointmentHistroryBtn.Name = "AppointmentHistroryBtn";
            this.AppointmentHistroryBtn.Size = new System.Drawing.Size(132, 61);
            this.AppointmentHistroryBtn.TabIndex = 45;
            this.AppointmentHistroryBtn.Text = "История записей";
            this.AppointmentHistroryBtn.UseVisualStyleBackColor = false;
            this.AppointmentHistroryBtn.Visible = false;
            this.AppointmentHistroryBtn.Click += new System.EventHandler(this.AppointmentHistroryBt_Click);
            // 
            // servicesCountLabel
            // 
            this.servicesCountLabel.AutoSize = true;
            this.servicesCountLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.servicesCountLabel.Location = new System.Drawing.Point(539, 726);
            this.servicesCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.servicesCountLabel.Name = "servicesCountLabel";
            this.servicesCountLabel.Size = new System.Drawing.Size(109, 17);
            this.servicesCountLabel.TabIndex = 46;
            this.servicesCountLabel.Text = "Всего услуг:";
            // 
            // logoPbox
            // 
            this.logoPbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoPbox.Image = global::UslugiAutoservisa.Properties.Resources.logo;
            this.logoPbox.Location = new System.Drawing.Point(15, 15);
            this.logoPbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoPbox.Name = "logoPbox";
            this.logoPbox.Size = new System.Drawing.Size(62, 62);
            this.logoPbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPbox.TabIndex = 47;
            this.logoPbox.TabStop = false;
            // 
            // PartsStorageBtn
            // 
            this.PartsStorageBtn.BackColor = System.Drawing.Color.LightYellow;
            this.PartsStorageBtn.Location = new System.Drawing.Point(695, 488);
            this.PartsStorageBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PartsStorageBtn.Name = "PartsStorageBtn";
            this.PartsStorageBtn.Size = new System.Drawing.Size(130, 62);
            this.PartsStorageBtn.TabIndex = 48;
            this.PartsStorageBtn.Text = "Склад запчастей";
            this.PartsStorageBtn.UseVisualStyleBackColor = false;
            this.PartsStorageBtn.Visible = false;
            this.PartsStorageBtn.Click += new System.EventHandler(this.PartsStorageBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(840, 754);
            this.Controls.Add(this.PartsStorageBtn);
            this.Controls.Add(this.logoPbox);
            this.Controls.Add(this.servicesCountLabel);
            this.Controls.Add(this.AppointmentHistroryBtn);
            this.Controls.Add(this.addServiceBtn);
            this.Controls.Add(this.currentPage);
            this.Controls.Add(this.employeesBtn);
            this.Controls.Add(this.customersFormBtn);
            this.Controls.Add(this.appointmentsBtn);
            this.Controls.Add(this.servicesPanel);
            this.Controls.Add(this.SortLabel);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SortComboBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.userInfoGroupBox);
            this.Controls.Add(this.LoginButton);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.Name = "MainForm";
            this.Text = "Услуги автосервиса";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.userInfoGroupBox.ResumeLayout(false);
            this.userInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.GroupBox userInfoGroupBox;
        private System.Windows.Forms.Label userPositionLabel;
        private System.Windows.Forms.Label patronymicNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label SortLabel;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.ComboBox SortComboBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.FlowLayoutPanel servicesPanel;
        private System.Windows.Forms.Button appointmentsBtn;
        private System.Windows.Forms.Button customersFormBtn;
        private System.Windows.Forms.Button employeesBtn;
        private System.Windows.Forms.Label currentPage;
        private System.Windows.Forms.Button addServiceBtn;
        private System.Windows.Forms.Button AppointmentHistroryBtn;
        private System.Windows.Forms.Label servicesCountLabel;
        private System.Windows.Forms.PictureBox logoPbox;
        private System.Windows.Forms.Button PartsStorageBtn;
    }
}

