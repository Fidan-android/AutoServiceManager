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
    public partial class Orders : helpers.BaseForm, helpers.IUpdateContract
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            onUpdateUI();
        }

        public void onUpdateUI()
        {
            configureData();
            carsComboBox.Enabled = false;
            var clients = (from c in autoserviceDataSet.client
                          orderby c.id
                          select new
                          {
                              ИД = c.id,
                              ФИО = c.first_name + " " + c.middle_name + " " + c.last_name
                          }).ToList();

            clientsComboBox.DisplayMember = "ФИО";
            clientsComboBox.ValueMember = "ИД";
            clientsComboBox.DataSource = clients;
            clientsComboBox.SelectedIndex = -1;
        }

        private void configureData()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.autoserviceDataSet.order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.car". При необходимости она может быть перемещена или удалена.
            this.carTableAdapter.Fill(this.autoserviceDataSet.car);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.autoserviceDataSet.client);
        }

        private int takenClient = 0;
        private void clientsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            takenClient = clientsComboBox.SelectedValue == null ? 0 : (int)clientsComboBox.SelectedValue;
            setCars();
        }

        private void setCars()
        {
            var cars = (from c in autoserviceDataSet.car
                       where c.client_id == takenClient
                       select new
                       {
                           c.id,
                           Машина = c.gos_number + " - " + c.mark + " " + c.model
                       }).ToList();

            carsComboBox.Enabled = true;
            carsComboBox.DisplayMember = "Машина";
            carsComboBox.ValueMember = "id";
            carsComboBox.DataSource = cars;
            carsComboBox.SelectedIndex = -1;
        }

        private int takenCar = 0;
        private void carsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carsComboBox.SelectedValue != null)
                takenCar = (int)carsComboBox.SelectedValue;
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            if (takenClient != 0 || takenCar != 0 || repairTypeTextBox.Text != "")
            {
                var confirmResult = MessageBox.Show("Вы действительно хотите создать заявку?",
                                     "Создание заявки",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    orderTableAdapter.InsertQuery(takenCar, repairTypeTextBox.Text.Trim());
                    MessageBox.Show("Заявка создана");
                    Close();
                }
            } else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
        }

        private void Orders_FormClosing(object sender, FormClosingEventArgs e)
        {
            helpers.Helper.Quit(false);
        }
    }
}
