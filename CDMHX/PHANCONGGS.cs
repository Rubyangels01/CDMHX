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
    public partial class PHANCONGGS : Form
    {
        PHANCONGGS_DAO pcgsdao = new PHANCONGGS_DAO();
        public PHANCONGGS()
        {
            InitializeComponent();
        }

        private void PHANCONGGS_Load(object sender, EventArgs e)
        {
            cbNamCD.Items.AddRange(pcgsdao.LayMaCD().ToArray());
            cbNamCD.SelectedIndex = 0;
            cbDiaBan.DataSource = pcgsdao.LayDB();
            cbDiaBan.DisplayMember = "TenDB";
            cbDiaBan.ValueMember = "MaDB";
            cbXa.DataSource = pcgsdao.LayXa(Program.ConvertStringToInt(cbNamCD.Text), Program.ConvertStringToInt(cbDiaBan.SelectedValue.ToString()));
            cbXa.DisplayMember = "tenxa";
            cbXa.ValueMember = "maxa";
            MessageBox.Show(cbDiaBan.SelectedValue.ToString());
            
            
            listGV.MultiSelect = true;
            listGVGS.MultiSelect = true;

        }
        public void ShowAllGV()
        {
            DataTable list = pcgsdao.GetAllGV();

            listGV.DataSource = list;

        }
        public void ShowAllGVDaPC()
        {

            int namcd;
            int.TryParse(cbNamCD.Text, out namcd);

            DataTable list = pcgsdao.GetAllGVDAGS(namcd,cbXa.SelectedValue.ToString());

            listGVGS.DataSource = list;

        }
        public void ShowAllSV_GS()
        {

            int namcd;
            int.TryParse(cbNamCD.Text, out namcd);
          
                DataTable list = pcgsdao.GetAllSV(cbNamCD.Text, cbXa.SelectedValue.ToString());
            listSVGS.DataSource = list;
             
           

        }


        private void cbDiaBan_TextChanged(object sender, EventArgs e)
        {
            if (cbDiaBan.SelectedItem != null)
            {
                cbXa.DataSource = null; // Gán DataSource thành null trước khi thay đổi các mục
                cbXa.Items.Clear();

                cbXa.DataSource = pcgsdao.LayXa(Program.ConvertStringToInt(cbNamCD.Text), Program.ConvertStringToInt(cbDiaBan.SelectedValue.ToString()));
                cbXa.DisplayMember = "tenxa";
                cbXa.ValueMember = "maxa";

                btnXem.Text = "Xem DSSV";
            }
        }


        private void cbXa_TextChanged(object sender, EventArgs e)
        {/*
            ShowAllSV_GS();
            ShowAllGV();
            ShowAllGVDaPC();
            btnXem.Text = "Xem DSGV";
            */
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            ShowAllSV_GS();
            ShowAllGV();
            ShowAllGVDaPC();
            btnThem.Enabled = true;
        }
        // btnthem
        private void button1_Click(object sender, EventArgs e)
        {
            if(listGVGS.Rows.Count > 1)
            {
                MessageBox.Show("Xã đã tồn tại giám sát!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                if (listSVGS.Rows.Count == 1)
                {
                    MessageBox.Show("Vui lòng phân công giám sát sinh viên trước khi phân công giáo viên giám sát!");
                    btnThem.Enabled = false;
                }
                else
                {
                    if (listGV.SelectedRows.Count != 2)
                    {
                        MessageBox.Show("Vui lòng chọn đủ 2 giáo viên giám sát!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();

                        // Lưu trữ các hàng được chọn vào danh sách tạm thời
                        foreach (DataGridViewRow row in listGV.SelectedRows)
                        {

                            selectedRows.Add(row);
                        }
                        int count = 0;
                        bool ktra = false;
                        foreach (DataGridViewRow rowGV in listGV.SelectedRows)
                        {

                            foreach (DataGridViewRow rowSVGS in listSVGS.Rows)
                            {
                                if (pcgsdao.KiemTraDuLieu(rowSVGS.Cells[0].Value.ToString(), rowGV.Cells[0].Value.ToString()) == 1)
                                {
                                    MessageBox.Show("Dữ Liệu Đã Tồn Tại Trong Hệ Thống!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    ktra = true;
                                    break;
                                }
                                else
                                {
                                    count += 1;
                                    pcgsdao.Insert_BGS(rowGV.Cells[0].Value.ToString(), rowSVGS.Cells[0].Value.ToString());
                                    if (count == 2)
                                    {
                                        count = 0;

                                        break;

                                    }
                                }


                            }
                            if (ktra == true)
                            {
                                break;
                            }
                        }

                        foreach (DataGridViewRow row in selectedRows)
                        {
                            if (ktra == true)
                            {
                                break;
                            }
                            listGV.Rows.Remove(row);
                        }

                        ShowAllGV();
                        ShowAllGVDaPC();
                        cbXa.Items.Remove(cbXa.Text);
                        if(cbXa.Items.Count == 0)
                        {
                            cbXa.Items.Add("DANH SÁCH RỖNG");
                            cbXa.SelectedItem = "DANH SÁCH RỖNG";
                        }    
                        cbXa.SelectedIndex = 0;
                        MessageBox.Show("Vui lòng làm mới lại danh sách trước khi thêm!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnThem.Enabled = false;
                    }
                }
            
            }


        }

        private void cbNamCD_TextChanged(object sender, EventArgs e)
        {

            if (cbDiaBan.SelectedItem != null)
            {
                cbXa.DataSource = null; // Gán DataSource thành null trước khi thay đổi các mục
                cbXa.Items.Clear();

                cbXa.DataSource = pcgsdao.LayXa(Program.ConvertStringToInt(cbNamCD.Text), Program.ConvertStringToInt(cbDiaBan.SelectedValue.ToString()));
                cbXa.DisplayMember = "tenxa";
                cbXa.ValueMember = "maxa";

                btnXem.Text = "Xem DSSV";
            }

        }
    }
}
