using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDMHX
{
    public partial class DSSV_GIAMSAT : Form
    {
        public DSSV_GIAMSAT()
        {
            InitializeComponent();
        }
        public DataTable GetAllDSSV_GS(string macd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(string.Format("EXEC DSSV_GS @MACD = {0}", macd), Program.dc.getConnec());
            da.Fill(dt);
            Program.dc.getConnec().Close();
            return dt;
        }
        public DataTable TimKiemSV(string macd, string masv)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(string.Format("EXEC TIMKIEM_SVGS @MACD = {0}, @MASV = {1}", macd, masv), Program.dc.getConnec());
            da.Fill(dt);
            Program.dc.getConnec().Close();
            return dt;

        }
        public void TimKiemGV()
        {
            if (Regex.IsMatch(txtTimKiem.Text, @"^\d+$"))
            {
                listSVGS.DataSource = TimKiemSV(txtNamCD.Text, txtTimKiem.Text);
                if (listSVGS.Rows.Count == 1)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {// Chuỗi chỉ chứa chữ
                MessageBox.Show("Dữ liệu không hợp lệ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void DSSV_GIAMSAT_Load(object sender, EventArgs e)
        {
            txtNamCD.Text = DateTime.Now.Year.ToString();
            listSVGS.DataSource = GetAllDSSV_GS(txtNamCD.Text);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemGV();
        }

        

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                listSVGS.DataSource = GetAllDSSV_GS(txtNamCD.Text);
            }
        }
    }
}
