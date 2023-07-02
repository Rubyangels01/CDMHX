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
    public partial class PHANCONGSV_GS : Form
    {
        PHANCONGSV_GSDAO pcdao = new PHANCONGSV_GSDAO();

        public PHANCONGSV_GS()
        {
            InitializeComponent();
        }

        public void ShowAllSV()
        {

            int namcd;
            int.TryParse(cbNamCD.Text, out namcd);

            DataTable list = pcdao.GetAllSV(namcd, cbXa.Text);

            listsv.DataSource = list;

        }
        public void ShowAllSVGS()
        {

            int namcd;
            int.TryParse(cbNamCD.Text, out namcd);

            DataTable list = pcdao.GetAllSVDAGS(namcd, cbXa.Text);

            listsvgs.DataSource = list;

        }
        private void PHANCONGSV_GS_Load(object sender, EventArgs e)
        {
            cbDiaBan.Items.AddRange(pcdao.LayDB().ToArray());
            cbDiaBan.SelectedIndex = 0;
            cbNamCD.Items.AddRange(pcdao.LayMaCD().ToArray());
            cbNamCD.SelectedIndex = 0;
            

            listsvgs.DataSource = pcdao.createTBSVGS();
        }
        public bool checkdl()
        {
            cbChucVu.Items.Clear();
            int namcd;
            int.TryParse(cbNamCD.Text, out namcd);
            if (pcdao.KiemTraDuLieu(namcd, cbXa.Text) == 1)
            {
                cbChucVu.Items.Add("ĐỘI PHÓ");
                cbChucVu.SelectedIndex = 0;

                ShowAllSV();
                return true;
            }
            else if (pcdao.KiemTraDuLieu(namcd, cbXa.Text) == 2)
            {
                cbChucVu.Items.Add("ĐỘI TRƯỞNG");
                cbChucVu.SelectedIndex = 0;
                ShowAllSV();
                return true;
            }
            else if (pcdao.KiemTraDuLieu(namcd, cbXa.Text) == 0)
            {
                cbChucVu.Items.Add("ĐỘI TRƯỞNG");
                cbChucVu.Items.Add("ĐỘI PHÓ");
                cbChucVu.SelectedIndex = 0;
                ShowAllSV();
                return true;
            }
            else
            {
                btnThem.Enabled = false;
                // cbChucVu.Items.Clear();

                MessageBox.Show("Đã tồn tại giám sát trong xã!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                listsv.Rows.Clear();
                return false;
            }

        }
        private void btnXem_Click(object sender, EventArgs e)
        {

            cbChucVu.Items.Clear();
            int namcd;
            int.TryParse(cbNamCD.Text, out namcd);
            
            if (pcdao.KiemTraDuLieu(namcd, cbXa.Text) == 1)
            {
                cbChucVu.Items.Add("ĐỘI PHÓ");
                cbChucVu.SelectedIndex = 0;
                ShowAllSV();
                ShowAllSVGS();
                btnThem.Enabled = true;

            }
            else if (pcdao.KiemTraDuLieu(namcd, cbXa.Text) == 2)
            {
                cbChucVu.Items.Add("ĐỘI TRƯỞNG");
                cbChucVu.SelectedIndex = 0;
                ShowAllSV();
                ShowAllSVGS();
                btnThem.Enabled = true;
            }
            else if (pcdao.KiemTraDuLieu(namcd, cbXa.Text) == 0)
            {
                cbChucVu.Items.Add("ĐỘI TRƯỞNG");
                cbChucVu.Items.Add("ĐỘI PHÓ");
                cbChucVu.SelectedIndex = 0;
                ShowAllSV();
                ShowAllSVGS();
                btnThem.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
                // cbChucVu.Items.Clear();
                ShowAllSVGS();
                MessageBox.Show("Đã tồn tại giám sát trong xã!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //listsv.Rows.Clear();
            }
            
            if (listsv.Rows.Count == 1)
            {
                btnThem.Enabled = false;
                MessageBox.Show("Danh sách đang rỗng, hãy thêm nhóm vào địa bàn trước khi phân giám sát!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
           
            // Kiểm tra xem đã chọn một danh mục trong combo box "cbDiaBan" hay chưa
            
        }
        private void cbDiaBan_TextChanged(object sender, EventArgs e)
        {
            
            int namcd;
            int.TryParse(cbNamCD.Text, out namcd);
            // Kiểm tra xem đã chọn một danh mục trong combo box "cbDiaBan" hay chưa
            if (cbDiaBan.SelectedItem != null)
            {
                if(pcdao.LayXa(namcd,cbDiaBan.Text).Count == 0)
                {
                    cbXa.Items.Clear();
                    cbXa.Items.Add("Danh Sách Rỗng");
                    cbXa.SelectedItem = "Danh Sách Rỗng";
                }
                else
                {
                    cbXa.Items.Clear();
                    cbXa.Items.AddRange(pcdao.LayXa(namcd, cbDiaBan.Text).ToArray());
                    cbXa.SelectedIndex = 0;
                    btnXem.Text = "Xem DSSV";
                }    
                
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            if (listsv.Rows.Count == 1)
            {
                btnThem.Enabled = false;
                MessageBox.Show("Danh sách đang rỗng, hãy thêm nhóm vào địa bàn trước khi phân giám sát!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (checkdl() == true)
                {
                    if (listsv.SelectedRows != null)
                    {
                        int masv, maxa, macd2 = 0;

                        int row = listsv.CurrentCell.RowIndex;
                        int.TryParse(listsv.Rows[row].Cells[0].Value.ToString(), out masv);
                        int.TryParse(cbNamCD.Text, out macd2);
                        int.TryParse(listsv.Rows[row].Cells[2].Value.ToString(), out maxa);

                        pcdao.InsertSV_GS(masv, macd2, maxa, cbChucVu.Text);

                        listsv.Rows.RemoveAt(row);

                        ShowAllSV();
                        ShowAllSVGS();
                        btnThem.Enabled = false;
                        MessageBox.Show("Vui lòng làm mới lại danh sách sinh viên để tiếp tục phân công giám sát!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnXem.Text = "Làm Mới";
                    }
                }
                else
                {

                    btnThem.Enabled = false;

                }
            }


            // Gọi phương thức PhanCongCV để thêm dữ liệu vào CSD
        }

        private void cbXa_TextChanged(object sender, EventArgs e)
        {
            btnXem.Text = "Xem DSSV";
        }

        private void cbNamCD_TextChanged(object sender, EventArgs e)
        {
            if (cbDiaBan.SelectedItem != null)
            {
                if (pcdao.LayXa(Program.ConvertStringToInt(cbNamCD.Text), cbDiaBan.Text).Count == 0)
                {
                    cbXa.Items.Clear();
                    cbXa.Items.Add("Danh Sách Rỗng");
                    cbXa.SelectedItem = "Danh Sách Rỗng";
                }
                else
                {
                    cbXa.Items.Clear();
                    cbXa.Items.AddRange(pcdao.LayXa(Program.ConvertStringToInt(cbNamCD.Text), cbDiaBan.Text).ToArray());
                    cbXa.SelectedIndex = 0;
                    btnXem.Text = "Xem DSSV";
                }

            }
        }
    }
}
