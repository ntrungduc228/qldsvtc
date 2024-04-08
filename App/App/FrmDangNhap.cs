using DevExpress.XtraEditors;
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

namespace App
{
    public partial class FrmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection conn_publisher = new SqlConnection();
        private bool isSinhVien = false;
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txbTaiKhoan.Text.Trim() == "" || txbMatKhau.Text.Trim() == "")
            {
                String message;
                if (isSinhVien)
                {
                    message = "Mã sinh viên";
                }
                else
                {
                    message = "Tên đăng nhập";
                }
                MessageBox.Show(message + " và mật khẩu không được trống", "", MessageBoxButtons.OK);
                return;
            }

            if (isSinhVien == false)
            {
                Program.login = txbTaiKhoan.Text; Program.password = txbMatKhau.Text;
                if (Program.KetNoi() == 0) return;
            }
            else
            {
                Program.login = "SVKN";
                Program.password = "123456";
                if (Program.KetNoi() == 0) return;
            }

            Program.mKhoa = CmbKhoa.SelectedIndex;
            Program.mLogin = Program.login;
            Program.mPassword = Program.password;

            if (isSinhVien == false)
            {
                string strLenh = "EXEC dbo.SP_Lay_Thong_Tin_GV_Tu_Login '" + Program.login + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read(); // Đọc 1 dòng nếu dữ liệu có nhiều dùng thì dùng for lặp nếu null thì break
                Program.mGroup = Program.myReader.GetString(2);
                Program.mHoten = Program.myReader.GetString(1);
                Program.username = Program.myReader.GetString(0);
                Program.myReader.Close();
            }else
            {

            }

            Program.conn.Close();
            Program.formMain = new FrmMain();
            Program.formMain.Show();
            Program.formDangNhap.Visible = false;
        }
        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            CmbKhoa.DataSource = Program.bds_dspm;
            CmbKhoa.DisplayMember = "TENKHOA";
            CmbKhoa.ValueMember = "TENSERVER";
        }
        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publicsher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu. \nBạn xem lại tên Sever của Publisher, và tên CSDL trong chuỗi kết nối.\n" + e.Message);
                return 0;
            }
        }
        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) return;
            LayDSPM("SELECT * FROM V_DS_PHANMANH");
            CmbKhoa.SelectedIndex = 1;
            CmbKhoa.SelectedIndex = 0;
            this.CenterToScreen();
        }

        private void CmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                    return;
                Program.servername = CmbKhoa.SelectedValue.ToString();
                Console.WriteLine("servername " + Program.servername);
            }
            catch (Exception) { }
        }

        private void CbSinhVien_CheckedChanged(object sender, EventArgs e)
        {
            isSinhVien = !isSinhVien;
            if (isSinhVien)
            {
                LabelTK.Text = "Mã Sinh Viên";
                return;
            }
            LabelTK.Text = "Tài Khoản";
        }

       
    }
}