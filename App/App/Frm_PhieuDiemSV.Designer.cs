
namespace App
{
    partial class Frm_PhieuDiemSV
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
            this.txbMaSV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnIn = new DevExpress.XtraEditors.SimpleButton();
            this.BtnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // txbMaSV
            // 
            this.txbMaSV.Location = new System.Drawing.Point(499, 73);
            this.txbMaSV.Name = "txbMaSV";
            this.txbMaSV.Size = new System.Drawing.Size(325, 23);
            this.txbMaSV.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(363, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "SINH VIÊN";
            // 
            // BtnIn
            // 
            this.BtnIn.Location = new System.Drawing.Point(415, 149);
            this.BtnIn.Name = "BtnIn";
            this.BtnIn.Size = new System.Drawing.Size(108, 44);
            this.BtnIn.TabIndex = 10;
            this.BtnIn.Text = "IN";
            this.BtnIn.Click += new System.EventHandler(this.BtnIn_Click);
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(634, 149);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(108, 44);
            this.BtnThoat.TabIndex = 11;
            this.BtnThoat.Text = "THOAT";
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // Frm_PhieuDiemSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 698);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.BtnIn);
            this.Controls.Add(this.txbMaSV);
            this.Controls.Add(this.label5);
            this.Name = "Frm_PhieuDiemSV";
            this.Text = "Frm_PhieuDiemSV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_PhieuDiemSV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbMaSV;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton BtnIn;
        private DevExpress.XtraEditors.SimpleButton BtnThoat;
    }
}