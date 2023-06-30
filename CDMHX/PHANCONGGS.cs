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
            cbDiaBan.Items.AddRange(pcgsdao.LayDB().ToArray());
            cbDiaBan.SelectedIndex = 0;
            listGV.MultiSelect = true;
            listGVGS.MultiSelect = true;

        }
        public void ShowAllGV()
        {

            int namcd;
            int.TryParse(cbNamCD.Text, out namcd);

            DataTable list = pcgsdao.GetAllGV();

            listGV.DataSource = list;

        }
        public void ShowAllGVDaPC()
        {

            int namcd;
            int.TryParse(cbNamCD.Text, out namcd);

            DataTable list = pcgsdao.GetAllGVDAGS(namcd,cbXa.Text);

            listGVGS.DataSource = list;

        }
        public void ShowAllSV_GS()
        {

            int namcd;
            int.TryParse(cbNamCD.Text, out namcd);

            DataTable list = pcgsdao.GetAllSV(namcd, cbXa.Text);

            listSVGS.DataSource = list;

        }


        private void cbDiaBan_TextChanged(object sender, EventArgs e)
        {
            cbXa.Items.Clear();
            int namcd;
            int.TryParse(cbNamCD.Text, out namcd);
            // Kiểm tra xem đã chọn một danh mục trong combo box "cbDiaBan" hay chưa
            if (cbDiaBan.SelectedItem != null)
            {
                cbXa.Items.AddRange(pcgsdao.LayXa(namcd, cbDiaBan.Text).ToArray());
                cbXa.SelectedIndex = 0;
                btnXem.Text = "Xem DSGV";
            }
        }

        private void cbXa_TextChanged(object sender, EventArgs e)
        {
            btnXem.Text = "Xem DSGV";
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
                    foreach (DataGridViewRow rowGV in listGV.SelectedRows)
                    {

                        foreach (DataGridViewRow rowSVGS in listSVGS.Rows)
                        {
                            if (pcgsdao.KiemTraDuLieu(rowSVGS.Cells[0].Value.ToString(),rowGV.Cells[0].Value.ToString()) == 1)
                            {
                                MessageBox.Show("Dữ Liệu Đã Tồn Tại Trong Hệ Thống!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    }

                    foreach (DataGridViewRow row in selectedRows)
                    {
                        listGV.Rows.Remove(row);
                    }

                    ShowAllGV();
                    ShowAllGVDaPC();
                }
            }


        }

    }
}
