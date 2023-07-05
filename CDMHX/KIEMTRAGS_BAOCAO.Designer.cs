
namespace CDMHX
{
    partial class KIEMTRAGS_BAOCAO
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.txtMaGS = new System.Windows.Forms.TextBox();
            this.labelMaGS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNamCd = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtNamCd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Controls.Add(this.txtMaGS);
            this.panel1.Controls.Add(this.labelMaGS);
            this.panel1.Location = new System.Drawing.Point(322, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 369);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "NĂM CHIẾN DỊCH";
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.Blue;
            this.btnXem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXem.Location = new System.Drawing.Point(309, 219);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(99, 41);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "XEM";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // txtMaGS
            // 
            this.txtMaGS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGS.Location = new System.Drawing.Point(187, 152);
            this.txtMaGS.Name = "txtMaGS";
            this.txtMaGS.Size = new System.Drawing.Size(221, 26);
            this.txtMaGS.TabIndex = 1;
            // 
            // labelMaGS
            // 
            this.labelMaGS.AutoSize = true;
            this.labelMaGS.Location = new System.Drawing.Point(48, 152);
            this.labelMaGS.Name = "labelMaGS";
            this.labelMaGS.Size = new System.Drawing.Size(38, 17);
            this.labelMaGS.TabIndex = 0;
            this.labelMaGS.Text = "laebl";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(252, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "BÁO CÁO";
            // 
            // txtNamCd
            // 
            this.txtNamCd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamCd.Location = new System.Drawing.Point(187, 94);
            this.txtNamCd.Name = "txtNamCd";
            this.txtNamCd.ReadOnly = true;
            this.txtNamCd.Size = new System.Drawing.Size(221, 26);
            this.txtNamCd.TabIndex = 4;
            // 
            // KIEMTRAGS_BAOCAO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "KIEMTRAGS_BAOCAO";
            this.Text = "KIEMTRAGS_BAOCAO";
            this.Load += new System.EventHandler(this.KIEMTRAGS_BAOCAO_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.TextBox txtMaGS;
        private System.Windows.Forms.Label labelMaGS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNamCd;
    }
}