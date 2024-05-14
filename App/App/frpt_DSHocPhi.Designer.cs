
namespace App
{
    partial class frpt_DSHocPhi
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
            this.txbNienKhoa = new System.Windows.Forms.TextBox();
            this.nmHocKy = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnIn = new DevExpress.XtraEditors.SimpleButton();
            this.BtnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.dSHP = new App.DSHP();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new App.DSHPTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new App.DSHPTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.nmHocKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txbNienKhoa
            // 
            this.txbNienKhoa.Location = new System.Drawing.Point(524, 116);
            this.txbNienKhoa.Name = "txbNienKhoa";
            this.txbNienKhoa.Size = new System.Drawing.Size(325, 23);
            this.txbNienKhoa.TabIndex = 11;
            // 
            // nmHocKy
            // 
            this.nmHocKy.Location = new System.Drawing.Point(524, 152);
            this.nmHocKy.Name = "nmHocKy";
            this.nmHocKy.Size = new System.Drawing.Size(325, 23);
            this.nmHocKy.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(388, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "HỌC KỲ";
            // 
            // cbLop
            // 
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(524, 74);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(325, 24);
            this.cbLop.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "NIÊN KHÓA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "MÃ LỚP";
            // 
            // BtnIn
            // 
            this.BtnIn.Location = new System.Drawing.Point(467, 238);
            this.BtnIn.Name = "BtnIn";
            this.BtnIn.Size = new System.Drawing.Size(125, 44);
            this.BtnIn.TabIndex = 12;
            this.BtnIn.Text = "In";
            this.BtnIn.Click += new System.EventHandler(this.BtnIn_Click);
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(675, 238);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(125, 44);
            this.BtnThoat.TabIndex = 13;
            this.BtnThoat.Text = "Thoat";
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // dSHP
            // 
            this.dSHP.DataSetName = "DSHP";
            this.dSHP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dSHP;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = App.DSHPTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frpt_DSHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 515);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.BtnIn);
            this.Controls.Add(this.txbNienKhoa);
            this.Controls.Add(this.nmHocKy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frpt_DSHocPhi";
            this.Text = "frpt_DSHocPhi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frpt_DSHocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmHocKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNienKhoa;
        private System.Windows.Forms.NumericUpDown nmHocKy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton BtnIn;
        private DevExpress.XtraEditors.SimpleButton BtnThoat;
        private DSHP dSHP;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSHPTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSHPTableAdapters.TableAdapterManager tableAdapterManager;
    }
}