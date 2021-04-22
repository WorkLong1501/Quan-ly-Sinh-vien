
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Diagnostics;
namespace CNQuanLySV
{
     class CommonConnect
    {
        //Phương thức kết nối chung 
        private SqlConnection conn;

        // Trả về đối tượng kết nối
        public SqlConnection Connected()
        {
            string conect = SystemInformation.UserDomainName.ToString();

            string source = @"server = DESKTOP-KMNS09Q;database = Quanlydiem_SV; uid =sa; pwd =sa";
            conn = new SqlConnection(source);
            conn.Open();
            return conn;
        }
    }
}