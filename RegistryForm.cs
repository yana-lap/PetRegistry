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
        Dictionary<string, List<string>> filterPetParams = new Dictionary<string, List<string>>();
        Dictionary<string, List<string>> filterOwnerUserParams = new Dictionary<string, List<string>>();
        Dictionary<string, List<string>> filterOwnerOrgParams = new Dictionary<string, List<string>>();

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
        private void ResetSettings()
        {
            filterPetParams = new Dictionary<string, List<string>>();
            filterOwnerUserParams = new Dictionary<string, List<string>>();
            filterOwnerOrgParams = new Dictionary<string, List<string>>();
            label.Text = "   ";
            addPetButton.Visible = false;
            openPetButton.Visible = false;
            deletePetButton.Visible = false;
            sortPetButton.Visible = false;
            sortOwnerButton.Visible = false;
            getOwnerUserParams.Visible = false;
            getOwnerOrgParams.Visible = false;
            openOwnerPets.Visible = false;

            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            petFilterGroupBox.Visible = false;
            ownerFilterGroupBox.Visible = false;


        }

        private void InsertDataToPetRegistry(DataTable data)
        {
            dataGridView.Rows.Clear();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var row = data.Rows[i];
                dataGridView.Rows.Add(row[0], row[1], row[2], row[3].ToString().Substring(0, 10),
                    row[4], row[5], row[6], row[7], row[8]);
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
            exportPetDataButton.Visible = true;

            dataGridView.Columns.Add("ID", "ID");
            dataGridView.Columns.Add("Категория", "Категория");
            dataGridView.Columns.Add("Пол", "Пол");
            dataGridView.Columns.Add("Дата рождения", "Дата рождения");
            dataGridView.Columns.Add("Идентификационная метка", "Идентификационная метка");
            dataGridView.Columns.Add("Номер электронного чипа", "Номер электронного чипа");
            dataGridView.Columns.Add("Кличка", "Кличка");
            dataGridView.Columns.Add("Фото", "Фото");
            dataGridView.Columns.Add("Владелец", "Владелец");
            dataGridView.Columns[0].Visible = false;


            DataTable data = controller.OpenPetsRegistry(filterPetParams);
            InsertDataToPetRegistry(data);
        }



        private void addPetButton_Click(object sender, EventArgs e)
        {
            if (controller.roleIsMaching("добавление"))
            {
                Form addPetCard = new AddPetCard();
                addPetCard.ShowDialog();

                DataTable data = controller.OpenPetsRegistry(filterPetParams);

                InsertDataToPetRegistry(data);
            }
            else MessageBox.Show("Недостаточно прав.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void openPetButton_Click(object sender, EventArgs e)
        {
            if (controller.roleIsMaching("открытие карточки"))
            {
                int selectedIndex = dataGridView.Rows.IndexOf(dataGridView.CurrentRow);
                Variables.CurrentPet = controller.OpenPetCard(dataGridView[0, selectedIndex].Value.ToString());

                Form petCard = new PetCardForm();
                petCard.ShowDialog();

                DataTable data = controller.OpenPetsRegistry(filterPetParams);
                InsertDataToPetRegistry(data);
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
                    DataTable data = controller.OpenPetsRegistry(filterPetParams);

                    InsertDataToPetRegistry(data);
                    Journal.CommitSystemChangeInfo(DateTime.Now, "удаление", Variables.CurrentUser.ID);
                    break;
                case "Недостаточно прав.":
                    MessageBox.Show(answer, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
        private void sortPetButton_Click(object sender, EventArgs e)
        {
            petFilterGroupBox.Visible = !petFilterGroupBox.Visible;
        }

        private void getPetParams_Click(object sender, EventArgs e)
        {
            filterPetParams = new Dictionary<string, List<string>>();
            if (categoryCheckedListBox.CheckedItems.Count != 0)
            {
                filterPetParams["Categories.CategoryName"] = new List<string>();
                foreach (var el in categoryCheckedListBox.CheckedItems)
                    filterPetParams["Categories.CategoryName"].Add(el.ToString());
            }

            if (genderCheckedListBox.CheckedItems.Count != 0)
            {
                filterPetParams["Pets.Gender"] = new List<string>();
                foreach (var el in genderCheckedListBox.CheckedItems)
                    filterPetParams["Pets.Gender"].Add(el.ToString());
            }

            if (ownerTypeCheckedListBox.CheckedItems.Count != 0)
            {
                filterPetParams["OwnerTypes.TypeName"] = new List<string>();
                foreach (var el in ownerTypeCheckedListBox.CheckedItems)
                    filterPetParams["OwnerTypes.TypeName"].Add(el.ToString());
            }

            if (ownerCheckedListBox.CheckedItems.Count != 0)
            {
                filterPetParams["dbo.GetPetOwner(OwnerType, OwnerUser, OwnerCompany)"] = new List<string>();
                foreach (var el in ownerCheckedListBox.CheckedItems)
                    filterPetParams["dbo.GetPetOwner(OwnerType, OwnerUser, OwnerCompany)"].Add(el.ToString());
            }

            if (checkBoxBirthDateStart.Checked == true)
            {
                filterPetParams["Pets.BirthDateS"] = new List<string>();
                filterPetParams["Pets.BirthDateS"].Add(birthDateStart.Value.ToString("yyyy-MM-dd"));
            }
            if (checkBoxBirthDateEnd.Checked == true)
            {
                filterPetParams["Pets.BirthDateE"] = new List<string>();
                filterPetParams["Pets.BirthDateE"].Add(birthDateEnd.Value.ToString("yyyy-MM-dd"));
            }

            DataTable data = controller.OpenPetsRegistry(filterPetParams);
            InsertDataToPetRegistry(data);

            petFilterGroupBox.Visible = false;
        }


        private void exportPetDataButton_Click(object sender, EventArgs e)
        {
            string path = System.IO.Directory.GetCurrentDirectory() + @"\PetRegistry.xlsx";

            Controller controller = new Controller();
            controller.ExportPetRegistryToExcel(dataGridView, path);
            MessageBox.Show("GOOD");
        }


        private void физическиеЛицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetSettings();
            openOwnerPets.Visible = true;
            sortOwnerButton.Visible = true;
            getOwnerUserParams.Visible = true;
            exportPetDataButton.Visible = true;


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


            DataTable data = controller.OpenOwnersUserRegistry(filterOwnerUserParams);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var row = data.Rows[i];
                dataGridView.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
            }

            ownerCountryCheckedListBox.Items.Clear();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var row = data.Rows[i];
                if (!ownerCountryCheckedListBox.Items.Contains(row[2]))
                    ownerCountryCheckedListBox.Items.Add(row[2]);
            }
        }
        private void юридическиеЛицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetSettings();
            openOwnerPets.Visible = true;
            sortOwnerButton.Visible = true;
            getOwnerOrgParams.Visible = true;
            exportPetDataButton.Visible = true;


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


            DataTable data = controller.OpenOwnersOrgRegistry(filterOwnerOrgParams);
            InsertDataToOwnerOrgRegistry(data);

            ownerCountryCheckedListBox.Items.Clear();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var row = data.Rows[i];
                if (!ownerCountryCheckedListBox.Items.Contains(row[4]))
                    ownerCountryCheckedListBox.Items.Add(row[4]);
            }
        }


        private void InsertDataToOwnerOrgRegistry(DataTable data)
        {
            dataGridView.Rows.Clear();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var row = data.Rows[i];
                dataGridView.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10]);
            }
        }


        private void sortOwnerUserButton_Click(object sender, EventArgs e)
        {
            ownerFilterGroupBox.Visible = !ownerFilterGroupBox.Visible;
        }

        private void getOwnerUsersParams_Click(object sender, EventArgs e) 
        {
            filterOwnerUserParams = new Dictionary<string, List<string>>();

            if (checkBoxpetsNumberFrom.Checked == true)
            {
                filterOwnerUserParams["petsNumberFrom"] = new List<string>();
                filterOwnerUserParams["petsNumberFrom"].Add(petsNumberFrom.Text);
            }
            if (checkBoxpetsNumberTo.Checked == true)
            {
                filterOwnerUserParams["petsNumberTo"] = new List<string>();
                filterOwnerUserParams["petsNumberTo"].Add(petsNumberTo.Text);
            }
            if (checkBoxcatsNumberFrom.Checked == true)
            {
                filterOwnerUserParams["catsNumberFrom"] = new List<string>();
                filterOwnerUserParams["catsNumberFrom"].Add(catsNumberFrom.Text);
            }
            if (checkBoxcatsNumberTo.Checked == true)
            {
                filterOwnerUserParams["catsNumberTo"] = new List<string>();
                filterOwnerUserParams["catsNumberTo"].Add(catsNumberTo.Text);
            }
            if (checkBoxdogsNumberFrom.Checked == true)
            {
                filterOwnerUserParams["dogsNumberFrom"] = new List<string>();
                filterOwnerUserParams["dogsNumberFrom"].Add(dogsNumberFrom.Text);
            }
            if (checkBoxdogsNumberTo.Checked == true)
            {
                filterOwnerUserParams["dogsNumberTo"] = new List<string>();
                filterOwnerUserParams["dogsNumberTo"].Add(dogsNumberTo.Text);
            }



            if (ownerCountryCheckedListBox.CheckedItems.Count != 0)
            {
                filterOwnerUserParams["Users.Country"] = new List<string>();
                foreach (var el in ownerCountryCheckedListBox.CheckedItems)
                    filterOwnerUserParams["Users.Country"].Add(el.ToString());
            }
            DataTable data = controller.OpenOwnersUserRegistry(filterOwnerUserParams);

            InsertDataToOwnerUserRegistry(data);

            ownerFilterGroupBox.Visible = false;
        }

        private void getOwnerOrgParams_Click(object sender, EventArgs e)
        {
            filterOwnerOrgParams = new Dictionary<string, List<string>>();
            if (checkBoxpetsNumberFrom.Checked == true)
            {
                filterOwnerOrgParams["petsNumberFrom"] = new List<string>();
                filterOwnerOrgParams["petsNumberFrom"].Add(petsNumberFrom.Text);
            }
            if (checkBoxpetsNumberTo.Checked == true)
            {
                filterOwnerOrgParams["petsNumberTo"] = new List<string>();
                filterOwnerOrgParams["petsNumberTo"].Add(petsNumberTo.Text);
            }
            if (checkBoxcatsNumberFrom.Checked == true)
            {
                filterOwnerOrgParams["catsNumberFrom"] = new List<string>();
                filterOwnerOrgParams["catsNumberFrom"].Add(catsNumberFrom.Text);
            }
            if (checkBoxcatsNumberTo.Checked == true)
            {
                filterOwnerOrgParams["catsNumberTo"] = new List<string>();
                filterOwnerOrgParams["catsNumberTo"].Add(catsNumberTo.Text);
            }
            if (checkBoxdogsNumberFrom.Checked == true)
            {
                filterOwnerOrgParams["dogsNumberFrom"] = new List<string>();
                filterOwnerOrgParams["dogsNumberFrom"].Add(dogsNumberFrom.Text);
            }
            if (checkBoxdogsNumberTo.Checked == true)
            {
                filterOwnerOrgParams["dogsNumberTo"] = new List<string>();
                filterOwnerOrgParams["dogsNumberTo"].Add(dogsNumberTo.Text);
            }
            
            if (ownerCountryCheckedListBox.CheckedItems.Count != 0)
            {
                filterOwnerOrgParams["Organizations.Country"] = new List<string>();
                foreach (var el in ownerCountryCheckedListBox.CheckedItems)
                    filterOwnerOrgParams["Organizations.Country"].Add(el.ToString());
            }

            DataTable data = controller.OpenOwnersOrgRegistry(filterOwnerOrgParams);

            InsertDataToOwnerOrgRegistry(data);

            ownerFilterGroupBox.Visible = false;
        }

        private void InsertDataToOwnerUserRegistry(DataTable data)
        {
            dataGridView.Rows.Clear();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var row = data.Rows[i];
                dataGridView.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
            }
        }

       




        private void моиДомашниеЖивотныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetSettings();
            openPetButton.Visible = true;
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

            DataTable data = controller.OpenMyPetsRegistry(filterPetParams);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var row = data.Rows[i];
                dataGridView.Rows.Add(row[0], row[1], row[2], row[3].ToString().Substring(0,10), row[4], row[5].ToString().Substring(0, 10), row[6], row[7]);
            }
        }        
     

        
        

       

        private void ownerTypeCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ownerTypeCheckedListBox.CheckedItems.Contains("Физическое лицо")
                && ownerTypeCheckedListBox.CheckedItems.Contains("Юридическое лицо"))
            {
                ownerCheckedListBox.Items.Clear();
                DataTable data = controller.OpenOwnersUserRegistry(filterOwnerUserParams);
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    var row = data.Rows[i];
                    if (!ownerCheckedListBox.Items.Contains(row[1]))
                        ownerCheckedListBox.Items.Add(row[1]);
                }
                data = controller.OpenOwnersOrgRegistry(filterOwnerOrgParams);
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    var row = data.Rows[i];
                    if (!ownerCheckedListBox.Items.Contains(row[1]))
                        ownerCheckedListBox.Items.Add(row[1]);
                }
            } 
            else if (ownerTypeCheckedListBox.CheckedItems.Contains("Физическое лицо"))
            {
                ownerCheckedListBox.Items.Clear();
                DataTable data = controller.OpenOwnersUserRegistry(filterOwnerUserParams);
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    var row = data.Rows[i];
                    if (!ownerCheckedListBox.Items.Contains(row[1]))
                        ownerCheckedListBox.Items.Add(row[1]);
                }
            }
            else if (ownerTypeCheckedListBox.CheckedItems.Contains("Юридическое лицо"))
            {
                ownerCheckedListBox.Items.Clear();
                DataTable data = controller.OpenOwnersOrgRegistry(filterOwnerOrgParams);
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    var row = data.Rows[i];
                    if (!ownerCheckedListBox.Items.Contains(row[1]))
                        ownerCheckedListBox.Items.Add(row[1]);
                }
            }
            else { ownerCheckedListBox.Items.Clear(); }
        }

        private void checkBoxBirthDate_CheckedChanged(object sender, EventArgs e)
        {
            birthDateStart.Enabled = checkBoxBirthDateStart.Checked;
            birthDateEnd.Enabled = checkBoxBirthDateEnd.Checked;
        }

        private void checkBoxPetsNumber_CheckedChanged(object sender, EventArgs e)
        {
            petsNumberFrom.Enabled = checkBoxpetsNumberFrom.Checked;
            petsNumberTo.Enabled = checkBoxpetsNumberTo.Checked;
            if (checkBoxpetsNumberFrom.Checked == false) petsNumberFrom.Text = "";
            if (checkBoxpetsNumberTo.Checked == false) petsNumberTo.Text = "";

        }

        private void checkBoxdogsNumber_CheckedChanged(object sender, EventArgs e)
        {
            dogsNumberFrom.Enabled = checkBoxdogsNumberFrom.Checked;
            dogsNumberTo.Enabled = checkBoxdogsNumberTo.Checked;

            if (checkBoxdogsNumberFrom.Checked == false) dogsNumberFrom.Text = "";
            if (checkBoxdogsNumberTo.Checked == false) dogsNumberTo.Text = "";
        }

        private void checkBoxcatsNumber_CheckedChanged(object sender, EventArgs e)
        {
            catsNumberFrom.Enabled = checkBoxcatsNumberFrom.Checked;
            catsNumberTo.Enabled = checkBoxcatsNumberTo.Checked;

            if (checkBoxcatsNumberFrom.Checked == false) catsNumberFrom.Text = "";
            if (checkBoxcatsNumberTo.Checked == false) catsNumberTo.Text = "";
        }

        private void openOwnerUserPets_Click(object sender, EventArgs e)
        {

            int selectedIndex = dataGridView.Rows.IndexOf(dataGridView.CurrentRow);
            string ownerUserFIO = dataGridView[1, selectedIndex].Value.ToString();
            ResetSettings();
            filterPetParams["dbo.GetPetOwner(OwnerType, OwnerUser, OwnerCompany)"] = new List<string>();
                filterPetParams["dbo.GetPetOwner(OwnerType, OwnerUser, OwnerCompany)"].Add(ownerUserFIO);

            label.Text = "Реестр животных";
            addPetButton.Visible = true;
            openPetButton.Visible = true;
            deletePetButton.Visible = true;
            sortPetButton.Visible = true;
            exportPetDataButton.Visible = true;

            dataGridView.Columns.Add("ID", "ID");
            dataGridView.Columns.Add("Категория", "Категория");
            dataGridView.Columns.Add("Пол", "Пол");
            dataGridView.Columns.Add("Дата рождения", "Дата рождения");
            dataGridView.Columns.Add("Идентификационная метка", "Идентификационная метка");
            dataGridView.Columns.Add("Номер электронного чипа", "Номер электронного чипа");
            dataGridView.Columns.Add("Кличка", "Кличка");
            dataGridView.Columns.Add("Фото", "Фото");
            dataGridView.Columns.Add("Владелец", "Владелец");
            dataGridView.Columns[0].Visible = false;


            DataTable data = controller.OpenPetsRegistry(filterPetParams);
            InsertDataToPetRegistry(data);
        }

    }
}
