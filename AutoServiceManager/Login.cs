using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoServiceManager
{
    public partial class Login : helpers.BaseForm
    {
        private AutoserviceDataSet.workerRow worker = null; 
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.worker". При необходимости она может быть перемещена или удалена.
            this.workerTableAdapter.Fill(this.autoserviceDataSet.worker);
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            logInButton.Enabled = false;
            var login = loginTextBox.Text.ToString();
            var password = passwordTextBox.Text.ToString();

            var result = autoserviceDataSet.worker.Where(w => w.login == login);
            if (result.Count() == 0) {
                errorLabel.Visible = true;
                showError.Start();
                return;
            }

            worker = result.First();
            if (!worker.password.Equals(password)) {
                errorLabel.Visible = true;
                showError.Start();
                return;
            }

            successLabel.Visible = true;
            successAuth.Start();
        }

        private void showPasswordButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = helpers.Helper.ShowPassword;
            showPasswordButton.BackgroundImage = helpers.Helper.PasswordImage;
        }

        private void showError_Tick(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            logInButton.Enabled = true;
            showError.Stop();
        }

        private void successAuth_Tick(object sender, EventArgs e)
        {
            successLabel.Visible = false;
            helpers.Helper.UserId = worker.id;
            logInButton.Enabled = true;
            successAuth.Stop();
            switch (worker.role)
            {
                case "admin":
                    {
                        helpers.Helper.BackStack = this;
                        new admin.AdminMenu().Show();
                        break;
                    }
                case "master":
                    {
                        helpers.Helper.BackStack = this;
                        new master.MasterMenu().Show();
                        break;
                    }
            }
        }
    }
}
