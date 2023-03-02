using System;
using System.Windows.Forms;
namespace ComputerInfo
{
    public partial class NetworkControls : Form
    {
        public static ButtonFunctions buttonFunctions;
        public static NetworkControls formInstance;
        public NetworkControls()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            buttonFunctions.GetNewIPaddress();
        
        }

        private void NetworkInfo_Click(object sender, EventArgs e)
        {
            buttonFunctions.GetNetworkInfo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ButtonFunctions class1 = new ButtonFunctions(this);
            buttonFunctions = class1;
            formInstance = this;
        }

        private void DisableAdapter_Click(object sender, EventArgs e)
        {
            buttonFunctions.DisableAdapter();
        }

        private void EnableAdapter_Click(object sender, EventArgs e)
        {
            buttonFunctions.EnableAdapter();
        }

        private void RestartAdapter_Click(object sender, EventArgs e)
        {
            buttonFunctions.RestartAdapter();
        }

        public void TestConnection_Click(object sender, EventArgs e)
        {
            buttonFunctions.TestConnection();
        }

        private async void RandStatic_Click(object sender, EventArgs e)
        {
            await buttonFunctions.AssignRandomIPAsync();
        }

        private void PingTest_Click(object sender, EventArgs e)
        {
            var form = new Ping_Device();

            if (form.Visible == false)
            {
                form.ShowDialog(this);
            }
        }

        private void ResetNetwork_Click(object sender, EventArgs e)
        {
            buttonFunctions.ResetNetwork();
        }

        private void NetworkAdapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonFunctions.selectedInterface = formInstance.NetworkAdapters.SelectedItem.ToString();
        }
    }
}
