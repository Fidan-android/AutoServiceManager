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
    public partial class Cars : helpers.BaseForm, helpers.IUpdateContract
    {
        public Cars()
        {
            InitializeComponent();
        }

        private void configureData()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.autoserviceDataSet.client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.car". При необходимости она может быть перемещена или удалена.
            this.carTableAdapter.Fill(this.autoserviceDataSet.car);
        }

        public void onUpdateUI()
        {
            configureData();

            var cars = (from ca in autoserviceDataSet.car
                        join cl in autoserviceDataSet.client on ca.client_id equals cl.id
                        select new
                        {
                            ca.id,
                            ФИО = cl.first_name + " " + cl.middle_name + " " + cl.last_name,
                            Машина = ca.mark + " " + ca.model
                        }).ToList();

            var clients = (from client in autoserviceDataSet.client
                           select new
                           {
                               client.id,
                               фио = client.first_name + " " + client.middle_name + " " + client.last_name
                           }).ToList();

            carsDataGridView.DataSource = cars;
            carsDataGridView.Columns[0].Visible = false;
            carsDataGridView.AutoResizeColumns();
            carsDataGridView.ClearSelection();
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            onUpdateUI();
        }

        private void Cars_FormClosing(object sender, FormClosingEventArgs e)
        {
            helpers.Helper.Quit(false);
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            helpers.Helper.BackStack = this;
            
        }
    }
}
