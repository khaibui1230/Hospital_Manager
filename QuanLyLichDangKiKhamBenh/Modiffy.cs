using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLichDangKiKhamBenh
{
    class Modiffy
    {


        public Modiffy()
        {
        }

        private SqlCommand sqlCommand; // dung de truy van cacs doi tuong insert, delete
        SqlDataReader dataReader; // doc du lieu trong bang
        public List<TaiKhoan> TaiKhoans(string query)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                // khai bao phuong thuc ket noi
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1)));

                }


                sqlConnection.Close();
            }
            return taiKhoans;

        }
        public void Command(string query) // dung để đăng kí tài khoản
        {
            SqlCommand sqlCommand = new SqlCommand();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();  // thuc thi cau truy vấn
                sqlConnection.Close();
            }
        }

        public List<Patients> AddPatients(string query)
        {
            List<Patients> patients = new List<Patients>();

            //

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                // khai bao phuong thuc ket noi
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    patients.Add(new Patients(
                        dataReader.GetInt32(0),      // CCCD
                        dataReader.GetString(1),     // Name
                        dataReader.GetString(2),     // Gender
                        dataReader.GetDateTime(3),   // DayOfBirth
                        dataReader.GetInt32(4),      // Contact
                        dataReader.GetInt32(5),      // Age
                        dataReader.GetString(6),     // BloodGroup
                        dataReader.GetString(8),     // History
                        dataReader.GetString(7)      // Address
                        ));
                }


                sqlConnection.Close();
            }
            return patients;
        }

        /// them benh nhan
        public void AddPatients(Patients patient)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();

                string query = "INSERT INTO Patients VALUES (@CCCD, @name, @gender, @Year, @contact, @blood, @history, @address)";

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@CCCD", patient.CCCD);
                    sqlCommand.Parameters.AddWithValue("@name", patient.Name);
                    sqlCommand.Parameters.AddWithValue("@gender", patient.Gender);
                    sqlCommand.Parameters.AddWithValue("@Year", patient.DayOfBirth);
                    sqlCommand.Parameters.AddWithValue("@contact", patient.Contact);
                    sqlCommand.Parameters.AddWithValue("@blood", patient.BloodGroup);
                    sqlCommand.Parameters.AddWithValue("@history", patient.History);
                    sqlCommand.Parameters.AddWithValue("@address", patient.Address);

                    sqlCommand.ExecuteNonQuery();
                }

                sqlConnection.Close();
            }
        }
    }
}
