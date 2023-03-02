namespace ComputerInfo
{
    partial class NetworkControls
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetworkControls));
            this.RenewIP = new System.Windows.Forms.Button();
            this.InfoBox = new System.Windows.Forms.RichTextBox();
            this.NetworkInfo = new System.Windows.Forms.Button();
            this.NetworkAdapters = new System.Windows.Forms.ListBox();
            this.TestConnection = new System.Windows.Forms.Button();
            this.RestartAdapter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RandStatic = new System.Windows.Forms.Button();
            this.PingTest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ResetNetwork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RenewIP
            // 
            this.RenewIP.Location = new System.Drawing.Point(12, 22);
            this.RenewIP.Name = "RenewIP";
            this.RenewIP.Size = new System.Drawing.Size(209, 23);
            this.RenewIP.TabIndex = 0;
            this.RenewIP.Text = "Refresh All IP Addresses";
            this.RenewIP.UseVisualStyleBackColor = true;
            this.RenewIP.Click += new System.EventHandler(this.button1_Click);
            // 
            // InfoBox
            // 
            this.InfoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoBox.Location = new System.Drawing.Point(12, 227);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(448, 211);
            this.InfoBox.TabIndex = 1;
            this.InfoBox.Text = "";
            // 
            // NetworkInfo
            // 
            this.NetworkInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NetworkInfo.Location = new System.Drawing.Point(244, 140);
            this.NetworkInfo.Name = "NetworkInfo";
            this.NetworkInfo.Size = new System.Drawing.Size(216, 23);
            this.NetworkInfo.TabIndex = 2;
            this.NetworkInfo.Text = "Get Network Adapters";
            this.NetworkInfo.UseVisualStyleBackColor = true;
            this.NetworkInfo.Click += new System.EventHandler(this.NetworkInfo_Click);
            // 
            // NetworkAdapters
            // 
            this.NetworkAdapters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NetworkAdapters.FormattingEnabled = true;
            this.NetworkAdapters.Location = new System.Drawing.Point(244, 22);
            this.NetworkAdapters.Name = "NetworkAdapters";
            this.NetworkAdapters.Size = new System.Drawing.Size(216, 108);
            this.NetworkAdapters.TabIndex = 3;
            this.NetworkAdapters.SelectedIndexChanged += new System.EventHandler(this.NetworkAdapters_SelectedIndexChanged);
            // 
            // TestConnection
            // 
            this.TestConnection.Location = new System.Drawing.Point(12, 80);
            this.TestConnection.Name = "TestConnection";
            this.TestConnection.Size = new System.Drawing.Size(209, 23);
            this.TestConnection.TabIndex = 6;
            this.TestConnection.Text = "Test Internet Connection";
            this.TestConnection.UseVisualStyleBackColor = true;
            this.TestConnection.Click += new System.EventHandler(this.TestConnection_Click);
            // 
            // RestartAdapter
            // 
            this.RestartAdapter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestartAdapter.Location = new System.Drawing.Point(244, 169);
            this.RestartAdapter.Name = "RestartAdapter";
            this.RestartAdapter.Size = new System.Drawing.Size(216, 23);
            this.RestartAdapter.TabIndex = 7;
            this.RestartAdapter.Text = "Restart Adapter";
            this.RestartAdapter.UseVisualStyleBackColor = true;
            this.RestartAdapter.Click += new System.EventHandler(this.RestartAdapter_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Network Adapters";
            // 
            // RandStatic
            // 
            this.RandStatic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RandStatic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RandStatic.Location = new System.Drawing.Point(244, 198);
            this.RandStatic.Name = "RandStatic";
            this.RandStatic.Size = new System.Drawing.Size(216, 23);
            this.RandStatic.TabIndex = 9;
            this.RandStatic.Text = "Set Random Static IP";
            this.RandStatic.UseVisualStyleBackColor = true;
            this.RandStatic.Click += new System.EventHandler(this.RandStatic_Click);
            // 
            // PingTest
            // 
            this.PingTest.Location = new System.Drawing.Point(12, 109);
            this.PingTest.Name = "PingTest";
            this.PingTest.Size = new System.Drawing.Size(209, 23);
            this.PingTest.TabIndex = 10;
            this.PingTest.Text = "Ping Device";
            this.PingTest.UseVisualStyleBackColor = true;
            this.PingTest.Click += new System.EventHandler(this.PingTest_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Troubleshooting Tools";
            // 
            // ResetNetwork
            // 
            this.ResetNetwork.Location = new System.Drawing.Point(12, 51);
            this.ResetNetwork.Name = "ResetNetwork";
            this.ResetNetwork.Size = new System.Drawing.Size(209, 23);
            this.ResetNetwork.TabIndex = 12;
            this.ResetNetwork.Text = "Reset Network Settings";
            this.ResetNetwork.UseVisualStyleBackColor = true;
            this.ResetNetwork.Click += new System.EventHandler(this.ResetNetwork_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.ResetNetwork);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PingTest);
            this.Controls.Add(this.RandStatic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RestartAdapter);
            this.Controls.Add(this.TestConnection);
            this.Controls.Add(this.NetworkAdapters);
            this.Controls.Add(this.NetworkInfo);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.RenewIP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Network Controls";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.RichTextBox InfoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button RenewIP;
        public System.Windows.Forms.Button NetworkInfo;
        public System.Windows.Forms.ListBox NetworkAdapters;
        public System.Windows.Forms.Button TestConnection;
        public System.Windows.Forms.Button RestartAdapter;
        public System.Windows.Forms.Button RandStatic;
        public System.Windows.Forms.Button PingTest;
        public System.Windows.Forms.Button ResetNetwork;
    }
}

