using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ComputerInfo
{
    public partial class RestartForm : Form
    {
        public RestartForm()
        {
            InitializeComponent();
        }

        private void RestartYes_Click(object sender, EventArgs e)
        {
            
            var setSecondaryDNS = Process.Start(new ProcessStartInfo("cmd", "/C shutdown -f -r") { CreateNoWindow = true, UseShellExecute = false });
        }

        private void RestartNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
