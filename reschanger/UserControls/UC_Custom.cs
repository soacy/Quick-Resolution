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

namespace reschanger.UserControls
{
    public partial class UC_Custom : UserControl
    {
        public UC_Custom()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 9999;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2.Maximum = 9999;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(numericUpDown1.Text) || string.IsNullOrWhiteSpace(numericUpDown1.Text))
            && (string.IsNullOrEmpty(numericUpDown2.Text) || string.IsNullOrWhiteSpace(numericUpDown2.Text)))
            {
                MessageBox.Show("Please enter a valid X-Resolution and/or Y-Resolution.");
            }
            else
            {
                string command = "QRes.exe";
                string arguments = $"/x:{numericUpDown1.Value} /y:{numericUpDown2.Value}";
                ExecuteCommand(command, arguments);
            }
        }

        private void ExecuteCommand(string command, string arguments)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();

            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = $"/C {command} {arguments}";

            process.StartInfo = startInfo;
            process.Start();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
