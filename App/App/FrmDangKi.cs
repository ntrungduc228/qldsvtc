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

namespace App
{
    public partial class FrmDangKi : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource bdsSinhVien = new BindingSource();
        private BindingSource bdsLopTinchi = new BindingSource();
        private BindingSource bdsDSLTC_HUY = new BindingSource();
        public FrmDangKi()
        {
            InitializeComponent();
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

        private void FrmDangKi_Load(object sender, EventArgs e)
        {
            string cmd = "EXEC [dbo].[SP_InDanhSachLopTinChi] '" + cbNienKhoa.Text + "', '" + cbHocKi.Text + "'";
            DataTable tableLopTC = Program.ExecSqlDataTable(cmd);
            this.bdsLopTinchi.DataSource = tableLopTC;
            this.LOPTINCHIgridControl.DataSource = this.bdsLopTinchi;
        }

        private void LOPTINCHIgridControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (bdsLopTinchi.Count > 0)
            {
                txbMaLopTinChi.Text = ((DataRowView)bdsLopTinchi[bdsLopTinchi.Position])["MALTC"].ToString();
            }

        }

        private void btnSearchSinhVien_Click(object sender, EventArgs e)
        {
            if (txbMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được thiếu!", "", MessageBoxButtons.OK);
                txbMaSV.Focus();
                return;
            }
            if (txbMaSV.Text != Program.username)
            {
                MessageBox.Show("Bạn không phải là tài khoản sinh viên này!", "", MessageBoxButtons.OK);
                txbMaSV.Focus();
                return;
            }
            txbMaSVDK.Text = txbMaSV.Text;
            string cmd = "EXEC dbo.SP_getInfoSVDKI '" + txbMaSV.Text + "'";
            string cmd1 = "EXEC dbo.SP_LIST_SVHUYDANGKY '" + txbMaSV.Text + "'";
            DataTable tableSV = Program.ExecSqlDataTable(cmd);
            DataTable tableDSLTC_HUY = Program.ExecSqlDataTable(cmd1);

            this.bdsSinhVien.DataSource = tableSV;
            this.bdsDSLTC_HUY.DataSource = tableDSLTC_HUY;
            this.SINHVIENgridControl.DataSource = this.bdsSinhVien;
            this.DSLTC_HUYgridControl.DataSource = this.bdsDSLTC_HUY;
        }

        private void SINHVIENgridControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (bdsSinhVien.Count > 0)
            {
                txbMaSVDK.Text = ((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MASV"].ToString();
            }

        }

        private void cbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadcbHocKi(cbNienKhoa.Text);
            cbHocKi.SelectedIndex = 0;
        }

        private void cbHocKi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchLopTinChi_Click(object sender, EventArgs e)
        {
            string cmd = "EXEC [dbo].[SP_InDanhSachLopTinChi] '" + cbNienKhoa.Text + "', '" + cbHocKi.Text + "'";
            DataTable tableLopTC = Program.ExecSqlDataTable(cmd);
            this.bdsLopTinchi.DataSource = tableLopTC;
            this.LOPTINCHIgridControl.DataSource = this.bdsLopTinchi;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txbMaSVDK.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được thiếu!", "", MessageBoxButtons.OK);
                txbMaSVDK.Focus();
                return;
            }
            if (bdsDSLTC_HUY.Position < 0)
            {
                MessageBox.Show("Bạn chưa chọn lớp tín chỉ để hủy");
                DSLTC_HUYgridControl.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy đăng kí lớp học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string maltc = "";
                if (((DataRowView)bdsDSLTC_HUY[bdsDSLTC_HUY.Position])["MALTC"] != null)
                {
                    maltc = ((DataRowView)bdsDSLTC_HUY[bdsDSLTC_HUY.Position])["MALTC"].ToString();
                }

                string cmd = "EXEC [dbo].[SP_XULY_LTC] '" + txbMaSVDK.Text + "' , '" + maltc + "', " + 2;
                if (Program.ExecSqlNonQuery(cmd) == 0)
                {
                    MessageBox.Show("Hủy đăng kí thành công!");
                    string cmd1 = "EXEC dbo.SP_LIST_SVHUYDANGKY '" + txbMaSV.Text + "'";
                    DataTable tableDSLTC_HUY = Program.ExecSqlDataTable(cmd1);
                    this.bdsDSLTC_HUY.DataSource = tableDSLTC_HUY;
                    this.DSLTC_HUYgridControl.DataSource = this.bdsDSLTC_HUY;
                }
                else
                {
                    MessageBox.Show("Hủy đăng kí thất bại");
                }
            }
            else
            {
                return;
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void BtnDangKi_Click(object sender, EventArgs e)
        {
            if (txbMaSVDK.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được thiếu!", "", MessageBoxButtons.OK);
                txbMaSVDK.Focus();
                return;
            }
            if (txbMaLopTinChi.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp tín chỉ không được thiếu!", "", MessageBoxButtons.OK);
                txbMaLopTinChi.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng kí lớp học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string cmd = "EXEC [dbo].[SP_XULY_LTC] '" + txbMaSVDK.Text + "' , '" + txbMaLopTinChi.Text + "', " + 1;
                if (Program.ExecSqlNonQuery(cmd) == 0)
                {
                    MessageBox.Show("Đăng kí thành công!");
                    string cmd1 = "EXEC dbo.SP_LIST_SVHUYDANGKY '" + txbMaSV.Text + "'";
                    DataTable tableDSLTC_HUY = Program.ExecSqlDataTable(cmd1);
                    this.bdsDSLTC_HUY.DataSource = tableDSLTC_HUY;
                    this.DSLTC_HUYgridControl.DataSource = this.bdsDSLTC_HUY;
                }
                else
                {
                    MessageBox.Show("Đăng kí thất bại");
                }
            }
            else
            {
                return;
            }
        }
    }
}