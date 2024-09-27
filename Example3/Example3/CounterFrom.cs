﻿using System;
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
    public partial class CounterFrom : Form
    {
        public CounterFrom()
        {
            InitializeComponent();
            lblCounter.Text = CounterConfig.count.ToString();
        }

        private void CounterFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            CounterConfig.count++;
            lblCounter.Text = CounterConfig.count.ToString();
            CounterConfig.lblStatus.Text = "Plus";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            CounterConfig.count--;
            lblCounter.Text = CounterConfig.count.ToString();
            CounterConfig.lblStatus.Text = "Minus";

        }

        private void CounterFrom_Enter(object sender, EventArgs e)
        {
            lblCounter.Text = CounterConfig.count.ToString();

        }
    }
}
