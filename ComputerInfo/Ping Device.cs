using System;
using System.Net;
using System.Windows.Forms;

namespace ComputerInfo
{
    public partial class Ping_Device : Form
    {
        public Ping_Device()
        {
            InitializeComponent();
        }
        //public Form1 form = new Form1();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PingDevice_Click(object sender, EventArgs e)
        {
            try
            {
                string info = this.TypedDevice.Text;

                IPAddress address = IPAddress.Parse(info);

                NetworkControls.buttonFunctions.PingTest(address);

                this.Close();
            }
            catch (Exception error)
            {
                NetworkControls.buttonFunctions.Debugging(error.ToString());

                this.Close();
            }
        }

        private void Ping_Device_Load(object sender, EventArgs e)
        {

        }
    }
}
