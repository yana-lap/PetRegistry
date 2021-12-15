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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            if (controller.Login(loginTextBox.Text, passwordTextBox.Text))
            {
                Form registryForm = new RegistryForm();
                registryForm.ShowDialog();
            }
            else
                MessageBox.Show("Неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginTextBox.Text = "vet";
            passwordTextBox.Text = "vet";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginTextBox.Text = "sapov";
            passwordTextBox.Text = "sapov";
        }
    }
}
