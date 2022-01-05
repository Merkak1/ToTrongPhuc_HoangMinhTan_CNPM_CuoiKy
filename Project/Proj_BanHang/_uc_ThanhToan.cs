using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace Proj_BanHang
{
    public partial class _uc_ThanhToan : UserControl
    {
        public _uc_ThanhToan()
        {
            InitializeComponent();
        }
        static string _TongTien = string.Empty;

        private void _uc_ThanhToan_Load(object sender, EventArgs e)
        {

        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            txt_TongTien.Text = _TongTien;
        }

        private void txtMaDonHang_Leave(object sender, EventArgs e)
        {
            string _madonhang = txtMaDonHang.Text.Trim();
            cs_SQL csSQL = new cs_SQL();
            SqlCommand _cmd = new SqlCommand("Select * from HoaDon where MaHoaDon = @mahoadon",cs_SQL.con);
            _cmd.Parameters.AddWithValue("@mahoadon", _madonhang);
            var dt = csSQL.readdata(_cmd);
            if(dt.Rows.Count > 0)
            {
                txt_TongTien.Text = dt.Rows[0].Field<decimal>("TongTien").ToString();
                txtTenKhachHang.Text = dt.Rows[0].Field<string>("TenKhachHang");
                rtbDiaChi.Text = dt.Rows[0].Field<string>("DiaChi");
                txtNgayDatHang.Text = dt.Rows[0].Field<DateTime>("NgayBan").ToString("dd/MM/yyyy HH:mm:ss");
                _Create_QR();
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
        public Image resizeImage(Image image, int new_height, int new_width)
        {
            Bitmap new_image = new Bitmap(new_width, new_height);
            Graphics g = Graphics.FromImage((Image)new_image);
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(image, 0, 0, new_width, new_height);
            return new_image;
        }
        private void _Create_QR()
        {
            var qrcode_text = $"2|99|{txtSDT.Text.Trim()}|{txtNguoiNhan.Text.Trim()}|{txtEmail.Text.Trim()}|0|0|{txt_TongTien.Text.Replace(",","").Trim()}";
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            EncodingOptions encodingOptions = new EncodingOptions() { Width = 500, Height = 500, Margin = 0, PureBarcode = false };
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            barcodeWriter.Renderer = new BitmapRenderer();
            barcodeWriter.Options = encodingOptions;
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap = barcodeWriter.Write(qrcode_text);
            Bitmap bm = new Bitmap(@"./MoMo_Logo.png");
            Bitmap logo = resizeImage(bm, 100, 100) as Bitmap;
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
            picBox.Image = bitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Create_QR();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn xác nhận đã thanh toán ?.", "Thanh toán.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cs_SQL _sql = new cs_SQL();
                SqlCommand _cmd = new SqlCommand("Update HoaDon set ThanhToan = '1' where MaHoaDon = @mahoadon", cs_SQL.con);
                _cmd.Parameters.AddWithValue("@mahoadon", txtMaDonHang.Text.Trim());
                int i = _sql.exedata(_cmd);
                if(i > 0)
                {
                    MessageBox.Show("Cập nhật thanh toán thành công.");
                }
                else
                {
                    MessageBox.Show("Cập nhật thanh toán thất bại.");
                }
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }
    }
}
