using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Sockets;
using System;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComputerInfo
{
    public class ButtonFunctions
    {
        private NetworkControls form1;

        public ButtonFunctions(NetworkControls form1)
        {
            this.form1 = form1;
        }

        //Declares Global Variable for current Selected Network Adapter
        public static string selectedInterface { get; set; }

        public void GetNewIPaddress()
        {
            //Locks UI
            LockUI(true, true);

            form1.InfoBox.AppendText("Releasing IP");

            var process = Process.Start(new ProcessStartInfo("ipconfig", "/release") { CreateNoWindow = true, UseShellExecute = false });

            while (process.HasExited == false)
            {
                Thread.Sleep(5);
            }

            form1.InfoBox.AppendText(System.Environment.NewLine + "IP has been Released");
            form1.InfoBox.AppendText(System.Environment.NewLine + "Getting New IP address");

            var process2 = Process.Start(new ProcessStartInfo("ipconfig", "/renew") { CreateNoWindow = true, UseShellExecute = false });

            while (process2.HasExited == false)
            {
                Thread.Sleep(5);
            }

            //Prints to Console
            form1.InfoBox.AppendText(System.Environment.NewLine + "IP Address has Been Renewed");

            //Release UI
            LockUI(false, false);
        }

        //Gets All Nework Adapters Info 
        public void GetNetworkInfo()
        {
            form1.InfoBox.Clear();
            form1.NetworkAdapters.Items.Clear();

            foreach (NetworkInterface netif in NetworkInterface.GetAllNetworkInterfaces())
            {

                form1.NetworkAdapters.Items.Add(netif.Name);
                IPInterfaceProperties properties = netif.GetIPProperties();
                if (string.IsNullOrEmpty(form1.InfoBox.Text))
                {
                    form1.InfoBox.AppendText("Adapter Name: " + netif.Name);
                }
                else
                {
                    form1.InfoBox.AppendText(System.Environment.NewLine + "Adapter Name: " + netif.Name);
                }

                foreach (IPAddressInformation ip in properties.UnicastAddresses)
                {
                    if (ip.Address.AddressFamily == AddressFamily.InterNetworkV6)
                    {
                        form1.InfoBox.AppendText(System.Environment.NewLine + "Ipv6 Address: " + ip.Address);
                    }
                    if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        form1.InfoBox.AppendText(System.Environment.NewLine + "Ipv4 Address: " + ip.Address);
                    }

                }

                foreach (IPAddress gate in properties.DhcpServerAddresses)
                {
                    form1.InfoBox.AppendText(System.Environment.NewLine + "Gateway: " + gate);
                }
                form1.InfoBox.AppendText(System.Environment.NewLine + "Status: " + netif.OperationalStatus);
                form1.InfoBox.AppendText(System.Environment.NewLine);

            }

        }

        //Gets the Info of the Currently Selected Network Adapter
        public string GetAdapterInfo()
        {
            //Declare Variable outside scope to Return
            string AdapterIP = String.Empty;

            //Checks if Network Adapter is Selected
            if (selectedInterface == null)
            {
                NoAdapterSelected();
            }
            else
            {
                foreach (NetworkInterface netif in NetworkInterface.GetAllNetworkInterfaces())
                {
                    IPInterfaceProperties properties = netif.GetIPProperties();

                    if (selectedInterface == netif.Name)
                    {
                        foreach (IPAddressInformation ip in properties.UnicastAddresses)
                        {
                            if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                            {
                                AdapterIP = ip.Address.ToString();

                            }
                        }
                    }
                }
            }
            return AdapterIP;
        }

        //Function Unused at the Moment
        //Sends Command to Disable Specified Adapter
        public void DisableAdapter()
        {
            //Locks UI
            LockUI(true, true);

            //Grabs the Currently Selected Network Adapter
            //string selectedInterface = form1.NetworkAdapters.SelectedItem.ToString();

            //Starts Windows Command
            var process2 = Process.Start(new ProcessStartInfo("netsh", "interface set interface \"" + selectedInterface + "\" disable") { CreateNoWindow = true, UseShellExecute = false });

            //Notification for Users to see that the Adapter is being Disabled
            form1.InfoBox.AppendText("Disabling Network Adapter " + selectedInterface);

            //Waits till Command has been Completed(Need to Rethink.....More Threading???)
            while (process2.HasExited == false)
            {
                Thread.Sleep(5);
            }
            //Appends Results to UI Result Text Box
            form1.InfoBox.AppendText(System.Environment.NewLine + "Network Adapter " + selectedInterface + " Disabled");

            //Releases UI
            LockUI(false, false);
        }

        //Function Unused at the Moment
        //Sends Command to Enable Specified Adapter
        public void EnableAdapter()
        {
            //Locks UI
            LockUI(true, true);

            //Starts Windows Command
            var process2 = Process.Start(new ProcessStartInfo("netsh", "interface set interface \"" + selectedInterface + "\" enable") { CreateNoWindow = true, UseShellExecute = false });

            //Notification for Users to see that the Adapter is being Disabled
            form1.InfoBox.AppendText("Enabling Network Adapter " + selectedInterface);

            //Waits till Command has been Completed(Need to Rethink.....More Threading???)
            while (process2.HasExited == false)
            {
                Thread.Sleep(5);
            }

            //Appends Results to UI Result Text Box
            form1.InfoBox.AppendText(System.Environment.NewLine + "Network Adapter " + selectedInterface + " Enabled");

            //Releases UI
            LockUI(false, false);
        }

        //Restart the Selected Network Adapter
        public void RestartAdapter()
        {
            //Locks UI
            LockUI(true, true);

            //Grabs the Currently Selected Network Adapter
            if (form1.NetworkAdapters.SelectedItem == null)
            {
                NoAdapterSelected();
            }
            else
            {
                //string selectedInterface = form1.NetworkAdapters.SelectedItem.ToString();
                //Disables Network Adapter
                var disable = Process.Start(new ProcessStartInfo("netsh", "interface set interface \"" + selectedInterface + "\" disable") { CreateNoWindow = true, UseShellExecute = false });
                form1.InfoBox.AppendText("Restarting Network Adapter " + selectedInterface);
                while (disable.HasExited == false)
                {
                    Thread.Sleep(5);
                }

                //Enables Network Adapter
                var enable = Process.Start(new ProcessStartInfo("netsh", "interface set interface \"" + selectedInterface + "\" enable") { CreateNoWindow = true, UseShellExecute = false });
                while (enable.HasExited == false)
                {
                    Thread.Sleep(5);
                }
                form1.InfoBox.AppendText(System.Environment.NewLine + "Network Adapter " + selectedInterface + " Restarted");
                
            }

            //Release UI
            LockUI(false, false);
        }

        //Pings Google to Judge if Internet connection is Functioning
        public void TestConnection()
        {
            //Locks UI
            LockUI(true, true);

            //Try Catch Block Incase Ping Fails
            try
            {
                Uri uri = new Uri("https://www.google.com");
                var ping = new Ping();
                PingReply result = ping.Send(uri.Host);

                if (result.Status == IPStatus.Success)
                {
                    form1.InfoBox.AppendText("Connection Test was Successful");
                }
            }
            catch
            {
                MessageBox.Show("Unable to Ping for Unknow Reason");
            }

            //Releases UI
            LockUI(false, false);
        }

        /*Gets Specified Network Adapter IPV4 Address
        Uses IPV4 address to get a Valid Range of IP Addresses to Ping
        Pings all the Addresses
        Puts Addresses that dont Respond into List of Possible Unused Addresses*/
        public async Task<List<string>> GetRandomIP()
        {
            LockUI(true, true);

            //List of Possible Unused Ip Addresses
            List<string> PossibleUnusedAddress = new List<string>();

            //Gets a Vaild IP Address Object
            IPNetwork iPNetwork = IPNetwork.Parse(GetAdapterInfo());

            //Gets the Number of Usable IP addresses in Subnet 
            BigInteger IPCount = iPNetwork.Usable;

            //Grabs the First Usable IP Address(Ususally the Gateway Address)
            string FirstAddress = iPNetwork.FirstUsable.ToString();

            //Creates a List of Pingable Addresses
            List<string> PingableAddresses = new List<string>();
            for (int i = 0; i < IPCount;)
            {
                string newAddress = FirstAddress.Remove(FirstAddress.LastIndexOf('.'));
                PingableAddresses.Add(newAddress + "." + i);
                i++;
            }

            //Declaring Task here so I can wait till it is finished out side of the Task
            Task task = null;

            /*Pings every IP Address in PingableAddresses
             * If IP address doesnt Return a Response
             * Its assumed that it is not being used
             * We are also creating a new Thread for Every IP Address that needs to be Pinged(Improves Speed)*/
            foreach (string address in PingableAddresses)
            {
                task = Task.Run(() =>
                {

                    IPAddress iP = IPAddress.Parse(address);
                    Ping ping = new Ping();
                    PingReply result = ping.Send(iP, 100);

                    if (result.Status != 0)
                    {
                        //Adds IP Address to List
                        PossibleUnusedAddress.Add(address);

                        //Invoking Here to Update UI(Possibly Need to change in Future)
                        //Needed to Update Console Cross Thread
                        form1.InfoBox.Invoke((MethodInvoker)(() =>
                        {
                            //Prints to Console
                            form1.InfoBox.AppendText(Environment.NewLine + address + " Added to List");
                            form1.InfoBox.ScrollToCaret();
                        }));
                    }

                });
            }
            //Waits till All IP Addresses have been Pinged
            await Task.WhenAll(task);

            //Releases UI
            LockUI(false, false);

            //Returns List of Possible Unused IP Addresses
            return PossibleUnusedAddress;
        }

        public async Task AssignRandomIPAsync()
        {
            //Checks if Network Adapter has been Selected
            if (form1.NetworkAdapters.SelectedItem == null)
            {
                //Message Box Function
                NoAdapterSelected();
            }
            else
            {
                //Awaiting the Results from Function
                var results = await this.GetRandomIP();

                //Getting new Random Class object
                Random rnd = new Random();

                //
                int index = rnd.Next(results.Count);
                string PickedIP = results[index];

                form1.InfoBox.AppendText("Running Commands");

                //Windows Commands
                //Will Multi Thread Windows Commands in Future for Speed and Async Capabilites
                var setIPAddress = Process.Start(new ProcessStartInfo("netsh", "interface ipv4 set address name=" + selectedInterface + " static " + PickedIP + " 255.255.255.0 192.168.0.1") { CreateNoWindow = true, UseShellExecute = false });
                var setPrimaryDNS = Process.Start(new ProcessStartInfo("netsh", "interface ip set dns name=" + selectedInterface + " static 8.8.8.8") { CreateNoWindow = true, UseShellExecute = false });
                var setSecondaryDNS = Process.Start(new ProcessStartInfo("netsh", "interface ip add dns name=" + selectedInterface + "4.2.2.4 index=2") { CreateNoWindow = true, UseShellExecute = false });

                //Used to wait till all Commands are Complete
                //Will be Removed when Windows Commands are Multi Threaded
                while (setIPAddress.HasExited == false || setPrimaryDNS.HasExited == false || setSecondaryDNS.HasExited == false)
                {
                    Thread.Sleep(5);
                }

                //Prints to Console
                form1.InfoBox.AppendText(System.Environment.NewLine + "Network Adapter " + selectedInterface + " Has been assign IP address:" + PickedIP);
                form1.InfoBox.ScrollToCaret();
            }
        }

        //User Inputs IP Address Returns Ping Results
        public void PingTest(IPAddress Ip)
        {
            //Locks UI
            LockUI(true, true);

            //Declare new Ping Class Object
            Ping ping = new Ping();

            //For Loop Configured to Ping Destination 4 Times
            for(int i = 0; i <= 4; i++)
            {
                //Sends Ping
                PingReply result = ping.Send(Ip);

                //Print out Responses to Console
                form1.InfoBox.AppendText("Reply from: " + Ip + " Time: " + result.RoundtripTime + "ms" + " Status: " + result.Status);
                form1.InfoBox.AppendText(System.Environment.NewLine);
            }

            //Releases UI
            LockUI(false, false);
        }

        //Locks UI and Clears Console
        public void LockUI(bool locked, bool clear)
        {
            if (locked == true & clear == true)
            {
                form1.InfoBox.Clear();
                UIControls.DisableControls(locked);
            }
            else if (locked == true & clear == false)
            {
                UIControls.DisableControls(locked);
            }
            else if (locked == false & clear == true)
            {
                form1.InfoBox.Clear();
            }
            else if (locked == false & clear == false)
            {
                UIControls.DisableControls(locked);
            }
        }

        //Debug Function
        public void Debugging(string Error)
        {
            form1.InfoBox.AppendText(Error);
        }

        //Uses the Winsock Reset Command to Reset Network Settings
        public void ResetNetwork()
        {
            //Locks UI
            LockUI(true, true);

            //Declares New Instance of RestartForm
            RestartForm restartForm = new RestartForm();

            //Prints to Console
            form1.InfoBox.AppendText("Resetting Network Settings");

            //Windows Command
            //Will Multi Thread
            var setSecondaryDNS = Process.Start(new ProcessStartInfo("netsh", "winsock reset") { CreateNoWindow = true, UseShellExecute = false });

            //Waits till Windows Command is Finished
            //Will Redo once Window Commands are Multi Threaded
            while (setSecondaryDNS.HasExited == false)
            {
                Thread.Sleep(5);
            }

            //Prints to Console
            form1.InfoBox.AppendText(System.Environment.NewLine+"Network Settings have been Reset");

            //Opens RestartForm using Show Dialog to Force User to Close Form
            restartForm.ShowDialog();

            //Releases UI
            LockUI(false, false);
        }

        //Message to Pick Network Adapter
        public void NoAdapterSelected()
        {
            MessageBox.Show("Please Select a Network Adapter");
        }
    }
}
