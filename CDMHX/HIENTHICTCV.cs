using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDMHX
{
    public partial class HIENTHICTCV : Form
    {
        DataConnection dc;
        public HIENTHICTCV()
        {
            dc = new DataConnection();
            InitializeComponent();
        }
        public DataTable GetAllCTCV()
        {        
            DataTable dt = new DataTable();           
            SqlDataAdapter da = new SqlDataAdapter("select * from V_DS_CTCV", dc.getConnec());
            da.Fill(dt);          
            dc.getConnec().Close();
            return dt;
        }

        public DataTable GetAllCTCV_SV(string macd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(string.Format("EXEC DS_CTCV_SV @MACD = {0}",macd), dc.getConnec());
            da.Fill(dt);
            dc.getConnec().Close();
            return dt;
        }
        public DataTable TimKiemCTCV(string manhom)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(string.Format("EXEC TIMKIEM_CTCV @MANHOM = {0}", manhom), dc.getConnec());
            da.Fill(dt);
            dc.getConnec().Close();
            return dt;
        }
        public void ShowAllCTCV()
        {         
            listCV.DataSource = GetAllCTCV();
        }
        public void ShowAllCTCV_SV()
        {
            listCV.DataSource = GetAllCTCV_SV(DateTime.Now.Year.ToString());
        }
        public void Timkiem()
        {
           
            listCV.DataSource = TimKiemCTCV(txtMaNhom.Text);
            if (listCV.Rows.Count == 1)
            {
                MessageBox.Show("Không tìm thấy kết quả!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           

        }
        private void HIENTHICTCV_Load(object sender, EventArgs e)
        {
            //cbMaCD.Items.AddRange(Program.LayMaCD().ToArray());
            //cbMaCD.SelectedIndex = 0;
            if(Program.group.Equals("TRUONG") || Program.group.Equals("GIAOVIEN"))
            {
                ShowAllCTCV();
            } 
            else
            {
                ShowAllCTCV_SV();
            }    
            
        }

        private void btnXem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtMaNhom.Text))
            {
                Timkiem();
                
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã nhóm để tìm kiếm công việc!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }    
        }

        private void txtMaNhom_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMaNhom.Text))
            {
                if(Program.username == "TRUONG" || Program.username == "GIAOVIEN")
                {
                    ShowAllCTCV();

                } 
                else
                {
                    ShowAllCTCV_SV();
                }    
            }    
        }
    }
}
