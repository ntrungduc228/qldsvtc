using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace App
{
    public partial class FrmHocPhi : DevExpress.XtraEditors.XtraForm
    {
        BindingSource bdsHocPhi = new BindingSource();
        BindingSource bdsCTHP = new BindingSource();
        int vitri = 0;
        int vitri1 = 0;
        bool dangthemmoi = false;
        Stack undoList = new Stack();
        public FrmHocPhi()
        {
            InitializeComponent();
        }

        private void hOCPHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsHOCPHI.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSHP);

        }

        void loadHOCPHI()
        {
            string loadTT_SV = "EXEC [dbo].[LayTTSV_TuSiteHocPhi] '" + txtMASV.Text + "'";
            SqlDataReader reader = Program.ExecSqlDataReader(loadTT_SV);
            if (reader.HasRows == false)
            {
                MessageBox.Show("Mã sinh viên không tồn tại");
                reader.Close();
                return;
            }
            reader.Read();
            txtTENSV.Text = reader.GetString(0);
            txtMALOP.Text = reader.GetString(1);
            reader.Close();
            Program.conn.Close();

            string loadHP = "EXEC [dbo].[LAY_DS_DONGHOCPHI_SV] '" + txtMASV.Text + "'";
            DataTable tableHOCPHI = Program.ExecSqlDataTable(loadHP);
            this.bdsHocPhi.DataSource = tableHOCPHI;
            this.HOCPHIGRIDCONTROL.DataSource = this.bdsHocPhi;
        }

        private void Load_CTDS_HOCPHI()
        {
            if (bdsHocPhi.Count > 0)
            {
                DataRowView datarv = ((DataRowView)bdsHocPhi[bdsHocPhi.Position]);
                string nienkhoa = datarv["NIENKHOA"].ToString();
                string hocki = ((DataRowView)bdsHocPhi[bdsHocPhi.Position])["HOCKY"].ToString();
                string msv = txtMASV.Text;

                string cmd = "EXEC dbo.LOADCTHP_SV '" + msv + "', '" + nienkhoa + "', '" + hocki + "'";
                DataTable tableCTHP = Program.ExecSqlDataTable(cmd);
                this.bdsCTHP.DataSource = tableCTHP;
                this.CT_HOCPHI_GRIDCONTROL.DataSource = this.bdsCTHP.DataSource;
            }
        }

        private void FrmHocPhi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dSHP.CT_DONGHOCPHI' table. You can move, or remove it, as needed.
            //this.cT_DONGHOCPHITableAdapter.Fill(this.dSHP.CT_DONGHOCPHI);
            // TODO: This line of code loads data into the 'dSHP.HOCPHI' table. You can move, or remove it, as needed.
            //this.hOCPHITableAdapter.Fill(this.dSHP.HOCPHI);

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtMASV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được bỏ trống");
                txtMASV.Focus();
                return;
            }
            loadHOCPHI();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void HOCPHIGRIDCONTROL_Click(object sender, EventArgs e)
        {
            Load_CTDS_HOCPHI();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri1 = bdsHocPhi.Position;
            dangthemmoi = true;
            bdsHocPhi.AddNew();
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsHocPhi.CancelEdit();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsHocPhi.CancelEdit();
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadHOCPHI();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (txtMASV.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã sinh viên");
                    txtMASV.Focus();
                    return;
                }
                if (((DataRowView)bdsHocPhi[bdsHocPhi.Position])["NIENKHOA"].ToString() == "")
                {
                    MessageBox.Show("Nien Khoa chưa nhập!");
                    return;
                }
                if (((DataRowView)bdsHocPhi[bdsHocPhi.Position])["HOCKY"].ToString() == "")
                {
                    MessageBox.Show("Học kỳ chưa nhập!");
                    return;
                }
                if (((DataRowView)bdsHocPhi[bdsHocPhi.Position])["HOCPHI"].ToString() == "")
                {
                    MessageBox.Show("Học phí chưa nhập!");
                    return;
                }
                if (float.Parse(((DataRowView)bdsHocPhi[bdsHocPhi.Position])["HOCKY"].ToString()) <= 0)
                {
                    MessageBox.Show("Học kì không được nhỏ hơn 1");
                    return;
                }
                if (float.Parse(((DataRowView)bdsHocPhi[bdsHocPhi.Position])["HOCPHI"].ToString()) <= 0)
                {
                    MessageBox.Show("Số tiền không được nhỏ hơn 0đ");
                    return;
                }
                if (float.Parse(((DataRowView)bdsHocPhi[bdsHocPhi.Position])["HOCKY"].ToString()) > 4)
                {
                    MessageBox.Show("Học kì không được Lon hon 4");
                    return;
                }

                string nienKhoaParts = ((DataRowView)bdsHocPhi[bdsHocPhi.Position])["NIENKHOA"].ToString();
                string[] nienKhoaPart1 = nienKhoaParts.Split('-');

                if (nienKhoaPart1.Length != 2 || nienKhoaPart1[0].Length != 4 || nienKhoaPart1[1].Length != 4)
                {

                    MessageBox.Show("Niên khóa phải có định dạng 'yyyy-yyyy'!", "", MessageBoxButtons.OK);

                    return;
                }

                int startYear, endYear;
                if (!int.TryParse(nienKhoaPart1[0], out startYear) || !int.TryParse(nienKhoaPart1[1], out endYear))
                {
                    MessageBox.Show("Niên khóa không hợp lệ!", "", MessageBoxButtons.OK);

                    return;
                }

                if (endYear - startYear != 1)
                {
                    MessageBox.Show("Niên khóa không hợp lệ!", "", MessageBoxButtons.OK);

                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            string maSV = txtMASV.Text;
            string nienkhoa = ((DataRowView)bdsHocPhi[bdsHocPhi.Position])["NIENKHOA"].ToString();
            string hocki = ((DataRowView)bdsHocPhi[bdsHocPhi.Position])["HOCKY"].ToString();
            string hocphi = ((DataRowView)bdsHocPhi[bdsHocPhi.Position])["HOCPHI"].ToString();
            bdsHocPhi.EndEdit();
            bdsHocPhi.ResetCurrentItem();
            SqlConnection conn = new SqlConnection(Program.connstr);
            // bắt đầu transaction
            SqlTransaction tran;

            conn.Open();
            tran = conn.BeginTransaction();
            try
            {
                Console.WriteLine(maSV);
                Console.WriteLine(nienkhoa);
                Console.WriteLine(hocki);
                Console.WriteLine(hocphi);
                Console.WriteLine("nienkhoa: ", nienkhoa, hocki, hocphi);
                SqlCommand cmd = new SqlCommand("TAO_THONGTINHOCPHI", conn);
                cmd.Connection = conn;
                cmd.Transaction = tran;
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@MASV", maSV));
                cmd.Parameters.Add(new SqlParameter("@NIENKHOA", nienkhoa));
                cmd.Parameters.Add(new SqlParameter("@HOCKY", hocki));
                cmd.Parameters.Add(new SqlParameter("@HOCPHI", hocphi));
                cmd.CommandType = CommandType.StoredProcedure;

                string query = cmd.CommandText;

                foreach (SqlParameter p in cmd.Parameters)
                {
                    query = query.Replace(p.ParameterName, p.Value.ToString());
                      Console.WriteLine(query);
                }

                // Add output parameter
                //SqlParameter resultParameter = new SqlParameter("@RESULT", SqlDbType.Int);
               // resultParameter.Direction = ParameterDirection.Output;
                //cmd.Parameters.Add(resultParameter);
                cmd.ExecuteNonQuery();
                tran.Commit();
                MessageBox.Show("Them thanh cong", "", MessageBoxButtons.OK);

                // Retrieve the result value
                //int result = Convert.ToInt32(resultParameter.Value);

                loadHOCPHI();


            }
            catch (SqlException sqlex)
            {
                try
                {

                    tran.Rollback();
                    MessageBox.Show("Lỗi ghi học phí vào Database. Bạn hãy xem lại ! " + sqlex.Message, "", MessageBoxButtons.OK);

                }
                catch (Exception ex2)
                {
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                }
                conn.Close();
                return;
            }
            finally
            {
                conn.Close();
            }
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vitri = bdsCTHP.Position;
            bdsCTHP.AddNew();
            btnThem.Enabled = btnGhi.Enabled = btnHuy.Enabled = btnLamMoi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void ghiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (((DataRowView)bdsCTHP[bdsCTHP.Position])["SOTIENDONG"].ToString() == "")
                {
                    MessageBox.Show("Số tiền không được bỏ trống");
                    return;
                }
                if (float.Parse(((DataRowView)bdsCTHP[bdsCTHP.Position])["SOTIENDONG"].ToString()) <= 0)
                {
                    MessageBox.Show("Số tiền không được nhỏ hơn 0đ");
                    return;
                }

                if (float.Parse(((DataRowView)bdsCTHP[bdsCTHP.Position])["SOTIENDONG"].ToString()) > float.Parse(((DataRowView)bdsHocPhi[bdsHocPhi.Position])["SOTIENCANDONG"].ToString()))
                {
                    MessageBox.Show("Số tiền đóng không được lớn hơn số tiền cần đóng!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = true;


            string nienkhoa = ((DataRowView)bdsHocPhi[bdsHocPhi.Position])["NIENKHOA"].ToString();
            string hocki = ((DataRowView)bdsHocPhi[bdsHocPhi.Position])["HOCKY"].ToString();
            string msv = txtMASV.Text;
            string sotiendong = ((DataRowView)bdsCTHP[bdsCTHP.Position])["SOTIENDONG"].ToString();
            bdsCTHP.EndEdit();
            bdsCTHP.ResetCurrentItem();
            SqlConnection conn = new SqlConnection(Program.connstr);
            // bắt đầu transaction
            SqlTransaction tran;

            conn.Open();
            tran = conn.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand("SV_DONGTIEN", conn);
                cmd.Connection = conn;
                cmd.Transaction = tran;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MASV", msv));
                cmd.Parameters.Add(new SqlParameter("@NienKhoa", nienkhoa));
                cmd.Parameters.Add(new SqlParameter("@HocKy", hocki));
                cmd.Parameters.Add(new SqlParameter("@SoTienDong", sotiendong));
                cmd.ExecuteNonQuery();
                tran.Commit();
                MessageBox.Show("Thêm chi tiết học phí thành công!");
                loadHOCPHI();


            }
            catch (SqlException sqlex)
            {
                try
                {

                    tran.Rollback();
                    MessageBox.Show("Lỗi ghi chi tiết học phí vào Database. Bạn hãy xem lại ! " + sqlex.Message, "", MessageBoxButtons.OK);

                }
                catch (Exception ex2)
                {
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                }
                conn.Close();
                return;
            }
            finally
            {
                conn.Close();
            }
        }

        private void phụcHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Load_CTDS_HOCPHI();
            bdsCTHP.CancelEdit();
           // FrmHocPhi_Load(sender, e);
            if (vitri > 0)
            {
                bdsCTHP.Position = vitri;
            }
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void thêmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            vitri = bdsCTHP.Position;
            bdsCTHP.AddNew();
            btnThem.Enabled = btnGhi.Enabled = btnHuy.Enabled = btnLamMoi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void phụcHồiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Load_CTDS_HOCPHI();
            bdsCTHP.CancelEdit();
            FrmHocPhi_Load(sender, e);
            if (vitri > 0)
            {
                bdsCTHP.Position = vitri;
            }
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = true;

        }

        private void ghiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (((DataRowView)bdsCTHP[bdsCTHP.Position])["SOTIENDONG"].ToString() == "")
                {
                    MessageBox.Show("Số tiền không được bỏ trống");
                    return;
                }
                if (float.Parse(((DataRowView)bdsCTHP[bdsCTHP.Position])["SOTIENDONG"].ToString()) <= 0)
                {
                    MessageBox.Show("Số tiền không được nhỏ hơn 0đ");
                    return;
                }

                if (float.Parse(((DataRowView)bdsCTHP[bdsCTHP.Position])["SOTIENDONG"].ToString()) > float.Parse(((DataRowView)bdsHocPhi[bdsHocPhi.Position])["SOTIENCANDONG"].ToString()))
                {
                    MessageBox.Show("Số tiền đóng không được lớn hơn số tiền cần đóng!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = true;


            string nienkhoa = ((DataRowView)bdsHocPhi[bdsHocPhi.Position])["NIENKHOA"].ToString();
            string hocki = ((DataRowView)bdsHocPhi[bdsHocPhi.Position])["HOCKY"].ToString();
            string msv = txtMASV.Text;
            string sotiendong = ((DataRowView)bdsCTHP[bdsCTHP.Position])["SOTIENDONG"].ToString();
            bdsCTHP.EndEdit();
            bdsCTHP.ResetCurrentItem();
            SqlConnection conn = new SqlConnection(Program.connstr);
            // bắt đầu transaction
            SqlTransaction tran;

            conn.Open();
            tran = conn.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand("SV_DONGTIEN", conn);
                cmd.Connection = conn;
                cmd.Transaction = tran;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MASV", msv));
                cmd.Parameters.Add(new SqlParameter("@NienKhoa", nienkhoa));
                cmd.Parameters.Add(new SqlParameter("@HocKy", hocki));
                cmd.Parameters.Add(new SqlParameter("@SoTienDong", sotiendong));
                cmd.ExecuteNonQuery();
                tran.Commit();
                MessageBox.Show("Thêm chi tiết học phí thành công!");
                loadHOCPHI();


            }
            catch (SqlException sqlex)
            {
                try
                {

                    tran.Rollback();
                    MessageBox.Show("Lỗi ghi chi tiết học phí vào Database. Bạn hãy xem lại ! " + sqlex.Message, "", MessageBoxButtons.OK);

                }
                catch (Exception ex2)
                {
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                }
                conn.Close();
                return;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}