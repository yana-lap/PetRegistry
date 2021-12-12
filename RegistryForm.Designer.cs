
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
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1229, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // реестрЖивотныхToolStripMenuItem
            // 
            this.реестрЖивотныхToolStripMenuItem.Name = "реестрЖивотныхToolStripMenuItem";
            this.реестрЖивотныхToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.реестрЖивотныхToolStripMenuItem.Text = "Реестр животных";
            this.реестрЖивотныхToolStripMenuItem.Visible = false;
            this.реестрЖивотныхToolStripMenuItem.Click += new System.EventHandler(this.реестрЖивотныхToolStripMenuItem_Click);
            // 
            // реестрВладельцевToolStripMenuItem
            // 
            this.реестрВладельцевToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.физическиеЛицаToolStripMenuItem,
            this.юридическиеЛицаToolStripMenuItem});
            this.реестрВладельцевToolStripMenuItem.Name = "реестрВладельцевToolStripMenuItem";
            this.реестрВладельцевToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.реестрВладельцевToolStripMenuItem.Text = "Реестр владельцев";
            this.реестрВладельцевToolStripMenuItem.Visible = false;
            // 
            // физическиеЛицаToolStripMenuItem
            // 
            this.физическиеЛицаToolStripMenuItem.Name = "физическиеЛицаToolStripMenuItem";
            this.физическиеЛицаToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.физическиеЛицаToolStripMenuItem.Text = "Физические лица";
            this.физическиеЛицаToolStripMenuItem.Click += new System.EventHandler(this.физическиеЛицаToolStripMenuItem_Click);
            // 
            // юридическиеЛицаToolStripMenuItem
            // 
            this.юридическиеЛицаToolStripMenuItem.Name = "юридическиеЛицаToolStripMenuItem";
            this.юридическиеЛицаToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.юридическиеЛицаToolStripMenuItem.Text = "Юридические лица";
            this.юридическиеЛицаToolStripMenuItem.Click += new System.EventHandler(this.юридическиеЛицаToolStripMenuItem_Click);
            // 
            // моиДомашниеЖивотныеToolStripMenuItem
            // 
            this.моиДомашниеЖивотныеToolStripMenuItem.Name = "моиДомашниеЖивотныеToolStripMenuItem";
            this.моиДомашниеЖивотныеToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
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
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.Color.CadetBlue;
            this.label.Location = new System.Drawing.Point(16, 46);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 31);
            this.label.TabIndex = 6;
            // 
            // RegistryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1229, 554);
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
            this.Text = "Приложение";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
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
    }
}