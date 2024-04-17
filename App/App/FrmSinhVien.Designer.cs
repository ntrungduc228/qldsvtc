
namespace App
{
    partial class FrmSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSinhVien));
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.BtnThem = new DevExpress.XtraBars.BarButtonItem();
            this.BtnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.BtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.BtnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.BtnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.BtnSua = new DevExpress.XtraBars.BarButtonItem();
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
            this.dS = new App.DS();
            this.BdsLH = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new App.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new App.DSTableAdapters.TableAdapterManager();
            this.lOPGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.nGAYSINHLabel1 = new System.Windows.Forms.Label();
            this.nGAYSINHDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.dANGHIHOCLabel = new System.Windows.Forms.Label();
            this.CbNghiHoc = new System.Windows.Forms.CheckBox();
            this.pHAILabel = new System.Windows.Forms.Label();
            this.CbPhai = new System.Windows.Forms.CheckBox();
            this.mALOPLabel = new System.Windows.Forms.Label();
            this.TxtMaLop = new System.Windows.Forms.TextBox();
            this.dIACHILabel = new System.Windows.Forms.Label();
            this.dIACHITextBox = new System.Windows.Forms.TextBox();
            this.tENLabel = new System.Windows.Forms.Label();
            this.TxtTenSV = new System.Windows.Forms.TextBox();
            this.hOLabel = new System.Windows.Forms.Label();
            this.TxtHo = new System.Windows.Forms.TextBox();
            this.mASVLabel = new System.Windows.Forms.Label();
            this.TxtMaSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BdsLH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.BtnThem,
            this.BtnGhi,
            this.BtnPhucHoi,
            this.BtnXoa,
            this.BtnLamMoi,
            this.BtnThoat,
            this.themCTHPBarbutton,
            this.ghiCTHPBtn,
            this.PHCTHPBtn,
            this.btnTest,
            this.barButtonItem7,
            this.barButtonItem1,
            this.BtnSua});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar5.OptionsBar.MultiLine = true;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Main menu";
            // 
            // BtnThem
            // 
            this.BtnThem.Caption = "Thêm";
            this.BtnThem.Id = 0;
            this.BtnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnThem.ImageOptions.SvgImage")));
            this.BtnThem.Name = "BtnThem";
            // 
            // BtnGhi
            // 
            this.BtnGhi.Caption = "Ghi";
            this.BtnGhi.Id = 1;
            this.BtnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnGhi.ImageOptions.SvgImage")));
            this.BtnGhi.Name = "BtnGhi";
            // 
            // BtnPhucHoi
            // 
            this.BtnPhucHoi.Caption = "Phục hồi";
            this.BtnPhucHoi.Id = 2;
            this.BtnPhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnPhucHoi.ImageOptions.SvgImage")));
            this.BtnPhucHoi.Name = "BtnPhucHoi";
            // 
            // BtnXoa
            // 
            this.BtnXoa.Caption = "Xóa";
            this.BtnXoa.Id = 3;
            this.BtnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnXoa.ImageOptions.Image")));
            this.BtnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnXoa.ImageOptions.LargeImage")));
            this.BtnXoa.Name = "BtnXoa";
            // 
            // BtnLamMoi
            // 
            this.BtnLamMoi.Caption = "Làm mới";
            this.BtnLamMoi.Id = 4;
            this.BtnLamMoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnLamMoi.ImageOptions.SvgImage")));
            this.BtnLamMoi.Name = "BtnLamMoi";
            // 
            // BtnThoat
            // 
            this.BtnThoat.Caption = "Thoát";
            this.BtnThoat.Id = 5;
            this.BtnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnThoat.ImageOptions.SvgImage")));
            this.BtnThoat.Name = "BtnThoat";
            // 
            // BtnSua
            // 
            this.BtnSua.Caption = "Sửa";
            this.BtnSua.Id = 12;
            this.BtnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnSua.ImageOptions.SvgImage")));
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
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
            this.barDockControl2.Size = new System.Drawing.Size(1248, 51);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl3.Location = new System.Drawing.Point(0, 628);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Size = new System.Drawing.Size(1248, 20);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl4.Location = new System.Drawing.Point(0, 51);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 577);
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl5.Location = new System.Drawing.Point(1248, 51);
            this.barDockControl5.Manager = this.barManager2;
            this.barDockControl5.Size = new System.Drawing.Size(0, 577);
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
            this.btnTest.Name = "btnTest";
            this.btnTest.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "test";
            this.barButtonItem7.Id = 10;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Sửa";
            this.barButtonItem1.Id = 11;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.CmbKhoa);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 51);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1248, 43);
            this.panelControl1.TabIndex = 12;
            // 
            // CmbKhoa
            // 
            this.CmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbKhoa.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbKhoa.FormattingEnabled = true;
            this.CmbKhoa.Location = new System.Drawing.Point(93, 13);
            this.CmbKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.CmbKhoa.Name = "CmbKhoa";
            this.CmbKhoa.Size = new System.Drawing.Size(251, 26);
            this.CmbKhoa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoa:";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BdsLH
            // 
            this.BdsLH.DataMember = "LOP";
            this.BdsLH.DataSource = this.dS;
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
            // lOPGridControl
            // 
            this.lOPGridControl.DataSource = this.BdsLH;
            this.lOPGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lOPGridControl.Location = new System.Drawing.Point(0, 94);
            this.lOPGridControl.MainView = this.gridView1;
            this.lOPGridControl.MenuManager = this.barManager2;
            this.lOPGridControl.Name = "lOPGridControl";
            this.lOPGridControl.Size = new System.Drawing.Size(1248, 220);
            this.lOPGridControl.TabIndex = 13;
            this.lOPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP});
            this.gridView1.GridControl = this.lOPGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMALOP
            // 
            this.colMALOP.Caption = "Ma Lop";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 25;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 94;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.nGAYSINHLabel1);
            this.panelControl2.Controls.Add(this.nGAYSINHDateEdit);
            this.panelControl2.Controls.Add(this.dANGHIHOCLabel);
            this.panelControl2.Controls.Add(this.CbNghiHoc);
            this.panelControl2.Controls.Add(this.pHAILabel);
            this.panelControl2.Controls.Add(this.CbPhai);
            this.panelControl2.Controls.Add(this.mALOPLabel);
            this.panelControl2.Controls.Add(this.TxtMaLop);
            this.panelControl2.Controls.Add(this.dIACHILabel);
            this.panelControl2.Controls.Add(this.dIACHITextBox);
            this.panelControl2.Controls.Add(this.tENLabel);
            this.panelControl2.Controls.Add(this.TxtTenSV);
            this.panelControl2.Controls.Add(this.hOLabel);
            this.panelControl2.Controls.Add(this.TxtHo);
            this.panelControl2.Controls.Add(this.mASVLabel);
            this.panelControl2.Controls.Add(this.TxtMaSV);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(0, 314);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(581, 314);
            this.panelControl2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.Location = new System.Drawing.Point(2, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(577, 41);
            this.label2.TabIndex = 18;
            this.label2.Text = "Thông tin sinh viên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nGAYSINHLabel1
            // 
            this.nGAYSINHLabel1.AutoSize = true;
            this.nGAYSINHLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.nGAYSINHLabel1.Location = new System.Drawing.Point(13, 228);
            this.nGAYSINHLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nGAYSINHLabel1.Name = "nGAYSINHLabel1";
            this.nGAYSINHLabel1.Size = new System.Drawing.Size(87, 18);
            this.nGAYSINHLabel1.TabIndex = 16;
            this.nGAYSINHLabel1.Text = "Ngày sinh:";
            // 
            // nGAYSINHDateEdit
            // 
            this.nGAYSINHDateEdit.EditValue = null;
            this.nGAYSINHDateEdit.Location = new System.Drawing.Point(111, 224);
            this.nGAYSINHDateEdit.Margin = new System.Windows.Forms.Padding(2);
            this.nGAYSINHDateEdit.MenuManager = this.barManager2;
            this.nGAYSINHDateEdit.Name = "nGAYSINHDateEdit";
            this.nGAYSINHDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYSINHDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYSINHDateEdit.Properties.MaxValue = new System.DateTime(((long)(0)));
            this.nGAYSINHDateEdit.Size = new System.Drawing.Size(193, 22);
            this.nGAYSINHDateEdit.TabIndex = 17;
            // 
            // dANGHIHOCLabel
            // 
            this.dANGHIHOCLabel.AutoSize = true;
            this.dANGHIHOCLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.dANGHIHOCLabel.Location = new System.Drawing.Point(335, 228);
            this.dANGHIHOCLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dANGHIHOCLabel.Name = "dANGHIHOCLabel";
            this.dANGHIHOCLabel.Size = new System.Drawing.Size(118, 18);
            this.dANGHIHOCLabel.TabIndex = 14;
            this.dANGHIHOCLabel.Text = "Đang nghỉ học:";
            // 
            // CbNghiHoc
            // 
            this.CbNghiHoc.Location = new System.Drawing.Point(469, 229);
            this.CbNghiHoc.Margin = new System.Windows.Forms.Padding(2);
            this.CbNghiHoc.Name = "CbNghiHoc";
            this.CbNghiHoc.Size = new System.Drawing.Size(69, 15);
            this.CbNghiHoc.TabIndex = 15;
            this.CbNghiHoc.UseVisualStyleBackColor = true;
            // 
            // pHAILabel
            // 
            this.pHAILabel.AutoSize = true;
            this.pHAILabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.pHAILabel.Location = new System.Drawing.Point(342, 78);
            this.pHAILabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pHAILabel.Name = "pHAILabel";
            this.pHAILabel.Size = new System.Drawing.Size(46, 18);
            this.pHAILabel.TabIndex = 12;
            this.pHAILabel.Text = "Phái:";
            // 
            // CbPhai
            // 
            this.CbPhai.Location = new System.Drawing.Point(395, 79);
            this.CbPhai.Margin = new System.Windows.Forms.Padding(2);
            this.CbPhai.Name = "CbPhai";
            this.CbPhai.Size = new System.Drawing.Size(69, 15);
            this.CbPhai.TabIndex = 13;
            this.CbPhai.UseVisualStyleBackColor = true;
            // 
            // mALOPLabel
            // 
            this.mALOPLabel.AutoSize = true;
            this.mALOPLabel.Enabled = false;
            this.mALOPLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.mALOPLabel.Location = new System.Drawing.Point(342, 174);
            this.mALOPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mALOPLabel.Name = "mALOPLabel";
            this.mALOPLabel.Size = new System.Drawing.Size(66, 18);
            this.mALOPLabel.TabIndex = 10;
            this.mALOPLabel.Text = "Mã Lớp:";
            // 
            // TxtMaLop
            // 
            this.TxtMaLop.Enabled = false;
            this.TxtMaLop.Location = new System.Drawing.Point(418, 173);
            this.TxtMaLop.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMaLop.Name = "TxtMaLop";
            this.TxtMaLop.Size = new System.Drawing.Size(142, 23);
            this.TxtMaLop.TabIndex = 11;
            // 
            // dIACHILabel
            // 
            this.dIACHILabel.AutoSize = true;
            this.dIACHILabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.dIACHILabel.Location = new System.Drawing.Point(13, 174);
            this.dIACHILabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dIACHILabel.Name = "dIACHILabel";
            this.dIACHILabel.Size = new System.Drawing.Size(65, 18);
            this.dIACHILabel.TabIndex = 6;
            this.dIACHILabel.Text = "Địa chỉ:";
            // 
            // dIACHITextBox
            // 
            this.dIACHITextBox.Location = new System.Drawing.Point(111, 173);
            this.dIACHITextBox.Margin = new System.Windows.Forms.Padding(2);
            this.dIACHITextBox.Name = "dIACHITextBox";
            this.dIACHITextBox.Size = new System.Drawing.Size(194, 23);
            this.dIACHITextBox.TabIndex = 7;
            // 
            // tENLabel
            // 
            this.tENLabel.AutoSize = true;
            this.tENLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.tENLabel.Location = new System.Drawing.Point(342, 122);
            this.tENLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tENLabel.Name = "tENLabel";
            this.tENLabel.Size = new System.Drawing.Size(40, 18);
            this.tENLabel.TabIndex = 4;
            this.tENLabel.Text = "Tên:";
            // 
            // TxtTenSV
            // 
            this.TxtTenSV.Location = new System.Drawing.Point(418, 121);
            this.TxtTenSV.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTenSV.Name = "TxtTenSV";
            this.TxtTenSV.Size = new System.Drawing.Size(142, 23);
            this.TxtTenSV.TabIndex = 5;
            // 
            // hOLabel
            // 
            this.hOLabel.AutoSize = true;
            this.hOLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.hOLabel.Location = new System.Drawing.Point(13, 122);
            this.hOLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hOLabel.Name = "hOLabel";
            this.hOLabel.Size = new System.Drawing.Size(33, 18);
            this.hOLabel.TabIndex = 2;
            this.hOLabel.Text = "Họ:";
            // 
            // TxtHo
            // 
            this.TxtHo.Location = new System.Drawing.Point(111, 121);
            this.TxtHo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtHo.Name = "TxtHo";
            this.TxtHo.Size = new System.Drawing.Size(194, 23);
            this.TxtHo.TabIndex = 3;
            // 
            // mASVLabel
            // 
            this.mASVLabel.AutoSize = true;
            this.mASVLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.mASVLabel.Location = new System.Drawing.Point(13, 78);
            this.mASVLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mASVLabel.Name = "mASVLabel";
            this.mASVLabel.Size = new System.Drawing.Size(59, 18);
            this.mASVLabel.TabIndex = 0;
            this.mASVLabel.Text = "Mã SV:";
            // 
            // TxtMaSV
            // 
            this.TxtMaSV.Location = new System.Drawing.Point(111, 77);
            this.TxtMaSV.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMaSV.Name = "TxtMaSV";
            this.TxtMaSV.Size = new System.Drawing.Size(194, 23);
            this.TxtMaSV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(581, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(667, 43);
            this.label3.TabIndex = 28;
            this.label3.Text = "Danh sách sinh viên";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 648);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.lOPGridControl);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl5);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl2);
            this.Name = "FrmSinhVien";
            this.Text = "FrmSinhVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BdsLH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarButtonItem BtnThem;
        private DevExpress.XtraBars.BarButtonItem BtnGhi;
        private DevExpress.XtraBars.BarButtonItem BtnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem BtnXoa;
        private DevExpress.XtraBars.BarButtonItem BtnLamMoi;
        private DevExpress.XtraBars.BarButtonItem BtnThoat;
        private DevExpress.XtraBars.BarButtonItem BtnSua;
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
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox CmbKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource BdsLH;
        private DS dS;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl lOPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nGAYSINHLabel1;
        private DevExpress.XtraEditors.DateEdit nGAYSINHDateEdit;
        private System.Windows.Forms.Label dANGHIHOCLabel;
        private System.Windows.Forms.CheckBox CbNghiHoc;
        private System.Windows.Forms.Label pHAILabel;
        private System.Windows.Forms.CheckBox CbPhai;
        private System.Windows.Forms.Label mALOPLabel;
        private System.Windows.Forms.TextBox TxtMaLop;
        private System.Windows.Forms.Label dIACHILabel;
        private System.Windows.Forms.TextBox dIACHITextBox;
        private System.Windows.Forms.Label tENLabel;
        private System.Windows.Forms.TextBox TxtTenSV;
        private System.Windows.Forms.Label hOLabel;
        private System.Windows.Forms.TextBox TxtHo;
        private System.Windows.Forms.Label mASVLabel;
        private System.Windows.Forms.TextBox TxtMaSV;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
    }
}