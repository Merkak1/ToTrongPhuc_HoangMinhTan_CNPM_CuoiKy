namespace Proj_BanHang
{
    partial class _uc_ThongKe
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
            this.dtgrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_TK_Thang = new System.Windows.Forms.ComboBox();
            this.btn_TK_NhapHang = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_TK_MaHang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtgrid_XuatHang = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbb_TK_ThangXuatHang = new System.Windows.Forms.ComboBox();
            this.btn_TK_XuatHang = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_TK_XuatHang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbb_DoanhThu_Thang = new System.Windows.Forms.ComboBox();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgrid_DoanhThu = new System.Windows.Forms.DataGridView();
            this.lblThongKe = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_XuatHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_DoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1008, 674);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgrid);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1000, 648);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TK Nhập Hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgrid
            // 
            this.dtgrid.AllowUserToAddRows = false;
            this.dtgrid.AllowUserToDeleteRows = false;
            this.dtgrid.AllowUserToResizeRows = false;
            this.dtgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrid.Location = new System.Drawing.Point(3, 107);
            this.dtgrid.MultiSelect = false;
            this.dtgrid.Name = "dtgrid";
            this.dtgrid.ReadOnly = true;
            this.dtgrid.RowHeadersVisible = false;
            this.dtgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrid.Size = new System.Drawing.Size(994, 538);
            this.dtgrid.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_TK_Thang);
            this.groupBox1.Controls.Add(this.btn_TK_NhapHang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbb_TK_MaHang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy Chọn Thống Kê Nhập Hàng";
            // 
            // cbb_TK_Thang
            // 
            this.cbb_TK_Thang.FormattingEnabled = true;
            this.cbb_TK_Thang.Items.AddRange(new object[] {
            "Tất Cả",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbb_TK_Thang.Location = new System.Drawing.Point(65, 51);
            this.cbb_TK_Thang.Name = "cbb_TK_Thang";
            this.cbb_TK_Thang.Size = new System.Drawing.Size(75, 21);
            this.cbb_TK_Thang.TabIndex = 5;
            // 
            // btn_TK_NhapHang
            // 
            this.btn_TK_NhapHang.Location = new System.Drawing.Point(65, 76);
            this.btn_TK_NhapHang.Name = "btn_TK_NhapHang";
            this.btn_TK_NhapHang.Size = new System.Drawing.Size(75, 23);
            this.btn_TK_NhapHang.TabIndex = 4;
            this.btn_TK_NhapHang.Text = "Thống Kê";
            this.btn_TK_NhapHang.UseVisualStyleBackColor = true;
            this.btn_TK_NhapHang.Click += new System.EventHandler(this.btn_TK_NhapHang_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tháng";
            // 
            // cbb_TK_MaHang
            // 
            this.cbb_TK_MaHang.FormattingEnabled = true;
            this.cbb_TK_MaHang.Location = new System.Drawing.Point(65, 20);
            this.cbb_TK_MaHang.Name = "cbb_TK_MaHang";
            this.cbb_TK_MaHang.Size = new System.Drawing.Size(121, 21);
            this.cbb_TK_MaHang.TabIndex = 1;
            this.cbb_TK_MaHang.DropDown += new System.EventHandler(this.cbb_TK_MaHang_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hàng";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtgrid_XuatHang);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1000, 648);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TK Xuất Hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgrid_XuatHang
            // 
            this.dtgrid_XuatHang.AllowUserToAddRows = false;
            this.dtgrid_XuatHang.AllowUserToDeleteRows = false;
            this.dtgrid_XuatHang.AllowUserToResizeRows = false;
            this.dtgrid_XuatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_XuatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_XuatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrid_XuatHang.Location = new System.Drawing.Point(3, 107);
            this.dtgrid_XuatHang.MultiSelect = false;
            this.dtgrid_XuatHang.Name = "dtgrid_XuatHang";
            this.dtgrid_XuatHang.ReadOnly = true;
            this.dtgrid_XuatHang.RowHeadersVisible = false;
            this.dtgrid_XuatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrid_XuatHang.Size = new System.Drawing.Size(994, 538);
            this.dtgrid_XuatHang.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbb_TK_ThangXuatHang);
            this.groupBox2.Controls.Add(this.btn_TK_XuatHang);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbb_TK_XuatHang);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(994, 104);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tùy Chọn Thống Kê Xuất Hàng";
            // 
            // cbb_TK_ThangXuatHang
            // 
            this.cbb_TK_ThangXuatHang.FormattingEnabled = true;
            this.cbb_TK_ThangXuatHang.Items.AddRange(new object[] {
            "Tất Cả",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbb_TK_ThangXuatHang.Location = new System.Drawing.Point(81, 51);
            this.cbb_TK_ThangXuatHang.Name = "cbb_TK_ThangXuatHang";
            this.cbb_TK_ThangXuatHang.Size = new System.Drawing.Size(75, 21);
            this.cbb_TK_ThangXuatHang.TabIndex = 5;
            // 
            // btn_TK_XuatHang
            // 
            this.btn_TK_XuatHang.Location = new System.Drawing.Point(81, 75);
            this.btn_TK_XuatHang.Name = "btn_TK_XuatHang";
            this.btn_TK_XuatHang.Size = new System.Drawing.Size(75, 23);
            this.btn_TK_XuatHang.TabIndex = 4;
            this.btn_TK_XuatHang.Text = "Thống Kê";
            this.btn_TK_XuatHang.UseVisualStyleBackColor = true;
            this.btn_TK_XuatHang.Click += new System.EventHandler(this.btn_TK_XuatHang_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tháng";
            // 
            // cbb_TK_XuatHang
            // 
            this.cbb_TK_XuatHang.FormattingEnabled = true;
            this.cbb_TK_XuatHang.Location = new System.Drawing.Point(81, 21);
            this.cbb_TK_XuatHang.Name = "cbb_TK_XuatHang";
            this.cbb_TK_XuatHang.Size = new System.Drawing.Size(121, 21);
            this.cbb_TK_XuatHang.TabIndex = 1;
            this.cbb_TK_XuatHang.DropDown += new System.EventHandler(this.cbb_TK_XuatHang_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Hóa Đơn";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dtgrid_DoanhThu);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1000, 648);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Doanh Thu";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblThongKe);
            this.groupBox3.Controls.Add(this.cbb_DoanhThu_Thang);
            this.groupBox3.Controls.Add(this.btnDoanhThu);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1000, 78);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thống Kê Doanh Thu";
            // 
            // cbb_DoanhThu_Thang
            // 
            this.cbb_DoanhThu_Thang.FormattingEnabled = true;
            this.cbb_DoanhThu_Thang.Items.AddRange(new object[] {
            "Tất Cả",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbb_DoanhThu_Thang.Location = new System.Drawing.Point(52, 17);
            this.cbb_DoanhThu_Thang.Name = "cbb_DoanhThu_Thang";
            this.cbb_DoanhThu_Thang.Size = new System.Drawing.Size(75, 21);
            this.cbb_DoanhThu_Thang.TabIndex = 5;
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.Location = new System.Drawing.Point(52, 44);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(75, 23);
            this.btnDoanhThu.TabIndex = 4;
            this.btnDoanhThu.Text = "Xem";
            this.btnDoanhThu.UseVisualStyleBackColor = true;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tháng";
            // 
            // dtgrid_DoanhThu
            // 
            this.dtgrid_DoanhThu.AllowUserToAddRows = false;
            this.dtgrid_DoanhThu.AllowUserToDeleteRows = false;
            this.dtgrid_DoanhThu.AllowUserToResizeRows = false;
            this.dtgrid_DoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_DoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_DoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrid_DoanhThu.Location = new System.Drawing.Point(0, 78);
            this.dtgrid_DoanhThu.MultiSelect = false;
            this.dtgrid_DoanhThu.Name = "dtgrid_DoanhThu";
            this.dtgrid_DoanhThu.ReadOnly = true;
            this.dtgrid_DoanhThu.RowHeadersVisible = false;
            this.dtgrid_DoanhThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrid_DoanhThu.Size = new System.Drawing.Size(1000, 570);
            this.dtgrid_DoanhThu.TabIndex = 8;
            // 
            // lblThongKe
            // 
            this.lblThongKe.AutoSize = true;
            this.lblThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongKe.Location = new System.Drawing.Point(133, 19);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Size = new System.Drawing.Size(19, 16);
            this.lblThongKe.TabIndex = 6;
            this.lblThongKe.Text = "...";
            // 
            // _uc_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "_uc_ThongKe";
            this.Size = new System.Drawing.Size(1008, 674);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_XuatHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_DoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_TK_NhapHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_TK_MaHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cbb_TK_Thang;
        private System.Windows.Forms.DataGridView dtgrid;
        private System.Windows.Forms.DataGridView dtgrid_XuatHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbb_TK_ThangXuatHang;
        private System.Windows.Forms.Button btn_TK_XuatHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_TK_XuatHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbb_DoanhThu_Thang;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgrid_DoanhThu;
        private System.Windows.Forms.Label lblThongKe;
    }
}
