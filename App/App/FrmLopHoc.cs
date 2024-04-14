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

namespace App
{
    public partial class FrmLopHoc : DevExpress.XtraEditors.XtraForm
    {
        private string makhoa = "";
        int vitri = 0;
        private string maLopSua = "";
        private string tenLopSua = "";
        private Boolean chonThem = true;
        public FrmLopHoc()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.BdsLH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FrmLopHoc_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS2.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.DS.LOP);
            //this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS2.SINHVIEN' table. You can move, or remove it, as needed.
            //this.sINHVIENTableAdapter.Fill(this.DS2.SINHVIEN);
            // TODO: This line of code loads data into the 'DS.SINHVIEN' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.DS.LOP);

            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT MAKHOA FROM KHOA");
            BindingSource bdsCN = new BindingSource();
            bdsCN.DataSource = dt;
            makhoa = ((DataRowView)bdsCN[0])["MAKHOA"].ToString();

            var dataSource = Program.bds_dspm;
            var filteredDataSource = dataSource.Cast<DataRowView>()
                .Where(row => row["TENKHOA"].ToString() != "Học Phí")
                .ToList();
            CmbKhoa.DataSource = filteredDataSource;
            CmbKhoa.DisplayMember = "TENKHOA";
            CmbKhoa.ValueMember = "TENSERVER";
            CmbKhoa.SelectedIndex = Program.mKhoa;
            panelControl2.Enabled = false;
            if (Program.mGroup == "PGV")
            {
                CmbKhoa.Enabled = true;
            }
            else
            {
                CmbKhoa.Enabled = false;
            }
            BtnGhiLH.Enabled = false;

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
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                // TODO: This line of code loads data into the 'dS2.LOP' table. You can move, or remove it, as needed.
                this.lOPTableAdapter.Fill(this.DS.LOP);
               // this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                // TODO: This line of code loads data into the 'dS2.SINHVIEN' table. You can move, or remove it, as needed.
                //this.sINHVIENTableAdapter.Fill(this.DS2.SINHVIEN);


                DataTable dt = new DataTable();
                dt = Program.ExecSqlDataTable("SELECT MAKHOA FROM KHOA");
                BindingSource bdsCN = new BindingSource();
                bdsCN.DataSource = dt;
                makhoa = ((DataRowView)bdsCN[0])["MAKHOA"].ToString();
            }
        }
    }
}