
namespace CDMHX
{
    partial class frmSaoLuuPhucHoi
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
            this.components = new System.ComponentModel.Container();
            this.mUAHEXANHDataSet = new CDMHX.MUAHEXANHDataSet();
            this.v_backupsaoluuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_backupsaoluuTableAdapter = new CDMHX.MUAHEXANHDataSetTableAdapters.v_backupsaoluuTableAdapter();
            this.tableAdapterManager = new CDMHX.MUAHEXANHDataSetTableAdapters.TableAdapterManager();
            this.v_backupsaoluuGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphyname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mUAHEXANHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_backupsaoluuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_backupsaoluuGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mUAHEXANHDataSet
            // 
            this.mUAHEXANHDataSet.DataSetName = "MUAHEXANHDataSet";
            this.mUAHEXANHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_backupsaoluuBindingSource
            // 
            this.v_backupsaoluuBindingSource.DataMember = "v_backupsaoluu";
            this.v_backupsaoluuBindingSource.DataSource = this.mUAHEXANHDataSet;
            // 
            // v_backupsaoluuTableAdapter
            // 
            this.v_backupsaoluuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = CDMHX.MUAHEXANHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // v_backupsaoluuGridControl
            // 
            this.v_backupsaoluuGridControl.DataSource = this.v_backupsaoluuBindingSource;
            this.v_backupsaoluuGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.v_backupsaoluuGridControl.Location = new System.Drawing.Point(271, 62);
            this.v_backupsaoluuGridControl.MainView = this.gridView1;
            this.v_backupsaoluuGridControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.v_backupsaoluuGridControl.Name = "v_backupsaoluuGridControl";
            this.v_backupsaoluuGridControl.Size = new System.Drawing.Size(710, 275);
            this.v_backupsaoluuGridControl.TabIndex = 1;
            this.v_backupsaoluuGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname,
            this.colphyname});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.v_backupsaoluuGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colname
            // 
            this.colname.FieldName = "name";
            this.colname.MinWidth = 25;
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 94;
            // 
            // colphyname
            // 
            this.colphyname.FieldName = "phyname";
            this.colphyname.MinWidth = 25;
            this.colphyname.Name = "colphyname";
            this.colphyname.Visible = true;
            this.colphyname.VisibleIndex = 1;
            this.colphyname.Width = 94;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tạo thiết bị back up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(73, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sao lưu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(462, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 60);
            this.button3.TabIndex = 4;
            this.button3.Text = "Phục hồi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmSaoLuuPhucHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 494);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.v_backupsaoluuGridControl);
            this.Name = "frmSaoLuuPhucHoi";
            this.Text = "frmSaoLuuPhucHoi";
            this.Load += new System.EventHandler(this.frmSaoLuuPhucHoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mUAHEXANHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_backupsaoluuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_backupsaoluuGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MUAHEXANHDataSet mUAHEXANHDataSet;
        private System.Windows.Forms.BindingSource v_backupsaoluuBindingSource;
        private MUAHEXANHDataSetTableAdapters.v_backupsaoluuTableAdapter v_backupsaoluuTableAdapter;
        private MUAHEXANHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl v_backupsaoluuGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colphyname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}