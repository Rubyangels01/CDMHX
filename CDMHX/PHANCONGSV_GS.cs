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
        int namcd;
        public void ShowAllSV()
        {

            
            int.TryParse(cbNamCD.Text, out namcd);

            DataTable list = pcdao.GetAllSV(namcd, cbXa.Text);

            listsv.DataSource = list;

        }
        private void PHANCONGSV_GS_Load(object sender, EventArgs e)
        {
            cbNamCD.Items.AddRange(pcdao.LayMaCD().ToArray());
            cbNamCD.SelectedIndex = 0;
            cbDiaBan.Items.AddRange(pcdao.LayDB().ToArray());
            cbDiaBan.SelectedIndex = 0;
            

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            ShowAllSV();
        }

        private void cbDiaBan_TextChanged(object sender, EventArgs e)
        {
            cbXa.Items.Clear();

            // Kiểm tra xem đã chọn một danh mục trong combo box "cbDiaBan" hay chưa
            if (cbDiaBan.SelectedItem != null)
            {
                cbXa.Items.AddRange(pcdao.LayXa(namcd, cbDiaBan.Text).ToArray());
                //cbXa.SelectedIndex = 0;

            }
            
        }
    }
}
