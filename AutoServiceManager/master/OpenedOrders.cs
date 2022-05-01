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
    public partial class OpenedOrders : helpers.BaseForm, helpers.IUpdateContract
    {
        public OpenedOrders()
        {
            InitializeComponent();
        }

        private void OpenedOrders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.order_worker". При необходимости она может быть перемещена или удалена.
            this.order_workerTableAdapter.Fill(this.autoserviceDataSet.order_worker);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.order_worker". При необходимости она может быть перемещена или удалена.
            this.order_workerTableAdapter.Fill(this.autoserviceDataSet.order_worker);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.worker". При необходимости она может быть перемещена или удалена.
            this.workerTableAdapter.Fill(this.autoserviceDataSet.worker);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.autoserviceDataSet.client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.car". При необходимости она может быть перемещена или удалена.
            this.carTableAdapter.Fill(this.autoserviceDataSet.car);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.autoserviceDataSet.order);

            this.onUpdateUI();
        }

        public void onUpdateUI()
        {
            var orders_with_worker = (from order_worker in autoserviceDataSet.order_worker
                                      select order_worker.order_id).ToList();

            var orders = (from order in autoserviceDataSet.order
                          where !orders_with_worker.Contains(order.id)
                          join car in autoserviceDataSet.car on order.car_id equals car.id
                          select new
                          {
                              Номер_заказа = order.id,
                              Автомобиль = car.mark + " " + car.model,
                              Тип_ремонта = order.repair_type,
                              Дата_начала = order.start_date,
                              Статус = order.status
                          }).ToList();
            openedOrdersGridView.DataSource = orders;
            openedOrdersGridView.Columns[0].Visible = false;
            openedOrdersGridView.AutoResizeColumns();
            openedOrdersGridView.ClearSelection();
        }

        private void OpenedOrders_FormClosing(object sender, FormClosingEventArgs e)
        {
            MasterMenu forma = (MasterMenu)helpers.Helper.BackStack;
            forma.onUpdateUI();
            forma.Show();
        }

        private int takenOrder = 0;

        private void setMeButton_Click(object sender, EventArgs e)
        {
            if (takenOrder != 0)
            {
                var confirmResult = MessageBox.Show($"Вы действительно хотите взять в работу заказ №{ takenOrder }?",
                                     "Подтверждение!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes) {
                    order_workerTableAdapter.InsertQuery(takenOrder, helpers.Helper.UserId);
                    orderTableAdapter.UpdateStatus("Выполняется", takenOrder);
                    this.onUpdateUI();
                    MessageBox.Show("Заявка успешно выбрана!");
                    Close();
                }

            } else { MessageBox.Show("Выберите заказ из таблицы"); }
        }

        private void openedOrdersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            takenOrder = (int) openedOrdersGridView[0, openedOrdersGridView.CurrentRow.Index].Value;
            Console.WriteLine(takenOrder);
        }
    }
}
