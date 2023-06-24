
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbNamCD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMaKT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listSV = new System.Windows.Forms.DataGridView();
            this.listSV2 = new System.Windows.Forms.DataGridView();
            this.txtMucDoKT = new System.Windows.Forms.TextBox();
            this.txtNoiDungKT = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listSV)).BeginInit();
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
            // cbNamCD
            // 
            this.cbNamCD.FormattingEnabled = true;
            this.cbNamCD.Location = new System.Drawing.Point(27, 34);
            this.cbNamCD.Name = "cbNamCD";
            this.cbNamCD.Size = new System.Drawing.Size(374, 24);
            this.cbNamCD.TabIndex = 0;
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
            this.groupBox3.Size = new System.Drawing.Size(567, 160);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listSV2);
            this.groupBox4.Location = new System.Drawing.Point(791, 382);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(503, 160);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(1109, 304);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(185, 60);
            this.btnXem.TabIndex = 7;
            this.btnXem.Text = "XEM DS SINH VIÊN CHƯA KHEN THƯỞNG";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(653, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "THÊM";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(653, 467);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 36);
            this.button3.TabIndex = 9;
            this.button3.Text = "XOÁ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // listSV
            // 
            this.listSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSV.Location = new System.Drawing.Point(3, 18);
            this.listSV.Name = "listSV";
            this.listSV.RowHeadersWidth = 51;
            this.listSV.RowTemplate.Height = 24;
            this.listSV.Size = new System.Drawing.Size(561, 139);
            this.listSV.TabIndex = 0;
            // 
            // listSV2
            // 
            this.listSV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listSV2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSV2.Location = new System.Drawing.Point(3, 18);
            this.listSV2.Name = "listSV2";
            this.listSV2.RowHeadersWidth = 51;
            this.listSV2.RowTemplate.Height = 24;
            this.listSV2.Size = new System.Drawing.Size(497, 139);
            this.listSV2.TabIndex = 0;
            // 
            // txtMucDoKT
            // 
            this.txtMucDoKT.Location = new System.Drawing.Point(490, 41);
            this.txtMucDoKT.Name = "txtMucDoKT";
            this.txtMucDoKT.Size = new System.Drawing.Size(249, 22);
            this.txtMucDoKT.TabIndex = 7;
            this.txtMucDoKT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNoiDungKT
            // 
            this.txtNoiDungKT.Location = new System.Drawing.Point(875, 37);
            this.txtNoiDungKT.Name = "txtNoiDungKT";
            this.txtNoiDungKT.Size = new System.Drawing.Size(354, 22);
            this.txtNoiDungKT.TabIndex = 8;
            // 
            // KHENTHUONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1306, 554);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
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
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listSV)).EndInit();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtNoiDungKT;
        private System.Windows.Forms.TextBox txtMucDoKT;
    }
}