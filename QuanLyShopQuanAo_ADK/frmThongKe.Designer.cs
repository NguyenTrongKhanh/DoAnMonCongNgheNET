namespace QuanLyShopQuanAo_ADK
{
    partial class frmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            this.dgvHoaDonSP = new System.Windows.Forms.DataGridView();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.btnTimTheoTatCa = new System.Windows.Forms.Button();
            this.lblNgay = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lblNgayHoaDon = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.mtxtNgay = new System.Windows.Forms.MaskedTextBox();
            this.btnTimTheoTen = new System.Windows.Forms.Button();
            this.btnTimTheoNgay = new System.Windows.Forms.Button();
            this.btnTimTheoMa = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblSanPham = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblThoat = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonSP)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoaDonSP
            // 
            this.dgvHoaDonSP.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvHoaDonSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDon,
            this.TenNhanVien,
            this.TenKhachHang,
            this.Loai,
            this.TG});
            this.dgvHoaDonSP.Location = new System.Drawing.Point(26, 326);
            this.dgvHoaDonSP.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHoaDonSP.Name = "dgvHoaDonSP";
            this.dgvHoaDonSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDonSP.Size = new System.Drawing.Size(1094, 254);
            this.dgvHoaDonSP.TabIndex = 27;
            this.dgvHoaDonSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDonSP_CellClick);
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.DataPropertyName = "MaHD";
            this.MaHoaDon.HeaderText = "Mã HD";
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.Width = 60;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNV";
            this.TenNhanVien.HeaderText = "Tên nhân viên";
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.Width = 270;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKH";
            this.TenKhachHang.HeaderText = "Tên khách hàng";
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.Width = 270;
            // 
            // Loai
            // 
            this.Loai.DataPropertyName = "TenLoai";
            this.Loai.HeaderText = "Loại KH";
            this.Loai.Name = "Loai";
            this.Loai.Width = 250;
            // 
            // TG
            // 
            this.TG.DataPropertyName = "ThoiGian";
            this.TG.HeaderText = "Thời gian";
            this.TG.Name = "TG";
            this.TG.Width = 200;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(265, 10);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(193, 29);
            this.txtTenKH.TabIndex = 28;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(83, 13);
            this.lblTenKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(154, 23);
            this.lblTenKH.TabIndex = 29;
            this.lblTenKH.Text = "Tên khách hàng:";
            // 
            // btnTimTheoTatCa
            // 
            this.btnTimTheoTatCa.Location = new System.Drawing.Point(51, 135);
            this.btnTimTheoTatCa.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimTheoTatCa.Name = "btnTimTheoTatCa";
            this.btnTimTheoTatCa.Size = new System.Drawing.Size(389, 53);
            this.btnTimTheoTatCa.TabIndex = 30;
            this.btnTimTheoTatCa.Text = "Tìm theo tất cả";
            this.btnTimTheoTatCa.UseVisualStyleBackColor = true;
            this.btnTimTheoTatCa.Click += new System.EventHandler(this.btnTimTheoTatCa_Click);
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(177, 53);
            this.lblNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(60, 23);
            this.lblNgay.TabIndex = 32;
            this.lblNgay.Text = "Ngày:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(311, 92);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(147, 29);
            this.txtMaHD.TabIndex = 33;
            // 
            // lblNgayHoaDon
            // 
            this.lblNgayHoaDon.AutoSize = true;
            this.lblNgayHoaDon.Location = new System.Drawing.Point(120, 95);
            this.lblNgayHoaDon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayHoaDon.Name = "lblNgayHoaDon";
            this.lblNgayHoaDon.Size = new System.Drawing.Size(117, 23);
            this.lblNgayHoaDon.TabIndex = 34;
            this.lblNgayHoaDon.Text = "Mã hoá đơn:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(555, 135);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(389, 53);
            this.btnReset.TabIndex = 35;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // mtxtNgay
            // 
            this.mtxtNgay.Location = new System.Drawing.Point(311, 50);
            this.mtxtNgay.Mask = "00/00/0000";
            this.mtxtNgay.Name = "mtxtNgay";
            this.mtxtNgay.Size = new System.Drawing.Size(147, 29);
            this.mtxtNgay.TabIndex = 38;
            this.mtxtNgay.ValidatingType = typeof(System.DateTime);
            // 
            // btnTimTheoTen
            // 
            this.btnTimTheoTen.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTheoTen.Location = new System.Drawing.Point(522, 9);
            this.btnTimTheoTen.Name = "btnTimTheoTen";
            this.btnTimTheoTen.Size = new System.Drawing.Size(290, 31);
            this.btnTimTheoTen.TabIndex = 39;
            this.btnTimTheoTen.Text = "Tìm theo tên khách hàng";
            this.btnTimTheoTen.UseVisualStyleBackColor = true;
            this.btnTimTheoTen.Click += new System.EventHandler(this.btnTimTheoTen_Click);
            // 
            // btnTimTheoNgay
            // 
            this.btnTimTheoNgay.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTheoNgay.Location = new System.Drawing.Point(522, 49);
            this.btnTimTheoNgay.Name = "btnTimTheoNgay";
            this.btnTimTheoNgay.Size = new System.Drawing.Size(290, 31);
            this.btnTimTheoNgay.TabIndex = 40;
            this.btnTimTheoNgay.Text = "Tìm theo ngày hoá đơn";
            this.btnTimTheoNgay.UseVisualStyleBackColor = true;
            this.btnTimTheoNgay.Click += new System.EventHandler(this.btnTimTheoNgay_Click);
            // 
            // btnTimTheoMa
            // 
            this.btnTimTheoMa.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTheoMa.Location = new System.Drawing.Point(522, 90);
            this.btnTimTheoMa.Name = "btnTimTheoMa";
            this.btnTimTheoMa.Size = new System.Drawing.Size(290, 31);
            this.btnTimTheoMa.TabIndex = 41;
            this.btnTimTheoMa.Text = "Tìm theo mã hoá đơn";
            this.btnTimTheoMa.UseVisualStyleBackColor = true;
            this.btnTimTheoMa.Click += new System.EventHandler(this.btnTimTheoMa_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(211)))), ((int)(((byte)(164)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.dgvChiTiet);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.dgvHoaDonSP);
            this.panel5.Location = new System.Drawing.Point(262, 20);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1157, 881);
            this.panel5.TabIndex = 98;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(449, 592);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 27);
            this.label4.TabIndex = 46;
            this.label4.Text = "Chi Tiết Hoá Đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(489, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 27);
            this.label3.TabIndex = 45;
            this.label3.Text = "Hóa Đơn";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(474, 12);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(199, 27);
            this.label20.TabIndex = 44;
            this.label20.Text = "Lọc Tìm Hoá Đơn";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenSanPham,
            this.SoLuong,
            this.DonGia1});
            this.dgvChiTiet.Location = new System.Drawing.Point(26, 634);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTiet.Size = new System.Drawing.Size(1094, 240);
            this.dgvChiTiet.TabIndex = 43;
            // 
            // TenSanPham
            // 
            this.TenSanPham.DataPropertyName = "TenSP";
            this.TenSanPham.HeaderText = "Tên sản phẩm";
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.Width = 200;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "SL";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 50;
            // 
            // DonGia1
            // 
            this.DonGia1.DataPropertyName = "DonGia";
            this.DonGia1.HeaderText = "Đơn giá";
            this.DonGia1.Name = "DonGia1";
            this.DonGia1.Width = 150;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnTimTheoMa);
            this.panel2.Controls.Add(this.btnTimTheoTatCa);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.txtTenKH);
            this.panel2.Controls.Add(this.btnTimTheoNgay);
            this.panel2.Controls.Add(this.lblTenKH);
            this.panel2.Controls.Add(this.btnTimTheoTen);
            this.panel2.Controls.Add(this.lblNgay);
            this.panel2.Controls.Add(this.mtxtNgay);
            this.panel2.Controls.Add(this.txtMaHD);
            this.panel2.Controls.Add(this.lblNgayHoaDon);
            this.panel2.Location = new System.Drawing.Point(63, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1057, 217);
            this.panel2.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 71;
            this.label1.Text = "Xuất Hóa Đơn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 315);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 70;
            this.pictureBox2.TabStop = false;
            // 
            // lblSanPham
            // 
            this.lblSanPham.AutoSize = true;
            this.lblSanPham.BackColor = System.Drawing.Color.Transparent;
            this.lblSanPham.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanPham.Location = new System.Drawing.Point(58, 162);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(132, 29);
            this.lblSanPham.TabIndex = 100;
            this.lblSanPham.Text = "Sản Phẩm";
            this.lblSanPham.Click += new System.EventHandler(this.lblSanPham_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(20, 110);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 106;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 29);
            this.label8.TabIndex = 102;
            this.label8.Text = "Nhân Viên";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.lblKhachHang.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHang.Location = new System.Drawing.Point(55, 264);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(156, 29);
            this.lblKhachHang.TabIndex = 109;
            this.lblKhachHang.Text = "Khách Hàng";
            this.lblKhachHang.Click += new System.EventHandler(this.lblKhachHang_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(20, 263);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 108;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(20, 212);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(24, 24);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 101;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(20, 20);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(24, 24);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 104;
            this.pictureBox7.TabStop = false;
            // 
            // lblEmpName
            // 
            this.lblEmpName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpName.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.Location = new System.Drawing.Point(59, 21);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(160, 75);
            this.lblEmpName.TabIndex = 105;
            this.lblEmpName.Text = "EmpName";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 29);
            this.label9.TabIndex = 107;
            this.label9.Text = "Trang Chủ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblThoat
            // 
            this.lblThoat.AutoSize = true;
            this.lblThoat.BackColor = System.Drawing.Color.Transparent;
            this.lblThoat.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoat.Location = new System.Drawing.Point(63, 856);
            this.lblThoat.Name = "lblThoat";
            this.lblThoat.Size = new System.Drawing.Size(82, 29);
            this.lblThoat.TabIndex = 113;
            this.lblThoat.Text = "Thoát";
            this.lblThoat.Click += new System.EventHandler(this.lblThoat_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(26, 856);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 24);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 112;
            this.pictureBox6.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(185)))), ((int)(((byte)(167)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Location = new System.Drawing.Point(20, 362);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(191, 41);
            this.panel3.TabIndex = 111;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 29);
            this.label5.TabIndex = 71;
            this.label5.Text = "Thống Kê";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 70;
            this.pictureBox5.TabStop = false;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1442, 913);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblThoat);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lblSanPham);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblKhachHang);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGiaoDich";
            this.Load += new System.EventHandler(this.frmGiaoDich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonSP)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDonSP;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Button btnTimTheoTatCa;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lblNgayHoaDon;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.MaskedTextBox mtxtNgay;
        private System.Windows.Forms.Button btnTimTheoTen;
        private System.Windows.Forms.Button btnTimTheoNgay;
        private System.Windows.Forms.Button btnTimTheoMa;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblSanPham;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblThoat;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia1;

    }
}