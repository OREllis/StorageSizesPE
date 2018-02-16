using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageSizesPE
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        StorageSizes SS = new StorageSizes();

        private void btnAdd_Click(object sender, EventArgs e) {
            SS.addMB(txtMBin.Text);

            lstOut.DataSource = null;
            lstOut.DataSource = SS.allMBs;

            changeLabels();
        }

        private void changeLabels() {
            lblListNo.Text = "No. of entries: " + SS.allMBs.Count();
            lblMaxNo.Text = "Largest Entry: " + SS.maxList() + "MB";
            lblMinNo.Text = "Smallest Entry: " + SS.minList() + "MB";
            lblAvgNo.Text = "Average of Entries: " + SS.avgList().ToString("#.##") + "MB";
            lblSum.Text = "Sum of Entries: " + SS.totalList() + "MB";
        }

        private void btnSort_Click(object sender, EventArgs e) {
            lstSorted.DataSource = null;
            lstSorted.DataSource = SS.sortMBs();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     
    }
}
