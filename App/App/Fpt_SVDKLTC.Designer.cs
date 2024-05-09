
namespace App
{
    partial class Fpt_SVDKLTC
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
            this.label5 = new System.Windows.Forms.Label();
            this.CmbMonHoc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbNhom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.BtnIn = new System.Windows.Forms.Button();
            this.CmbHocKy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(309, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(450, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "In Danh Sách Sinh Viên Đăng Ký Lớp Tín Chỉ";
            // 
            // CmbMonHoc
            // 
            this.CmbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMonHoc.FormattingEnabled = true;
            this.CmbMonHoc.Location = new System.Drawing.Point(442, 259);
            this.CmbMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.CmbMonHoc.Name = "CmbMonHoc";
            this.CmbMonHoc.Size = new System.Drawing.Size(337, 24);
            this.CmbMonHoc.TabIndex = 36;
            this.CmbMonHoc.SelectedIndexChanged += new System.EventHandler(this.CmbMonHoc_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(329, 265);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "Môn Học:";
            // 
            // CmbNhom
            // 
            this.CmbNhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbNhom.FormattingEnabled = true;
            this.CmbNhom.Location = new System.Drawing.Point(442, 296);
            this.CmbNhom.Margin = new System.Windows.Forms.Padding(2);
            this.CmbNhom.Name = "CmbNhom";
            this.CmbNhom.Size = new System.Drawing.Size(337, 24);
            this.CmbNhom.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(329, 302);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Nhóm:";
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(546, 354);
            this.BtnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(76, 31);
            this.BtnThoat.TabIndex = 32;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // BtnIn
            // 
            this.BtnIn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnIn.Location = new System.Drawing.Point(445, 353);
            this.BtnIn.Margin = new System.Windows.Forms.Padding(2);
            this.BtnIn.Name = "BtnIn";
            this.BtnIn.Size = new System.Drawing.Size(79, 32);
            this.BtnIn.TabIndex = 31;
            this.BtnIn.Text = "In";
            this.BtnIn.UseVisualStyleBackColor = false;
            this.BtnIn.Click += new System.EventHandler(this.BtnIn_Click);
            // 
            // CmbHocKy
            // 
            this.CmbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbHocKy.FormattingEnabled = true;
            this.CmbHocKy.Location = new System.Drawing.Point(442, 221);
            this.CmbHocKy.Margin = new System.Windows.Forms.Padding(2);
            this.CmbHocKy.Name = "CmbHocKy";
            this.CmbHocKy.Size = new System.Drawing.Size(337, 24);
            this.CmbHocKy.TabIndex = 30;
            this.CmbHocKy.SelectedIndexChanged += new System.EventHandler(this.CmbHocKy_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Học Kỳ:";
            // 
            // CmbNienKhoa
            // 
            this.CmbNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbNienKhoa.DropDownWidth = 504;
            this.CmbNienKhoa.FormattingEnabled = true;
            this.CmbNienKhoa.IntegralHeight = false;
            this.CmbNienKhoa.ItemHeight = 16;
            this.CmbNienKhoa.Location = new System.Drawing.Point(442, 181);
            this.CmbNienKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.CmbNienKhoa.Name = "CmbNienKhoa";
            this.CmbNienKhoa.Size = new System.Drawing.Size(337, 24);
            this.CmbNienKhoa.TabIndex = 28;
            this.CmbNienKhoa.SelectedIndexChanged += new System.EventHandler(this.CmbNienKhoa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Niên Khóa:";
            // 
            // CmbKhoa
            // 
            this.CmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbKhoa.FormattingEnabled = true;
            this.CmbKhoa.Location = new System.Drawing.Point(442, 146);
            this.CmbKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.CmbKhoa.Name = "CmbKhoa";
            this.CmbKhoa.Size = new System.Drawing.Size(337, 24);
            this.CmbKhoa.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Khoa:";
            // 
            // Fpt_SVDKLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 530);
            this.Controls.Add(this.CmbMonHoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmbNhom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.BtnIn);
            this.Controls.Add(this.CmbHocKy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbNienKhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "Fpt_SVDKLTC";
            this.Text = "Fpt_SVDKLTC";
            this.Load += new System.EventHandler(this.Fpt_SVDKLTC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbMonHoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbNhom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.Button BtnIn;
        private System.Windows.Forms.ComboBox CmbHocKy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbNienKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbKhoa;
        private System.Windows.Forms.Label label1;
    }
}