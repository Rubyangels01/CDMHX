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
    public partial class CT_CHIENDICH : Form
    {
       
       
        CT_CDDAO ctcddao = new CT_CDDAO();
        public CT_CHIENDICH()
        {
            InitializeComponent();
        }
        public void ShowAllCV()
        {
            CHIENDICH parentForm = Application.OpenForms.OfType<CHIENDICH>().FirstOrDefault();

            DataTable listCT_CVCD = ctcddao.GetAllCongViec(parentForm.MaCD1);

            listCongViec.DataSource = listCT_CVCD;

        }
        public void ShowAllNhom()
        {
            CHIENDICH parentForm = Application.OpenForms.OfType<CHIENDICH>().FirstOrDefault();
            
            DataTable listCT_NHOMCD = ctcddao.GetAllNhom(parentForm.MaCD1);

            listNhom.DataSource = listCT_NHOMCD;

        }

        public void ShowAllDB()
        {
            CHIENDICH parentForm = Application.OpenForms.OfType<CHIENDICH>().FirstOrDefault();

            DataTable listCT_NHOMCD = ctcddao.GetAllDB(parentForm.MaCD1);

            listDB.DataSource = listCT_NHOMCD;

        }
        public void ShowAllKT()
        {
            CHIENDICH parentForm = Application.OpenForms.OfType<CHIENDICH>().FirstOrDefault();

            DataTable listCT_NHOMCD = ctcddao.GetAllKT(parentForm.MaCD1);

            listKT.DataSource = listCT_NHOMCD;

        }
        private void CT_CHIENDICH_Load(object sender, EventArgs e)
        {
            ShowAllCV();
            ShowAllNhom();
            ShowAllDB();
            ShowAllKT();
        }
        
        private void CT_CHIENDICH_FormClosed(object sender, FormClosedEventArgs e)
        {
            CHIENDICH parentForm = Application.OpenForms.OfType<CHIENDICH>().FirstOrDefault();
            if (parentForm != null)
            {
                parentForm.isDetailFormOpen = false;
                
            }
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (tabControl.SelectedTab == tabCongViec)
            {
                // Gán dữ liệu cho DataGridView trên tab CongViec
                ShowAllCV();
            }
            else if (tabControl.SelectedTab == tab2)
            {
                // Gán dữ liệu cho DataGridView trên tab Nhom
                ShowAllNhom();
            }*/
            
        }
    }
}
