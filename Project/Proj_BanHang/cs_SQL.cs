using System;
using System.Data.SqlClient;
using System.Data;

namespace Proj_BanHang
{
    internal class cs_SQL
    {
        static readonly string _ConnectString = @"Data Source=DESKTOP-U2JUDT3\SQL_TAN;Initial Catalog=QuanLy_BanHang;Integrated Security=True";
        //static readonly string _MDFpath = Path.Combine(Application.StartupPath, "QuanLy_BanHang.mdf");
        //static readonly string _ConnectString = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + _MDFpath +";Integrated Security=True";
        public static SqlConnection con = new SqlConnection(_ConnectString);        
        private void openconnect()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        private void closeconnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public int exedata(SqlCommand cmd)
        {
            int i = 0;
            openconnect();
            try
            {
                SqlCommand sc = cmd;
                i = sc.ExecuteNonQuery();
            }
            catch (Exception)
            {
                i = 0;
            }
            closeconnect();
            return i;
        }
        public DataTable readdata(SqlCommand cmd)
        {
            openconnect();
            DataTable da = new DataTable();
            try
            {
                SqlCommand sc = cmd;
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sda.Fill(da);
            }
            catch (Exception)
            {
                da = null;
            }
            closeconnect();
            return da;
        }
    }
}
