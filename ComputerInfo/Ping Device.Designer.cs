namespace ComputerInfo
{
    partial class Ping_Device
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ping_Device));
            this.TypedDevice = new System.Windows.Forms.TextBox();
            this.PingDevice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TypedDevice
            // 
            this.TypedDevice.Location = new System.Drawing.Point(12, 21);
            this.TypedDevice.Name = "TypedDevice";
            this.TypedDevice.Size = new System.Drawing.Size(209, 20);
            this.TypedDevice.TabIndex = 0;
            this.TypedDevice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PingDevice
            // 
            this.PingDevice.Location = new System.Drawing.Point(12, 47);
            this.PingDevice.Name = "PingDevice";
            this.PingDevice.Size = new System.Drawing.Size(209, 23);
            this.PingDevice.TabIndex = 1;
            this.PingDevice.Text = "Submit";
            this.PingDevice.UseVisualStyleBackColor = true;
            this.PingDevice.Click += new System.EventHandler(this.PingDevice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hostname/IP Address";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Ping_Device
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 84);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PingDevice);
            this.Controls.Add(this.TypedDevice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ping_Device";
            this.Text = "Ping_Device";
            this.Load += new System.EventHandler(this.Ping_Device_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TypedDevice;
        private System.Windows.Forms.Button PingDevice;
        private System.Windows.Forms.Label label1;
    }
}