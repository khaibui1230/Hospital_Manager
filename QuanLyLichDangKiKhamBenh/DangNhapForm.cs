namespace QuanLyLichDangKiKhamBenh
{
    public partial class DangNhapForm : Form
    {
        public DangNhapForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void DangNhapForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        Modiffy modiffy = new Modiffy();
        private void DangnhapBtn_Click(object sender, EventArgs e)
        {
            string tentk = textBox_TenTaiKhoan.Text;
            string matkhau = textBox_MatKhau.Text;
            if (tentk.Trim() == "")
            {
                MessageBox.Show("Vui long nhap ten tài khoản");
            }
            else if(matkhau.Trim() == "")
            {
                MessageBox.Show("Vui long nhap mat khau"); 
            }
            else
            {
                string query = "Select* from TaiKhoan where TenTaiKhoan = '" + tentk + "' and MatKhau = '" + matkhau+"'";
                if(modiffy.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Dang nhap thanh cong");
                    // vao trang chu khi dang nhap thanh cong

                    Home home = new Home();
                    home.ShowDialog();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ten tai khoan hoac mật khẩu không chính xác ");
                }
            }
            
            
        }

        private void TenTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void MatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void DangKiLinkLB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKyForm dangKyForm= new DangKyForm();
            dangKyForm.ShowDialog();

            // an box vua moi tao
            this.Hide();
        }

        private void LinkLb_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhauForm quenMatKhauForm= new QuenMatKhauForm();
            quenMatKhauForm.ShowDialog();

            this.Hide();    
        }
    }
}