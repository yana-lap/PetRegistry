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
    public partial class AddPetCard : Form
    {
        Controller controller = new Controller();
        Dictionary<string, List<string>> filterParams = new Dictionary<string, List<string>>();
        public AddPetCard()
        {
            InitializeComponent();
            categoryComboBox.SelectedIndex = 0;
            genderComboBox.SelectedIndex = 0;
            ownerTypeComboBox.SelectedIndex = 0;
        }

        private void addPetButton_Click(object sender, EventArgs e)
        { 
            string answer = controller.RegisterNewPet(new string[] 
            { 
                nameTextBox.Text, //0 Кличка не нул
                (categoryComboBox.SelectedIndex+1).ToString(), //1 категория не нул
                breedTextBox.Text, //2 порода не нул
                genderComboBox.Text, //3 пол не нул
                birthDate.Value.ToString("yyyy-MM-dd"), //4 день рождения  нул
                registrationDate.Value.ToString("yyyy-MM-dd"), // 5 дата регистрации  не нул
                passportNum.Text, //6 номер паспорта  нул
                identificationNum.Text, //7 идентификационный номер нул
                chipNumberTextBox.Text, //8 номер чипа нул
                vacinationDate.Value.ToString("yyyy-MM-dd"), //9 дата вакцинации нул
                vacinationDateEnd.Value.ToString("yyyy-MM-dd"), //10 окончание дейтсвия вакцины нул
                dewormingDate.Value.ToString("yyyy-MM-dd"), //11 дегельм. дата нул
                dewormingDateEnd.Value.ToString("yyyy-MM-dd"), //12 окончания дегельм. нул
                vetAppointments.Text, //13 назначения ветеринара нул
                //14 фото
                (ownerTypeComboBox.SelectedIndex+1).ToString(), //14 тип владельца  не нул
                ownerComboBox.SelectedValue.ToString(),  //15 владелец ФЛ  нул
                ownerComboBox.SelectedValue.ToString() //16 владелец ЮЛ нул
            });
            switch (answer)
            {
                case "Животное успешно добавлено.":
                    MessageBox.Show(answer, "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Journal.CommitSystemChangeInfo(DateTime.Now, "добавление", Variables.CurrentUser.ID);
                    this.Close();
                    break;
                case "Неверные данные.":
                    MessageBox.Show(answer, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "Недостаточно прав.":
                    MessageBox.Show(answer, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    break;
            }
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
            else
            if (ownerTypeComboBox.SelectedIndex == 1)
            {
                DataTable data = controller.OpenOwnersOrgRegistry(filterParams);
                ownerComboBox.DataSource = data;
                ownerComboBox.ValueMember = data.Columns[0].ToString();
                ownerComboBox.DisplayMember = data.Columns[1].ToString();
            }
        }
    }
}
