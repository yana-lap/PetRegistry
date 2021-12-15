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
        string typeOfOwner = "";

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
            sortOwnerUserButton.Visible = true;
            typeOfOwner = "физическиеЛица";

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
            countryUsersCheckListBox.Visible = true;


            DataTable data = controller.OpenOwnersUserRegistry();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var row = data.Rows[i];
                dataGridView.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
            }

            countryUsersCheckListBox.Items.Clear();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var row = data.Rows[i];
                if (!countryUsersCheckListBox.Items.Contains(row[2]))
                    countryUsersCheckListBox.Items.Add(row[2]);
            }
        }

        private void sortOwnerUserButton_Click(object sender, EventArgs e)
        {
            ownerUserFilterGroupBox.Visible = true;
        }

        private void getOwnerUsersParams_Click(object sender, EventArgs e) ////////////////
        {
            if (countryUsersCheckListBox.CheckedItems.Count == 0 && petsNumberFrom.TextLength == 0 
                && dogsNumberFrom.TextLength == 0 && catsNumberFrom.TextLength == 0)
            {
                ownerUserFilterGroupBox.Visible = false;
                return;
            }
            
            Dictionary<string, List<string>> ownerFilter = new Dictionary<string, List<string>>();
            if (typeOfOwner == "физическиеЛица")
            {
                if (countryUsersCheckListBox.CheckedItems.Count != 0)
                {
                    ownerFilter["Users.Country"] = new List<string>();
                    foreach (var el in categoryCheckedListBox.CheckedItems)
                        ownerFilter["Users.Country"].Add(el.ToString());
                }
                if (petsNumberFrom.TextLength > 0)
                {
                    ownerFilter["Count(Pets.OwnerUser)"] = new List<string>();

                    ownerFilter["Count(Pets.OwnerUser)"].Add(petsNumberFrom.Text);
                    ownerFilter["Count(Pets.OwnerUser)"].Add(petsNumberTo.Text);
                }
                if (dogsNumberFrom.TextLength > 0)
                {
                    ownerFilter["dbo.GetCatDogCount(1,Users.IDUser,2)"] = new List<string>();

                    ownerFilter["dbo.GetCatDogCount(1,Users.IDUser,2)"].Add(dogsNumberFrom.Text);
                    ownerFilter["dbo.GetCatDogCount(1,Users.IDUser,2)"].Add(dogsNumberTo.Text);
                }
                if (catsNumberFrom.TextLength > 0)
                {
                    ownerFilter["dbo.GetCatDogCount(1, Users.IDUser, 1)"] = new List<string>();

                    ownerFilter["dbo.GetCatDogCount(1, Users.IDUser, 1)"].Add(catsNumberFrom.Text);
                    ownerFilter["dbo.GetCatDogCount(1, Users.IDUser, 1)"].Add(catsNumberTo.Text);
                }
            }
            else
            {
                if (ownerCompanyCountryCheckedListBox.CheckedItems.Count != 0)
                {
                    ownerFilter["Organizations.Country"] = new List<string>();
                    foreach (var el in categoryCheckedListBox.CheckedItems)
                        ownerFilter["Organizations.Country"].Add(el.ToString());
                }
                if (petsNumberFrom.TextLength > 0)
                {
                    ownerFilter["Count(Pets.OwnerUser)"] = new List<string>();

                    ownerFilter["Count(Pets.OwnerUser)"].Add(petsNumberFrom.Text);
                    ownerFilter["Count(Pets.OwnerUser)"].Add(petsNumberTo.Text);
                }
                if (dogsNumberFrom.TextLength > 0)
                {
                    ownerFilter["dbo.GetCatDogCount(1,Users.IDUser,2)"] = new List<string>();

                    ownerFilter["dbo.GetCatDogCount(1,Users.IDUser,2)"].Add(dogsNumberFrom.Text);
                    ownerFilter["dbo.GetCatDogCount(1,Users.IDUser,2)"].Add(dogsNumberTo.Text);
                }
                if (catsNumberFrom.TextLength > 0)
                {
                    ownerFilter["dbo.GetCatDogCount(1, Users.IDUser, 1)"] = new List<string>();

                    ownerFilter["dbo.GetCatDogCount(1, Users.IDUser, 1)"].Add(catsNumberFrom.Text);
                    ownerFilter["dbo.GetCatDogCount(1, Users.IDUser, 1)"].Add(catsNumberTo.Text);
                }
            }

            DataTable data = controller.OpenOwnersUserRegistry(ownerFilter);
            dataGridView.Rows.Clear();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var row = data.Rows[i];
                dataGridView.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
            }

            ownerUserFilterGroupBox.Visible = false;
        }


        //private void getOwCParams_Click(object sender, EventArgs e) ///////////////
        //{
        //    Dictionary<string, List<string>> ownerFilter = new Dictionary<string, List<string>>();

            

        //    DataTable data = controller.OpenOwnersOrgRegistry(ownerFilter);
        //    dataGridView.Rows.Clear();
        //    for (int i = 0; i < data.Rows.Count; i++)
        //    {
        //        var row = data.Rows[i];
        //        dataGridView.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10]);
        //    }

        //    // ownerCompanyFilterGroupBox.Visible = false;
        //}

        private void юридическиеЛицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetSettings();
            //sortOwnerCompanyButton.Visible = true;
            typeOfOwner = "юридическиеЛица";

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
            ownerCompanyCountryCheckedListBox.Visible = true;


            DataTable data = controller.OpenOwnersOrgRegistry();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var row = data.Rows[i];
                dataGridView.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10]);
            }

            ownerCompanyCountryCheckedListBox.Items.Clear();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var row = data.Rows[i];
                if (!countryUsersCheckListBox.Items.Contains(row[4]))
                    countryUsersCheckListBox.Items.Add(row[4]);
            }
        }

        //private void sortOwnerCompanyButton_Click(object sender, EventArgs e)
        //{
        //    ownerCompanyFilterGroupBox.Visible = true;
        //}


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
            exportPetDataButton.Visible = false;

            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            petFilterGroupBox.Visible = false;
            ownerUserFilterGroupBox.Visible = false;

            ownerCompanyCountryCheckedListBox.Visible = false;
            countryUsersCheckListBox.Visible = false;
            // ownerCompanyFilterGroupBox.Visible = false;
        }
        private void openPetButton_Click(object sender, EventArgs e)
        {
            if (controller.roleIsMaching("открытие карточки"))
            {
                int selectedIndex = dataGridView.Rows.IndexOf(dataGridView.CurrentRow);
                Variables.CurrentPet = controller.OpenPetCard(dataGridView[0, selectedIndex].Value.ToString());

                Form petCard = new PetCardForm();
                petCard.ShowDialog();

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


        private void sortPetButton_Click(object sender, EventArgs e)
        {
            petFilterGroupBox.Visible = true;
        }

        private void getPetParams_Click(object sender, EventArgs e)
        {
            Dictionary<string, List<string>> petFilter = new Dictionary<string, List<string>>();
            if (categoryCheckedListBox.CheckedItems.Count == 0 && genderCheckedListBox.CheckedItems.Count == 0
                && ownerTypeCheckedListBox.CheckedItems.Count == 0 && ownerCheckedListBox.CheckedItems.Count == 0)
            {
                petFilterGroupBox.Visible = false;
                return;
            }
            
            if (categoryCheckedListBox.CheckedItems.Count != 0)
            {
                petFilter["Categories.CategoryName"] = new List<string>();
                foreach (var el in categoryCheckedListBox.CheckedItems)
                    petFilter["Categories.CategoryName"].Add(el.ToString());
            }

            if (genderCheckedListBox.CheckedItems.Count != 0)
            {
                petFilter["Pets.Gender"] = new List<string>();
                foreach (var el in genderCheckedListBox.CheckedItems)
                    petFilter["Pets.Gender"].Add(el.ToString());
            }

            if (ownerTypeCheckedListBox.CheckedItems.Count != 0)
            {
                petFilter["OwnerTypes.TypeName"] = new List<string>();
                foreach (var el in ownerTypeCheckedListBox.CheckedItems)
                    petFilter["OwnerTypes.TypeName"].Add(el.ToString());
            }
            //MessageBox.Show(petFilter["OwnerTypes.TypeName"][0] + petFilter["OwnerTypes.TypeName"][1]);
            if (ownerCheckedListBox.CheckedItems.Count != 0)
            {
                petFilter["dbo.GetPetOwner(OwnerType, OwnerUser, OwnerCompany)"] = new List<string>();
                foreach (var el in ownerCheckedListBox.CheckedItems)
                    petFilter["dbo.GetPetOwner(OwnerType, OwnerUser, OwnerCompany)"].Add(el.ToString());
            }

            //НЕ ХВАТАЕТ ДАТ

            DataTable data = controller.OpenPetsRegistry(petFilter);
            UpdatePetRegistry(data);

            petFilterGroupBox.Visible = false;
        }

        private void UpdatePetRegistry(DataTable data)
        {
            dataGridView.Rows.Clear();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var row = data.Rows[i];
                dataGridView.Rows.Add(row[0], row[1], row[2], row[3].ToString().Substring(0, 10),
                    row[4], row[5], row[6], row[7], row[8]);
            }
        }

        private void exportPetDataButton_Click(object sender, EventArgs e)
        {


        }

        private void ownerTypeCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ownerTypeCheckedListBox.CheckedItems.Contains("Физическое лицо")
                && ownerTypeCheckedListBox.CheckedItems.Contains("Юридическое лицо"))
            {
                ownerCheckedListBox.Items.Clear();
                DataTable data = controller.OpenOwnersUserRegistry();
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    var row = data.Rows[i];
                    if (!ownerCheckedListBox.Items.Contains(row[1]))
                        ownerCheckedListBox.Items.Add(row[1]);
                }
                data = controller.OpenOwnersOrgRegistry();
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
                DataTable data = controller.OpenOwnersUserRegistry();
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
                DataTable data = controller.OpenOwnersOrgRegistry();
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    var row = data.Rows[i];
                    if (!ownerCheckedListBox.Items.Contains(row[1]))
                        ownerCheckedListBox.Items.Add(row[1]);
                }
            }
            else { ownerCheckedListBox.Items.Clear(); }
        }
    }
}
