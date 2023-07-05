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

            DataTable list = pcdao.GetAllSV(namcd,cbXa.SelectedValue.ToString());

            listsv.DataSource = list;

        }
        public void ShowAllSVGS()
        {

            int namcd;
            int.TryParse(cbNamCD.Text, out namcd);

            DataTable list = pcdao.GetAllSVDAGS(namcd, cbXa.SelectedValue.ToString());

            listsvgs.DataSource = list;

        }
        private void PHANCONGSV_GS_Load(object sender, EventArgs e)
        {
            cbDiaBan.DataSource = Program.LayDB();
            cbDiaBan.DisplayMember = "TenDB";
            cbDiaBan.ValueMember = "MaDB";
            cbNamCD.Items.AddRange(Program.LayMaCD().ToArray());
            cbNamCD.SelectedIndex = 0;
            
            cbXa.DataSource = pcdao.LayXa(Program.ConvertStringToInt(cbNamCD.Text), cbDiaBan.SelectedValue.ToString());
            cbXa.DisplayMember = "tenxa";
            cbXa.ValueMember = "maxa";

            //listsvgs.DataSource = pcdao.createTBSVGS();
        }
        public bool checkdl()
        {
            cbChucVu.Items.Clear();
            int namcd;
            int.TryParse(cbNamCD.Text, out namcd);
            if (pcdao.KiemTraDuLieu(namcd, cbXa.SelectedValue.ToString()) == 1)
            {
                cbChucVu.Items.Add("ĐỘI PHÓ");
                cbChucVu.SelectedIndex = 0;

               
                return true;
            }
            else if (pcdao.KiemTraDuLieu(namcd, cbXa.SelectedValue.ToString()) == 2)
            {
                cbChucVu.Items.Add("ĐỘI TRƯỞNG");
                cbChucVu.SelectedIndex = 0;
               
                return true;
            }
            else if (pcdao.KiemTraDuLieu(namcd, cbXa.SelectedValue.ToString()) == 0)
            {
                cbChucVu.Items.Add("ĐỘI TRƯỞNG");
                cbChucVu.Items.Add("ĐỘI PHÓ");
                cbChucVu.SelectedIndex = 0;
              
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
            //ShowAllSVGS();
            if (cbXa.Text.Equals("Danh Sách Rỗng"))
            {
                MessageBox.Show("Địa bàn này chưa có nhóm tham gia chiến dịch!","THÔNG BÁO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            } 
            else
            {
                
                ShowAllSV();
                
                if(checkdl() == true)
                {
                    btnThem.Enabled = true;
                } 
                    
                
            }    
            
            
           
            // Kiểm tra xem đã chọn một danh mục trong combo box "cbDiaBan" hay chưa
            
        }
        private void cbDiaBan_TextChanged(object sender, EventArgs e)
        {
            /*
            cbXa.DataSource = pcdao.LayXa(Program.ConvertStringToInt(cbNamCD.Text), cbDiaBan.SelectedValue.ToString());
            cbXa.DisplayMember = "tenxa";
            cbXa.ValueMember = "maxa";
            btnXem.Text = "Xem DSSV";
            */
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
        }

        private void cbXa_TextChanged(object sender, EventArgs e)
        {
            btnXem.Text = "Xem DSSV";
        }

        private void cbNamCD_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
           
            if (MessageBox.Show("Bạn có muốn xoá sinh viên ra khỏi danh sách?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in listsvgs.SelectedRows)
                {                                       
                    pcdao.DeleteSV_GS(row.Cells[0].Value.ToString(),cbNamCD.Text);                   
                    
                }

                ShowAllSV();
                ShowAllSVGS();
            }
        }

        private void cbDiaBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(pcdao.LayXa(Program.ConvertStringToInt(cbNamCD.Text), cbDiaBan.SelectedValue.ToString()).Count == 0)
            {
                cbXa.DataSource = null;
                cbXa.Items.Add("Danh Sách Rỗng");
                cbXa.SelectedItem = "Danh Sách Rỗng";
            }
            else
            {
                cbXa.DataSource = pcdao.LayXa(Program.ConvertStringToInt(cbNamCD.Text), cbDiaBan.SelectedValue.ToString());
                cbXa.DisplayMember = "tenxa";
                cbXa.ValueMember = "maxa";
                btnXem.Text = "Xem DSSV";
            }    
            
        }

        private void cbNamCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pcdao.LayXa(Program.ConvertStringToInt(cbNamCD.Text), cbDiaBan.SelectedValue.ToString()).Count == 0)
            {
                cbXa.DataSource = null;
                cbXa.Items.Add("Danh Sách Rỗng");
                cbXa.SelectedItem = "Danh Sách Rỗng";
            }
            else
            {
                cbXa.DataSource = pcdao.LayXa(Program.ConvertStringToInt(cbNamCD.Text), cbDiaBan.SelectedValue.ToString());
                cbXa.DisplayMember = "tenxa";
                cbXa.ValueMember = "maxa";
                btnXem.Text = "Xem DSSV";
            }
        }
    }
}
