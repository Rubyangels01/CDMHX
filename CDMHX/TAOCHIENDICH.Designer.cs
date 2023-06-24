
namespace CDMHX
{
    partial class TAOCHIENDICH
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dateNgayBD = new System.Windows.Forms.DateTimePicker();
            this.txtTenCD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cbMaCD = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(440, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TẠO CHIẾN DỊCH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMaCD);
            this.groupBox1.Controls.Add(this.dateNgayKT);
            this.groupBox1.Controls.Add(this.dateNgayBD);
            this.groupBox1.Controls.Add(this.txtTenCD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(52, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(945, 146);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TẠO CHIẾN DỊCH";
            // 
            // dateNgayKT
            // 
            this.dateNgayKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayKT.Location = new System.Drawing.Point(688, 90);
            this.dateNgayKT.Name = "dateNgayKT";
            this.dateNgayKT.Size = new System.Drawing.Size(200, 26);
            this.dateNgayKT.TabIndex = 7;
            // 
            // dateNgayBD
            // 
            this.dateNgayBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayBD.Location = new System.Drawing.Point(688, 39);
            this.dateNgayBD.Name = "dateNgayBD";
            this.dateNgayBD.Size = new System.Drawing.Size(200, 26);
            this.dateNgayBD.TabIndex = 6;
            // 
            // txtTenCD
            // 
            this.txtTenCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCD.Location = new System.Drawing.Point(198, 87);
            this.txtTenCD.Name = "txtTenCD";
            this.txtTenCD.Size = new System.Drawing.Size(225, 26);
            this.txtTenCD.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "NGÀY KẾT THÚC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(510, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "NGÀY BẮT ĐẦU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "TÊN CHIẾN DỊCH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "MÃ CHIẾN DỊCH";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(272, 295);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(166, 46);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "THÊM CHIẾN DỊCH";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(565, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 46);
            this.button3.TabIndex = 5;
            this.button3.Text = "SỬA CHIẾN DỊCH";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cbMaCD
            // 
            this.cbMaCD.FormattingEnabled = true;
            this.cbMaCD.Location = new System.Drawing.Point(198, 44);
            this.cbMaCD.Name = "cbMaCD";
            this.cbMaCD.Size = new System.Drawing.Size(225, 24);
            this.cbMaCD.TabIndex = 8;
            // 
            // TAOCHIENDICH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 373);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "TAOCHIENDICH";
            this.Text = "TAOCHIENDICH";
            this.Load += new System.EventHandler(this.TAOCHIENDICH_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateNgayKT;
        private System.Windows.Forms.DateTimePicker dateNgayBD;
        private System.Windows.Forms.TextBox txtTenCD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbMaCD;
    }
}