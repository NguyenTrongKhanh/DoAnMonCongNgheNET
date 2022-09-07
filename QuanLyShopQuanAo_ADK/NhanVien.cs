using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ThuVien;

namespace QuanLyShopQuanAo_ADK
{
    class NhanVien:ThuVien1
    {
        public SqlDataAdapter ada_NhanVien = new SqlDataAdapter();
        DataColumn[] primaryKey = new DataColumn[1];

        public NhanVien()
        {
            string strSQl = "SELECT * FROM NhanVien";
            ada_NhanVien = getDataAdapter(strSQl, "NhanVien");
            primaryKey[0] = DSet.Tables["NhanVien"].Columns["MaNV"];
            DSet.Tables["NhanVien"].PrimaryKey = primaryKey;
        }
    }
}
