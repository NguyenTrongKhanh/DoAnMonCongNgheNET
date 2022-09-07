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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            timer1.Start();
        }
        int start = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 2;
            progressBar1.Value = start;
            lblPhanTram.Text = start + "%";
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                frmDangNhap obj = new frmDangNhap();
                obj.Show();
                this.Hide();
                timer1.Stop();
            }
        }

    }
}
