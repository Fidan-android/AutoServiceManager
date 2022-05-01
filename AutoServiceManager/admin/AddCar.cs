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
    public partial class AddCar : helpers.BaseForm, helpers.IUpdateContract
    {
        public AddCar()
        {
            InitializeComponent();
        }

        private void configureData()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.car". При необходимости она может быть перемещена или удалена.
            this.carTableAdapter.Fill(this.autoserviceDataSet.car);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.autoserviceDataSet.client);
        }

        public void onUpdateUI()
        {
            configureData();

            var clients = (from client in autoserviceDataSet.client
                           select new
                           {
                               client.id,
                               фио = client.first_name + " " + client.middle_name + " " + client.last_name
                           }).ToList();

            clientsComboBox.DataSource = clients;
            clientsComboBox.DisplayMember = "фио";
            clientsComboBox.ValueMember = "id";

        }

        private void AddCar_Load(object sender, EventArgs e)
        {
            onUpdateUI();
        }

        private int takenClient = 0;
        private void clientsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            takenClient = (int) clientsComboBox.SelectedValue;
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            if (takenClient == 0)
            {
                MessageBox.Show("Выберите клиента");
            } else
            {
                if (markTextBox.Text == "")
                {
                    MessageBox.Show("Не все поля заполнены");
                    return;
                }
                if (modelTextBox.Text == "")
                {
                    MessageBox.Show("Не все поля заполнены");
                    return;
                }
                if (numberTextBox.Text == "")
                {
                    MessageBox.Show("Не все поля заполнены");
                    return;
                }

                carTableAdapter.Insert(
                    markTextBox.Text,
                    modelTextBox.Text,
                    numberTextBox.Text,
                    colorTextBox.Text,
                    takenClient
                );
                MessageBox.Show("Успешно создан");
                Close();
            }
        }

        private void AddCar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cars forma = (Cars) helpers.Helper.BackStack;
            forma.onUpdateUI();
            forma.Show();
        }
    }
}
