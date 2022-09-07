using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopQuanAo_ADK
{
    public partial class frmHoaDon : Form
    {
        DataColumn[] primaryKey;
        DataTable tSP;
        DataTable tKH;
        DataTable tLocKH;
        DataTable tChiTiet;
        HoaDon HD = new HoaDon();
        int MaCTHD;

        public frmHoaDon()
        {
            InitializeComponent();
            primaryKey = new DataColumn[1];
            tSP = new DataTable();
            tKH = new DataTable();
            tLocKH = new DataTable();
            tChiTiet = new DataTable();
            styleGridViewHoaDonSP();
            styleGridViewSanPham();
            lblEmpName.Text = LoginInfo.TenNhanVien.ToString();
            txtGia.Enabled = false;
            btnLuu.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
        }
        public void styleGridViewSanPham()
        {
            dgvSanPham.AutoGenerateColumns = false;
            dgvSanPham.Columns["TenSP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSanPham.Columns["SoLuongTon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSanPham.Columns["DonGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvSanPham.EnableHeadersVisualStyles = false; //Bắt buộc phải có dòng này!
            dgvSanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSanPham.ColumnHeadersDefaultCellStyle.ForeColor = Color.Green;
            dgvSanPham.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvSanPham.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
        }
        public void styleGridViewHoaDonSP()
        {
            dgvHoaDonSP.AutoGenerateColumns = false;
            dgvHoaDonSP.Columns["TenSanPham"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHoaDonSP.Columns["SoLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHoaDonSP.Columns["DonGia1"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



            dgvHoaDonSP.EnableHeadersVisualStyles = false; //Bắt buộc phải có dòng này!
            dgvHoaDonSP.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHoaDonSP.ColumnHeadersDefaultCellStyle.ForeColor = Color.Green;
            dgvHoaDonSP.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvHoaDonSP.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
        }
        
        public void Load_Data()
        {
            string strSQL = "SELECT * FROM KhachHang";
            tKH = HD.getDataTable(strSQL, "KhachHang");
            primaryKey[0] = HD.DSet.Tables["KhachHang"].Columns["MaKH"];
            HD.DSet.Tables["KhachHang"].PrimaryKey = primaryKey;
        }
        public void LoadGridView_SanPham()
        {
            tSP = HD.DSet.Tables["SANPHAM"];
            dgvSanPham.DataSource = tSP;
            DataBindings_SanPham(tSP);
        }

        public void LoadGridView_ChiTietHoaDon(DataTable HoaDon)
        {
            tChiTiet = HD.DSet.Tables["HoaDon"];
            dgvHoaDonSP.DataSource = tChiTiet;
        }
        public void LoadGridView_ChiTietHoaDon()
        {
            int n=HD.DSet.Tables["HoaDon"].Rows.Count;
            tChiTiet = HD.LayChiTietHoaDon(n);
            dgvHoaDonSP.DataSource = tChiTiet;
        }

        public void DataBindings_SanPham(DataTable pDataTable)
        {
            txtTenSP.DataBindings.Clear();
            txtSoLuong.DataBindings.Clear();
            txtGia.DataBindings.Clear();
            txtMaSP.DataBindings.Clear();
            txtTenSP.DataBindings.Add("Text", pDataTable, "TenSP", true, DataSourceUpdateMode.Never);
            txtSoLuong.Text = "1";
            txtGia.DataBindings.Add("Text", pDataTable, "DonGia", true, DataSourceUpdateMode.Never);
            txtMaSP.DataBindings.Add("Text", pDataTable, "MaSP", true, DataSourceUpdateMode.Never);
        }

        void loadComboBox_KH() 
        {
            cboMaKH.DataSource = tKH;
            cboMaKH.DisplayMember = "TenKH";
            cboMaKH.ValueMember = "MaKH";
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            Load_Data();
            loadComboBox_KH();
            LoadGridView_SanPham();
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            frmDangNhap obj = new frmDangNhap();
            obj.Show();
            this.Hide();
        }

        private void lblKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang obj = new frmKhachHang();
            obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            frmNhanVien obj = new frmNhanVien();
            obj.Show();
            this.Hide();
        }

        private void lblSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham obj = new frmSanPham();
            obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            frmHome obj = new frmHome();
            obj.Show();
            this.Hide();
        }


        private void btnLocKH_Click(object sender, EventArgs e)
        {
            string temp = cboMaKH.Text;
            cboMaKH.DataSource = HD.LocKhachHang(temp);
        }


        private void btnTaoHDMoi_Click(object sender, EventArgs e)
        {
            int maHD = HD.DSet.Tables["HoaDon"].Rows.Count + 1;
            int maNV = LoginInfo.MaNhanVien;
            int maKH = int.Parse(cboMaKH.SelectedValue.ToString());
            int maLoaiKH = HD.layMaLoaiKH(maKH);
            DateTime thoiGian = DateTime.Now;
            int kt = HD.ThemHoaDonMoi(maHD, maNV, maKH, maLoaiKH, thoiGian);
            if(kt == 1)
            {
                dgvHoaDonSP.DataSource = null;
                dgvHoaDonSP.Refresh();
                btnLuu.Enabled = true;
                MessageBox.Show("Đã tạo một hoá đơn mới");
                btnTaoHDMoi.Enabled = false;
                txtSoLuong.Enabled = txtTenSP.Enabled = txtMaSP.Enabled = true;
            }
            else if (kt == 0)
            {
                MessageBox.Show("Hoá đơn đã tồn tại");
            }
            else
            {
                MessageBox.Show("Bị lỗi hãy thử lại");
            }
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int maHD = HD.DSet.Tables["HoaDon"].Rows.Count;
            int SL = int.Parse(txtSoLuong.Text);
            int DonGia = int.Parse(txtGia.Text);
            int maSP = int.Parse(txtMaSP.Text);
            int maCTHD = HD.DSet.Tables["ChiTietHoaDon"].Rows.Count + 1;
            int kt = HD.ThemChiTietHoaDon(maHD, maSP, SL, DonGia, maCTHD);
            if (kt == 1)
            {
                MessageBox.Show("Đã thêm thành công");
                LoadGridView_ChiTietHoaDon();
            }
            else if (kt == 0)
            {
                MessageBox.Show("Sản phẩm đã có trong hoá đơn rồi!");
            }
            else
            {
                MessageBox.Show("Bị lỗi hãy thử lại");
            }
        }

        private void btnLocSP_Click(object sender, EventArgs e)
        {
            string temp = txtMaSP.Text;
            dgvSanPham.DataSource = HD.LocSanPham(temp);
        }

        private void btnLocSP_Ten_Click(object sender, EventArgs e)
        {
            string temp = txtTenSP.Text;
            dgvSanPham.DataSource = HD.LocSanPham_Ten(temp);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int kt = HD.XoaChiTietSanPham(MaCTHD);
            if (kt == 1)
            {
                MessageBox.Show("Đã xoá thành công");
                LoadGridView_ChiTietHoaDon();
                btnXoa.Enabled = false;
                txtSoLuong.Enabled = txtTenSP.Enabled = txtMaSP.Enabled = true;
            }
            else if (kt == 0)
            {
                MessageBox.Show("Sản phẩm không có trong hoá đơn rồi!");
            }
            else
            {
                MessageBox.Show("Bị lỗi hãy thử lại");
            }
        }

        private void dgvHoaDonSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenSP.Text = dgvHoaDonSP.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSoLuong.Text = dgvHoaDonSP.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtGia.Text = dgvHoaDonSP.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtMaSP.Text = dgvHoaDonSP.Rows[e.RowIndex].Cells[3].Value.ToString();
            MaCTHD = int.Parse(dgvHoaDonSP.Rows[e.RowIndex].Cells[4].Value.ToString());
            btnSua.Enabled = btnXoa.Enabled = true;
            txtMaSP.Enabled = txtTenSP.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int SL = int.Parse(txtSoLuong.Text);
            int kt = HD.SuaChiTietSanPham(MaCTHD, SL);
            if (kt == 1)
            {
                MessageBox.Show("Đã sửa thành công");
                LoadGridView_ChiTietHoaDon();
                btnSua.Enabled = false;
                txtSoLuong.Enabled = txtTenSP.Enabled = txtMaSP.Enabled = true;
            }
            else if (kt == 0)
            {
                MessageBox.Show("Sản phẩm chưa có trong hoá đơn rồi!");
            }
            else
            {
                MessageBox.Show("Bị lỗi hãy thử lại");
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmXuatHoaDon obj = new frmXuatHoaDon();
            obj.Show();
            btnTaoHDMoi.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmThongKe obj = new frmThongKe();
            obj.Show();
            this.Hide();
        }

        private void dgvHoaDonSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenSP.Text = dgvHoaDonSP.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSoLuong.Text = dgvHoaDonSP.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtGia.Text = dgvHoaDonSP.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtMaSP.Text = dgvHoaDonSP.Rows[e.RowIndex].Cells[3].Value.ToString();
            MaCTHD = int.Parse(dgvHoaDonSP.Rows[e.RowIndex].Cells[4].Value.ToString());
            btnSua.Enabled = btnXoa.Enabled = true;
            txtMaSP.Enabled = txtTenSP.Enabled = false;
        }

    }
}
