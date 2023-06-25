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
       
        public THEMSVNHOM()
        {
            InitializeComponent();
        }
        public void ShowAllSV()
        {

            int namcd;
            int.TryParse(cbNamCD.Text, out namcd);

            DataTable list = themsvdao.GetAllSV(namcd, cbNamCD.Text);

            listSV.DataSource = list;

        }
        public void ShowAllSVThem()
        {
            int namcd;
            int.TryParse(cbNamCD.Text, out namcd);
            DataTable listSV1 = themsvdao.GetAllSVDaCoNhom(namcd);

            listSVNhom.DataSource = listSV1;

        }
        private void THEMSVNHOM_Load(object sender, EventArgs e)
        {
            cbNamCD.Items.AddRange(themsvdao.LayMaCD().ToArray()); 
           
        }
        

        
        private void btnThem_Click(object sender, EventArgs e)
        {
            THEMSVNHOMDAO themsvdao = new THEMSVNHOMDAO();
            List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();
            if(txtMaNhom.Text != null && txtTenNhom.Text != null)
            {
                themsvdao.InsertNhom(txtMaNhom.Text, txtTenNhom.Text, cbSoLuong.Text, cbNamCD.Text, cbAp.Text);
            }    
            // Lưu trữ các hàng được chọn vào danh sách tạm thời
            foreach (DataGridViewRow row in listSV.SelectedRows)
            {

                selectedRows.Add(row);
            }
            
            // Xóa các hàng được chọn khỏi DataGridView


            // Thêm dữ liệu vào DataGridView2
            foreach (DataGridViewRow row in listSV.SelectedRows)
            {
                int masv = 0;
                int index = row.Index;

                if (row.Cells[0].Value != null && int.TryParse(row.Cells[0].Value.ToString(), out masv))
                {
                    string tensv = row.Cells[1].Value?.ToString();
                    string tennhom = row.Cells[2].Value?.ToString();

                    themsvdao.InsertSV(txtMaNhom.Text, masv.ToString(), cbChucVu.Text);

                }
                else
                {
                    MessageBox.Show("Khen Thưởng Thất Bại!");
                }
                //listSV2.Rows.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), cbMaKT.Text);
            }
            foreach (DataGridViewRow row in selectedRows)
            {
                // listSV2.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, cbMaKT.Text);
                listSV.Rows.Remove(row);
                ShowAllSV();
                ShowAllSVDAKT();
            }
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
               // nhom.ShowDialog();
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

        private void btnXem_Click(object sender, EventArgs e)
        {
            ShowAllSV();
            //ShowAllSVThem();
        }
    }
}

