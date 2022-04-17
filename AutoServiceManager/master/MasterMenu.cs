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
    public partial class MasterMenu : Form
    {
        public MasterMenu()
        {
            InitializeComponent();
        }

        private void MasterMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            helpers.Helper.Quit();
        }
    }
}
