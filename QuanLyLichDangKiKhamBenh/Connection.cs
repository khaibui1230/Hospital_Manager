using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyLichDangKiKhamBenh
{
    class Connection
    {
        private const string connectionString = @"Data Source=KHAIBUI\MSSQLSERVER02;Initial Catalog=QLDangKiKhamBenh;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
