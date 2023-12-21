using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using Bunifu.Framework.UI;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace QuanLyLichDangKiKhamBenh
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            Home_Load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.C = new System.Windows.Forms.Label();
            this.Button_ThemBenhNhan = new System.Windows.Forms.Button();
            this.Button_ChanDoanBenh = new System.Windows.Forms.Button();
            this.button_DSachBenhNhan = new System.Windows.Forms.Button();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.panel_thembenhnhan = new System.Windows.Forms.Panel();
            this.button_xoa = new System.Windows.Forms.Button();
            this.Button_Sua = new System.Windows.Forms.Button();
            this.dataGridViewAdd = new System.Windows.Forms.DataGridView();
            this.textBox_Year = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_NhomMau = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_CCCD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_TienSuBenh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Age = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Number = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_DS = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridView_Full = new System.Windows.Forms.DataGridView();
            this.panel_ChandoanBenh = new System.Windows.Forms.Panel();
            this.button_Luu = new System.Windows.Forms.Button();
            this.comboBox_KhoaKhambenh = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox_CanGiamSAt = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button_keDonThuoc = new System.Windows.Forms.Button();
            this.textBox_Chandoan = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_TrieuChung = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView_PatientMore = new System.Windows.Forms.DataGridView();
            this.textBox_Id2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printDialog_All = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel_thembenhnhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdd)).BeginInit();
            this.panel_DS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Full)).BeginInit();
            this.panel_ChandoanBenh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PatientMore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.C.Location = new System.Drawing.Point(30, 46);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(132, 31);
            this.C.TabIndex = 0;
            this.C.Text = "Chức Năng";
            // 
            // Button_ThemBenhNhan
            // 
            this.Button_ThemBenhNhan.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Button_ThemBenhNhan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_ThemBenhNhan.Location = new System.Drawing.Point(12, 102);
            this.Button_ThemBenhNhan.Name = "Button_ThemBenhNhan";
            this.Button_ThemBenhNhan.Size = new System.Drawing.Size(215, 49);
            this.Button_ThemBenhNhan.TabIndex = 1;
            this.Button_ThemBenhNhan.Text = "Thêm Bệnh Nhân";
            this.Button_ThemBenhNhan.UseVisualStyleBackColor = false;
            this.Button_ThemBenhNhan.Click += new System.EventHandler(this.Button_ThemBenhNhan_Click);
            // 
            // Button_ChanDoanBenh
            // 
            this.Button_ChanDoanBenh.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Button_ChanDoanBenh.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_ChanDoanBenh.Location = new System.Drawing.Point(12, 178);
            this.Button_ChanDoanBenh.Name = "Button_ChanDoanBenh";
            this.Button_ChanDoanBenh.Size = new System.Drawing.Size(215, 49);
            this.Button_ChanDoanBenh.TabIndex = 2;
            this.Button_ChanDoanBenh.Text = "Chẩn Đoán Bệnh";
            this.Button_ChanDoanBenh.UseVisualStyleBackColor = false;
            this.Button_ChanDoanBenh.Click += new System.EventHandler(this.Button_ChanDoanBenh_Click);
            // 
            // button_DSachBenhNhan
            // 
            this.button_DSachBenhNhan.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_DSachBenhNhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_DSachBenhNhan.Location = new System.Drawing.Point(12, 265);
            this.button_DSachBenhNhan.Name = "button_DSachBenhNhan";
            this.button_DSachBenhNhan.Size = new System.Drawing.Size(215, 49);
            this.button_DSachBenhNhan.TabIndex = 3;
            this.button_DSachBenhNhan.Text = "DS Đã chẩn đoán\r\n";
            this.button_DSachBenhNhan.UseVisualStyleBackColor = false;
            this.button_DSachBenhNhan.Click += new System.EventHandler(this.button_DSachBenhNhan_Click);
            // 
            // button_Thoat
            // 
            this.button_Thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Thoat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Thoat.Location = new System.Drawing.Point(50, 421);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(112, 50);
            this.button_Thoat.TabIndex = 4;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = false;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // panel_thembenhnhan
            // 
            this.panel_thembenhnhan.Controls.Add(this.button_xoa);
            this.panel_thembenhnhan.Controls.Add(this.Button_Sua);
            this.panel_thembenhnhan.Controls.Add(this.dataGridViewAdd);
            this.panel_thembenhnhan.Controls.Add(this.textBox_Year);
            this.panel_thembenhnhan.Controls.Add(this.label10);
            this.panel_thembenhnhan.Controls.Add(this.comboBox_NhomMau);
            this.panel_thembenhnhan.Controls.Add(this.comboBox1);
            this.panel_thembenhnhan.Controls.Add(this.label9);
            this.panel_thembenhnhan.Controls.Add(this.button_Save);
            this.panel_thembenhnhan.Controls.Add(this.textBox_CCCD);
            this.panel_thembenhnhan.Controls.Add(this.label8);
            this.panel_thembenhnhan.Controls.Add(this.textBox_TienSuBenh);
            this.panel_thembenhnhan.Controls.Add(this.label7);
            this.panel_thembenhnhan.Controls.Add(this.label6);
            this.panel_thembenhnhan.Controls.Add(this.label5);
            this.panel_thembenhnhan.Controls.Add(this.textBox_Age);
            this.panel_thembenhnhan.Controls.Add(this.label4);
            this.panel_thembenhnhan.Controls.Add(this.textBox_Number);
            this.panel_thembenhnhan.Controls.Add(this.label3);
            this.panel_thembenhnhan.Controls.Add(this.textBox_Address);
            this.panel_thembenhnhan.Controls.Add(this.label2);
            this.panel_thembenhnhan.Controls.Add(this.textBox_Name);
            this.panel_thembenhnhan.Controls.Add(this.label1);
            this.panel_thembenhnhan.Location = new System.Drawing.Point(252, 12);
            this.panel_thembenhnhan.Name = "panel_thembenhnhan";
            this.panel_thembenhnhan.Size = new System.Drawing.Size(1170, 630);
            this.panel_thembenhnhan.TabIndex = 6;
            this.panel_thembenhnhan.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button_xoa
            // 
            this.button_xoa.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_xoa.Location = new System.Drawing.Point(776, 305);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(112, 42);
            this.button_xoa.TabIndex = 26;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = false;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // Button_Sua
            // 
            this.Button_Sua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button_Sua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button_Sua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_Sua.Location = new System.Drawing.Point(454, 305);
            this.Button_Sua.Name = "Button_Sua";
            this.Button_Sua.Size = new System.Drawing.Size(112, 42);
            this.Button_Sua.TabIndex = 25;
            this.Button_Sua.Text = "Sửa";
            this.Button_Sua.UseVisualStyleBackColor = false;
            this.Button_Sua.Click += new System.EventHandler(this.Button_Sua_Click);
            // 
            // dataGridViewAdd
            // 
            this.dataGridViewAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdd.Location = new System.Drawing.Point(13, 362);
            this.dataGridViewAdd.Name = "dataGridViewAdd";
            this.dataGridViewAdd.RowHeadersWidth = 51;
            this.dataGridViewAdd.RowTemplate.Height = 29;
            this.dataGridViewAdd.Size = new System.Drawing.Size(1157, 234);
            this.dataGridViewAdd.TabIndex = 24;
            this.dataGridViewAdd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdd_CellContentClick);
            this.dataGridViewAdd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdd_CellContentClick);
            // 
            // textBox_Year
            // 
            this.textBox_Year.Location = new System.Drawing.Point(946, 78);
            this.textBox_Year.Name = "textBox_Year";
            this.textBox_Year.Size = new System.Drawing.Size(125, 27);
            this.textBox_Year.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(842, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Năm sinh";
            // 
            // comboBox_NhomMau
            // 
            this.comboBox_NhomMau.FormattingEnabled = true;
            this.comboBox_NhomMau.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O",
            "A Rh+",
            "A Rh-",
            "B Rh+",
            "B Rh-",
            "AB Rh+",
            "AB Rh-",
            "O Rh+",
            "O Rh-"});
            this.comboBox_NhomMau.Location = new System.Drawing.Point(677, 195);
            this.comboBox_NhomMau.Name = "comboBox_NhomMau";
            this.comboBox_NhomMau.Size = new System.Drawing.Size(91, 28);
            this.comboBox_NhomMau.TabIndex = 19;
            this.comboBox_NhomMau.SelectedIndexChanged += new System.EventHandler(this.comboBox_NhomMau_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.comboBox1.Location = new System.Drawing.Point(961, 193);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(88, 28);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(352, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(230, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "THÊM BỆNH NHÂN";
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Save.Location = new System.Drawing.Point(202, 305);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(112, 42);
            this.button_Save.TabIndex = 16;
            this.button_Save.Text = "Thêm";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // textBox_CCCD
            // 
            this.textBox_CCCD.Location = new System.Drawing.Point(147, 188);
            this.textBox_CCCD.Name = "textBox_CCCD";
            this.textBox_CCCD.Size = new System.Drawing.Size(307, 27);
            this.textBox_CCCD.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(34, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "CCCD";
            // 
            // textBox_TienSuBenh
            // 
            this.textBox_TienSuBenh.Location = new System.Drawing.Point(192, 244);
            this.textBox_TienSuBenh.Name = "textBox_TienSuBenh";
            this.textBox_TienSuBenh.Size = new System.Drawing.Size(869, 27);
            this.textBox_TienSuBenh.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(30, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tiền sử bệnh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(547, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nhóm máu";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(845, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giới Tính";
            // 
            // textBox_Age
            // 
            this.textBox_Age.Location = new System.Drawing.Point(490, 75);
            this.textBox_Age.Name = "textBox_Age";
            this.textBox_Age.Size = new System.Drawing.Size(133, 27);
            this.textBox_Age.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(425, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tuổi";
            // 
            // textBox_Number
            // 
            this.textBox_Number.Location = new System.Drawing.Point(600, 138);
            this.textBox_Number.Name = "textBox_Number";
            this.textBox_Number.Size = new System.Drawing.Size(203, 27);
            this.textBox_Number.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(440, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số điện thoại";
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(149, 129);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(270, 27);
            this.textBox_Address.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa Chỉ";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(149, 78);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(270, 27);
            this.textBox_Name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Và Tên";
            // 
            // panel_DS
            // 
            this.panel_DS.Controls.Add(this.button3);
            this.panel_DS.Controls.Add(this.label17);
            this.panel_DS.Controls.Add(this.dataGridView_Full);
            this.panel_DS.Location = new System.Drawing.Point(252, 15);
            this.panel_DS.Name = "panel_DS";
            this.panel_DS.Size = new System.Drawing.Size(1190, 635);
            this.panel_DS.TabIndex = 23;
            this.panel_DS.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(985, 537);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "Xóa Thông tin";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(422, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(328, 28);
            this.label17.TabIndex = 1;
            this.label17.Text = "Danh Sách bệnh Nhân";
            // 
            // dataGridView_Full
            // 
            this.dataGridView_Full.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Full.Location = new System.Drawing.Point(13, 57);
            this.dataGridView_Full.Name = "dataGridView_Full";
            this.dataGridView_Full.RowHeadersWidth = 51;
            this.dataGridView_Full.RowTemplate.Height = 29;
            this.dataGridView_Full.Size = new System.Drawing.Size(1159, 456);
            this.dataGridView_Full.TabIndex = 0;
            this.dataGridView_Full.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Full_CellContentClick);
            this.dataGridView_Full.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Full_CellContentClick_2);
            // 
            // panel_ChandoanBenh
            // 
            this.panel_ChandoanBenh.Controls.Add(this.button_Luu);
            this.panel_ChandoanBenh.Controls.Add(this.comboBox_KhoaKhambenh);
            this.panel_ChandoanBenh.Controls.Add(this.label16);
            this.panel_ChandoanBenh.Controls.Add(this.comboBox_CanGiamSAt);
            this.panel_ChandoanBenh.Controls.Add(this.label15);
            this.panel_ChandoanBenh.Controls.Add(this.button_keDonThuoc);
            this.panel_ChandoanBenh.Controls.Add(this.textBox_Chandoan);
            this.panel_ChandoanBenh.Controls.Add(this.label14);
            this.panel_ChandoanBenh.Controls.Add(this.textBox_TrieuChung);
            this.panel_ChandoanBenh.Controls.Add(this.label13);
            this.panel_ChandoanBenh.Controls.Add(this.dataGridView_PatientMore);
            this.panel_ChandoanBenh.Controls.Add(this.textBox_Id2);
            this.panel_ChandoanBenh.Controls.Add(this.label12);
            this.panel_ChandoanBenh.Controls.Add(this.label11);
            this.panel_ChandoanBenh.Location = new System.Drawing.Point(255, 12);
            this.panel_ChandoanBenh.Name = "panel_ChandoanBenh";
            this.panel_ChandoanBenh.Size = new System.Drawing.Size(1167, 638);
            this.panel_ChandoanBenh.TabIndex = 22;
            this.panel_ChandoanBenh.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button_Luu
            // 
            this.button_Luu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Luu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Luu.Location = new System.Drawing.Point(856, 552);
            this.button_Luu.Name = "button_Luu";
            this.button_Luu.Size = new System.Drawing.Size(111, 42);
            this.button_Luu.TabIndex = 13;
            this.button_Luu.Text = "Lưu";
            this.button_Luu.UseVisualStyleBackColor = false;
            this.button_Luu.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox_KhoaKhambenh
            // 
            this.comboBox_KhoaKhambenh.FormattingEnabled = true;
            this.comboBox_KhoaKhambenh.Items.AddRange(new object[] {
            "Khoa Nội Tiêu Hóa ",
            "Khoa Tim Mạch ",
            "Khoa Nhi ",
            "Khoa Phụ Nữ và Sinh Học ",
            "Khoa Ngoại Tiêu Hóa ",
            "Khoa Tai Mũi Họng ",
            "Khoa Chấn Thương ",
            "Khoa Y Học Nội Ngoại ",
            "Khoa Ung Bướu ",
            "Khoa Nguồn Cung Y Tế ",
            "Khoa Hồi Sức Cấp Cứu ",
            "Khoa Ngoại Tâm Thần Học ",
            "Khoa Nhiễm ",
            "Khoa Răng Hàm Mặt ",
            "Khoa Mắt"});
            this.comboBox_KhoaKhambenh.Location = new System.Drawing.Point(841, 476);
            this.comboBox_KhoaKhambenh.Name = "comboBox_KhoaKhambenh";
            this.comboBox_KhoaKhambenh.Size = new System.Drawing.Size(260, 28);
            this.comboBox_KhoaKhambenh.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(661, 479);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(161, 25);
            this.label16.TabIndex = 11;
            this.label16.Text = " Khoa khám bệnh";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // comboBox_CanGiamSAt
            // 
            this.comboBox_CanGiamSAt.FormattingEnabled = true;
            this.comboBox_CanGiamSAt.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.comboBox_CanGiamSAt.Location = new System.Drawing.Point(709, 406);
            this.comboBox_CanGiamSAt.Name = "comboBox_CanGiamSAt";
            this.comboBox_CanGiamSAt.Size = new System.Drawing.Size(93, 28);
            this.comboBox_CanGiamSAt.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(544, 405);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 25);
            this.label15.TabIndex = 9;
            this.label15.Text = "Cần giám sát";
            // 
            // button_keDonThuoc
            // 
            this.button_keDonThuoc.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_keDonThuoc.Location = new System.Drawing.Point(103, 532);
            this.button_keDonThuoc.Name = "button_keDonThuoc";
            this.button_keDonThuoc.Size = new System.Drawing.Size(127, 29);
            this.button_keDonThuoc.TabIndex = 8;
            this.button_keDonThuoc.Text = "Kê đơn thuốc";
            this.button_keDonThuoc.UseVisualStyleBackColor = false;
            this.button_keDonThuoc.Click += new System.EventHandler(this.button_keDonThuoc_Click);
            // 
            // textBox_Chandoan
            // 
            this.textBox_Chandoan.Location = new System.Drawing.Point(170, 471);
            this.textBox_Chandoan.Name = "textBox_Chandoan";
            this.textBox_Chandoan.Size = new System.Drawing.Size(248, 27);
            this.textBox_Chandoan.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(43, 467);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 25);
            this.label14.TabIndex = 6;
            this.label14.Text = "Chẩn đoán";
            // 
            // textBox_TrieuChung
            // 
            this.textBox_TrieuChung.Location = new System.Drawing.Point(170, 410);
            this.textBox_TrieuChung.Name = "textBox_TrieuChung";
            this.textBox_TrieuChung.Size = new System.Drawing.Size(192, 27);
            this.textBox_TrieuChung.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(43, 409);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 25);
            this.label13.TabIndex = 4;
            this.label13.Text = "Triệu chứng";
            // 
            // dataGridView_PatientMore
            // 
            this.dataGridView_PatientMore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PatientMore.Location = new System.Drawing.Point(21, 180);
            this.dataGridView_PatientMore.Name = "dataGridView_PatientMore";
            this.dataGridView_PatientMore.RowHeadersWidth = 51;
            this.dataGridView_PatientMore.RowTemplate.Height = 29;
            this.dataGridView_PatientMore.Size = new System.Drawing.Size(1143, 188);
            this.dataGridView_PatientMore.TabIndex = 3;
            this.dataGridView_PatientMore.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_PatientMore_CellContentClick);
            // 
            // textBox_Id2
            // 
            this.textBox_Id2.Location = new System.Drawing.Point(182, 105);
            this.textBox_Id2.Name = "textBox_Id2";
            this.textBox_Id2.Size = new System.Drawing.Size(192, 27);
            this.textBox_Id2.TabIndex = 2;
            this.textBox_Id2.TextChanged += new System.EventHandler(this.textBox_Id_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(43, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "Số Căn Cước";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(387, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 31);
            this.label11.TabIndex = 0;
            this.label11.Text = "Chẩn Đoán Bệnh";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 39);
            this.button1.TabIndex = 24;
            this.button1.Text = "Xuất thông tin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataSource = typeof(QuanLyLichDangKiKhamBenh.TaiKhoan);
            // 
            // printDialog_All
            // 
            this.printDialog_All.Document = this.printDocument1;
            this.printDialog_All.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Home
            // 
            this.ClientSize = new System.Drawing.Size(1499, 798);
            this.Controls.Add(this.panel_DS);
            this.Controls.Add(this.panel_thembenhnhan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel_ChandoanBenh);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.button_DSachBenhNhan);
            this.Controls.Add(this.Button_ChanDoanBenh);
            this.Controls.Add(this.Button_ThemBenhNhan);
            this.Controls.Add(this.C);
            this.Name = "Home";
            this.Text = "Patients Manament";
            this.panel_thembenhnhan.ResumeLayout(false);
            this.panel_thembenhnhan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdd)).EndInit();
            this.panel_DS.ResumeLayout(false);
            this.panel_DS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Full)).EndInit();
            this.panel_ChandoanBenh.ResumeLayout(false);
            this.panel_ChandoanBenh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PatientMore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Home_Load()
        {
            panel_thembenhnhan.Visible = false;
            panel_ChandoanBenh.Visible = false;
            panel_DS.Visible = true;


            ShowFullDataForDoctor();
        }

        private void Button_ThemBenhNhan_Click(object sender, EventArgs e)
        {
            Button_ThemBenhNhan.BackColor = Color.Yellow;
            Button_ChanDoanBenh.BackColor = Color.White;
            button_DSachBenhNhan.BackColor = Color.White;

            panel_ChandoanBenh.Visible = false;
            panel_thembenhnhan.Visible = true;
            panel_DS.Visible = false;
            RefreshDataGridView();
        }

        private void Button_ChanDoanBenh_Click(object sender, EventArgs e)
        {
            Button_ThemBenhNhan.BackColor = Color.White;
            Button_ChanDoanBenh.BackColor = Color.Yellow;
            button_DSachBenhNhan.BackColor = Color.White;

            // an panel

            panel_thembenhnhan.Visible = false;
            panel_ChandoanBenh.Visible = true;
            panel_DS.Visible = false;

            // hien bang co so du lieu
            ShowDataPatientToDia();
        }

        private void ShowDataPatientToDia()
        {
            using (SqlConnection sql = Connection.GetSqlConnection())
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sql;
                cmd.CommandText = "select * from Patients ";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                DA.Fill(dataSet);
                dataGridView_PatientMore.DataSource = dataSet.Tables[0];
                sql.Close();
            }
        }

        private void button_DSachBenhNhan_Click(object sender, EventArgs e)
        {
            Button_ThemBenhNhan.BackColor = Color.White;
            Button_ChanDoanBenh.BackColor = Color.White;
            button_DSachBenhNhan.BackColor = Color.Yellow;
            panel_thembenhnhan.Visible = false;
            panel_DS.Visible = true;
            panel_ChandoanBenh.Visible = false;

            ShowFullDataForDoctor();
        }

        private void ShowFullDataForDoctor()
        {
            using (SqlConnection sql = Connection.GetSqlConnection())
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sql;
                cmd.CommandText = "select * from Patients inner join PatientsMore on Patients.PatientID = PatientsMore.PatientID";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                DA.Fill(dataSet);
                dataGridView_Full.DataSource = dataSet.Tables[0];
                sql.Close();
            }
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không? ", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DangNhapForm dangNhapFormform = new DangNhapForm();
                dangNhapFormform.Show();


                this.Hide();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        Modiffy modiffy = new Modiffy();



        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void textBox_Id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Id2.Text != "")
                {
                    int pid = Convert.ToInt32(textBox_Id2.Text);

                    using (SqlConnection sql = Connection.GetSqlConnection())
                    {
                        sql.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = sql;
                        cmd.CommandText = "select * from Patients where PatientID = " + pid + " ";
                        SqlDataAdapter DA = new SqlDataAdapter(cmd);
                        DataSet dataSet = new DataSet();
                        DA.Fill(dataSet);
                        dataGridView_PatientMore.DataSource = dataSet.Tables[0];
                        sql.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("vui long Id của bệnh nhân");
            }
        }
        // save chan doan benh
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = Convert.ToInt32(textBox_Id2.Text);
                String sympt = textBox_TrieuChung.Text;
                String diag = textBox_Chandoan.Text;
                String ward = comboBox_CanGiamSAt.Text;
                String wardType = comboBox_KhoaKhambenh.Text;

                // them du lieu vao database
                using (SqlConnection sql = Connection.GetSqlConnection())
                {
                    sql.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sql;
                    cmd.CommandText = "INSERT INTO PatientsMore (PatientID, Symotoms, Diagnosis, Ward, Ward_Type) VALUES (@pid, @sympt, @diag, @ward, @wardType)";

                    // Add parameters to the SqlCommand
                    cmd.Parameters.AddWithValue("@pid", pid);
                    cmd.Parameters.AddWithValue("@sympt", sympt);
                    cmd.Parameters.AddWithValue("@diag", diag);
                    cmd.Parameters.AddWithValue("@ward", ward);
                    cmd.Parameters.AddWithValue("@wardType", wardType);

                    // Execute the INSERT query
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm dữ liệu thành công");
                    sql.Close();

                }
            }
            catch
            {
                MessageBox.Show("dữ liệu sai hoặc lỗi");
            }

            // xoa thong tin da nhap
            textBox_Id2.Clear();
            textBox_TrieuChung.Clear();
            textBox_Chandoan.Clear();
            comboBox_CanGiamSAt.ResetText();
            comboBox_KhoaKhambenh.ResetText();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        // Them benh nhan
        private void button_Save_Click(object sender, EventArgs e)
        {
            String name = textBox_Name.Text;
            String address = textBox_Address.Text;
            String contactText = textBox_Number.Text;
            int contact;
            String ageText = textBox_Age.Text;
            int Age;
            String blood = comboBox_NhomMau.Text;
            String cccdText = textBox_CCCD.Text;
            int cCCD;
            String history = textBox_TienSuBenh.Text;
            String yearText = textBox_Year.Text;
            int Year;
            String gender = comboBox1.Text;

            if (name.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhâp tên bệnh nhân");
            }
            else if (address.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhâp địa chỉ bệnh nhân");
            }
            else if (!int.TryParse(contactText, out contact) || contact <= 0)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại bệnh nhân hợp lệ");
            }
            else if (!int.TryParse(ageText, out Age) || Age <= 0)
            {
                MessageBox.Show("Vui lòng nhập số tuổi bệnh nhân hợp lệ");
            }
            else if (!int.TryParse(cccdText, out cCCD) || cCCD <= 0)
            {
                MessageBox.Show("Vui lòng nhập số Căn cước của bệnh nhân hợp lệ");
            }
            else if (!int.TryParse(yearText, out Year) || Year <= 0)
            {
                MessageBox.Show("Vui lòng nhập năm sinh của bệnh nhân hợp lệ");
            }
            else
            {


                try
                {
                    // Create a patient object
                    Patients newPatient = new Patients
                    {
                        CCCD = cCCD,
                        Name = name,
                        Gender = gender,
                        DayOfBirth = new DateTime(Year, 1, 1),
                        Contact = contact,
                        BloodGroup = blood,
                        History = history,
                        Address = address
                    };

                    // Check if the patient already exists by querying the database
                    string queryCheckCCCD = "SELECT COUNT(*) FROM Patients WHERE PatientID = @CCCD";
                    using (SqlConnection sqlConnection = Connection.GetSqlConnection())
                    {
                        sqlConnection.Open();

                        using (SqlCommand sqlCommandCheckCCCD = new SqlCommand(queryCheckCCCD, sqlConnection))
                        {
                            sqlCommandCheckCCCD.Parameters.AddWithValue("@CCCD", cCCD);

                            int existingCount = (int)sqlCommandCheckCCCD.ExecuteScalar();

                            if (existingCount > 0)
                            {
                                // Patient with the given CCCD already exists
                                MessageBox.Show("Căn cước này đã đăng ký");
                                return;
                            }
                        }
                    }

                    // Check if the patient's phone number already exists by querying the database
                    string queryCheckPhoneNumber = "SELECT COUNT(*) FROM Patients WHERE PhoneNumber = @PhoneNumber";
                    using (SqlConnection sqlConnection = Connection.GetSqlConnection())
                    {
                        sqlConnection.Open();

                        using (SqlCommand sqlCommandCheckPhoneNumber = new SqlCommand(queryCheckPhoneNumber, sqlConnection))
                        {
                            sqlCommandCheckPhoneNumber.Parameters.AddWithValue("@PhoneNumber", contact);

                            int existingCount = (int)sqlCommandCheckPhoneNumber.ExecuteScalar();

                            if (existingCount > 0)
                            {
                                // Patient with the given phone number already exists
                                MessageBox.Show("Số điện thoại này đã được đăng ký");
                                return;
                            }
                        }
                    }

                    // Insert the new patient into the database
                    modiffy.AddPatients(newPatient);

                    MessageBox.Show("Thêm bệnh nhân thành công");

                    // cap nhật sao khi thêm bệnh nhan
                    RefreshDataGridView();

                    // Clear input fields
                    ClearInputFields();
                    // ... (your existing code)
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void RefreshDataGridView()
        {
            using (SqlConnection sql = Connection.GetSqlConnection())
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sql;
                cmd.CommandText = "select * from Patients ";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                DA.Fill(dataSet);
                dataGridViewAdd.DataSource = dataSet.Tables[0];
                sql.Close();
            }
        }

        private void ClearInputFields()
        {
            textBox_Name.Clear();
            textBox_Address.Clear();
            textBox_Number.Clear();
            textBox_Age.Clear();
            comboBox_NhomMau.Items.Clear();
            textBox_CCCD.Clear();
            textBox_TienSuBenh.Clear();
            textBox_Year.Clear();
            comboBox1.Items.Clear();
            comboBox_NhomMau.Items.Clear();

        }
        // ke don thuoc tu bang Excell

        private void button_keDonThuoc_Click(object sender, EventArgs e)
        {
            try
            {// Tạo một package Excel
                using (var excelPackage = new ExcelPackage())
                {
                    // Thêm một worksheet vào package
                    var worksheet = excelPackage.Workbook.Worksheets.Add("DonThuoc");

                    // Thêm dữ liệu vào worksheet
                    worksheet.Cells["A1"].Value = "Tên Thuốc";
                    worksheet.Cells["B1"].Value = "Liều Lượng";
                    worksheet.Cells["C1"].Value = "Cách Dùng";

                    // Lưu tệp Excel vào một đường dẫn cụ thể 

                    var filePath = Path.Combine("D:\\TaiLieuDaiHoc\\Nam4-Ki1\\XDHTTTQL\\QuanLyLichDangKiKhamBenh", "DonThuoc.xlsx");


                    // Lưu workbook vào tệp Excel
                    File.WriteAllBytes(filePath, excelPackage.GetAsByteArray());

                    // Hiển thị thông báo thành công
                    MessageBox.Show($"Đã tạo và lưu Excel thành công tại:\n{filePath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        //xuat file 
        private void button1_Click(object sender, EventArgs e)
        {
            ExportForm exportForm = new ExportForm();
            exportForm.ShowDialog();


            if (exportForm.ExportExcelResult)
            {
                Export_Excel();
            }
            else if (exportForm.ExportPdfResult)
            {
                ExportPDf();
            }
            else if (exportForm.ExportWordResult)
            {
                Export_Word();
            }



        }



        private void ExportPDf()
        {
            if (dataGridView_Full.Rows.Count > 0)

            {

                SaveFileDialog save = new SaveFileDialog();

                save.Filter = "PDF (*.pdf)|*.pdf";

                save.FileName = "Result.pdf";

                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)

                {

                    if (File.Exists(save.FileName))

                    {

                        try

                        {

                            File.Delete(save.FileName);

                        }

                        catch (Exception ex)

                        {

                            ErrorMessage = true;

                            MessageBox.Show("Unable to wride data in disk" + ex.Message);

                        }

                    }

                    if (!ErrorMessage)

                    {

                        try

                        {

                            PdfPTable pTable = new PdfPTable(dataGridView_Full.Columns.Count);

                            pTable.DefaultCell.Padding = 2;

                            pTable.WidthPercentage = 100;

                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in dataGridView_Full.Columns)

                            {

                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                pTable.AddCell(pCell);

                            }

                            foreach (DataGridViewRow viewRow in dataGridView_Full.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    // Kiểm tra giá trị của ô trước khi thêm vào pTable
                                    string cellValue = (dcell.Value != null) ? dcell.Value.ToString() : "";
                                    pTable.AddCell(cellValue);
                                }
                            }


                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))

                            {

                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);

                                PdfWriter.GetInstance(document, fileStream);

                                document.Open();

                                document.Add(pTable);

                                document.Close();

                                fileStream.Close();

                            }

                            MessageBox.Show("Export thành công", "info");

                        }

                        catch (Exception ex)

                        {

                            MessageBox.Show("Bị lỗi:" + ex.Message);

                        }

                    }

                }

            }

            else

            {

                MessageBox.Show("No Record Found", "Info");

            }

        }


        private void Export_Excel()
        {
            if (dataGridView_Full.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Excel (*.xlsx)|*.xlsx";
                save.FileName = "Result.xlsx";

                bool errorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            errorMessage = true;
                            MessageBox.Show("Unable to write data to disk: " + ex.Message);
                        }
                    }

                    if (!errorMessage)
                    {
                        try
                        {
                            using (ExcelPackage excelPackage = new ExcelPackage())
                            {
                                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Data");

                                // Ghi header
                                int colIndex = 1;
                                foreach (DataGridViewColumn col in dataGridView_Full.Columns)
                                {
                                    worksheet.Cells[1, colIndex].Value = col.HeaderText;
                                    colIndex++;
                                }

                                // Ghi dữ liệu
                                int rowIndex = 2;
                                foreach (DataGridViewRow viewRow in dataGridView_Full.Rows)
                                {
                                    int cellIndex = 1;
                                    foreach (DataGridViewCell dcell in viewRow.Cells)
                                    {
                                        string cellValue = (dcell.Value != null) ? dcell.Value.ToString() : "";
                                        worksheet.Cells[rowIndex, cellIndex].Value = cellValue;
                                        cellIndex++;
                                    }
                                    rowIndex++;
                                }

                                FileInfo excelFile = new FileInfo(save.FileName);
                                excelPackage.SaveAs(excelFile);
                            }

                            MessageBox.Show("Export thành công", "Thông báo");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
                        }
                    }
                }
            }
        }
        private void Export_Word()
        {
            throw new NotImplementedException();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_NhomMau_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_PatientMore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // button sua for the add patient
        private void Button_Sua_Click(object sender, EventArgs e)
        {
            String name = textBox_Name.Text;
            String address = textBox_Address.Text;
            String contactText = textBox_Number.Text;
            int contact;
            String ageText = textBox_Age.Text;
            int Age;
            String blood = comboBox_NhomMau.Text;
            String cccdText = textBox_CCCD.Text;
            int cCCD;
            String history = textBox_TienSuBenh.Text;
            String yearText = textBox_Year.Text;
            int Year;
            String gender = comboBox1.Text;

            if (name.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhâp tên bệnh nhân");
            }
            else if (address.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhâp địa chỉ bệnh nhân");
            }
            else if (!int.TryParse(contactText, out contact) || contact <= 0)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại bệnh nhân hợp lệ");
            }
            else if (!int.TryParse(ageText, out Age) || Age <= 0)
            {
                MessageBox.Show("Vui lòng nhập số tuổi bệnh nhân hợp lệ");
            }
            else if (!int.TryParse(cccdText, out cCCD) || cCCD <= 0)
            {
                MessageBox.Show("Vui lòng nhập số Căn cước của bệnh nhân hợp lệ");
            }
            else if (!int.TryParse(yearText, out Year) || Year <= 0)
            {
                MessageBox.Show("Vui lòng nhập năm sinh của bệnh nhân hợp lệ");
            }
            else
            {


                try
                {
                    // Create a patient object
                    Patients updatedPatient = new Patients
                    {
                        CCCD = cCCD,
                        Name = name,
                        Gender = gender,
                        DayOfBirth = new DateTime(Year, 1, 1),
                        Contact = contact,
                        BloodGroup = blood,
                        History = history,
                        Address = address
                    };





                    // Update the existing patient in the database
                    modiffy.UpdatePatient(updatedPatient);

                    MessageBox.Show("Cập nhật bệnh nhân thành công");

                    // Refresh the DataGridView after updating patient
                    RefreshDataGridView();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        // button xoa for the add patient
        private void button_xoa_Click(object sender, EventArgs e)
        {
            String cccdText = textBox_CCCD.Text;
            int cCCD;

            if (!int.TryParse(cccdText, out cCCD) || cCCD <= 0)
            {
                MessageBox.Show("Vui lòng nhập số Căn cước của bệnh nhân hợp lệ");
            }
            else
            {
                try
                {
                    // Call the function to delete the patient
                    modiffy.DeletePatient(cCCD);

                    MessageBox.Show("Xóa bệnh nhân " + cCCD + " thành công !!");
                    RefreshDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewAdd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewAdd.SelectedRows.Count > 0)
            {
                // Assuming the columns in the DataGridView are in the same order as your fields

                // Set the value of textBox_CCCD using the content of the first column (Column 0)
                textBox_CCCD.Text = dataGridViewAdd.SelectedRows[0].Cells[0].Value.ToString(); // Column 0

                // Set the value of textBox_Name using the content of the second column (Column 1)
                textBox_Name.Text = dataGridViewAdd.SelectedRows[0].Cells[1].Value.ToString(); // Column 1

                // Set the value of textBox_Gender using the content of the third column (Column 2)
                comboBox1.Text = dataGridViewAdd.SelectedRows[0].Cells[2].Value.ToString(); // Column 2

                // Set the value of textBox_DayOfBirth using the content of the fourth column (Column 3)
                // Assuming textBox_Age is meant for age, as you didn't have textBox_Age in the provided code
                textBox_Age.Text = dataGridViewAdd.SelectedRows[0].Cells[3].Value.ToString(); // Column 3

                // Set the value of textBox_Contact using the content of the fifth column (Column 4)
                textBox_Number.Text = dataGridViewAdd.SelectedRows[0].Cells[4].Value.ToString(); // Column 4

                // Set the value of comboBox_NhomMau using the content of the sixth column (Column 5)
                comboBox_NhomMau.Text = dataGridViewAdd.SelectedRows[0].Cells[5].Value.ToString(); // Column 5

                // Set the value of textBox_History using the content of the seventh column (Column 6)
                textBox_TienSuBenh.Text = dataGridViewAdd.SelectedRows[0].Cells[6].Value.ToString(); // Column 6

                // Set the value of textBox_Address using the content of the eighth column (Column 7)
                textBox_Address.Text = dataGridViewAdd.SelectedRows[0].Cells[7].Value.ToString(); // Column 7

            }

        }

        private void C_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_Full_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox_KhoaKhambenh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_CanGiamSAt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Chandoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox_TrieuChung_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Year_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox_CCCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox_TienSuBenh_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Age_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Number_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void taiKhoanBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_Full_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_Full_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        ////// sua thong tin

        //private void button2_Click_1(object sender, EventArgs e)
        //{

        //}
        // xoa thong tin trong danh sach full

        private void button3_Click(object sender, EventArgs e)
        {
            //String DocIDText = textBox_.Text;
            //int docID;

            //if (!int.TryParse(DocIDText, out docID) || docID <= 0)
            //{
            //    MessageBox.Show("Vui lòng nhập số Căn cước của bệnh nhân hợp lệ");
            //}
            //else
            //{
            //    try
            //    {
            //        // Call the function to delete the patient
            //        modiffy.DeletePatient(docID);

            //        MessageBox.Show("Xóa bệnh nhân " + docID + " thành công !!");
            //        RefreshDataGridView();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
