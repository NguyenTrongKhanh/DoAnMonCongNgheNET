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
    public partial class frmDangNhap : Form
    {
        NguoiDung nd = new NguoiDung();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string strTenDN = txtTDNhap.Text;
            string strMatKhau = txtMKhau.Text;
            if (strTenDN == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtTDNhap.Focus();
                return;
            }


            if (strMatKhau == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtMKhau.Focus();
                return;
            }
            if (nd.DangNhap(strTenDN, strMatKhau) == 1)
            {
                frmHome obj = new frmHome();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

    }
}
