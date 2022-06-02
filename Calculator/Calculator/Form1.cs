using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double a,b;
        int def;
        int ded;
        
        public Form1()
        {
            InitializeComponent();
        }

        
        

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void инженерныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 897;
            this.Height = 443;
            this.Text = "Режим инженерный";
            panel1.Visible = true;
            panel1.Dock = DockStyle.Left;
            panel1.Dock = DockStyle.Right;
            panel3.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);

            textBox1.Clear();
            def = 1;
            label1.Text = a.ToString() + "x";

        } 

        private void button17_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);

            textBox1.Clear();
            def = 2;
            label1.Text = a.ToString() + "+";
            
        }

        private void button16_Click(object sender, EventArgs e)
        {

            a = double.Parse(textBox1.Text);

            textBox1.Clear();
            def = 3;
            label1.Text = a.ToString() + "-";

        }

        private void обычныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 330;
            this.Height = 430;
            this.Text = "Режим обычный";
            panel3.Visible = true;
            
            panel1.Visible = false;
            
        }

       

        private void прогаммистToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 780;
            this.Height = 440;
            this.Text = "Режим программист";

            panel3.Visible = true;
            panel1.Visible = false;
            
            panel3.Dock = DockStyle.Right;
           
            
        }

        private void button12_Click(object sender, EventArgs e)
        {

            a = Convert.ToDouble(textBox1.Text);

            
            b = a * (double.Parse(textBox1.Text)/ 100);
           
            textBox1.Text = b.ToString();
            
        }

        
        private void ch()
        { 
           switch (def)
           {
                case 1:
                    {
                        b = a * double.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                        break;
                    }
                case 2:
                    {
                        b = a + double.Parse(textBox1.Text);
                        textBox1.Text = Convert.ToString(b);
                        break;
                    }
                case 3:
                    {
                        b = a - double.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                        break;
                    }
                case 4:
                    {
                        b = a / double.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                        break;
                    }
           }

        }

        private void Check()
        {
            switch (ded)
            {
                case 1:
                    {
                        b = Math.Pow(a, 2);
                        textBox1.Text = b.ToString();
                        break;
                    }
                case 2:
                    {
                        b = Math.Pow(a, 3);
                        textBox1.Text = b.ToString();
                        break;
                    }
                case 3:
                    {
                        b = Math.Pow(a, double.Parse(textBox1.Text));
                        textBox1.Text = b.ToString();
                        break;
                    }
                case 4:
                    {
                        b = Math.Exp(double.Parse(textBox1.Text));
                        textBox1.Text = b.ToString();
                        break;
                    }
                case 5:
                    {
                        b = Math.Pow(10, a);
                        textBox1.Text = b.ToString();
                        break;
                    }
                case 6:
                    {
                        b = Math.Sqrt(a);
                        textBox1.Text = b.ToString();
                        break;
                    }
                case 7:
                    {
                        a = 1;
                        for (int i = 1; i <= a; i++)
                        {
                            b *= i;
                        }
                        textBox1.Text = b.ToString();
                        break;
                    }
                case 8:
                    {
                        b = Math.Log(a);
                        break;
                    }
                case 9:
                    {
                        b = Math.Log10(a);
                        break;
                    }
                case 10:
                    {
                        b = Math.Sin(a * 3.14159265359 / 180);
                        break;

                    }
                case 11:
                    {
                        b = 1 / double.Parse(textBox1.Text);
                        break;

                    }
                case 12:
                    {
                        b = Math.E;
                        break;

                    }
                case 13:
                    {
                        b = a % double.Parse(textBox1.Text);
                        break;

                    }
                case 14:
                    {
                        b = Math.Sinh(a * 3.14159265359 / 180);
                        break;

                    }


            }
        }
            private void button18_Click(object sender, EventArgs e)
            {
            ch();
            Check();
            label1.Text = "";
            }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);

            

            ded = 1;
            label1.Text = a.ToString() + "^2";

        }

        private void button35_Click(object sender, EventArgs e)
        {
           
            textBox1.Text += "(";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            
            textBox1.Text += ")";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();

            ded = 2;
            label1.Text = a.ToString() + "^3";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
           

            ded = 3;
            label1.Text = a.ToString() + "^y";

        }

        private void button33_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
           
            ded = 4;
            label1.Text = a.ToString() + "e^";

        }

        private void button30_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            

            ded = 5;
            label1.Text = a.ToString() + "10^";

        }

        private void button25_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            ded = 6;
            label1.Text = a.ToString() + "√";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            ded = 7;
            label1.Text = a.ToString() + "n!";

        }

        private void button44_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);

            textBox1.Clear();
            ded = 8;
            label1.Text = a.ToString() + "log";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);

            textBox1.Clear();
            ded = 11;
            label1.Text = a.ToString() + "1/x";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);

            textBox1.Clear();
            def = 9;
            label1.Text = a.ToString() + "ln";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);

            textBox1.Clear();
            def = 10;
            label1.Text = a.ToString() + "sin";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);

            textBox1.Clear();
            def = 12;
            label1.Text = a.ToString() + "e";


        }

        private void button37_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);

            textBox1.Clear();
            ded = 13;
            label1.Text = a.ToString() + "mod";
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);

            textBox1.Clear();
            def = 14;
            label1.Text = a.ToString() + "sinh";
        }

        private void button14_Click(object sender, EventArgs e)
        {

            a = double.Parse(textBox1.Text);

            textBox1.Clear();
            def = 4;
            label1.Text = a.ToString() + "/";


        }
   
       
    }

}
