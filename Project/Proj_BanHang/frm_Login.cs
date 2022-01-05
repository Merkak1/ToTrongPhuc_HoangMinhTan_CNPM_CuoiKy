using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proj_BanHang
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _taikhoan = txtTaiKhoan.Text.Trim();
            string _matkhau = txtMatKhau.Text.Trim();
            if((_taikhoan != string.Empty) && (_matkhau != string.Empty))
            {
                cs_SQL csSQL = new cs_SQL();
                SqlCommand _sql = new SqlCommand("Select MaNV,HoTen,QuanLy,MatKhau from NhanVien where TaiKhoan = @taikhoan", cs_SQL.con);
                _sql.Parameters.AddWithValue("@taikhoan", _taikhoan);
                var dt = csSQL.readdata(_sql);
                if(dt.Rows.Count > 0)
                {
                    string _mk = dt.Rows[0].Field<string>("MatKhau").Trim();
                    if(_mk.Equals(_matkhau))
                    {
                        Form1._dangnhap = true;
                        Form1._hoten = dt.Rows[0].Field<string>("HoTen");
                        Form1._isQuanLy = dt.Rows[0].Field<bool>("QuanLy");
                        Form1._manv = dt.Rows[0].Field<string>("MaNV");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sai Mật Khẩu.");
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Tài khoản này không tồn tại.");                   
                }
            }
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Liên hệ: Eric để lấy tài khoản và mật khẩu.");
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
