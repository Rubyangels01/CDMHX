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
            listSV.MultiSelect = true;

            cbNamCD.Items.AddRange(Program.LayMaCD().ToArray());
            cbNamCD.SelectedIndex = 0;
            cbSoLuong.Items.Add(3);
            cbSoLuong.Items.Add(4);
            cbSoLuong.Items.Add(5);
            cbSoLuong.Items.Add(6);
            cbSoLuong.SelectedIndex = 0;
            cbDiaBan.Items.AddRange(themsvdao.LayDB().ToArray());
            cbDiaBan.SelectedIndex = 0;
           
        }
        

        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (listSV.Rows.Count == 1)
            {
                MessageBox.Show("Danh sách rỗng!");
                btnThem.Enabled = false;
            }
            else
            {
                if (listSV.SelectedRows.Count != Program.ConvertStringToInt(cbSoLuong.Text))
                {
                    MessageBox.Show("Vui lòng chọn đủ số lượng sinh viên!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();

                    // Lưu trữ các hàng được chọn vào danh sách tạm thời
                    foreach (DataGridViewRow row in listSV.SelectedRows)
                    {

                        selectedRows.Add(row);
                    }
                    if(txtTenNhom.Text != null)
                    {
                        themsvdao.InsertNhom(txtTenNhom.Text, cbSoLuong.Text, cbNamCD.Text, cbAp.Text);
                           
                    }    
                    
                    int count = 0;
                    foreach (DataGridViewRow rowSV in listSV.SelectedRows)
                    {
                        if (rowSV.Index == 1)

                        {
                            themsvdao.InsertSV(themsvdao.manhom.ToString(), rowSV.Cells[0].Value.ToString(), "Trưởng Nhóm");
                        }
                        else
                        {
                            themsvdao.InsertSV(themsvdao.manhom.ToString(), rowSV.Cells[0].Value.ToString(), "Không");
                        }
                        count += 1;                               
                                if (count == Program.ConvertStringToInt(cbSoLuong.Text))
                                {
                                    break;
                                }
                                
                        

                    }
                    /*
                    foreach (DataGridViewRow row in selectedRows)
                    {

                       
                    }*/
                    ShowAllSVThem();
                    ShowAllSV();
                }
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
            btnThem.Enabled = true;
            //ShowAllSVThem();
        }

        private void cbDiaBan_TextChanged(object sender, EventArgs e)
        {
            cbXa.Items.Clear();
            cbXa.Items.AddRange(themsvdao.LayXa(cbDiaBan.Text).ToArray());
            cbXa.SelectedIndex = 0;
        }

        private void cbAp_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbXa_TextChanged(object sender, EventArgs e)
        {
            cbAp.Items.Clear();
            cbAp.Items.AddRange(themsvdao.LayAp(cbXa.Text).ToArray());
            cbAp.SelectedIndex = 0;
        }
    }
}

