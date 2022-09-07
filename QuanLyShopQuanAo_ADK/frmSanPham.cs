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

using ThuVien;

namespace QuanLyShopQuanAo_ADK
{
    public partial class frmSanPham : Form
    {
        ThuVien1 db;
        SqlDataAdapter ada_SanPham;
        DataColumn[] primaryKey;
        public frmSanPham()
        {
            InitializeComponent();
            db = new ThuVien1();
            ada_SanPham = new SqlDataAdapter();
            primaryKey = new DataColumn[1];
        }
        public void Load_Data()
        {
            string strSQL = "SELECT * FROM dbo.SanPham";
            ada_SanPham = db.getDataAdapter(strSQL, "dbo.SanPham");
            //Thêm khóa chính cho bảng tblKhoa
            primaryKey[0] = db.DSet.Tables["dbo.SanPham"].Columns["MaSP"];
            db.DSet.Tables["dbo.SanPham"].PrimaryKey = primaryKey;
            //Binding dữ liệu giữa DataSet và Textbox
            DataBinding(db.DSet.Tables["dbo.SanPham"]);
        }

        public void LoadGridView_SanPham()
        {
            grvSanPham.DataSource = db.DSet.Tables["dbo.SanPham"];
            grvSanPham.Columns[0].HeaderText = "Mã SP";
            grvSanPham.Columns[1].HeaderText = "Tên SP";
            grvSanPham.Columns[2].HeaderText = "Hình Ảnh";
            grvSanPham.Columns[3].HeaderText = "Trạng Thái";
            grvSanPham.Columns[4].HeaderText = "ĐơnGiá";
            grvSanPham.Columns[5].HeaderText = "Số Lượng";
            grvSanPham.Columns[6].HeaderText = "Chất Liệu";
            grvSanPham.Columns[7].HeaderText = "Loại";
            grvSanPham.Columns[8].HeaderText = "NSX";
            grvSanPham.Columns[0].Width = 50;
            grvSanPham.Columns[1].Width = 110;
            grvSanPham.Columns[3].Width = 98;
            grvSanPham.Columns[5].Width = 70;
            grvSanPham.Columns[6].Width = 50;
            grvSanPham.Columns[7].Width = 50;
            grvSanPham.Columns[8].Width = 50;
            grvSanPham.Columns[4].Width = 70;
            grvSanPham.EnableHeadersVisualStyles = false; //Bắt buộc phải có dòng này!
            grvSanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvSanPham.ColumnHeadersDefaultCellStyle.ForeColor = Color.Green;
            grvSanPham.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            grvSanPham.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
        }

        public void DataBinding(DataTable pDataTable)
        {
            txtMaSP.DataBindings.Clear();
            Binding dataBinding1 = new Binding("Text", pDataTable, "MaSP", true, DataSourceUpdateMode.Never);
            txtMaSP.DataBindings.Add(dataBinding1);

            txtTenSP.DataBindings.Clear();
            Binding dataBinding2 = new Binding("Text", pDataTable, "TenSP", true, DataSourceUpdateMode.Never);
            txtTenSP.DataBindings.Add(dataBinding2);

            txtTrangThai.DataBindings.Clear();
            Binding dataBinding3 = new Binding("Text", pDataTable, "TrangThai", true, DataSourceUpdateMode.Never);
            txtTrangThai.DataBindings.Add(dataBinding3);

            txtGia.DataBindings.Clear();
            Binding dataBinding4 = new Binding("Text", pDataTable, "DonGia", true, DataSourceUpdateMode.Never);
            txtGia.DataBindings.Add(dataBinding4);

            txtSoLuong.DataBindings.Clear();
            Binding dataBinding5 = new Binding("Text", pDataTable, "SoLuongTon", true, DataSourceUpdateMode.Never);
            txtSoLuong.DataBindings.Add(dataBinding5);

            txtChatLieu.DataBindings.Clear();
            Binding dataBinding6 = new Binding("Text", pDataTable, "MaChatLieu", true, DataSourceUpdateMode.Never);
            txtChatLieu.DataBindings.Add(dataBinding6);

            txtLoai.DataBindings.Clear();
            Binding dataBinding7 = new Binding("Text", pDataTable, "MaLoai", true, DataSourceUpdateMode.Never);
            txtLoai.DataBindings.Add(dataBinding7);

            txtNSX.DataBindings.Clear();
            Binding dataBinding8 = new Binding("Text", pDataTable, "MaNSX", true, DataSourceUpdateMode.Never);
            txtNSX.DataBindings.Add(dataBinding8);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            Load_Data();
            lblEmpName.Text = LoginInfo.TenNhanVien.ToString();
            LoadGridView_SanPham();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string strMaSP = txtMaSP.Text.Trim();
            string strTenSP = txtTenSP.Text.Trim();
            string strTrangThai = txtTrangThai.Text.Trim();
            string strDonGia = txtGia.Text.Trim();
            string strSoLuong = txtSoLuong.Text.Trim();
            string strChatLieu = txtChatLieu.Text.Trim();
            string strLoai = txtLoai.Text.Trim();
            string strNSX = txtNSX.Text.Trim();

            if (strMaSP == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập " + lblMaSP.Text);
                txtMaSP.Focus();
                return;
            }
            if (strTenSP == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập " + lblTenSP.Text);
                txtTenSP.Focus();
                return;
            }
            if (strTrangThai == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập " + lblTrangThai.Text);
                txtTrangThai.Focus();
                return;
            }
            if (strDonGia == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập " + lblGia.Text);
                txtGia.Focus();
                return;
            }
            if (strSoLuong == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập " + lblSL.Text);
                txtSoLuong.Focus();
                return;
            }
            if (strChatLieu == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập " + lblChatLieu.Text);
                txtChatLieu.Focus();
                return;
            }
            if (strLoai == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập " + lblLoaiSP.Text);
                txtLoai.Focus();
                return;
            }
            if (strNSX == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập " + lblNSX.Text);
                txtNSX.Focus();
                return;
            }
            try
            {
                DataRow dr = db.DSet.Tables["dbo.SanPham"].Rows.Find(strMaSP);
                if (dr != null)
                {
                    MessageBox.Show("Sản Phẩm này đã tồn tại");
                    return;
                }
                DataRow newRow = db.DSet.Tables["dbo.SanPham"].NewRow();
                newRow["MaSP"] = strMaSP;
                newRow["TenSP"] = strTenSP;
                newRow["TrangThai"] = strTrangThai;
                newRow["DonGia"] = strDonGia;
                newRow["SoLuongTon"] = strSoLuong;
                newRow["MaChatLieu"] = strChatLieu;
                newRow["MaLoai"] = strLoai;
                newRow["MaNSX"] = strNSX;
                db.DSet.Tables["dbo.SanPham"].Rows.Add(newRow);//add vô dataset
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(ada_SanPham);//reconcile với DataAdapter
                ada_SanPham.Update(db.DSet, "dbo.SanPham");
                MessageBox.Show("Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            string strMaSP = txtMaSP.Text.Trim();
            string strTenSP = txtTenSP.Text.Trim();
            string strTrangThai = txtTrangThai.Text.Trim();
            string strDonGia = txtGia.Text.Trim();
            string strSoLuong = txtSoLuong.Text.Trim();
            string strChatLieu = txtChatLieu.Text.Trim();
            string strLoai = txtLoai.Text.Trim();
            string strNSX = txtNSX.Text.Trim();

            if (strMaSP == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập " + lblMaSP.Text);
                txtMaSP.Focus();
                return;
            }
            if (strTenSP == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập " + lblTenSP.Text);
                txtTenSP.Focus();
                return;
            }
            if (strTrangThai == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập " + lblTrangThai.Text);
                txtTrangThai.Focus();
                return;
            }
            if (strSoLuong == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập " + lblSL.Text);
                txtSoLuong.Focus();
                return;
            }
            if (strChatLieu == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập " + lblChatLieu.Text);
                txtChatLieu.Focus();
                return;
            }
            if (strLoai == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập " + lblLoaiSP.Text);
                txtLoai.Focus();
                return;
            }
            if (strNSX == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập " + lblNSX.Text);
                txtNSX.Focus();
                return;
            }
            try
            {
                DataRow dr = db.DSet.Tables["dbo.SanPham"].Rows.Find(strMaSP);
                if (dr != null)
                { //Cập nhật lại dữ liệu cho dòng vừa tìm được
                    dr["TenSP"] = strTenSP;
                    SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(ada_SanPham);
                    ada_SanPham.Update(db.DSet, "dbo.SanPham");
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                    MessageBox.Show("Không tìm thấy mã khoa này");
            }
            catch
            {
                MessageBox.Show("Cập nhật không thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string strMaSP = txtMaSP.Text.Trim();
            if (strMaSP == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập " + lblMaSP.Text);
                txtMaSP.Focus();
                return;
            }

            try
            {
                if (db.checkExist("dbo.HoaDon", "MaSP", strMaSP))
                {
                    MessageBox.Show("Mã Sản phẩm này đã có Hóa Đơn");
                    return;
                }
                DataRow dr = db.DSet.Tables["dbo.SanPham"].Rows.Find(strMaSP);
                if (dr != null)
                {
                    dr.Delete(); //Xóa dòng dữ liệu vừa tìm được
                    //Cập nhật trong CSDL
                    SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(ada_SanPham);
                    ada_SanPham.Update(db.DSet, "dbo.SanPham");
                    MessageBox.Show("Xóa thành công");
                }
                else
                    MessageBox.Show("Không tìm thấy mã khoa này");
            }
            catch
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void lblKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang obj = new frmKhachHang();
            obj.Show();
            this.Hide();
        }

        private void lblHoaDon_Click(object sender, EventArgs e)
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

        private void lblTrangChu_Click(object sender, EventArgs e)
        {
            frmHome obj = new frmHome();
            obj.Show();
            this.Hide();
        }

        private void lblNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien obj = new frmNhanVien();
            obj.Show();
            this.Hide();
        }

        private void lblThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe obj = new frmThongKe();
            obj.Show();
            this.Hide();
        }

    }
}
