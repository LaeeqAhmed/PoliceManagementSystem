namespace DB_PROJECT
{
    partial class emp_form
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
            this.outbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outbtn
            // 
            this.outbtn.Location = new System.Drawing.Point(846, 12);
            this.outbtn.Name = "outbtn";
            this.outbtn.Size = new System.Drawing.Size(75, 23);
            this.outbtn.TabIndex = 0;
            this.outbtn.Text = "LogOut";
            this.outbtn.UseVisualStyleBackColor = true;
            this.outbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // emp_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 355);
            this.Controls.Add(this.outbtn);
            this.Name = "emp_form";
            this.Text = "emp_form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button outbtn;
    }
}