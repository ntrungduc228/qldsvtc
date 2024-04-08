
namespace App
{
    partial class FrmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangNhap));
            this.CbSinhVien = new System.Windows.Forms.CheckBox();
            this.CmbKhoa = new System.Windows.Forms.ComboBox();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.txbMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txbTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LabelTK = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txbMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTaiKhoan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // CbSinhVien
            // 
            this.CbSinhVien.AutoSize = true;
            this.CbSinhVien.Location = new System.Drawing.Point(221, 271);
            this.CbSinhVien.Name = "CbSinhVien";
            this.CbSinhVien.Size = new System.Drawing.Size(85, 21);
            this.CbSinhVien.TabIndex = 21;
            this.CbSinhVien.Text = "Sinh viên";
            this.CbSinhVien.UseVisualStyleBackColor = true;
            this.CbSinhVien.CheckedChanged += new System.EventHandler(this.CbSinhVien_CheckedChanged);
            // 
            // CmbKhoa
            // 
            this.CmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbKhoa.FormattingEnabled = true;
            this.CmbKhoa.Location = new System.Drawing.Point(221, 135);
            this.CmbKhoa.Name = "CmbKhoa";
            this.CmbKhoa.Size = new System.Drawing.Size(284, 24);
            this.CmbKhoa.TabIndex = 16;
            this.CmbKhoa.SelectedIndexChanged += new System.EventHandler(this.CmbKhoa_SelectedIndexChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.AutoSize = true;
            this.btnDangNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangNhap.ImageOptions.SvgImage")));
            this.btnDangNhap.Location = new System.Drawing.Point(269, 317);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(118, 44);
            this.btnDangNhap.TabIndex = 19;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.EditValue = "123456";
            this.txbMatKhau.Location = new System.Drawing.Point(221, 235);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Properties.UseSystemPasswordChar = true;
            this.txbMatKhau.Size = new System.Drawing.Size(284, 22);
            this.txbMatKhau.TabIndex = 18;
            // 
            // txbTaiKhoan
            // 
            this.txbTaiKhoan.EditValue = "GV01";
            this.txbTaiKhoan.Location = new System.Drawing.Point(221, 183);
            this.txbTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txbTaiKhoan.Name = "txbTaiKhoan";
            this.txbTaiKhoan.Size = new System.Drawing.Size(284, 22);
            this.txbTaiKhoan.TabIndex = 17;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(141, 238);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 17);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Mật khẩu";
            // 
            // LabelTK
            // 
            this.LabelTK.Location = new System.Drawing.Point(141, 188);
            this.LabelTK.Margin = new System.Windows.Forms.Padding(4);
            this.LabelTK.Name = "LabelTK";
            this.LabelTK.Size = new System.Drawing.Size(59, 17);
            this.LabelTK.TabIndex = 14;
            this.LabelTK.Text = "Tài khoản";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(141, 138);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(58, 16);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Chi Nhánh";
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 496);
            this.Controls.Add(this.CbSinhVien);
            this.Controls.Add(this.CmbKhoa);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.txbTaiKhoan);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.LabelTK);
            this.Controls.Add(this.labelControl4);
            this.Name = "FrmDangNhap";
            this.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
            this.Text = "FrmDangNhap";
            this.Load += new System.EventHandler(this.FrmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txbMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTaiKhoan.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CbSinhVien;
        private System.Windows.Forms.ComboBox CmbKhoa;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private DevExpress.XtraEditors.TextEdit txbMatKhau;
        private DevExpress.XtraEditors.TextEdit txbTaiKhoan;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl LabelTK;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}