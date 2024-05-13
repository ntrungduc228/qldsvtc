
namespace App
{
    partial class frm_BHDM_R
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
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label nHOMLabel;
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label tENMHLabel1;
            this.btnThoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbNhom = new System.Windows.Forms.ComboBox();
            this.cbHocKi = new System.Windows.Forms.ComboBox();
            this.cbNienKhoa = new System.Windows.Forms.ComboBox();
            this.cmbTENMH = new System.Windows.Forms.ComboBox();
            this.cmbKHOA = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DS = new App.DS();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new App.DSTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new App.DSTableAdapters.TableAdapterManager();
            hOCKYLabel = new System.Windows.Forms.Label();
            nHOMLabel = new System.Windows.Forms.Label();
            nIENKHOALabel = new System.Windows.Forms.Label();
            tENMHLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightCoral;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Location = new System.Drawing.Point(576, 416);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 33);
            this.btnThoat.TabIndex = 51;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(447, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 50;
            this.button1.Text = "IN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbNhom
            // 
            this.cbNhom.FormattingEnabled = true;
            this.cbNhom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbNhom.Location = new System.Drawing.Point(344, 266);
            this.cbNhom.Name = "cbNhom";
            this.cbNhom.Size = new System.Drawing.Size(529, 24);
            this.cbNhom.TabIndex = 49;
            // 
            // cbHocKi
            // 
            this.cbHocKi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHocKi.FormattingEnabled = true;
            this.cbHocKi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbHocKi.Location = new System.Drawing.Point(344, 214);
            this.cbHocKi.Name = "cbHocKi";
            this.cbHocKi.Size = new System.Drawing.Size(529, 24);
            this.cbHocKi.TabIndex = 48;
            this.cbHocKi.SelectedIndexChanged += new System.EventHandler(this.cbHocKi_SelectedIndexChanged);
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            hOCKYLabel.Location = new System.Drawing.Point(238, 214);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(64, 17);
            hOCKYLabel.TabIndex = 47;
            hOCKYLabel.Text = "HOCKY:";
            // 
            // nHOMLabel
            // 
            nHOMLabel.AutoSize = true;
            nHOMLabel.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            nHOMLabel.Location = new System.Drawing.Point(238, 273);
            nHOMLabel.Name = "nHOMLabel";
            nHOMLabel.Size = new System.Drawing.Size(58, 17);
            nHOMLabel.TabIndex = 46;
            nHOMLabel.Text = "NHOM:";
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            nIENKHOALabel.Location = new System.Drawing.Point(238, 157);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(93, 17);
            nIENKHOALabel.TabIndex = 44;
            nIENKHOALabel.Text = "NIENKHOA:";
            // 
            // cbNienKhoa
            // 
            this.cbNienKhoa.FormattingEnabled = true;
            this.cbNienKhoa.Items.AddRange(new object[] {
            "2012-2013",
            "2014-2015",
            "2015-2016",
            "2016-2017",
            "2017-2018",
            "2018-2019",
            "2020-2021",
            "2021-2022",
            "2022-2023",
            "2024-2025",
            "2026-2027"});
            this.cbNienKhoa.Location = new System.Drawing.Point(344, 157);
            this.cbNienKhoa.Name = "cbNienKhoa";
            this.cbNienKhoa.Size = new System.Drawing.Size(529, 24);
            this.cbNienKhoa.TabIndex = 45;
            this.cbNienKhoa.SelectedIndexChanged += new System.EventHandler(this.cbNienKhoa_SelectedIndexChanged);
            // 
            // tENMHLabel1
            // 
            tENMHLabel1.AutoSize = true;
            tENMHLabel1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            tENMHLabel1.Location = new System.Drawing.Point(238, 334);
            tENMHLabel1.Name = "tENMHLabel1";
            tENMHLabel1.Size = new System.Drawing.Size(65, 17);
            tENMHLabel1.TabIndex = 42;
            tENMHLabel1.Text = "TENMH:";
            // 
            // cmbTENMH
            // 
            this.cmbTENMH.FormattingEnabled = true;
            this.cmbTENMH.Location = new System.Drawing.Point(344, 327);
            this.cmbTENMH.Name = "cmbTENMH";
            this.cmbTENMH.Size = new System.Drawing.Size(529, 24);
            this.cmbTENMH.TabIndex = 43;
            this.cmbTENMH.SelectedIndexChanged += new System.EventHandler(this.cmbTENMH_SelectedIndexChanged);
            // 
            // cmbKHOA
            // 
            this.cmbKHOA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKHOA.FormattingEnabled = true;
            this.cmbKHOA.Location = new System.Drawing.Point(344, 96);
            this.cmbKHOA.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKHOA.Name = "cmbKHOA";
            this.cmbKHOA.Size = new System.Drawing.Size(529, 24);
            this.cmbKHOA.TabIndex = 41;
            this.cmbKHOA.SelectedIndexChanged += new System.EventHandler(this.cmbKHOA_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(238, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "KHOA";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.DS;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = App.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frm_BHDM_R
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 635);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbNhom);
            this.Controls.Add(this.cbHocKi);
            this.Controls.Add(hOCKYLabel);
            this.Controls.Add(nHOMLabel);
            this.Controls.Add(nIENKHOALabel);
            this.Controls.Add(this.cbNienKhoa);
            this.Controls.Add(tENMHLabel1);
            this.Controls.Add(this.cmbTENMH);
            this.Controls.Add(this.cmbKHOA);
            this.Controls.Add(this.label1);
            this.Name = "frm_BHDM_R";
            this.Text = "frm_BHDM_R";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_BHDM_R_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbNhom;
        private System.Windows.Forms.ComboBox cbHocKi;
        private System.Windows.Forms.ComboBox cbNienKhoa;
        private System.Windows.Forms.ComboBox cmbTENMH;
        private System.Windows.Forms.ComboBox cmbKHOA;
        private System.Windows.Forms.Label label1;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
    }
}