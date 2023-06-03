
namespace CDMHX
{
    partial class THEMSVNHOM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listSV = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listSVNhom = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.MaSVNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSVNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinhSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoaNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listSV)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listSVNhom)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listSV);
            this.groupBox1.Location = new System.Drawing.Point(13, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 561);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH SINH VIÊN";
            // 
            // listSV
            // 
            this.listSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.TenSV,
            this.GioiTinh,
            this.TenKhoa,
            this.NgaySinh,
            this.DiaChi,
            this.Sdt});
            this.listSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSV.Location = new System.Drawing.Point(3, 18);
            this.listSV.Name = "listSV";
            this.listSV.RowHeadersWidth = 51;
            this.listSV.RowTemplate.Height = 24;
            this.listSV.Size = new System.Drawing.Size(705, 540);
            this.listSV.TabIndex = 0;
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "MÃ SV";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            this.MaSV.Width = 125;
            // 
            // TenSV
            // 
            this.TenSV.DataPropertyName = "TenSV";
            this.TenSV.HeaderText = "TÊN SV";
            this.TenSV.MinimumWidth = 6;
            this.TenSV.Name = "TenSV";
            this.TenSV.Width = 200;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "GIỚI TÍNH";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 125;
            // 
            // TenKhoa
            // 
            this.TenKhoa.DataPropertyName = "TenKhoa";
            this.TenKhoa.HeaderText = "TÊN KHOA";
            this.TenKhoa.MinimumWidth = 6;
            this.TenKhoa.Name = "TenKhoa";
            this.TenKhoa.Width = 200;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "NGÀY SINH";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 150;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "ĐỊA CHỈ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 200;
            // 
            // Sdt
            // 
            this.Sdt.DataPropertyName = "Sdt";
            this.Sdt.HeaderText = "SĐT";
            this.Sdt.MinimumWidth = 6;
            this.Sdt.Name = "Sdt";
            this.Sdt.Width = 175;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listSVNhom);
            this.groupBox2.Location = new System.Drawing.Point(929, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 561);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DANH SÁCH SINH VIÊN ĐƯỢC THÊM VÀO NHÓM";
            // 
            // listSVNhom
            // 
            this.listSVNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listSVNhom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSVNhom,
            this.TenSVNhom,
            this.GioiTinhSV,
            this.TenKhoaNhom});
            this.listSVNhom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSVNhom.Location = new System.Drawing.Point(3, 18);
            this.listSVNhom.Name = "listSVNhom";
            this.listSVNhom.RowHeadersWidth = 51;
            this.listSVNhom.RowTemplate.Height = 24;
            this.listSVNhom.Size = new System.Drawing.Size(615, 540);
            this.listSVNhom.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(776, 215);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 54);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(776, 347);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 56);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "XOÁ";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(753, 625);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(157, 45);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // MaSVNhom
            // 
            this.MaSVNhom.DataPropertyName = "MaSVNhom";
            this.MaSVNhom.HeaderText = "MÃ SV";
            this.MaSVNhom.MinimumWidth = 6;
            this.MaSVNhom.Name = "MaSVNhom";
            this.MaSVNhom.Width = 125;
            // 
            // TenSVNhom
            // 
            this.TenSVNhom.DataPropertyName = "TenSVNhom";
            this.TenSVNhom.HeaderText = "TÊN SV";
            this.TenSVNhom.MinimumWidth = 6;
            this.TenSVNhom.Name = "TenSVNhom";
            this.TenSVNhom.Width = 200;
            // 
            // GioiTinhSV
            // 
            this.GioiTinhSV.DataPropertyName = "GioiTinhSV";
            this.GioiTinhSV.HeaderText = "GIỚI TÍNH";
            this.GioiTinhSV.MinimumWidth = 6;
            this.GioiTinhSV.Name = "GioiTinhSV";
            this.GioiTinhSV.Width = 125;
            // 
            // TenKhoaNhom
            // 
            this.TenKhoaNhom.DataPropertyName = "TenKhoaNhom";
            this.TenKhoaNhom.HeaderText = "TÊN KHOA";
            this.TenKhoaNhom.MinimumWidth = 6;
            this.TenKhoaNhom.Name = "TenKhoaNhom";
            this.TenKhoaNhom.Width = 200;
            // 
            // THEMSVNHOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 691);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "THEMSVNHOM";
            this.Text = "THEMSVNHOM";
            this.Load += new System.EventHandler(this.THEMSVNHOM_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listSV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listSVNhom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView listSV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView listSVNhom;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSVNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSVNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinhSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoaNhom;
    }
}