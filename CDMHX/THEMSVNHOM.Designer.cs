
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listSVNhom = new System.Windows.Forms.DataGridView();
            this.MaSVNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSVNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinhSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoaNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSoLuong = new System.Windows.Forms.ComboBox();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNamCD = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbXa = new System.Windows.Forms.ComboBox();
            this.cbDiaBan = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbAp = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listSV)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listSVNhom)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listSV);
            this.groupBox1.Location = new System.Drawing.Point(20, 422);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH SINH VIÊN";
            // 
            // listSV
            // 
            this.listSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.listSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSV.Location = new System.Drawing.Point(3, 18);
            this.listSV.Name = "listSV";
            this.listSV.RowHeadersWidth = 51;
            this.listSV.RowTemplate.Height = 24;
            this.listSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listSV.Size = new System.Drawing.Size(705, 272);
            this.listSV.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaSV";
            this.Column1.HeaderText = "MÃ SV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenSV";
            this.Column2.HeaderText = "TÊN SV";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GioiTinh";
            this.Column3.HeaderText = "GIỚI TÍNH";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TenKhoa";
            this.Column4.HeaderText = "TÊN KHOA";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listSVNhom);
            this.groupBox2.Location = new System.Drawing.Point(937, 419);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(714, 293);
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
            this.TenKhoaNhom,
            this.Column5,
            this.Column6});
            this.listSVNhom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSVNhom.Location = new System.Drawing.Point(3, 18);
            this.listSVNhom.Name = "listSVNhom";
            this.listSVNhom.RowHeadersWidth = 51;
            this.listSVNhom.RowTemplate.Height = 24;
            this.listSVNhom.Size = new System.Drawing.Size(708, 272);
            this.listSVNhom.TabIndex = 0;
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
            // Column5
            // 
            this.Column5.DataPropertyName = "MaNhom";
            this.Column5.HeaderText = "MÃ NHÓM";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ChucVu";
            this.Column6.HeaderText = "CHỨC VỤ";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(786, 515);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 54);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(786, 575);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 56);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "XOÁ";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.cbSoLuong);
            this.groupBox4.Controls.Add(this.txtTenNhom);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(148, 225);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1267, 87);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CHI TIẾT NHÓM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(643, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "SỐ LƯỢNG";
            // 
            // cbSoLuong
            // 
            this.cbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSoLuong.FormattingEnabled = true;
            this.cbSoLuong.Location = new System.Drawing.Point(752, 36);
            this.cbSoLuong.Name = "cbSoLuong";
            this.cbSoLuong.Size = new System.Drawing.Size(270, 28);
            this.cbSoLuong.TabIndex = 6;
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhom.Location = new System.Drawing.Point(344, 36);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(258, 26);
            this.txtTenNhom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(254, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "TÊN NHÓM";
            // 
            // cbNamCD
            // 
            this.cbNamCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNamCD.FormattingEnabled = true;
            this.cbNamCD.Location = new System.Drawing.Point(612, 28);
            this.cbNamCD.Name = "cbNamCD";
            this.cbNamCD.Size = new System.Drawing.Size(295, 28);
            this.cbNamCD.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbKhoa);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnXem);
            this.groupBox3.Controls.Add(this.cbNamCD);
            this.groupBox3.Location = new System.Drawing.Point(570, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1061, 78);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(940, 21);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(105, 42);
            this.btnXem.TabIndex = 8;
            this.btnXem.Text = "XEM";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(654, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "TẠO NHÓM SINH VIÊN";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbXa);
            this.groupBox5.Controls.Add(this.cbDiaBan);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.cbAp);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(148, 318);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1267, 85);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CHI TIẾT NHÓM";
            // 
            // cbXa
            // 
            this.cbXa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbXa.FormattingEnabled = true;
            this.cbXa.Location = new System.Drawing.Point(536, 32);
            this.cbXa.Name = "cbXa";
            this.cbXa.Size = new System.Drawing.Size(258, 28);
            this.cbXa.TabIndex = 11;
            this.cbXa.SelectedIndexChanged += new System.EventHandler(this.cbXa_SelectedIndexChanged);
            this.cbXa.TextChanged += new System.EventHandler(this.cbXa_TextChanged);
            // 
            // cbDiaBan
            // 
            this.cbDiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDiaBan.FormattingEnabled = true;
            this.cbDiaBan.Location = new System.Drawing.Point(116, 32);
            this.cbDiaBan.Name = "cbDiaBan";
            this.cbDiaBan.Size = new System.Drawing.Size(258, 28);
            this.cbDiaBan.TabIndex = 10;
            this.cbDiaBan.SelectedIndexChanged += new System.EventHandler(this.cbDiaBan_SelectedIndexChanged);
            this.cbDiaBan.TextChanged += new System.EventHandler(this.cbDiaBan_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(921, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "ẤP";
            // 
            // cbAp
            // 
            this.cbAp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAp.FormattingEnabled = true;
            this.cbAp.Location = new System.Drawing.Point(978, 32);
            this.cbAp.Name = "cbAp";
            this.cbAp.Size = new System.Drawing.Size(258, 28);
            this.cbAp.TabIndex = 6;
            this.cbAp.SelectedIndexChanged += new System.EventHandler(this.cbAp_SelectedIndexChanged);
            this.cbAp.TextChanged += new System.EventHandler(this.cbAp_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(471, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "XÃ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(23, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "ĐỊA BÀN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "KHOA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "NĂM CHIẾN DỊCH";
            // 
            // cbKhoa
            // 
            this.cbKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(114, 31);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(300, 28);
            this.cbKhoa.TabIndex = 11;
            // 
            // THEMSVNHOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1668, 725);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView listSV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView listSVNhom;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSoLuong;
        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNamCD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSVNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSVNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinhSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoaNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbXa;
        private System.Windows.Forms.ComboBox cbDiaBan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbAp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}