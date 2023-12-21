namespace QuanLyLichDangKiKhamBenh
{
    partial class DoctorManament
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_DoctorId = new System.Windows.Forms.TextBox();
            this.textBox_NameDoctor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxExp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Spec = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_Doctor = new System.Windows.Forms.DataGridView();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_Gen = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Doctor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(191, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1066, 38);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.Button_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 663);
            this.panel1.TabIndex = 3;
            // 
            // Button_Exit
            // 
            this.Button_Exit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Exit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button_Exit.Location = new System.Drawing.Point(36, 46);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(135, 38);
            this.Button_Exit.TabIndex = 1;
            this.Button_Exit.Text = "Exit";
            this.Button_Exit.UseVisualStyleBackColor = false;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(573, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quản Lý Bác Sĩ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(241, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã BS";
            // 
            // textBox_DoctorId
            // 
            this.textBox_DoctorId.Location = new System.Drawing.Point(348, 123);
            this.textBox_DoctorId.Name = "textBox_DoctorId";
            this.textBox_DoctorId.Size = new System.Drawing.Size(182, 27);
            this.textBox_DoctorId.TabIndex = 7;
            // 
            // textBox_NameDoctor
            // 
            this.textBox_NameDoctor.Location = new System.Drawing.Point(353, 194);
            this.textBox_NameDoctor.Name = "textBox_NameDoctor";
            this.textBox_NameDoctor.Size = new System.Drawing.Size(177, 27);
            this.textBox_NameDoctor.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(241, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên Bác sĩ";
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Location = new System.Drawing.Point(348, 259);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.Size = new System.Drawing.Size(182, 27);
            this.textBox_Pass.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(241, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mật khẩu";
            // 
            // textBoxExp
            // 
            this.textBoxExp.Location = new System.Drawing.Point(361, 329);
            this.textBoxExp.Name = "textBoxExp";
            this.textBoxExp.Size = new System.Drawing.Size(182, 27);
            this.textBoxExp.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(207, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kinh nghiệm";
            // 
            // textBox_Spec
            // 
            this.textBox_Spec.Location = new System.Drawing.Point(348, 408);
            this.textBox_Spec.Name = "textBox_Spec";
            this.textBox_Spec.Size = new System.Drawing.Size(195, 27);
            this.textBox_Spec.TabIndex = 15;
            this.textBox_Spec.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(205, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Chuyên khoa";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dataGridView_Doctor
            // 
            this.dataGridView_Doctor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_Doctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Doctor.Location = new System.Drawing.Point(623, 121);
            this.dataGridView_Doctor.Name = "dataGridView_Doctor";
            this.dataGridView_Doctor.RowHeadersWidth = 51;
            this.dataGridView_Doctor.RowTemplate.Height = 29;
            this.dataGridView_Doctor.Size = new System.Drawing.Size(622, 425);
            this.dataGridView_Doctor.TabIndex = 16;
            this.dataGridView_Doctor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Doctor_CellContentClick);
            this.dataGridView_Doctor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Doctor_CellContentClick);
            // 
            // button_Them
            // 
            this.button_Them.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Them.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Them.Location = new System.Drawing.Point(219, 538);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(94, 42);
            this.button_Them.TabIndex = 17;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = false;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Xoa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Xoa.Location = new System.Drawing.Point(480, 538);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(94, 42);
            this.button_Xoa.TabIndex = 18;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = false;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Sua
            // 
            this.button_Sua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Sua.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Sua.Location = new System.Drawing.Point(348, 538);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(94, 42);
            this.button_Sua.TabIndex = 19;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = false;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(205, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 28);
            this.label7.TabIndex = 20;
            this.label7.Text = "Giới tính";
            // 
            // comboBox_Gen
            // 
            this.comboBox_Gen.FormattingEnabled = true;
            this.comboBox_Gen.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.comboBox_Gen.Location = new System.Drawing.Point(348, 475);
            this.comboBox_Gen.Name = "comboBox_Gen";
            this.comboBox_Gen.Size = new System.Drawing.Size(151, 28);
            this.comboBox_Gen.TabIndex = 21;
            // 
            // DoctorManament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 663);
            this.Controls.Add(this.comboBox_Gen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_Sua);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.dataGridView_Doctor);
            this.Controls.Add(this.textBox_Spec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxExp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_NameDoctor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_DoctorId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "DoctorManament";
            this.Text = "DoctorManament";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Doctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Button Button_Exit;
        private Label label1;
        private Label label2;
        private TextBox textBox_DoctorId;
        private TextBox textBox_NameDoctor;
        private Label label3;
        private TextBox textBox_Pass;
        private Label label4;
        private TextBox textBoxExp;
        private Label label5;
        private TextBox textBox_Spec;
        private Label label6;
        private DataGridView dataGridView_Doctor;
        private Button button_Them;
        private Button button_Xoa;
        private Button button_Sua;
        private Label label7;
        private ComboBox comboBox_Gen;
    }
}