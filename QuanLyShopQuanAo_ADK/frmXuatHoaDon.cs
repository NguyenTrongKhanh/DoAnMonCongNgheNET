using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien;
//using CrystalDecisions.CrystalReports.Engine;
//using CrystalDecisions.Shared;

namespace QuanLyShopQuanAo_ADK
{
    public partial class frmXuatHoaDon : Form
    {
        DataTable tHoaDon;
        ThuVien1 db = new ThuVien1();
        public frmXuatHoaDon()
        {
            InitializeComponent();
            tHoaDon = new DataTable();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            //int maHD = HoaDon.MaHD;
            //string strSQL = "SELECT hd.MaHD, hd.ThoiGian, nv.TenNV, sp.TenSP, kh.TenKH, cthd.SoLuong, cthd.DonGia from HOADON hd,CHITIETHOADON cthd,SANPHAM sp,KHACHHANG kh,NHANVIEN nv where hd.MaHD = cthd.MaHD and cthd.MaSP = sp.MaSP and hd.MaNV = nv.MaNV and hd.MaKH = kh.MaKH and hd.MaHD = '" + maHD + "'";
            //tHoaDon = db.getDataTable(strSQL,"XuatHoaDon");
            //rptXuatHoaDon rpt = new rptXuatHoaDon();

            //rpt.SetDataSource(tHoaDon);
            //crystalReportViewer1.ReportSource = rpt;
            //crystalReportViewer1.Refresh();
        }
    }
}
