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
        {
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
        }


        public void UnlockControl()
        {
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

        }
        public void ShowAllNhom()
        {

            DataTable listCV = nhomdao.GetAllNhom();

            listNhom.DataSource = listCV;

        }
        public void ShowAllSVNhom()
        {

            DataTable list = nhomdao.GetAllSvThemNhom();
            
            listSVNhom.DataSource = list;


        }
        private void NHÓM_Load(object sender, EventArgs e)
        {
            KhoaControl();
            ShowAllNhom();
            
            cbSoLuong.Items.Add(3);
            cbSoLuong.Items.Add(4);
            cbSoLuong.Items.Add(5);
            cbSoLuong.Items.Add(6);
            
        }
        int ID;
        private void listNhom_SelectionChanged(object sender, EventArgs e)
        {
            index = listNhom.CurrentCell.RowIndex;
            DataTable dt = (DataTable)listNhom.DataSource;
            if (dt.Rows.Count > 0 || dt.Rows != null)
            {
                int.TryParse(listNhom.Rows[index].Cells[0].Value.ToString(), out ID);
                txtMaNhom.Text = ID.ToString();
                txtTenNhom.Text = listNhom.Rows[index].Cells[1].Value.ToString();
                
                cbSoLuong.Text = listNhom.Rows[index].Cells[2].Value.ToString(); // Gán dữ liệu vào ComboBox
                cbChucVu.Text = listNhom.Rows[index].Cells[3].Value.ToString();
                DataTable listSVnhom = nhomdao.GetAllSVNhom(ID);
                listSVNhom.DataSource = listSVnhom;


            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            UnlockControl();

            flag = "add";
            txtMaNhom.Text = "";
            txtTenNhom.Text = "";
            cbSoLuong.Text = "";
            cbChucVu.Text = "";
            btnThemSV.Text = "THÊM SV NHÓM";
            DataTable emptyDataTable = new DataTable();
            emptyDataTable = nhomdao.createTBSV();
            listSVNhom.DataSource = emptyDataTable; 
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            KhoaControl();
            ShowAllNhom();
            btnThemSV.Text = "CHỈNH SỬA DSSV NHÓM";
        }

        

        public bool checkData()
        {

            if (string.IsNullOrWhiteSpace(txtTenNhom.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên Nhóm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNhom.Focus();
                return false;
            }                                                   
            if (string.IsNullOrWhiteSpace(cbSoLuong.SelectedItem.ToString()))
            {
                MessageBox.Show("Bạn chưa chọn số lượng nhóm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbSoLuong.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbChucVu.SelectedItem.ToString()))
            {
                MessageBox.Show("Bạn chưa chọn chức vụ nhóm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbChucVu.Focus();
                return false;
            }
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
    }
}
