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
    public partial class _uc_NhapKho : UserControl
    {
        public _uc_NhapKho()
        {
            InitializeComponent();
        }
        AutoCompleteStringCollection _sourceMaHang = new AutoCompleteStringCollection();
        static SqlConnection _con = cs_SQL.con;
        private void _uc_NhapKho_Load(object sender, EventArgs e)
        {
            _load_Data();
            _load_items_Mahang();
        }
        private void _load_items_Mahang()
        {
            cbb_MaHang_Input.Items.Clear();
            cbb_MaHang_Output.Items.Clear();
            _sourceMaHang.Clear();
            cbb_MaHang_Input.SelectedIndex = -1;
            cbb_MaHang_Input.Text = "";
            cbb_MaHang_Input_SelectedIndexChanged(this, null);
            cs_SQL _sql = new cs_SQL();
            SqlCommand _cmd = new SqlCommand("Select MaHang from MaHang", cs_SQL.con);
            var _data = _sql.readdata(_cmd);
            for (int i = 0; i < _data.Rows.Count; i++)
            {
                _sourceMaHang.Add(_data.Rows[i].Field<string>("MaHang"));
            }
            cbb_MaHang_Input.AutoCompleteCustomSource = _sourceMaHang;
            cbb_MaHang_Output.AutoCompleteCustomSource= _sourceMaHang;
            foreach (var _item in _sourceMaHang)
            {
                cbb_MaHang_Input.Items.Add(_item);
                cbb_MaHang_Output.Items.Add(_item);
            }
        }
        private void _load_Data()
        {
            SqlCommand _cmd = new SqlCommand("Select MaHang.MaHang[Mã Hàng], TenHang[Tên Hàng], MoTa[Mô Tả],GiaTien[Giá Tiền],TonKho[Tồn Kho] from MaHang", _con);
            
            cs_SQL _sql = new cs_SQL();
            DataTable dt = _sql.readdata(_cmd);
            if (dt != null)
            {
                dtgrid.DataSource = dt;
            }
        }       
        private void cbb_MaHang_Input_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_MaHang_Input.SelectedIndex != -1)
            {
                string _Mahang = cbb_MaHang_Input.Text.Trim().ToUpper();
                if (_Mahang != string.Empty)
                {
                    SqlCommand _cmd = new SqlCommand("Select * from MaHang Where MaHang = @mahang", _con);
                    _cmd.Parameters.AddWithValue("@mahang", _Mahang);
                    cs_SQL _sql = new cs_SQL();
                    DataTable dt = _sql.readdata(_cmd);
                    if (dt.Rows.Count > 0)
                    {
                        txtTenHang_Input.Text = dt.Rows[0].Field<string>("TenHang");
                        rtb_MoTa_Input.Text = dt.Rows[0].Field<string>("MoTa");
                        txt_GiaTien_Input.Text = dt.Rows[0].Field<decimal>("GiaTien").ToString();
                    }
                }
            }
            else if(cbb_MaHang_Input.SelectedIndex == -1)
            {
                txtTenHang_Input.Clear();
                rtb_MoTa_Input.Clear();
                txt_GiaTien_Input.Clear();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string _Mahang = cbb_MaHang_Input.Text.Trim().ToUpper();
            string _TenHang = txtTenHang_Input.Text.Trim();
            string _MoTa = rtb_MoTa_Input.Text.Trim();
            string _giaTien = txt_GiaTien_Input.Text.Replace(",","");
            int _Soluong = 0;
            if (_Mahang != string.Empty)
            {
                SqlCommand _cmd = new SqlCommand("Select * from MaHang Where MaHang = @mahang", _con);
                _cmd.Parameters.AddWithValue("@mahang", _Mahang);
                cs_SQL _sql = new cs_SQL();
                DataTable dt = _sql.readdata(_cmd);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Mã hàng: " + _Mahang + " đã tồn tại. Hãy bấm nút cập nhật nếu bạn muốn cập nhật thông tin cho mã hàng này.");
                    return;
                }
                else
                {
                    if((_TenHang == String.Empty) || (_giaTien == String.Empty))
                    {
                        MessageBox.Show("Hẫy nhập tên hàng và giá tiền.");
                        return;
                    }
                    SqlCommand _sqlcmd = new SqlCommand("Insert Into MaHang Values (@mahang,@tenhang,@mota,@giatien,@soluong)",_con);
                    _sqlcmd.Parameters.AddWithValue("@mahang", _Mahang);
                    _sqlcmd.Parameters.AddWithValue("@tenhang", _TenHang);
                    _sqlcmd.Parameters.AddWithValue("@mota", _MoTa);
                    _sqlcmd.Parameters.AddWithValue("@giatien", _giaTien);
                    _sqlcmd.Parameters.AddWithValue("@soluong", _Soluong);
                    int i =_sql.exedata(_sqlcmd);
                    if(i > 0)
                    {
                        MessageBox.Show("Thêm mã hàng: " + _Mahang + " thành công.");
                        _load_items_Mahang();
                        _load_Data();
                    }
                    else
                    {
                        MessageBox.Show("Thêm mã hàng thất bại. Xin hãy thử lại.");
                    }    

                }
            }
        }
        private void txt_GiaTien_Input_TextChanged(object sender, EventArgs e)
        {
            if (txt_GiaTien_Input.Text.Trim() != String.Empty)
            {
                try
                {
                    System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                    decimal value = decimal.Parse(txt_GiaTien_Input.Text, System.Globalization.NumberStyles.AllowThousands);
                    txt_GiaTien_Input.Text = String.Format(culture, "{0:N0}", value);
                    txt_GiaTien_Input.Select(txt_GiaTien_Input.Text.Length, 0);
                }
                catch { }
            }
        }
        private void txt_GiaTien_Input_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string _Mahang = cbb_MaHang_Input.Text.Trim().ToUpper();
            string _TenHang = txtTenHang_Input.Text.Trim();
            string _MoTa = rtb_MoTa_Input.Text.Trim();
            string _giaTien = txt_GiaTien_Input.Text.Replace(",", "");
            if (_Mahang != string.Empty)
            {
                SqlCommand _cmd = new SqlCommand("Select * from MaHang Where MaHang = @mahang", _con);
                _cmd.Parameters.AddWithValue("@mahang", _Mahang);
                cs_SQL _sql = new cs_SQL();
                DataTable dt = _sql.readdata(_cmd);
                if (dt.Rows.Count > 0)
                {
                    if ((_TenHang == String.Empty) || (_giaTien == String.Empty))
                    {
                        MessageBox.Show("Hẫy nhập tên hàng và giá tiền.");
                        return;
                    }
                    SqlCommand _sqlcmd = new SqlCommand("Update MaHang Set TenHang = @tenhang,MoTa = @mota,GiaTien = @giatien where MaHang = @mahang", _con);
                    _sqlcmd.Parameters.AddWithValue("@mahang", _Mahang);
                    _sqlcmd.Parameters.AddWithValue("@tenhang", _TenHang);
                    _sqlcmd.Parameters.AddWithValue("@mota", _MoTa);
                    _sqlcmd.Parameters.AddWithValue("@giatien", _giaTien);
                    int i = _sql.exedata(_sqlcmd);
                    if (i > 0)
                    {
                        MessageBox.Show("Cập nhật mã hàng: " + _Mahang + " thành công.");
                        _load_items_Mahang();
                        _load_Data();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật mã hàng thất bại. Xin hãy thử lại.");
                    }
                }
                else
                {
                    MessageBox.Show("Mã hàng này chưa tồn tại trong hệ thống.");
                    return;
                }
            }
        }
        private void btn_Xoa_Input_Click(object sender, EventArgs e)
        {
            string _Mahang = cbb_MaHang_Input.Text.Trim().ToUpper();
            if (_Mahang != string.Empty)
            {
                SqlCommand _cmd = new SqlCommand("Select * from MaHang Where MaHang = @mahang", _con);
                _cmd.Parameters.AddWithValue("@mahang", _Mahang);
                cs_SQL _sql = new cs_SQL();
                DataTable dt = _sql.readdata(_cmd);
                if (dt.Rows.Count > 0)
                {
                //    SqlCommand _sqlcmd3 = new SqlCommand("Delete from DonHang where MaHang = @mahang", _con);
                //    _sqlcmd3.Parameters.AddWithValue("@mahang", _Mahang);
                //    int i = _sql.exedata(_sqlcmd3);
                    SqlCommand _sqlcmd = new SqlCommand("Delete from NhapHang where MaHang = @mahang", _con);
                    _sqlcmd.Parameters.AddWithValue("@mahang", _Mahang);
                    int i = _sql.exedata(_sqlcmd);
                    SqlCommand _sqlcmd1 = new SqlCommand("Delete from XuatKho where MaHang = @mahang", _con);
                    _sqlcmd1.Parameters.AddWithValue("@mahang", _Mahang);
                    i += _sql.exedata(_sqlcmd1);
                    SqlCommand _sqlcmd2 = new SqlCommand("Delete from MaHang where MaHang = @mahang", _con);
                    _sqlcmd2.Parameters.AddWithValue("@mahang", _Mahang);
                    i += _sql.exedata(_sqlcmd2);
                    if (i > 0 )
                    {
                        MessageBox.Show("Xóa mã hàng: " + _Mahang + " thành công.");
                        _load_items_Mahang();
                        _load_Data();
                    }
                    else
                    {
                        MessageBox.Show("Xóa mã hàng thất bại. Xin hãy thử lại.");
                    }
                }
                else
                {
                    MessageBox.Show("Mã hàng này không tồn tại trong hệ thống.");
                    return;
                }
            }
        }
        private void cbb_MaHang_Output_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_MaHang_Output.SelectedIndex != -1)
            {
                string _Mahang = cbb_MaHang_Output.Text.Trim().ToUpper();
                if (_Mahang != string.Empty)
                {
                    SqlCommand _cmd = new SqlCommand("Select * from MaHang Where MaHang = @mahang", _con);
                    _cmd.Parameters.AddWithValue("@mahang", _Mahang);
                    cs_SQL _sql = new cs_SQL();
                    DataTable dt = _sql.readdata(_cmd);
                    if (dt.Rows.Count > 0)
                    {
                        txtTenHang_Input.Text = dt.Rows[0].Field<string>("TenHang");
                        rtb_MoTa_Input.Text = dt.Rows[0].Field<string>("MoTa");
                        txt_GiaTien_Input.Text = dt.Rows[0].Field<decimal>("GiaTien").ToString();
                        cbb_MaHang_Input.Text = cbb_MaHang_Output.Text;
                    }
                    else
                    {
                        MessageBox.Show("Mã hàng này chưa được nhập vào hệ thống.");
                    }
                }
            }
        }

        private void cbb_MaHang_Output_Leave(object sender, EventArgs e)
        {
            //if (!cbb_MaHang_Output.Items.Contains(cbb_MaHang_Output.Text.Trim().ToUpper()))
            //{
            //    MessageBox.Show("Mã hàng này chưa được nhập vào hệ thống.");
            //    return;
            //}
            //else
            //{
            //    int _idx = cbb_MaHang_Output.Items.IndexOf(cbb_MaHang_Output.Text.Trim().ToUpper());
            //    if (_idx > -1)
            //    {
            //        cbb_MaHang_Output.SelectedIndex = _idx;
            //    }
            //}
        }

        private void nmr_SoLuong_ValueChanged(object sender, EventArgs e)
        {
            if (txt_GiaTien_Input.Text.Trim() != String.Empty)
            {
                int _soluong = int.Parse(nmr_SoLuong.Value.ToString());
                decimal _Tongtien = _soluong * decimal.Parse(txt_GiaTien_Input.Text.Trim());
                txt_TongTien.Text = _Tongtien.ToString();
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

        private void btnNhap_Click(object sender, EventArgs e)
        {
            string _mahang = cbb_MaHang_Output.Text.Trim().ToUpper();
            int _soluong = int.Parse(nmr_SoLuong.Value.ToString());
            int _tonkho = 0;
            //Kiểm tra tồn kho
            cs_SQL csSQL = new cs_SQL();
            SqlCommand _sqlcheck = new SqlCommand("Select TonKho from MaHang where MaHang = @mahang", _con);
            _sqlcheck.Parameters.AddWithValue("@mahang", _mahang);
            var _dtTonKho = csSQL.readdata(_sqlcheck);
            if(_dtTonKho.Rows.Count > 0)
            {
                try
                {
                    _tonkho = _dtTonKho.Rows[0].Field<int>("TonKho");
                }
                catch
                {
                    _tonkho = 0;
                }
            }
            int _tongtonkho = _tonkho + _soluong;
            SqlCommand _sqlcmd = new SqlCommand("Update MaHang Set TonKho = @tongtonkho where MaHang = @mahang",_con);
            _sqlcmd.Parameters.AddWithValue("@tongtonkho", _tongtonkho);
            _sqlcmd.Parameters.AddWithValue("@mahang", _mahang);
            int i = csSQL.exedata(_sqlcmd);
            SqlCommand _sqlcmdNhapHang = new SqlCommand("Insert into NhapHang values (@mahang,@soluong,@ngaynhap,@manv)", _con);
            _sqlcmdNhapHang.Parameters.AddWithValue("@mahang", _mahang);
            _sqlcmdNhapHang.Parameters.AddWithValue("@soluong", _soluong);
            _sqlcmdNhapHang.Parameters.AddWithValue("@ngaynhap", DateTime.Now);
            _sqlcmdNhapHang.Parameters.AddWithValue("@manv", Form1._manv);
            int x = csSQL.exedata(_sqlcmdNhapHang);
            if((i > 0) && (x > 0))
            {
                MessageBox.Show("Nhập hàng thành công.");
                _load_Data();
            }
            else
            {
                MessageBox.Show("Nhập hàng không thành công.");
                return;
            }    
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            cbb_MaHang_Output.SelectedIndex = -1;
            cbb_MaHang_Output.Text = "";
            nmr_SoLuong.Value = 0;
            txt_TongTien.Clear();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 1)
            {
                AutoCompleteStringCollection _source = new AutoCompleteStringCollection();
                cs_SQL csSQL = new cs_SQL();
                SqlCommand _cmd = new SqlCommand("Select MaHoaDon from HoaDon",_con);
                var dt = csSQL.readdata(_cmd);
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    _source.Add(dt.Rows[i].Field<string>("MaHoaDon"));
                }

                cbbMaHoaDon.Items.Clear();
                foreach(var item in _source)
                {
                    cbbMaHoaDon.Items.Add(item);
                }
                cbbMaHoaDon.AutoCompleteCustomSource = _source;
            }
        }

        private void cbbMaHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _mahoadon = cbbMaHoaDon.Text;
            cs_SQL csSQL = new cs_SQL();
            SqlCommand _cmd = new SqlCommand("Select DonHang.MaHoaDon[Mã Hóa Đơn],MaHang[Mã Hàng],SoLuong[Số Lượng],DaXuatKho[Đã Xuất Kho],HoaDon.ThanhToan[Đã Thanh Toán] from DonHang,HoaDon where DonHang.MaHoaDon = @mahoadon AND HoaDon.MaHoaDon = DonHang.MaHoaDon", _con);
            _cmd.Parameters.AddWithValue("@mahoadon", _mahoadon);            
            dtgrid_XuatKho.DataSource = csSQL.readdata(_cmd);

            decimal _TongTienHD = 0;

            foreach(DataGridViewRow row in dtgrid_XuatKho.Rows)
            {
                string _mahang = row.Cells[1].Value.ToString();
                decimal _giatien = 0;
                SqlCommand _cmdgiatien = new SqlCommand("Select GiaTien from MaHang where MaHang = @mahang",_con);
                _cmdgiatien.Parameters.AddWithValue("@mahang", _mahang);
                var _dtGiatien = csSQL.readdata(_cmdgiatien);
                if(_dtGiatien != null)
                {
                    _giatien = _dtGiatien.Rows[0].Field<decimal>("GiaTien");
                }
                int _soluong = int.Parse(row.Cells[2].Value.ToString());
                decimal _tongtienMH = _soluong * _giatien;
                _TongTienHD += _tongtienMH;
            }
            txt_XacNhan_TongTien.Text = _TongTienHD.ToString();


            //if(dt.Rows.Count > 0)
            //{
            //    for(int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        var _item = dt.Rows[i].Field<string>("MaHang");
            //        if(!cbbMaHang.Items.Contains(_item))
            //        {
            //            cbbMaHang.Items.Add(_item);
            //        }
            //    }
            //}
        }

        private void txt_XacNhan_TongTien_TextChanged(object sender, EventArgs e)
        {
            if (txt_XacNhan_TongTien.Text.Trim() != String.Empty)
            {
                try
                {
                    System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                    decimal value = decimal.Parse(txt_XacNhan_TongTien.Text, System.Globalization.NumberStyles.AllowThousands);
                    txt_XacNhan_TongTien.Text = String.Format(culture, "{0:N0}", value);
                    txt_XacNhan_TongTien.Select(txt_XacNhan_TongTien.Text.Length, 0);
                }
                catch { }
            }
        }
        private void btnXacNhanXuat_Click(object sender, EventArgs e)
        {
            try
            {
                cs_SQL _sql = new cs_SQL();

                SqlCommand _cmdCheckXuatKho = new SqlCommand("Select * from XuatKho where MaHoaDon = @mahoadon", _con);
                _cmdCheckXuatKho.Parameters.AddWithValue("@mahoadon", cbbMaHoaDon.Text.Trim());
                var _dtCheckXuatKho = _sql.readdata(_cmdCheckXuatKho);
                if(_dtCheckXuatKho.Rows.Count > 0)
                {
                    MessageBox.Show("Mã hóa đơn này đã xuất kho.");
                    return;
                }

                for (int i = 0; i < dtgrid_XuatKho.Rows.Count; i++)
                {
                    string _mahang = dtgrid_XuatKho.Rows[i].Cells[1].Value.ToString().Trim();
                    SqlCommand _cmd = new SqlCommand("Select TonKho from MaHang where MaHang = @mahang", _con);
                    _cmd.Parameters.AddWithValue("@mahang", _mahang);
                    var dt = _sql.readdata(_cmd);
                    if (dt.Rows.Count > 0)
                    {
                        int _tonkho = dt.Rows[0].Field<int>("TonKho");
                        int _conlai = _tonkho - int.Parse(dtgrid_XuatKho.Rows[i].Cells[2].Value.ToString().Replace(",", ""));
                        if(_conlai < 0)
                        {
                            MessageBox.Show("Hàng tồn kho không đủ để xuất kho, hãy nhập hàng để có thể xuất kho hóa đơn này."
                                + Environment.NewLine + "Mã hàng: " + _mahang + ". Tồn kho: " + _tonkho);
                            return;
                        }
                    }
                }

                for (int i = 0; i < dtgrid_XuatKho.Rows.Count; i++)
                {
                    string _mahang = dtgrid_XuatKho.Rows[i].Cells[1].Value.ToString().Trim();
                    SqlCommand _cmd = new SqlCommand("Select TonKho from MaHang where MaHang = @mahang", _con);
                    _cmd.Parameters.AddWithValue("@mahang", _mahang);
                    var dt = _sql.readdata(_cmd);
                    if (dt.Rows.Count > 0)
                    {
                        int _tonkho = dt.Rows[0].Field<int>("TonKho");
                        int _soluong = int.Parse(dtgrid_XuatKho.Rows[i].Cells[2].Value.ToString().Replace(",", ""));
                        int _conlai = _tonkho - _soluong;
                        SqlCommand _cmd2 = new SqlCommand("Update MaHang set TonKho = @conlai where MaHang = @mahang", _con);
                        _cmd2.Parameters.AddWithValue("@conlai", _conlai);
                        _cmd2.Parameters.AddWithValue("@mahang", _mahang);
                        _sql.exedata(_cmd2);

                        SqlCommand _cmd3 = new SqlCommand("Insert into XuatKho values (@MaHang,@SoLuong,@MaHoaDon,@MaNV,@NgayXuat)", _con);
                        _cmd3.Parameters.AddWithValue("@MaHang", _mahang);
                        _cmd3.Parameters.AddWithValue("@SoLuong", _soluong);
                        _cmd3.Parameters.AddWithValue("@MaHoaDon", cbbMaHoaDon.Text.Trim());
                        _cmd3.Parameters.AddWithValue("@MaNV", Form1._manv);
                        _cmd3.Parameters.AddWithValue("@NgayXuat", DateTime.Now);
                        _sql.exedata(_cmd3);
                        SqlCommand _cmd4 = new SqlCommand("Update DonHang set DaXuatKho = '1' where MaHoaDon = @mahoadon", _con);
                        _cmd4.Parameters.AddWithValue("@mahoadon",cbbMaHoaDon.Text.Trim());
                        _sql.exedata(_cmd4);
                    }
                }
                MessageBox.Show("Đã lưu dữ liệu xuất kho thành công.");
                //dtgrid_XuatKho.Rows.Clear();
                cbbMaHoaDon_SelectedIndexChanged(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Xuat_Xoa_Click(object sender, EventArgs e)
        {
            dtgrid_XuatKho.DataSource = null;
        }
    }
}
