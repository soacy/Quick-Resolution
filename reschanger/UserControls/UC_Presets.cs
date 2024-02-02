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
    public partial class UC_Presets : UserControl
    {
        public UC_Presets()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            // 1920 x 1080
            string command = "QRes.exe";
            string arguments = $"/x:1920 /y:1080";
            ExecuteCommand(command, arguments);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 1280 x 1080
            string command = "QRes.exe";
            string arguments = $"/x:1280 /y:1080";
            ExecuteCommand(command, arguments);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1440 x 1080
            string command = "QRes.exe";
            string arguments = $"/x:1440 /y:1080";
            ExecuteCommand(command, arguments);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 1080 x 1080
            string command = "QRes.exe";
            string arguments = $"/x:1080 /y:1080";
            ExecuteCommand(command, arguments);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 2560 x 1440
            string command = "QRes.exe";
            string arguments = $"/x:2560 /y:1440";
            ExecuteCommand(command, arguments);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // 1280 x 720
            string command = "QRes.exe";
            string arguments = $"/x:1280 /y:720";
            ExecuteCommand(command, arguments);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // 854 x 480
            string command = "QRes.exe";
            string arguments = $"/x:854 /y:480";
            ExecuteCommand(command, arguments);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // 1680 x 1050
            string command = "QRes.exe";
            string arguments = $"/x:1680 /y:1050";
            ExecuteCommand(command, arguments);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // 1440 x 900
            string command = "QRes.exe";
            string arguments = $"/x:1440 /y:900";
            ExecuteCommand(command, arguments);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // 800 x 2560
            string command = "QRes.exe";
            string arguments = $"/x:800 /y:2560";
            ExecuteCommand(command, arguments);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // 1620 x 1080
            string command = "QRes.exe";
            string arguments = $"/x:1620 /y:1080";
            ExecuteCommand(command, arguments);
        }
    }
}
