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
        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            pn_main.Controls.Clear();

            CONGVIEC myForm = new CONGVIEC();
            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;

            // Tính toán margin để căn giữa myForm trong pn_main
            int leftMargin = (pn_main.Width - myForm.Width) / 2;
            int topMargin = (pn_main.Height - myForm.Height) / 2;
            myForm.Margin = new Padding(leftMargin, topMargin, leftMargin, topMargin);

            // Đặt Anchor để myForm căn giữa trong pn_main
            myForm.Anchor = AnchorStyles.None;

            myForm.Dock = DockStyle.Fill;
            pn_main.Controls.Add(myForm);
            myForm.Show();
        }


        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        // BUTTON GIÁO VIÊN
        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            pn_main.Controls.Clear();

            GIAOVIEN myForm = new GIAOVIEN();
            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;

            // Tính toán margin để căn giữa myForm trong pn_main
            int leftMargin = (pn_main.Width - myForm.Width) / 2;
            int topMargin = (pn_main.Height - myForm.Height) / 2;
            myForm.Margin = new Padding(leftMargin, topMargin, leftMargin, topMargin);

            // Đặt Anchor để myForm căn giữa trong pn_main
            myForm.Anchor = AnchorStyles.None;

            myForm.Dock = DockStyle.Fill;
            pn_main.Controls.Add(myForm);
            myForm.Show();
        }
        // BUTTON SINH VIÊN
        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            pn_main.Controls.Clear();

            SINHVIEN myForm = new SINHVIEN();
            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;

            


            // Đặt Anchor để myForm căn giữa trong pn_main
            myForm.Anchor = AnchorStyles.None;

            myForm.Dock = DockStyle.Fill;
            pn_main.Controls.Add(myForm);
            myForm.Show();
        }
        // BUTTON NHÓM
        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            pn_main.Controls.Clear();

            NHÓM myForm = new NHÓM();
            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;




            // Đặt Anchor để myForm căn giữa trong pn_main
            myForm.Anchor = AnchorStyles.None;

            myForm.Dock = DockStyle.Fill;
            pn_main.Controls.Add(myForm);
            myForm.Show();
        }
        // TẠO NHÓM SINH VIÊN
        private void barButtonItem5_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            pn_main.Controls.Clear();

            THEMSVNHOM myForm = new THEMSVNHOM();
            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;




            // Đặt Anchor để myForm căn giữa trong pn_main
            myForm.Anchor = AnchorStyles.None;

            myForm.Dock = DockStyle.Fill;
            pn_main.Controls.Add(myForm);
            myForm.Show();
        }
        // BUTTON FORM CHIẾN DỊCH
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            pn_main.Controls.Clear();

            CHIENDICH myForm = new CHIENDICH();
            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;




            // Đặt Anchor để myForm căn giữa trong pn_main
            myForm.Anchor = AnchorStyles.None;

            myForm.Dock = DockStyle.Fill;
            pn_main.Controls.Add(myForm);
            myForm.Show();
        }

        private void btnTaoCD_ItemClick(object sender, ItemClickEventArgs e)
        {
            pn_main.Controls.Clear();

            TAOCHIENDICH myForm = new TAOCHIENDICH();
            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            // Đặt Anchor để myForm căn giữa trong pn_main
            myForm.Anchor = AnchorStyles.None;

            myForm.Dock = DockStyle.Fill;
            pn_main.Controls.Add(myForm);
            myForm.Show();
        }

        private void btnPCCV_ItemClick(object sender, ItemClickEventArgs e)
        {
            pn_main.Controls.Clear();

            CHITIETCV myForm = new CHITIETCV();
            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            // Đặt Anchor để myForm căn giữa trong pn_main
            myForm.Anchor = AnchorStyles.None;

            myForm.Dock = DockStyle.Fill;
            pn_main.Controls.Add(myForm);
            myForm.Show();
        }

        private void btnKhenThuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            pn_main.Controls.Clear();

            DSKHENTHUONG myForm = new DSKHENTHUONG();
            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            // Đặt Anchor để myForm căn giữa trong pn_main
            myForm.Anchor = AnchorStyles.None;

            myForm.Dock = DockStyle.Fill;
            pn_main.Controls.Add(myForm);
            myForm.Show();
        }

        private void btnKT_ItemClick(object sender, ItemClickEventArgs e)
        {
            pn_main.Controls.Clear();

            KHENTHUONG myForm = new KHENTHUONG();
            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            // Đặt Anchor để myForm căn giữa trong pn_main
            myForm.Anchor = AnchorStyles.None;

            myForm.Dock = DockStyle.Fill;
            pn_main.Controls.Add(myForm);
            myForm.Show();
        }

        private void btnTaoNhom_ItemClick(object sender, ItemClickEventArgs e)
        {
            pn_main.Controls.Clear();

            THEMSVNHOM myForm = new THEMSVNHOM();
            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            // Đặt Anchor để myForm căn giữa trong pn_main
            myForm.Anchor = AnchorStyles.None;

            myForm.Dock = DockStyle.Fill;
            pn_main.Controls.Add(myForm);
            myForm.Show();
        }
    }
}