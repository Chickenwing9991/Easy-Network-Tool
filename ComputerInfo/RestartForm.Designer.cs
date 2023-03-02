namespace ComputerInfo
{
    partial class RestartForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.RestartYes = new System.Windows.Forms.Button();
            this.RestartNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restart Needed to Take Effect";
            // 
            // RestartYes
            // 
            this.RestartYes.Location = new System.Drawing.Point(12, 25);
            this.RestartYes.Name = "RestartYes";
            this.RestartYes.Size = new System.Drawing.Size(91, 23);
            this.RestartYes.TabIndex = 1;
            this.RestartYes.Text = "Restart Now";
            this.RestartYes.UseVisualStyleBackColor = true;
            this.RestartYes.Click += new System.EventHandler(this.RestartYes_Click);
            // 
            // RestartNo
            // 
            this.RestartNo.Location = new System.Drawing.Point(144, 25);
            this.RestartNo.Name = "RestartNo";
            this.RestartNo.Size = new System.Drawing.Size(91, 23);
            this.RestartNo.TabIndex = 3;
            this.RestartNo.Text = "Restart Later";
            this.RestartNo.UseVisualStyleBackColor = true;
            this.RestartNo.Click += new System.EventHandler(this.RestartNo_Click);
            // 
            // RestartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 55);
            this.Controls.Add(this.RestartNo);
            this.Controls.Add(this.RestartYes);
            this.Controls.Add(this.label1);
            this.Name = "RestartForm";
            this.Text = "Restart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RestartYes;
        private System.Windows.Forms.Button RestartNo;
    }
}