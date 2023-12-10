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

    }
}
