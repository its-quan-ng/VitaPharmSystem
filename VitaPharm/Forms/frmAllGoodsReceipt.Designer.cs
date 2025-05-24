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
            panel1 = new Panel();
            btnFilter = new DevExpress.XtraEditors.SimpleButton();
            cboStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            cboEmployee = new DevExpress.XtraEditors.ComboBoxEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            cboSupplier = new DevExpress.XtraEditors.ComboBoxEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            dateCreate = new DevExpress.XtraEditors.DateEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            panel2 = new Panel();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            btnReload = new DevExpress.XtraEditors.SimpleButton();
            btnDeactive = new DevExpress.XtraEditors.SimpleButton();
            btnNewGoodsReceipt = new DevExpress.XtraEditors.SimpleButton();
            panel3 = new Panel();
            gridControl = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colReceiptID = new DevExpress.XtraGrid.Columns.GridColumn();
            colReceiptCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colReceiptDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colSupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            colReceiptSatus = new DevExpress.XtraGrid.Columns.GridColumn();
            colAction = new DevExpress.XtraGrid.Columns.GridColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cboStatus.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboEmployee.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboSupplier.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateCreate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateCreate.Properties.CalendarTimeProperties).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnFilter);
            panel1.Controls.Add(cboStatus);
            panel1.Controls.Add(labelControl4);
            panel1.Controls.Add(cboEmployee);
            panel1.Controls.Add(labelControl3);
            panel1.Controls.Add(cboSupplier);
            panel1.Controls.Add(labelControl2);
            panel1.Controls.Add(dateCreate);
            panel1.Controls.Add(labelControl1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(853, 83);
            panel1.TabIndex = 0;
            // 
            // btnFilter
            // 
            btnFilter.Appearance.BackColor = Color.FromArgb(255, 126, 121);
            btnFilter.Appearance.FontStyleDelta = FontStyle.Bold;
            btnFilter.Appearance.ForeColor = Color.Black;
            btnFilter.Appearance.Options.UseBackColor = true;
            btnFilter.Appearance.Options.UseFont = true;
            btnFilter.Appearance.Options.UseForeColor = true;
            btnFilter.Location = new Point(754, 32);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(85, 26);
            btnFilter.TabIndex = 8;
            btnFilter.Text = "Filter";
            // 
            // cboStatus
            // 
            cboStatus.Location = new Point(578, 34);
            cboStatus.Name = "cboStatus";
            cboStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboStatus.Size = new Size(146, 22);
            cboStatus.TabIndex = 7;
            // 
            // labelControl4
            // 
            labelControl4.Location = new Point(578, 12);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(36, 16);
            labelControl4.TabIndex = 6;
            labelControl4.Text = "Status";
            // 
            // cboEmployee
            // 
            cboEmployee.Location = new Point(381, 34);
            cboEmployee.Name = "cboEmployee";
            cboEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboEmployee.Size = new Size(156, 22);
            cboEmployee.TabIndex = 5;
            // 
            // labelControl3
            // 
            labelControl3.Location = new Point(381, 12);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(55, 16);
            labelControl3.TabIndex = 4;
            labelControl3.Text = "Employee";
            // 
            // cboSupplier
            // 
            cboSupplier.Location = new Point(185, 34);
            cboSupplier.Name = "cboSupplier";
            cboSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboSupplier.Size = new Size(143, 22);
            cboSupplier.TabIndex = 3;
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(185, 12);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(47, 16);
            labelControl2.TabIndex = 2;
            labelControl2.Text = "Supplier";
            // 
            // dateCreate
            // 
            dateCreate.EditValue = null;
            dateCreate.Location = new Point(12, 34);
            dateCreate.Name = "dateCreate";
            dateCreate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateCreate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateCreate.Size = new Size(113, 22);
            dateCreate.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(12, 12);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(73, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Date Create:";
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
            panel3.Location = new Point(0, 83);
            panel3.Name = "panel3";
            panel3.Size = new Size(853, 261);
            panel3.TabIndex = 2;
            // 
            // gridControl
            // 
            gridControl.Dock = DockStyle.Fill;
            gridControl.Location = new Point(0, 0);
            gridControl.MainView = gridView1;
            gridControl.Name = "gridControl";
            gridControl.Size = new Size(853, 261);
            gridControl.TabIndex = 0;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colReceiptID, colReceiptCode, colReceiptDate, colSupplierName, colNote, colReceiptSatus, colAction });
            gridView1.GridControl = gridControl;
            gridView1.Name = "gridView1";
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
            Controls.Add(panel1);
            Name = "frmAllGoodsReceipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "All Goods Receipt";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cboStatus.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboEmployee.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboSupplier.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateCreate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateCreate.Properties).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
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
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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