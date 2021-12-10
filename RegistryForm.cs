using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetRegistry
{
    public partial class RegistryForm : Form
    {
        Controller controller = new Controller();
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
            DataTable data = controller.OpenPetsRegistry();

            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("ID", "ID");
            dataGridView.Columns.Add("Имя", "Имя");
            dataGridView.Columns.Add("Категория", "Категория");
            dataGridView.Columns.Add("Порода", "Порода");
            dataGridView.Columns.Add("Пол", "Пол");
            dataGridView.Columns.Add("Размер", "Размер");
            dataGridView.Columns.Add("Шерсть", "Шерсть");
            dataGridView.Columns.Add("Номер чипа", "Номер чипа");
            dataGridView.Columns.Add("Владелец", "Владелец");
            dataGridView.Columns.Add("Организация", "Организация");
            dataGridView.Columns[0].Visible = false;

            for (int i = 0; i < data.Rows.Count; i++)
            {
                var row = data.Rows[i];
                dataGridView.Rows.Add(row[0], row[5], row[2], row[1], row[7], row[4], row[3], row[9], row[11], row[12]);
            }
        }

        private void openPetButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView.Rows.IndexOf(dataGridView.CurrentRow);
            controller.OpenPetCard(dataGridView[0, selectedIndex].Value.ToString());
        }

        private void реестрВладельцевToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("ID", "ID");
            dataGridView.Columns.Add("Имя", "Имя");
            dataGridView.Columns.Add("Организация", "Организация");
        }
    }
}
