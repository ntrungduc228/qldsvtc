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
    public partial class frm_BHDM_R : DevExpress.XtraEditors.XtraForm
    {
        string maMH;

        public frm_BHDM_R()
        {
            InitializeComponent();
        }

        private void frm_BHDM_R_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.DS.MONHOC);

            var dataSource = Program.bds_dspm;
            var filteredDataSource = dataSource.Cast<DataRowView>()
                .Where(row => row["TENKHOA"].ToString() != "PHÒNG KẾ TOÁN")
                .ToList();
            cmbKHOA.DataSource = filteredDataSource;
            cmbKHOA.DisplayMember = "TENKHOA";
            cmbKHOA.ValueMember = "TENSERVER";
            cmbKHOA.SelectedIndex = Program.mKhoa;
            cmbTENMH.DataSource = bdsMonHoc;
            cmbTENMH.DisplayMember = "TENMH";
            cmbTENMH.ValueMember = "MAMH";
            loadcbNienkhoa();
            cbNienKhoa.SelectedIndex = 0;

        }

        void loadcbNienkhoa()
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.GetAllNienKhoa";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsNienKhoa = new BindingSource();
            bdsNienKhoa.DataSource = dt;
            cbNienKhoa.DataSource = bdsNienKhoa;
            cbNienKhoa.DisplayMember = "NIENKHOA";
            cbNienKhoa.ValueMember = "NIENKHOA";
        }

        void loadcbHocKi(string nienkhoa)
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.GetAllHocKy '" + nienkhoa + "'";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsHocKi = new BindingSource();
            bdsHocKi.DataSource = dt;
            cbHocKi.DataSource = bdsHocKi;
            cbHocKi.DisplayMember = "HOCKY";
            cbHocKi.ValueMember = "HOCKY";
        }

        void loadNhom(string nienkhoa, string hocki)
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.GetAllNhom '" + nienkhoa + "', " + hocki;
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsNhom = new BindingSource();
            bdsNhom.DataSource = dt;
            cbNhom.DataSource = bdsNhom;
            cbNhom.DisplayMember = "NHOM";
            cbNhom.ValueMember = "NHOM";
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void cmbKHOA_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbKHOA.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbKHOA.SelectedValue.ToString();
            if (cmbKHOA.SelectedIndex != Program.mKhoa)
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
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                loadcbNienkhoa();
                cbNienKhoa.SelectedIndex = 0;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadcbHocKi(cbNienKhoa.Text);
           // cbHocKi.SelectedIndex = 0;
        }

        private void cbHocKi_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadNhom(cbNienKhoa.Text, cbHocKi.Text);
           // cbNhom.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nienkhoa = cbNienKhoa.Text;
            int hocky = Int32.Parse(cbHocKi.Text);
            int nhom = Int32.Parse(cbNhom.Text);
            string monhoc = cmbTENMH.SelectedValue.ToString();
            string khoa = cmbKHOA.Text;
            Frm_BDMH rpt = new Frm_BDMH(nienkhoa, hocky, nhom, monhoc);
            rpt.txtNienKhoa.Text = nienkhoa;
            rpt.txtHOCKY.Text = hocky.ToString();
            rpt.txtNHOM.Text = nhom.ToString();
            rpt.txtMONHOC.Text = cmbTENMH.Text;
            
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void cmbTENMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbTENMH.DataSource = this.DS.MONHOC;
                cmbTENMH.DisplayMember = "TENMH";
                cmbTENMH.ValueMember = "MAMH";

                maMH = cmbTENMH.SelectedValue.ToString();
            }
            catch (Exception ex)
            {

            }
        }
    }
}