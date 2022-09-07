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
    class HoaDon:ThuVien1
    {
        public SqlDataAdapter ada_SanPham = new SqlDataAdapter();
        public SqlDataAdapter ada_HoaDon = new SqlDataAdapter();
        public SqlDataAdapter ada_ChiTietHoaDon = new SqlDataAdapter();
        public SqlDataAdapter ada_LoaiKH = new SqlDataAdapter();
        public SqlDataAdapter ada_NhanVien = new SqlDataAdapter();
        DataColumn[] primaryKey = new DataColumn[1];
        public int stt = 0;
        public DataTable tLocKH = new DataTable();
        public DataTable tLocSP = new DataTable();
        public static int MaHD;
        public HoaDon()
        {
            string strSQl = "  SELECT * FROM SanPham";
            ada_SanPham = getDataAdapter(strSQl, "SanPham");
            primaryKey[0] = DSet.Tables["SanPham"].Columns["MaSP"];
            DSet.Tables["SanPham"].PrimaryKey = primaryKey;

            strSQl = "  SELECT * FROM HoaDon";
            ada_HoaDon = getDataAdapter(strSQl, "HoaDon");
            primaryKey[0] = DSet.Tables["HoaDon"].Columns["MaHD"];
            DSet.Tables["HoaDon"].PrimaryKey = primaryKey;

            strSQl = "SELECT * FROM ChiTietHoaDon";
            ada_ChiTietHoaDon = getDataAdapter(strSQl, "ChiTietHoaDon");
            primaryKey[0] = DSet.Tables["ChiTietHoaDon"].Columns["MaCTHoaDon"];
            DSet.Tables["ChiTietHoaDon"].PrimaryKey = primaryKey;

            strSQl = "Select * from LoaiKhachHang";
            ada_LoaiKH = getDataAdapter(strSQl, "LoaiKhachHang");
            primaryKey[0] = DSet.Tables["LoaiKhachHang"].Columns["MaLoai"];
            DSet.Tables["LoaiKhachHang"].PrimaryKey = primaryKey;

            

        }
        public int layMaLoaiKH(int maKH)
        {
            string strSQL;
            strSQL = "Select * from LoaiKhachHang,KHACHHANG where  LOAIKHACHHANG.MaLoai = KHACHHANG.MaLoaiKH and KHACHHANG.MaKH = '" + maKH + "'";
            tLocKH = getDataTable(strSQL, "LoaiKhachHang");
            DataRow dr = DSet.Tables["LoaiKhachHang"].Rows.Find(maKH);
            int maLoai = int.Parse(dr["MaLoai"].ToString());
            return maLoai;
        }
        public DataTable LocKhachHang(string temp)
        {
            tLocKH = new DataTable();
            string strSQL = "SELECT * FROM KhachHang where TenKH like N'" + temp + "%'";
            tLocKH = getDataTable(strSQL, "tLocKH" + stt);
            stt++;
            return tLocKH;
        }
        public DataTable LocSanPham(string temp)
        {
            tLocSP = new DataTable();
            string strSQL = "SELECT * FROM SanPham where MaSP = '" + temp + "'";
            tLocSP = getDataTable(strSQL, "tLocKH" + stt);
            stt++;
            return tLocSP;
        }
        public DataTable LocSanPham_Ten(string temp)
        {
            tLocSP = new DataTable();
            string strSQL = "SELECT * FROM SanPham where TenSP like N'" + temp + "%'";
            tLocSP = getDataTable(strSQL, "tLocKH" + stt);
            stt++;
            return tLocSP;
        }
        public DataTable LayChiTietHoaDon(int MaHD)
        {
            tLocKH = new DataTable();
            string strSQL = "SELECT distinct * FROM ChiTietHoaDon,SanPham,HOADON where ChiTietHoaDon.MaSP = SanPham.MaSP and ChiTietHoaDon.MaHD = HOADON.MaHD and HOADON.MaHD = '" + MaHD + "'";
            tLocKH = getDataTable(strSQL, "ChiTietHoaDon"+stt);
            stt++;
            return tLocKH;
        }
        public int ThemChiTietHoaDon(int maHD, int maSP, int SoLuong, int donGia, int maCTHD)
        {
            try
            {
                string strSQL = "Select count (*) from ChiTietHoaDon where MaHD = '" + maHD + "' and maSP ='" + maSP + "'";
                int dem = getCount(strSQL);
                if (dem != 0)
                {
                    return 0;
                }
                DataRow newRow = DSet.Tables["ChiTietHoaDon"].NewRow();
                newRow["MaCTHoaDon"] = maCTHD;
                newRow["MaHD"] = maHD;
                newRow["MaSP"] = maSP;
                newRow["SoLuong"] = SoLuong;
                newRow["DonGia"] = donGia;
                DSet.Tables["ChiTietHoaDon"].Rows.Add(newRow);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(ada_ChiTietHoaDon);
                ada_ChiTietHoaDon.Update(DSet, "ChiTietHoaDon");
                return 1;
            }
            catch
            {
                return 2;

            }
        }
        public int ThemHoaDonMoi(int maHD, int maNV, int maKH, int MaLoaiKH, DateTime ThoiGian)
        {
            try
            {
                DataRow existRow = DSet.Tables["HoaDon"].Rows.Find(maHD);
                if (existRow != null)
                {
                    return 0;
                }
                DataRow newRow = DSet.Tables["HoaDon"].NewRow();
                newRow["MaHD"] = maHD;
                newRow["MaNV"] = maNV;
                newRow["MaKH"] = maKH;
                newRow["MaLoaiKH"] = MaLoaiKH;
                newRow["ThoiGian"] = ThoiGian;
                DSet.Tables["HoaDon"].Rows.Add(newRow);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(ada_HoaDon);
                ada_HoaDon.Update(DSet, "HoaDon");
                MaHD = maHD;
                return 1;
            }
            catch
            {
                return 2;

            }
        }
        public int SuaChiTietSanPham(int MaCTHD, int soLuong)
        {
            try
            {
                DataRow updateRow = DSet.Tables["ChiTietHoaDon"].Rows.Find(MaCTHD);
                if (updateRow == null)
                {
                    return 0;
                }
                updateRow["SoLuong"] = soLuong;
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(ada_ChiTietHoaDon);
                ada_ChiTietHoaDon.Update(DSet, "ChiTietHoaDon");
                return 1;
            }
            catch
            {
                return 2;

            }
        }
        public int XoaChiTietSanPham(int maCTHD)
        {
            try
            {
                DataRow deleteRow = DSet.Tables["ChiTietHoaDon"].Rows.Find(maCTHD);
                if (deleteRow == null)
                {
                    return 0;
                }
                deleteRow.Delete();
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(ada_ChiTietHoaDon);
                ada_ChiTietHoaDon.Update(DSet, "ChiTietHoaDon");
                return 1;
            }
            catch
            {
                return 2;

            }
        }
    }
}
