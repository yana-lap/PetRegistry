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

            if (Variables.MatchingRoles["открытие реестров"].Contains(Variables.CurrentUser.Role))
            {
                реестрЖивотныхToolStripMenuItem.Visible = true;
                реестрВладельцевToolStripMenuItem.Visible = true;
            }
            if (Variables.MatchingRoles["открытие дж"].Contains(Variables.CurrentUser.Role))
            {
                моиДомашниеЖивотныеToolStripMenuItem.Visible = true;
            }
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
            dataGridView.Columns.Add("Категория", "Категория");
            dataGridView.Columns.Add("Пол", "Пол");
            dataGridView.Columns.Add("Год рождения", "Год рождения");
            dataGridView.Columns.Add("Идентификационная метка", "Идентификационная метка");
            dataGridView.Columns.Add("Номер электронного чипа", "Номер электронного чипа");
            dataGridView.Columns.Add("Кличка", "Кличка");
            dataGridView.Columns.Add("Фото", "Фото");
            dataGridView.Columns.Add("Владелец", "Владелец");
            dataGridView.Columns[0].Visible = false;

            for (int i = 0; i < data.Rows.Count; i++)
            {
                var row = data.Rows[i];
                dataGridView.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
            }
        }

        private void openPetButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView.Rows.IndexOf(dataGridView.CurrentRow);
            controller.OpenPetCard(dataGridView[0, selectedIndex].Value.ToString());
        }
    }
}
