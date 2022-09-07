using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopQuanAo_ADK
{
    public partial class frmGiaoDich : Form
    {
        DataColumn[] primaryKey;
        ThongKe tk = new ThongKe();
        public frmGiaoDich()
        {
            InitializeComponent();
            primaryKey = new DataColumn[1];
            styleGridViewGiaoDich();
            styleGridViewHoaDonSP();
        }
        public void styleGridViewGiaoDich()
        {
            dgvHoaDonSP.AutoGenerateColumns = false;
            dgvHoaDonSP.Columns["TenKhachHang"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHoaDonSP.Columns["TenNhanVien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHoaDonSP.Columns["TG"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHoaDonSP.Columns["Loai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHoaDonSP.Columns["MaHoaDon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvHoaDonSP.EnableHeadersVisualStyles = false; //Bắt buộc phải có dòng này!
            dgvHoaDonSP.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHoaDonSP.ColumnHeadersDefaultCellStyle.ForeColor = Color.Green;
            dgvHoaDonSP.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvHoaDonSP.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
        }
        public void styleGridViewHoaDonSP()
        {
            dgvChiTiet.AutoGenerateColumns = false;
            dgvChiTiet.Columns["TenSanPham"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvChiTiet.Columns["SoLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvChiTiet.Columns["DonGia1"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



            dgvChiTiet.EnableHeadersVisualStyles = false; //Bắt buộc phải có dòng này!
            dgvChiTiet.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvChiTiet.ColumnHeadersDefaultCellStyle.ForeColor = Color.Green;
            dgvChiTiet.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvChiTiet.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
        }
        
        public void LoadGridView_HoaDon()
        {
            tk.loadGirdView();
            dgvHoaDonSP.DataSource = tk.DSet.Tables["HoaDon"];
        }

        private void frmGiaoDich_Load(object sender, EventArgs e)
        {
            LoadGridView_HoaDon();
        }
    }
}
