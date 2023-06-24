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
    
    public partial class TAOCHIENDICH : Form
    {
        public List<string> listnhom = new List<string>();
        public List<string> listDB = new List<string>();
        public List<string> listcv = new List<string>();
        DataConnection dc;
        public TAOCHIENDICH()
        {
            dc = new DataConnection();
            InitializeComponent();
        }
        CHITIETCV parentForm = Application.OpenForms.OfType<CHITIETCV>().FirstOrDefault();
        /*
        public ListBox getList()
        {
            return listboxCV;
        }
        public void setList(ListBox list)
        {
            listboxCV = list;
        }*/
        public void listyear()
        {
            int currentYear = DateTime.Now.Year;

            // Tạo danh sách các năm
            List<int> years = new List<int>();

            // Thêm các năm từ năm hiện tại cho đến những năm tiếp theo vào danh sách
            for (int year = currentYear; year <= currentYear + 10; year++)
            {
                years.Add(year);
            }

            // Gán danh sách năm cho ComboBox
            cbMaCD.DataSource = years;

            

            // Đặt giá trị mặc định cho ComboBox
            cbMaCD.SelectedIndex = 0;
        }
        private void TAOCHIENDICH_Load(object sender, EventArgs e)
        {
            listyear();
        }
        public bool checkData()
        {

            if (string.IsNullOrWhiteSpace(txtTenCD.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên công việc", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenCD.Focus();
                return false;
            }
            if (dateNgayBD.Value.Date >= dateNgayKT.Value.Date)
            {
                // Hiển thị thông báo lỗi cho người dùng
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateNgayBD.Focus();
                return false;
            }



            return true;
        }
        private void btnThemCV_Click(object sender, EventArgs e)
        {
            CHITIETCV ctcv = new CHITIETCV();
            ctcv.ShowDialog();
        }
        public string tencv, tennhom, buoi, ngay, tenap;
        
        public bool ThemCD(string macd, string tencd, DateTime ngaybd, DateTime ngaykt)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_ThemCD";
            command.Connection = dc.getConnec();

            command.Parameters.Add("@MaCD", SqlDbType.Int).Value = cbMaCD.Text;
            command.Parameters.Add("@TenCD", SqlDbType.NVarChar).Value = txtTenCD.Text;
            command.Parameters.Add("@NgayBD", SqlDbType.Date).Value = dateNgayBD.Value;
            command.Parameters.Add("@NgayKT", SqlDbType.Date).Value = dateNgayKT.Value;
            
            command.ExecuteNonQuery();
            dc.getConnec().Close();

            return true;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            
            {
                if (checkData())
                {
                    
                    if (ThemCD(cbMaCD.Text,txtTenCD.Text,dateNgayBD.Value,dateNgayKT.Value))
                    {
                        MessageBox.Show("Thêm Chiến Dịch Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information
                            );
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
