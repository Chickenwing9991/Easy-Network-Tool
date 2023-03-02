using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ComputerInfo
{
    public class UIControls
    {
        public static void DisableControls(bool Enabled)
        {
            var NetworkControls = ComputerInfo.NetworkControls.formInstance;

            if (Enabled == false)
            {
                NetworkControls.RenewIP.Enabled = true;
                NetworkControls.NetworkInfo.Enabled = true;
                NetworkControls.RestartAdapter.Enabled = true;
                NetworkControls.TestConnection.Enabled = true;
                NetworkControls.RandStatic.Enabled = true;
                NetworkControls.PingTest.Enabled = true;
                NetworkControls.ResetNetwork.Enabled = true;
            }
            else
            {
                NetworkControls.RenewIP.Enabled = false;
                NetworkControls.NetworkInfo.Enabled = false;
                NetworkControls.RestartAdapter.Enabled = false;
                NetworkControls.TestConnection.Enabled = false;
                NetworkControls.RandStatic.Enabled = false;
                NetworkControls.PingTest.Enabled = false;
                NetworkControls.ResetNetwork.Enabled = false;
            }

        }

        

    }
}
