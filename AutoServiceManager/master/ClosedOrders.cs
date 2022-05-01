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
    public partial class ClosedOrders : helpers.BaseForm, helpers.IUpdateContract
    {
        public ClosedOrders()
        {
            InitializeComponent();
        }

        private void ClosedOrders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.car". При необходимости она может быть перемещена или удалена.
            this.carTableAdapter.Fill(this.autoserviceDataSet.car);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.spare". При необходимости она может быть перемещена или удалена.
            this.spareTableAdapter.Fill(this.autoserviceDataSet.spare);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.spares_order". При необходимости она может быть перемещена или удалена.
            this.spares_orderTableAdapter.Fill(this.autoserviceDataSet.spares_order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.order_worker". При необходимости она может быть перемещена или удалена.
            this.order_workerTableAdapter.Fill(this.autoserviceDataSet.order_worker);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.autoserviceDataSet.order);

            onUpdateUI();
        }

        private void ClosedOrders_FormClosing(object sender, FormClosingEventArgs e)
        {
            helpers.Helper.Quit(false);
        }

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoserviceDataSet);

        }

        public void onUpdateUI()
        {
            var order_info = (from o in autoserviceDataSet.order
                              join ow in autoserviceDataSet.order_worker on o.id equals ow.order_id
                              where ow.worker_id == helpers.Helper.UserId && o.status != "Выполняется"
                              join c in autoserviceDataSet.car on o.car_id equals c.id
                              select new
                              {
                                  o.id,
                                  Машина = c.mark + " " + c.model,
                                  Ремонт = o.repair_type,
                                  Начал = o.start_date,
                                  Завершил = o.finish_date,
                                  Статус = o.status
                              }).ToList();
            myOrdersDataGridView.DataSource = order_info;
            myOrdersDataGridView.Columns[0].Visible = false;
            myOrdersDataGridView.AutoResizeColumns();
            myOrdersDataGridView.ClearSelection();
        }
    }
}
