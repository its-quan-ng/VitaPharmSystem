namespace VitaPharm.Forms
{
    partial class frmGoodsReceiptDetail
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
            btnPrint = new DevExpress.XtraEditors.SimpleButton();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            btnReload = new DevExpress.XtraEditors.SimpleButton();
            panel2 = new Panel();
            lblTotalAmount = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            lblTotalQuantity = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            gridControl = new DevExpress.XtraGrid.GridControl();
            gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colID = new DevExpress.XtraGrid.Columns.GridColumn();
            colBatchCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colMfgDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colExpDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colPurchasePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            txtEmployee = new DevExpress.XtraEditors.TextEdit();
            txtReceiptCode = new DevExpress.XtraEditors.TextEdit();
            txtSupplier = new DevExpress.XtraEditors.TextEdit();
            dateReceiptDate = new DevExpress.XtraEditors.DateEdit();
            meNote = new DevExpress.XtraEditors.MemoEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtEmployee.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtReceiptCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSupplier.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateReceiptDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateReceiptDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)meNote.Properties).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnReload);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 342);
            panel1.Name = "panel1";
            panel1.Size = new Size(907, 64);
            panel1.TabIndex = 1;
            // 
            // btnPrint
            // 
            btnPrint.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            btnPrint.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnPrint.Appearance.Options.UseBackColor = true;
            btnPrint.Appearance.Options.UseFont = true;
            btnPrint.Location = new Point(583, 20);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(106, 32);
            btnPrint.TabIndex = 12;
            btnPrint.Text = "Print";
            btnPrint.Click += btnPrint_Click;
            // 
            // btnCancel
            // 
            btnCancel.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            btnCancel.Appearance.FontStyleDelta = FontStyle.Bold;
            btnCancel.Appearance.Options.UseBackColor = true;
            btnCancel.Appearance.Options.UseFont = true;
            btnCancel.Location = new Point(798, 20);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 32);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Close";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnReload
            // 
            btnReload.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            btnReload.Appearance.FontStyleDelta = FontStyle.Bold;
            btnReload.Appearance.Options.UseBackColor = true;
            btnReload.Appearance.Options.UseFont = true;
            btnReload.Location = new Point(695, 20);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(97, 32);
            btnReload.TabIndex = 0;
            btnReload.Text = "Reload";
            btnReload.Click += btnReload_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTotalAmount);
            panel2.Controls.Add(labelControl2);
            panel2.Controls.Add(lblTotalQuantity);
            panel2.Controls.Add(labelControl1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 271);
            panel2.Name = "panel2";
            panel2.Size = new Size(907, 71);
            panel2.TabIndex = 2;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            lblTotalAmount.Appearance.ForeColor = Color.FromArgb(0, 192, 0);
            lblTotalAmount.Appearance.Options.UseFont = true;
            lblTotalAmount.Appearance.Options.UseForeColor = true;
            lblTotalAmount.Appearance.Options.UseTextOptions = true;
            lblTotalAmount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            lblTotalAmount.Location = new Point(773, 49);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(28, 16);
            lblTotalAmount.TabIndex = 0;
            lblTotalAmount.Text = "0.00";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(27, 47);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(92, 16);
            labelControl2.TabIndex = 0;
            labelControl2.Text = "Total Amount:";
            // 
            // lblTotalQuantity
            // 
            lblTotalQuantity.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            lblTotalQuantity.Appearance.ForeColor = Color.Red;
            lblTotalQuantity.Appearance.Options.UseFont = true;
            lblTotalQuantity.Appearance.Options.UseForeColor = true;
            lblTotalQuantity.Appearance.Options.UseTextOptions = true;
            lblTotalQuantity.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            lblTotalQuantity.Location = new Point(773, 15);
            lblTotalQuantity.Name = "lblTotalQuantity";
            lblTotalQuantity.Size = new Size(28, 16);
            lblTotalQuantity.TabIndex = 0;
            lblTotalQuantity.Text = "0.00";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(27, 15);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(97, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Total Quantity:";
            // 
            // gridControl
            // 
            gridControl.Dock = DockStyle.Fill;
            gridControl.Location = new Point(0, 132);
            gridControl.MainView = gridView;
            gridControl.Name = "gridControl";
            gridControl.Size = new Size(907, 139);
            gridControl.TabIndex = 0;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView, gridView1 });
            // 
            // gridView
            // 
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colID, colBatchCode, colMfgDate, colExpDate, colPurchasePrice, colQuantity, colAmount });
            gridView.GridControl = gridControl;
            gridView.Name = "gridView";
            // 
            // colID
            // 
            colID.Caption = "ID";
            colID.FieldName = "ID";
            colID.MinWidth = 25;
            colID.Name = "colID";
            colID.OptionsColumn.AllowEdit = false;
            colID.Visible = true;
            colID.VisibleIndex = 0;
            colID.Width = 47;
            // 
            // colBatchCode
            // 
            colBatchCode.Caption = "Batch Code";
            colBatchCode.FieldName = "BatchCode";
            colBatchCode.MinWidth = 25;
            colBatchCode.Name = "colBatchCode";
            colBatchCode.OptionsColumn.AllowEdit = false;
            colBatchCode.Visible = true;
            colBatchCode.VisibleIndex = 1;
            colBatchCode.Width = 272;
            // 
            // colMfgDate
            // 
            colMfgDate.Caption = "Mfg Date";
            colMfgDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            colMfgDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colMfgDate.FieldName = "MfgDate";
            colMfgDate.GroupFormat.FormatString = "dd/MM/yyyy";
            colMfgDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colMfgDate.MinWidth = 25;
            colMfgDate.Name = "colMfgDate";
            colMfgDate.OptionsColumn.AllowEdit = false;
            colMfgDate.Visible = true;
            colMfgDate.VisibleIndex = 2;
            colMfgDate.Width = 126;
            // 
            // colExpDate
            // 
            colExpDate.Caption = "Exp Date";
            colExpDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            colExpDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colExpDate.FieldName = "ExpDate";
            colExpDate.GroupFormat.FormatString = "dd/MM/yyyy";
            colExpDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colExpDate.MinWidth = 25;
            colExpDate.Name = "colExpDate";
            colExpDate.OptionsColumn.AllowEdit = false;
            colExpDate.Visible = true;
            colExpDate.VisibleIndex = 3;
            colExpDate.Width = 124;
            // 
            // colPurchasePrice
            // 
            colPurchasePrice.Caption = "Purchase Price";
            colPurchasePrice.DisplayFormat.FormatString = "N0";
            colPurchasePrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colPurchasePrice.FieldName = "PurchasePrice";
            colPurchasePrice.GroupFormat.FormatString = "N0";
            colPurchasePrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colPurchasePrice.MinWidth = 25;
            colPurchasePrice.Name = "colPurchasePrice";
            colPurchasePrice.OptionsColumn.AllowEdit = false;
            colPurchasePrice.Visible = true;
            colPurchasePrice.VisibleIndex = 4;
            colPurchasePrice.Width = 109;
            // 
            // colQuantity
            // 
            colQuantity.Caption = "Qty";
            colQuantity.FieldName = "Quantity";
            colQuantity.MinWidth = 25;
            colQuantity.Name = "colQuantity";
            colQuantity.OptionsColumn.AllowEdit = false;
            colQuantity.Visible = true;
            colQuantity.VisibleIndex = 5;
            colQuantity.Width = 48;
            // 
            // colAmount
            // 
            colAmount.Caption = "Amount";
            colAmount.DisplayFormat.FormatString = "N0";
            colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colAmount.FieldName = "Amount";
            colAmount.GroupFormat.FormatString = "N0";
            colAmount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colAmount.MinWidth = 25;
            colAmount.Name = "colAmount";
            colAmount.OptionsColumn.AllowEdit = false;
            colAmount.UnboundDataType = typeof(decimal);
            colAmount.Visible = true;
            colAmount.VisibleIndex = 6;
            colAmount.Width = 125;
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl;
            gridView1.Name = "gridView1";
            // 
            // groupControl1
            // 
            groupControl1.Appearance.BackColor = Color.White;
            groupControl1.Appearance.Options.UseBackColor = true;
            groupControl1.Appearance.Options.UseBorderColor = true;
            groupControl1.AppearanceCaption.BorderColor = Color.FromArgb(93, 83, 167);
            groupControl1.AppearanceCaption.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupControl1.AppearanceCaption.ForeColor = Color.FromArgb(244, 221, 180);
            groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            groupControl1.AppearanceCaption.Options.UseFont = true;
            groupControl1.AppearanceCaption.Options.UseForeColor = true;
            groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            groupControl1.Controls.Add(txtEmployee);
            groupControl1.Controls.Add(txtReceiptCode);
            groupControl1.Controls.Add(txtSupplier);
            groupControl1.Controls.Add(dateReceiptDate);
            groupControl1.Controls.Add(meNote);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(labelControl5);
            groupControl1.Controls.Add(labelControl4);
            groupControl1.Controls.Add(labelControl6);
            groupControl1.Controls.Add(labelControl7);
            groupControl1.Dock = DockStyle.Top;
            groupControl1.Location = new Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(907, 132);
            groupControl1.TabIndex = 3;
            groupControl1.Text = "Basic Information";
            // 
            // txtEmployee
            // 
            txtEmployee.Anchor = AnchorStyles.Top;
            txtEmployee.Location = new Point(683, 43);
            txtEmployee.Name = "txtEmployee";
            txtEmployee.Size = new Size(185, 22);
            txtEmployee.TabIndex = 13;
            // 
            // txtReceiptCode
            // 
            txtReceiptCode.Anchor = AnchorStyles.Top;
            txtReceiptCode.Location = new Point(125, 43);
            txtReceiptCode.Name = "txtReceiptCode";
            txtReceiptCode.Size = new Size(168, 22);
            txtReceiptCode.TabIndex = 11;
            // 
            // txtSupplier
            // 
            txtSupplier.Anchor = AnchorStyles.Top;
            txtSupplier.Location = new Point(125, 79);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(285, 22);
            txtSupplier.TabIndex = 14;
            // 
            // dateReceiptDate
            // 
            dateReceiptDate.Anchor = AnchorStyles.Top;
            dateReceiptDate.EditValue = null;
            dateReceiptDate.Location = new Point(426, 43);
            dateReceiptDate.Name = "dateReceiptDate";
            dateReceiptDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateReceiptDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateReceiptDate.Size = new Size(130, 22);
            dateReceiptDate.TabIndex = 12;
            // 
            // meNote
            // 
            meNote.Anchor = AnchorStyles.Top;
            meNote.Location = new Point(595, 80);
            meNote.Name = "meNote";
            meNote.Properties.ScrollBars = ScrollBars.Horizontal;
            meNote.Size = new Size(273, 33);
            meNote.TabIndex = 15;
            // 
            // labelControl3
            // 
            labelControl3.Anchor = AnchorStyles.Top;
            labelControl3.Location = new Point(530, 85);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(26, 16);
            labelControl3.TabIndex = 6;
            labelControl3.Text = "Note";
            // 
            // labelControl5
            // 
            labelControl5.Anchor = AnchorStyles.Top;
            labelControl5.Location = new Point(595, 46);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(55, 16);
            labelControl5.TabIndex = 7;
            labelControl5.Text = "Employee";
            // 
            // labelControl4
            // 
            labelControl4.Anchor = AnchorStyles.Top;
            labelControl4.Location = new Point(36, 82);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(47, 16);
            labelControl4.TabIndex = 8;
            labelControl4.Text = "Supplier";
            // 
            // labelControl6
            // 
            labelControl6.Anchor = AnchorStyles.Top;
            labelControl6.Location = new Point(338, 46);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(72, 16);
            labelControl6.TabIndex = 9;
            labelControl6.Text = "Receipt Date";
            // 
            // labelControl7
            // 
            labelControl7.Anchor = AnchorStyles.Top;
            labelControl7.Location = new Point(36, 46);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(75, 16);
            labelControl7.TabIndex = 10;
            labelControl7.Text = "Receipt Code";
            // 
            // frmGoodsReceiptDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 406);
            Controls.Add(gridControl);
            Controls.Add(groupControl1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmGoodsReceiptDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Goods Receipt Detail";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtEmployee.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtReceiptCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSupplier.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateReceiptDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateReceiptDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)meNote.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblTotalAmount;
        private DevExpress.XtraEditors.LabelControl lblTotalQuantity;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colBatchCode;
        private DevExpress.XtraGrid.Columns.GridColumn colMfgDate;
        private DevExpress.XtraGrid.Columns.GridColumn colExpDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchasePrice;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtEmployee;
        private DevExpress.XtraEditors.TextEdit txtReceiptCode;
        private DevExpress.XtraEditors.TextEdit txtSupplier;
        private DevExpress.XtraEditors.DateEdit dateReceiptDate;
        private DevExpress.XtraEditors.MemoEdit meNote;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}