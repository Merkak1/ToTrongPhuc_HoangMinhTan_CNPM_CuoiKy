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
    public partial class _uc_MuaHang : UserControl
    {
        public _uc_MuaHang()
        {
            InitializeComponent();
        }
        static SqlConnection _con = cs_SQL.con;
        AutoCompleteStringCollection _source = new AutoCompleteStringCollection();
        private void _SetMaHD()
        {
            cs_SQL csSQL = new cs_SQL();
            SqlCommand _cmd = new SqlCommand("Select ID from HoaDon", _con);
            var dt = csSQL.readdata(_cmd);
            List<int> _lstInt = new List<int>();
            if (dt.Rows.Count > 0)
            {
                for(int x = 0; x < dt.Rows.Count; x++)
                {
                    _lstInt.Add( dt.Rows[x].Field<int>("ID"));
                }
            }
            txt_MaDonHang.Text = ( _lstInt.Max() + 1).ToString();
        }
        private void _uc_MuaHang_Load(object sender, EventArgs e)
        {
            _SetMaHD();
            cs_SQL csSQL = new cs_SQL();            
            SqlCommand _cmdMaHang = new SqlCommand("select MaHang from MaHang", _con);
            var _dtMaHang = csSQL.readdata(_cmdMaHang);
            for(int row = 0; row < _dtMaHang.Rows.Count; row++)
            {
                cbb_MaHang_Output.Items.Add(_dtMaHang.Rows[row].Field<string>("MaHang"));
                _source.Add(_dtMaHang.Rows[row].Field<string>("MaHang"));
            }
            cbb_MaHang_Output.AutoCompleteCustomSource = _source;
        }
        private void nmr_SoLuong_Leave(object sender, EventArgs e)
        {
            if(cbb_MaHang_Output.Text.Trim() != string.Empty)
            {
                string _mahang = cbb_MaHang_Output.Text.Trim();
                int _soluong = int.Parse(nmr_SoLuong.Value.ToString());
                int _soluongton = 0;
                decimal _giatien = 0;
                cs_SQL csSQL = new cs_SQL();
                SqlCommand _cmd = new SqlCommand("Select TonKho,GiaTien from MaHang Where MaHang = @mahang",_con);
                _cmd.Parameters.AddWithValue("@mahang", _mahang);
                var dt = csSQL.readdata(_cmd);
                if(dt.Rows.Count > 0)
                {
                    try
                    {
                        _soluongton = dt.Rows[0].Field<int>("TonKho");
                    }
                    catch
                    {
                        _soluongton = 0;
                    }
                    _giatien = dt.Rows[0].Field<decimal>("GiaTien");
                }
                if(_soluong > _soluongton)
                {
                    MessageBox.Show("Số lượng tồn nhỏ hơn số lượng đặt mua. Số lượng tồn của mã hàng còn lại: " + _soluongton);
                    return;
                }
                txt_TongTien.Text = (_soluong * _giatien).ToString();
            }
        }

        private void txt_TongTien_TextChanged(object sender, EventArgs e)
        {
            if (txt_TongTien.Text.Trim() != String.Empty)
            {
                try
                {
                    System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                    decimal value = decimal.Parse(txt_TongTien.Text, System.Globalization.NumberStyles.AllowThousands);
                    txt_TongTien.Text = String.Format(culture, "{0:N0}", value);
                    txt_TongTien.Select(txt_TongTien.Text.Length, 0);
                    //txt_TongTien.Text = string.Format("{0:0,0}", decimal.Parse(txt_TongTien.Text));
                    //txt_TongTien.SelectionStart = txt_TongTien.Text.Length;
                }
                catch { }
            }
        }
        private void cbb_MaHang_Output_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _mahang = cbb_MaHang_Output.Text.Trim();
            if(_mahang != string.Empty)
            {
                nmr_SoLuong.Value = 0;
                txt_TongTien.Text = "0";
                cs_SQL csSQL = new cs_SQL();
                SqlCommand _cmd = new SqlCommand("Select * from MaHang where MaHang = @mahang",_con);
                _cmd.Parameters.AddWithValue("@mahang", _mahang);
                var dt = csSQL.readdata(_cmd);
                if(dt.Rows.Count > 0)
                {
                    txtTenHang.Text = dt.Rows[0].Field<string>("TenHang");
                    rtbMoTa.Text = dt.Rows[0].Field<string>("MoTa");
                }
            }
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            string _mahang = cbb_MaHang_Output.Text.Trim();
            string _tenhang = txtTenHang.Text;
            int _soluong = int.Parse(nmr_SoLuong.Value.ToString());
            string _tongtien = txt_TongTien.Text;
            if (_mahang != string.Empty)
            {
                dtgrid.Rows.Add(_mahang, _tenhang, _soluong, _tongtien);
                int _TongHoaDon = int.Parse(txt_TongTien_MuaHang.Text.Replace(",", ""));
                txt_TongTien_MuaHang.Text = (int.Parse(_tongtien.Replace(",","")) + _TongHoaDon).ToString();
            }
            else
            {
                MessageBox.Show("Hãy chọn mã hàng muốn mua.");                
            }

        }

        private void txt_TongTien_MuaHang_TextChanged(object sender, EventArgs e)
        {

            if (txt_TongTien_MuaHang.Text.Trim() != String.Empty)
            {
                try
                {
                    System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                    decimal value = decimal.Parse(txt_TongTien_MuaHang.Text, System.Globalization.NumberStyles.AllowThousands);
                    txt_TongTien_MuaHang.Text = String.Format(culture, "{0:N0}", value);
                    txt_TongTien_MuaHang.Select(txt_TongTien_MuaHang.Text.Length, 0);
                    //txt_TongTien.Text = string.Format("{0:0,0}", decimal.Parse(txt_TongTien.Text));
                    //txt_TongTien.SelectionStart = txt_TongTien.Text.Length;
                }
                catch { }
            }
        }

        private void nmr_SoLuong_ValueChanged(object sender, EventArgs e)
        {
            if (cbb_MaHang_Output.Text.Trim() != string.Empty)
            {
                string _mahang = cbb_MaHang_Output.Text.Trim();
                int _soluong = int.Parse(nmr_SoLuong.Value.ToString());
                int _soluongton = 0;
                decimal _giatien = 0;
                cs_SQL csSQL = new cs_SQL();
                SqlCommand _cmd = new SqlCommand("Select TonKho,GiaTien from MaHang Where MaHang = @mahang", _con);
                _cmd.Parameters.AddWithValue("@mahang", _mahang);
                var dt = csSQL.readdata(_cmd);
                if (dt.Rows.Count > 0)
                {
                    try
                    {
                        _soluongton = dt.Rows[0].Field<int>("TonKho");
                    }
                    catch
                    {
                        _soluongton = 0;
                    }
                    _giatien = dt.Rows[0].Field<decimal>("GiaTien");
                }
                if (_soluong > _soluongton)
                {
                    MessageBox.Show("Số lượng tồn nhỏ hơn số lượng đặt mua. Số lượng tồn của mã hàng còn lại: " + _soluongton);
                    nmr_SoLuong.Value = 0;
                    return;
                }
                txt_TongTien.Text = (_soluong * _giatien).ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgrid.CurrentRow != null)
            {
                string _mahang = dtgrid.CurrentRow.Cells[0].Value.ToString().Trim();
                DialogResult dr = MessageBox.Show("Bạn muốn xóa mã hàng: " + _mahang + " ra khỏi danh sách mua ?.", "Xóa mã hàng chọn mua.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int _tongtien = int.Parse(dtgrid.CurrentRow.Cells[3].Value.ToString().Replace(",", ""));
                    int _TongHoaDon = int.Parse(txt_TongTien_MuaHang.Text.Replace(",", ""));
                    txt_TongTien_MuaHang.Text = (_TongHoaDon - _tongtien).ToString();
                    dtgrid.Rows.Remove(dtgrid.CurrentRow);
                }
            }
        }

        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn xóa hết danh sách mua hàng ?.", "Xóa danh sách mua hàng.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                dtgrid.Rows.Clear();
                txt_TongTien_MuaHang.Text = "0";
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if((txtHoTen.Text.Trim() == string.Empty) || (rtbDiaChi.Text.Trim() == string.Empty))
            {
                MessageBox.Show("Xin hãy nhập đầy đủ họ tên và địa chỉ.");
                return;
            }
            if(dtgrid.Rows.Count <= 0)
            {
                MessageBox.Show("Bạn chưa chọn mã hàng nào.");
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn xác nhận muốn đặt đơn hàng ?.", "Xác nhận đặt hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string _mahoadon = txt_MaDonHang.Text.Trim().ToUpper();
                string _hoten = txtHoTen.Text.Trim();
                string _diachi = rtbDiaChi.Text.Trim();
                string _tongtien = txt_TongTien_MuaHang.Text.Trim().Replace(",", "");
                DateTime _ngaymua = DateTime.Now;

                cs_SQL csSQL = new cs_SQL();
                SqlCommand _cmd = new SqlCommand("Insert into HoaDon values (@mahoadon,@hoten,@diachi,@tongtien,@ngaymua,@thanhtoan)", _con);
                _cmd.Parameters.AddWithValue("@mahoadon", _mahoadon);
                _cmd.Parameters.AddWithValue("@hoten", _hoten);
                _cmd.Parameters.AddWithValue("@diachi", _diachi);
                _cmd.Parameters.AddWithValue("@tongtien", _tongtien);
                _cmd.Parameters.AddWithValue("@ngaymua", _ngaymua);
                _cmd.Parameters.AddWithValue("@thanhtoan", false);
                int i = csSQL.exedata(_cmd);
                if (i > 0)
                {
                    MessageBox.Show("Đặt hàng thành công. Xin hãy tiến hành thanh toán.");
                    foreach (DataGridViewRow row in dtgrid.Rows)
                    {
                        string _mahang = row.Cells[0].Value.ToString().Trim();
                        int _soluong = int.Parse(row.Cells[2].Value.ToString().Trim());                        
                        SqlCommand _sqlcmd = new SqlCommand("Insert into DonHang values (@mahoadon,@mahang,@soluong,@xuatkho)",_con);
                        _sqlcmd.Parameters.AddWithValue("@mahoadon", _mahoadon);
                        _sqlcmd.Parameters.AddWithValue("@mahang", _mahang);
                        _sqlcmd.Parameters.AddWithValue("@soluong", _soluong);
                        _sqlcmd.Parameters.AddWithValue("@xuatkho",false);
                        csSQL.exedata(_sqlcmd);
                    }
                    _SetMaHD();
                    txtHoTen.Clear();
                    rtbDiaChi.Clear();
                    txt_TongTien.Clear();
                    dtgrid.Rows.Clear();
                    txt_TongTien_MuaHang.Text = "0";
                }
            }
        }

        private void cbb_MaHang_Output_DropDown(object sender, EventArgs e)
        {
            cbb_MaHang_Output.Items.Clear();
            cs_SQL csSQL = new cs_SQL();          
            SqlCommand _cmdMaHang = new SqlCommand("select MaHang from MaHang", _con);
            var _dtMaHang = csSQL.readdata(_cmdMaHang);
            for (int row = 0; row < _dtMaHang.Rows.Count; row++)
            {
                cbb_MaHang_Output.Items.Add(_dtMaHang.Rows[row].Field<string>("MaHang"));
                _source.Add(_dtMaHang.Rows[row].Field<string>("MaHang"));
            }
            cbb_MaHang_Output.AutoCompleteCustomSource = _source;
        }
    }
}
