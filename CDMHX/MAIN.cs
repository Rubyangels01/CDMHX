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

namespace CDMHX
{
    public partial class MAIN : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MAIN()
        {
            InitializeComponent();
        }
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
        public DevExpress.XtraBars.Ribbon.RibbonPage getformTruong()
        {
            return rbTruong;
        }
        public DevExpress.XtraBars.Ribbon.RibbonPage getformGiaoVien()
        {
            return rbGiaoVien;
        }
        public DevExpress.XtraBars.Ribbon.RibbonPage getformSinhVien()
        {
            return rbSinhVien;
        }
        public DevExpress.XtraBars.Ribbon.RibbonPage getformGiamSat()
        {
            return rbGiamSat;
        }
        public BarButtonItem getbtn()
        {
            return btnDangXuat;
        }
        private void MAIN_Load(object sender, EventArgs e)
        {
            btnDangNhap.Enabled = false;
            if (Program.loginLogin.Equals("GIAOVIEN"))
            {
                rbTruong.Visible = false;
                
            }
            else if (Program.loginLogin.Equals("SINHVIEN"))
            {
                rbGiaoVien.Visible = false;
                rbTruong.Visible = false;
                rbGiamSat.Visible = false;
            }
            else if (Program.loginLogin.Equals("GIAMSAT"))
            {
                rbGiaoVien.Visible = false;
                rbTruong.Visible = false;
               
            }
            
        }

        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            DANGNHAP form = new DANGNHAP();
            OpenForm(form);
        }

        private void btnQLCD_ItemClick(object sender, ItemClickEventArgs e)
        {
            CHIENDICH form = new CHIENDICH();
            OpenForm(form);
        }
        public void UnLock()
        {
            btnDangXuat.Enabled = true;
        }
        public void Lock()
        {
            btnDangXuat.Enabled = false;
        }
        private void btnQLGV_ItemClick(object sender, ItemClickEventArgs e)
        {
            GIAOVIEN form = new GIAOVIEN();
            OpenForm(form);
        }

        private void btnTaoCD_ItemClick(object sender, ItemClickEventArgs e)
        {
            TAOCHIENDICH form = new TAOCHIENDICH();
            OpenForm(form);
        }

        private void btnPhanCongGVGS_ItemClick(object sender, ItemClickEventArgs e)
        {
            PHANCONGGS form = new PHANCONGGS();
            OpenForm(form);
        }

        private void btnQLSV_ItemClick(object sender, ItemClickEventArgs e)
        {
            SINHVIEN form = new SINHVIEN();
            OpenForm(form);
        }

        private void btnQLNhom_ItemClick(object sender, ItemClickEventArgs e)
        {
            THEMSVNHOM form = new THEMSVNHOM();
            OpenForm(form);
        }

        private void btnQLCV_ItemClick(object sender, ItemClickEventArgs e)
        {
            CONGVIEC form = new CONGVIEC();
            OpenForm(form);
        }

        private void btnPCCV_ItemClick(object sender, ItemClickEventArgs e)
        {
            KIEMTRAPC_GV form = new KIEMTRAPC_GV();
           
            OpenForm(form);
        }

        private void btnPCSVGS_ItemClick(object sender, ItemClickEventArgs e)
        {
            PHANCONGSV_GS form = new PHANCONGSV_GS();
            OpenForm(form);
        }

        private void btnKT_ItemClick(object sender, ItemClickEventArgs e)
        {
            KHENTHUONG form = new KHENTHUONG();
            OpenForm(form);
        }

        private void btnDSKT_ItemClick(object sender, ItemClickEventArgs e)
        {
            DSKHENTHUONG form = new DSKHENTHUONG();
            OpenForm(form);
        }

        private void btnBaoCao_ItemClick(object sender, ItemClickEventArgs e)
        {
            BAOCAO form = new BAOCAO();
            OpenForm(form);
        }

        private void btnXemNhom_ItemClick(object sender, ItemClickEventArgs e)
        {
            NHÓM form = new NHÓM();
            OpenForm(form);
        }

        private void btnChiTietCV_ItemClick(object sender, ItemClickEventArgs e)
        {
            HIENTHICTCV form = new HIENTHICTCV();
            OpenForm(form);
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            rbGiamSat.Visible = false;
            rbTruong.Visible = false;
            rbGiaoVien.Visible = false;
            rbSinhVien.Visible = false;
            btnDangXuat.Enabled = false;
            this.Hide();
            DANGNHAP dn = new DANGNHAP();
            dn.ShowDialog();
            
        }

        private void btnThemCV_ItemClick(object sender, ItemClickEventArgs e)
        {
            THEMCV_CD form = new THEMCV_CD();
            OpenForm(form);
        }
    }
}