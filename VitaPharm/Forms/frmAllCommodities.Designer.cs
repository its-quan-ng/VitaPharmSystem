namespace VitaPharm.Forms
{
    partial class frmAllCommodities
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
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColID = new DevExpress.XtraGrid.Columns.GridColumn();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            SuspendLayout();
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColID });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // gridColID
            // 
            gridColID.Caption = "ID";
            gridColID.FieldName = "CommodityID";
            gridColID.MinWidth = 25;
            gridColID.Name = "gridColID";
            gridColID.Visible = true;
            gridColID.VisibleIndex = 0;
            gridColID.Width = 94;
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(0, 0);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(831, 462);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // frmAllCommodities
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 462);
            Controls.Add(gridControl1);
            Name = "frmAllCommodities";
            Text = "frmAllCommodities";
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColID;
        private DevExpress.XtraGrid.GridControl gridControl1;
    }
}