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
    public partial class CurrentOrder : helpers.BaseForm, helpers.IUpdateContract
    {
        public CurrentOrder()
        {
            InitializeComponent();
        }

        private void CurrentOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            MasterMenu forma = (MasterMenu)helpers.Helper.BackStack;
            forma.onUpdateUI();
            forma.Show();
        }

        private void CurrentOrder_Load(object sender, EventArgs e)
        {
            configureData();
            onUpdateUI();
        }

        private void configureData()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.car". При необходимости она может быть перемещена или удалена.
            this.carTableAdapter.Fill(this.autoserviceDataSet.car);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.spares_order". При необходимости она может быть перемещена или удалена.
            this.spares_orderTableAdapter.Fill(this.autoserviceDataSet.spares_order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.spare". При необходимости она может быть перемещена или удалена.
            this.spareTableAdapter.Fill(this.autoserviceDataSet.spare);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.autoserviceDataSet.order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.order_worker". При необходимости она может быть перемещена или удалена.
            this.order_workerTableAdapter.Fill(this.autoserviceDataSet.order_worker);
        }

        public void onUpdateUI() {
            configureData();

            var order_info = (from o in autoserviceDataSet.order
                          join ow in autoserviceDataSet.order_worker on o.id equals ow.order_id
                          where ow.worker_id == helpers.Helper.UserId && o.status == "Выполняется"
                          join c in autoserviceDataSet.car on o.car_id equals c.id
                          select new
                          {
                              o.id,
                              Машина = c.mark + " " + c.model,
                              o.repair_type,
                              o.start_date,
                              o.status
                          }).First();

            helpers.Helper.OrderId = order_info.id;

            var spares_order = (from so in autoserviceDataSet.spares_order
                               where so.request_id == order_info.id
                               join s in autoserviceDataSet.spare on so.spare_id equals s.id
                               select new
                               {
                                   so.id,
                                   Марка = s.mark,
                                   Модель = s.model
                               }).ToList();

            carLabel.Text = "Машина: " + order_info.Машина;            
            repairTypeLabel.Text = "Тип ремонта: " + order_info.repair_type;            
            dateStartLabel.Text = "Дата начала: " + order_info.start_date;            
            statusLabel.Text = "Статус: " + order_info.status;     
            
            detailsDataGridView.DataSource = spares_order;
            detailsDataGridView.Columns[0].Visible = false;
            detailsDataGridView.AutoResizeColumns();
            detailsDataGridView.ClearSelection();
        }

        private void addDetailButton_Click(object sender, EventArgs e)
        {
            helpers.Helper.BackStack = this;
            new AddSpare().Show();
        }

        private void removeDetailButton_Click(object sender, EventArgs e)
        {
            if (takenDetail == 0) {
                MessageBox.Show("Из списка ничего не выбрано");
            } else
            {
                Console.WriteLine(takenDetail);
                spares_orderTableAdapter.DeleteById(takenDetail);
                onUpdateUI();
            }
        }

        private int takenDetail = 0;

        private void detailsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (detailsDataGridView.CurrentRow != null)
                takenDetail = (int)detailsDataGridView[0, detailsDataGridView.CurrentRow.Index].Value;
        }

        private void cancelOrderButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Вы действительно хотите отказаться от заявки?",
                                     "Отказ!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes) {
                orderTableAdapter.UpdateStatusAndFinishDate(DateTime.Now, "В ожидании", helpers.Helper.OrderId);
                MessageBox.Show("Заявка отказана");
                Close();
            }
        }

        private void finishOrderButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Вы действительно хотите завершить заявку?",
                                     "Завершение!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                orderTableAdapter.UpdateStatusAndFinishDate(DateTime.Now, "Завершена", helpers.Helper.OrderId);
                MessageBox.Show("Заявка завершена");
                Close();
            }
        }
    }
}
