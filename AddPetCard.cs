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
        public AddPetCard()
        {
            InitializeComponent();
            categoryComboBox.SelectedIndex = 0;
            genderComboBox.SelectedIndex = 0;
            ownerTypeComboBox.SelectedIndex = 0;

        }

        private void addPetButton_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            controller.RegisterNewPet(new string[] { nameTextBox.Text, (categoryComboBox.SelectedIndex+1).ToString(), breedTextBox.Text, genderComboBox.Text,
                birthDate.Value.ToString("yyyy-MM-dd"), registrationDate.Value.ToString("yyyy-MM-dd"),
                passportNum.Text, identificationNum.Text, numberTextBox.Text, vacinationDate.Value.ToString("yyyy-MM-dd"),
                vacinationDateEnd.Value.ToString("yyyy-MM-dd"), dewormingDate.Value.ToString("yyyy-MM-dd"),
                dewormingDateEnd.Value.ToString("yyyy-MM-dd"), vetAppointments.Text,(ownerTypeComboBox.SelectedIndex+1).ToString(), ownerComboBox.Text, ""});
        }
    }
}
