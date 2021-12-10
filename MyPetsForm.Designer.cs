
namespace PetRegistry
{
    partial class MyPetsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.MyPetsGrid = new System.Windows.Forms.DataGridView();
            this.petsSortButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MyPetsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Мои домашние животные";
            // 
            // MyPetsGrid
            // 
            this.MyPetsGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.MyPetsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MyPetsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyPetsGrid.Location = new System.Drawing.Point(17, 66);
            this.MyPetsGrid.Name = "MyPetsGrid";
            this.MyPetsGrid.RowHeadersWidth = 51;
            this.MyPetsGrid.Size = new System.Drawing.Size(771, 354);
            this.MyPetsGrid.TabIndex = 6;
            // 
            // petsSortButton
            // 
            this.petsSortButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.petsSortButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.petsSortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.petsSortButton.ForeColor = System.Drawing.Color.CadetBlue;
            this.petsSortButton.Location = new System.Drawing.Point(617, 37);
            this.petsSortButton.Name = "petsSortButton";
            this.petsSortButton.Size = new System.Drawing.Size(171, 23);
            this.petsSortButton.TabIndex = 5;
            this.petsSortButton.Text = "Параметры фильтрации...";
            this.petsSortButton.UseVisualStyleBackColor = false;
            // 
            // MyPetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MyPetsGrid);
            this.Controls.Add(this.petsSortButton);
            this.Controls.Add(this.label1);
            this.Name = "MyPetsForm";
            this.Text = "Мои домашние животные";
            ((System.ComponentModel.ISupportInitialize)(this.MyPetsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView MyPetsGrid;
        private System.Windows.Forms.Button petsSortButton;
    }
}