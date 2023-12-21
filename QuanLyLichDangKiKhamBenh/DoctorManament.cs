using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyLichDangKiKhamBenh
{
    public partial class DoctorManament : Form
    {
        public DoctorManament()
        {
            InitializeComponent();
            RefreshDataGridView();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();

            this.Hide();
        }
        Modiffy modiffy = new Modiffy();
        private void button_Them_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các control trên form
            string docName = textBox_NameDoctor.Text;
            string docIDText = textBox_DoctorId.Text;
            int docID;
            string docExpText = textBoxExp.Text;
            int docExp;
            string docGender = comboBox_Gen.Text;
            string docSpec = textBox_Spec.Text;
            string docPass = textBox_Pass.Text;

            // Kiểm tra thông tin đầu vào
            if (docName.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên bác sĩ");
            }
            else if (docSpec.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập chuyên khoa của bác sĩ");
            }
            else if (!int.TryParse(docIDText, out docID) || docID <= 0)
            {
                MessageBox.Show("Vui lòng nhập mã bác sĩ hợp lệ");
            }
            else if (!int.TryParse(docExpText, out docExp) || docExp <= 0)
            {
                MessageBox.Show("Vui lòng nhập số năm kinh nghiệm của bác sĩ hợp lệ");
            }
            else
            {
                try
                {
                    // Tạo một đối tượng Doctor mới
                    Doctor newDoctor = new Doctor
                    {
                        DocName = docName,
                        DocExp = docExp,
                        Gender = docGender,
                        DocID = docID,
                        DocSpec = docSpec,
                        DocPass = docPass
                    };

                    // Kiểm tra xem bác sĩ đã tồn tại chưa bằng cách truy vấn cơ sở dữ liệu
                    string queryCheckDocName = "SELECT COUNT(*) FROM Doctor WHERE DocName = @DocName";
                    using (SqlConnection sqlConnection = Connection.GetSqlConnection())
                    {
                        sqlConnection.Open();

                        using (SqlCommand sqlCommandCheckDocName = new SqlCommand(queryCheckDocName, sqlConnection))
                        {
                            sqlCommandCheckDocName.Parameters.AddWithValue("@DocName", docName);

                            int existingCount = (int)sqlCommandCheckDocName.ExecuteScalar();

                            if (existingCount > 0)
                            {
                                // Bác sĩ đã tồn tại
                                MessageBox.Show("Bác sĩ này đã đăng ký");
                                return;
                            }
                        }
                    }
                    // them bac si

                    modiffy.AddDoctor(newDoctor);

                    MessageBox.Show("Thêm bác sĩ thành công");

                    // Cập nhật sau khi thêm bác sĩ
                    RefreshDataGridView();

                    // Xóa các trường nhập liệu
                    ClearDoctorInputFields();

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
                cmd.CommandText = "select * from Doctor ";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                DA.Fill(dataSet);
                dataGridView_Doctor.DataSource = dataSet.Tables[0];
                sql.Close();
            }
        }

        private void ClearDoctorInputFields()
        {
            textBox_NameDoctor.Clear();
            textBox_DoctorId.Clear();
            textBoxExp.Clear();
            comboBox_Gen.Items.Clear();
            textBox_Spec.Clear();
            textBox_Pass.Clear();
        }

        private void dataGridView_Doctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Doctor.SelectedRows.Count > 0)
            {
                // Assuming the columns in the DataGridView are in the same order as your fields

                // Set the value of textBox_CCCD using the content of the first column (Column 0)
                textBox_DoctorId.Text = dataGridView_Doctor.SelectedRows[0].Cells[0].Value.ToString(); // Column 0

                // Set the value of textBox_Name using the content of the second column (Column 1)
                textBox_NameDoctor.Text = dataGridView_Doctor.SelectedRows[0].Cells[1].Value.ToString(); // Column 1

                // Set the value of textBox_Gender using the content of the third column (Column 2)
                textBoxExp.Text = dataGridView_Doctor.SelectedRows[0].Cells[2].Value.ToString(); // Column 2

                // Set the value of textBox_DayOfBirth using the content of the fourth column (Column 3)
                // Assuming textBox_Age is meant for age, as you didn't have textBox_Age in the provided code
                comboBox_Gen.Text = dataGridView_Doctor.SelectedRows[0].Cells[3].Value.ToString(); // Column 3

                // Set the value of textBox_Contact using the content of the fifth column (Column 4)
                textBox_Spec.Text = dataGridView_Doctor.SelectedRows[0].Cells[4].Value.ToString(); // Column 4

                // Set the value of comboBox_NhomMau using the content of the sixth column (Column 5)
                textBox_Pass.Text = dataGridView_Doctor.SelectedRows[0].Cells[5].Value.ToString(); // Column 5



            }
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các control trên form
            string docName = textBox_NameDoctor.Text;
            string docIDText = textBox_DoctorId.Text;
            int docID;
            string docExpText = textBoxExp.Text;
            int docExp;
            string docGender = comboBox_Gen.Text;
            string docSpec = textBox_Spec.Text;
            string docPass = textBox_Pass.Text;

            // Kiểm tra thông tin đầu vào
            if (docName.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên bác sĩ");
            }
            else if (docSpec.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập chuyên khoa của bác sĩ");
            }
            else if (!int.TryParse(docIDText, out docID) || docID <= 0)
            {
                MessageBox.Show("Vui lòng nhập mã bác sĩ hợp lệ");
            }
            else if (!int.TryParse(docExpText, out docExp) || docExp <= 0)
            {
                MessageBox.Show("Vui lòng nhập số năm kinh nghiệm của bác sĩ hợp lệ");
            }
            else
            {
                try
                {
                    // Tạo một đối tượng Doctor mới
                    Doctor newDoctor = new Doctor
                    {
                        DocName = docName,
                        DocExp = docExp,
                        Gender = docGender,
                        DocID = docID,
                        DocSpec = docSpec,
                        DocPass = docPass
                    };

                    //// Kiểm tra xem bác sĩ đã tồn tại chưa bằng cách truy vấn cơ sở dữ liệu
                    //string queryCheckDocName = "SELECT COUNT(*) FROM Doctor WHERE DocName = @DocName";
                    //using (SqlConnection sqlConnection = Connection.GetSqlConnection())
                    //{
                    //    sqlConnection.Open();

                    //    using (SqlCommand sqlCommandCheckDocName = new SqlCommand(queryCheckDocName, sqlConnection))
                    //    {
                    //        sqlCommandCheckDocName.Parameters.AddWithValue("@DocName", docName);

                    //        int existingCount = (int)sqlCommandCheckDocName.ExecuteScalar();

                    //        if (existingCount > 0)
                    //        {
                    //            // Bác sĩ đã tồn tại
                    //            MessageBox.Show("Bác sĩ này đã đăng ký");
                    //            return;
                    //        }
                    //    }
                    //}
                    // them bac si

                    modiffy.UpdateDoctor(newDoctor);

                    MessageBox.Show("sửa bác sĩ thành công");

                    // Cập nhật sau khi thêm bác sĩ
                    RefreshDataGridView();

                    // Xóa các trường nhập liệu
                    ClearDoctorInputFields();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            String DocIDText = textBox_DoctorId.Text;
            int docID;

            if (!int.TryParse(DocIDText, out docID) || docID <= 0)
            {
                MessageBox.Show("Vui lòng nhập Id bác sĩ  hợp lệ");
            }
            else
            {
                try
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc sẽ xóa bác sĩ " + docID + " không?", "Xác nhận xóa bác sĩ", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        // Call the function to delete the doctor
                        modiffy.DeleteDoctor(docID);

                        MessageBox.Show("Xóa bác sĩ " + docID + " thành công !!");

                        // Refresh your DataGridView after deletion
                        RefreshDataGridView();
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

