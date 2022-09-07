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
    class NguoiDung:ThuVien1
    {
        public SqlDataAdapter ada_NguoiDung = new SqlDataAdapter();
        public SqlDataAdapter ada_NhanVien = new SqlDataAdapter();
        DataColumn[] primaryKey = new DataColumn[1];
        DataRow dr;
        public static int MaNhanVien;
        public static string TenNhanVien;
        public NguoiDung()
        {
            string strSQl = "SELECT * FROM NguoiDung";
            ada_NguoiDung = getDataAdapter(strSQl, "NguoiDung");
            primaryKey[0] = DSet.Tables["NguoiDung"].Columns["MaNguoiDung"];
            DSet.Tables["NguoiDung"].PrimaryKey = primaryKey;

            strSQl = "Select * from NhanVien";
            ada_NhanVien = getDataAdapter(strSQl, "NhanVien");
            primaryKey[0] = DSet.Tables["NhanVien"].Columns["MaNV"];
            DSet.Tables["NhanVien"].PrimaryKey = primaryKey;
        }
        public int DangNhap(string tenDN, string matKhau)
        {
            string strSQl = "SELECT COUNT(*) FROM NguoiDung where TenDangNhap = '" + tenDN + "' AND MatKhau = '" + matKhau +"'";
            int dem  = getCount(strSQl);
            if (dem == 1)
            {
                strSQl = "SELECT * FROM NguoiDung where TenDangNhap = '" + tenDN + "' AND MatKhau = '" + matKhau + "'";
                dr = DSet.Tables["NguoiDung"].Rows[getCount(strSQl)];
                MaNhanVien = int.Parse(dr["MaNV"].ToString());
                strSQl = "SELECT * FROM NhanVien where MaNV = '" + MaNhanVien + "'";
                dr = DSet.Tables["NhanVien"].Rows[getCount(strSQl)];
                TenNhanVien = (dr["TenNV"].ToString());
                return 1;
            }
            else
            {
                return 0;
            }
            
        }
 
    }
    public static class LoginInfo
    {
        public static int MaNhanVien=NguoiDung.MaNhanVien;
        public static string TenNhanVien = NguoiDung.TenNhanVien;    
    }
}