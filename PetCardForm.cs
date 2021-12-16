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
        Controller controller = new Controller();
        string CurrentPetID;
        Pet CurrentPet;
        Dictionary<string, List<string>> filterParams = new Dictionary<string, List<string>>();

        public PetCardForm()
        {
            InitializeComponent();
            CurrentPetID = Variables.CurrentPet.PetID;
            CurrentPet = Variables.CurrentPet;
        }

        private void PetCardForm_Activated(object sender, EventArgs e)
        {
            CurrentPetID = Variables.CurrentPet.PetID;
            CurrentPet = Variables.CurrentPet;
            UpdateForm();
        }

        private void changeCardButton_Click(object sender, EventArgs e)
        {
            if (controller.roleIsMaching("изменение"))
            {
                ResetVisibility();
                okButton.Visible = true;

                genderComboBox.Visible = true;
                genderComboBox.Text = gender.Text;

                categoryComboBox.Visible = true;
                categoryComboBox.Text = category.Text;

                ownerTypeComboBox.Visible = true;
                ownerTypeComboBox.Text = ownerType.Text;

                ownerComboBox.Visible = true;
                ownerComboBox.Text = owner.Text;

                birthDate.Enabled = true;
                registrationDate.Enabled = true;
                vacinationDate.Enabled = true;
                vacinationDateEnd.Enabled = true;
                dewormingDate.Enabled = true;
                dewormingDateEnd.Enabled = true;
            }
            else MessageBox.Show("Недостаточно прав.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            
            string[] petData = new string[] {
                petName.Text, //0
                (categoryComboBox.SelectedIndex + 1).ToString(), //1
                breed.Text, //2
                genderComboBox.Text, //3
                birthDate.Value.ToString("yyyy-MM-dd"), //4
                registrationDate.Value.ToString("yyyy-MM-dd"), //5
                passportNum.Text, //6
                identificationNum.Text, //7
                chipNum.Text, //8
                vacinationDate.Value.ToString("yyyy-MM-dd"), //9
                vacinationDateEnd.Value.ToString("yyyy-MM-dd"), //10
                dewormingDate.Value.ToString("yyyy-MM-dd"), //11
                dewormingDateEnd.Value.ToString("yyyy-MM-dd"), //12
                vetAppointments.Text, //13
                (ownerTypeComboBox.SelectedIndex + 1).ToString(), //14
                ownerComboBox.SelectedValue.ToString(), //15
                ownerComboBox.SelectedValue.ToString() //16
            };

            string answer = controller.UpdatePetData(CurrentPetID, petData);

            switch (answer)
            {
                case "Карточка успешно изменена.":
                    MessageBox.Show(answer, "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Journal.CommitSystemChangeInfo(DateTime.Now, "изменение", Variables.CurrentUser.ID);
                    break;
                case "Неверные данные.":
                    MessageBox.Show(answer, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "Недостаточно прав.":
                    MessageBox.Show(answer, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            ResetVisibility();

            changeCardButton.Visible = true;

            gender.Visible = true;       
            category.Visible = true;
            ownerType.Visible = true;
            owner.Visible = true;

            petName.ReadOnly = true;    
            breed.ReadOnly = true;
            vetAppointments.ReadOnly = true;
            passportNum.ReadOnly = true;
            identificationNum.ReadOnly = true;
            chipNum.ReadOnly = true;
        }

        private void ResetVisibility()
        {
            
            changeCardButton.Visible = false;  //кнопки
            okButton.Visible = false;

            gender.Visible = false;           //комбобоксы
            category.Visible = false;
            ownerType.Visible = false;
            owner.Visible = false;

            genderComboBox.Visible = false;
            categoryComboBox.Visible = false;
            ownerTypeComboBox.Visible = false;
            ownerComboBox.Visible = false;

            petName.ReadOnly = false;        //все остальное
            birthDate.Enabled = false;
            breed.ReadOnly = false;
            registrationDate.Enabled = false;
            vacinationDate.Enabled = false;
            vacinationDateEnd.Enabled = false;
            dewormingDate.Enabled = false;
            dewormingDateEnd.Enabled = false;
            vetAppointments.ReadOnly = false;
            passportNum.ReadOnly = false;
            identificationNum.ReadOnly = false;
            chipNum.ReadOnly = false;
        }

        private void UpdateForm()
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
            passportNum.Text = CurrentPet.PassportNum;
            identificationNum.Text = CurrentPet.IdentificationNum;
            chipNum.Text = CurrentPet.ChipNum;
        }

        private void ownerTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ownerTypeComboBox.SelectedIndex == 0)
            {
                DataTable data = controller.OpenOwnersUserRegistry(filterParams);
                ownerComboBox.DataSource = data;
                ownerComboBox.ValueMember = data.Columns[0].ToString();
                ownerComboBox.DisplayMember = data.Columns[1].ToString();
            }
            else if (ownerTypeComboBox.SelectedIndex == 1)
            {
                DataTable data = controller.OpenOwnersOrgRegistry(filterParams);
                ownerComboBox.DataSource = data;
                ownerComboBox.ValueMember = data.Columns[0].ToString();
                ownerComboBox.DisplayMember = data.Columns[1].ToString();
            }
        }
    }
}
