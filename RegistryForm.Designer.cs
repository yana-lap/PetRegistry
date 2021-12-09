
namespace PetRegistry
{
    partial class Form2
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
            this.реестрВладелцевToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.реестрЖивотныхToolStripMenuItem,
            this.реестрВладелцевToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // реестрЖивотныхToolStripMenuItem
            // 
            this.реестрЖивотныхToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.реестрЖивотныхToolStripMenuItem.Name = "реестрЖивотныхToolStripMenuItem";
            this.реестрЖивотныхToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.реестрЖивотныхToolStripMenuItem.Text = "Реестр животных";
            // 
            // реестрВладелцевToolStripMenuItem
            // 
            this.реестрВладелцевToolStripMenuItem.Name = "реестрВладелцевToolStripMenuItem";
            this.реестрВладелцевToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.реестрВладелцевToolStripMenuItem.Text = "Реестр владелцев";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Реестр животных";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.CadetBlue;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addButton.Location = new System.Drawing.Point(17, 61);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.openButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButton.ForeColor = System.Drawing.Color.CadetBlue;
            this.openButton.Location = new System.Drawing.Point(98, 61);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 3;
            this.openButton.Text = "Открыть";
            this.openButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.Color.CadetBlue;
            this.deleteButton.Location = new System.Drawing.Point(179, 61);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // sortButton
            // 
            this.sortButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sortButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.sortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortButton.ForeColor = System.Drawing.Color.CadetBlue;
            this.sortButton.Location = new System.Drawing.Point(610, 61);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(178, 23);
            this.sortButton.TabIndex = 5;
            this.sortButton.Text = "Параметры фильтрации...";
            this.sortButton.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(771, 348);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem реестрЖивотныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem реестрВладелцевToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}