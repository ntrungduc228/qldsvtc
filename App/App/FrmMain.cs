using DevExpress.XtraBars;
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
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.MA.Text = "Mã: " + Program.username;
            this.HOTEN.Text = "Họ và tên: " + Program.mHoten;
            this.NHOM.Text = "Nhóm: " + Program.mGroup;
        }

        private void ShowMdiChildren(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    f.Activate();
                    return;
                }
            }
            Form form = (Form)Activator.CreateInstance(fType);
            form.MdiParent = this;
            form.Show();
        }

        private void BtnLopHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FrmLopHoc));
        }

        private void BtnSinhVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FrmSinhVien));
        }

        private void BtnMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FrmMonHoc));
        }

        private void BtnLopTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FrmLTC));

        }

        private void btnHocPhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FrmHocPhi));

        }

        private void BtnDSLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Frpt_LTC));
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Fpt_SVDKLTC));

        }

        private void BtnDangKy_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FrmDangKi));

        }

        private void BtnDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FrmDiem));

        }

        private void BtnBDHM_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frm_BHDM_R));

        }

        private void BtnPhieuDiemSV_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Frm_PhieuDiemSV));

        }

        private void BtnInHocPhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frpt_DSHocPhi));

        }

        private void BtnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
            Program.formDangNhap.Visible = true;


            this.Close();
        }

        private void BtnTaoTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Frm_TaoTK));
        }
    }
}