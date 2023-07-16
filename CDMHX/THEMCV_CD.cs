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
    public partial class THEMCV_CD : Form
    {
        int index = 0;
        string flag = "";
        public THEMCV_CD()
        {
            InitializeComponent();
        }
        public void KhoaControl()
        {
            btnThem.Visible = true;
            btnSua.Visible = true;
            btnXoa.Visible = true;
            btnLuu.Visible = false;
            btnHuy.Visible = false;

            cbTenCV.Enabled = false;
            dateNgayBD.Enabled = false;
            dateNgayKT.Enabled = false;


            btnThem.Focus();
        }


        public void UnlockControl()
        {
            btnThem.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
            btnLuu.Visible = true;
            btnHuy.Visible = true;

            cbTenCV.Enabled = true;
            dateNgayBD.Enabled = true;
            dateNgayKT.Enabled = true;
        }

        public DataTable GetAllDSCT_CDCV(string macd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(string.Format("SELECT CONGVIEC.MaCV, CONGVIEC.TenCV,NgayBD,NgayKT FROM CT_CD JOIN CONGVIEC ON CONGVIEC.MACV = CT_CD.MACV WHERE MACD = {0}", macd), Program.dc.getConnec());
            da.Fill(dt);
            Program.dc.getConnec().Close();
            return dt;
        }
        public List<tbCongViec> LayCV(string macd)
        {
            List<tbCongViec> listCV = new List<tbCongViec>();
            SqlCommand command = new SqlCommand();
            command.Connection = Program.dc.getConnec();

            command.CommandType = CommandType.Text;
            command.CommandText = (string.Format("SELECT * FROM CONGVIEC where CONGVIEC.MACV NOT IN(SELECT MACV FROM CT_CD WHERE MACD = {0})",macd));
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                tbCongViec cv = new tbCongViec();
                string macv = reader["MaCV"].ToString();
                string tencv = reader["TenCV"].ToString();
                cv.MaCV = Program.ConvertStringToInt(macv);
                cv.TenCV = tencv;
                listCV.Add(cv);

            }
            reader.Close();
            Program.dc.getConnec().Close();
            return listCV;
        }
        public DateTime getDateBD(string macv)
        {
            DateTime ngaybdcv = new DateTime();
            SqlCommand command = new SqlCommand();
            command.Connection = Program.dc.getConnec();

            command.CommandType = CommandType.Text;
            command.CommandText = (string.Format("select NGAYBD from ct_cd  WHERE MACV = {0}", macv));
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                DateTime ngaybd;
                if (DateTime.TryParse(reader["NGAYBD"].ToString(), out ngaybd))
                {
                    ngaybdcv = ngaybd;
                }


            }
            reader.Close();
            Program.dc.getConnec().Close();
            return ngaybdcv;
        }

        public DateTime getDateKT(string macv)
        {
            DateTime ngayktcv = new DateTime();
            SqlCommand command = new SqlCommand();
            command.Connection = Program.dc.getConnec();

            command.CommandType = CommandType.Text;
            command.CommandText = (string.Format("select NGAYKT from ct_cd  WHERE MACV = {0}", macv));
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                
                DateTime ngaykt;
                if (DateTime.TryParse(reader["NGAYKT"].ToString(), out ngaykt))
                {
                    ngayktcv = ngaykt;
                }

            }
            reader.Close();
            Program.dc.getConnec().Close();
            return ngayktcv;
        }
        
        private void THEMCV_CD_Load(object sender, EventArgs e)
        {
            KhoaControl();
            cbNamCD.Items.AddRange(Program.LayMaCD().ToArray());
            cbNamCD.SelectedIndex = 0;
            listsvcd.DataSource = GetAllDSCT_CDCV(cbNamCD.Text);
            
            
            
        }
        string macu = "";
        private void listsvcd_SelectionChanged(object sender, EventArgs e)
        {
            if(listsvcd.Rows.Count == 1)
            {
                listsvcd.DataSource = GetAllDSCT_CDCV(cbNamCD.Text);
            } 
            else
            {
                index = listsvcd.CurrentCell.RowIndex;
                DataTable dt = (DataTable)listsvcd.DataSource;
                if (dt.Rows.Count > 0 || dt.Rows != null)
                {
                    macu = listsvcd.Rows[index].Cells[0].Value.ToString();
                    cbTenCV.Text = listsvcd.Rows[index].Cells[1].Value.ToString();

                    DateTime ngayBD;
                    DateTime.TryParse(listsvcd.Rows[index].Cells[2].Value.ToString(), out ngayBD);

                    if (ngayBD != DateTime.MinValue)
                    {
                        dateNgayBD.Value = ngayBD;
                    }

                    DateTime ngayKT;
                    DateTime.TryParse(listsvcd.Rows[index].Cells[3].Value.ToString(), out ngayKT);
                    if (ngayKT != DateTime.MinValue)
                    {
                        dateNgayKT.Value = ngayKT;
                    }
                }
            }    
        }

        private void cbNamCD_TextChanged(object sender, EventArgs e)
        {
            listsvcd.DataSource = GetAllDSCT_CDCV(cbNamCD.Text);
            if(listsvcd.Rows.Count == 1)
            {
                MessageBox.Show("Danh sách đang trống!","THÔNG BÁO",MessageBoxButtons.OK);
            }    
        }
        public bool checkData()
        {                  
            if (dateNgayBD.Value.Date > dateNgayKT.Value.Date)
            {
                // Hiển thị thông báo lỗi cho người dùng
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateNgayBD.Focus();
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            UnlockControl();
            flag = "add";
            dateNgayBD.Value = DateTime.Now;
            dateNgayKT.Value = DateTime.Now.AddDays(1).Date;
            cbTenCV.DataSource = LayCV(cbNamCD.Text);
            cbTenCV.DisplayMember = "TenCV";
            cbTenCV.ValueMember = "MaCV";

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            KhoaControl();
            if(listsvcd.Rows.Count > 1)
            {
                listsvcd.DataSource = GetAllDSCT_CDCV(cbNamCD.Text);
            }    
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UnlockControl();
            cbTenCV.DataSource = LayCV(cbNamCD.Text);
            cbTenCV.DisplayMember = "TenCV";
            cbTenCV.ValueMember = "MaCV";
            flag = "edit";
            /*
            if (txtTenCV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn đối tượng cần sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowAllCV();
                KhoaControl();
            }*/
        }
        public bool ThemCV(string macd, string macv, DateTime ngayBD, DateTime ngayKt)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "INSERT_CTCD_CV";
            command.Connection = Program.dc.getConnec();           
            command.Parameters.Add("@MACD", SqlDbType.Int).Value = macd;
            command.Parameters.Add("@MACV", SqlDbType.Int).Value = macv;
            command.Parameters.Add("@NGAYBD", SqlDbType.Date).Value = ngayBD;
            command.Parameters.Add("@NGAYKT", SqlDbType.Date).Value = ngayKt;
            command.ExecuteNonQuery();
            Program.dc.getConnec().Close();

            return true;
        }
        public bool UpdateCV(string macd, string macv, DateTime ngayBD, DateTime ngayKt,string tencv)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "UPDATE_CTCD_CV";
            command.Connection = Program.dc.getConnec();

            command.Parameters.Add("@MACD", SqlDbType.Int).Value = macd;
            command.Parameters.Add("@MACV", SqlDbType.Int).Value = macv;
            command.Parameters.Add("@NGAYBD", SqlDbType.Date).Value = ngayBD;
            command.Parameters.Add("@NGAYKT", SqlDbType.Date).Value = ngayKt;
            command.Parameters.Add("@MACU", SqlDbType.Int).Value = macu;
            command.ExecuteNonQuery();
            Program.dc.getConnec().Close();

            return true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                if (checkData())
                {                   
                    if (ThemCV(cbNamCD.Text,cbTenCV.SelectedValue.ToString(),dateNgayBD.Value,dateNgayKT.Value))
                    {
                        listsvcd.DataSource = GetAllDSCT_CDCV(cbNamCD.Text);
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra, xin vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (flag == "edit")
            {
                if (checkData())
                {                   
                    if (UpdateCV(cbNamCD.Text, cbTenCV.SelectedValue.ToString(), dateNgayBD.Value, dateNgayKT.Value,macu))
                    {
                        listsvcd.DataSource = GetAllDSCT_CDCV(cbNamCD.Text);
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra, xin vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }


            KhoaControl();
        }
        public int KiemTraDuLieu(string macv, string macd)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = string.Format("SELECT [dbo].[FN_KIEMTRADULIEUCT_CV] ({0}, {1})", macv,macd);
            command.Connection = Program.dc.getConnec();

            int kq = 0;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    kq = reader.GetInt32(0);
                }
            }

            command.Connection.Close();

            return kq;
        }
        public bool DeleteCV(string macv, string macd)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = string.Format("DELETE CT_CD WHERE MACV = {0} AND MACD = {1}",macv,macd);
            command.Connection = Program.dc.getConnec();

            

            // Thực thi câu lệnh
            command.ExecuteNonQuery();
            Program.dc.getConnec().Close();

            return true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            

            if ((KiemTraDuLieu(macu,cbNamCD.Text)) == 1)
            {
                MessageBox.Show("Dữ Liệu Này Không Được Xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xoá công việc này?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    if (DeleteCV(macu,cbNamCD.Text))
                    {
                        listsvcd.DataSource = GetAllDSCT_CDCV(cbNamCD.Text);
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra, xin vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}
