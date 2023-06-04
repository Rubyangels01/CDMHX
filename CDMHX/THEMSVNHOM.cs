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
        THEMSVNHOMDAO themsvdao = new THEMSVNHOMDAO();
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
        public void ShowAllSVThem()
        {

            DataTable listSV1 = themsvdao.GetAllSvThem();

            listSVNhom.DataSource = listSV1;

        }
        private void THEMSVNHOM_Load(object sender, EventArgs e)
        {
            ShowAllSV();
            ShowAllSVThem();
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
            index = listSV.CurrentCell.RowIndex;
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

                // Thêm dữ liệu vào nguồn dữ liệu của DataGridView
                DataTable dataSource = (DataTable)listSVNhom.DataSource;
                DataRow newRow = dataSource.NewRow();
                newRow["MaSVNhom"] = sv.MaSV;
                newRow["TenSVNhom"] = sv.TenSV;
                newRow["GioiTinhSV"] = sv.GioiTinh;
                newRow["TenKhoaNhom"] = sv.Khoa.TenKhoa;
                dataSource.Rows.Add(newRow);

                // Lưu dữ liệu vào cơ sở dữ liệu
                themsvdao.SaveSVNhom(sv.MaSV, sv.TenSV, sv.GioiTinh, sv.Khoa.TenKhoa);

                // Làm mới hiển thị DataGridView
                listSVNhom.Refresh();
            }
            listSV.Rows.RemoveAt(index);
        }
        int maSV;
        private void listSVNhom_SelectionChanged(object sender, EventArgs e)
        {

            if (listSVNhom.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = listSVNhom.SelectedRows[0];

                tbSinhVien sv = new tbSinhVien();
               
                int.TryParse(selectedRow.Cells["MaSVNhom"].Value.ToString(), out maSV);
                sv.MaSV = maSV;
               
                sv.TenSV = selectedRow.Cells["TenSVNhom"].Value.ToString();


                sv.GioiTinh = selectedRow.Cells["GioiTinhSV"].Value.ToString();
                sv.Khoa.TenKhoa = selectedRow.Cells["TenKhoaNhom"].Value.ToString();





            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (listSVNhom.RowCount >= 3 && listSVNhom.RowCount <= 6)
            {
                NHÓM nhom = new NHÓM(listSVNhom);
                nhom.ShowAllSVNhom();
                this.Close();                           
            }
            else
            {
                MessageBox.Show("Số lượng sinh viên cho phép là từ 3-6 sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá sinh viên này?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbSinhVien sv = new tbSinhVien();
                sv.MaSV = maSV;
                MessageBox.Show(maSV.ToString());
                if (themsvdao.DeleteSV(sv))
                {
                    ShowAllSVThem();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, xin vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
      
       
    }
}

