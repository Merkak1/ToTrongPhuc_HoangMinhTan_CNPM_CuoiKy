namespace Proj_BanHang
{
    partial class _uc_NhapKho
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dtgrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_GiaTien_Input = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btn_Xoa_Input = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbb_MaHang_Input = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtb_MoTa_Input = new System.Windows.Forms.RichTextBox();
            this.txtTenHang_Input = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_ChonHinh = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_MaHang_Output = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nmr_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dtgrid_XuatKho = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_XacNhan_TongTien = new System.Windows.Forms.TextBox();
            this.cbbMaHoaDon = new System.Windows.Forms.ComboBox();
            this.btn_Xuat_Xoa = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btnXacNhanXuat = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.btn_ChonHinh.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_SoLuong)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_XuatKho)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1008, 674);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Controls.Add(this.btn_ChonHinh);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1000, 648);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NHẬP KHO";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 154);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dtgrid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(994, 491);
            this.splitContainer1.SplitterDistance = 700;
            this.splitContainer1.TabIndex = 3;
            // 
            // dtgrid
            // 
            this.dtgrid.AllowUserToAddRows = false;
            this.dtgrid.AllowUserToDeleteRows = false;
            this.dtgrid.AllowUserToResizeRows = false;
            this.dtgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrid.Location = new System.Drawing.Point(0, 0);
            this.dtgrid.MultiSelect = false;
            this.dtgrid.Name = "dtgrid";
            this.dtgrid.ReadOnly = true;
            this.dtgrid.RowHeadersVisible = false;
            this.dtgrid.RowHeadersWidth = 51;
            this.dtgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrid.Size = new System.Drawing.Size(700, 491);
            this.dtgrid.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_GiaTien_Input);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.btn_Xoa_Input);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.cbb_MaHang_Input);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rtb_MoTa_Input);
            this.groupBox1.Controls.Add(this.txtTenHang_Input);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Mã Hàng";
            // 
            // txt_GiaTien_Input
            // 
            this.txt_GiaTien_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaTien_Input.Location = new System.Drawing.Point(66, 170);
            this.txt_GiaTien_Input.Name = "txt_GiaTien_Input";
            this.txt_GiaTien_Input.Size = new System.Drawing.Size(170, 26);
            this.txt_GiaTien_Input.TabIndex = 37;
            this.txt_GiaTien_Input.TextChanged += new System.EventHandler(this.txt_GiaTien_Input_TextChanged);
            this.txt_GiaTien_Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_GiaTien_Input_KeyPress);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCapNhat.Location = new System.Drawing.Point(109, 202);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 36;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btn_Xoa_Input
            // 
            this.btn_Xoa_Input.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Xoa_Input.Location = new System.Drawing.Point(207, 202);
            this.btn_Xoa_Input.Name = "btn_Xoa_Input";
            this.btn_Xoa_Input.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa_Input.TabIndex = 35;
            this.btn_Xoa_Input.Text = "Xóa";
            this.btn_Xoa_Input.UseVisualStyleBackColor = false;
            this.btn_Xoa_Input.Click += new System.EventHandler(this.btn_Xoa_Input_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThem.Location = new System.Drawing.Point(11, 202);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 34;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbb_MaHang_Input
            // 
            this.cbb_MaHang_Input.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbb_MaHang_Input.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbb_MaHang_Input.FormattingEnabled = true;
            this.cbb_MaHang_Input.Location = new System.Drawing.Point(66, 21);
            this.cbb_MaHang_Input.Name = "cbb_MaHang_Input";
            this.cbb_MaHang_Input.Size = new System.Drawing.Size(121, 21);
            this.cbb_MaHang_Input.TabIndex = 33;
            this.cbb_MaHang_Input.SelectedIndexChanged += new System.EventHandler(this.cbb_MaHang_Input_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "VNĐ";
            // 
            // rtb_MoTa_Input
            // 
            this.rtb_MoTa_Input.Location = new System.Drawing.Point(66, 77);
            this.rtb_MoTa_Input.Name = "rtb_MoTa_Input";
            this.rtb_MoTa_Input.Size = new System.Drawing.Size(216, 84);
            this.rtb_MoTa_Input.TabIndex = 31;
            this.rtb_MoTa_Input.Text = "";
            // 
            // txtTenHang_Input
            // 
            this.txtTenHang_Input.Location = new System.Drawing.Point(66, 47);
            this.txtTenHang_Input.Name = "txtTenHang_Input";
            this.txtTenHang_Input.Size = new System.Drawing.Size(216, 20);
            this.txtTenHang_Input.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Giá Tiền";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Mô Tả";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Tên Hàng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Mã Hàng";
            // 
            // btn_ChonHinh
            // 
            this.btn_ChonHinh.Controls.Add(this.groupBox2);
            this.btn_ChonHinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ChonHinh.Location = new System.Drawing.Point(3, 3);
            this.btn_ChonHinh.Name = "btn_ChonHinh";
            this.btn_ChonHinh.Size = new System.Drawing.Size(994, 151);
            this.btn_ChonHinh.TabIndex = 2;
            this.btn_ChonHinh.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnNhap);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbb_MaHang_Output);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_TongTien);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nmr_SoLuong);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(3, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 132);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phiếu Nhập Kho";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoa.Location = new System.Drawing.Point(153, 108);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.BackColor = System.Drawing.Color.PaleGreen;
            this.btnNhap.Location = new System.Drawing.Point(67, 108);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 5;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = false;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(234, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "VNĐ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hàng";
            // 
            // cbb_MaHang_Output
            // 
            this.cbb_MaHang_Output.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbb_MaHang_Output.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbb_MaHang_Output.FormattingEnabled = true;
            this.cbb_MaHang_Output.Location = new System.Drawing.Point(67, 16);
            this.cbb_MaHang_Output.Name = "cbb_MaHang_Output";
            this.cbb_MaHang_Output.Size = new System.Drawing.Size(110, 21);
            this.cbb_MaHang_Output.TabIndex = 4;
            this.cbb_MaHang_Output.SelectedIndexChanged += new System.EventHandler(this.cbb_MaHang_Output_SelectedIndexChanged);
            this.cbb_MaHang_Output.Leave += new System.EventHandler(this.cbb_MaHang_Output_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số Lượng Nhập";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTien.Location = new System.Drawing.Point(67, 71);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.ReadOnly = true;
            this.txt_TongTien.Size = new System.Drawing.Size(161, 26);
            this.txt_TongTien.TabIndex = 4;
            this.txt_TongTien.TextChanged += new System.EventHandler(this.txt_TongTien_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tổng Tiền";
            // 
            // nmr_SoLuong
            // 
            this.nmr_SoLuong.Location = new System.Drawing.Point(94, 44);
            this.nmr_SoLuong.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nmr_SoLuong.Name = "nmr_SoLuong";
            this.nmr_SoLuong.Size = new System.Drawing.Size(83, 20);
            this.nmr_SoLuong.TabIndex = 2;
            this.nmr_SoLuong.ValueChanged += new System.EventHandler(this.nmr_SoLuong_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1000, 648);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "XUẤT KHO";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dtgrid_XuatKho);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitContainer2.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer2.Size = new System.Drawing.Size(994, 642);
            this.splitContainer2.SplitterDistance = 697;
            this.splitContainer2.TabIndex = 1;
            // 
            // dtgrid_XuatKho
            // 
            this.dtgrid_XuatKho.AllowUserToAddRows = false;
            this.dtgrid_XuatKho.AllowUserToDeleteRows = false;
            this.dtgrid_XuatKho.AllowUserToResizeRows = false;
            this.dtgrid_XuatKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_XuatKho.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtgrid_XuatKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_XuatKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrid_XuatKho.Location = new System.Drawing.Point(0, 0);
            this.dtgrid_XuatKho.MultiSelect = false;
            this.dtgrid_XuatKho.Name = "dtgrid_XuatKho";
            this.dtgrid_XuatKho.ReadOnly = true;
            this.dtgrid_XuatKho.RowHeadersVisible = false;
            this.dtgrid_XuatKho.RowHeadersWidth = 51;
            this.dtgrid_XuatKho.Size = new System.Drawing.Size(697, 642);
            this.dtgrid_XuatKho.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txt_XacNhan_TongTien);
            this.groupBox4.Controls.Add(this.cbbMaHoaDon);
            this.groupBox4.Controls.Add(this.btn_Xuat_Xoa);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.btnXacNhanXuat);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(293, 136);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Phiếu Xuất Kho";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(261, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "VNĐ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Mã Hóa Đơn";
            // 
            // txt_XacNhan_TongTien
            // 
            this.txt_XacNhan_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_XacNhan_TongTien.Location = new System.Drawing.Point(82, 51);
            this.txt_XacNhan_TongTien.Name = "txt_XacNhan_TongTien";
            this.txt_XacNhan_TongTien.ReadOnly = true;
            this.txt_XacNhan_TongTien.Size = new System.Drawing.Size(174, 26);
            this.txt_XacNhan_TongTien.TabIndex = 42;
            this.txt_XacNhan_TongTien.Text = "0";
            this.txt_XacNhan_TongTien.TextChanged += new System.EventHandler(this.txt_XacNhan_TongTien_TextChanged);
            // 
            // cbbMaHoaDon
            // 
            this.cbbMaHoaDon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbMaHoaDon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbbMaHoaDon.FormattingEnabled = true;
            this.cbbMaHoaDon.Location = new System.Drawing.Point(82, 19);
            this.cbbMaHoaDon.Name = "cbbMaHoaDon";
            this.cbbMaHoaDon.Size = new System.Drawing.Size(110, 21);
            this.cbbMaHoaDon.TabIndex = 42;
            this.cbbMaHoaDon.SelectedIndexChanged += new System.EventHandler(this.cbbMaHoaDon_SelectedIndexChanged);
            // 
            // btn_Xuat_Xoa
            // 
            this.btn_Xuat_Xoa.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Xuat_Xoa.Location = new System.Drawing.Point(181, 92);
            this.btn_Xuat_Xoa.Name = "btn_Xuat_Xoa";
            this.btn_Xuat_Xoa.Size = new System.Drawing.Size(75, 33);
            this.btn_Xuat_Xoa.TabIndex = 6;
            this.btn_Xuat_Xoa.Text = "Xóa";
            this.btn_Xuat_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xuat_Xoa.Click += new System.EventHandler(this.btn_Xuat_Xoa_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "Tổng Hóa Đơn";
            // 
            // btnXacNhanXuat
            // 
            this.btnXacNhanXuat.BackColor = System.Drawing.Color.Cyan;
            this.btnXacNhanXuat.Location = new System.Drawing.Point(14, 92);
            this.btnXacNhanXuat.Name = "btnXacNhanXuat";
            this.btnXacNhanXuat.Size = new System.Drawing.Size(90, 33);
            this.btnXacNhanXuat.TabIndex = 6;
            this.btnXacNhanXuat.Text = "Xác Nhận Xuất";
            this.btnXacNhanXuat.UseVisualStyleBackColor = false;
            this.btnXacNhanXuat.Click += new System.EventHandler(this.btnXacNhanXuat_Click);
            // 
            // _uc_NhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "_uc_NhapKho";
            this.Size = new System.Drawing.Size(1008, 674);
            this.Load += new System.EventHandler(this._uc_NhapKho_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.btn_ChonHinh.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_SoLuong)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_XuatKho)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dtgrid;
        private System.Windows.Forms.GroupBox btn_ChonHinh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmr_SoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_MaHang_Output;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btn_Xoa_Input;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbb_MaHang_Input;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtb_MoTa_Input;
        private System.Windows.Forms.TextBox txtTenHang_Input;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_GiaTien_Input;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dtgrid_XuatKho;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbbMaHoaDon;
        private System.Windows.Forms.Button btnXacNhanXuat;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_XacNhan_TongTien;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_Xuat_Xoa;
    }
}
