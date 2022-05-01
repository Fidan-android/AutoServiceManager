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
    public partial class AdminMenu : helpers.BaseForm, helpers.IUpdateContract
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void AdminMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            helpers.Helper.Quit();
        }

        private void workerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoserviceDataSet);

        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void configureData()
        {
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
                adminNameLabel.Text = "Админ: " + worker.first_name + " " + worker.middle_name;
            }
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            helpers.Helper.BackStack = this;
            new Clients().Show();
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            helpers.Helper.BackStack = this;
            new Cars().Show();
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            helpers.Helper.BackStack = this;
            new Orders().Show();
        }
    }
}
