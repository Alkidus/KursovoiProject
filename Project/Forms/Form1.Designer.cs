
namespace Project
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ChooseSubs_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeAccrualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addServiсemanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToPDF_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debtorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keysToAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findSurnameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.font_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.color_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.default_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.help_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Repair_btn = new System.Windows.Forms.Button();
            this.Adress_btn = new System.Windows.Forms.Button();
            this.Keys_btn = new System.Windows.Forms.Button();
            this.HandSet_btn = new System.Windows.Forms.Button();
            this.Domofons_btn = new System.Windows.Forms.Button();
            this.ADD_btn = new System.Windows.Forms.Button();
            this.CHAGE_btn = new System.Windows.Forms.Button();
            this.DELL_btn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.payments_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Back_btn = new System.Windows.Forms.Button();
            this.repairs_by_date_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairs_by_subscriber_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairs_by_address_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(394, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(778, 572);
            this.dataGridView1.TabIndex = 0;
            // 
            // ChooseSubs_btn
            // 
            this.ChooseSubs_btn.BackColor = System.Drawing.SystemColors.Control;
            this.ChooseSubs_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChooseSubs_btn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseSubs_btn.Location = new System.Drawing.Point(20, 100);
            this.ChooseSubs_btn.Name = "ChooseSubs_btn";
            this.ChooseSubs_btn.Size = new System.Drawing.Size(200, 45);
            this.ChooseSubs_btn.TabIndex = 1;
            this.ChooseSubs_btn.Text = "Выбрать абонента";
            this.ChooseSubs_btn.UseVisualStyleBackColor = false;
            this.ChooseSubs_btn.Click += new System.EventHandler(this.ChooseSubs_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.форматToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeAccrualToolStripMenuItem,
            this.addServiсemanToolStripMenuItem,
            this.chooseCompanyToolStripMenuItem,
            this.saveToPDF_ToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // makeAccrualToolStripMenuItem
            // 
            this.makeAccrualToolStripMenuItem.Name = "makeAccrualToolStripMenuItem";
            this.makeAccrualToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.makeAccrualToolStripMenuItem.Text = "Начислить абонплату";
            this.makeAccrualToolStripMenuItem.Click += new System.EventHandler(this.makeAccrualToolStripMenuItem_Click);
            // 
            // addServiсemanToolStripMenuItem
            // 
            this.addServiсemanToolStripMenuItem.Name = "addServiсemanToolStripMenuItem";
            this.addServiсemanToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.addServiсemanToolStripMenuItem.Text = "Мастера по ремонту";
            this.addServiсemanToolStripMenuItem.Click += new System.EventHandler(this.addServiсemanToolStripMenuItem_Click);
            // 
            // chooseCompanyToolStripMenuItem
            // 
            this.chooseCompanyToolStripMenuItem.Name = "chooseCompanyToolStripMenuItem";
            this.chooseCompanyToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.chooseCompanyToolStripMenuItem.Text = "Выбрать компанию";
            this.chooseCompanyToolStripMenuItem.Click += new System.EventHandler(this.chooseCompanyToolStripMenuItem_Click);
            // 
            // saveToPDF_ToolStripMenuItem
            // 
            this.saveToPDF_ToolStripMenuItem.Name = "saveToPDF_ToolStripMenuItem";
            this.saveToPDF_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.saveToPDF_ToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.saveToPDF_ToolStripMenuItem.Text = "Сохранить таблицу в pdf";
            this.saveToPDF_ToolStripMenuItem.Click += new System.EventHandler(this.saveToPDF_ToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debtorsToolStripMenuItem,
            this.receiptsToolStripMenuItem,
            this.generalReportToolStripMenuItem,
            this.keysToAddressToolStripMenuItem,
            this.findSurnameToolStripMenuItem,
            this.findCodeToolStripMenuItem,
            this.repairs_by_date_ToolStripMenuItem,
            this.repairs_by_subscriber_ToolStripMenuItem,
            this.repairs_by_address_ToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // debtorsToolStripMenuItem
            // 
            this.debtorsToolStripMenuItem.Name = "debtorsToolStripMenuItem";
            this.debtorsToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.debtorsToolStripMenuItem.Text = "Должники";
            this.debtorsToolStripMenuItem.Click += new System.EventHandler(this.debtorsToolStripMenuItem_Click);
            // 
            // receiptsToolStripMenuItem
            // 
            this.receiptsToolStripMenuItem.Name = "receiptsToolStripMenuItem";
            this.receiptsToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.receiptsToolStripMenuItem.Text = "Квитанции";
            // 
            // generalReportToolStripMenuItem
            // 
            this.generalReportToolStripMenuItem.Name = "generalReportToolStripMenuItem";
            this.generalReportToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.generalReportToolStripMenuItem.Text = "Общий отчет текущего состояния";
            this.generalReportToolStripMenuItem.Click += new System.EventHandler(this.generalReportToolStripMenuItem_Click);
            // 
            // keysToAddressToolStripMenuItem
            // 
            this.keysToAddressToolStripMenuItem.Name = "keysToAddressToolStripMenuItem";
            this.keysToAddressToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.keysToAddressToolStripMenuItem.Text = "Ключи по адресам";
            this.keysToAddressToolStripMenuItem.Click += new System.EventHandler(this.keysToAddressToolStripMenuItem_Click);
            // 
            // findSurnameToolStripMenuItem
            // 
            this.findSurnameToolStripMenuItem.Name = "findSurnameToolStripMenuItem";
            this.findSurnameToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.findSurnameToolStripMenuItem.Text = "Поиск по фамилии";
            this.findSurnameToolStripMenuItem.Click += new System.EventHandler(this.findSurnameToolStripMenuItem_Click);
            // 
            // findCodeToolStripMenuItem
            // 
            this.findCodeToolStripMenuItem.Name = "findCodeToolStripMenuItem";
            this.findCodeToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.findCodeToolStripMenuItem.Text = "Поиск по коду абонента";
            this.findCodeToolStripMenuItem.Click += new System.EventHandler(this.findCodeToolStripMenuItem_Click);
            // 
            // форматToolStripMenuItem
            // 
            this.форматToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.font_ToolStripMenuItem,
            this.color_ToolStripMenuItem,
            this.default_ToolStripMenuItem});
            this.форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            this.форматToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.форматToolStripMenuItem.Text = "Формат";
            // 
            // font_ToolStripMenuItem
            // 
            this.font_ToolStripMenuItem.Name = "font_ToolStripMenuItem";
            this.font_ToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.font_ToolStripMenuItem.Text = "Шрифт...";
            this.font_ToolStripMenuItem.Click += new System.EventHandler(this.font_ToolStripMenuItem_Click);
            // 
            // color_ToolStripMenuItem
            // 
            this.color_ToolStripMenuItem.Name = "color_ToolStripMenuItem";
            this.color_ToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.color_ToolStripMenuItem.Text = "Цвет...";
            this.color_ToolStripMenuItem.Click += new System.EventHandler(this.color_ToolStripMenuItem_Click);
            // 
            // default_ToolStripMenuItem
            // 
            this.default_ToolStripMenuItem.Name = "default_ToolStripMenuItem";
            this.default_ToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.default_ToolStripMenuItem.Text = "По умолчанию";
            this.default_ToolStripMenuItem.Click += new System.EventHandler(this.default_ToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.help_ToolStripMenuItem,
            this.about_ToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // help_ToolStripMenuItem
            // 
            this.help_ToolStripMenuItem.Name = "help_ToolStripMenuItem";
            this.help_ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.help_ToolStripMenuItem.Text = "Помощь...";
            // 
            // about_ToolStripMenuItem
            // 
            this.about_ToolStripMenuItem.Name = "about_ToolStripMenuItem";
            this.about_ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.about_ToolStripMenuItem.Text = "О программе...";
            this.about_ToolStripMenuItem.Click += new System.EventHandler(this.about_ToolStripMenuItem_Click);
            // 
            // Repair_btn
            // 
            this.Repair_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Repair_btn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Repair_btn.Location = new System.Drawing.Point(20, 150);
            this.Repair_btn.Name = "Repair_btn";
            this.Repair_btn.Size = new System.Drawing.Size(200, 45);
            this.Repair_btn.TabIndex = 3;
            this.Repair_btn.Text = "Журнал заявок";
            this.Repair_btn.UseVisualStyleBackColor = true;
            this.Repair_btn.Click += new System.EventHandler(this.Repair_btn_Click);
            // 
            // Adress_btn
            // 
            this.Adress_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Adress_btn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Adress_btn.Location = new System.Drawing.Point(20, 50);
            this.Adress_btn.Name = "Adress_btn";
            this.Adress_btn.Size = new System.Drawing.Size(200, 45);
            this.Adress_btn.TabIndex = 4;
            this.Adress_btn.Text = "Список адресов";
            this.Adress_btn.UseVisualStyleBackColor = true;
            this.Adress_btn.Click += new System.EventHandler(this.Adress_btn_Click);
            // 
            // Keys_btn
            // 
            this.Keys_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Keys_btn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Keys_btn.Location = new System.Drawing.Point(20, 200);
            this.Keys_btn.Name = "Keys_btn";
            this.Keys_btn.Size = new System.Drawing.Size(200, 45);
            this.Keys_btn.TabIndex = 5;
            this.Keys_btn.Text = "Ключи";
            this.Keys_btn.UseVisualStyleBackColor = true;
            this.Keys_btn.Click += new System.EventHandler(this.Keys_btn_Click);
            // 
            // HandSet_btn
            // 
            this.HandSet_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HandSet_btn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HandSet_btn.Location = new System.Drawing.Point(20, 250);
            this.HandSet_btn.Name = "HandSet_btn";
            this.HandSet_btn.Size = new System.Drawing.Size(200, 45);
            this.HandSet_btn.TabIndex = 6;
            this.HandSet_btn.Text = "Виды трубок";
            this.HandSet_btn.UseVisualStyleBackColor = true;
            this.HandSet_btn.Click += new System.EventHandler(this.HandSet_btn_Click);
            // 
            // Domofons_btn
            // 
            this.Domofons_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Domofons_btn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Domofons_btn.Location = new System.Drawing.Point(20, 300);
            this.Domofons_btn.Name = "Domofons_btn";
            this.Domofons_btn.Size = new System.Drawing.Size(200, 45);
            this.Domofons_btn.TabIndex = 7;
            this.Domofons_btn.Text = "Виды домофонов";
            this.Domofons_btn.UseVisualStyleBackColor = true;
            this.Domofons_btn.Click += new System.EventHandler(this.Domofons_btn_Click);
            // 
            // ADD_btn
            // 
            this.ADD_btn.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ADD_btn.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.ADD_btn.FlatAppearance.BorderSize = 3;
            this.ADD_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.ADD_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ADD_btn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADD_btn.ForeColor = System.Drawing.Color.Green;
            this.ADD_btn.Location = new System.Drawing.Point(7, 395);
            this.ADD_btn.Name = "ADD_btn";
            this.ADD_btn.Size = new System.Drawing.Size(120, 45);
            this.ADD_btn.TabIndex = 8;
            this.ADD_btn.Text = "Добавить";
            this.ADD_btn.UseVisualStyleBackColor = true;
            this.ADD_btn.Click += new System.EventHandler(this.ADD_btn_Click);
            // 
            // CHAGE_btn
            // 
            this.CHAGE_btn.Cursor = System.Windows.Forms.Cursors.Cross;
            this.CHAGE_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.CHAGE_btn.FlatAppearance.BorderSize = 3;
            this.CHAGE_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.CHAGE_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHAGE_btn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CHAGE_btn.ForeColor = System.Drawing.Color.Blue;
            this.CHAGE_btn.Location = new System.Drawing.Point(137, 395);
            this.CHAGE_btn.Name = "CHAGE_btn";
            this.CHAGE_btn.Size = new System.Drawing.Size(120, 45);
            this.CHAGE_btn.TabIndex = 9;
            this.CHAGE_btn.Text = "Изменить";
            this.CHAGE_btn.UseVisualStyleBackColor = true;
            this.CHAGE_btn.Click += new System.EventHandler(this.CHAGE_btn_Click);
            // 
            // DELL_btn
            // 
            this.DELL_btn.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DELL_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.DELL_btn.FlatAppearance.BorderSize = 3;
            this.DELL_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.DELL_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DELL_btn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DELL_btn.ForeColor = System.Drawing.Color.Red;
            this.DELL_btn.Location = new System.Drawing.Point(267, 395);
            this.DELL_btn.Name = "DELL_btn";
            this.DELL_btn.Size = new System.Drawing.Size(120, 45);
            this.DELL_btn.TabIndex = 10;
            this.DELL_btn.Text = "Удалить";
            this.DELL_btn.UseVisualStyleBackColor = true;
            this.DELL_btn.Click += new System.EventHandler(this.DELL_btn_Click);
            // 
            // payments_btn
            // 
            this.payments_btn.Cursor = System.Windows.Forms.Cursors.Cross;
            this.payments_btn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.payments_btn.FlatAppearance.BorderSize = 3;
            this.payments_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.payments_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payments_btn.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payments_btn.ForeColor = System.Drawing.Color.Blue;
            this.payments_btn.Location = new System.Drawing.Point(15, 471);
            this.payments_btn.Name = "payments_btn";
            this.payments_btn.Size = new System.Drawing.Size(360, 47);
            this.payments_btn.TabIndex = 11;
            this.payments_btn.Text = "Оплаты";
            this.payments_btn.UseVisualStyleBackColor = true;
            this.payments_btn.Click += new System.EventHandler(this.payments_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Операции с компанией:";
            // 
            // Back_btn
            // 
            this.Back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_btn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_btn.Image = ((System.Drawing.Image)(resources.GetObject("Back_btn.Image")));
            this.Back_btn.Location = new System.Drawing.Point(287, 27);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(105, 55);
            this.Back_btn.TabIndex = 13;
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // repairs_by_date_ToolStripMenuItem
            // 
            this.repairs_by_date_ToolStripMenuItem.Name = "repairs_by_date_ToolStripMenuItem";
            this.repairs_by_date_ToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.repairs_by_date_ToolStripMenuItem.Text = "Вывести заявки на дату";
            this.repairs_by_date_ToolStripMenuItem.Click += new System.EventHandler(this.repairs_by_date_ToolStripMenuItem_Click);
            // 
            // repairs_by_subscriber_ToolStripMenuItem
            // 
            this.repairs_by_subscriber_ToolStripMenuItem.Name = "repairs_by_subscriber_ToolStripMenuItem";
            this.repairs_by_subscriber_ToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.repairs_by_subscriber_ToolStripMenuItem.Text = "Все заявки по выбранному абоненту";
            this.repairs_by_subscriber_ToolStripMenuItem.Click += new System.EventHandler(this.repairs_by_subscriber_ToolStripMenuItem_Click);
            // 
            // repairs_by_address_ToolStripMenuItem
            // 
            this.repairs_by_address_ToolStripMenuItem.Name = "repairs_by_address_ToolStripMenuItem";
            this.repairs_by_address_ToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.repairs_by_address_ToolStripMenuItem.Text = "Все заявки по выбранному адресу";
            this.repairs_by_address_ToolStripMenuItem.Click += new System.EventHandler(this.repairs_by_address_ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.payments_btn);
            this.Controls.Add(this.DELL_btn);
            this.Controls.Add(this.CHAGE_btn);
            this.Controls.Add(this.ADD_btn);
            this.Controls.Add(this.Domofons_btn);
            this.Controls.Add(this.HandSet_btn);
            this.Controls.Add(this.Keys_btn);
            this.Controls.Add(this.Adress_btn);
            this.Controls.Add(this.Repair_btn);
            this.Controls.Add(this.ChooseSubs_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ChooseSubs_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeAccrualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToPDF_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debtorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem help_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem about_ToolStripMenuItem;
        private System.Windows.Forms.Button Repair_btn;
        private System.Windows.Forms.Button Adress_btn;
        private System.Windows.Forms.Button Keys_btn;
        private System.Windows.Forms.Button HandSet_btn;
        private System.Windows.Forms.Button Domofons_btn;
        private System.Windows.Forms.Button ADD_btn;
        private System.Windows.Forms.Button CHAGE_btn;
        private System.Windows.Forms.Button DELL_btn;
        private System.Windows.Forms.ToolStripMenuItem addServiсemanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseCompanyToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem форматToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem font_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem color_ToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem default_ToolStripMenuItem;
        private System.Windows.Forms.Button payments_btn;
        private System.Windows.Forms.ToolStripMenuItem generalReportToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.ToolStripMenuItem findSurnameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keysToAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repairs_by_date_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repairs_by_subscriber_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repairs_by_address_ToolStripMenuItem;
    }
}

