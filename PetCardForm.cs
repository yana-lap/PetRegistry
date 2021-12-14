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
    public partial class PetCardForm : Form
    {
        Controller Controller = new Controller();
        string CurrentPetID;
        Pet CurrentPet;
        
        public PetCardForm(string petID, Pet pet)
        {
            InitializeComponent();
            CurrentPetID = petID;
            CurrentPet = pet;
        }

        private void PetCardForm_Activated(object sender, EventArgs e)
        {
            petName.Text = CurrentPet.PetName;
            gender.Text = CurrentPet.Gender;
            birthDate.Value = CurrentPet.BirthDate;
            category.Text = CurrentPet.Category;
            breed.Text = CurrentPet.Breed;
            ownerType.Text = CurrentPet.OwnerType;
            owner.Text = CurrentPet.Owner;
            registrationDate.Value = CurrentPet.RegistrationDate;
            vacinationDate.Value = CurrentPet.VacinationDate;
            vacinationDateEnd.Value = CurrentPet.VacinationDateEnd;
            dewormingDate.Value = CurrentPet.DewormingDate;
            dewormingDateEnd.Value = CurrentPet.DewormingDateEnd;
            vetAppointments.Text = CurrentPet.VetAppointments;
            label.Text = CurrentPet.PassportNum;
            identificationNum.Text = CurrentPet.IdentificationNum;
            chipNum.Text = CurrentPet.ChipNum;
        }

        private void changeCardButton_Click(object sender, EventArgs e)
        {
            changeCardButton.Enabled = false; //кнопки
            changeCardButton.Visible = false;
            okButton.Enabled = true;
            okButton.Visible = true;

            gender.Visible = false;           //комбобоксы
            category.Visible = false;
            ownerType.Visible = false;
            owner.Visible = false;

            genderComboBox.Visible = true;
            categoryComboBox.Visible = true;
            ownerTypeComboBox.Visible = true;
            ownerComboBox.Visible = true;

            petName.ReadOnly = false;        //все остальное
            birthDate.Enabled = true;
            breed.ReadOnly = false;
            registrationDate.Enabled = true;
            vacinationDate.Enabled = true;
            vacinationDateEnd.Enabled = true;
            dewormingDate.Enabled = true;
            dewormingDateEnd.Enabled = true;
            vetAppointments.ReadOnly = false;
            passportNum.ReadOnly = false;
            identificationNum.ReadOnly = false;
            chipNum.ReadOnly = false;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string[] petData = new string[] {petName.Text, (categoryComboBox.SelectedIndex + 1).ToString(), breed.Text, genderComboBox.Text,
                birthDate.Value.ToString("yyyy-MM-dd"), registrationDate.Value.ToString("yyyy-MM-dd"),
                passportNum.Text, identificationNum.Text, chipNum.Text,
                vacinationDate.Value.ToString("yyyy-MM-dd"), vacinationDateEnd.Value.ToString("yyyy-MM-dd"),
                dewormingDate.Value.ToString("yyyy-MM-dd"), dewormingDateEnd.Value.ToString("yyyy-MM-dd"),
                vetAppointments.Text, (ownerTypeComboBox.SelectedIndex + 1).ToString(),
                ownerComboBox.SelectedValue.ToString(), ownerComboBox.SelectedValue.ToString() };
            string answer = Controller.UpdatePetData(CurrentPetID, petData);

            switch (answer)
            {
                case "Карточка успешно изменена.":
                    MessageBox.Show(answer, "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Неверные данные.":
                    MessageBox.Show(answer, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "Недостаточно прав.":
                    MessageBox.Show(answer, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            changeCardButton.Enabled = true; //кнопки
            changeCardButton.Visible = true;
            okButton.Enabled = false;
            okButton.Visible = false;

            gender.Visible = true;           //комбобоксы
            category.Visible = true;
            ownerType.Visible = true;
            owner.Visible = true;

            genderComboBox.Visible = false;
            categoryComboBox.Visible = false;
            ownerTypeComboBox.Visible = false;
            ownerComboBox.Visible = false;

            petName.ReadOnly = true;        //все остальное
            birthDate.Enabled = false;
            breed.ReadOnly = true;
            registrationDate.Enabled = false;
            vacinationDate.Enabled = false;
            vacinationDateEnd.Enabled = false;
            dewormingDate.Enabled = false;
            dewormingDateEnd.Enabled = false;
            vetAppointments.ReadOnly = true;
            passportNum.ReadOnly = true;
            identificationNum.ReadOnly = true;
            chipNum.ReadOnly = true;
        }

        private void ownerTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ownerTypeComboBox.SelectedIndex == 0)
            {
                DataTable data = Controller.OpenOwnersUserRegistry();
                ownerComboBox.DataSource = data;
                ownerComboBox.ValueMember = data.Columns[0].ToString();
                ownerComboBox.DisplayMember = data.Columns[1].ToString();
            }
            else if (ownerTypeComboBox.SelectedIndex == 1)
            {
                DataTable data = Controller.OpenOwnersOrgRegistry();
                ownerComboBox.DataSource = data;
                ownerComboBox.ValueMember = data.Columns[0].ToString();
                ownerComboBox.DisplayMember = data.Columns[1].ToString();
            }
        }
    }
}
