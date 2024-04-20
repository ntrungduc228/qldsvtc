
namespace App
{
    partial class FrmLopHoc
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label kHOAHOCLabel;
            System.Windows.Forms.Label mAKHOALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLopHoc));
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.BtnThemLH = new DevExpress.XtraBars.BarButtonItem();
            this.BtnGhiLH = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPhucHoiLH = new DevExpress.XtraBars.BarButtonItem();
            this.BtnXoaLH = new DevExpress.XtraBars.BarButtonItem();
            this.BtnLamMoiLH = new DevExpress.XtraBars.BarButtonItem();
            this.BtnThoatLH = new DevExpress.XtraBars.BarButtonItem();
            this.BtnSuaLH = new DevExpress.XtraBars.BarButtonItem();
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.themCTHPBarbutton = new DevExpress.XtraBars.BarButtonItem();
            this.ghiCTHPBtn = new DevExpress.XtraBars.BarButtonItem();
            this.PHCTHPBtn = new DevExpress.XtraBars.BarButtonItem();
            this.btnTest = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.CmbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DS = new App.DS();
            this.BdsLH = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new App.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new App.DSTableAdapters.TableAdapterManager();
            this.GcLopHoc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHOAHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TxtMaLop = new System.Windows.Forms.TextBox();
            this.TxtTenLop = new System.Windows.Forms.TextBox();
            this.TxtKhoaHoc = new System.Windows.Forms.TextBox();
            this.TxtMaKhoa = new System.Windows.Forms.TextBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.BdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new App.DSTableAdapters.SINHVIENTableAdapter();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            kHOAHOCLabel = new System.Windows.Forms.Label();
            mAKHOALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BdsLH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcLopHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BdsSV)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            mALOPLabel.Location = new System.Drawing.Point(58, 96);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(63, 17);
            mALOPLabel.TabIndex = 0;
            mALOPLabel.Text = "Mã Lớp:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            tENLOPLabel.Location = new System.Drawing.Point(58, 144);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(69, 17);
            tENLOPLabel.TabIndex = 2;
            tENLOPLabel.Text = "Tên Lớp:";
            // 
            // kHOAHOCLabel
            // 
            kHOAHOCLabel.AutoSize = true;
            kHOAHOCLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            kHOAHOCLabel.Location = new System.Drawing.Point(58, 197);
            kHOAHOCLabel.Name = "kHOAHOCLabel";
            kHOAHOCLabel.Size = new System.Drawing.Size(80, 17);
            kHOAHOCLabel.TabIndex = 4;
            kHOAHOCLabel.Text = "Khóa Học:";
            // 
            // mAKHOALabel
            // 
            mAKHOALabel.AutoSize = true;
            mAKHOALabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            mAKHOALabel.Location = new System.Drawing.Point(58, 256);
            mAKHOALabel.Name = "mAKHOALabel";
            mAKHOALabel.Size = new System.Drawing.Size(73, 17);
            mAKHOALabel.TabIndex = 6;
            mAKHOALabel.Text = "Mã Khoa:";
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4,
            this.bar5,
            this.bar6});
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.DockControls.Add(this.barDockControl5);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.BtnThemLH,
            this.BtnGhiLH,
            this.BtnPhucHoiLH,
            this.BtnXoaLH,
            this.BtnLamMoiLH,
            this.BtnThoatLH,
            this.themCTHPBarbutton,
            this.ghiCTHPBtn,
            this.PHCTHPBtn,
            this.btnTest,
            this.barButtonItem7,
            this.barButtonItem1,
            this.BtnSuaLH});
            this.barManager2.MainMenu = this.bar5;
            this.barManager2.MaxItemId = 13;
            this.barManager2.StatusBar = this.bar6;
            // 
            // bar4
            // 
            this.bar4.BarName = "Tools";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 1;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.Text = "Tools";
            // 
            // bar5
            // 
            this.bar5.BarName = "Main menu";
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnThemLH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnGhiLH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnPhucHoiLH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnXoaLH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnLamMoiLH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnThoatLH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnSuaLH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar5.OptionsBar.MultiLine = true;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Main menu";
            // 
            // BtnThemLH
            // 
            this.BtnThemLH.Caption = "Thêm";
            this.BtnThemLH.Id = 0;
            this.BtnThemLH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnThemLH.ImageOptions.SvgImage")));
            this.BtnThemLH.Name = "BtnThemLH";
            this.BtnThemLH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnThemLH_ItemClick);
            // 
            // BtnGhiLH
            // 
            this.BtnGhiLH.Caption = "Ghi";
            this.BtnGhiLH.Id = 1;
            this.BtnGhiLH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnGhiLH.ImageOptions.SvgImage")));
            this.BtnGhiLH.Name = "BtnGhiLH";
            this.BtnGhiLH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnGhiLH_ItemClick);
            // 
            // BtnPhucHoiLH
            // 
            this.BtnPhucHoiLH.Caption = "Phục hồi";
            this.BtnPhucHoiLH.Id = 2;
            this.BtnPhucHoiLH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnPhucHoiLH.ImageOptions.SvgImage")));
            this.BtnPhucHoiLH.Name = "BtnPhucHoiLH";
            this.BtnPhucHoiLH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPhucHoiLH_ItemClick);
            // 
            // BtnXoaLH
            // 
            this.BtnXoaLH.Caption = "Xóa";
            this.BtnXoaLH.Id = 3;
            this.BtnXoaLH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnXoaLH.ImageOptions.Image")));
            this.BtnXoaLH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnXoaLH.ImageOptions.LargeImage")));
            this.BtnXoaLH.Name = "BtnXoaLH";
            this.BtnXoaLH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnXoaLH_ItemClick);
            // 
            // BtnLamMoiLH
            // 
            this.BtnLamMoiLH.Caption = "Làm mới";
            this.BtnLamMoiLH.Id = 4;
            this.BtnLamMoiLH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnLamMoiLH.ImageOptions.SvgImage")));
            this.BtnLamMoiLH.Name = "BtnLamMoiLH";
            this.BtnLamMoiLH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnLamMoiLH_ItemClick);
            // 
            // BtnThoatLH
            // 
            this.BtnThoatLH.Caption = "Thoát";
            this.BtnThoatLH.Id = 5;
            this.BtnThoatLH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnThoatLH.ImageOptions.SvgImage")));
            this.BtnThoatLH.Name = "BtnThoatLH";
            this.BtnThoatLH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnThoatLH_ItemClick);
            // 
            // BtnSuaLH
            // 
            this.BtnSuaLH.Caption = "Sửa";
            this.BtnSuaLH.Id = 12;
            this.BtnSuaLH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSuaLH.ImageOptions.Image")));
            this.BtnSuaLH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnSuaLH.ImageOptions.LargeImage")));
            this.BtnSuaLH.Name = "BtnSuaLH";
            this.BtnSuaLH.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            this.BtnSuaLH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSuaLH_ItemClick);
            // 
            // bar6
            // 
            this.bar6.BarName = "Status bar";
            this.bar6.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar6.DockCol = 0;
            this.bar6.DockRow = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar6.OptionsBar.AllowQuickCustomization = false;
            this.bar6.OptionsBar.DrawDragBorder = false;
            this.bar6.OptionsBar.UseWholeRow = true;
            this.bar6.Text = "Status bar";
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl2.Location = new System.Drawing.Point(0, 0);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControl2.Size = new System.Drawing.Size(1583, 51);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl3.Location = new System.Drawing.Point(0, 720);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControl3.Size = new System.Drawing.Size(1583, 20);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl4.Location = new System.Drawing.Point(0, 51);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControl4.Size = new System.Drawing.Size(0, 669);
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl5.Location = new System.Drawing.Point(1583, 51);
            this.barDockControl5.Manager = this.barManager2;
            this.barDockControl5.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControl5.Size = new System.Drawing.Size(0, 669);
            // 
            // themCTHPBarbutton
            // 
            this.themCTHPBarbutton.Caption = "Thêm CTHP";
            this.themCTHPBarbutton.Id = 6;
            this.themCTHPBarbutton.Name = "themCTHPBarbutton";
            // 
            // ghiCTHPBtn
            // 
            this.ghiCTHPBtn.Caption = "Ghi CTHP";
            this.ghiCTHPBtn.Id = 7;
            this.ghiCTHPBtn.Name = "ghiCTHPBtn";
            // 
            // PHCTHPBtn
            // 
            this.PHCTHPBtn.Caption = "ph CTHP";
            this.PHCTHPBtn.Id = 8;
            this.PHCTHPBtn.Name = "PHCTHPBtn";
            // 
            // btnTest
            // 
            this.btnTest.Id = 9;
            this.btnTest.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTest.ImageOptions.Image")));
            this.btnTest.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTest.ImageOptions.LargeImage")));
            this.btnTest.Name = "btnTest";
            this.btnTest.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "test";
            this.barButtonItem7.Id = 10;
            this.barButtonItem7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
            this.barButtonItem7.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.LargeImage")));
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Sửa";
            this.barButtonItem1.Id = 11;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.CmbKhoa);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 51);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1583, 76);
            this.panelControl1.TabIndex = 9;
            // 
            // CmbKhoa
            // 
            this.CmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbKhoa.FormattingEnabled = true;
            this.CmbKhoa.Location = new System.Drawing.Point(132, 18);
            this.CmbKhoa.Name = "CmbKhoa";
            this.CmbKhoa.Size = new System.Drawing.Size(319, 24);
            this.CmbKhoa.TabIndex = 1;
            this.CmbKhoa.SelectedIndexChanged += new System.EventHandler(this.CmbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(42, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoa:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(0, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1583, 41);
            this.label2.TabIndex = 36;
            this.label2.Text = "Danh sách lớp học";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BdsLH
            // 
            this.BdsLH.DataMember = "LOP";
            this.BdsLH.DataSource = this.DS;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = App.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // GcLopHoc
            // 
            this.GcLopHoc.DataSource = this.BdsLH;
            this.GcLopHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.GcLopHoc.Location = new System.Drawing.Point(0, 168);
            this.GcLopHoc.MainView = this.gridView1;
            this.GcLopHoc.MenuManager = this.barManager2;
            this.GcLopHoc.Name = "GcLopHoc";
            this.GcLopHoc.Size = new System.Drawing.Size(1583, 182);
            this.GcLopHoc.TabIndex = 37;
            this.GcLopHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colKHOAHOC,
            this.colMAKHOA});
            this.gridView1.GridControl = this.GcLopHoc;
            this.gridView1.Name = "gridView1";
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 25;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 94;
            // 
            // colTENLOP
            // 
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 25;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 94;
            // 
            // colKHOAHOC
            // 
            this.colKHOAHOC.FieldName = "KHOAHOC";
            this.colKHOAHOC.MinWidth = 25;
            this.colKHOAHOC.Name = "colKHOAHOC";
            this.colKHOAHOC.Visible = true;
            this.colKHOAHOC.VisibleIndex = 2;
            this.colKHOAHOC.Width = 94;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.MinWidth = 25;
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 3;
            this.colMAKHOA.Width = 94;
            // 
            // TxtMaLop
            // 
            this.TxtMaLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BdsLH, "MALOP", true));
            this.TxtMaLop.Location = new System.Drawing.Point(192, 88);
            this.TxtMaLop.Name = "TxtMaLop";
            this.TxtMaLop.Size = new System.Drawing.Size(301, 23);
            this.TxtMaLop.TabIndex = 1;
            // 
            // TxtTenLop
            // 
            this.TxtTenLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BdsLH, "TENLOP", true));
            this.TxtTenLop.Location = new System.Drawing.Point(192, 144);
            this.TxtTenLop.Name = "TxtTenLop";
            this.TxtTenLop.Size = new System.Drawing.Size(301, 23);
            this.TxtTenLop.TabIndex = 3;
            // 
            // TxtKhoaHoc
            // 
            this.TxtKhoaHoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BdsLH, "KHOAHOC", true));
            this.TxtKhoaHoc.Location = new System.Drawing.Point(192, 197);
            this.TxtKhoaHoc.Name = "TxtKhoaHoc";
            this.TxtKhoaHoc.Size = new System.Drawing.Size(301, 23);
            this.TxtKhoaHoc.TabIndex = 5;
            // 
            // TxtMaKhoa
            // 
            this.TxtMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BdsLH, "MAKHOA", true));
            this.TxtMaKhoa.Enabled = false;
            this.TxtMaKhoa.Location = new System.Drawing.Point(192, 256);
            this.TxtMaKhoa.Name = "TxtMaKhoa";
            this.TxtMaKhoa.Size = new System.Drawing.Size(301, 23);
            this.TxtMaKhoa.TabIndex = 7;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(mAKHOALabel);
            this.panelControl2.Controls.Add(this.TxtMaKhoa);
            this.panelControl2.Controls.Add(kHOAHOCLabel);
            this.panelControl2.Controls.Add(this.TxtKhoaHoc);
            this.panelControl2.Controls.Add(tENLOPLabel);
            this.panelControl2.Controls.Add(this.TxtTenLop);
            this.panelControl2.Controls.Add(mALOPLabel);
            this.panelControl2.Controls.Add(this.TxtMaLop);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 391);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1583, 329);
            this.panelControl2.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(0, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1583, 38);
            this.label3.TabIndex = 43;
            this.label3.Text = "Thông tin lớp học";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BdsSV
            // 
            this.BdsSV.DataMember = "FK_SINHVIEN_LOP";
            this.BdsSV.DataSource = this.BdsLH;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // FrmLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 740);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.GcLopHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl5);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl2);
            this.Name = "FrmLopHoc";
            this.Text = "FrmLopHoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BdsLH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcLopHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BdsSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarButtonItem BtnThemLH;
        private DevExpress.XtraBars.BarButtonItem BtnGhiLH;
        private DevExpress.XtraBars.BarButtonItem BtnPhucHoiLH;
        private DevExpress.XtraBars.BarButtonItem BtnXoaLH;
        private DevExpress.XtraBars.BarButtonItem BtnLamMoiLH;
        private DevExpress.XtraBars.BarButtonItem BtnThoatLH;
        private DevExpress.XtraBars.BarButtonItem BtnSuaLH;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarButtonItem themCTHPBarbutton;
        private DevExpress.XtraBars.BarButtonItem ghiCTHPBtn;
        private DevExpress.XtraBars.BarButtonItem PHCTHPBtn;
        private DevExpress.XtraBars.BarButtonItem btnTest;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.BindingSource BdsLH;
        private DS DS;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox CmbKhoa;
        private System.Windows.Forms.Label label1;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl GcLopHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colKHOAHOC;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.TextBox TxtMaKhoa;
        private System.Windows.Forms.TextBox TxtKhoaHoc;
        private System.Windows.Forms.TextBox TxtTenLop;
        private System.Windows.Forms.TextBox TxtMaLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource BdsSV;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
    }
}