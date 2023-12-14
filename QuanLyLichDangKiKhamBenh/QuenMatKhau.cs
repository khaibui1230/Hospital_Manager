using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLichDangKiKhamBenh
{
    public partial class QuenMatKhauForm : Form
    {
        private Modiffy modiffy; // Assuming you have a Modiffy class for database operations

        public QuenMatKhauForm()
        {
            InitializeComponent();
            modiffy = new Modiffy(); // Initialize your Modiffy class
        }



        //private void LayLaiMatKhauBtn_Click_1(object sender, EventArgs e)
        //{
        //    string email = textBox1.Text;

        //    // Check if the email exists in the database
        //    if (modiffy.TaiKhoans("SELECT * FROM TaiKhoan WHERE Email = '" + email + "'").Count() != 0)
        //    {
        //        // Generate a random code (you may want to make this more secure)
        //        string recoveryCode = GenerateRandomCode();

        //        // Send the recovery code to the user's email
        //        SendRecoveryCode(email, recoveryCode);

        //        MessageBox.Show("Mã code đã được gửi về email của bạn. Vui lòng kiểm tra email và nhập mã code để đặt lại mật khẩu.");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Email không tồn tại trong hệ thống.");
        //    }
        //}

        //private void SendRecoveryCode(string email, string recoveryCode)
        //{
        //    // Replace with your Gmail credentials
        //    string fromEmail = "Ngungoc7456321@gmail.com";
        //    string password = "";

        //    // Configure the SMTP client
        //    SmtpClient client = new SmtpClient("khaib.gmail.com")
        //    {
        //        Port = 587,
        //        Credentials = new NetworkCredential(fromEmail, password),
        //        EnableSsl = true,
        //    };

        //    // Email message
        //    MailMessage mail = new MailMessage(fromEmail, email, "Password Recovery Code", $"Your recovery code is: {recoveryCode}");

        //    // Send the email
        //    client.Send(mail);
        //}

        //private string GenerateRandomCode()
        //{
        //    // Generate a random 6-digit code (you may want to make this more secure)
        //    Random random = new Random();
        //    return random.Next(100000, 999999).ToString();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            if(email.Trim() == "")
            {
                MessageBox.Show("Vui lòn nhập email đã đăng kí");

            }
            else
            {
                string query = "SELECT * FROM TaiKhoan WHERE Email = '" + email + "'";
                if (modiffy.TaiKhoans(query).Count() != 0)
                {
                    label2.ForeColor= Color.Blue;
                    label2.Text = "Mật khẩu: " + modiffy.TaiKhoans(query)[0].MatKhau;

                }
                else
                {
                    label2.ForeColor= Color.Red;
                    label2.Text = "Email này chưa được đăng kí";
                }
            }


            //string XacThucCode = textBox_Otp.Text;
            //if(XacThucCode == GenerateRandomCode())
            //{
            //    MessageBox.Show("Mã code xác nhận đúng. Bạn có thể đặt lại mật khẩu");

            //    // Chuyển sang trang reset mật khẩu.

            //    // Prompt for entering the new password
            //    string newPassword = Microsoft.VisualBasic.Interaction.InputBox("Nhập mật khẩu mới:", "Đặt lại mật khẩu", "");

            //    // Check if the user entered a new password
            //    if (!string.IsNullOrWhiteSpace(newPassword))
            //    {
            //        // Prompt for confirming the new password
            //        string confirmPassword = Microsoft.VisualBasic.Interaction.InputBox("Nhập lại mật khẩu mới để xác nhận:", "Xác nhận mật khẩu", "");

            //        // Check if the passwords match
            //        if (newPassword == confirmPassword)
            //        {

            //            if (MessageBox.Show("Thay đổi mật khẩu thành công. Bạn có muốn đăng nhập không ?",
            //            "Thông báo",
            //        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) ;
            //            {
            //                this.Close();
            //                DangNhapForm dangNhapForm = new DangNhapForm();
            //                dangNhapForm.ShowDialog();

            //                this.Hide();
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Mật khẩu xác nhận không khớp. Vui lòng thử lại.");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Mật khẩu không được bỏ trống. Vui lòng thử lại.");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Mã code bị sai. Vui lòng kiểm tra lại");
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DangNhapForm dangNhapForm= new DangNhapForm();
            dangNhapForm.Show();

            this.Hide();
        }
    }
}
