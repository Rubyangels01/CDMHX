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
        int index = 0;
        string flag;
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
        private void CT_CHIENDICH_Load(object sender, EventArgs e)
        {
            ShowAllCV();
        }
        
        private void CT_CHIENDICH_FormClosed(object sender, FormClosedEventArgs e)
        {
            CHIENDICH parentForm = Application.OpenForms.OfType<CHIENDICH>().FirstOrDefault();
            if (parentForm != null)
            {
                parentForm.isDetailFormOpen = false;
                
            }
            
        }
    }
}
