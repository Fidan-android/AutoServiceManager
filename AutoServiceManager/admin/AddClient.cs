using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoServiceManager.admin
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void AddClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            Clients forma = (Clients) helpers.Helper.BackStack;
            forma.onUpdateUI();
            forma.Show();
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            if (firstnameTextBox.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }
            if (lastnameTextBox.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }
            if (passportTextBox.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }
            if (tinTextBox.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }
            if (birthdayDateTimePicker.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }
            if (maleTextBox.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }

            clientTableAdapter.InsertWithoutCreated(
                firstnameTextBox.Text,
                nameTextBox.Text,
                lastnameTextBox.Text,
                passportTextBox.Text,
                tinTextBox.Text,
                birthdayDateTimePicker.Value.Date,
                maleTextBox.Text
            );
            MessageBox.Show("Успешно создан");
            Close();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoserviceDataSet);

        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.autoserviceDataSet.client);

        }
    }
}
