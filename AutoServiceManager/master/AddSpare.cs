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
    public partial class AddSpare : helpers.BaseForm,helpers.IUpdateContract
    {
        public AddSpare()
        {
            InitializeComponent();
        }

        private void AddSpare_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.spares_order". При необходимости она может быть перемещена или удалена.
            this.spares_orderTableAdapter.Fill(this.autoserviceDataSet.spares_order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoserviceDataSet.spare". При необходимости она может быть перемещена или удалена.
            this.spareTableAdapter.Fill(this.autoserviceDataSet.spare);

            onUpdateUI();
        }

        public void onUpdateUI()
        {
            var spares = from s in autoserviceDataSet.spare
                         where s.count > 0
                         select new
                         {
                             s.id,
                             Деталь = s.mark + " " + s.model,
                             Количество = s.count
                         };

            spareDataGridView.DataSource = spares.ToList();
            spareDataGridView.Columns[0].Visible = false;
            spareDataGridView.AutoResizeColumns();
            spareDataGridView.ClearSelection();
        }

        private int takenSpare = 0;
        private void spareDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            takenSpare = (int)spareDataGridView[0, spareDataGridView.CurrentRow.Index].Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (takenSpare == 0)
            {
                MessageBox.Show("Из списка ничего не выбрано");
            }
            else
            {
                spares_orderTableAdapter.Insert(helpers.Helper.OrderId, takenSpare);
                MessageBox.Show("Успешо выбрано");
                Close();
            }
        }

        private void AddSpare_FormClosing(object sender, FormClosingEventArgs e)
        {
            CurrentOrder forma = (CurrentOrder) helpers.Helper.BackStack;
            forma.onUpdateUI();
            forma.Show();
        }
    }
}
