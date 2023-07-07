
namespace CDMHX
{
    partial class MAIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnBaoCao = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLCD = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLGV = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoCD = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhanCongGVGS = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLNhom = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLCV = new DevExpress.XtraBars.BarButtonItem();
            this.btnPCCV = new DevExpress.XtraBars.BarButtonItem();
            this.btnPCSVGS = new DevExpress.XtraBars.BarButtonItem();
            this.btnKT = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSKT = new DevExpress.XtraBars.BarButtonItem();
            this.btnXemNhom = new DevExpress.XtraBars.BarButtonItem();
            this.btnChiTietCV = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemCV = new DevExpress.XtraBars.BarButtonItem();
            this.btnLichGS = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSSV_GS = new DevExpress.XtraBars.BarButtonItem();
            this.rbTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbTruong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbGiaoVien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbGiamSat = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbSinhVien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.pn_main = new System.Windows.Forms.Panel();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnBaoCao,
            this.btnDangNhap,
            this.btnDangXuat,
            this.btnQLCD,
            this.btnQLGV,
            this.btnTaoCD,
            this.btnPhanCongGVGS,
            this.btnQLSV,
            this.btnQLNhom,
            this.btnQLCV,
            this.btnPCCV,
            this.btnPCSVGS,
            this.btnKT,
            this.btnDSKT,
            this.btnXemNhom,
            this.btnChiTietCV,
            this.btnThemCV,
            this.btnLichGS,
            this.btnDSSV_GS,
            this.barButtonItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.ribbon.MaxItemId = 21;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbTaiKhoan,
            this.rbTruong,
            this.rbGiaoVien,
            this.rbGiamSat,
            this.rbSinhVien});
            this.ribbon.Size = new System.Drawing.Size(1206, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Caption = "BÁO CÁO GIÁM SÁT";
            this.btnBaoCao.Id = 1;
            this.btnBaoCao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoCao.ImageOptions.Image")));
            this.btnBaoCao.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBaoCao.ImageOptions.LargeImage")));
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBaoCao_ItemClick);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "ĐĂNG NHẬP";
            this.btnDangNhap.Id = 2;
            this.btnDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.Image")));
            this.btnDangNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.LargeImage")));
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "ĐĂNG XUẤT";
            this.btnDangXuat.Id = 3;
            this.btnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.Image")));
            this.btnDangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.LargeImage")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnQLCD
            // 
            this.btnQLCD.Caption = "CHIẾN DỊCH";
            this.btnQLCD.Id = 4;
            this.btnQLCD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLCD.ImageOptions.Image")));
            this.btnQLCD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLCD.ImageOptions.LargeImage")));
            this.btnQLCD.Name = "btnQLCD";
            this.btnQLCD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLCD_ItemClick);
            // 
            // btnQLGV
            // 
            this.btnQLGV.Caption = "GIÁO VIÊN";
            this.btnQLGV.Id = 5;
            this.btnQLGV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLGV.ImageOptions.Image")));
            this.btnQLGV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLGV.ImageOptions.LargeImage")));
            this.btnQLGV.Name = "btnQLGV";
            this.btnQLGV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLGV_ItemClick);
            // 
            // btnTaoCD
            // 
            this.btnTaoCD.Caption = "TẠO CHIẾN DỊCH";
            this.btnTaoCD.Id = 6;
            this.btnTaoCD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoCD.ImageOptions.Image")));
            this.btnTaoCD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaoCD.ImageOptions.LargeImage")));
            this.btnTaoCD.Name = "btnTaoCD";
            this.btnTaoCD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoCD_ItemClick);
            // 
            // btnPhanCongGVGS
            // 
            this.btnPhanCongGVGS.Caption = "PHÂN CÔNG GV GIÁM SÁT";
            this.btnPhanCongGVGS.Id = 7;
            this.btnPhanCongGVGS.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhanCongGVGS.ImageOptions.Image")));
            this.btnPhanCongGVGS.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhanCongGVGS.ImageOptions.LargeImage")));
            this.btnPhanCongGVGS.Name = "btnPhanCongGVGS";
            this.btnPhanCongGVGS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhanCongGVGS_ItemClick);
            // 
            // btnQLSV
            // 
            this.btnQLSV.Caption = "SINH VIÊN";
            this.btnQLSV.Id = 8;
            this.btnQLSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLSV.ImageOptions.Image")));
            this.btnQLSV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLSV.ImageOptions.LargeImage")));
            this.btnQLSV.Name = "btnQLSV";
            this.btnQLSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLSV_ItemClick);
            // 
            // btnQLNhom
            // 
            this.btnQLNhom.Caption = "NHÓM";
            this.btnQLNhom.Id = 9;
            this.btnQLNhom.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnQLNhom.ImageOptions.SvgImage")));
            this.btnQLNhom.Name = "btnQLNhom";
            this.btnQLNhom.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLNhom_ItemClick);
            // 
            // btnQLCV
            // 
            this.btnQLCV.Caption = "CÔNG VIỆC";
            this.btnQLCV.Id = 10;
            this.btnQLCV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLCV.ImageOptions.Image")));
            this.btnQLCV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLCV.ImageOptions.LargeImage")));
            this.btnQLCV.Name = "btnQLCV";
            this.btnQLCV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLCV_ItemClick);
            // 
            // btnPCCV
            // 
            this.btnPCCV.Caption = "PHÂN CÔNG CÔNG VIỆC";
            this.btnPCCV.Id = 11;
            this.btnPCCV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPCCV.ImageOptions.SvgImage")));
            this.btnPCCV.Name = "btnPCCV";
            this.btnPCCV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPCCV_ItemClick);
            // 
            // btnPCSVGS
            // 
            this.btnPCSVGS.Caption = "PHÂN CÔNG SV GIÁM SÁT";
            this.btnPCSVGS.Id = 12;
            this.btnPCSVGS.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPCSVGS.ImageOptions.SvgImage")));
            this.btnPCSVGS.Name = "btnPCSVGS";
            this.btnPCSVGS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPCSVGS_ItemClick);
            // 
            // btnKT
            // 
            this.btnKT.Caption = "KHEN THƯỞNG";
            this.btnKT.Id = 13;
            this.btnKT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKT.ImageOptions.SvgImage")));
            this.btnKT.Name = "btnKT";
            this.btnKT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKT_ItemClick);
            // 
            // btnDSKT
            // 
            this.btnDSKT.Caption = "DS KHEN THƯỞNG";
            this.btnDSKT.Id = 14;
            this.btnDSKT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSKT.ImageOptions.Image")));
            this.btnDSKT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDSKT.ImageOptions.LargeImage")));
            this.btnDSKT.Name = "btnDSKT";
            this.btnDSKT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSKT_ItemClick);
            // 
            // btnXemNhom
            // 
            this.btnXemNhom.Caption = "DS NHÓM";
            this.btnXemNhom.Id = 15;
            this.btnXemNhom.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXemNhom.ImageOptions.SvgImage")));
            this.btnXemNhom.Name = "btnXemNhom";
            this.btnXemNhom.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXemNhom_ItemClick);
            // 
            // btnChiTietCV
            // 
            this.btnChiTietCV.Caption = "CHI TIẾT CÔNG VIỆC";
            this.btnChiTietCV.Id = 16;
            this.btnChiTietCV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChiTietCV.ImageOptions.SvgImage")));
            this.btnChiTietCV.Name = "btnChiTietCV";
            this.btnChiTietCV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChiTietCV_ItemClick);
            // 
            // btnThemCV
            // 
            this.btnThemCV.Caption = "THÊM CÔNG VIỆC CHIẾN DỊCH";
            this.btnThemCV.Id = 17;
            this.btnThemCV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemCV.ImageOptions.SvgImage")));
            this.btnThemCV.Name = "btnThemCV";
            this.btnThemCV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemCV_ItemClick);
            // 
            // btnLichGS
            // 
            this.btnLichGS.Caption = "LỊCH GIÁM SÁT";
            this.btnLichGS.Id = 18;
            this.btnLichGS.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLichGS.ImageOptions.SvgImage")));
            this.btnLichGS.Name = "btnLichGS";
            this.btnLichGS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLichGS_ItemClick);
            // 
            // btnDSSV_GS
            // 
            this.btnDSSV_GS.Caption = "DSSV GIÁM SÁT";
            this.btnDSSV_GS.Id = 19;
            this.btnDSSV_GS.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDSSV_GS.ImageOptions.SvgImage")));
            this.btnDSSV_GS.Name = "btnDSSV_GS";
            this.btnDSSV_GS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSSV_GS_ItemClick);
            // 
            // rbTaiKhoan
            // 
            this.rbTaiKhoan.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbTaiKhoan.Name = "rbTaiKhoan";
            this.rbTaiKhoan.Text = "HỆ THỐNG";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "TÀI KHOẢN";
            // 
            // rbTruong
            // 
            this.rbTruong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup5,
            this.ribbonPageGroup11});
            this.rbTruong.Name = "rbTruong";
            this.rbTruong.Text = "TRƯỜNG";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnQLCD);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnQLGV);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "QUẢN LÝ DANH MỤC";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnTaoCD);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnPhanCongGVGS);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnThemCV);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "CHỨC NĂNG";
            // 
            // rbGiaoVien
            // 
            this.rbGiaoVien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7,
            this.ribbonPageGroup9});
            this.rbGiaoVien.Name = "rbGiaoVien";
            this.rbGiaoVien.Text = "GIÁO VIÊN";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnQLSV);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnQLNhom);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnQLCV);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "QUẢN LÝ";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnPCCV);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnPCSVGS);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnKT);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "CHỨC NĂNG";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnDSKT);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "THỐNG KÊ";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btnLichGS);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "XEM";
            // 
            // rbGiamSat
            // 
            this.rbGiamSat.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup10});
            this.rbGiamSat.Name = "rbGiamSat";
            this.rbGiamSat.Text = "GIÁM SÁT";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnBaoCao);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "BÁO CÁO";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.btnDSSV_GS);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            this.ribbonPageGroup10.Text = "XEM";
            // 
            // rbSinhVien
            // 
            this.rbSinhVien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup8});
            this.rbSinhVien.Name = "rbSinhVien";
            this.rbSinhVien.Text = "SINH VIÊN";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnXemNhom);
            this.ribbonPageGroup8.ItemLinks.Add(this.btnChiTietCV);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "XEM";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 510);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1206, 30);
            // 
            // pn_main
            // 
            this.pn_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_main.Location = new System.Drawing.Point(0, 193);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(1206, 317);
            this.pn_main.TabIndex = 2;
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            this.ribbonPageGroup11.Text = "SAO LƯU PHỤC HỒI";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "SAO LƯU PHỤC HỒI";
            this.barButtonItem1.Id = 20;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 540);
            this.Controls.Add(this.pn_main);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "MAIN";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MAIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MAIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbTaiKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnBaoCao;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnQLCD;
        private DevExpress.XtraBars.BarButtonItem btnQLGV;
        private DevExpress.XtraBars.BarButtonItem btnTaoCD;
        private DevExpress.XtraBars.BarButtonItem btnPhanCongGVGS;
        private DevExpress.XtraBars.BarButtonItem btnQLSV;
        private DevExpress.XtraBars.BarButtonItem btnQLNhom;
        private DevExpress.XtraBars.BarButtonItem btnQLCV;
        private DevExpress.XtraBars.BarButtonItem btnPCCV;
        private DevExpress.XtraBars.BarButtonItem btnPCSVGS;
        private DevExpress.XtraBars.BarButtonItem btnKT;
        private DevExpress.XtraBars.BarButtonItem btnDSKT;
        private DevExpress.XtraBars.BarButtonItem btnXemNhom;
        private DevExpress.XtraBars.BarButtonItem btnChiTietCV;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbGiaoVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbTruong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbGiamSat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbSinhVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private System.Windows.Forms.Panel pn_main;
        private DevExpress.XtraBars.BarButtonItem btnThemCV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.BarButtonItem btnLichGS;
        private DevExpress.XtraBars.BarButtonItem btnDSSV_GS;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}