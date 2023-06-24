
namespace CDMHX
{
    partial class KHENTHUONG
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
            this.cbNamCD = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNoiDungKT = new System.Windows.Forms.TextBox();
            this.txtMucDoKT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMaKT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listSV = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listSV2 = new System.Windows.Forms.DataGridView();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listSV)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listSV2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNamCD);
            this.groupBox1.Location = new System.Drawing.Point(870, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NĂM CHIẾN DỊCH";
            // 
            // cbNamCD
            // 
            this.cbNamCD.FormattingEnabled = true;
            this.cbNamCD.Location = new System.Drawing.Point(27, 34);
            this.cbNamCD.Name = "cbNamCD";
            this.cbNamCD.Size = new System.Drawing.Size(374, 24);
            this.cbNamCD.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNoiDungKT);
            this.groupBox2.Controls.Add(this.txtMucDoKT);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbMaKT);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(42, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1252, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CHI TIẾT KHEN THƯỞNG";
            // 
            // txtNoiDungKT
            // 
            this.txtNoiDungKT.Location = new System.Drawing.Point(875, 37);
            this.txtNoiDungKT.Name = "txtNoiDungKT";
            this.txtNoiDungKT.Size = new System.Drawing.Size(354, 22);
            this.txtNoiDungKT.TabIndex = 8;
            // 
            // txtMucDoKT
            // 
            this.txtMucDoKT.Location = new System.Drawing.Point(490, 41);
            this.txtMucDoKT.Name = "txtMucDoKT";
            this.txtMucDoKT.Size = new System.Drawing.Size(249, 22);
            this.txtMucDoKT.TabIndex = 7;
            this.txtMucDoKT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(802, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "NDKT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(385, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "MỨC ĐỘ KT";
            // 
            // cbMaKT
            // 
            this.cbMaKT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbMaKT.FormattingEnabled = true;
            this.cbMaKT.Location = new System.Drawing.Point(104, 37);
            this.cbMaKT.Name = "cbMaKT";
            this.cbMaKT.Size = new System.Drawing.Size(227, 24);
            this.cbMaKT.TabIndex = 3;
            this.cbMaKT.TextChanged += new System.EventHandler(this.cbMaKT_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÃ KT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(527, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "KHEN THƯỞNG";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listSV);
            this.groupBox3.Location = new System.Drawing.Point(42, 382);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(567, 225);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DSSV CHƯA KHEN THƯỞNG";
            // 
            // listSV
            // 
            this.listSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.listSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSV.Location = new System.Drawing.Point(3, 18);
            this.listSV.Name = "listSV";
            this.listSV.RowHeadersWidth = 51;
            this.listSV.RowTemplate.Height = 24;
            this.listSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listSV.Size = new System.Drawing.Size(561, 204);
            this.listSV.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listSV2);
            this.groupBox4.Location = new System.Drawing.Point(791, 382);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(503, 222);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DSSV ĐÃ KHEN THƯỞNG";
            // 
            // listSV2
            // 
            this.listSV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listSV2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.listSV2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSV2.Location = new System.Drawing.Point(3, 18);
            this.listSV2.Name = "listSV2";
            this.listSV2.RowHeadersWidth = 51;
            this.listSV2.RowTemplate.Height = 24;
            this.listSV2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listSV2.Size = new System.Drawing.Size(497, 201);
            this.listSV2.TabIndex = 0;
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.Blue;
            this.btnXem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXem.Location = new System.Drawing.Point(1109, 304);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(185, 60);
            this.btnXem.TabIndex = 7;
            this.btnXem.Text = "XEM DS SINH VIÊN CHƯA KHEN THƯỞNG";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(654, 452);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 36);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(654, 512);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 36);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "XOÁ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaSV2";
            this.Column4.HeaderText = "MÃ SINH VIÊN";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TenSV2";
            this.Column5.HeaderText = "TÊN SINH VIÊN";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TenNhom2";
            this.Column6.HeaderText = "TÊN NHÓM";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TenKT";
            this.Column7.HeaderText = "KHEN THƯỞNG";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaSV";
            this.Column1.HeaderText = "MÃ SINH VIÊN";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenSV";
            this.Column2.HeaderText = "TÊN SINH VIÊN";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Nhom";
            this.Column3.HeaderText = "TÊN NHÓM";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // KHENTHUONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1306, 627);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "KHENTHUONG";
            this.Text = "KHENTHUONG";
            this.Load += new System.EventHandler(this.KHENTHUONG_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listSV)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listSV2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbNamCD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMaKT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView listSV;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView listSV2;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtNoiDungKT;
        private System.Windows.Forms.TextBox txtMucDoKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}