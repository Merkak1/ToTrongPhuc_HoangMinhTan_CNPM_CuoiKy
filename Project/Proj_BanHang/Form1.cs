using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_BanHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool mouseDown;
        private Point lastLocation;
        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            _uc_NhapKho1.BringToFront();
        }
        public void btnThanhToan_Click(object sender, EventArgs e)
        {
            _uc_ThanhToan1.BringToFront();
        }
        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            _uc_MuaHang1.BringToFront();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("bạn muốn thoát chương trình ?.", "Xác nhận thoát.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        public static bool _dangnhap = false;
        public static bool _isQuanLy = false;
        public static string _hoten = string.Empty;
        public static string _manv = string.Empty;
        private void Form1_Load(object sender, EventArgs e)
        {
            frm_Login frm = new frm_Login();
            frm.ShowDialog();
            if (_dangnhap == false)
            {
                this.Close();
            }
            else
            {
                lblHoTen.Text = "Xin chào: " + _hoten;
                if (_isQuanLy == false)
                {
                    btnNhapKho.Visible = false;
                    btnThongKe.Visible = false;
                    _uc_MuaHang1.BringToFront();
                }
                else
                {
                    btnNhapKho.Visible = true;
                    btnThongKe.Visible = true;
                    _uc_NhapKho1.BringToFront();
                }
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            _uc_ThongKe1.BringToFront();
        }
    }
}
