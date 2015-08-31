namespace MonitorTracker
{
    partial class Form1
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
            this.textOldSerial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFetching = new System.Windows.Forms.Label();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textNewSerial = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkPc = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSeen = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textOldSerial
            // 
            this.textOldSerial.Location = new System.Drawing.Point(168, 29);
            this.textOldSerial.Name = "textOldSerial";
            this.textOldSerial.Size = new System.Drawing.Size(214, 20);
            this.textOldSerial.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monitor Serial# ";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(389, 29);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.labelFetching);
            this.panel1.Controls.Add(this.buttonCopy);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textNewSerial);
            this.panel1.Location = new System.Drawing.Point(27, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 132);
            this.panel1.TabIndex = 3;
            // 
            // labelFetching
            // 
            this.labelFetching.AutoSize = true;
            this.labelFetching.Location = new System.Drawing.Point(33, 93);
            this.labelFetching.Name = "labelFetching";
            this.labelFetching.Size = new System.Drawing.Size(0, 13);
            this.labelFetching.TabIndex = 5;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(381, 93);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(104, 23);
            this.buttonCopy.TabIndex = 2;
            this.buttonCopy.Text = "Copy to Clipboard";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modified Serial#";
            // 
            // textNewSerial
            // 
            this.textNewSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNewSerial.Location = new System.Drawing.Point(33, 42);
            this.textNewSerial.Name = "textNewSerial";
            this.textNewSerial.Size = new System.Drawing.Size(452, 44);
            this.textNewSerial.TabIndex = 0;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(168, 14);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 4;
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Most likely connected to:";
            // 
            // linkPc
            // 
            this.linkPc.AutoSize = true;
            this.linkPc.Location = new System.Drawing.Point(162, 222);
            this.linkPc.Name = "linkPc";
            this.linkPc.Size = new System.Drawing.Size(0, 13);
            this.linkPc.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(30, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(512, 212);
            this.dataGridView1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Last seen on:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Results:";
            // 
            // labelSeen
            // 
            this.labelSeen.AutoSize = true;
            this.labelSeen.Location = new System.Drawing.Point(158, 240);
            this.labelSeen.Name = "labelSeen";
            this.labelSeen.Size = new System.Drawing.Size(0, 13);
            this.labelSeen.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Scan or type the full monitor serial number.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 527);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelSeen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkPc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textOldSerial);
            this.Name = "Form1";
            this.Text = "Monitor Tracker";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textOldSerial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textNewSerial;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelFetching;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkPc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelSeen;
        private System.Windows.Forms.Label label6;
    }
}

