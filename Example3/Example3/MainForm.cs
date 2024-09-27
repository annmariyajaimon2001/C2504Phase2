using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CounterConfig.lblStatus = lblStatus;
        }
        private CounterFrom frmCounter = new CounterFrom();
        private ExtendedCounterFrom frmExtendedCounter = new ExtendedCounterFrom();

        private void mnuSimpleCounter_Click(object sender, EventArgs e)
        {
            //frmCounter.MdiParent = this;
            //frmCounter.Show();
            //frmCounter.Activate();
            CounterConfig.ShowChild(this, frmCounter);
        }

        private void mnuExtendedCounter_Click(object sender, EventArgs e)
        {
            //frmExtendedCounter.MdiParent = this;
            //frmExtendedCounter.Show();
            //frmExtendedCounter.Activate();
            CounterConfig.ShowChild(this, frmExtendedCounter);
        }
    }
}
