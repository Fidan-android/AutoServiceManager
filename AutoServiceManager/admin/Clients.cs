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
    public partial class Clients : helpers.BaseForm, helpers.IUpdateContract
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void configureData()
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.autoserviceDataSet.client);
        }

        public void onUpdateUI()
        {
            configureData();

            var clients = (from c in autoserviceDataSet.client
                          select new
                          {
                              c.id,
                              ФИО = c.first_name + " " + c.middle_name + " " + c.last_name,
                              ДР = c.birthday,
                              Паспорт = c.passport,
                              ИНН = c.tin,
                              Пол = c.male == "м" ? "Мужской" : "Женский"
                          }).ToList();

            clientsDataGridView.DataSource = clients;
            clientsDataGridView.Columns[0].Visible = false;
            clientsDataGridView.AutoResizeColumns();
            clientsDataGridView.ClearSelection();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            onUpdateUI();
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            helpers.Helper.BackStack = this;
            new AddClient().Show();
        }

        private void Clients_FormClosing(object sender, FormClosingEventArgs e)
        {
            helpers.Helper.Quit(false);
        }
    }
}
