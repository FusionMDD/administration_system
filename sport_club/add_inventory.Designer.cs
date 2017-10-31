namespace sport_club
{
    partial class add_inventory
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
            System.Windows.Forms.Label qualityLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label invdescriptionLabel;
            System.Windows.Forms.Label invnameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_inventory));
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
            this.qualityTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.invdescriptionTextBox = new System.Windows.Forms.TextBox();
            this.invnameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            qualityLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            invdescriptionLabel = new System.Windows.Forms.Label();
            invnameLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // qualityLabel
            // 
            qualityLabel.AutoSize = true;
            qualityLabel.Location = new System.Drawing.Point(122, 106);
            qualityLabel.Name = "qualityLabel";
            qualityLabel.Size = new System.Drawing.Size(40, 13);
            qualityLabel.TabIndex = 10;
            qualityLabel.Text = "Якість";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(122, 67);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(53, 13);
            quantityLabel.TabIndex = 8;
            quantityLabel.Text = "Кількість";
            // 
            // invdescriptionLabel
            // 
            invdescriptionLabel.AutoSize = true;
            invdescriptionLabel.Location = new System.Drawing.Point(122, 132);
            invdescriptionLabel.Name = "invdescriptionLabel";
            invdescriptionLabel.Size = new System.Drawing.Size(33, 13);
            invdescriptionLabel.TabIndex = 6;
            invdescriptionLabel.Text = "Опис";
            // 
            // invnameLabel
            // 
            invnameLabel.AutoSize = true;
            invnameLabel.Location = new System.Drawing.Point(122, 28);
            invnameLabel.Name = "invnameLabel";
            invnameLabel.Size = new System.Drawing.Size(39, 13);
            invnameLabel.TabIndex = 4;
            invnameLabel.Text = "Назва";
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
            this.menuStrip1.Size = new System.Drawing.Size(536, 24);
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
            this.доспутToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.новийКористувачToolStripMenuItem.Click += new System.EventHandler(this.новийКористувачToolStripMenuItem_Click_1);
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
            // qualityTextBox
            // 
            this.qualityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventory1BindingSource, "Quality", true));
            this.qualityTextBox.Location = new System.Drawing.Point(204, 99);
            this.qualityTextBox.Name = "qualityTextBox";
            this.qualityTextBox.Size = new System.Drawing.Size(60, 20);
            this.qualityTextBox.TabIndex = 11;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventory1BindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(204, 60);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(27, 20);
            this.quantityTextBox.TabIndex = 9;
            // 
            // invdescriptionTextBox
            // 
            this.invdescriptionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.invdescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventory1BindingSource, "Invdescription", true));
            this.invdescriptionTextBox.Location = new System.Drawing.Point(204, 129);
            this.invdescriptionTextBox.Multiline = true;
            this.invdescriptionTextBox.Name = "invdescriptionTextBox";
            this.invdescriptionTextBox.Size = new System.Drawing.Size(152, 90);
            this.invdescriptionTextBox.TabIndex = 7;
            // 
            // invnameTextBox
            // 
            this.invnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventory1BindingSource, "Invname", true));
            this.invnameTextBox.Location = new System.Drawing.Point(204, 25);
            this.invnameTextBox.Name = "invnameTextBox";
            this.invnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.invnameTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Прийняти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(536, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(invnameLabel);
            this.Controls.Add(this.invnameTextBox);
            this.Controls.Add(invdescriptionLabel);
            this.Controls.Add(this.invdescriptionTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(qualityLabel);
            this.Controls.Add(this.qualityTextBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "add_inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додавання інвентара";
            this.Load += new System.EventHandler(this.add_inventory_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory1BindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox qualityTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox invdescriptionTextBox;
        private System.Windows.Forms.TextBox invnameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem тренуванняToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem новеТренуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиТренуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пошукТренуванняToolStripMenuItem;
    }
}