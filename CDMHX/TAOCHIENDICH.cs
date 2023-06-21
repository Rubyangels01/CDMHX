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
    public partial class TAOCHIENDICH : Form
    {
        public TAOCHIENDICH()
        {
            InitializeComponent();
        }
        CHITIETCV parentForm = Application.OpenForms.OfType<CHITIETCV>().FirstOrDefault();
        public void showCV(ListBox list)
        {
            
            
                foreach (string selectedItem in list.Items)
                {
                    
                    listboxCV.Items.Add(selectedItem);
                    
                }
            
            listboxCV.Show();
        }
        private void TAOCHIENDICH_Load(object sender, EventArgs e)
        {
                                                              
        }

        private void btnThemCV_Click(object sender, EventArgs e)
        {
            CHITIETCV ctcv = new CHITIETCV();
            ctcv.ShowDialog();
        }
    }
}
