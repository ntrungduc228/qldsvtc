
namespace App
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.BtnLopHoc = new DevExpress.XtraBars.BarButtonItem();
            this.BtnMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.BtnLopTC = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDangKy = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDSLTC = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnBDHM = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPhieuDiemSV = new DevExpress.XtraBars.BarButtonItem();
            this.BtnInHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnTaoTK = new DevExpress.XtraBars.BarButtonItem();
            this.BtnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.HeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.BaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.CauHinh = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MA = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.BtnSinhVien,
            this.BtnLopHoc,
            this.BtnMonHoc,
            this.BtnLopTC,
            this.BtnDiem,
            this.btnHocPhi,
            this.BtnDangKy,
            this.BtnDSLTC,
            this.barButtonItem8,
            this.BtnBDHM,
            this.BtnPhieuDiemSV,
            this.BtnInHocPhi,
            this.barButtonItem12,
            this.BtnTaoTK,
            this.BtnLogout});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 17;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.HeThong,
            this.BaoCao,
            this.CauHinh});
            this.ribbon.Size = new System.Drawing.Size(1135, 209);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // BtnSinhVien
            // 
            this.BtnSinhVien.Caption = "Sinh Viên";
            this.BtnSinhVien.Id = 1;
            this.BtnSinhVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSinhVien.ImageOptions.Image")));
            this.BtnSinhVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnSinhVien.ImageOptions.LargeImage")));
            this.BtnSinhVien.LargeWidth = 60;
            this.BtnSinhVien.Name = "BtnSinhVien";
            this.BtnSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSinhVien_ItemClick);
            // 
            // BtnLopHoc
            // 
            this.BtnLopHoc.Caption = "Lớp học";
            this.BtnLopHoc.Id = 2;
            this.BtnLopHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnLopHoc.ImageOptions.Image")));
            this.BtnLopHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnLopHoc.ImageOptions.LargeImage")));
            this.BtnLopHoc.LargeWidth = 60;
            this.BtnLopHoc.Name = "BtnLopHoc";
            this.BtnLopHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnLopHoc_ItemClick);
            // 
            // BtnMonHoc
            // 
            this.BtnMonHoc.Caption = "Môn học";
            this.BtnMonHoc.Id = 3;
            this.BtnMonHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnMonHoc.ImageOptions.Image")));
            this.BtnMonHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnMonHoc.ImageOptions.LargeImage")));
            this.BtnMonHoc.LargeWidth = 60;
            this.BtnMonHoc.Name = "BtnMonHoc";
            this.BtnMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnMonHoc_ItemClick);
            // 
            // BtnLopTC
            // 
            this.BtnLopTC.Caption = "Lớp TC";
            this.BtnLopTC.Id = 4;
            this.BtnLopTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnLopTC.ImageOptions.Image")));
            this.BtnLopTC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnLopTC.ImageOptions.LargeImage")));
            this.BtnLopTC.LargeWidth = 60;
            this.BtnLopTC.Name = "BtnLopTC";
            this.BtnLopTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnLopTC_ItemClick);
            // 
            // BtnDiem
            // 
            this.BtnDiem.Caption = "Điểm";
            this.BtnDiem.Id = 5;
            this.BtnDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDiem.ImageOptions.Image")));
            this.BtnDiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnDiem.ImageOptions.LargeImage")));
            this.BtnDiem.LargeWidth = 60;
            this.BtnDiem.Name = "BtnDiem";
            this.BtnDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDiem_ItemClick);
            // 
            // btnHocPhi
            // 
            this.btnHocPhi.Caption = "Học phí";
            this.btnHocPhi.Id = 6;
            this.btnHocPhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHocPhi.ImageOptions.Image")));
            this.btnHocPhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHocPhi.ImageOptions.LargeImage")));
            this.btnHocPhi.LargeWidth = 60;
            this.btnHocPhi.Name = "btnHocPhi";
            this.btnHocPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHocPhi_ItemClick);
            // 
            // BtnDangKy
            // 
            this.BtnDangKy.Caption = "Đăng ký";
            this.BtnDangKy.Id = 7;
            this.BtnDangKy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDangKy.ImageOptions.Image")));
            this.BtnDangKy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnDangKy.ImageOptions.LargeImage")));
            this.BtnDangKy.LargeWidth = 60;
            this.BtnDangKy.Name = "BtnDangKy";
            this.BtnDangKy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDangKy_ItemClick);
            // 
            // BtnDSLTC
            // 
            this.BtnDSLTC.Caption = "In DSLTC";
            this.BtnDSLTC.Id = 8;
            this.BtnDSLTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDSLTC.ImageOptions.Image")));
            this.BtnDSLTC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnDSLTC.ImageOptions.LargeImage")));
            this.BtnDSLTC.LargeWidth = 60;
            this.BtnDSLTC.Name = "BtnDSLTC";
            this.BtnDSLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDSLTC_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "In DSSV DKLTC";
            this.barButtonItem8.Id = 9;
            this.barButtonItem8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
            this.barButtonItem8.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.LargeImage")));
            this.barButtonItem8.LargeWidth = 60;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // BtnBDHM
            // 
            this.BtnBDHM.Caption = "In BDMH";
            this.BtnBDHM.Id = 10;
            this.BtnBDHM.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnBDHM.ImageOptions.Image")));
            this.BtnBDHM.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnBDHM.ImageOptions.LargeImage")));
            this.BtnBDHM.LargeWidth = 60;
            this.BtnBDHM.Name = "BtnBDHM";
            this.BtnBDHM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnBDHM_ItemClick);
            // 
            // BtnPhieuDiemSV
            // 
            this.BtnPhieuDiemSV.Caption = "In Phiếu điểm SV";
            this.BtnPhieuDiemSV.Id = 11;
            this.BtnPhieuDiemSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPhieuDiemSV.ImageOptions.Image")));
            this.BtnPhieuDiemSV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnPhieuDiemSV.ImageOptions.LargeImage")));
            this.BtnPhieuDiemSV.LargeWidth = 60;
            this.BtnPhieuDiemSV.Name = "BtnPhieuDiemSV";
            this.BtnPhieuDiemSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPhieuDiemSV_ItemClick);
            // 
            // BtnInHocPhi
            // 
            this.BtnInHocPhi.Caption = "In DS Học phí";
            this.BtnInHocPhi.Id = 12;
            this.BtnInHocPhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnInHocPhi.ImageOptions.Image")));
            this.BtnInHocPhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnInHocPhi.ImageOptions.LargeImage")));
            this.BtnInHocPhi.LargeWidth = 60;
            this.BtnInHocPhi.Name = "BtnInHocPhi";
            this.BtnInHocPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnInHocPhi_ItemClick);
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "In Bảng điểm TK";
            this.barButtonItem12.Id = 13;
            this.barButtonItem12.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem12.ImageOptions.Image")));
            this.barButtonItem12.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem12.ImageOptions.LargeImage")));
            this.barButtonItem12.LargeWidth = 60;
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // BtnTaoTK
            // 
            this.BtnTaoTK.Caption = "Tạo tài khoản";
            this.BtnTaoTK.Id = 14;
            this.BtnTaoTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem13.ImageOptions.Image")));
            this.BtnTaoTK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem13.ImageOptions.LargeImage")));
            this.BtnTaoTK.LargeWidth = 60;
            this.BtnTaoTK.Name = "BtnTaoTK";
            this.BtnTaoTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnTaoTK_ItemClick);
            // 
            // BtnLogout
            // 
            this.BtnLogout.Caption = "Đăng xuất";
            this.BtnLogout.Id = 16;
            this.BtnLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnLogout.ImageOptions.Image")));
            this.BtnLogout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnLogout.ImageOptions.LargeImage")));
            this.BtnLogout.LargeWidth = 60;
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnLogout_ItemClick);
            // 
            // HeThong
            // 
            this.HeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.HeThong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("HeThong.ImageOptions.Image")));
            this.HeThong.Name = "HeThong";
            this.HeThong.Text = "Hệ Thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnSinhVien);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnLopHoc);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnMonHoc);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnLopTC);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnDiem);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHocPhi);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnDangKy);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quản lý dữ liệu";
            // 
            // BaoCao
            // 
            this.BaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.BaoCao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BaoCao.ImageOptions.Image")));
            this.BaoCao.Name = "BaoCao";
            this.BaoCao.Text = "Báo cáo";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnDSLTC);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnBDHM);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnPhieuDiemSV);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnInHocPhi);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem12);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // CauHinh
            // 
            this.CauHinh.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.CauHinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CauHinh.ImageOptions.Image")));
            this.CauHinh.Name = "CauHinh";
            this.CauHinh.Text = "Cấu hình";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnTaoTK);
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnLogout);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Chức năng";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 536);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1135, 30);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MA,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1135, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MA
            // 
            this.MA.Name = "MA";
            this.MA.Size = new System.Drawing.Size(32, 20);
            this.MA.Text = "MA";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(57, 20);
            this.HOTEN.Text = "HOTEN";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(55, 20);
            this.NHOM.Text = "NHOM";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 566);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản lý DSVTC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage HeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem BtnSinhVien;
        private DevExpress.XtraBars.BarButtonItem BtnLopHoc;
        private DevExpress.XtraBars.BarButtonItem BtnMonHoc;
        private DevExpress.XtraBars.BarButtonItem BtnLopTC;
        private DevExpress.XtraBars.BarButtonItem BtnDiem;
        private DevExpress.XtraBars.BarButtonItem btnHocPhi;
        private DevExpress.XtraBars.BarButtonItem BtnDangKy;
        private DevExpress.XtraBars.BarButtonItem BtnDSLTC;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem BtnBDHM;
        private DevExpress.XtraBars.BarButtonItem BtnPhieuDiemSV;
        private DevExpress.XtraBars.Ribbon.RibbonPage BaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem BtnInHocPhi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem BtnTaoTK;
        private DevExpress.XtraBars.BarButtonItem BtnLogout;
        private DevExpress.XtraBars.Ribbon.RibbonPage CauHinh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MA;
        private System.Windows.Forms.ToolStripStatusLabel HOTEN;
        private System.Windows.Forms.ToolStripStatusLabel NHOM;
    }
}