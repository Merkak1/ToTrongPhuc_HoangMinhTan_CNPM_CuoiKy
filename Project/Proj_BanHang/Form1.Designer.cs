namespace Proj_BanHang
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnMuaHang = new System.Windows.Forms.Button();
            this.btnNhapKho = new System.Windows.Forms.Button();
            this._uc_NhapKho1 = new Proj_BanHang._uc_NhapKho();
            this._uc_MuaHang1 = new Proj_BanHang._uc_MuaHang();
            this._uc_ThanhToan1 = new Proj_BanHang._uc_ThanhToan();
            this._uc_ThongKe1 = new Proj_BanHang._uc_ThongKe();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 25);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Proj_BanHang.Properties.Resources.icons8_close_window_32;
            this.pictureBox1.Location = new System.Drawing.Point(984, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1008, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phần mềm quản lý bán hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThongKe);
            this.panel2.Controls.Add(this.lblHoTen);
            this.panel2.Controls.Add(this.btnThanhToan);
            this.panel2.Controls.Add(this.btnMuaHang);
            this.panel2.Controls.Add(this.btnNhapKho);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 30);
            this.panel2.TabIndex = 1;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(321, 0);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(107, 30);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Visible = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(989, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(19, 13);
            this.lblHoTen.TabIndex = 4;
            this.lblHoTen.Text = "...";
            this.lblHoTen.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(214, 0);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(107, 30);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnMuaHang
            // 
            this.btnMuaHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMuaHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuaHang.Location = new System.Drawing.Point(107, 0);
            this.btnMuaHang.Name = "btnMuaHang";
            this.btnMuaHang.Size = new System.Drawing.Size(107, 30);
            this.btnMuaHang.TabIndex = 2;
            this.btnMuaHang.Text = "Mua Hàng";
            this.btnMuaHang.UseVisualStyleBackColor = true;
            this.btnMuaHang.Click += new System.EventHandler(this.btnMuaHang_Click);
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNhapKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapKho.Location = new System.Drawing.Point(0, 0);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(107, 30);
            this.btnNhapKho.TabIndex = 0;
            this.btnNhapKho.Text = "Quản Lý Kho";
            this.btnNhapKho.UseVisualStyleBackColor = true;
            this.btnNhapKho.Click += new System.EventHandler(this.btnNhapKho_Click);
            // 
            // _uc_NhapKho1
            // 
            this._uc_NhapKho1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._uc_NhapKho1.Location = new System.Drawing.Point(0, 55);
            this._uc_NhapKho1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._uc_NhapKho1.Name = "_uc_NhapKho1";
            this._uc_NhapKho1.Size = new System.Drawing.Size(1008, 674);
            this._uc_NhapKho1.TabIndex = 2;
            // 
            // _uc_MuaHang1
            // 
            this._uc_MuaHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._uc_MuaHang1.Location = new System.Drawing.Point(0, 55);
            this._uc_MuaHang1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._uc_MuaHang1.Name = "_uc_MuaHang1";
            this._uc_MuaHang1.Size = new System.Drawing.Size(1008, 674);
            this._uc_MuaHang1.TabIndex = 3;
            // 
            // _uc_ThanhToan1
            // 
            this._uc_ThanhToan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._uc_ThanhToan1.Location = new System.Drawing.Point(0, 55);
            this._uc_ThanhToan1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._uc_ThanhToan1.Name = "_uc_ThanhToan1";
            this._uc_ThanhToan1.Size = new System.Drawing.Size(1008, 674);
            this._uc_ThanhToan1.TabIndex = 4;
            // 
            // _uc_ThongKe1
            // 
            this._uc_ThongKe1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._uc_ThongKe1.Location = new System.Drawing.Point(0, 55);
            this._uc_ThongKe1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._uc_ThongKe1.Name = "_uc_ThongKe1";
            this._uc_ThongKe1.Size = new System.Drawing.Size(1008, 674);
            this._uc_ThongKe1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this._uc_ThongKe1);
            this.Controls.Add(this._uc_ThanhToan1);
            this.Controls.Add(this._uc_MuaHang1);
            this.Controls.Add(this._uc_NhapKho1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnMuaHang;
        private System.Windows.Forms.Button btnNhapKho;
        private _uc_NhapKho _uc_NhapKho1;
        private _uc_MuaHang _uc_MuaHang1;
        private _uc_ThanhToan _uc_ThanhToan1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Button btnThongKe;
        private _uc_ThongKe _uc_ThongKe1;
    }
}

