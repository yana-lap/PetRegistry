
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
            this.exportButton = new System.Windows.Forms.Button();
            this.petGroupBox = new System.Windows.Forms.GroupBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.ownerLabel = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.getPetParams = new System.Windows.Forms.Button();
            this.ownerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.ownerComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.birthDate2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.petGroupBox.SuspendLayout();
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
            this.label.Location = new System.Drawing.Point(17, 45);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(49, 31);
            this.label.TabIndex = 6;
            this.label.Text = "     ";
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exportButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportButton.ForeColor = System.Drawing.Color.CadetBlue;
            this.exportButton.Location = new System.Drawing.Point(383, 80);
            this.exportButton.Margin = new System.Windows.Forms.Padding(4);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(115, 28);
            this.exportButton.TabIndex = 12;
            this.exportButton.Text = "Экспорт";
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Visible = false;
            this.exportButton.Click += new System.EventHandler(this.rabiesButton_Click);
            // 
            // petGroupBox
            // 
            this.petGroupBox.Controls.Add(this.listBox1);
            this.petGroupBox.Controls.Add(this.label3);
            this.petGroupBox.Controls.Add(this.label1);
            this.petGroupBox.Controls.Add(this.birthDate2);
            this.petGroupBox.Controls.Add(this.ownerComboBox);
            this.petGroupBox.Controls.Add(this.categoryComboBox);
            this.petGroupBox.Controls.Add(this.ownerTypeComboBox);
            this.petGroupBox.Controls.Add(this.getPetParams);
            this.petGroupBox.Controls.Add(this.birthDate);
            this.petGroupBox.Controls.Add(this.label2);
            this.petGroupBox.Controls.Add(this.genderComboBox);
            this.petGroupBox.Controls.Add(this.ownerLabel);
            this.petGroupBox.Controls.Add(this.typeLabel);
            this.petGroupBox.Controls.Add(this.genderLabel);
            this.petGroupBox.Controls.Add(this.categoryLabel);
            this.petGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.petGroupBox.Location = new System.Drawing.Point(532, 115);
            this.petGroupBox.Name = "petGroupBox";
            this.petGroupBox.Size = new System.Drawing.Size(684, 327);
            this.petGroupBox.TabIndex = 13;
            this.petGroupBox.TabStop = false;
            this.petGroupBox.Visible = false;
            this.petGroupBox.Enter += new System.EventHandler(this.petGroupBox_Enter);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryLabel.ForeColor = System.Drawing.Color.CadetBlue;
            this.categoryLabel.Location = new System.Drawing.Point(19, 32);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(107, 20);
            this.categoryLabel.TabIndex = 106;
            this.categoryLabel.Text = "Категория";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genderLabel.ForeColor = System.Drawing.Color.CadetBlue;
            this.genderLabel.Location = new System.Drawing.Point(19, 67);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(45, 20);
            this.genderLabel.TabIndex = 107;
            this.genderLabel.Text = "Пол";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.ForeColor = System.Drawing.Color.CadetBlue;
            this.typeLabel.Location = new System.Drawing.Point(24, 170);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(149, 20);
            this.typeLabel.TabIndex = 114;
            this.typeLabel.Text = "Тип владельца";
            // 
            // ownerLabel
            // 
            this.ownerLabel.AutoSize = true;
            this.ownerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownerLabel.ForeColor = System.Drawing.Color.CadetBlue;
            this.ownerLabel.Location = new System.Drawing.Point(24, 206);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(101, 20);
            this.ownerLabel.TabIndex = 115;
            this.ownerLabel.Text = "Владелец";
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.genderComboBox.Location = new System.Drawing.Point(238, 74);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(154, 24);
            this.genderComboBox.TabIndex = 116;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(19, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 117;
            this.label2.Text = "Дата рождения";
            // 
            // birthDate
            // 
            this.birthDate.Location = new System.Drawing.Point(237, 109);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(154, 22);
            this.birthDate.TabIndex = 118;
            // 
            // getPetParams
            // 
            this.getPetParams.BackColor = System.Drawing.Color.CadetBlue;
            this.getPetParams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getPetParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getPetParams.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.getPetParams.Location = new System.Drawing.Point(237, 244);
            this.getPetParams.Name = "getPetParams";
            this.getPetParams.Size = new System.Drawing.Size(154, 32);
            this.getPetParams.TabIndex = 125;
            this.getPetParams.Text = "Oк";
            this.getPetParams.UseVisualStyleBackColor = false;
            this.getPetParams.Click += new System.EventHandler(this.getPetParams_Click);
            // 
            // ownerTypeComboBox
            // 
            this.ownerTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ownerTypeComboBox.FormattingEnabled = true;
            this.ownerTypeComboBox.Items.AddRange(new object[] {
            "Физическое лицо",
            "Юридическое лицо"});
            this.ownerTypeComboBox.Location = new System.Drawing.Point(238, 170);
            this.ownerTypeComboBox.Name = "ownerTypeComboBox";
            this.ownerTypeComboBox.Size = new System.Drawing.Size(154, 24);
            this.ownerTypeComboBox.TabIndex = 126;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Кошка",
            "Собака"});
            this.categoryComboBox.Location = new System.Drawing.Point(238, 32);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(154, 24);
            this.categoryComboBox.TabIndex = 127;
            // 
            // ownerComboBox
            // 
            this.ownerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ownerComboBox.FormattingEnabled = true;
            this.ownerComboBox.Location = new System.Drawing.Point(238, 206);
            this.ownerComboBox.Name = "ownerComboBox";
            this.ownerComboBox.Size = new System.Drawing.Size(154, 24);
            this.ownerComboBox.TabIndex = 128;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.CadetBlue;
            this.label3.Location = new System.Drawing.Point(198, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 137;
            this.label3.Text = "до";
            // 
            // birthDate2
            // 
            this.birthDate2.Location = new System.Drawing.Point(237, 142);
            this.birthDate2.Name = "birthDate2";
            this.birthDate2.Size = new System.Drawing.Size(154, 22);
            this.birthDate2.TabIndex = 135;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(200, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 136;
            this.label1.Text = "от";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.listBox1.Location = new System.Drawing.Point(437, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(224, 84);
            this.listBox1.TabIndex = 138;
            // 
            // RegistryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1229, 554);
            this.Controls.Add(this.petGroupBox);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.sortPetButton);
            this.Controls.Add(this.deletePetButton);
            this.Controls.Add(this.openPetButton);
            this.Controls.Add(this.addPetButton);
            this.Controls.Add(this.label);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реестры";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.petGroupBox.ResumeLayout(false);
            this.petGroupBox.PerformLayout();
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
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.GroupBox petGroupBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker birthDate2;
        private System.Windows.Forms.ComboBox ownerComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox ownerTypeComboBox;
        private System.Windows.Forms.Button getPetParams;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label ownerLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label categoryLabel;
    }
}