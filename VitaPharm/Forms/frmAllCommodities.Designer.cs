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
            colID = new DevExpress.XtraGrid.Columns.GridColumn();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colID, gridColumn1 });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // colID
            // 
            colID.Caption = "ID";
            colID.FieldName = "CommodityID";
            colID.MinWidth = 25;
            colID.Name = "colID";
            colID.Visible = true;
            colID.VisibleIndex = 0;
            colID.Width = 94;
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(0, 132);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(831, 330);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "gridColumn1";
            gridColumn1.MinWidth = 25;
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 1;
            gridColumn1.Width = 94;
            // 
            // groupControl1
            // 
            groupControl1.AppearanceCaption.Font = new Font("Inter", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupControl1.AppearanceCaption.ForeColor = Color.FromArgb(16, 53, 113);
            groupControl1.AppearanceCaption.Options.UseFont = true;
            groupControl1.AppearanceCaption.Options.UseForeColor = true;
            groupControl1.Controls.Add(textEdit1);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Dock = DockStyle.Top;
            groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            groupControl1.Location = new Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(831, 132);
            groupControl1.TabIndex = 1;
            groupControl1.Text = "Commodity Information";
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(21, 31);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(42, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Name: ";
            // 
            // textEdit1
            // 
            textEdit1.EditValue = "";
            textEdit1.Location = new Point(69, 31);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(156, 22);
            textEdit1.TabIndex = 1;
            // 
            // frmAllCommodities
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 462);
            Controls.Add(gridControl1);
            Controls.Add(groupControl1);
            Name = "frmAllCommodities";
            Text = "frmAllCommodities";
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}