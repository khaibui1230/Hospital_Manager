namespace QuanLyLichDangKiKhamBenh
{
    partial class DangNhapForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhapForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_TenTaiKhoan = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.DangKiLinkLB = new System.Windows.Forms.LinkLabel();
            this.LinkLb_QuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.DangnhapBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyLichDangKiKhamBenh.Properties.Resources.Screenshot_2023_11_24_034230;
            this.pictureBox1.Location = new System.Drawing.Point(130, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 173);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox_TenTaiKhoan
            // 
            this.textBox_TenTaiKhoan.Location = new System.Drawing.Point(207, 204);
            this.textBox_TenTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_TenTaiKhoan.Multiline = true;
            this.textBox_TenTaiKhoan.Name = "textBox_TenTaiKhoan";
            this.textBox_TenTaiKhoan.Size = new System.Drawing.Size(222, 33);
            this.textBox_TenTaiKhoan.TabIndex = 1;
            this.textBox_TenTaiKhoan.TextChanged += new System.EventHandler(this.TenTaiKhoan_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(154, 204);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Ivory;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(154, 275);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Location = new System.Drawing.Point(207, 275);
            this.textBox_MatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_MatKhau.Multiline = true;
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.PasswordChar = '*';
            this.textBox_MatKhau.Size = new System.Drawing.Size(222, 33);
            this.textBox_MatKhau.TabIndex = 3;
            this.textBox_MatKhau.TextChanged += new System.EventHandler(this.MatKhau_TextChanged);
            // 
            // DangKiLinkLB
            // 
            this.DangKiLinkLB.AutoSize = true;
            this.DangKiLinkLB.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.DangKiLinkLB.Location = new System.Drawing.Point(154, 348);
            this.DangKiLinkLB.Name = "DangKiLinkLB";
            this.DangKiLinkLB.Size = new System.Drawing.Size(64, 20);
            this.DangKiLinkLB.TabIndex = 7;
            this.DangKiLinkLB.TabStop = true;
            this.DangKiLinkLB.Text = "Đăng Ký";
            this.DangKiLinkLB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DangKiLinkLB_LinkClicked);
            // 
            // LinkLb_QuenMatKhau
            // 
            this.LinkLb_QuenMatKhau.AutoSize = true;
            this.LinkLb_QuenMatKhau.Location = new System.Drawing.Point(318, 348);
            this.LinkLb_QuenMatKhau.Name = "LinkLb_QuenMatKhau";
            this.LinkLb_QuenMatKhau.Size = new System.Drawing.Size(111, 20);
            this.LinkLb_QuenMatKhau.TabIndex = 8;
            this.LinkLb_QuenMatKhau.TabStop = true;
            this.LinkLb_QuenMatKhau.Text = "Quên Mật Khẩu";
            this.LinkLb_QuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLb_QuenMatKhau_LinkClicked);
            // 
            // DangnhapBtn
            // 
            this.DangnhapBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DangnhapBtn.Location = new System.Drawing.Point(218, 392);
            this.DangnhapBtn.Name = "DangnhapBtn";
            this.DangnhapBtn.Size = new System.Drawing.Size(113, 42);
            this.DangnhapBtn.TabIndex = 9;
            this.DangnhapBtn.Text = "Đăng nhập";
            this.DangnhapBtn.UseVisualStyleBackColor = false;
            this.DangnhapBtn.Click += new System.EventHandler(this.DangnhapBtn_Click);
            // 
            // DangNhapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 446);
            this.Controls.Add(this.DangnhapBtn);
            this.Controls.Add(this.LinkLb_QuenMatKhau);
            this.Controls.Add(this.DangKiLinkLB);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBox_MatKhau);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox_TenTaiKhoan);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DangNhapForm";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.DangNhapForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox_TenTaiKhoan;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox textBox_MatKhau;
        private LinkLabel DangKiLinkLB;
        private LinkLabel LinkLb_QuenMatKhau;
        private Button DangnhapBtn;
    }
}