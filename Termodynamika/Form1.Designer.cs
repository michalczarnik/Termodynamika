namespace Termodynamika
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
            this.loadFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.countButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadFile
            // 
            this.loadFile.Location = new System.Drawing.Point(910, 12);
            this.loadFile.Name = "loadFile";
            this.loadFile.Size = new System.Drawing.Size(300, 113);
            this.loadFile.TabIndex = 0;
            this.loadFile.Text = "Load File";
            this.loadFile.UseVisualStyleBackColor = true;
            this.loadFile.Click += new System.EventHandler(this.loadFile_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 670);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(1216, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(892, 670);
            this.panel2.TabIndex = 2;
            // 
            // count_button
            // 
            this.countButton.Enabled = false;
            this.countButton.Location = new System.Drawing.Point(910, 148);
            this.countButton.Name = "count_button";
            this.countButton.Size = new System.Drawing.Size(300, 113);
            this.countButton.TabIndex = 3;
            this.countButton.Text = "Count";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2128, 706);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loadFile);
            this.Name = "Form1";
            this.Text = "Termodynamika";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button countButton;
    }
}

