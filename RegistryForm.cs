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
            //MessageBox.Show(Variables.CurrentUser.Role);
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (controller.roleIsMaching("открытие реестров"))
            {
                реестрЖивотныхToolStripMenuItem.Visible = true;
                реестрВладельцевToolStripMenuItem.Visible = true;
            }
            if (controller.roleIsMaching("открытие дж"))
            {
                моиДомашниеЖивотныеToolStripMenuItem.Visible = true;
            }
        }

        private void реестрЖивотныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetSettings();
            label.Text = "Реестр животных";
            addPetButton.Visible = true;
            openPetButton.Visible = true;
            deletePetButton.Visible = true;
            sortPetButton.Visible = true;
           
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


            DataTable data = controller.OpenPetsRegistry();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var row = data.Rows[i];
                dataGridView.Rows.Add(row[0], row[1], row[2], row[3].ToString().Substring(0, 10), 
                    row[4], row[5], row[6], row[7], row[8]);
            }
        }

        

        private void физическиеЛицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetSettings();
            label.Text = "Реестр владельцев";
            dataGridView.Columns.Add("ID", "ID");
            dataGridView.Columns.Add("ФИО", "ФИО");
            dataGridView.Columns.Add("Страна", "Страна");
            dataGridView.Columns.Add("Адрес", "Адрес");
            dataGridView.Columns.Add("Телефон", "Телефон");
            dataGridView.Columns.Add("Электронная почта", "Электронная почта");
            dataGridView.Columns.Add("Количество животных", "Количество животных");
            dataGridView.Columns.Add("Количество кошек", "Количество кошек");
            dataGridView.Columns.Add("Количество собак", "Количество собак");
            dataGridView.Columns[0].Visible = false;



            DataTable data = controller.OpenOwnersUserRegistry();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var row = data.Rows[i];
                dataGridView.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
            }

        }

        private void юридическиеЛицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetSettings();

            label.Text = "Реестр владельцев";
            dataGridView.Columns.Add("ID", "ID");
            dataGridView.Columns.Add("Наименование организации", "Наименование организации");
            dataGridView.Columns.Add("ИНН", "ИНН");
            dataGridView.Columns.Add("КПП", "КПП");
            dataGridView.Columns.Add("Страна", "Страна");
            dataGridView.Columns.Add("Адрес", "Адрес");
            dataGridView.Columns.Add("Телефон", "Телефон");
            dataGridView.Columns.Add("Электронная почта", "Электронная почта");
            dataGridView.Columns.Add("Количество животных", "Количество животных");
            dataGridView.Columns.Add("Количество кошек", "Количество кошек");
            dataGridView.Columns.Add("Количество собак", "Количество собак");
            dataGridView.Columns[0].Visible = false;

            DataTable data = controller.OpenOwnersOrgRegistry();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var row = data.Rows[i];
                dataGridView.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10]);
            }
        }

        private void моиДомашниеЖивотныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetSettings();
            label.Text = "Мои домашние животные";
            dataGridView.Columns.Add("ID", "ID");
            dataGridView.Columns.Add("Категория животного", "Категория животного");
            dataGridView.Columns.Add("Кличка", "Кличка");
            dataGridView.Columns.Add("Дата рождения", "Дата рождения");
            dataGridView.Columns.Add("Порода", "Порода;");
            dataGridView.Columns.Add("Дата регистрации животного", "Дата регистрации животного");
            dataGridView.Columns.Add("Номер паспорта домашнего животного", "Номер паспорта домашнего животного");
            dataGridView.Columns.Add("Владелец", "Владелец");
            dataGridView.Columns[0].Visible = false;

            DataTable data = controller.OpenMyPetsRegistry();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var row = data.Rows[i];
                dataGridView.Rows.Add(row[0], row[1], row[2], row[3].ToString().Substring(0,10), row[4], row[5].ToString().Substring(0, 10), row[6], row[7]);
            }

        }

        private void addPetButton_Click(object sender, EventArgs e)
        {
            if (controller.roleIsMaching("добавление"))
            {
                Form addPetCard = new AddPetCard();
                addPetCard.ShowDialog();
                dataGridView.Rows.Clear();
                DataTable data = controller.OpenPetsRegistry();
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    var row = data.Rows[i];
                    dataGridView.Rows.Add(row[0], row[1], row[2], row[3].ToString().Substring(0, 10),
                        row[4], row[5], row[6], row[7], row[8]);
                }
            }
            else MessageBox.Show("Недостаточно прав.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ResetSettings()
        {
            label.Text = "   ";
            addPetButton.Visible = false;
            openPetButton.Visible = false;
            deletePetButton.Visible = false;
            sortPetButton.Visible = false;

            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
        }
        private void openPetButton_Click(object sender, EventArgs e)
        {
            if (controller.roleIsMaching("открытие"))
            {
                int selectedIndex = dataGridView.Rows.IndexOf(dataGridView.CurrentRow);
                controller.OpenPetCard(dataGridView[0, selectedIndex].Value.ToString());
            }
            else MessageBox.Show("Недостаточно прав.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void deletePetButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView.Rows.IndexOf(dataGridView.CurrentRow);
            string answer = controller.DeletePetCard(dataGridView[0, selectedIndex].Value.ToString());
            switch (answer)
            {
                case "Удаление завершено.":
                    MessageBox.Show(answer, "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView.Rows.Clear();
                    DataTable data = controller.OpenPetsRegistry();
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        var row = data.Rows[i];
                        dataGridView.Rows.Add(row[0], row[1], row[2], row[3].ToString().Substring(0, 10),
                            row[4], row[5], row[6], row[7], row[8]);
                    }
                    break;
                case "Недостаточно прав.":
                    MessageBox.Show(answer, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

    }
}
