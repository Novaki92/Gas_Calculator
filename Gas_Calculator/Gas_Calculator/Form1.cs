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
            int mpg = Convert.ToInt16(tb_MPG.Text);
            int miles = Convert.ToInt16(tb_Miles.Text);
            decimal gas = Convert.ToDecimal(tb_Gas.Text);

            decimal price = (miles / mpg) * gas;

            lbl_result.Text = "$" + Convert.ToString(price);
            lbl_result.Visible = true;
        }
    }
}
