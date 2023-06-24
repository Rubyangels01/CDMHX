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
    public partial class KHENTHUONG : Form
    {
        KHENTHUONGDAO ktdao = new KHENTHUONGDAO();
        public KHENTHUONG()
        {
            InitializeComponent();
        }
        public void ShowAllSV()
        {
            int namcd;
            int.TryParse(cbNamCD.Text, out namcd);
            int makt;
            int.TryParse(cbMaKT.Text, out makt);
            DataTable list = ktdao.GetAllSV(namcd, makt);

            listSV.DataSource = list;

        }
        private void KHENTHUONG_Load(object sender, EventArgs e)
        {
            txtMucDoKT.ReadOnly = true;
           cbMaKT.Items.AddRange(ktdao.LayMaKT().ToArray());
            cbMaKT.SelectedIndex = 0;
            cbNamCD.Items.AddRange(ktdao.LayMaCD().ToArray());
            cbNamCD.SelectedIndex = 0;
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
        }
    }
}
