namespace VitaPharm.Forms
{
    partial class frmAllGoodsReceipt
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
            panel2 = new Panel();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            btnReload = new DevExpress.XtraEditors.SimpleButton();
            btnDeactive = new DevExpress.XtraEditors.SimpleButton();
            btnNewGoodsReceipt = new DevExpress.XtraEditors.SimpleButton();
            panel3 = new Panel();
            gridControl = new DevExpress.XtraGrid.GridControl();
            gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colReceiptID = new DevExpress.XtraGrid.Columns.GridColumn();
            colReceiptCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colReceiptDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colSupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            colReceiptSatus = new DevExpress.XtraGrid.Columns.GridColumn();
            colAction = new DevExpress.XtraGrid.Columns.GridColumn();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnReload);
            panel2.Controls.Add(btnDeactive);
            panel2.Controls.Add(btnNewGoodsReceipt);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 344);
            panel2.Name = "panel2";
            panel2.Size = new Size(853, 71);
            panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            btnCancel.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnCancel.Appearance.Options.UseBackColor = true;
            btnCancel.Appearance.Options.UseFont = true;
            btnCancel.Location = new Point(714, 20);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 36);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            // 
            // btnReload
            // 
            btnReload.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            btnReload.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnReload.Appearance.Options.UseBackColor = true;
            btnReload.Appearance.Options.UseFont = true;
            btnReload.Location = new Point(590, 20);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(118, 36);
            btnReload.TabIndex = 9;
            btnReload.Text = "Reload";
            // 
            // btnDeactive
            // 
            btnDeactive.Appearance.BackColor = Color.FromArgb(78, 109, 156);
            btnDeactive.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnDeactive.Appearance.Options.UseBackColor = true;
            btnDeactive.Appearance.Options.UseFont = true;
            btnDeactive.Location = new Point(466, 20);
            btnDeactive.Name = "btnDeactive";
            btnDeactive.Size = new Size(118, 36);
            btnDeactive.TabIndex = 8;
            btnDeactive.Text = "Deactive";
            // 
            // btnNewGoodsReceipt
            // 
            btnNewGoodsReceipt.Appearance.BackColor = Color.FromArgb(100, 165, 80);
            btnNewGoodsReceipt.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnNewGoodsReceipt.Appearance.Options.UseBackColor = true;
            btnNewGoodsReceipt.Appearance.Options.UseFont = true;
            btnNewGoodsReceipt.Location = new Point(311, 20);
            btnNewGoodsReceipt.Name = "btnNewGoodsReceipt";
            btnNewGoodsReceipt.Size = new Size(149, 36);
            btnNewGoodsReceipt.TabIndex = 7;
            btnNewGoodsReceipt.Text = "New Goods Receipt";
            // 
            // panel3
            // 
            panel3.Controls.Add(gridControl);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(853, 344);
            panel3.TabIndex = 2;
            // 
            // gridControl
            // 
            gridControl.Dock = DockStyle.Fill;
            gridControl.Location = new Point(0, 0);
            gridControl.MainView = gridView;
            gridControl.Name = "gridControl";
            gridControl.Size = new Size(853, 344);
            gridControl.TabIndex = 0;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // gridView
            // 
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colReceiptID, colReceiptCode, colReceiptDate, colSupplierName, colNote, colReceiptSatus, colAction });
            gridView.GridControl = gridControl;
            gridView.Name = "gridView";
            gridView.OptionsView.ShowAutoFilterRow = true;
            // 
            // colReceiptID
            // 
            colReceiptID.Caption = "ID";
            colReceiptID.FieldName = "ID";
            colReceiptID.MinWidth = 25;
            colReceiptID.Name = "colReceiptID";
            colReceiptID.OptionsColumn.AllowEdit = false;
            colReceiptID.Visible = true;
            colReceiptID.VisibleIndex = 0;
            colReceiptID.Width = 94;
            // 
            // colReceiptCode
            // 
            colReceiptCode.Caption = "Receipt Code";
            colReceiptCode.FieldName = "ReceiptCode";
            colReceiptCode.MinWidth = 25;
            colReceiptCode.Name = "colReceiptCode";
            colReceiptCode.OptionsColumn.AllowEdit = false;
            colReceiptCode.Visible = true;
            colReceiptCode.VisibleIndex = 1;
            colReceiptCode.Width = 94;
            // 
            // colReceiptDate
            // 
            colReceiptDate.Caption = "Date";
            colReceiptDate.FieldName = "ReceiptDate";
            colReceiptDate.MinWidth = 25;
            colReceiptDate.Name = "colReceiptDate";
            colReceiptDate.OptionsColumn.AllowEdit = false;
            colReceiptDate.Visible = true;
            colReceiptDate.VisibleIndex = 2;
            colReceiptDate.Width = 94;
            // 
            // colSupplierName
            // 
            colSupplierName.Caption = "Supplier Name";
            colSupplierName.FieldName = "SupplierName";
            colSupplierName.MinWidth = 25;
            colSupplierName.Name = "colSupplierName";
            colSupplierName.OptionsColumn.AllowEdit = false;
            colSupplierName.Visible = true;
            colSupplierName.VisibleIndex = 3;
            colSupplierName.Width = 94;
            // 
            // colNote
            // 
            colNote.Caption = "Note";
            colNote.FieldName = "Note";
            colNote.MinWidth = 25;
            colNote.Name = "colNote";
            colNote.OptionsColumn.AllowEdit = false;
            colNote.Visible = true;
            colNote.VisibleIndex = 4;
            colNote.Width = 94;
            // 
            // colReceiptSatus
            // 
            colReceiptSatus.Caption = "Satus ";
            colReceiptSatus.FieldName = "ReceiptSatus ";
            colReceiptSatus.MinWidth = 25;
            colReceiptSatus.Name = "colReceiptSatus";
            colReceiptSatus.OptionsColumn.AllowEdit = false;
            colReceiptSatus.Visible = true;
            colReceiptSatus.VisibleIndex = 5;
            colReceiptSatus.Width = 94;
            // 
            // colAction
            // 
            colAction.Caption = "Action";
            colAction.MinWidth = 25;
            colAction.Name = "colAction";
            colAction.Visible = true;
            colAction.VisibleIndex = 6;
            colAction.Width = 94;
            // 
            // frmAllGoodsReceipt
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 415);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "frmAllGoodsReceipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "All Goods Receipt";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DevExpress.XtraEditors.ComboBoxEdit cboStatus;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cboEmployee;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cboSupplier;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateCreate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnFilter;
        private Panel panel2;
        private Panel panel3;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiptID;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiptCode;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiptDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierName;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiptSatus;
        private DevExpress.XtraGrid.Columns.GridColumn colAction;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraEditors.SimpleButton btnDeactive;
        private DevExpress.XtraEditors.SimpleButton btnNewGoodsReceipt;
    }
}