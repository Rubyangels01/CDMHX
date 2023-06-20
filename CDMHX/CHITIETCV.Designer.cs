
namespace CDMHX
{
    partial class CHITIETCV
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
            this.listboxCTCV = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listboxCongViec = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listboxNhom = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listboxDiaBan = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbBuoi = new System.Windows.Forms.ComboBox();
            this.dateNgayChon = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChuyenmot = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listboxCTCV);
            this.groupBox1.Location = new System.Drawing.Point(736, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 438);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHI TIẾT DANH SÁCH CÔNG VIỆC";
            // 
            // listboxCTCV
            // 
            this.listboxCTCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listboxCTCV.FormattingEnabled = true;
            this.listboxCTCV.ItemHeight = 16;
            this.listboxCTCV.Location = new System.Drawing.Point(3, 18);
            this.listboxCTCV.Name = "listboxCTCV";
            this.listboxCTCV.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listboxCTCV.Size = new System.Drawing.Size(623, 417);
            this.listboxCTCV.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listboxCongViec);
            this.groupBox2.Location = new System.Drawing.Point(40, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CÔNG VIỆC";
            // 
            // listboxCongViec
            // 
            this.listboxCongViec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listboxCongViec.FormattingEnabled = true;
            this.listboxCongViec.ItemHeight = 16;
            this.listboxCongViec.Location = new System.Drawing.Point(3, 18);
            this.listboxCongViec.Name = "listboxCongViec";
            this.listboxCongViec.Size = new System.Drawing.Size(541, 79);
            this.listboxCongViec.TabIndex = 0;
            this.listboxCongViec.SelectedIndexChanged += new System.EventHandler(this.listboxCongViec_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listboxNhom);
            this.groupBox3.Location = new System.Drawing.Point(40, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(547, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "NHÓM";
            // 
            // listboxNhom
            // 
            this.listboxNhom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listboxNhom.FormattingEnabled = true;
            this.listboxNhom.ItemHeight = 16;
            this.listboxNhom.Location = new System.Drawing.Point(3, 18);
            this.listboxNhom.Name = "listboxNhom";
            this.listboxNhom.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listboxNhom.Size = new System.Drawing.Size(541, 79);
            this.listboxNhom.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listboxDiaBan);
            this.groupBox4.Location = new System.Drawing.Point(40, 310);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(547, 103);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ĐỊA BÀN";
            // 
            // listboxDiaBan
            // 
            this.listboxDiaBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listboxDiaBan.FormattingEnabled = true;
            this.listboxDiaBan.ItemHeight = 16;
            this.listboxDiaBan.Location = new System.Drawing.Point(3, 18);
            this.listboxDiaBan.Name = "listboxDiaBan";
            this.listboxDiaBan.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listboxDiaBan.Size = new System.Drawing.Size(541, 82);
            this.listboxDiaBan.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbBuoi);
            this.groupBox5.Controls.Add(this.dateNgayChon);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(40, 429);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(547, 105);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "THỜI GIAN";
            // 
            // cbBuoi
            // 
            this.cbBuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuoi.FormattingEnabled = true;
            this.cbBuoi.Location = new System.Drawing.Point(179, 24);
            this.cbBuoi.Name = "cbBuoi";
            this.cbBuoi.Size = new System.Drawing.Size(291, 28);
            this.cbBuoi.TabIndex = 4;
            // 
            // dateNgayChon
            // 
            this.dateNgayChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayChon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayChon.Location = new System.Drawing.Point(179, 65);
            this.dateNgayChon.Name = "dateNgayChon";
            this.dateNgayChon.Size = new System.Drawing.Size(291, 26);
            this.dateNgayChon.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "NGÀY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "BUỔI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(454, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "THÊM CHI TIẾT CÔNG VIỆC";
            // 
            // btnChuyenmot
            // 
            this.btnChuyenmot.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenmot.Location = new System.Drawing.Point(620, 239);
            this.btnChuyenmot.Name = "btnChuyenmot";
            this.btnChuyenmot.Size = new System.Drawing.Size(75, 45);
            this.btnChuyenmot.TabIndex = 6;
            this.btnChuyenmot.Text = "+";
            this.btnChuyenmot.UseVisualStyleBackColor = true;
            this.btnChuyenmot.Click += new System.EventHandler(this.btnChuyenmot_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(620, 328);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 49);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "-";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Blue;
            this.btnOK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOK.Location = new System.Drawing.Point(590, 563);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 45);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // CHITIETCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1500, 620);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChuyenmot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CHITIETCV";
            this.Text = "CHITIETCV";
            this.Load += new System.EventHandler(this.CHITIETCV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listboxCTCV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listboxCongViec;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listboxNhom;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listboxDiaBan;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChuyenmot;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cbBuoi;
        private System.Windows.Forms.DateTimePicker dateNgayChon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}