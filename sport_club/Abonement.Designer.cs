namespace sport_club
{
    partial class Abonement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abonement));
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
            this.редагуватиТренуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пошукТренуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новеТренуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.sportDataSet = new sport_club.SportDataSet();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new sport_club.SportDataSetTableAdapters.DataTable1TableAdapter();
            this.tableAdapterManager = new sport_club.SportDataSetTableAdapters.TableAdapterManager();
            this.dataTable1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1DataGridView)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(701, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            this.персоналToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.персоналToolStripMenuItem.Text = "Персонал";
            this.персоналToolStripMenuItem.Click += new System.EventHandler(this.персоналToolStripMenuItem_Click);
            // 
            // користувачіToolStripMenuItem
            // 
            this.користувачіToolStripMenuItem.Name = "користувачіToolStripMenuItem";
            this.користувачіToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.користувачіToolStripMenuItem.Text = "Користувачі";
            this.користувачіToolStripMenuItem.Click += new System.EventHandler(this.користувачіToolStripMenuItem_Click);
            // 
            // інвентарToolStripMenuItem
            // 
            this.інвентарToolStripMenuItem.Name = "інвентарToolStripMenuItem";
            this.інвентарToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.інвентарToolStripMenuItem.Text = "Інвентар";
            this.інвентарToolStripMenuItem.Click += new System.EventHandler(this.інвентарToolStripMenuItem_Click);
            // 
            // тренуванняToolStripMenuItem
            // 
            this.тренуванняToolStripMenuItem.Name = "тренуванняToolStripMenuItem";
            this.тренуванняToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.редагуватиТренуванняToolStripMenuItem,
            this.пошукТренуванняToolStripMenuItem,
            this.новеТренуванняToolStripMenuItem});
            this.тренуванняToolStripMenuItem1.Name = "тренуванняToolStripMenuItem1";
            this.тренуванняToolStripMenuItem1.Size = new System.Drawing.Size(84, 20);
            this.тренуванняToolStripMenuItem1.Text = "Тренування";
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
            // новеТренуванняToolStripMenuItem
            // 
            this.новеТренуванняToolStripMenuItem.Name = "новеТренуванняToolStripMenuItem";
            this.новеТренуванняToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.новеТренуванняToolStripMenuItem.Text = "Нове тренування";
            this.новеТренуванняToolStripMenuItem.Click += new System.EventHandler(this.новеТренуванняToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Перевірка абонементів";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sportDataSet
            // 
            this.sportDataSet.DataSetName = "SportDataSet";
            this.sportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.sportDataSet;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Customer3TableAdapter = null;
            this.tableAdapterManager.Inventory1TableAdapter = null;
            this.tableAdapterManager.LogTableAdapter = null;
            this.tableAdapterManager.Sign_inTableAdapter = null;
            this.tableAdapterManager.Trainer1TableAdapter = null;
            this.tableAdapterManager.Training2TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sport_club.SportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataTable1DataGridView
            // 
            this.dataTable1DataGridView.AutoGenerateColumns = false;
            this.dataTable1DataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataTable1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataTable1DataGridView.DataSource = this.dataTable1BindingSource;
            this.dataTable1DataGridView.Location = new System.Drawing.Point(12, 37);
            this.dataTable1DataGridView.Name = "dataTable1DataGridView";
            this.dataTable1DataGridView.ReadOnly = true;
            this.dataTable1DataGridView.Size = new System.Drawing.Size(463, 393);
            this.dataTable1DataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cfname";
            this.dataGridViewTextBoxColumn1.HeaderText = "Ім\'я клієнта";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Csname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамілія клієнта";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Abonement";
            this.dataGridViewTextBoxColumn3.HeaderText = "Абонемент до";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Sname";
            this.dataGridViewTextBoxColumn4.HeaderText = "Фамілія тренера";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(508, 87);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(153, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Лишилось меньше 7 днів";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(508, 111);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(156, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Лишилось меньше14 днів";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(508, 135);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(167, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Лишилось меньше 1 місяця";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(508, 159);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(144, 17);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "Просрочені до 1 місяця";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(508, 182);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(157, 17);
            this.checkBox5.TabIndex = 8;
            this.checkBox5.Text = "Просрочені більше місяця";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // Abonement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(701, 442);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataTable1DataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Abonement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Абонементи";
            this.Load += new System.EventHandler(this.Abonement_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1DataGridView)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem тренуванняToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem редагуватиТренуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пошукТренуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новеТренуванняToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private SportDataSet sportDataSet;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private SportDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private SportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataTable1DataGridView;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}