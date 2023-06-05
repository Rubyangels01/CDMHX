
namespace CDMHX
{
    partial class CT_CHIENDICH
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCongViec = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listCongViec = new System.Windows.Forms.DataGridView();
            this.TenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenAp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listNhom = new System.Windows.Forms.DataGridView();
            this.MaNhomSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listDB = new System.Windows.Forms.DataGridView();
            this.MaDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listKT = new System.Windows.Forms.DataGridView();
            this.MaKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MucDoKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabCongViec.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listCongViec)).BeginInit();
            this.tab2.SuspendLayout();
            this.tab3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listNhom)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listDB)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listKT)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCongViec);
            this.tabControl.Controls.Add(this.tab2);
            this.tabControl.Controls.Add(this.tab3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1011, 434);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabCongViec
            // 
            this.tabCongViec.Controls.Add(this.label1);
            this.tabCongViec.Controls.Add(this.groupBox1);
            this.tabCongViec.Location = new System.Drawing.Point(4, 29);
            this.tabCongViec.Name = "tabCongViec";
            this.tabCongViec.Padding = new System.Windows.Forms.Padding(3);
            this.tabCongViec.Size = new System.Drawing.Size(1003, 401);
            this.tabCongViec.TabIndex = 0;
            this.tabCongViec.Text = "CÔNG VIỆC";
            this.tabCongViec.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH CÔNG VIỆC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listCongViec);
            this.groupBox1.Location = new System.Drawing.Point(31, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(933, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH CÔNG VIỆC";
            // 
            // listCongViec
            // 
            this.listCongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listCongViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenCV,
            this.MaNhom,
            this.Buoi,
            this.Ngay,
            this.TenAp});
            this.listCongViec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCongViec.Location = new System.Drawing.Point(3, 22);
            this.listCongViec.Name = "listCongViec";
            this.listCongViec.RowHeadersWidth = 51;
            this.listCongViec.RowTemplate.Height = 24;
            this.listCongViec.Size = new System.Drawing.Size(927, 263);
            this.listCongViec.TabIndex = 0;
            // 
            // TenCV
            // 
            this.TenCV.DataPropertyName = "TenCV";
            this.TenCV.HeaderText = "TÊN CÔNG VIỆC";
            this.TenCV.MinimumWidth = 6;
            this.TenCV.Name = "TenCV";
            this.TenCV.Width = 200;
            // 
            // MaNhom
            // 
            this.MaNhom.DataPropertyName = "MaNhom";
            this.MaNhom.HeaderText = "MÃ NHÓM";
            this.MaNhom.MinimumWidth = 6;
            this.MaNhom.Name = "MaNhom";
            this.MaNhom.Width = 125;
            // 
            // Buoi
            // 
            this.Buoi.DataPropertyName = "Buoi";
            this.Buoi.HeaderText = "BUỔI";
            this.Buoi.MinimumWidth = 6;
            this.Buoi.Name = "Buoi";
            this.Buoi.Width = 125;
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "Ngay";
            this.Ngay.HeaderText = "NGÀY";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            this.Ngay.Width = 150;
            // 
            // TenAp
            // 
            this.TenAp.DataPropertyName = "TenAp";
            this.TenAp.HeaderText = "TÊN ẤP";
            this.TenAp.MinimumWidth = 6;
            this.TenAp.Name = "TenAp";
            this.TenAp.Width = 200;
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.groupBox2);
            this.tab2.Controls.Add(this.label2);
            this.tab2.Location = new System.Drawing.Point(4, 29);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(1003, 401);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "NHÓM";
            this.tab2.UseVisualStyleBackColor = true;
            this.tab2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tab3
            // 
            this.tab3.Controls.Add(this.groupBox3);
            this.tab3.Controls.Add(this.label3);
            this.tab3.Location = new System.Drawing.Point(4, 29);
            this.tab3.Name = "tab3";
            this.tab3.Padding = new System.Windows.Forms.Padding(3);
            this.tab3.Size = new System.Drawing.Size(1003, 401);
            this.tab3.TabIndex = 2;
            this.tab3.Text = "ĐỊA BÀN";
            this.tab3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1003, 401);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "KHEN THƯỞNG";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1003, 401);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "GIÁM SÁT";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(408, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "CÔNG VIỆC";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listNhom);
            this.groupBox2.Location = new System.Drawing.Point(21, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(962, 292);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DANH SÁCH NHÓM";
            // 
            // listNhom
            // 
            this.listNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listNhom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhomSV,
            this.TenNhom,
            this.SoLuong});
            this.listNhom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listNhom.Location = new System.Drawing.Point(3, 22);
            this.listNhom.Name = "listNhom";
            this.listNhom.RowHeadersWidth = 51;
            this.listNhom.RowTemplate.Height = 24;
            this.listNhom.Size = new System.Drawing.Size(956, 267);
            this.listNhom.TabIndex = 0;
            // 
            // MaNhomSV
            // 
            this.MaNhomSV.DataPropertyName = "MaNhomSV";
            this.MaNhomSV.HeaderText = "MÃ NHÓM";
            this.MaNhomSV.MinimumWidth = 6;
            this.MaNhomSV.Name = "MaNhomSV";
            this.MaNhomSV.Width = 200;
            // 
            // TenNhom
            // 
            this.TenNhom.DataPropertyName = "TenNhom";
            this.TenNhom.HeaderText = "TÊN NHÓM";
            this.TenNhom.MinimumWidth = 6;
            this.TenNhom.Name = "TenNhom";
            this.TenNhom.Width = 300;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "SỐ LƯỢNG";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(418, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "ĐỊA BÀN";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listDB);
            this.groupBox3.Location = new System.Drawing.Point(8, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(971, 297);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DANH SÁCH ĐỊA BÀN";
            // 
            // listDB
            // 
            this.listDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDB,
            this.TenDB});
            this.listDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDB.Location = new System.Drawing.Point(3, 22);
            this.listDB.Name = "listDB";
            this.listDB.RowHeadersWidth = 51;
            this.listDB.RowTemplate.Height = 24;
            this.listDB.Size = new System.Drawing.Size(965, 272);
            this.listDB.TabIndex = 0;
            // 
            // MaDB
            // 
            this.MaDB.DataPropertyName = "MaDB";
            this.MaDB.HeaderText = "MÃ ĐỊA BÀN";
            this.MaDB.MinimumWidth = 6;
            this.MaDB.Name = "MaDB";
            this.MaDB.Width = 200;
            // 
            // TenDB
            // 
            this.TenDB.DataPropertyName = "TenDB";
            this.TenDB.HeaderText = "TÊN ĐỊA BÀN";
            this.TenDB.MinimumWidth = 6;
            this.TenDB.Name = "TenDB";
            this.TenDB.Width = 300;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(351, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(356, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "DANH SÁCH KHEN THƯỞNG";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listKT);
            this.groupBox4.Location = new System.Drawing.Point(9, 97);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(986, 283);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DANH SÁCH";
            // 
            // listKT
            // 
            this.listKT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listKT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKT,
            this.MucDoKT,
            this.NoiDung,
            this.MaSV,
            this.TenSV});
            this.listKT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listKT.Location = new System.Drawing.Point(3, 22);
            this.listKT.Name = "listKT";
            this.listKT.RowHeadersWidth = 51;
            this.listKT.RowTemplate.Height = 24;
            this.listKT.Size = new System.Drawing.Size(980, 258);
            this.listKT.TabIndex = 0;
            // 
            // MaKT
            // 
            this.MaKT.DataPropertyName = "MaKT";
            this.MaKT.HeaderText = "MÃ KHEN THƯỞNG";
            this.MaKT.MinimumWidth = 6;
            this.MaKT.Name = "MaKT";
            this.MaKT.Width = 125;
            // 
            // MucDoKT
            // 
            this.MucDoKT.DataPropertyName = "MucDoKT";
            this.MucDoKT.HeaderText = "MỨC ĐỘ KT";
            this.MucDoKT.MinimumWidth = 6;
            this.MucDoKT.Name = "MucDoKT";
            this.MucDoKT.Width = 150;
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "NoiDung";
            this.NoiDung.HeaderText = "NỘI DUNG";
            this.NoiDung.MinimumWidth = 6;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.Width = 300;
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "MÃ SINH VIÊN";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            this.MaSV.Width = 150;
            // 
            // TenSV
            // 
            this.TenSV.DataPropertyName = "TenSV";
            this.TenSV.HeaderText = "TÊN SINH VIÊN";
            this.TenSV.MinimumWidth = 6;
            this.TenSV.Name = "TenSV";
            this.TenSV.Width = 200;
            // 
            // CT_CHIENDICH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 434);
            this.Controls.Add(this.tabControl);
            this.Name = "CT_CHIENDICH";
            this.Text = "CT_CHIENDICH";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CT_CHIENDICH_FormClosed);
            this.Load += new System.EventHandler(this.CT_CHIENDICH_Load);
            this.tabControl.ResumeLayout(false);
            this.tabCongViec.ResumeLayout(false);
            this.tabCongViec.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listCongViec)).EndInit();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.tab3.ResumeLayout(false);
            this.tab3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listNhom)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listDB)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listKT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCongViec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView listCongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenAp;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.TabPage tab3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView listNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhomSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView listDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView listKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MucDoKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
        private System.Windows.Forms.Label label4;
    }
}