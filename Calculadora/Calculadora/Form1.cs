using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a;
        double b;
        string c;

        private void Button0_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "")
            {
                txtResultado.Text = "0";
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "")
            {
                txtResultado.Text = "1";
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "")
            {
                txtResultado.Text = "2";
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "")
            {
                txtResultado.Text = "3";
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "")
            {
                txtResultado.Text = "4";
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "")
            {
                txtResultado.Text = "5";
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "")
            {
                txtResultado.Text = "6";
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "")
            {
                txtResultado.Text = "7";
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "")
            {
                txtResultado.Text = "8";
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "")
            {
                txtResultado.Text = "9";
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "9";
            }
        }

        private void botonPor_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txtResultado.Text);
            c = "%";
            this.txtResultado.Text = Convert.ToString(a / 100);
            this.txtResultado.Focus();
        }

        private void botonPunto_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "")
            {
                txtResultado.Text = ".";
            }
            else
            {
                txtResultado.Text = txtResultado.Text + ".";
            }
        }

        private void botonDiv_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txtResultado.Text);
            c = "/";
            this.txtResultado.Clear();
            this.txtResultado.Focus();
        }

        private void botonMult_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txtResultado.Text);
            c = "*";
            this.txtResultado.Clear();
            this.txtResultado.Focus();
        }

        private void botonMas_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txtResultado.Text);
            c = "+";
            this.txtResultado.Clear();
            this.txtResultado.Focus();
        }

        private void botonMenos_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txtResultado.Text);
            c = "-";
            this.txtResultado.Clear();
            this.txtResultado.Focus();
        }

        private void botonCE_Click(object sender, EventArgs e)
        {

            if (txtResultado.Text.Length == 1)
            {
                txtResultado.Text = "";
            }
            else
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble("0");
            b = Convert.ToDouble("0");
            this.txtResultado.Text = "";
        }

        private void botonIgual_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(this.txtResultado.Text);
            switch (c)
            {
                case "+":
                    this.txtResultado.Text = Convert.ToString((b) + (a));
                    break;

                case "-":
                    this.txtResultado.Text = Convert.ToString((b) - (a));
                    break;

                case "*":
                    this.txtResultado.Text = Convert.ToString((b) * (a));
                    break;

                case "/":
                    this.txtResultado.Text = Convert.ToString((b) / (a));
                    break;
            }
        }
    }
}
