using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLichDangKiKhamBenh
{
    public partial class DangKyForm : Form
    {
        public DangKyForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DangnhapBtn_Click(object sender, EventArgs e)
        {

        }
        public bool checkedAccount(string ac) // check tai khaon va mat khau
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool checkedEmail(string em) // check email
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com$");
        }

        Modiffy modiffy = new Modiffy();

        private void Button_DangKi_Click(object sender, EventArgs e)
        {
            string tentk = textBox_TenTaiKhoan.Text;
            string matkhau = textBox_MatKhau.Text;
            string xnmatkhau = textBox_XacThuc.Text;
            string email = textBox_Email.Text;
            if (!checkedAccount(tentk))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản dài 6 -24 kí tự, với các kí tự chữ hoa và thường");
                return;
            }
            if (!checkedAccount(matkhau))
            {
                MessageBox.Show("Vui lòng nhập mat khau dài 6 -24 kí tự, với các kí tự chữ hoa và thường");
                return;
            }
            if (xnmatkhau != matkhau)
            {
                MessageBox.Show("Mật khẩu không khớp");
                return;
            }
            if (!checkedEmail(email))
            {
                MessageBox.Show("Định dạng Email không đúng");
            }
            if(modiffy.TaiKhoans("Select * from TaiKhoan where Email = '" + email + "'").Count() != 0) 
            {
                MessageBox.Show("Email này đã được đăng kí");
                return;
            }
            try
            {
                // check nguoi sử dụng có trùng không
                string query = " Insert into TaiKhoan values ('" + tentk + "','" + matkhau + "','" + email + "')";
                modiffy.Command(query);

                if (MessageBox.Show("Đăng ký thành công. Bạn có muốn đăng nhập không ?", "Thông báo", 
                    MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes) ;
                {
                    this.Close();
                    DangNhapForm dangNhapForm = new DangNhapForm();
                    dangNhapForm.Show();

                    this.Hide();
                }

            }catch {
                MessageBox.Show(" Tên Tài khoản đã được đăng kí, Vui lòng nhập tên tài khoản khác, hoặc đăng nhập");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangNhapForm dangNhapForm = new DangNhapForm();
            dangNhapForm.Show();

            this.Hide();
        }
    }
}
