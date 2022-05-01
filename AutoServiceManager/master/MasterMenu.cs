using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoServiceManager.master
{
    public sealed partial class MasterMenu : helpers.BaseForm, helpers.IUpdateContract
    {
        public MasterMenu()
        {
            InitializeComponent();
        }

        private void MasterMenu_Load(object sender, EventArgs e) {
            configureData();
            onUpdateUI();
        }

        private void MasterMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            var confirmResult = MessageBox.Show("Вы действительно хотите выйти из приложения?",
                                     "Confirm Exit!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes) { helpers.Helper.Quit(); }
            else { e.Cancel = true; }
        }

        private void openedOrdersButton_Click(object sender, EventArgs e)
        {
            helpers.Helper.BackStack = this;
            new OpenedOrders().Show();
        }

        private void currentOrderButton_Click(object sender, EventArgs e)
        {
            helpers.Helper.BackStack = this;
            new CurrentOrder().Show();
        }

        private void closedOrdersButton_Click(object sender, EventArgs e)
        {
            helpers.Helper.BackStack = this;
            new ClosedOrders().Show();
        }

        private void configureData()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.order_worker". При необходимости она может быть перемещена или удалена.
            this.order_workerTableAdapter.Fill(this.autoserviceDataSet.order_worker);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.autoserviceDataSet.order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.worker". При необходимости она может быть перемещена или удалена.
            this.workerTableAdapter.Fill(this.autoserviceDataSet.worker);
        }

        public void onUpdateUI()
        {
            configureData();
            if (helpers.Helper.UserId == 0)
            {
                helpers.Helper.Quit(false);
            }
            else
            {
                var worker = autoserviceDataSet.worker.Where(w => w.id == helpers.Helper.UserId).First();
                masterNameLabel.Text = "Мастер: " + worker.first_name + " " + worker.middle_name;

                var orders = (from order in autoserviceDataSet.order
                              join order_worker in autoserviceDataSet.order_worker on order.id equals order_worker.order_id
                              where order.status == "Выполняется" && order_worker.worker_id == worker.id
                              select order.id).ToList();
                //var orders = autoserviceDataSet.order.Where(r => r.worker_id == worker.id && r.status.Equals("Выполняется"));

                currentOrderButton.Enabled = orders.Count() != 0;
                openedOrdersButton.Enabled = orders.Count() == 0;
            }
        }
    }
}
