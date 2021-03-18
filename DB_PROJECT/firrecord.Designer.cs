namespace DB_PROJECT
{
    partial class firrecord
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
            this.dataGridView_fir = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fir)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_fir
            // 
            this.dataGridView_fir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_fir.Location = new System.Drawing.Point(0, 1);
            this.dataGridView_fir.Name = "dataGridView_fir";
            this.dataGridView_fir.Size = new System.Drawing.Size(1181, 351);
            this.dataGridView_fir.TabIndex = 0;
            this.dataGridView_fir.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_fir_CellClick);
            this.dataGridView_fir.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_fir_CellContentClick);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(346, 359);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(309, 23);
            this.back.TabIndex = 1;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // firrecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 393);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dataGridView_fir);
            this.Name = "firrecord";
            this.Text = "firrecord";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_fir;
        private System.Windows.Forms.Button back;
    }
}