using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gas_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mpg = 1;
            int miles = 1;
            decimal gas = 1;

            try
            {
                mpg = Convert.ToInt16(tb_MPG.Text);
                miles = Convert.ToInt16(tb_Miles.Text);
                gas = Convert.ToDecimal(tb_Gas.Text);
            }
            catch
            {
                MessageBox.Show("Enter a valid number");
            }

            decimal price = (miles / mpg) * gas;
            if (cb_trip.Checked)
            {
                price *= 2;
            }

            lbl_result.Text = "$" + Convert.ToString(price);
            lbl_result.Visible = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                button1_Click(sender, e);
            }
        }
    }
}
