namespace sport_club
{
    partial class Inventory_view
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory_view));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.переглядДанихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.персоналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.користувачіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.інвентарToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тренуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуванняДанихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новийПрацівникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуванняПрацівниківToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.розподілНавантаженняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пошукПрацівникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клієнтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новийКлієнтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуванняКлієнтівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пошукКлієнтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статусАбонементівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спорядженняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новеСпорядженняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуванняСпорядженняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пошукСпорядженняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервісToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.доспутToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переглядОбліковихЗаписівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.змінаПаролюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новийКористувачToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тренуванняToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.новеТренуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиТренуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пошукТренуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sportDataSet = new sport_club.SportDataSet();
            this.inventory1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventory1TableAdapter = new sport_club.SportDataSetTableAdapters.Inventory1TableAdapter();
            this.tableAdapterManager = new sport_club.SportDataSetTableAdapters.TableAdapterManager();
            this.inventory1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory1DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переглядДанихToolStripMenuItem,
            this.редагуванняДанихToolStripMenuItem,
            this.клієнтиToolStripMenuItem,
            this.спорядженняToolStripMenuItem,
            this.сервісToolStripMenuItem,
            this.менюToolStripMenuItem,
            this.тренуванняToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(668, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // переглядДанихToolStripMenuItem
            // 
            this.переглядДанихToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.персоналToolStripMenuItem,
            this.користувачіToolStripMenuItem,
            this.інвентарToolStripMenuItem,
            this.тренуванняToolStripMenuItem});
            this.переглядДанихToolStripMenuItem.Name = "переглядДанихToolStripMenuItem";
            this.переглядДанихToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.переглядДанихToolStripMenuItem.Text = "Перегляд даних ";
            // 
            // персоналToolStripMenuItem
            // 
            this.персоналToolStripMenuItem.Name = "персоналToolStripMenuItem";
            this.персоналToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.персоналToolStripMenuItem.Text = "Персонал";
            this.персоналToolStripMenuItem.Click += new System.EventHandler(this.персоналToolStripMenuItem_Click);
            // 
            // користувачіToolStripMenuItem
            // 
            this.користувачіToolStripMenuItem.Name = "користувачіToolStripMenuItem";
            this.користувачіToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.користувачіToolStripMenuItem.Text = "Користувачі";
            this.користувачіToolStripMenuItem.Click += new System.EventHandler(this.користувачіToolStripMenuItem_Click);
            // 
            // інвентарToolStripMenuItem
            // 
            this.інвентарToolStripMenuItem.Name = "інвентарToolStripMenuItem";
            this.інвентарToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.інвентарToolStripMenuItem.Text = "Інвентар";
            this.інвентарToolStripMenuItem.Click += new System.EventHandler(this.інвентарToolStripMenuItem_Click);
            // 
            // тренуванняToolStripMenuItem
            // 
            this.тренуванняToolStripMenuItem.Name = "тренуванняToolStripMenuItem";
            this.тренуванняToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.тренуванняToolStripMenuItem.Text = "Тренування";
            this.тренуванняToolStripMenuItem.Click += new System.EventHandler(this.тренуванняToolStripMenuItem_Click);
            // 
            // редагуванняДанихToolStripMenuItem
            // 
            this.редагуванняДанихToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новийПрацівникToolStripMenuItem,
            this.редагуванняПрацівниківToolStripMenuItem,
            this.розподілНавантаженняToolStripMenuItem,
            this.пошукПрацівникаToolStripMenuItem});
            this.редагуванняДанихToolStripMenuItem.Name = "редагуванняДанихToolStripMenuItem";
            this.редагуванняДанихToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.редагуванняДанихToolStripMenuItem.Text = "Персонал";
            // 
            // новийПрацівникToolStripMenuItem
            // 
            this.новийПрацівникToolStripMenuItem.Name = "новийПрацівникToolStripMenuItem";
            this.новийПрацівникToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.новийПрацівникToolStripMenuItem.Text = "Новий працівник";
            this.новийПрацівникToolStripMenuItem.Click += new System.EventHandler(this.новийПрацівникToolStripMenuItem_Click);
            // 
            // редагуванняПрацівниківToolStripMenuItem
            // 
            this.редагуванняПрацівниківToolStripMenuItem.Name = "редагуванняПрацівниківToolStripMenuItem";
            this.редагуванняПрацівниківToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.редагуванняПрацівниківToolStripMenuItem.Text = "Редагування працівників";
            this.редагуванняПрацівниківToolStripMenuItem.Click += new System.EventHandler(this.редагуванняПрацівниківToolStripMenuItem_Click);
            // 
            // розподілНавантаженняToolStripMenuItem
            // 
            this.розподілНавантаженняToolStripMenuItem.Name = "розподілНавантаженняToolStripMenuItem";
            this.розподілНавантаженняToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.розподілНавантаженняToolStripMenuItem.Text = "Розподіл навантаження";
            this.розподілНавантаженняToolStripMenuItem.Click += new System.EventHandler(this.розподілНавантаженняToolStripMenuItem_Click);
            // 
            // пошукПрацівникаToolStripMenuItem
            // 
            this.пошукПрацівникаToolStripMenuItem.Name = "пошукПрацівникаToolStripMenuItem";
            this.пошукПрацівникаToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.пошукПрацівникаToolStripMenuItem.Text = "Пошук працівника";
            this.пошукПрацівникаToolStripMenuItem.Click += new System.EventHandler(this.пошукПрацівникаToolStripMenuItem_Click);
            // 
            // клієнтиToolStripMenuItem
            // 
            this.клієнтиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новийКлієнтToolStripMenuItem,
            this.редагуванняКлієнтівToolStripMenuItem,
            this.пошукКлієнтаToolStripMenuItem,
            this.статусАбонементівToolStripMenuItem});
            this.клієнтиToolStripMenuItem.Name = "клієнтиToolStripMenuItem";
            this.клієнтиToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.клієнтиToolStripMenuItem.Text = "Клієнти";
            // 
            // новийКлієнтToolStripMenuItem
            // 
            this.новийКлієнтToolStripMenuItem.Name = "новийКлієнтToolStripMenuItem";
            this.новийКлієнтToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.новийКлієнтToolStripMenuItem.Text = "Новий клієнт";
            this.новийКлієнтToolStripMenuItem.Click += new System.EventHandler(this.новийКлієнтToolStripMenuItem_Click);
            // 
            // редагуванняКлієнтівToolStripMenuItem
            // 
            this.редагуванняКлієнтівToolStripMenuItem.Name = "редагуванняКлієнтівToolStripMenuItem";
            this.редагуванняКлієнтівToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.редагуванняКлієнтівToolStripMenuItem.Text = "Редагування клієнтів";
            this.редагуванняКлієнтівToolStripMenuItem.Click += new System.EventHandler(this.редагуванняКлієнтівToolStripMenuItem_Click);
            // 
            // пошукКлієнтаToolStripMenuItem
            // 
            this.пошукКлієнтаToolStripMenuItem.Name = "пошукКлієнтаToolStripMenuItem";
            this.пошукКлієнтаToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.пошукКлієнтаToolStripMenuItem.Text = "Пошук клієнта";
            this.пошукКлієнтаToolStripMenuItem.Click += new System.EventHandler(this.пошукКлієнтаToolStripMenuItem_Click);
            // 
            // статусАбонементівToolStripMenuItem
            // 
            this.статусАбонементівToolStripMenuItem.Name = "статусАбонементівToolStripMenuItem";
            this.статусАбонементівToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.статусАбонементівToolStripMenuItem.Text = "Статус абонементів";
            this.статусАбонементівToolStripMenuItem.Click += new System.EventHandler(this.статусАбонементівToolStripMenuItem_Click);
            // 
            // спорядженняToolStripMenuItem
            // 
            this.спорядженняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новеСпорядженняToolStripMenuItem,
            this.редагуванняСпорядженняToolStripMenuItem,
            this.пошукСпорядженняToolStripMenuItem});
            this.спорядженняToolStripMenuItem.Name = "спорядженняToolStripMenuItem";
            this.спорядженняToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.спорядженняToolStripMenuItem.Text = "Спорядження";
            // 
            // новеСпорядженняToolStripMenuItem
            // 
            this.новеСпорядженняToolStripMenuItem.Name = "новеСпорядженняToolStripMenuItem";
            this.новеСпорядженняToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.новеСпорядженняToolStripMenuItem.Text = "Нове спорядження";
            this.новеСпорядженняToolStripMenuItem.Click += new System.EventHandler(this.новеСпорядженняToolStripMenuItem_Click);
            // 
            // редагуванняСпорядженняToolStripMenuItem
            // 
            this.редагуванняСпорядженняToolStripMenuItem.Name = "редагуванняСпорядженняToolStripMenuItem";
            this.редагуванняСпорядженняToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.редагуванняСпорядженняToolStripMenuItem.Text = "Редагування спорядження";
            this.редагуванняСпорядженняToolStripMenuItem.Click += new System.EventHandler(this.редагуванняСпорядженняToolStripMenuItem_Click);
            // 
            // пошукСпорядженняToolStripMenuItem
            // 
            this.пошукСпорядженняToolStripMenuItem.Name = "пошукСпорядженняToolStripMenuItem";
            this.пошукСпорядженняToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.пошукСпорядженняToolStripMenuItem.Text = "Пошук спорядження";
            this.пошукСпорядженняToolStripMenuItem.Click += new System.EventHandler(this.пошукСпорядженняToolStripMenuItem_Click);
            // 
            // сервісToolStripMenuItem
            // 
            this.сервісToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.доспутToolStripMenuItem});
            this.сервісToolStripMenuItem.Name = "сервісToolStripMenuItem";
            this.сервісToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.сервісToolStripMenuItem.Text = "Сервіс";
            // 
            // доспутToolStripMenuItem
            // 
            this.доспутToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переглядОбліковихЗаписівToolStripMenuItem,
            this.змінаПаролюToolStripMenuItem,
            this.новийКористувачToolStripMenuItem});
            this.доспутToolStripMenuItem.Name = "доспутToolStripMenuItem";
            this.доспутToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.доспутToolStripMenuItem.Text = "Доступ";
            // 
            // переглядОбліковихЗаписівToolStripMenuItem
            // 
            this.переглядОбліковихЗаписівToolStripMenuItem.Name = "переглядОбліковихЗаписівToolStripMenuItem";
            this.переглядОбліковихЗаписівToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.переглядОбліковихЗаписівToolStripMenuItem.Text = "Перегляд облікових записів";
            this.переглядОбліковихЗаписівToolStripMenuItem.Click += new System.EventHandler(this.переглядОбліковихЗаписівToolStripMenuItem_Click);
            // 
            // змінаПаролюToolStripMenuItem
            // 
            this.змінаПаролюToolStripMenuItem.Name = "змінаПаролюToolStripMenuItem";
            this.змінаПаролюToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.змінаПаролюToolStripMenuItem.Text = "Зміна паролю";
            this.змінаПаролюToolStripMenuItem.Click += new System.EventHandler(this.змінаПаролюToolStripMenuItem_Click);
            // 
            // новийКористувачToolStripMenuItem
            // 
            this.новийКористувачToolStripMenuItem.Name = "новийКористувачToolStripMenuItem";
            this.новийКористувачToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.новийКористувачToolStripMenuItem.Text = "Новий користувач";
            this.новийКористувачToolStripMenuItem.Click += new System.EventHandler(this.новийКористувачToolStripMenuItem_Click);
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            this.менюToolStripMenuItem.Click += new System.EventHandler(this.менюToolStripMenuItem_Click_1);
            // 
            // тренуванняToolStripMenuItem1
            // 
            this.тренуванняToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новеТренуванняToolStripMenuItem,
            this.редагуватиТренуванняToolStripMenuItem,
            this.пошукТренуванняToolStripMenuItem});
            this.тренуванняToolStripMenuItem1.Name = "тренуванняToolStripMenuItem1";
            this.тренуванняToolStripMenuItem1.Size = new System.Drawing.Size(84, 20);
            this.тренуванняToolStripMenuItem1.Text = "Тренування";
            // 
            // новеТренуванняToolStripMenuItem
            // 
            this.новеТренуванняToolStripMenuItem.Name = "новеТренуванняToolStripMenuItem";
            this.новеТренуванняToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.новеТренуванняToolStripMenuItem.Text = "Нове тренування";
            this.новеТренуванняToolStripMenuItem.Click += new System.EventHandler(this.новеТренуванняToolStripMenuItem_Click);
            // 
            // редагуватиТренуванняToolStripMenuItem
            // 
            this.редагуватиТренуванняToolStripMenuItem.Name = "редагуватиТренуванняToolStripMenuItem";
            this.редагуватиТренуванняToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.редагуватиТренуванняToolStripMenuItem.Text = "Редагувати тренування";
            this.редагуватиТренуванняToolStripMenuItem.Click += new System.EventHandler(this.редагуватиТренуванняToolStripMenuItem_Click);
            // 
            // пошукТренуванняToolStripMenuItem
            // 
            this.пошукТренуванняToolStripMenuItem.Name = "пошукТренуванняToolStripMenuItem";
            this.пошукТренуванняToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.пошукТренуванняToolStripMenuItem.Text = "Пошук тренування";
            this.пошукТренуванняToolStripMenuItem.Click += new System.EventHandler(this.пошукТренуванняToolStripMenuItem_Click);
            // 
            // sportDataSet
            // 
            this.sportDataSet.DataSetName = "SportDataSet";
            this.sportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventory1BindingSource
            // 
            this.inventory1BindingSource.DataMember = "Inventory1";
            this.inventory1BindingSource.DataSource = this.sportDataSet;
            // 
            // inventory1TableAdapter
            // 
            this.inventory1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Customer3TableAdapter = null;
            this.tableAdapterManager.Inventory1TableAdapter = this.inventory1TableAdapter;
            this.tableAdapterManager.LogTableAdapter = null;
            this.tableAdapterManager.Sign_inTableAdapter = null;
            this.tableAdapterManager.Trainer1TableAdapter = null;
            this.tableAdapterManager.Training2TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sport_club.SportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // inventory1DataGridView
            // 
            this.inventory1DataGridView.AutoGenerateColumns = false;
            this.inventory1DataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.inventory1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventory1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.inventory1DataGridView.DataSource = this.inventory1BindingSource;
            this.inventory1DataGridView.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.inventory1DataGridView.Location = new System.Drawing.Point(0, 38);
            this.inventory1DataGridView.Name = "inventory1DataGridView";
            this.inventory1DataGridView.ReadOnly = true;
            this.inventory1DataGridView.Size = new System.Drawing.Size(654, 380);
            this.inventory1DataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Inventory_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Inventory_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Invname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Назва інвентара";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Invdescription";
            this.dataGridViewTextBoxColumn3.HeaderText = "Опис";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Кількість";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Quality";
            this.dataGridViewTextBoxColumn5.HeaderText = "Якість";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Inventory_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(668, 430);
            this.Controls.Add(this.inventory1DataGridView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventory_view";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перегляд інвентара";
            this.Load += new System.EventHandler(this.Inventory_view_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory1DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem переглядДанихToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem персоналToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem користувачіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem інвентарToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тренуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуванняДанихToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новийПрацівникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуванняПрацівниківToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem розподілНавантаженняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пошукПрацівникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клієнтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новийКлієнтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуванняКлієнтівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пошукКлієнтаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статусАбонементівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem спорядженняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новеСпорядженняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуванняСпорядженняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пошукСпорядженняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервісToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem доспутToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переглядОбліковихЗаписівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem змінаПаролюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новийКористувачToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private SportDataSet sportDataSet;
        private System.Windows.Forms.BindingSource inventory1BindingSource;
        private SportDataSetTableAdapters.Inventory1TableAdapter inventory1TableAdapter;
        private SportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView inventory1DataGridView;
        private System.Windows.Forms.ToolStripMenuItem тренуванняToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem новеТренуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиТренуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пошукТренуванняToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}