namespace DBExample
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
            this.cmd = new System.Windows.Forms.Button();
            this.lst = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmd
            // 
            this.cmd.Location = new System.Drawing.Point(818, 43);
            this.cmd.Name = "cmd";
            this.cmd.Size = new System.Drawing.Size(219, 71);
            this.cmd.TabIndex = 0;
            this.cmd.Text = "Get Data";
            this.cmd.UseVisualStyleBackColor = true;
            this.cmd.Click += new System.EventHandler(this.cmd_Click);
            // 
            // lst
            // 
            this.lst.FormattingEnabled = true;
            this.lst.ItemHeight = 24;
            this.lst.Location = new System.Drawing.Point(53, 43);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(730, 316);
            this.lst.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 398);
            this.Controls.Add(this.lst);
            this.Controls.Add(this.cmd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd;
        private System.Windows.Forms.ListBox lst;
    }
}

