﻿using System;
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
    public partial class KHENTHUONG : Form
    {
        int namcd;
        KHENTHUONGDAO ktdao = new KHENTHUONGDAO();
        public KHENTHUONG()
        {
            InitializeComponent();
        }
        public void ShowAllSV()
        {

            int namcd;
            int.TryParse(cbNamCD.Text, out namcd);

            DataTable list = ktdao.GetAllSV(namcd, cbMaKT.Text);

            listSV.DataSource = list;

        }

        DataTable list = new DataTable();

        public void ShowAllSVDAKT()
        {

            int.TryParse(cbNamCD.Text, out namcd);

            list = ktdao.GetAllSVDaKT(namcd, cbMaKT.Text);

            listSV2.DataSource = list;

        }
        private void KHENTHUONG_Load(object sender, EventArgs e)
        {
            txtMucDoKT.ReadOnly = true;
            cbMaKT.Items.AddRange(ktdao.LayMaKT().ToArray());
            cbMaKT.SelectedIndex = 0;
            cbNamCD.Items.AddRange(ktdao.LayMaCD().ToArray());
            cbNamCD.SelectedIndex = 0;
            listSV.MultiSelect = true;
            listSV2.MultiSelect = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbMaKT_TextChanged(object sender, EventArgs e)
        {
            txtMucDoKT.Text = "";

            // Kiểm tra xem đã chọn một danh mục trong combo box "cbDiaBan" hay chưa
            if (cbMaKT.SelectedItem != null)
            {
                txtMucDoKT.Text = ktdao.MucDoKT(cbMaKT.Text);

            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            ShowAllSV();
            ShowAllSVDAKT();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int count = 0;
            // Thêm dữ liệu vào DataGridView2
            foreach (DataGridViewRow row in listSV.SelectedRows)
            {
                MessageBox.Show(row.Cells[0].Value.ToString());
                MessageBox.Show(listSV.SelectedRows.Count.ToString());
                count += 1;
                ktdao.InsertKT(row.Cells[0].Value.ToString(), cbNamCD.Text, cbMaKT.Text);

                if (count == listSV.SelectedRows.Count)
                {
                    break;
                }

            }
            ShowAllSV();
            ShowAllSVDAKT();


        }




        private void btnXoa_Click(object sender, EventArgs e)
        {
            int masv = 0;

            // Tạo một danh sách các hàng để chứa các hàng được chọn
            List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();
            if (MessageBox.Show("Bạn có muốn xoá sinh viên ra khỏi danh sách?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in listSV2.SelectedRows)
                {
                    int.TryParse(row.Cells[0].Value.ToString(), out masv);
                    string tensv = row.Cells[1].Value.ToString();
                    string tennhom = row.Cells[2].Value.ToString();
                    string tenkt = row.Cells[3].Value.ToString();
                    // Thực hiện thêm dữ liệu vào nguồn dữ liệu chính (ví dụ: DataTable) hoặc cơ sở dữ liệu
                    ktdao.DeleteSV_KT(masv, namcd, tenkt);

                    // Thêm hàng được chọn vào danh sách
                    selectedRows.Add(row);
                }

                // Thêm dữ liệu vào listSV2


                // Xóa các hàng được chọn khỏi listSV
                foreach (DataGridViewRow row in selectedRows)
                {
                    listSV2.Rows.Remove(row);
                    ShowAllSV();
                }
            }

        }
    }
}
