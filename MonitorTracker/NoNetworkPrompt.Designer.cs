namespace MonitorTracker
{
    partial class NoNetworkPrompt
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonTry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(22, 78);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(230, 41);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Not connected to the AT&T network.  Please connect to the AT&T network and try ag" +
    "ain.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTry
            // 
            this.buttonTry.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonTry.Location = new System.Drawing.Point(74, 125);
            this.buttonTry.Name = "buttonTry";
            this.buttonTry.Size = new System.Drawing.Size(109, 23);
            this.buttonTry.TabIndex = 1;
            this.buttonTry.Text = "Close Application";
            this.buttonTry.UseVisualStyleBackColor = true;
            this.buttonTry.Click += new System.EventHandler(this.buttonTry_Click);
            // 
            // NoNetworkPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonTry);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoNetworkPrompt";
            this.ShowIcon = false;
            this.Text = "NoNetworkPrompt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonTry;
    }
}