namespace VitaPharm.Forms
{
    partial class frmNewGoodsReceipt
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
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            grpDetails = new DevExpress.XtraEditors.GroupControl();
            gridControl = new DevExpress.XtraGrid.GridControl();
            gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colCommodityName = new DevExpress.XtraGrid.Columns.GridColumn();
            colBatchCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            colPurchasePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            btnAddBatch = new DevExpress.XtraEditors.SimpleButton();
            grpInfo = new DevExpress.XtraEditors.GroupControl();
            txtEmployee = new DevExpress.XtraEditors.TextEdit();
            txtReceiptCode = new DevExpress.XtraEditors.TextEdit();
            txtSupplier = new DevExpress.XtraEditors.TextEdit();
            dateReceiptDate = new DevExpress.XtraEditors.DateEdit();
            meNote = new DevExpress.XtraEditors.MemoEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            grpSum = new DevExpress.XtraEditors.GroupControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grpDetails).BeginInit();
            grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grpInfo).BeginInit();
            grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtEmployee.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtReceiptCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSupplier.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateReceiptDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateReceiptDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)meNote.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grpSum).BeginInit();
            grpSum.SuspendLayout();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(groupControl1);
            panelControl1.Dock = DockStyle.Fill;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(917, 498);
            panelControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            groupControl1.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            groupControl1.Controls.Add(grpDetails);
            groupControl1.Controls.Add(grpInfo);
            groupControl1.Controls.Add(grpSum);
            groupControl1.Dock = DockStyle.Fill;
            groupControl1.Location = new Point(2, 2);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(913, 494);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "New Goods Receipt";
            // 
            // grpDetails
            // 
            grpDetails.AppearanceCaption.FontStyleDelta = FontStyle.Bold;
            grpDetails.AppearanceCaption.ForeColor = Color.Maroon;
            grpDetails.AppearanceCaption.Options.UseFont = true;
            grpDetails.AppearanceCaption.Options.UseForeColor = true;
            grpDetails.Controls.Add(gridControl);
            grpDetails.Controls.Add(panelControl2);
            grpDetails.Dock = DockStyle.Fill;
            grpDetails.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            grpDetails.Location = new Point(2, 164);
            grpDetails.Name = "grpDetails";
            grpDetails.Size = new Size(909, 231);
            grpDetails.TabIndex = 1;
            grpDetails.Text = "Goods Receipt Details";
            // 
            // gridControl
            // 
            gridControl.Dock = DockStyle.Fill;
            gridControl.Location = new Point(2, 67);
            gridControl.MainView = gridView;
            gridControl.Name = "gridControl";
            gridControl.Size = new Size(905, 162);
            gridControl.TabIndex = 0;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // gridView
            // 
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colCommodityName, colBatchCode, colQuantity, colPurchasePrice, Amount });
            gridView.GridControl = gridControl;
            gridView.Name = "gridView";
            // 
            // colCommodityName
            // 
            colCommodityName.Caption = "Commodity Name";
            colCommodityName.FieldName = "CommodityName";
            colCommodityName.MinWidth = 25;
            colCommodityName.Name = "colCommodityName";
            colCommodityName.Visible = true;
            colCommodityName.VisibleIndex = 0;
            colCommodityName.Width = 94;
            // 
            // colBatchCode
            // 
            colBatchCode.Caption = "Batch Code";
            colBatchCode.FieldName = "BatchCode";
            colBatchCode.MinWidth = 25;
            colBatchCode.Name = "colBatchCode";
            colBatchCode.Visible = true;
            colBatchCode.VisibleIndex = 1;
            colBatchCode.Width = 94;
            // 
            // colQuantity
            // 
            colQuantity.Caption = "Quantity";
            colQuantity.FieldName = "QtyIn";
            colQuantity.MinWidth = 25;
            colQuantity.Name = "colQuantity";
            colQuantity.Visible = true;
            colQuantity.VisibleIndex = 2;
            colQuantity.Width = 94;
            // 
            // colPurchasePrice
            // 
            colPurchasePrice.Caption = "Purchase Price";
            colPurchasePrice.FieldName = "PurchasePrice";
            colPurchasePrice.MinWidth = 25;
            colPurchasePrice.Name = "colPurchasePrice";
            colPurchasePrice.Visible = true;
            colPurchasePrice.VisibleIndex = 3;
            colPurchasePrice.Width = 94;
            // 
            // Amount
            // 
            Amount.Caption = "Amount";
            Amount.FieldName = "Amount";
            Amount.MinWidth = 25;
            Amount.Name = "Amount";
            Amount.Visible = true;
            Amount.VisibleIndex = 4;
            Amount.Width = 94;
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(btnAddBatch);
            panelControl2.Dock = DockStyle.Top;
            panelControl2.Location = new Point(2, 28);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(905, 39);
            panelControl2.TabIndex = 2;
            // 
            // btnAddBatch
            // 
            btnAddBatch.Appearance.BackColor = Color.White;
            btnAddBatch.Appearance.BorderColor = Color.FromArgb(192, 0, 0);
            btnAddBatch.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddBatch.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical;
            btnAddBatch.Appearance.Options.UseBackColor = true;
            btnAddBatch.Appearance.Options.UseBorderColor = true;
            btnAddBatch.Appearance.Options.UseFont = true;
            btnAddBatch.Appearance.Options.UseForeColor = true;
            btnAddBatch.AppearanceHovered.Options.UseBorderColor = true;
            btnAddBatch.AppearancePressed.Options.UseBorderColor = true;
            btnAddBatch.Location = new Point(777, 5);
            btnAddBatch.Name = "btnAddBatch";
            btnAddBatch.Size = new Size(99, 29);
            btnAddBatch.TabIndex = 1;
            btnAddBatch.Text = "Add Batch";
            // 
            // grpInfo
            // 
            grpInfo.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpInfo.Appearance.Options.UseFont = true;
            grpInfo.AppearanceCaption.FontStyleDelta = FontStyle.Bold;
            grpInfo.AppearanceCaption.ForeColor = Color.FromArgb(16, 53, 113);
            grpInfo.AppearanceCaption.Options.UseFont = true;
            grpInfo.AppearanceCaption.Options.UseForeColor = true;
            grpInfo.Controls.Add(txtEmployee);
            grpInfo.Controls.Add(txtReceiptCode);
            grpInfo.Controls.Add(txtSupplier);
            grpInfo.Controls.Add(dateReceiptDate);
            grpInfo.Controls.Add(meNote);
            grpInfo.Controls.Add(labelControl3);
            grpInfo.Controls.Add(labelControl5);
            grpInfo.Controls.Add(labelControl2);
            grpInfo.Controls.Add(labelControl4);
            grpInfo.Controls.Add(labelControl1);
            grpInfo.Dock = DockStyle.Top;
            grpInfo.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            grpInfo.Location = new Point(2, 28);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new Size(909, 136);
            grpInfo.TabIndex = 0;
            grpInfo.Text = "Receipt Info";
            // 
            // txtEmployee
            // 
            txtEmployee.Location = new Point(684, 30);
            txtEmployee.Name = "txtEmployee";
            txtEmployee.Size = new Size(185, 22);
            txtEmployee.TabIndex = 4;
            // 
            // txtReceiptCode
            // 
            txtReceiptCode.Location = new Point(126, 30);
            txtReceiptCode.Name = "txtReceiptCode";
            txtReceiptCode.Size = new Size(134, 22);
            txtReceiptCode.TabIndex = 1;
            // 
            // txtSupplier
            // 
            txtSupplier.Location = new Point(126, 66);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(134, 22);
            txtSupplier.TabIndex = 3;
            // 
            // dateReceiptDate
            // 
            dateReceiptDate.EditValue = null;
            dateReceiptDate.Location = new Point(427, 30);
            dateReceiptDate.Name = "dateReceiptDate";
            dateReceiptDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateReceiptDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateReceiptDate.Size = new Size(130, 22);
            dateReceiptDate.TabIndex = 2;
            // 
            // meNote
            // 
            meNote.Location = new Point(427, 67);
            meNote.Name = "meNote";
            meNote.Properties.ScrollBars = ScrollBars.Horizontal;
            meNote.Size = new Size(442, 54);
            meNote.TabIndex = 5;
            // 
            // labelControl3
            // 
            labelControl3.Location = new Point(339, 69);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(26, 16);
            labelControl3.TabIndex = 0;
            labelControl3.Text = "Note";
            // 
            // labelControl5
            // 
            labelControl5.Location = new Point(596, 33);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(55, 16);
            labelControl5.TabIndex = 0;
            labelControl5.Text = "Employee";
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(37, 69);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(47, 16);
            labelControl2.TabIndex = 0;
            labelControl2.Text = "Supplier";
            // 
            // labelControl4
            // 
            labelControl4.Location = new Point(339, 33);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(72, 16);
            labelControl4.TabIndex = 0;
            labelControl4.Text = "Receipt Date";
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(37, 33);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(75, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Receipt Code";
            // 
            // grpSum
            // 
            grpSum.AppearanceCaption.FontStyleDelta = FontStyle.Bold;
            grpSum.AppearanceCaption.Options.UseFont = true;
            grpSum.Controls.Add(labelControl6);
            grpSum.Controls.Add(btnCancel);
            grpSum.Controls.Add(btnAdd);
            grpSum.Controls.Add(labelControl8);
            grpSum.Dock = DockStyle.Bottom;
            grpSum.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            grpSum.Location = new Point(2, 395);
            grpSum.Name = "grpSum";
            grpSum.Size = new Size(909, 97);
            grpSum.TabIndex = 2;
            grpSum.Text = "Summary";
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new Point(860, 28);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(20, 16);
            labelControl6.TabIndex = 2;
            labelControl6.Text = "0.0";
            // 
            // btnCancel
            // 
            btnCancel.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnCancel.Appearance.Options.UseFont = true;
            btnCancel.Location = new Point(463, 58);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 29);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            // 
            // btnAdd
            // 
            btnAdd.Appearance.BackColor = Color.FromArgb(50, 112, 188);
            btnAdd.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnAdd.Appearance.ForeColor = Color.Black;
            btnAdd.Appearance.Options.UseBackColor = true;
            btnAdd.Appearance.Options.UseFont = true;
            btnAdd.Appearance.Options.UseForeColor = true;
            btnAdd.Location = new Point(349, 58);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(97, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.Location = new Point(695, 28);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(32, 16);
            labelControl8.TabIndex = 0;
            labelControl8.Text = "Total";
            // 
            // frmNewGoodsReceipt
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 498);
            Controls.Add(panelControl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNewGoodsReceipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Goods Receipt";
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grpDetails).EndInit();
            grpDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grpInfo).EndInit();
            grpInfo.ResumeLayout(false);
            grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtEmployee.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtReceiptCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSupplier.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateReceiptDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateReceiptDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)meNote.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)grpSum).EndInit();
            grpSum.ResumeLayout(false);
            grpSum.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl grpInfo;
        private DevExpress.XtraEditors.GroupControl grpSum;
        private DevExpress.XtraEditors.GroupControl grpDetails;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateReceiptDate;
        private DevExpress.XtraEditors.MemoEdit meNote;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colCommodityName;
        private DevExpress.XtraGrid.Columns.GridColumn colBatchCode;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchasePrice;
        private DevExpress.XtraGrid.Columns.GridColumn Amount;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.TextEdit txtEmployee;
        private DevExpress.XtraEditors.TextEdit txtSupplier;
        private DevExpress.XtraEditors.TextEdit txtReceiptCode;
        private DevExpress.XtraEditors.SimpleButton btnAddBatch;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}