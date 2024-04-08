using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace App
{
    static class Program
    {
        public static SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PN0LV22;Initial Catalog=QLDSV_TC;Persist Security Info=True;User ID=sa;Password=123");
        public static String connstr;
        public static String connstr_publicsher = "Data Source=DESKTOP-PN0LV22; Initial Catalog=QLDSV_TC;User ID=sa;Password=123";
        public static SqlDataAdapter da;
        public static SqlDataReader myReader;
        public static String servername = "DESKTOP-PN0LV22";
        public static String servername1 = "DESKTOP-PN0LV22\\SQLSV1";
        public static String servername2 = "DESKTOP-PN0LV22\\SQLSV2";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";
        public static String login = "";

        public static String database = "QLDSV_TC";
        public static String remotelogin = "HTKN";
        public static String remotepassword = "123456";
        public static String mLogin = "";
        public static String mPassword = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mKhoa = 0;

        public static BindingSource bds_dspm = new BindingSource();
        public static FrmMain formMain;
        public static FrmDangNhap formDangNhap;
        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open) Program.conn.Close();
            try
            {
                Console.WriteLine(Program.password);
                Console.WriteLine(Program.servername);
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" + Program.database + ";User ID=" +
                      Program.login + ";Password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            try
            {
                da.Fill(dt); Program.conn.Close();
                return dt;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut 
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           // Application.Run(new FrmDangNhap());
             formMain = new FrmMain();
            formDangNhap = new FrmDangNhap();
            Application.Run(formDangNhap);
           // Application.Run(new FrmMain());
        }
    }
}
