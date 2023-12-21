namespace QuanLyLichDangKiKhamBenh
{
    partial class PrescriptionsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_TenThuoc = new System.Windows.Forms.TextBox();
            this.textBox_LieuLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_CachSuDung = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_IdCuaBenhNha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 669);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(21, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(21, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Lưu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(206, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Thuốc";
            // 
            // textBox_TenThuoc
            // 
            this.textBox_TenThuoc.Location = new System.Drawing.Point(364, 98);
            this.textBox_TenThuoc.Name = "textBox_TenThuoc";
            this.textBox_TenThuoc.Size = new System.Drawing.Size(364, 27);
            this.textBox_TenThuoc.TabIndex = 2;
            // 
            // textBox_LieuLuong
            // 
            this.textBox_LieuLuong.Location = new System.Drawing.Point(364, 158);
            this.textBox_LieuLuong.Name = "textBox_LieuLuong";
            this.textBox_LieuLuong.Size = new System.Drawing.Size(364, 27);
            this.textBox_LieuLuong.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(206, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Liều Lượng";
            // 
            // textBox_CachSuDung
            // 
            this.textBox_CachSuDung.Location = new System.Drawing.Point(364, 209);
            this.textBox_CachSuDung.Name = "textBox_CachSuDung";
            this.textBox_CachSuDung.Size = new System.Drawing.Size(364, 27);
            this.textBox_CachSuDung.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(206, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cách sử dụng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(206, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(947, 357);
            this.dataGridView1.TabIndex = 7;
            // 
            // textBox_IdCuaBenhNha
            // 
            this.textBox_IdCuaBenhNha.Location = new System.Drawing.Point(425, 31);
            this.textBox_IdCuaBenhNha.Name = "textBox_IdCuaBenhNha";
            this.textBox_IdCuaBenhNha.Size = new System.Drawing.Size(364, 27);
            this.textBox_IdCuaBenhNha.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(206, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Id của bệnh nhân";
            // 
            // PrescriptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 669);
            this.Controls.Add(this.textBox_IdCuaBenhNha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_CachSuDung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_LieuLuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_TenThuoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "PrescriptionsForm";
            this.Text = "PrescriptionsForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Label label1;
        private TextBox textBox_TenThuoc;
        private TextBox textBox_LieuLuong;
        private Label label2;
        private TextBox textBox_CachSuDung;
        private Label label3;
        private DataGridView dataGridView1;
        private TextBox textBox_IdCuaBenhNha;
        private Label label4;
    }
}