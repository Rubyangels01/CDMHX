using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDMHX
{
    public partial class NHÓM : Form
    {
        int index = 0;
        string flag;
        NHOMDAO nhomdao = new NHOMDAO();
        public NHÓM()
        {
            InitializeComponent();
        }

        public NHÓM(DataGridView list1)
        {
            InitializeComponent();


            listSVNhom.DataSource = list1;
            
            // Sử dụng dữ liệu từ GridView để hiển thị trên form NHÓM
            // ...
        }
        public void KhoaControl()
        {/*
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThemSV.Enabled = false;

            txtMaNhom.ReadOnly = true;
            txtTenNhom.ReadOnly = true;
            cbSoLuong.Enabled = false;
            cbChucVu.Enabled = false;  
            
            btnThem.Focus();
            */
        }


        public void UnlockControl()
        {/*
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThemSV.Enabled = true;

            txtMaNhom.ReadOnly = false;
            txtTenNhom.ReadOnly = false;
            cbSoLuong.Enabled = true;
            cbChucVu.Enabled = true;
            txtMaNhom.Focus();
            */
        }
        public void ShowAllNhom()
        {
            listNhom.DataSource = nhomdao.GetAllNhom();

        }
        public void TimKiemNhom()
        {
            if (Regex.IsMatch(txtTimKiem.Text, @"^\d+$"))
            {
                listNhom.DataSource = nhomdao.TimKiemNhom(DateTime.Now.Year.ToString(), txtTimKiem.Text);
                if (listNhom.Rows.Count == 1)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {// Chuỗi chỉ chứa chữ
                MessageBox.Show("Dữ liệu không hợp lệ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }                         
        }
        public void ShowAllNhom_sv()
        {
            listNhom.DataSource = nhomdao.GetAllNhom_SV("2023");

        }
        public void ShowAllSVNhom()
        {

            DataTable list = nhomdao.GetAllSvThemNhom();
            
            listSVNhom.DataSource = list;


        }
        ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
        ToolStripMenuItem menuItemDelete = new ToolStripMenuItem("Xóa");
        private void NHÓM_Load(object sender, EventArgs e)
        {
            KhoaControl();
            if(Program.loginLogin.Equals("GIAOVIEN") || Program.loginLogin.Equals("TRUONG"))
            {
                ShowAllNhom();
            }
            else if(Program.loginLogin.Equals("GIAMSAT") || Program.loginLogin.Equals("SINHVIEN"))
            {
                ShowAllNhom_sv();
            }
            
            menuItemDelete.Click += MenuItemDelete_Click;
            contextMenuStrip.Items.Add(menuItemDelete);
    
        }
        private void MenuItemDelete_Click(object sender, EventArgs e)
        {
            if(Program.loginLogin.Equals("SINHVIEN") || Program.loginLogin.Equals("GIAMSAT"))
            {
                MessageBox.Show("Bạn Không Có Quyền Chỉnh Sửa Dữ Liệu!","THÔNG BÁO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            } 
            else
            {
                int ID;
                index = listNhom.CurrentCell.RowIndex;
                int.TryParse(listNhom.Rows[index].Cells[0].Value.ToString(), out ID);

                if ((nhomdao.KiemTraDuLieu(ID)) == 1)
                {
                    MessageBox.Show("Dữ Liệu Này Không Được Xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Bạn có muốn xoá nhóm này?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (listNhom.SelectedCells.Count > 0)
                        {
                            DataGridViewCell selectedCell = listNhom.SelectedCells[0];
                            int rowIndex = selectedCell.RowIndex;
                            nhomdao.DeleteNhom(ID.ToString());
                            listNhom.Rows.RemoveAt(rowIndex);

                        }
                    }
                }
            }    
            


        }
        int ID;
        private void listNhom_SelectionChanged(object sender, EventArgs e)
        {
            index = listNhom.CurrentCell.RowIndex;
            DataTable dt = (DataTable)listNhom.DataSource;
            if (dt.Rows.Count > 0 || dt.Rows != null)
            {

                int.TryParse(listNhom.Rows[index].Cells[0].Value.ToString(), out ID);
                //txtMaNhom.Text = ID.ToString();
                //txtTenNhom.Text = listNhom.Rows[index].Cells[1].Value.ToString();
                
                //cbSoLuong.Text = listNhom.Rows[index].Cells[2].Value.ToString(); // Gán dữ liệu vào ComboBox
                //cbChucVu.Text = listNhom.Rows[index].Cells[3].Value.ToString();
                DataTable listSVnhom = nhomdao.GetAllSVNhom(ID);
                listSVNhom.DataSource = listSVnhom;


            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            UnlockControl();

            flag = "add";
            /*
            txtMaNhom.Text = "";
            txtTenNhom.Text = "";
            cbSoLuong.Text = "";
            cbChucVu.Text = "";
            btnThemSV.Text = "THÊM SV NHÓM";
            */
            DataTable emptyDataTable = new DataTable();
            emptyDataTable = nhomdao.createTBSV();
            listSVNhom.DataSource = emptyDataTable; 
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            KhoaControl();
            ShowAllNhom();
            //btnThemSV.Text = "CHỈNH SỬA DSSV NHÓM";
        }

        

        public bool checkData()
        {

            
            return true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            THEMSVNHOMDAO tsvnhom = new THEMSVNHOMDAO();
            tsvnhom.XoaBangTam();
            KhoaControl();
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            THEMSVNHOM myform = new THEMSVNHOM();
            myform.Show();
        }

        private void listNhom_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                listNhom.CurrentCell = listNhom.Rows[e.RowIndex].Cells[e.ColumnIndex];
                e.ContextMenuStrip = contextMenuStrip;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemNhom();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (Program.loginLogin.Equals("GIAOVIEN") || Program.loginLogin.Equals("TRUONG"))
            {
                ShowAllNhom();
            }
            else if (Program.loginLogin.Equals("GIAMSAT") || Program.loginLogin.Equals("SINHVIEN"))
            {
                ShowAllNhom_sv();
            }
        }
    }
}
