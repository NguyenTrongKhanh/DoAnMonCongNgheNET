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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void lblSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham obj = new frmSanPham();
            obj.Show();
            this.Hide();
        }


        private void lblThoat_Click(object sender, EventArgs e)
        {
            frmDangNhap obj = new frmDangNhap();
            obj.Show();
            this.Hide();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            lblEmpName.Text = LoginInfo.TenNhanVien.ToString();
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

        private void label5_Click(object sender, EventArgs e)
        {
            frmHoaDon obj = new frmHoaDon();
            obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            frmThongKe obj = new frmThongKe();
            obj.Show();
            this.Hide();
        }

        private void lblThoat_Click_1(object sender, EventArgs e)
        {
            frmDangNhap obj = new frmDangNhap();
            obj.Show();
            this.Hide();
        }



    }
}
