using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1Animal
{
    public partial class frmAssignment : Form
    {
        public frmAssignment()
        {
            InitializeComponent();
        }
        private PeacockForm frmPeacock = new PeacockForm();
        private DuckFrom frmDuck = new DuckFrom();
        private CrowFrom frmCrow = new CrowFrom();

        private void mnuPeacock_Click(object sender, EventArgs e)
        {
            frmPeacock.MdiParent = this;
            frmPeacock.Show();
            frmPeacock.Activate();
        }

        private void mnuDuck_Click(object sender, EventArgs e)
        {
            frmDuck.MdiParent = this;
            frmDuck.Show();
            frmDuck.Activate();
        }

        private void mnuCrow_Click(object sender, EventArgs e)
        {
            frmCrow.MdiParent = this;
            frmCrow.Show();
            frmCrow.Activate();
        }
    }
}
