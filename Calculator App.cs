using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Design
{
    public partial class n : Form
    {
        Double resultValue = 0;
        String opPerformed = "";
        bool isopPerformed = false;
        public n()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void n_click(object sender, EventArgs e)
        {
            if ((textBox.Text == "0") || (isopPerformed))
                textBox.Clear();

            isopPerformed = false;
            Button n = (Button) sender;
            if(n.Text == ".")
            {
                if(!textBox.Text.Contains("."))
                    textBox.Text = textBox.Text + n.Text;
            }
            else
            textBox.Text = textBox.Text + n.Text;
            
                }

        private void op_click(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            if (resultValue != 0)
            {
                nequal.PerformClick();
                opPerformed = n.Text;

                Lcurrentop.Text = resultValue + "" + opPerformed;
                isopPerformed = true;
            }
            else
            {
                opPerformed = n.Text;
                resultValue = Double.Parse(textBox.Text);
                Lcurrentop.Text = resultValue + "" + opPerformed;
                isopPerformed = true;
            }
        }

            private void op_click(object sender, UICuesEventArgs e)
            {

            } 

        private void nce_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";        }

        private void nc_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            resultValue = 0;
        }

        private void nequal_Click(object sender, EventArgs e)
        {
            switch(opPerformed)
                {
                case "+":
                    textBox.Text = (resultValue + Double.Parse(textBox.Text)).ToString();
                    break;
                case "-":
                    textBox.Text = (resultValue - Double.Parse(textBox.Text)).ToString();
                    break;
                case "*":
                    textBox.Text = (resultValue * Double.Parse(textBox.Text)).ToString();
                    break;
                case "/":
                    textBox.Text = (resultValue / Double.Parse(textBox.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textBox.Text);
            Lcurrentop.Text = "";
        }
    }
}
