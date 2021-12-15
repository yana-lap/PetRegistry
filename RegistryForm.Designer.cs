
namespace PetRegistry
{
    partial class RegistryForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.реестрЖивотныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.реестрВладельцевToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.физическиеЛицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.юридическиеЛицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моиДомашниеЖивотныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.sortPetButton = new System.Windows.Forms.Button();
            this.deletePetButton = new System.Windows.Forms.Button();
            this.openPetButton = new System.Windows.Forms.Button();
            this.addPetButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.exportPetDataButton = new System.Windows.Forms.Button();
            this.petFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.ownerCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.ownerTypeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.genderCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.categoryCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.birthDate2 = new System.Windows.Forms.DateTimePicker();
            this.getPetParams = new System.Windows.Forms.Button();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.ownerLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.sortOwnerUserButton = new System.Windows.Forms.Button();
            this.ownerFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.catsNumberFrom = new System.Windows.Forms.TextBox();
            this.catsNumberTo = new System.Windows.Forms.TextBox();
            this.dogsNumberTo = new System.Windows.Forms.TextBox();
            this.dogsNumberFrom = new System.Windows.Forms.TextBox();
            this.petsNumberTo = new System.Windows.Forms.TextBox();
            this.petsNumberFrom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ownerCompanyCountryCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.countryUsersCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.getOwnerUsersParams = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.petFilterGroupBox.SuspendLayout();
            this.ownerFilterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.реестрЖивотныхToolStripMenuItem,
            this.реестрВладельцевToolStripMenuItem,
            this.моиДомашниеЖивотныеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1229, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // реестрЖивотныхToolStripMenuItem
            // 
            this.реестрЖивотныхToolStripMenuItem.Name = "реестрЖивотныхToolStripMenuItem";
            this.реестрЖивотныхToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.реестрЖивотныхToolStripMenuItem.Text = "Реест животных";
            this.реестрЖивотныхToolStripMenuItem.Visible = false;
            this.реестрЖивотныхToolStripMenuItem.Click += new System.EventHandler(this.реестрЖивотныхToolStripMenuItem_Click);
            // 
            // реестрВладельцевToolStripMenuItem
            // 
            this.реестрВладельцевToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.физическиеЛицаToolStripMenuItem,
            this.юридическиеЛицаToolStripMenuItem});
            this.реестрВладельцевToolStripMenuItem.Name = "реестрВладельцевToolStripMenuItem";
            this.реестрВладельцевToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.реестрВладельцевToolStripMenuItem.Text = "Реестр владельцев";
            this.реестрВладельцевToolStripMenuItem.Visible = false;
            // 
            // физическиеЛицаToolStripMenuItem
            // 
            this.физическиеЛицаToolStripMenuItem.Name = "физическиеЛицаToolStripMenuItem";
            this.физическиеЛицаToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.физическиеЛицаToolStripMenuItem.Text = "Физические лица";
            this.физическиеЛицаToolStripMenuItem.Click += new System.EventHandler(this.физическиеЛицаToolStripMenuItem_Click);
            // 
            // юридическиеЛицаToolStripMenuItem
            // 
            this.юридическиеЛицаToolStripMenuItem.Name = "юридическиеЛицаToolStripMenuItem";
            this.юридическиеЛицаToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.юридическиеЛицаToolStripMenuItem.Text = "Юридические лица";
            this.юридическиеЛицаToolStripMenuItem.Click += new System.EventHandler(this.юридическиеЛицаToolStripMenuItem_Click);
            // 
            // моиДомашниеЖивотныеToolStripMenuItem
            // 
            this.моиДомашниеЖивотныеToolStripMenuItem.Name = "моиДомашниеЖивотныеToolStripMenuItem";
            this.моиДомашниеЖивотныеToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.моиДомашниеЖивотныеToolStripMenuItem.Text = "Мои домашние животные";
            this.моиДомашниеЖивотныеToolStripMenuItem.Visible = false;
            this.моиДомашниеЖивотныеToolStripMenuItem.Click += new System.EventHandler(this.моиДомашниеЖивотныеToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(23, 130);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(1193, 409);
            this.dataGridView.TabIndex = 11;
            // 
            // sortPetButton
            // 
            this.sortPetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortPetButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sortPetButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.sortPetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortPetButton.ForeColor = System.Drawing.Color.CadetBlue;
            this.sortPetButton.Location = new System.Drawing.Point(988, 80);
            this.sortPetButton.Margin = new System.Windows.Forms.Padding(4);
            this.sortPetButton.Name = "sortPetButton";
            this.sortPetButton.Size = new System.Drawing.Size(228, 28);
            this.sortPetButton.TabIndex = 10;
            this.sortPetButton.Text = "Параметры фильтрации...";
            this.sortPetButton.UseVisualStyleBackColor = false;
            this.sortPetButton.Visible = false;
            this.sortPetButton.Click += new System.EventHandler(this.sortPetButton_Click);
            // 
            // deletePetButton
            // 
            this.deletePetButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deletePetButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.deletePetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePetButton.ForeColor = System.Drawing.Color.CadetBlue;
            this.deletePetButton.Location = new System.Drawing.Point(239, 80);
            this.deletePetButton.Margin = new System.Windows.Forms.Padding(4);
            this.deletePetButton.Name = "deletePetButton";
            this.deletePetButton.Size = new System.Drawing.Size(100, 28);
            this.deletePetButton.TabIndex = 9;
            this.deletePetButton.Text = "Удалить";
            this.deletePetButton.UseVisualStyleBackColor = false;
            this.deletePetButton.Visible = false;
            this.deletePetButton.Click += new System.EventHandler(this.deletePetButton_Click);
            // 
            // openPetButton
            // 
            this.openPetButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.openPetButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.openPetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openPetButton.ForeColor = System.Drawing.Color.CadetBlue;
            this.openPetButton.Location = new System.Drawing.Point(131, 80);
            this.openPetButton.Margin = new System.Windows.Forms.Padding(4);
            this.openPetButton.Name = "openPetButton";
            this.openPetButton.Size = new System.Drawing.Size(100, 28);
            this.openPetButton.TabIndex = 8;
            this.openPetButton.Text = "Открыть";
            this.openPetButton.UseVisualStyleBackColor = false;
            this.openPetButton.Visible = false;
            this.openPetButton.Click += new System.EventHandler(this.openPetButton_Click);
            // 
            // addPetButton
            // 
            this.addPetButton.BackColor = System.Drawing.Color.CadetBlue;
            this.addPetButton.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.addPetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPetButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addPetButton.Location = new System.Drawing.Point(23, 80);
            this.addPetButton.Margin = new System.Windows.Forms.Padding(4);
            this.addPetButton.Name = "addPetButton";
            this.addPetButton.Size = new System.Drawing.Size(100, 28);
            this.addPetButton.TabIndex = 7;
            this.addPetButton.Text = "Добавить";
            this.addPetButton.UseVisualStyleBackColor = false;
            this.addPetButton.Visible = false;
            this.addPetButton.Click += new System.EventHandler(this.addPetButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.Color.CadetBlue;
            this.label.Location = new System.Drawing.Point(17, 46);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(49, 31);
            this.label.TabIndex = 6;
            this.label.Text = "     ";
            // 
            // exportPetDataButton
            // 
            this.exportPetDataButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exportPetDataButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.exportPetDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportPetDataButton.ForeColor = System.Drawing.Color.CadetBlue;
            this.exportPetDataButton.Location = new System.Drawing.Point(383, 80);
            this.exportPetDataButton.Margin = new System.Windows.Forms.Padding(4);
            this.exportPetDataButton.Name = "exportPetDataButton";
            this.exportPetDataButton.Size = new System.Drawing.Size(115, 28);
            this.exportPetDataButton.TabIndex = 12;
            this.exportPetDataButton.Text = "Экспорт";
            this.exportPetDataButton.UseVisualStyleBackColor = false;
            this.exportPetDataButton.Visible = false;
            this.exportPetDataButton.Click += new System.EventHandler(this.exportPetDataButton_Click);
            // 
            // petFilterGroupBox
            // 
            this.petFilterGroupBox.Controls.Add(this.ownerCheckedListBox);
            this.petFilterGroupBox.Controls.Add(this.ownerTypeCheckedListBox);
            this.petFilterGroupBox.Controls.Add(this.genderCheckedListBox);
            this.petFilterGroupBox.Controls.Add(this.categoryCheckedListBox);
            this.petFilterGroupBox.Controls.Add(this.label3);
            this.petFilterGroupBox.Controls.Add(this.label1);
            this.petFilterGroupBox.Controls.Add(this.birthDate2);
            this.petFilterGroupBox.Controls.Add(this.getPetParams);
            this.petFilterGroupBox.Controls.Add(this.birthDate);
            this.petFilterGroupBox.Controls.Add(this.label2);
            this.petFilterGroupBox.Controls.Add(this.ownerLabel);
            this.petFilterGroupBox.Controls.Add(this.typeLabel);
            this.petFilterGroupBox.Controls.Add(this.genderLabel);
            this.petFilterGroupBox.Controls.Add(this.categoryLabel);
            this.petFilterGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.petFilterGroupBox.Location = new System.Drawing.Point(797, 114);
            this.petFilterGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.petFilterGroupBox.Name = "petFilterGroupBox";
            this.petFilterGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.petFilterGroupBox.Size = new System.Drawing.Size(419, 425);
            this.petFilterGroupBox.TabIndex = 13;
            this.petFilterGroupBox.TabStop = false;
            this.petFilterGroupBox.Visible = false;
            // 
            // ownerCheckedListBox
            // 
            this.ownerCheckedListBox.CheckOnClick = true;
            this.ownerCheckedListBox.FormattingEnabled = true;
            this.ownerCheckedListBox.Location = new System.Drawing.Point(233, 279);
            this.ownerCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ownerCheckedListBox.Name = "ownerCheckedListBox";
            this.ownerCheckedListBox.Size = new System.Drawing.Size(159, 38);
            this.ownerCheckedListBox.TabIndex = 140;
            // 
            // ownerTypeCheckedListBox
            // 
            this.ownerTypeCheckedListBox.CheckOnClick = true;
            this.ownerTypeCheckedListBox.FormattingEnabled = true;
            this.ownerTypeCheckedListBox.Items.AddRange(new object[] {
            "Физическое лицо",
            "Юридическое лицо"});
            this.ownerTypeCheckedListBox.Location = new System.Drawing.Point(233, 220);
            this.ownerTypeCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ownerTypeCheckedListBox.Name = "ownerTypeCheckedListBox";
            this.ownerTypeCheckedListBox.Size = new System.Drawing.Size(159, 38);
            this.ownerTypeCheckedListBox.TabIndex = 139;
            this.ownerTypeCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.ownerTypeCheckedListBox_SelectedIndexChanged);
            // 
            // genderCheckedListBox
            // 
            this.genderCheckedListBox.CheckOnClick = true;
            this.genderCheckedListBox.FormattingEnabled = true;
            this.genderCheckedListBox.Items.AddRange(new object[] {
            "Женский",
            "Мужской"});
            this.genderCheckedListBox.Location = new System.Drawing.Point(233, 94);
            this.genderCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genderCheckedListBox.Name = "genderCheckedListBox";
            this.genderCheckedListBox.Size = new System.Drawing.Size(159, 38);
            this.genderCheckedListBox.TabIndex = 138;
            // 
            // categoryCheckedListBox
            // 
            this.categoryCheckedListBox.CheckOnClick = true;
            this.categoryCheckedListBox.FormattingEnabled = true;
            this.categoryCheckedListBox.Items.AddRange(new object[] {
            "Кошка",
            "Собака"});
            this.categoryCheckedListBox.Location = new System.Drawing.Point(233, 32);
            this.categoryCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryCheckedListBox.Name = "categoryCheckedListBox";
            this.categoryCheckedListBox.Size = new System.Drawing.Size(159, 38);
            this.categoryCheckedListBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.CadetBlue;
            this.label3.Location = new System.Drawing.Point(195, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 137;
            this.label3.Text = "до";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(196, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 136;
            this.label1.Text = "от";
            // 
            // birthDate2
            // 
            this.birthDate2.Location = new System.Drawing.Point(233, 188);
            this.birthDate2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.birthDate2.Name = "birthDate2";
            this.birthDate2.Size = new System.Drawing.Size(159, 22);
            this.birthDate2.TabIndex = 135;
            // 
            // getPetParams
            // 
            this.getPetParams.BackColor = System.Drawing.Color.CadetBlue;
            this.getPetParams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getPetParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getPetParams.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.getPetParams.Location = new System.Drawing.Point(233, 354);
            this.getPetParams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getPetParams.Name = "getPetParams";
            this.getPetParams.Size = new System.Drawing.Size(155, 32);
            this.getPetParams.TabIndex = 125;
            this.getPetParams.Text = "Oк";
            this.getPetParams.UseVisualStyleBackColor = false;
            this.getPetParams.Click += new System.EventHandler(this.getPetParams_Click);
            // 
            // birthDate
            // 
            this.birthDate.Location = new System.Drawing.Point(233, 155);
            this.birthDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(159, 22);
            this.birthDate.TabIndex = 118;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(15, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 117;
            this.label2.Text = "Дата рождения";
            // 
            // ownerLabel
            // 
            this.ownerLabel.AutoSize = true;
            this.ownerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownerLabel.ForeColor = System.Drawing.Color.CadetBlue;
            this.ownerLabel.Location = new System.Drawing.Point(15, 279);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(101, 20);
            this.ownerLabel.TabIndex = 115;
            this.ownerLabel.Text = "Владелец";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.ForeColor = System.Drawing.Color.CadetBlue;
            this.typeLabel.Location = new System.Drawing.Point(15, 220);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(149, 20);
            this.typeLabel.TabIndex = 114;
            this.typeLabel.Text = "Тип владельца";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genderLabel.ForeColor = System.Drawing.Color.CadetBlue;
            this.genderLabel.Location = new System.Drawing.Point(15, 94);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(45, 20);
            this.genderLabel.TabIndex = 107;
            this.genderLabel.Text = "Пол";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryLabel.ForeColor = System.Drawing.Color.CadetBlue;
            this.categoryLabel.Location = new System.Drawing.Point(15, 32);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(107, 20);
            this.categoryLabel.TabIndex = 106;
            this.categoryLabel.Text = "Категория";
            // 
            // sortOwnerUserButton
            // 
            this.sortOwnerUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortOwnerUserButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sortOwnerUserButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.sortOwnerUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortOwnerUserButton.ForeColor = System.Drawing.Color.CadetBlue;
            this.sortOwnerUserButton.Location = new System.Drawing.Point(985, 80);
            this.sortOwnerUserButton.Margin = new System.Windows.Forms.Padding(4);
            this.sortOwnerUserButton.Name = "sortOwnerUserButton";
            this.sortOwnerUserButton.Size = new System.Drawing.Size(228, 28);
            this.sortOwnerUserButton.TabIndex = 14;
            this.sortOwnerUserButton.Text = "Параметры фильтрации...";
            this.sortOwnerUserButton.UseVisualStyleBackColor = false;
            this.sortOwnerUserButton.Visible = false;
            this.sortOwnerUserButton.Click += new System.EventHandler(this.sortOwnerUserButton_Click);
            // 
            // ownerFilterGroupBox
            // 
            this.ownerFilterGroupBox.Controls.Add(this.label12);
            this.ownerFilterGroupBox.Controls.Add(this.label13);
            this.ownerFilterGroupBox.Controls.Add(this.label11);
            this.ownerFilterGroupBox.Controls.Add(this.catsNumberFrom);
            this.ownerFilterGroupBox.Controls.Add(this.catsNumberTo);
            this.ownerFilterGroupBox.Controls.Add(this.dogsNumberTo);
            this.ownerFilterGroupBox.Controls.Add(this.dogsNumberFrom);
            this.ownerFilterGroupBox.Controls.Add(this.petsNumberTo);
            this.ownerFilterGroupBox.Controls.Add(this.petsNumberFrom);
            this.ownerFilterGroupBox.Controls.Add(this.label7);
            this.ownerFilterGroupBox.Controls.Add(this.label8);
            this.ownerFilterGroupBox.Controls.Add(this.label9);
            this.ownerFilterGroupBox.Controls.Add(this.ownerCompanyCountryCheckedListBox);
            this.ownerFilterGroupBox.Controls.Add(this.countryUsersCheckListBox);
            this.ownerFilterGroupBox.Controls.Add(this.label4);
            this.ownerFilterGroupBox.Controls.Add(this.label5);
            this.ownerFilterGroupBox.Controls.Add(this.getOwnerUsersParams);
            this.ownerFilterGroupBox.Controls.Add(this.label6);
            this.ownerFilterGroupBox.Controls.Add(this.label10);
            this.ownerFilterGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ownerFilterGroupBox.Location = new System.Drawing.Point(752, 114);
            this.ownerFilterGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ownerFilterGroupBox.Name = "ownerFilterGroupBox";
            this.ownerFilterGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ownerFilterGroupBox.Size = new System.Drawing.Size(419, 425);
            this.ownerFilterGroupBox.TabIndex = 141;
            this.ownerFilterGroupBox.TabStop = false;
            this.ownerFilterGroupBox.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.CadetBlue;
            this.label12.Location = new System.Drawing.Point(192, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 20);
            this.label12.TabIndex = 149;
            this.label12.Text = "до";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.CadetBlue;
            this.label13.Location = new System.Drawing.Point(193, 256);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 20);
            this.label13.TabIndex = 148;
            this.label13.Text = "от";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.CadetBlue;
            this.label11.Location = new System.Drawing.Point(8, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 20);
            this.label11.TabIndex = 147;
            this.label11.Text = "Кол-во кошек";
            // 
            // catsNumberFrom
            // 
            this.catsNumberFrom.Location = new System.Drawing.Point(233, 255);
            this.catsNumberFrom.Margin = new System.Windows.Forms.Padding(4);
            this.catsNumberFrom.Name = "catsNumberFrom";
            this.catsNumberFrom.Size = new System.Drawing.Size(159, 22);
            this.catsNumberFrom.TabIndex = 146;
            // 
            // catsNumberTo
            // 
            this.catsNumberTo.Location = new System.Drawing.Point(233, 287);
            this.catsNumberTo.Margin = new System.Windows.Forms.Padding(4);
            this.catsNumberTo.Name = "catsNumberTo";
            this.catsNumberTo.Size = new System.Drawing.Size(159, 22);
            this.catsNumberTo.TabIndex = 145;
            // 
            // dogsNumberTo
            // 
            this.dogsNumberTo.Location = new System.Drawing.Point(233, 203);
            this.dogsNumberTo.Margin = new System.Windows.Forms.Padding(4);
            this.dogsNumberTo.Name = "dogsNumberTo";
            this.dogsNumberTo.Size = new System.Drawing.Size(159, 22);
            this.dogsNumberTo.TabIndex = 144;
            // 
            // dogsNumberFrom
            // 
            this.dogsNumberFrom.Location = new System.Drawing.Point(233, 171);
            this.dogsNumberFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dogsNumberFrom.Name = "dogsNumberFrom";
            this.dogsNumberFrom.Size = new System.Drawing.Size(159, 22);
            this.dogsNumberFrom.TabIndex = 143;
            // 
            // petsNumberTo
            // 
            this.petsNumberTo.Location = new System.Drawing.Point(233, 121);
            this.petsNumberTo.Margin = new System.Windows.Forms.Padding(4);
            this.petsNumberTo.Name = "petsNumberTo";
            this.petsNumberTo.Size = new System.Drawing.Size(159, 22);
            this.petsNumberTo.TabIndex = 142;
            // 
            // petsNumberFrom
            // 
            this.petsNumberFrom.Location = new System.Drawing.Point(233, 90);
            this.petsNumberFrom.Margin = new System.Windows.Forms.Padding(4);
            this.petsNumberFrom.Name = "petsNumberFrom";
            this.petsNumberFrom.Size = new System.Drawing.Size(159, 22);
            this.petsNumberFrom.TabIndex = 141;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.CadetBlue;
            this.label7.Location = new System.Drawing.Point(191, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 140;
            this.label7.Text = "до";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.CadetBlue;
            this.label8.Location = new System.Drawing.Point(192, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 139;
            this.label8.Text = "от";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.CadetBlue;
            this.label9.Location = new System.Drawing.Point(8, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 20);
            this.label9.TabIndex = 138;
            this.label9.Text = "Кол-во собак";
            // 
            // ownerCompanyCountryCheckedListBox
            // 
            this.ownerCompanyCountryCheckedListBox.CheckOnClick = true;
            this.ownerCompanyCountryCheckedListBox.FormattingEnabled = true;
            this.ownerCompanyCountryCheckedListBox.Location = new System.Drawing.Point(233, 36);
            this.ownerCompanyCountryCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ownerCompanyCountryCheckedListBox.Name = "ownerCompanyCountryCheckedListBox";
            this.ownerCompanyCountryCheckedListBox.Size = new System.Drawing.Size(159, 38);
            this.ownerCompanyCountryCheckedListBox.TabIndex = 14;
            // 
            // countryUsersCheckListBox
            // 
            this.countryUsersCheckListBox.CheckOnClick = true;
            this.countryUsersCheckListBox.FormattingEnabled = true;
            this.countryUsersCheckListBox.Location = new System.Drawing.Point(233, 36);
            this.countryUsersCheckListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countryUsersCheckListBox.Name = "countryUsersCheckListBox";
            this.countryUsersCheckListBox.Size = new System.Drawing.Size(159, 38);
            this.countryUsersCheckListBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.CadetBlue;
            this.label4.Location = new System.Drawing.Point(192, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 137;
            this.label4.Text = "до";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.CadetBlue;
            this.label5.Location = new System.Drawing.Point(193, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 136;
            this.label5.Text = "от";
            // 
            // getOwnerUsersParams
            // 
            this.getOwnerUsersParams.BackColor = System.Drawing.Color.CadetBlue;
            this.getOwnerUsersParams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getOwnerUsersParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getOwnerUsersParams.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.getOwnerUsersParams.Location = new System.Drawing.Point(233, 354);
            this.getOwnerUsersParams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getOwnerUsersParams.Name = "getOwnerUsersParams";
            this.getOwnerUsersParams.Size = new System.Drawing.Size(155, 32);
            this.getOwnerUsersParams.TabIndex = 125;
            this.getOwnerUsersParams.Text = "Oк";
            this.getOwnerUsersParams.UseVisualStyleBackColor = false;
            this.getOwnerUsersParams.Click += new System.EventHandler(this.getOwnerUsersParams_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.CadetBlue;
            this.label6.Location = new System.Drawing.Point(8, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 20);
            this.label6.TabIndex = 117;
            this.label6.Text = "Кол-во животных";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.CadetBlue;
            this.label10.Location = new System.Drawing.Point(8, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 106;
            this.label10.Text = "Страна";
            // 
            // RegistryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1229, 554);
            this.Controls.Add(this.ownerFilterGroupBox);
            this.Controls.Add(this.petFilterGroupBox);
            this.Controls.Add(this.exportPetDataButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.sortPetButton);
            this.Controls.Add(this.deletePetButton);
            this.Controls.Add(this.openPetButton);
            this.Controls.Add(this.addPetButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.sortOwnerUserButton);
            this.Controls.Add(this.dataGridView);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реестры";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.petFilterGroupBox.ResumeLayout(false);
            this.petFilterGroupBox.PerformLayout();
            this.ownerFilterGroupBox.ResumeLayout(false);
            this.ownerFilterGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem реестрЖивотныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem реестрВладельцевToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button sortPetButton;
        private System.Windows.Forms.Button deletePetButton;
        private System.Windows.Forms.Button openPetButton;
        private System.Windows.Forms.Button addPetButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ToolStripMenuItem физическиеЛицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem юридическиеЛицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem моиДомашниеЖивотныеToolStripMenuItem;
        private System.Windows.Forms.Button exportPetDataButton;
        private System.Windows.Forms.GroupBox petFilterGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker birthDate2;
        private System.Windows.Forms.Button getPetParams;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ownerLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.CheckedListBox genderCheckedListBox;
        private System.Windows.Forms.CheckedListBox categoryCheckedListBox;
        private System.Windows.Forms.CheckedListBox ownerCheckedListBox;
        private System.Windows.Forms.CheckedListBox ownerTypeCheckedListBox;
        private System.Windows.Forms.Button sortOwnerUserButton;
        private System.Windows.Forms.GroupBox ownerFilterGroupBox;
        private System.Windows.Forms.CheckedListBox countryUsersCheckListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button getOwnerUsersParams;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox catsNumberFrom;
        private System.Windows.Forms.TextBox catsNumberTo;
        private System.Windows.Forms.TextBox dogsNumberTo;
        private System.Windows.Forms.TextBox dogsNumberFrom;
        private System.Windows.Forms.TextBox petsNumberTo;
        private System.Windows.Forms.TextBox petsNumberFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckedListBox ownerCompanyCountryCheckedListBox;
    }
}