using reschanger.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reschanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Info uc = new Info();
            addUserControl(uc);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UC_Presets uc = new UC_Presets();
            addUserControl(uc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UC_Custom uc = new UC_Custom();
            addUserControl(uc);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Info uc = new Info();
            addUserControl(uc);
        }
    }
}
