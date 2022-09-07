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
    public partial class frmThongKe : Form
    {
        DataColumn[] primaryKey;
        ThongKe tk = new ThongKe();
        HoaDon HD = new HoaDon();
        DataTable tChiTiet;
        DataTable tLoc;
        public frmThongKe()
        {
            InitializeComponent();
            primaryKey = new DataColumn[1];
            tChiTiet = new DataTable();
            tLoc = new DataTable();
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
            lblEmpName.Text = LoginInfo.TenNhanVien.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaHD.Clear();
            txtTenKH.Clear();
            mtxtNgay.Clear();
        }
        public void LoadGridView_ChiTietHoaDon(int n)
        {
            tChiTiet = HD.LayChiTietHoaDon(n);
            dgvChiTiet.DataSource = tChiTiet;
        }
        private void dgvHoaDonSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string a = dgvHoaDonSP.Rows[e.RowIndex].Cells[0].Value.ToString();
            if(a==null)
            {
                return;
            }
            int n = int.Parse(a);
            LoadGridView_ChiTietHoaDon(n);
        }

        private void btnTimTheoTen_Click(object sender, EventArgs e)
        {
            string strTenKH = txtTenKH.Text;
            if (strTenKH == "")
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng");
                return;
            }
            tLoc = tk.LocHoaDon_TenKH(strTenKH);
            dgvHoaDonSP.DataSource = tLoc;
        }

        private void btnTimTheoMa_Click(object sender, EventArgs e)
        {
            string strMaHD = txtMaHD.Text;
            if (strMaHD == "")
            {
                MessageBox.Show("Bạn chưa nhập Mã hoá đơn");
                return;
            }
            int MaHD = int.Parse(strMaHD);
            tLoc = tk.LocHoaDon_MaHD(MaHD);
            dgvHoaDonSP.DataSource = tLoc;
        }

        private void btnTimTheoNgay_Click(object sender, EventArgs e)
        {
            string strNgayHD = DateTime.Parse(mtxtNgay.Text).ToString("yyyy/MM/dd");
            if (strNgayHD == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày hoá đơn");
                return;
            }
            tLoc = tk.LocHoaDon_NgayHD(strNgayHD);
            dgvHoaDonSP.DataSource = tLoc;
        }

        private void btnTimTheoTatCa_Click(object sender, EventArgs e)
        {
            string strNgayHD = DateTime.Parse(mtxtNgay.Text).ToString("yyyy/MM/dd");
            if (strNgayHD == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày hoá đơn");
                return;
            }
            string strMaHD = txtMaHD.Text;
            if(strMaHD == "")
            {
                MessageBox.Show("Bạn chưa nhập Mã hoá đơn");
                return;
            }
            int MaHD = int.Parse(strMaHD);
            string strTenKH = txtTenKH.Text;
            if (strTenKH == "")
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng");
                return;
            }
            tLoc = tk.LocHoaDon_TatCa(strTenKH,MaHD,strNgayHD);
            dgvHoaDonSP.DataSource = tLoc;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            frmHome obj = new frmHome();
            obj.Show();
            this.Hide();
        }

        private void lblSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham obj = new frmSanPham();
            obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            frmNhanVien obj = new frmNhanVien();
            obj.Show();
            this.Hide();
        }

        private void lblKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang obj = new frmKhachHang();
            obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmHoaDon obj = new frmHoaDon();
            obj.Show();
            this.Hide();
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            frmDangNhap obj = new frmDangNhap();
            obj.Show();
            this.Hide();
        }
    }
}
