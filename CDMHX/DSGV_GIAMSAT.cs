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
    public partial class DSGV_GIAMSAT : Form
    {
        public DSGV_GIAMSAT()
        {
            InitializeComponent();
        }
        public DataTable GetAllDSGV_GS(string macd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(string.Format("EXEC DS_GVGS @MACD = {0}", macd), Program.dc.getConnec());
            da.Fill(dt);
            Program.dc.getConnec().Close();
            return dt;
        }
        public DataTable TimKiemGV(string macd, string magv)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(string.Format("EXEC TIMKIEM_GVGS @MACD = {0}, @MAGV = {1}", macd, magv), Program.dc.getConnec());
            da.Fill(dt);
            Program.dc.getConnec().Close();
            return dt;

        }
        public void TimKiemGV()
        {
            if (Regex.IsMatch(txtTimKiem.Text, @"^\d+$"))
            {
                listGVGS.DataSource = TimKiemGV(cbNamCD.Text,txtTimKiem.Text);
                if (listGVGS.Rows.Count == 1)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {// Chuỗi chỉ chứa chữ
                MessageBox.Show("Dữ liệu không hợp lệ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void DSGV_GIAMSAT_Load(object sender, EventArgs e)
        {
            cbNamCD.Items.AddRange(Program.LayMaCD().ToArray());
            cbNamCD.SelectedIndex = 0;
            listGVGS.DataSource = GetAllDSGV_GS(cbNamCD.Text);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemGV();
        }

        private void cbNamCD_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTimKiem.Text))
            {
                listGVGS.DataSource = GetAllDSGV_GS(cbNamCD.Text);
            }    
        }

        private void cbNamCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            listGVGS.DataSource = GetAllDSGV_GS(cbNamCD.Text);
        }
    }
}
