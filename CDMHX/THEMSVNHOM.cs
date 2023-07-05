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

            DataTable list = themsvdao.GetAllSV(namcd,cbKhoa.SelectedValue.ToString());

            listSV.DataSource = list;

        }
        public void ShowAllSVThem()
        {
            int namcd;
            int.TryParse(cbNamCD.Text, out namcd);
            DataTable listSV1 = themsvdao.GetAllSVDaCoNhom(namcd,cbKhoa.SelectedValue.ToString());

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
            cbDiaBan.DataSource = themsvdao.LayDB();
            cbDiaBan.DisplayMember = "TenDB";
            cbDiaBan.ValueMember = "MaDB";
            cbXa.DataSource = themsvdao.LayXa(cbDiaBan.SelectedValue.ToString());
            cbXa.DisplayMember = "tenxa";
            cbXa.ValueMember = "maxa";
            cbAp.DataSource = themsvdao.LayAp(cbXa.SelectedValue.ToString());
            cbAp.DisplayMember = "TenAp";
            cbAp.ValueMember = "MaAp";
            cbKhoa.DataSource = Program.LayKhoa();
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";

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
                if(string.IsNullOrEmpty(txtTenNhom.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ tên nhóm!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        if (txtTenNhom.Text != null)
                        {
                            themsvdao.InsertNhom(txtTenNhom.Text, cbSoLuong.Text, cbNamCD.Text, cbAp.SelectedValue.ToString());
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
                        ShowAllSVThem();
                        ShowAllSV();
                        txtTenNhom.Text = "";
                    }
                }
                
            }
        }
        int maSV;
        
        private void btnXem_Click(object sender, EventArgs e)
        {

            ShowAllSV();
            ShowAllSVThem();
            if (listSV.Rows.Count == 1)
            {
                MessageBox.Show("Tất cả sinh viên đã có nhóm!","THÔNG BÁO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            btnThem.Enabled = true;
            
           
            //ShowAllSVThem();
        }

        private void cbDiaBan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbAp_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbXa_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cbDiaBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbXa.DataSource = themsvdao.LayXa(cbDiaBan.SelectedValue.ToString());
            cbXa.DisplayMember = "tenxa";
            cbXa.ValueMember = "maxa";
        }

        private void cbAp_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbXa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbAp.DataSource = themsvdao.LayAp(cbXa.SelectedValue.ToString());
            cbAp.DisplayMember = "TenAp";
            cbAp.ValueMember = "MaAp";
        }
    }
}

