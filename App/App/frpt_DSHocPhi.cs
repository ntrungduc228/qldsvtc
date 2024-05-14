﻿using DevExpress.XtraEditors;
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
using DevExpress.XtraReports.UI;


namespace App
{
    public partial class frpt_DSHocPhi : DevExpress.XtraEditors.XtraForm
    {
        public frpt_DSHocPhi()
        {
            InitializeComponent();
        }

        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String database = "QLDSV_TC";
        public int type;
        private void frpt_DSHocPhi_Load(object sender, EventArgs e)
        {
            int type;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            dSHP.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dSHP.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.dSHP.LOP);

            cbLop.DataSource = this.dSHP.LOP;

            if (Program.mGroup.Equals("PGV") || Program.mGroup.Equals("KHOA"))
            {
                if (KetNoiSql("DESKTOP-PN0LV22\\SQLSV3", Program.remotelogin, Program.remotepassword) == 0)
                {
                    MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                }
            }
            if (Program.mGroup.Equals("KHOA")) type = 1;
            else type = 0;

            if (Program.mGroup.Equals("PKT"))
            {
                KetNoiSql("DESKTOP-PN0LV22\\SQLSV3", "GV06", "123456");

            }
            if (type == 1)
            {
                // Lấy ra những lớp có MAKHOA = 'CNNT'
                cbLop.DisplayMember = "MALOP";
                cbLop.ValueMember = "MALOP";
                if (Program.mKhoa == 0)
                {
                    this.dSHP.LOP.DefaultView.RowFilter = "MAKHOA = 'CNNT'";

                }
                if (Program.mKhoa == 1)
                {
                    this.dSHP.LOP.DefaultView.RowFilter = "MAKHOA = 'VT'";
                }
            }
            else if (type == 0)
            {
                // Hiển thị tất cả các MALOP
                cbLop.DisplayMember = "MALOP";
                cbLop.ValueMember = "MALOP";
                this.dSHP.LOP.DefaultView.RowFilter = string.Empty;
            }
        }

        public static string NumberToText(double inputNumber, bool suffix = true)
        {
            string[] unitNumbers = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] placeValues = new string[] { "", "nghìn", "triệu", "tỷ" };
            bool isNegative = false;

            // -12345678.3445435 => "-12345678"
            string sNumber = inputNumber.ToString("#");
            double number = Convert.ToDouble(sNumber);
            if (number < 0)
            {
                number = -number;
                sNumber = number.ToString();
                isNegative = true;
            }


            int ones, tens, hundreds;

            int positionDigit = sNumber.Length;   // last -> first

            string result = " ";


            if (positionDigit == 0)
                result = unitNumbers[0] + result;
            else
            {
                // 0:       ###
                // 1: nghìn ###,###
                // 2: triệu ###,###,###
                // 3: tỷ    ###,###,###,###
                int placeValue = 0;

                while (positionDigit > 0)
                {
                    // Check last 3 digits remain ### (hundreds tens ones)
                    tens = hundreds = -1;
                    ones = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                    positionDigit--;
                    if (positionDigit > 0)
                    {
                        tens = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                        positionDigit--;
                        if (positionDigit > 0)
                        {
                            hundreds = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                            positionDigit--;
                        }
                    }

                    if ((ones > 0) || (tens > 0) || (hundreds > 0) || (placeValue == 3))
                        result = placeValues[placeValue] + result;

                    placeValue++;
                    if (placeValue > 3) placeValue = 1;

                    if ((ones == 1) && (tens > 1))
                        result = "một " + result;
                    else
                    {
                        if ((ones == 5) && (tens > 0))
                            result = "lăm " + result;
                        else if (ones > 0)
                            result = unitNumbers[ones] + " " + result;
                    }
                    if (tens < 0)
                        break;
                    else
                    {
                        if ((tens == 0) && (ones > 0)) result = "lẻ " + result;
                        if (tens == 1) result = "mười " + result;
                        if (tens > 1) result = unitNumbers[tens] + " mươi " + result;
                    }
                    if (hundreds < 0) break;
                    else
                    {
                        if ((hundreds > 0) || (tens > 0) || (ones > 0))
                            result = unitNumbers[hundreds] + " trăm " + result;
                    }
                    result = " " + result;
                }
            }
            result = result.Trim();
            if (isNegative) result = "Âm " + result;
            return "(" + result + (suffix ? " đồng chẵn)" : ")");
        }


        public static int KetNoiSql(string severname, string mlogin, string password)
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
            try
            {
                connstr = "Data Source=" + severname + ";Initial Catalog=" +
                    database + ";User ID=" +
                    mlogin + ";password=" + password;
                conn.ConnectionString = connstr;
                conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu. \nBạn xem lại username và password.");
                return 0;
            }

        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSHP);

        }

        public static SqlDataReader ExecSqlDataReader(string strlenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strlenh, conn);
            sqlcmd.CommandType = CommandType.Text;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void BtnIn_Click(object sender, EventArgs e)
        {
            if (txbNienKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Niên khóa không được để trống", "", MessageBoxButtons.OK);
                txbNienKhoa.Focus();
                return;
            }
            if (nmHocKy.Value == 0)
            {
                MessageBox.Show("Học Kỳ không được để trống", "", MessageBoxButtons.OK);
                nmHocKy.Focus();
                return;
            }
            string nienkhoa = txbNienKhoa.Text;
            int hocky = (int)nmHocKy.Value;
            string malop = cbLop.Text;
            string tongtien = "";
            string cmd = "SELECT TENKHOA FROM dbo.LOP,dbo.KHOA WHERE MALOP = '" + malop + "' AND KHOA.MAKHOA = LOP.MAKHOA";
            SqlDataReader reader = ExecSqlDataReader(cmd);
            reader.Read();
            string tenkhoa = reader.GetString(0);
            reader.Close();

            string cmd1 = "EXEC [dbo].[SP_TongTienHocPhi] '" + malop + "', '" + nienkhoa + "', " + hocky;
            SqlDataReader reader1 = ExecSqlDataReader(cmd1);
            reader1.Read();
            tongtien = reader1.GetInt32(0).ToString();
            reader1.Close();



            if (tongtien != "0")
            {
                tongtien = NumberToText(double.Parse(tongtien));
            }


            Xrpt_DSHocPhi rpt = new Xrpt_DSHocPhi(malop, nienkhoa, hocky, connstr);
            rpt.lbMaLop.Text = malop;
            rpt.lbKhoa.Text = tenkhoa;
            rpt.lbTienChu.Text = tongtien;


            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}