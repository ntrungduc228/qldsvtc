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
    }
}