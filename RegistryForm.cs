using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace PetRegistry
{
    public partial class RegistryForm : Form
    {
        public RegistryForm()
        {
            InitializeComponent();
        }

        private void реестрЖивотныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label.Text = "Реестр животных";
            addPetButton.Visible = true;
            openPetButton.Visible = true;
            deletePetButton.Visible = true;
            sortPetButton.Visible = true;

            Controller controller = new Controller();
            DataTable data = controller.OpenPetsRegistry();

            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("Имя", "Имя");
            dataGridView.Columns.Add("Категория", "Категория");
            dataGridView.Columns.Add("Порода", "Порода");
            dataGridView.Columns.Add("Пол", "Пол");
            dataGridView.Columns.Add("Размер", "Размер");
            dataGridView.Columns.Add("Шерсть", "Шерсть");
            dataGridView.Columns.Add("Номер чипа", "Номер чипа");
            dataGridView.Columns.Add("Владелец", "Владелец");
            dataGridView.Columns.Add("Организация", "Организация");

            for (int i = 0; i < data.Rows.Count; i++)
            {
                var row = data.Rows[i];
                dataGridView.Rows.Add(row[5], row[2], row[1], row[7], row[4], row[3], row[9], row[11], row[12]);
            }
        }
    }
}
