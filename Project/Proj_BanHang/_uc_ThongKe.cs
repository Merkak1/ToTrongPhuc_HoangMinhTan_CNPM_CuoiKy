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

namespace Proj_BanHang
{
    public partial class _uc_ThongKe : UserControl
    {
        public _uc_ThongKe()
        {
            InitializeComponent();
        }
        AutoCompleteStringCollection _sourceMaHang = new AutoCompleteStringCollection();
        static SqlConnection _con = cs_SQL.con;
        private void cbb_TK_MaHang_DropDown(object sender, EventArgs e)
        {
            cbb_TK_MaHang.Items.Clear();
            cbb_TK_MaHang.Items.Add("Tất Cả");
            SqlCommand _cmd = new SqlCommand("Select MaHang from NhapHang",_con);
            cs_SQL _sql = new cs_SQL();
            var _dt = _sql.readdata(_cmd);
            if(_dt.Rows.Count > 0)
            {
                for(int i = 0; i < _dt.Rows.Count; i++)
                {
                    string _mahang = _dt.Rows[i].Field<string>("MaHang");
                    if(!cbb_TK_MaHang.Items.Contains(_mahang))
                    {
                        cbb_TK_MaHang.Items.Add(_mahang);
                    }
                }
            }
            
        }
        private void btn_TK_NhapHang_Click(object sender, EventArgs e)
        {
            SqlCommand _cmd;
            cs_SQL _sql = new cs_SQL();
            if(cbb_TK_MaHang.SelectedItem == null)
            {
                MessageBox.Show("Hãy chọn mã hàng muốn xem thống kê.");
                return;
            }
            if(cbb_TK_MaHang.SelectedIndex == 0) // Tất cả
            {
                if(cbb_TK_Thang.SelectedIndex == 0) //Tất cả
                {
                    _cmd = new SqlCommand("Select ID, MaHang[Mã Hàng],SoLuong[Số Lượng],NgayNhap[Ngày Nhập],MaNV[Mã Nhân Viên] from NhapHang",_con);
                    dtgrid.DataSource = _sql.readdata(_cmd);
                }
                else
                {
                    _cmd = new SqlCommand("Select ID, MaHang[Mã Hàng], SoLuong[Số Lượng], NgayNhap[Ngày Nhập], MaNV[Mã Nhân Viên] from NhapHang Where Month(NgayNhap) = @month",_con);
                    _cmd.Parameters.AddWithValue("@month", cbb_TK_Thang.Text.Trim());
                    dtgrid.DataSource= _sql.readdata(_cmd);
                }
            }
            else
            {
                if(cbb_TK_Thang.SelectedIndex > 0)
                {
                    _cmd = new SqlCommand("Select ID, MaHang[Mã Hàng], SoLuong[Số Lượng], NgayNhap[Ngày Nhập], MaNV[Mã Nhân Viên] from NhapHang Where MaHang = @mahang AND Month(NgayNhap) = @month",_con);
                    _cmd.Parameters.AddWithValue("@mahang", cbb_TK_MaHang.Text.Trim());
                    _cmd.Parameters.AddWithValue("@month", cbb_TK_Thang.Text.Trim());
                    dtgrid.DataSource = _sql.readdata(_cmd);
                }
                else
                {
                    _cmd = new SqlCommand("Select ID, MaHang[Mã Hàng], SoLuong[Số Lượng], NgayNhap[Ngày Nhập], MaNV[Mã Nhân Viên] from NhapHang Where MaHang = @mahang",_con);
                    _cmd.Parameters.AddWithValue("@mahang", cbb_TK_MaHang.Text.Trim());
                    dtgrid.DataSource = _sql.readdata(_cmd);
                }
            }
        }

        private void cbb_TK_XuatHang_DropDown(object sender, EventArgs e)
        {
            cbb_TK_XuatHang.Items.Clear();
            cbb_TK_XuatHang.Items.Add("Tất Cả");
            SqlCommand _cmd = new SqlCommand("Select MaHoaDon from XuatKho", _con);
            cs_SQL _SQL = new cs_SQL();
            var dt = _SQL.readdata(_cmd);
            if(dt != null)
            {
                for(int i = 0; i < dt.Rows.Count; i ++)
                {
                    if(!cbb_TK_XuatHang.Items.Contains(dt.Rows[i].Field<string>("MaHoaDon")))
                    {
                        cbb_TK_XuatHang.Items.Add(dt.Rows[i].Field<string>("MaHoaDon"));
                    }
                }
            }
        }

        private void btn_TK_XuatHang_Click(object sender, EventArgs e)
        {
            SqlCommand _cmd;
            cs_SQL _sql = new cs_SQL();
            if (cbb_TK_XuatHang.SelectedItem == null)
            {
                MessageBox.Show("Hãy chọn mã hóa đơn muốn xem thống kê.");
                return;
            }
            if(cbb_TK_XuatHang.SelectedIndex == 0)
            {
                if(cbb_TK_ThangXuatHang.SelectedIndex == 0)
                {
                    _cmd = new SqlCommand("Select MaHoaDon[Mã Hóa Đơn],MaHang[Mã Hàng],SoLuong[Số Lượng],MaNV[Mã Nhân Viên],NgayXuat[Ngày Xuất] from XuatKho", _con);
                    dtgrid_XuatHang.DataSource = _sql.readdata(_cmd);
                }
                else
                {
                    _cmd = new SqlCommand("Select MaHoaDon[Mã Hóa Đơn],MaHang[Mã Hàng],SoLuong[Số Lượng],MaNV[Mã Nhân Viên],NgayXuat[Ngày Xuất] from XuatKho where Month(NgayXuat) = @month", _con);
                    _cmd.Parameters.AddWithValue("@month", cbb_TK_ThangXuatHang.Text.Trim());
                    dtgrid_XuatHang.DataSource= _sql.readdata(_cmd);
                }
            }
            else
            {
                if (cbb_TK_ThangXuatHang.SelectedIndex == 0)
                {
                    _cmd = new SqlCommand("Select MaHoaDon[Mã Hóa Đơn],MaHang[Mã Hàng],SoLuong[Số Lượng],MaNV[Mã Nhân Viên],NgayXuat[Ngày Xuất] from XuatKho where MaHoaDon = @mahoadon", _con);
                    _cmd.Parameters.AddWithValue("@mahoadon", cbb_TK_XuatHang.Text.Trim());
                    dtgrid_XuatHang.DataSource = _sql.readdata(_cmd);
                }
                else
                {
                    _cmd = new SqlCommand("Select MaHoaDon[Mã Hóa Đơn],MaHang[Mã Hàng],SoLuong[Số Lượng],MaNV[Mã Nhân Viên],NgayXuat[Ngày Xuất] from XuatKho where MaHoaDon = @mahoadon AND Month(NgayXuat) = @month", _con);
                    _cmd.Parameters.AddWithValue("@mahoadon", cbb_TK_XuatHang.Text.Trim());
                    _cmd.Parameters.AddWithValue("@month", cbb_TK_ThangXuatHang.Text.Trim());
                    dtgrid_XuatHang.DataSource = _sql.readdata(_cmd);
                }
            }
        }
        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            string _thang = cbb_DoanhThu_Thang.Text.Trim();
            cs_SQL _sql = new cs_SQL();
            SqlCommand _cmd;
            decimal _TongTien = 0;

            if (cbb_DoanhThu_Thang.SelectedIndex == 0)
            {
                _cmd = new SqlCommand("Select MaHoaDon[Mã Hóa Đơn],TenKhachHang[Khách Hàng],DiaChi[Địa Chỉ],TongTien[Tổng Tiền],NgayBan[Ngày Bán],ThanhToan[Thanh Toán] from HoaDon where ThanhToan = '1'", _con);
                dtgrid_DoanhThu.DataSource = _sql.readdata(_cmd);
            }
            else
            {
                _cmd = new SqlCommand("Select MaHoaDon[Mã Hóa Đơn],TenKhachHang[Khách Hàng],DiaChi[Địa Chỉ],TongTien[Tổng Tiền],NgayBan[Ngày Bán],ThanhToan[Thanh Toán] from HoaDon where ThanhToan = '1' AND Month(NgayBan) = @month", _con);
                _cmd.Parameters.AddWithValue("@month", _thang);
                dtgrid_DoanhThu.DataSource = _sql.readdata(_cmd);
            }
            if(dtgrid_DoanhThu.Rows.Count > 0)
            {
                foreach(DataGridViewRow row in dtgrid_DoanhThu.Rows)
                {
                    decimal _tien = decimal.Parse(row.Cells[3].Value.ToString());
                    _TongTien += _tien;
                }
            }
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            string _tongtienString = String.Format(culture, "{0:N0}", _TongTien);

            if (cbb_DoanhThu_Thang.SelectedIndex == 0)
            {
                lblThongKe.Text = String.Format("Doanh thu tất cả: {0} VNĐ", _tongtienString);
            }
            else
            {
                lblThongKe.Text = String.Format("Doanh thu tháng {0}: {1} VNĐ",_thang, _tongtienString);
            }

        }
    }
}
