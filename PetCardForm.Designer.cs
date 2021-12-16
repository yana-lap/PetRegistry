
namespace PetRegistry
{
    partial class PetCardForm
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
            this.petCardTabControl = new System.Windows.Forms.TabControl();
            this.petCharacteristicsTab = new System.Windows.Forms.TabPage();
            this.owner = new System.Windows.Forms.TextBox();
            this.ownerType = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.TextBox();
            this.ownerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ownerComboBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.petName = new System.Windows.Forms.TextBox();
            this.breed = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.registrationDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vacinationTab = new System.Windows.Forms.TabPage();
            this.vacinationDateEnd = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.vacinationDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dewormingTab = new System.Windows.Forms.TabPage();
            this.dewormingDateEnd = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dewormingDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.vetAppointmentsTab = new System.Windows.Forms.TabPage();
            this.vetAppointments = new System.Windows.Forms.TextBox();
            this.documentsTab = new System.Windows.Forms.TabPage();
            this.chipNum = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.identificationNum = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.passportNum = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.changeCardButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.petCardTabControl.SuspendLayout();
            this.petCharacteristicsTab.SuspendLayout();
            this.vacinationTab.SuspendLayout();
            this.dewormingTab.SuspendLayout();
            this.vetAppointmentsTab.SuspendLayout();
            this.documentsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // petCardTabControl
            // 
            this.petCardTabControl.Controls.Add(this.petCharacteristicsTab);
            this.petCardTabControl.Controls.Add(this.vacinationTab);
            this.petCardTabControl.Controls.Add(this.dewormingTab);
            this.petCardTabControl.Controls.Add(this.vetAppointmentsTab);
            this.petCardTabControl.Controls.Add(this.documentsTab);
            this.petCardTabControl.Location = new System.Drawing.Point(0, 98);
            this.petCardTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.petCardTabControl.Name = "petCardTabControl";
            this.petCardTabControl.SelectedIndex = 0;
            this.petCardTabControl.Size = new System.Drawing.Size(1067, 454);
            this.petCardTabControl.TabIndex = 0;
            // 
            // petCharacteristicsTab
            // 
            this.petCharacteristicsTab.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.petCharacteristicsTab.Controls.Add(this.owner);
            this.petCharacteristicsTab.Controls.Add(this.ownerType);
            this.petCharacteristicsTab.Controls.Add(this.category);
            this.petCharacteristicsTab.Controls.Add(this.gender);
            this.petCharacteristicsTab.Controls.Add(this.ownerTypeComboBox);
            this.petCharacteristicsTab.Controls.Add(this.label15);
            this.petCharacteristicsTab.Controls.Add(this.ownerComboBox);
            this.petCharacteristicsTab.Controls.Add(this.label14);
            this.petCharacteristicsTab.Controls.Add(this.petName);
            this.petCharacteristicsTab.Controls.Add(this.breed);
            this.petCharacteristicsTab.Controls.Add(this.categoryComboBox);
            this.petCharacteristicsTab.Controls.Add(this.genderComboBox);
            this.petCharacteristicsTab.Controls.Add(this.birthDate);
            this.petCharacteristicsTab.Controls.Add(this.registrationDate);
            this.petCharacteristicsTab.Controls.Add(this.label7);
            this.petCharacteristicsTab.Controls.Add(this.label6);
            this.petCharacteristicsTab.Controls.Add(this.label5);
            this.petCharacteristicsTab.Controls.Add(this.label4);
            this.petCharacteristicsTab.Controls.Add(this.label3);
            this.petCharacteristicsTab.Controls.Add(this.label2);
            this.petCharacteristicsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.petCharacteristicsTab.Location = new System.Drawing.Point(4, 25);
            this.petCharacteristicsTab.Margin = new System.Windows.Forms.Padding(4);
            this.petCharacteristicsTab.Name = "petCharacteristicsTab";
            this.petCharacteristicsTab.Padding = new System.Windows.Forms.Padding(4);
            this.petCharacteristicsTab.Size = new System.Drawing.Size(1059, 425);
            this.petCharacteristicsTab.TabIndex = 0;
            this.petCharacteristicsTab.Text = "Основные характеристики животного";
            // 
            // owner
            // 
            this.owner.BackColor = System.Drawing.SystemColors.Control;
            this.owner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.owner.Location = new System.Drawing.Point(749, 74);
            this.owner.Margin = new System.Windows.Forms.Padding(4);
            this.owner.Name = "owner";
            this.owner.ReadOnly = true;
            this.owner.Size = new System.Drawing.Size(265, 23);
            this.owner.TabIndex = 19;
            // 
            // ownerType
            // 
            this.ownerType.BackColor = System.Drawing.SystemColors.Control;
            this.ownerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownerType.Location = new System.Drawing.Point(749, 37);
            this.ownerType.Margin = new System.Windows.Forms.Padding(4);
            this.ownerType.Name = "ownerType";
            this.ownerType.ReadOnly = true;
            this.ownerType.Size = new System.Drawing.Size(265, 23);
            this.ownerType.TabIndex = 18;
            // 
            // category
            // 
            this.category.BackColor = System.Drawing.SystemColors.Control;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.category.Location = new System.Drawing.Point(219, 155);
            this.category.Margin = new System.Windows.Forms.Padding(4);
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Size = new System.Drawing.Size(265, 23);
            this.category.TabIndex = 17;
            // 
            // gender
            // 
            this.gender.BackColor = System.Drawing.SystemColors.Control;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gender.Location = new System.Drawing.Point(219, 73);
            this.gender.Margin = new System.Windows.Forms.Padding(4);
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Size = new System.Drawing.Size(265, 23);
            this.gender.TabIndex = 16;
            // 
            // ownerTypeComboBox
            // 
            this.ownerTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ownerTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownerTypeComboBox.FormattingEnabled = true;
            this.ownerTypeComboBox.Items.AddRange(new object[] {
            "Физическое лицо",
            "Юридическое лицо"});
            this.ownerTypeComboBox.Location = new System.Drawing.Point(749, 36);
            this.ownerTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ownerTypeComboBox.Name = "ownerTypeComboBox";
            this.ownerTypeComboBox.Size = new System.Drawing.Size(265, 25);
            this.ownerTypeComboBox.TabIndex = 15;
            this.ownerTypeComboBox.Visible = false;
            this.ownerTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ownerTypeComboBox_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.CadetBlue;
            this.label15.Location = new System.Drawing.Point(576, 37);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(155, 20);
            this.label15.TabIndex = 14;
            this.label15.Text = "Тип владельца:";
            // 
            // ownerComboBox
            // 
            this.ownerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ownerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownerComboBox.FormattingEnabled = true;
            this.ownerComboBox.Location = new System.Drawing.Point(749, 73);
            this.ownerComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ownerComboBox.Name = "ownerComboBox";
            this.ownerComboBox.Size = new System.Drawing.Size(265, 25);
            this.ownerComboBox.TabIndex = 13;
            this.ownerComboBox.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.CadetBlue;
            this.label14.Location = new System.Drawing.Point(576, 74);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 20);
            this.label14.TabIndex = 12;
            this.label14.Text = "Владелец:";
            // 
            // petName
            // 
            this.petName.BackColor = System.Drawing.SystemColors.Control;
            this.petName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.petName.Location = new System.Drawing.Point(219, 27);
            this.petName.Margin = new System.Windows.Forms.Padding(4);
            this.petName.Name = "petName";
            this.petName.ReadOnly = true;
            this.petName.Size = new System.Drawing.Size(265, 23);
            this.petName.TabIndex = 11;
            // 
            // breed
            // 
            this.breed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.breed.Location = new System.Drawing.Point(219, 190);
            this.breed.Margin = new System.Windows.Forms.Padding(4);
            this.breed.Name = "breed";
            this.breed.ReadOnly = true;
            this.breed.Size = new System.Drawing.Size(265, 23);
            this.breed.TabIndex = 10;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Кошка",
            "Собака"});
            this.categoryComboBox.Location = new System.Drawing.Point(219, 155);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(265, 25);
            this.categoryComboBox.TabIndex = 9;
            this.categoryComboBox.Visible = false;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.genderComboBox.Location = new System.Drawing.Point(219, 73);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(265, 25);
            this.genderComboBox.TabIndex = 8;
            this.genderComboBox.Visible = false;
            // 
            // birthDate
            // 
            this.birthDate.Enabled = false;
            this.birthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDate.Location = new System.Drawing.Point(219, 111);
            this.birthDate.Margin = new System.Windows.Forms.Padding(4);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(265, 23);
            this.birthDate.TabIndex = 7;
            // 
            // registrationDate
            // 
            this.registrationDate.Enabled = false;
            this.registrationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationDate.Location = new System.Drawing.Point(219, 384);
            this.registrationDate.Margin = new System.Windows.Forms.Padding(4);
            this.registrationDate.Name = "registrationDate";
            this.registrationDate.Size = new System.Drawing.Size(265, 23);
            this.registrationDate.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.CadetBlue;
            this.label7.Location = new System.Drawing.Point(25, 384);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Дата регистраци:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.CadetBlue;
            this.label6.Location = new System.Drawing.Point(25, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Дата рождения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.CadetBlue;
            this.label5.Location = new System.Drawing.Point(25, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Пол:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.CadetBlue;
            this.label4.Location = new System.Drawing.Point(25, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Порода:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.CadetBlue;
            this.label3.Location = new System.Drawing.Point(25, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Категория:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(25, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Кличка:";
            // 
            // vacinationTab
            // 
            this.vacinationTab.Controls.Add(this.vacinationDateEnd);
            this.vacinationTab.Controls.Add(this.label9);
            this.vacinationTab.Controls.Add(this.vacinationDate);
            this.vacinationTab.Controls.Add(this.label8);
            this.vacinationTab.Location = new System.Drawing.Point(4, 25);
            this.vacinationTab.Margin = new System.Windows.Forms.Padding(4);
            this.vacinationTab.Name = "vacinationTab";
            this.vacinationTab.Padding = new System.Windows.Forms.Padding(4);
            this.vacinationTab.Size = new System.Drawing.Size(1059, 425);
            this.vacinationTab.TabIndex = 1;
            this.vacinationTab.Text = "Вакцинация";
            this.vacinationTab.UseVisualStyleBackColor = true;
            // 
            // vacinationDateEnd
            // 
            this.vacinationDateEnd.Enabled = false;
            this.vacinationDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vacinationDateEnd.Location = new System.Drawing.Point(205, 64);
            this.vacinationDateEnd.Margin = new System.Windows.Forms.Padding(4);
            this.vacinationDateEnd.Name = "vacinationDateEnd";
            this.vacinationDateEnd.Size = new System.Drawing.Size(265, 23);
            this.vacinationDateEnd.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.CadetBlue;
            this.label9.Location = new System.Drawing.Point(13, 64);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Вакцинация до:";
            // 
            // vacinationDate
            // 
            this.vacinationDate.Enabled = false;
            this.vacinationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vacinationDate.Location = new System.Drawing.Point(205, 23);
            this.vacinationDate.Margin = new System.Windows.Forms.Padding(4);
            this.vacinationDate.Name = "vacinationDate";
            this.vacinationDate.Size = new System.Drawing.Size(265, 23);
            this.vacinationDate.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.CadetBlue;
            this.label8.Location = new System.Drawing.Point(13, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Дата вакцинации:";
            // 
            // dewormingTab
            // 
            this.dewormingTab.Controls.Add(this.dewormingDateEnd);
            this.dewormingTab.Controls.Add(this.label10);
            this.dewormingTab.Controls.Add(this.dewormingDate);
            this.dewormingTab.Controls.Add(this.label11);
            this.dewormingTab.Location = new System.Drawing.Point(4, 25);
            this.dewormingTab.Margin = new System.Windows.Forms.Padding(4);
            this.dewormingTab.Name = "dewormingTab";
            this.dewormingTab.Padding = new System.Windows.Forms.Padding(4);
            this.dewormingTab.Size = new System.Drawing.Size(1059, 425);
            this.dewormingTab.TabIndex = 2;
            this.dewormingTab.Text = "Дегельминтизация";
            this.dewormingTab.UseVisualStyleBackColor = true;
            // 
            // dewormingDateEnd
            // 
            this.dewormingDateEnd.Enabled = false;
            this.dewormingDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dewormingDateEnd.Location = new System.Drawing.Point(279, 64);
            this.dewormingDateEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dewormingDateEnd.Name = "dewormingDateEnd";
            this.dewormingDateEnd.Size = new System.Drawing.Size(265, 23);
            this.dewormingDateEnd.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.CadetBlue;
            this.label10.Location = new System.Drawing.Point(13, 64);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(223, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Дегельминтизация до:";
            // 
            // dewormingDate
            // 
            this.dewormingDate.Enabled = false;
            this.dewormingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dewormingDate.Location = new System.Drawing.Point(279, 23);
            this.dewormingDate.Margin = new System.Windows.Forms.Padding(4);
            this.dewormingDate.Name = "dewormingDate";
            this.dewormingDate.Size = new System.Drawing.Size(265, 23);
            this.dewormingDate.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.CadetBlue;
            this.label11.Location = new System.Drawing.Point(13, 23);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(245, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Дата дегельминтизации:";
            // 
            // vetAppointmentsTab
            // 
            this.vetAppointmentsTab.Controls.Add(this.vetAppointments);
            this.vetAppointmentsTab.Location = new System.Drawing.Point(4, 25);
            this.vetAppointmentsTab.Margin = new System.Windows.Forms.Padding(4);
            this.vetAppointmentsTab.Name = "vetAppointmentsTab";
            this.vetAppointmentsTab.Padding = new System.Windows.Forms.Padding(4);
            this.vetAppointmentsTab.Size = new System.Drawing.Size(1059, 425);
            this.vetAppointmentsTab.TabIndex = 3;
            this.vetAppointmentsTab.Text = "Ветеринарные назначения";
            this.vetAppointmentsTab.UseVisualStyleBackColor = true;
            // 
            // vetAppointments
            // 
            this.vetAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vetAppointments.Location = new System.Drawing.Point(17, 7);
            this.vetAppointments.Margin = new System.Windows.Forms.Padding(4);
            this.vetAppointments.Multiline = true;
            this.vetAppointments.Name = "vetAppointments";
            this.vetAppointments.ReadOnly = true;
            this.vetAppointments.Size = new System.Drawing.Size(1013, 410);
            this.vetAppointments.TabIndex = 12;
            // 
            // documentsTab
            // 
            this.documentsTab.Controls.Add(this.chipNum);
            this.documentsTab.Controls.Add(this.label13);
            this.documentsTab.Controls.Add(this.identificationNum);
            this.documentsTab.Controls.Add(this.label12);
            this.documentsTab.Controls.Add(this.passportNum);
            this.documentsTab.Controls.Add(this.label41);
            this.documentsTab.Location = new System.Drawing.Point(4, 25);
            this.documentsTab.Margin = new System.Windows.Forms.Padding(4);
            this.documentsTab.Name = "documentsTab";
            this.documentsTab.Padding = new System.Windows.Forms.Padding(4);
            this.documentsTab.Size = new System.Drawing.Size(1059, 425);
            this.documentsTab.TabIndex = 4;
            this.documentsTab.Text = "Фото/Документы";
            this.documentsTab.UseVisualStyleBackColor = true;
            // 
            // chipNum
            // 
            this.chipNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chipNum.Location = new System.Drawing.Point(313, 87);
            this.chipNum.Margin = new System.Windows.Forms.Padding(4);
            this.chipNum.Name = "chipNum";
            this.chipNum.ReadOnly = true;
            this.chipNum.Size = new System.Drawing.Size(265, 23);
            this.chipNum.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.CadetBlue;
            this.label13.Location = new System.Drawing.Point(13, 89);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "Номер чипа:";
            // 
            // identificationNum
            // 
            this.identificationNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.identificationNum.Location = new System.Drawing.Point(313, 55);
            this.identificationNum.Margin = new System.Windows.Forms.Padding(4);
            this.identificationNum.Name = "identificationNum";
            this.identificationNum.ReadOnly = true;
            this.identificationNum.Size = new System.Drawing.Size(265, 23);
            this.identificationNum.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.CadetBlue;
            this.label12.Location = new System.Drawing.Point(13, 57);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(275, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Идентификационный номер:";
            // 
            // passportNum
            // 
            this.passportNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passportNum.Location = new System.Drawing.Point(313, 23);
            this.passportNum.Margin = new System.Windows.Forms.Padding(4);
            this.passportNum.Name = "passportNum";
            this.passportNum.ReadOnly = true;
            this.passportNum.Size = new System.Drawing.Size(265, 23);
            this.passportNum.TabIndex = 13;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label41.ForeColor = System.Drawing.Color.CadetBlue;
            this.label41.Location = new System.Drawing.Point(13, 25);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(168, 20);
            this.label41.TabIndex = 12;
            this.label41.Text = "Номер паспорта:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Карточка питомца";
            // 
            // changeCardButton
            // 
            this.changeCardButton.BackColor = System.Drawing.Color.CadetBlue;
            this.changeCardButton.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.changeCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeCardButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.changeCardButton.Location = new System.Drawing.Point(951, 63);
            this.changeCardButton.Margin = new System.Windows.Forms.Padding(4);
            this.changeCardButton.Name = "changeCardButton";
            this.changeCardButton.Size = new System.Drawing.Size(100, 28);
            this.changeCardButton.TabIndex = 8;
            this.changeCardButton.Text = "Изменить";
            this.changeCardButton.UseVisualStyleBackColor = false;
            this.changeCardButton.Click += new System.EventHandler(this.changeCardButton_Click);
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.CadetBlue;
            this.okButton.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.okButton.Location = new System.Drawing.Point(951, 63);
            this.okButton.Margin = new System.Windows.Forms.Padding(4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 28);
            this.okButton.TabIndex = 9;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Visible = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // PetCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.changeCardButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.petCardTabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PetCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Карточка питомца";
            this.Activated += new System.EventHandler(this.PetCardForm_Activated);
            this.petCardTabControl.ResumeLayout(false);
            this.petCharacteristicsTab.ResumeLayout(false);
            this.petCharacteristicsTab.PerformLayout();
            this.vacinationTab.ResumeLayout(false);
            this.vacinationTab.PerformLayout();
            this.dewormingTab.ResumeLayout(false);
            this.dewormingTab.PerformLayout();
            this.vetAppointmentsTab.ResumeLayout(false);
            this.vetAppointmentsTab.PerformLayout();
            this.documentsTab.ResumeLayout(false);
            this.documentsTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl petCardTabControl;
        private System.Windows.Forms.TabPage petCharacteristicsTab;
        private System.Windows.Forms.TabPage vacinationTab;
        private System.Windows.Forms.TabPage dewormingTab;
        private System.Windows.Forms.TabPage vetAppointmentsTab;
        private System.Windows.Forms.TabPage documentsTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker registrationDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox petName;
        private System.Windows.Forms.TextBox breed;
        private System.Windows.Forms.DateTimePicker vacinationDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker vacinationDateEnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dewormingDateEnd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dewormingDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox vetAppointments;
        private System.Windows.Forms.TextBox passportNum;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.ComboBox ownerComboBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox chipNum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox identificationNum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ownerTypeComboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button changeCardButton;
        private System.Windows.Forms.TextBox owner;
        private System.Windows.Forms.TextBox ownerType;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.Button okButton;
    }
}