using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDMHX
{
    public partial class THEMSVNHOM : Form
    {
        DataTable listSVNhom1;
        int index = 0;
        string flag;
        SINHVIENDAO svdao = new SINHVIENDAO();
        public THEMSVNHOM()
        {
            InitializeComponent();
        }
        public void ShowAllSV()
        {

            DataTable listSV1 = svdao.GetAllSV();

            listSV.DataSource = listSV1;

        }
        private void THEMSVNHOM_Load(object sender, EventArgs e)
        {
            ShowAllSV();
        }
        public DataTable createTB()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSVNhom");
            dt.Columns.Add("TenSVNhom");
            dt.Columns.Add("GioiTinhSV");
            
            dt.Columns.Add("TenKhoaNhom");
            return dt;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            THEMSVNHOMDAO themsvdao = new THEMSVNHOMDAO();
           
            //listSVNhom1 = createTB();
            // Lấy danh sách sinh viên đã được chọn từ GridView toàn bộ sinh viên
            List<tbSinhVien> danhSachSinhVienDuocChon = new List<tbSinhVien>();

            if (listSV.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = listSV.SelectedRows[0];

                tbSinhVien sv = new tbSinhVien();
                int maSV;
                int.TryParse(selectedRow.Cells["MaSV"].Value.ToString(), out maSV);
                sv.MaSV = maSV;
                sv.TenSV = selectedRow.Cells["TenSV"].Value.ToString();
                
                
                sv.GioiTinh = selectedRow.Cells["GioiTinh"].Value.ToString();
                sv.Khoa.TenKhoa = selectedRow.Cells["TenKhoa"].Value.ToString();


                // Thêm dòng vào GridView "Danh sách sinh viên được chọn"
                listSVNhom.Rows.Add(sv.MaSV, sv.TenSV, sv.GioiTinh, sv.Khoa.TenKhoa);
               
                themsvdao.SaveSVNhom(sv.MaSV, sv.TenSV, sv.GioiTinh, sv.Khoa.TenKhoa);


            }
            
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (listSVNhom.RowCount >= 3 && listSVNhom.RowCount <= 6)
            {
                NHÓM form = new NHÓM();
                form.ShowAllSVNhom();
                this.Close();                           
            }
            else
            {
                MessageBox.Show("Số lượng sinh viên cho phép là từ 3-6 sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}

