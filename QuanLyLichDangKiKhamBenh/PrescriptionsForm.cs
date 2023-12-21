using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLichDangKiKhamBenh
{
    public partial class PrescriptionsForm : Form
    {
        public PrescriptionsForm()
        {
            InitializeComponent();
        }

        private static Patients selectedPatients;
        private prescription prescription;
        private void SelectedPatient(Patients patients)
        {
            selectedPatients = patients;

            textBox_IdCuaBenhNha.Text = selectedPatients.Name;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Xử lý thêm thông tin thuốc vào đơn thuốc
            Medication medication = new Medication
            {
                MedicineName = textBox_TenThuoc.Text,
                Dosage = Convert.ToInt32(textBox_LieuLuong.Text),
                UsageInstructions = textBox_CachSuDung.Text
            };

            prescription.Medications.Add(medication);

            // Hiển thị thông tin thuốc trong DataGridView hoặc ListBox tương ứng
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = prescription.Medications;
        }
    }
}
