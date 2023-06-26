using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace CDMHX
{
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
       

        public RibbonForm1()
        {
            InitializeComponent();
            
        }


        private void RibbonForm1_Load(object sender, EventArgs e)
        {

        }
        // BUTTON CÔNG VIỆC
        public void OpenForm(Form form)
        {
            pn_main.Controls.Clear();

            
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;

            // Tính toán margin để căn giữa myForm trong pn_main
            int leftMargin = (pn_main.Width - form.Width) / 2;
            int topMargin = (pn_main.Height - form.Height) / 2;
            form.Margin = new Padding(leftMargin, topMargin, leftMargin, topMargin);

            // Đặt Anchor để myForm căn giữa trong pn_main
            form.Anchor = AnchorStyles.None;

            form.Dock = DockStyle.Fill;
            pn_main.Controls.Add(form);
            form.Show();
        }
        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            CONGVIEC form = new CONGVIEC();
            OpenForm(form);
        }


        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        // BUTTON GIÁO VIÊN
        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            GIAOVIEN myForm = new GIAOVIEN();
            OpenForm(myForm);
        }
        // BUTTON SINH VIÊN
        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {          
            SINHVIEN myForm = new SINHVIEN();
            OpenForm(myForm);          
        }
        // BUTTON NHÓM
        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {          
            NHÓM myForm = new NHÓM();
            OpenForm(myForm);
        }
        // TẠO NHÓM SINH VIÊN
        private void barButtonItem5_ItemClick_1(object sender, ItemClickEventArgs e)
        {           
            THEMSVNHOM myForm = new THEMSVNHOM();
            OpenForm(myForm);
        }
        // BUTTON FORM CHIẾN DỊCH
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {          
            CHIENDICH myForm = new CHIENDICH();
            OpenForm(myForm);
        }

        private void btnTaoCD_ItemClick(object sender, ItemClickEventArgs e)
        {        
            TAOCHIENDICH myForm = new TAOCHIENDICH();
            OpenForm(myForm);
        }

        private void btnPCCV_ItemClick(object sender, ItemClickEventArgs e)
        {          
            CHITIETCV myForm = new CHITIETCV();
            OpenForm(myForm);
        }

        private void btnKhenThuong_ItemClick(object sender, ItemClickEventArgs e)
        {          
            DSKHENTHUONG myForm = new DSKHENTHUONG();
            OpenForm(myForm);
        }

        private void btnKT_ItemClick(object sender, ItemClickEventArgs e)
        {          
            KHENTHUONG myForm = new KHENTHUONG();
            OpenForm(myForm);
        }

        private void btnTaoNhom_ItemClick(object sender, ItemClickEventArgs e)
        {          
            THEMSVNHOM myForm = new THEMSVNHOM();
            OpenForm(myForm);
        }

        private void btnPhanCongGS_ItemClick(object sender, ItemClickEventArgs e)
        {          
            PHANCONGGS myForm = new PHANCONGGS();
            OpenForm(myForm);
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            PHANCONGSV_GS myForm = new PHANCONGSV_GS();
            OpenForm(myForm);
        }
    }
}