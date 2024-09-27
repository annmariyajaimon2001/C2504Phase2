using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Example1Project
{
    /// <summary>
    /// Interaction logic for SquareCalcWindow.xaml
    /// </summary>
    public partial class SquareCalcWindow : Window
    {
        public SquareCalcWindow()
        {
            InitializeComponent();
        }
        private bool IsNum(string numStr)
        {
            try
            {
                int.Parse(numStr);
                return true;
            }
            catch { return false; }
        }

        private void btnSquare_Click(object sender, RoutedEventArgs e)
        {
            if(!IsNum(txtNumber.Text))
            {
                MessageBox.Show("Please enter number");
                txtNumber.Focus();
                txtNumber.SelectAll();
                return; 
            }
            int number = int.Parse(txtNumber.Text);
            int square = number * number;
            txtResult.Text = square.ToString();
            lblResult.Text = "Square";
        }

        private void btnCube_Click(object sender, RoutedEventArgs e)
        {
            if (!IsNum(txtNumber.Text))
            {
                MessageBox.Show("Please enter number");
                txtNumber.Focus();
                txtNumber.SelectAll();
                return; 
            }
            int number = int.Parse(txtNumber.Text);
            int cube = number * number * number;
            txtResult.Text = cube.ToString();
            lblResult.Text = "Cube";
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
