using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DECHECK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panels.UserControl1 uc1= new Panels.UserControl1();
            addUserControl(uc1);

        }
       private void addUserControl(UserControl userControl) {
            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panels.UserControl2 uc2 = new Panels.UserControl2();
            addUserControl(uc2);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
          //  button2.BackColor = Color.Red;
        }
    }
}
