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
    class ThongKe:ThuVien1  
    {
        public SqlDataAdapter ada_HoaDon = new SqlDataAdapter();
        DataColumn[] primaryKey = new DataColumn[1];
        public DataTable tLocKH = new DataTable();
        int stt = 0;
        public ThongKe()
        {
            string strSQl = "SELECT * FROM HoaDon";
            ada_HoaDon = getDataAdapter(strSQl, "HoaDon");
            primaryKey[0] = DSet.Tables["HoaDon"].Columns["MaHD"];
            DSet.Tables["HoaDon"].PrimaryKey = primaryKey;
        }
        public DataTable loadGirdView()
        {
            string strSQl = "SELECT * FROM HoaDon,NHANVIEN,KHACHHANG,LOAIKHACHHANG where HOADON.MaKH = KHACHHANG.MaKH and HOADON.MaNV = NHANVIEN.MaNV and HOADON.MaLoaiKH = LOAIKHACHHANG.MaLoai";
            return getDataTable(strSQl, "HoaDon");
        }
        public DataTable LocHoaDon_TenKH(string tenKH)
        {
            string strSQl = "SELECT * FROM HoaDon,NHANVIEN,KHACHHANG,LOAIKHACHHANG where HOADON.MaKH = KHACHHANG.MaKH and HOADON.MaNV = NHANVIEN.MaNV and HOADON.MaLoaiKH = LOAIKHACHHANG.MaLoai and TenKH like N'" + tenKH + "%'";
            stt++;
            return getDataTable(strSQl, "HoaDon"+stt);
        }
        public DataTable LocHoaDon_MaHD(int MaHD)
        {
            string strSQl = "SELECT * FROM HoaDon,NHANVIEN,KHACHHANG,LOAIKHACHHANG where HOADON.MaKH = KHACHHANG.MaKH and HOADON.MaNV = NHANVIEN.MaNV and HOADON.MaLoaiKH = LOAIKHACHHANG.MaLoai and HOADON.MaHD = '" + MaHD + "'";
            stt++;
            return getDataTable(strSQl, "HoaDon" + stt);
        }
        public DataTable LocHoaDon_NgayHD(string ngayHD)
        {
            string strSQl = "SELECT * FROM HoaDon,NHANVIEN,KHACHHANG,LOAIKHACHHANG where HOADON.MaKH = KHACHHANG.MaKH and HOADON.MaNV = NHANVIEN.MaNV and HOADON.MaLoaiKH = LOAIKHACHHANG.MaLoai and HOADON.ThoiGian BETWEEN '" + ngayHD + " 00:00:00' AND '" + ngayHD + " 23:59:59'";
            stt++;
            return getDataTable(strSQl, "HoaDon" + stt);
        }
        public DataTable LocHoaDon_TatCa(string tenKH, int maHD, string ngayHD)
        {
            string strSQl = "SELECT * FROM HoaDon,NHANVIEN,KHACHHANG,LOAIKHACHHANG where HOADON.MaKH = KHACHHANG.MaKH and HOADON.MaNV = NHANVIEN.MaNV and HOADON.MaLoaiKH = LOAIKHACHHANG.MaLoai and HOADON.ThoiGian BETWEEN '" + ngayHD + " 00:00:00' AND '" + ngayHD + " 23:59:59' and HOADON.MaHD = '" + maHD + "' and TenKH like N'" + tenKH + "%'";
            stt++;
            return getDataTable(strSQl, "HoaDon" + stt);
        }

        public static object MaHD { get; set; }
    }
}
