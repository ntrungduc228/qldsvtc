using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;


namespace App
{
    public partial class Frpt_LTC : DevExpress.XtraEditors.XtraForm
    {
        private string maKhoa = "";

        public Frpt_LTC()
        {
            InitializeComponent();
        }

        void LayDSHocKy(string nienkhoa)
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC SP_LayDSHocKy '" + nienkhoa + "'";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsHocKi = new BindingSource();
            bdsHocKi.DataSource = dt;
            CmbHocKy.DataSource = bdsHocKi;
            CmbHocKy.DisplayMember = "HOCKY";
            CmbHocKy.ValueMember = "HOCKY";
        }

        void LayDSNienKhoa()
        {
            string cmd = "SELECT * FROM [dbo].[LayDSNienKhoa]";
            DataTable dt = Program.ExecSqlDataTable(cmd);
            BindingSource bdsNienKhoa = new BindingSource();
            bdsNienKhoa.DataSource = dt;
            CmbNienKhoa.DataSource = bdsNienKhoa;
            CmbNienKhoa.DisplayMember = "NIENKHOA";
            CmbNienKhoa.ValueMember = "NIENKHOA";
            //CmbNienKhoa.SelectedIndex = 0;
        }

        private void Frpt_LTC_Load(object sender, EventArgs e)
        {
            var dataSource = Program.bds_dspm;
            var filteredDataSource = dataSource.Cast<DataRowView>()
                .Where(row => row["TENKHOA"].ToString() != "PHÒNG KẾ TOÁN")
                .ToList();
            CmbKhoa.DataSource = filteredDataSource;
            CmbKhoa.DisplayMember = "TENKHOA";
            CmbKhoa.ValueMember = "TENSERVER";
            CmbKhoa.SelectedIndex = Program.mKhoa;



            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT MAKHOA FROM KHOA");
            BindingSource bdsCN = new BindingSource();
            bdsCN.DataSource = dt;
            maKhoa = ((DataRowView)bdsCN[0])["MAKHOA"].ToString();

            LayDSNienKhoa();
            CmbNienKhoa.SelectedIndex = 0;
            LayDSHocKy(CmbNienKhoa.SelectedValue.ToString());

            if (Program.mGroup == "PGV")
                CmbKhoa.Enabled = true;
            else
                CmbKhoa.Enabled = false;
        }

        private void CmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.servername = CmbKhoa.SelectedValue.ToString();
            if (CmbKhoa.SelectedIndex != Program.mKhoa)
            {
                Program.login = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.login = Program.mLogin;
                Program.password = Program.mPassword;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {



                DataTable dt = new DataTable();
                dt = Program.ExecSqlDataTable("SELECT MAKHOA FROM KHOA");
                BindingSource bdsCN = new BindingSource();
                bdsCN.DataSource = dt;
                maKhoa = ((DataRowView)bdsCN[0])["MAKHOA"].ToString();

                LayDSNienKhoa();
                CmbNienKhoa.SelectedIndex = 0;
                LayDSHocKy(CmbNienKhoa.SelectedValue.ToString());

            }
        }

        private void CmbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CmbHocKy.SelectedIndex = 0;
                LayDSHocKy(CmbNienKhoa.SelectedValue.ToString());

            }
            catch
            {
            }
        }

        private void BtnIn_Click(object sender, EventArgs e)
        {
            Xrpt_LTC rpt = new Xrpt_LTC(CmbNienKhoa.Text, int.Parse(CmbHocKy.Text));

            rpt.LbKhoa.Text = CmbKhoa.Text;
            rpt.LbNienKhoa.Text = CmbNienKhoa.Text;
            rpt.LbHocKy.Text = CmbHocKy.Text;

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}