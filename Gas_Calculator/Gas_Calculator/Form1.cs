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
            int mpg = 1; //prevents divide by zero
            int miles = 0;
            decimal gas = 0;

            //conversion
            try{
                mpg = Math.Abs(Convert.ToInt16(tb_MPG.Text));
                miles = Math.Abs(Convert.ToInt16(tb_Miles.Text));
                gas = Math.Abs(Convert.ToDecimal(tb_Gas.Text));
            }
            catch{
                //MessageBox.Show("Enter a valid number");
            }

            //math
            decimal price = (miles / mpg) * gas;
            if (cb_trip.Checked){price *= 2;}

            //label
            lbl_result.Text = price.ToString("C");
            if (mpg == 1 || miles == 0 || gas == 0){
                lbl_result.Visible = false;
            } else{
                lbl_result.Visible = true;
            }

            //remove negative from textbox
            if (tb_MPG.Text.Contains('-')){
                tb_MPG.Text = tb_MPG.Text.Remove(0, 1);
            }
            if (tb_Miles.Text.Contains('-')){
                tb_Miles.Text = tb_Miles.Text.Remove(0, 1);
            }
            if(tb_Gas.Text.Contains('-')){
                tb_Gas.Text = tb_Gas.Text.Remove(0, 1);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return){
                button1_Click(sender, e);
            }
        }
    }
}
