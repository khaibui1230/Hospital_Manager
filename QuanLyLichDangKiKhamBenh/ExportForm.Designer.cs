namespace QuanLyLichDangKiKhamBenh
{
    partial class ExportForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.PDf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(159, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Excel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PDf
            // 
            this.PDf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PDf.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PDf.Location = new System.Drawing.Point(421, 53);
            this.PDf.Name = "PDf";
            this.PDf.Size = new System.Drawing.Size(108, 49);
            this.PDf.TabIndex = 2;
            this.PDf.Text = "Pdf";
            this.PDf.UseVisualStyleBackColor = false;
            this.PDf.Click += new System.EventHandler(this.PDf_Click);
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 128);
            this.Controls.Add(this.PDf);
            this.Controls.Add(this.button1);
            this.Name = "ExportForm";
            this.Text = "ExportForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button PDf;
    }
}