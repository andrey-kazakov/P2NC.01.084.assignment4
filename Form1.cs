using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment4_AndreiKazakov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label2.Text = "";
            }
            else
            {
                label2.Text = "ERROR";
            }

            ulong input;

            if (ulong.TryParse(textBox1.Text, out input))
            {
                if (input > 20) // 21! is more than 18,446,744,073,709,551,615 (max value for ulong)
                {
                    label2.Text = "OVERFLOW";
                }
                else if (input >= 0)
                {
                    label2.Text = factorial(input).ToString("N0");
                }
            }
        }

        private ulong factorial(ulong input)
        {
            ulong result = 1;

            while (input > 0)
            {
                result *= input;
                input--;
            }

            return result;
        }
    }
}
