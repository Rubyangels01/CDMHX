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
   

    public partial class CHIENDICH : Form
    {
       public int MaCD1 = 0;
        public bool isDetailFormOpen = false;
        int index = 0;
        CHIENDICHDAO cddao = new CHIENDICHDAO();
        public CHIENDICH()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void ShowAllCD()
        {

            DataTable listCV = cddao.GetAllCD();

            listChienDich.DataSource = listCV;

        }
        ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
        ToolStripMenuItem menuItemDelete = new ToolStripMenuItem("Xóa");
        
        private void CHIENDICH_Load(object sender, EventArgs e)
        {
            listChienDich.CellDoubleClick += listChienDich_CellDoubleClick_1;
            ShowAllCD();
            cbTimKiem.Items.Add("2020");
            cbTimKiem.Items.Add("2021");
            cbTimKiem.Items.Add("2022");
            cbTimKiem.Items.Add("2023");

            menuItemDelete.Click += MenuItemDelete_Click;
            contextMenuStrip.Items.Add(menuItemDelete);

            // Thêm các lựa chọn khác nếu cần

        }
        
        
        private void MenuItemDelete_Click(object sender, EventArgs e)
        {
            int ID;
            index = listChienDich.CurrentCell.RowIndex;
            int.TryParse(listChienDich.Rows[index].Cells[0].Value.ToString(), out ID);
            
            if ((cddao.KiemTraDuLieu(ID)) == 1)
            {
                MessageBox.Show("Dữ Liệu Này Không Được Xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xoá chiến dịch này?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (listChienDich.SelectedCells.Count > 0)
                    {
                        DataGridViewCell selectedCell = listChienDich.SelectedCells[0];
                        int rowIndex = selectedCell.RowIndex;
                        cddao.DeleteCD(ID.ToString());
                        listChienDich.Rows.RemoveAt(rowIndex);
                       
                    }
                }    
            }

            
        }

        
        private void listChienDich_SelectionChanged(object sender, EventArgs e)
        {
            

        }



        private void cbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbTimKiem.SelectedItem.ToString()))
            {
                DataTable dt = cddao.TimKiem(cbTimKiem.SelectedItem.ToString());
                if (dt.Rows.Count > 0)
                {
                    listChienDich.DataSource = dt;
                }
            }
            else
            {
                ShowAllCD();
            }
        }

        private void cbTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbTimKiem.Text))
            {
                // Hiển thị lại tất cả danh sách sinh viên
                ShowAllCD();
            }
        }

        private void listChienDich_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
}

        private void listChienDich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < listChienDich.Rows.Count)
            {
                // Lấy chỉ số dòng của ô đã nhấp đúp
                int rowIndex = e.RowIndex;

                // Lấy dữ liệu từ ô đã nhấp đúp
                txtMaCD.Text = listChienDich.Rows[rowIndex].Cells[0].Value.ToString();
                 int.TryParse(txtMaCD.Text, out MaCD1);
                
                txtTenCD.Text = listChienDich.Rows[rowIndex].Cells[1].Value.ToString();
                DateTime ngayBD;
                DateTime.TryParse(listChienDich.Rows[index].Cells[2].Value.ToString(), out ngayBD);
                if (ngayBD != DateTime.MinValue)
                {
                    dateNgayBD.Value = ngayBD;
                }

                DateTime ngayKT;
                DateTime.TryParse(listChienDich.Rows[index].Cells[3].Value.ToString(), out ngayKT);
                if (ngayKT != DateTime.MinValue)
                {
                    dateNgayKT.Value = ngayKT;
                }
                // Lấy các thông tin khác cần thiết

                // Tạo một instance của FormChiTiet và truyền dữ liệu sang
                CT_CHIENDICH ctcd = new CT_CHIENDICH();
                // Truy cập và hiển thị form chi tiết
                ctcd.Show();
                isDetailFormOpen = true;

            }
        }

        private void listChienDich_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                listChienDich.CurrentCell = listChienDich.Rows[e.RowIndex].Cells[e.ColumnIndex];
                e.ContextMenuStrip = contextMenuStrip;
            }
        }
        

    }
}
