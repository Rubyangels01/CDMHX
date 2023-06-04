
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
            this.tabCongViec = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listCongViec = new System.Windows.Forms.DataGridView();
            this.TenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenAp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCongViec.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listCongViec)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCongViec
            // 
            this.tabCongViec.Controls.Add(this.tabPage1);
            this.tabCongViec.Controls.Add(this.tabPage2);
            this.tabCongViec.Controls.Add(this.tabPage3);
            this.tabCongViec.Controls.Add(this.tabPage4);
            this.tabCongViec.Controls.Add(this.tabPage5);
            this.tabCongViec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabCongViec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCongViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCongViec.Location = new System.Drawing.Point(0, 0);
            this.tabCongViec.Name = "tabCongViec";
            this.tabCongViec.SelectedIndex = 0;
            this.tabCongViec.Size = new System.Drawing.Size(1011, 434);
            this.tabCongViec.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1003, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CÔNG VIỆC";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1003, 585);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "NHÓM";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1003, 585);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ĐỊA BÀN";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1003, 585);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "KHEN THƯỞNG";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1003, 585);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "GIÁM SÁT";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listCongViec);
            this.groupBox1.Location = new System.Drawing.Point(31, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(933, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
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
            // CT_CHIENDICH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 434);
            this.Controls.Add(this.tabCongViec);
            this.Name = "CT_CHIENDICH";
            this.Text = "CT_CHIENDICH";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CT_CHIENDICH_FormClosed);
            this.Load += new System.EventHandler(this.CT_CHIENDICH_Load);
            this.tabCongViec.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listCongViec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCongViec;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView listCongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenAp;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
    }
}