
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ChooseSubs_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьАбонентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начислитьАбонплатуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.провестиОплатуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addServiсemanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьАбонентаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.должникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.квитанцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Repair_btn = new System.Windows.Forms.Button();
            this.Adress_btn = new System.Windows.Forms.Button();
            this.Keys_btn = new System.Windows.Forms.Button();
            this.HandSet_btn = new System.Windows.Forms.Button();
            this.Domofons_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.chooseCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(394, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(778, 572);
            this.dataGridView1.TabIndex = 0;
            // 
            // ChooseSubs_btn
            // 
            this.ChooseSubs_btn.BackColor = System.Drawing.SystemColors.Control;
            this.ChooseSubs_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChooseSubs_btn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseSubs_btn.Location = new System.Drawing.Point(25, 55);
            this.ChooseSubs_btn.Name = "ChooseSubs_btn";
            this.ChooseSubs_btn.Size = new System.Drawing.Size(150, 30);
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
            this.выбратьАбонентаToolStripMenuItem,
            this.начислитьАбонплатуToolStripMenuItem,
            this.провестиОплатуToolStripMenuItem,
            this.addServiсemanToolStripMenuItem,
            this.chooseCompanyToolStripMenuItem,
            this.печатьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выбратьАбонентаToolStripMenuItem
            // 
            this.выбратьАбонентаToolStripMenuItem.Name = "выбратьАбонентаToolStripMenuItem";
            this.выбратьАбонентаToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.выбратьАбонентаToolStripMenuItem.Text = "Выбрать абонента";
            // 
            // начислитьАбонплатуToolStripMenuItem
            // 
            this.начислитьАбонплатуToolStripMenuItem.Name = "начислитьАбонплатуToolStripMenuItem";
            this.начислитьАбонплатуToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.начислитьАбонплатуToolStripMenuItem.Text = "Начислить абонплату";
            // 
            // провестиОплатуToolStripMenuItem
            // 
            this.провестиОплатуToolStripMenuItem.Name = "провестиОплатуToolStripMenuItem";
            this.провестиОплатуToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.провестиОплатуToolStripMenuItem.Text = "Провести оплату";
            // 
            // addServiсemanToolStripMenuItem
            // 
            this.addServiсemanToolStripMenuItem.Name = "addServiсemanToolStripMenuItem";
            this.addServiсemanToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.addServiсemanToolStripMenuItem.Text = "Добавить мастера";
            this.addServiсemanToolStripMenuItem.Click += new System.EventHandler(this.addServiсemanToolStripMenuItem_Click);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.печатьToolStripMenuItem.Text = "Печать";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьАбонентаToolStripMenuItem1,
            this.должникиToolStripMenuItem,
            this.квитанцииToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // выбратьАбонентаToolStripMenuItem1
            // 
            this.выбратьАбонентаToolStripMenuItem1.Name = "выбратьАбонентаToolStripMenuItem1";
            this.выбратьАбонентаToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.выбратьАбонентаToolStripMenuItem1.Text = "Выбрать абонента";
            // 
            // должникиToolStripMenuItem
            // 
            this.должникиToolStripMenuItem.Name = "должникиToolStripMenuItem";
            this.должникиToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.должникиToolStripMenuItem.Text = "Должники";
            // 
            // квитанцииToolStripMenuItem
            // 
            this.квитанцииToolStripMenuItem.Name = "квитанцииToolStripMenuItem";
            this.квитанцииToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.квитанцииToolStripMenuItem.Text = "Квитанции";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.помощьToolStripMenuItem.Text = "Помощь...";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе...";
            // 
            // Repair_btn
            // 
            this.Repair_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Repair_btn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Repair_btn.Location = new System.Drawing.Point(25, 90);
            this.Repair_btn.Name = "Repair_btn";
            this.Repair_btn.Size = new System.Drawing.Size(150, 30);
            this.Repair_btn.TabIndex = 3;
            this.Repair_btn.Text = "Журнал заявок";
            this.Repair_btn.UseVisualStyleBackColor = true;
            this.Repair_btn.Click += new System.EventHandler(this.Repair_btn_Click);
            // 
            // Adress_btn
            // 
            this.Adress_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Adress_btn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Adress_btn.Location = new System.Drawing.Point(25, 125);
            this.Adress_btn.Name = "Adress_btn";
            this.Adress_btn.Size = new System.Drawing.Size(150, 30);
            this.Adress_btn.TabIndex = 4;
            this.Adress_btn.Text = "Список адресов";
            this.Adress_btn.UseVisualStyleBackColor = true;
            this.Adress_btn.Click += new System.EventHandler(this.Adress_btn_Click);
            // 
            // Keys_btn
            // 
            this.Keys_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Keys_btn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Keys_btn.Location = new System.Drawing.Point(25, 160);
            this.Keys_btn.Name = "Keys_btn";
            this.Keys_btn.Size = new System.Drawing.Size(150, 30);
            this.Keys_btn.TabIndex = 5;
            this.Keys_btn.Text = "Ключи";
            this.Keys_btn.UseVisualStyleBackColor = true;
            this.Keys_btn.Click += new System.EventHandler(this.Keys_btn_Click);
            // 
            // HandSet_btn
            // 
            this.HandSet_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HandSet_btn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HandSet_btn.Location = new System.Drawing.Point(25, 195);
            this.HandSet_btn.Name = "HandSet_btn";
            this.HandSet_btn.Size = new System.Drawing.Size(150, 30);
            this.HandSet_btn.TabIndex = 6;
            this.HandSet_btn.Text = "Виды трубок";
            this.HandSet_btn.UseVisualStyleBackColor = true;
            this.HandSet_btn.Click += new System.EventHandler(this.HandSet_btn_Click);
            // 
            // Domofons_btn
            // 
            this.Domofons_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Domofons_btn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Domofons_btn.Location = new System.Drawing.Point(25, 230);
            this.Domofons_btn.Name = "Domofons_btn";
            this.Domofons_btn.Size = new System.Drawing.Size(150, 30);
            this.Domofons_btn.TabIndex = 7;
            this.Domofons_btn.Text = "Виды домофонов";
            this.Domofons_btn.UseVisualStyleBackColor = true;
            this.Domofons_btn.Click += new System.EventHandler(this.Domofons_btn_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(15, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(145, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(275, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 45);
            this.button3.TabIndex = 10;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // chooseCompanyToolStripMenuItem
            // 
            this.chooseCompanyToolStripMenuItem.Name = "chooseCompanyToolStripMenuItem";
            this.chooseCompanyToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.chooseCompanyToolStripMenuItem.Text = "Выбрать компанию";
            this.chooseCompanyToolStripMenuItem.Click += new System.EventHandler(this.chooseCompanyToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ChooseSubs_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьАбонентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начислитьАбонплатуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem провестиОплатуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьАбонентаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem должникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem квитанцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button Repair_btn;
        private System.Windows.Forms.Button Adress_btn;
        private System.Windows.Forms.Button Keys_btn;
        private System.Windows.Forms.Button HandSet_btn;
        private System.Windows.Forms.Button Domofons_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem addServiсemanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseCompanyToolStripMenuItem;
    }
}

