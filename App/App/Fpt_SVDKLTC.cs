using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Fpt_SVDKLTC : DevExpress.XtraEditors.XtraForm
    {
        private string maKhoa = "";

        public Fpt_SVDKLTC()
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

        void LayDSMonHoc(string nienkhoa, int hocky)
        {
            string cmd = "EXEC [dbo].[SP_LayDSMonHoc] '" + nienkhoa + "'," + hocky;

            DataTable dt = Program.ExecSqlDataTable(cmd);
            BindingSource bdsMonHoc = new BindingSource();
            bdsMonHoc.DataSource = dt;
            CmbMonHoc.DataSource = bdsMonHoc;
            CmbMonHoc.DisplayMember = "TENMH";
            CmbMonHoc.ValueMember = "MAMH";
        }

        void LayDSNhom(string nienkhoa, int hocky, string mamh)
        {
            string cmd = "EXEC [dbo].[GetAllNhom] '" + nienkhoa + "'," + hocky;
            DataTable dt = Program.ExecSqlDataTable(cmd);
            BindingSource bdsNhom = new BindingSource();
            bdsNhom.DataSource = dt;
            CmbNhom.DataSource = bdsNhom;
            CmbNhom.DisplayMember = "NHOM";
            CmbNhom.ValueMember = "NHOM";
        }

        private void CmbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CmbHocKy.SelectedIndex = 0;
                LayDSHocKy(CmbNienKhoa.SelectedValue.ToString());
                LayDSMonHoc(CmbNienKhoa.SelectedValue.ToString(), Int32.Parse(CmbHocKy.SelectedValue.ToString()));
                CmbMonHoc.SelectedIndex = 0;
                LayDSNhom(CmbNienKhoa.SelectedValue.ToString(), Int32.Parse(CmbHocKy.SelectedValue.ToString()), CmbMonHoc.SelectedValue.ToString());
            }
            catch
            {
            }
        }

        private void CmbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
                LayDSMonHoc(CmbNienKhoa.SelectedValue.ToString(), Int32.Parse(CmbHocKy.SelectedValue.ToString()));
                CmbMonHoc.SelectedIndex = 0;
                LayDSNhom(CmbNienKhoa.SelectedValue.ToString(), Int32.Parse(CmbHocKy.SelectedValue.ToString()), CmbMonHoc.SelectedValue.ToString());
            }
            catch
            {
            }
        }

        private void CmbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LayDSNhom(CmbNienKhoa.SelectedValue.ToString(), Int32.Parse(CmbHocKy.SelectedValue.ToString()), CmbMonHoc.SelectedValue.ToString());
            }
            catch
            {
            }

        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnIn_Click(object sender, EventArgs e)
        {
            Xrpt_SVDKLTC rpt = new Xrpt_SVDKLTC(CmbNienKhoa.Text, int.Parse(CmbHocKy.Text), CmbMonHoc.SelectedValue.ToString(), int.Parse(CmbNhom.Text));

            rpt.LbKhoa.Text = CmbKhoa.Text;
            rpt.LbNienKhoa.Text = CmbNienKhoa.Text;
            rpt.LbHocKy.Text = CmbHocKy.Text;
            rpt.LbNhom.Text = CmbNhom.Text;
            rpt.LbMonHoc.Text = CmbMonHoc.Text;

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void Fpt_SVDKLTC_Load(object sender, EventArgs e)
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
            LayDSMonHoc(CmbNienKhoa.SelectedValue.ToString(), Int32.Parse(CmbHocKy.SelectedValue.ToString()));
            CmbMonHoc.SelectedIndex = 0;
            LayDSNhom(CmbNienKhoa.SelectedValue.ToString(), Int32.Parse(CmbHocKy.SelectedValue.ToString()), CmbMonHoc.SelectedValue.ToString());


            if (Program.mGroup == "PGV")
                CmbKhoa.Enabled = true;
            else
                CmbKhoa.Enabled = false;
        }
    }
}