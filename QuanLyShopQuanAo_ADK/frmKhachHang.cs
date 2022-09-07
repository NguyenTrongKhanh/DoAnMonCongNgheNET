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
    public partial class frmKhachHang : Form
    {
        ThuVien1 db;
        SqlDataAdapter ada_KhachHang;
        DataColumn[] primaryKey;
        public frmKhachHang()
        {
            InitializeComponent();
            db = new ThuVien1();
            ada_KhachHang = new SqlDataAdapter();
            primaryKey = new DataColumn[1];
        }
        public void Load_Data()
        {
            string strSQL = "SELECT * FROM dbo.KhachHang";
            ada_KhachHang = db.getDataAdapter(strSQL, "dbo.KhachHang");
            //Thêm khóa chính cho bảng tblKhoa
            primaryKey[0] = db.DSet.Tables["dbo.KhachHang"].Columns["MaKH"];
            db.DSet.Tables["dbo.KhachHang"].PrimaryKey = primaryKey;
            //Binding dữ liệu giữa DataSet và Textbox
            DataBinding(db.DSet.Tables["dbo.KhachHang"]);
        }

        public void LoadGridView_KhachHang()
        {
            grvKhachHang.DataSource = db.DSet.Tables["dbo.KhachHang"];
            grvKhachHang.Columns[0].HeaderText = "Mã KH";
            grvKhachHang.Columns[1].HeaderText = "Tên KH";
            grvKhachHang.Columns[2].HeaderText = "SDT";
            grvKhachHang.Columns[3].HeaderText = "DiaChi";
            grvKhachHang.Columns[0].Width = 80;
            grvKhachHang.Columns[1].Width = 160;
            grvKhachHang.Columns[3].Width = 200;
            grvKhachHang.EnableHeadersVisualStyles = false; //Bắt buộc phải có dòng này!
            grvKhachHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKhachHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.Green;
            grvKhachHang.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            grvKhachHang.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15F, FontStyle.Bold, GraphicsUnit.Pixel);
        }

        public void DataBinding(DataTable pDataTable)
        {
            txtMaKH.DataBindings.Clear();
            Binding dataBinding1 = new Binding("Text", pDataTable, "MaKH", true, DataSourceUpdateMode.Never);
            txtMaKH.DataBindings.Add(dataBinding1);

            txtHoTen.DataBindings.Clear();
            Binding dataBinding2 = new Binding("Text", pDataTable, "TenKH", true, DataSourceUpdateMode.Never);
            txtHoTen.DataBindings.Add(dataBinding2);

            txtSDT.DataBindings.Clear();
            Binding dataBinding3 = new Binding("Text", pDataTable, "SDT", true, DataSourceUpdateMode.Never);
            txtSDT.DataBindings.Add(dataBinding3);

            txtDiaChi.DataBindings.Clear();
            Binding dataBinding4 = new Binding("Text", pDataTable, "DiaChi", true, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Add(dataBinding4);

            

           
        }
        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            Load_Data();
            lblEmpName.Text = LoginInfo.TenNhanVien.ToString();
            LoadGridView_KhachHang();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string strMaKH = txtMaKH.Text.Trim();
            string strTenKH = txtHoTen.Text.Trim();
            string strDiaChi = txtDiaChi.Text.Trim();
            string strSDT = txtSDT.Text.Trim();
            

            if (strMaKH == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập " + lblMaKH.Text);
                txtMaKH.Focus();
                return;
            }
            if (strTenKH == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập " + lblTenKH.Text);
                txtHoTen.Focus();
                return;
            }
            if (strDiaChi == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập " + lblDiaChi.Text);
                txtDiaChi.Focus();
                return;
            }
            if (strSDT == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập " + lblSDT.Text);
                txtSDT.Focus();
                return;
            }
            
            try
            {
                DataRow dr = db.DSet.Tables["dbo.KhachHang"].Rows.Find(strMaKH);
                if (dr != null)
                {
                    MessageBox.Show("Khách Hàng này đã tồn tại");
                    return;
                }
                DataRow newRow = db.DSet.Tables["dbo.KhachHang"].NewRow();
                newRow["MaKH"] = strMaKH;
                newRow["TenKH"] = strTenKH;
                newRow["SDT"] = strSDT;
                newRow["DiaChi"] = strDiaChi;
                db.DSet.Tables["dbo.KhachHang"].Rows.Add(newRow);//add vô dataset
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(ada_KhachHang);//reconcile với DataAdapter
                ada_KhachHang.Update(db.DSet, "dbo.KhachHang");
                MessageBox.Show("Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            string strMaKH = txtMaKH.Text.Trim();
            string strTenKH = txtHoTen.Text.Trim();
            string strDiaChi = txtDiaChi.Text.Trim();
            string strSDT = txtSDT.Text.Trim();
           

            if (strMaKH == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập " + lblMaKH.Text);
                txtMaKH.Focus();
                return;
            }
            if (strTenKH == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập " + lblTenKH.Text);
                txtHoTen.Focus();
                return;
            }
            if (strDiaChi == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập " + lblDiaChi.Text);
                txtDiaChi.Focus();
                return;
            }
            if (strSDT == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập " + lblSDT.Text);
                txtSDT.Focus();
                return;
            }
           
            try
            {
                DataRow dr = db.DSet.Tables["dbo.KhachHang"].Rows.Find(strMaKH);
                if (dr != null)
                { //Cập nhật lại dữ liệu cho dòng vừa tìm được
                    dr["TenKH"] = strTenKH;
                    SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(ada_KhachHang);
                    ada_KhachHang.Update(db.DSet, "dbo.KhachHang");
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
            string strMaKH = txtMaKH.Text.Trim();
            if (strMaKH == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập " + lblMaKH.Text);
                txtMaKH.Focus();
                return;
            }

            try
            {
                if (db.checkExist("dbo.HoaDon", "MaKH", strMaKH))
                {
                    MessageBox.Show("Mã Khach Hang này đã có Hóa Đơn");
                    return;
                }
                DataRow dr = db.DSet.Tables["dbo.KhachHang"].Rows.Find(strMaKH);
                if (dr != null)
                {
                    dr.Delete(); //Xóa dòng dữ liệu vừa tìm được
                    //Cập nhật trong CSDL
                    SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(ada_KhachHang);
                    ada_KhachHang.Update(db.DSet, "dbo.KhachHang");
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

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void lblSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham obj = new frmSanPham();
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

        private void lblThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe obj = new frmThongKe();
            obj.Show();
            this.Hide();
        }

        private void lblNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien obj = new frmNhanVien();
            obj.Show();
            this.Hide();
        }



        

      
    }
}
