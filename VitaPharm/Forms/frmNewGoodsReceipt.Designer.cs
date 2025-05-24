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
            btnAddBatch = new DevExpress.XtraEditors.SimpleButton();
            gridControl = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            Commodity = new DevExpress.XtraGrid.Columns.GridColumn();
            Batch = new DevExpress.XtraGrid.Columns.GridColumn();
            Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            PurchasePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            grpInfo = new DevExpress.XtraEditors.GroupControl();
            txtEmployee = new DevExpress.XtraEditors.TextEdit();
            txtReceiptCode = new DevExpress.XtraEditors.TextEdit();
            txtSupplier = new DevExpress.XtraEditors.TextEdit();
            deReceiptDate = new DevExpress.XtraEditors.DateEdit();
            meNote = new DevExpress.XtraEditors.MemoEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            grpSum = new DevExpress.XtraEditors.GroupControl();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
            label3 = new Label();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grpDetails).BeginInit();
            grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grpInfo).BeginInit();
            grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtEmployee.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtReceiptCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSupplier.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deReceiptDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deReceiptDate.Properties.CalendarTimeProperties).BeginInit();
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
            panelControl1.Size = new Size(614, 487);
            panelControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(grpDetails);
            groupControl1.Controls.Add(grpInfo);
            groupControl1.Controls.Add(grpSum);
            groupControl1.Dock = DockStyle.Fill;
            groupControl1.Location = new Point(2, 2);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(610, 483);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "New Goods Receipt";
            // 
            // grpDetails
            // 
            grpDetails.AppearanceCaption.FontStyleDelta = FontStyle.Bold;
            grpDetails.AppearanceCaption.Options.UseFont = true;
            grpDetails.Controls.Add(btnAddBatch);
            grpDetails.Controls.Add(gridControl);
            grpDetails.Dock = DockStyle.Fill;
            grpDetails.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            grpDetails.Location = new Point(2, 231);
            grpDetails.Name = "grpDetails";
            grpDetails.Size = new Size(606, 153);
            grpDetails.TabIndex = 1;
            grpDetails.Text = "Good Receipt Details";
            // 
            // btnAddBatch
            // 
            btnAddBatch.Location = new Point(496, 34);
            btnAddBatch.Name = "btnAddBatch";
            btnAddBatch.Size = new Size(99, 29);
            btnAddBatch.TabIndex = 1;
            btnAddBatch.Text = "Add Batch";
            // 
            // gridControl
            // 
            gridControl.Dock = DockStyle.Fill;
            gridControl.Location = new Point(2, 28);
            gridControl.MainView = gridView1;
            gridControl.Name = "gridControl";
            gridControl.Size = new Size(602, 123);
            gridControl.TabIndex = 0;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { Commodity, Batch, Quantity, PurchasePrice, Amount });
            gridView1.GridControl = gridControl;
            gridView1.Name = "gridView1";
            // 
            // Commodity
            // 
            Commodity.Caption = "Commodity";
            Commodity.FieldName = "Commodity";
            Commodity.MinWidth = 25;
            Commodity.Name = "Commodity";
            Commodity.Visible = true;
            Commodity.VisibleIndex = 0;
            Commodity.Width = 94;
            // 
            // Batch
            // 
            Batch.Caption = "Batch";
            Batch.FieldName = "Batch";
            Batch.MinWidth = 25;
            Batch.Name = "Batch";
            Batch.Visible = true;
            Batch.VisibleIndex = 1;
            Batch.Width = 94;
            // 
            // Quantity
            // 
            Quantity.Caption = "Quantity";
            Quantity.FieldName = "Quantity";
            Quantity.MinWidth = 25;
            Quantity.Name = "Quantity";
            Quantity.Visible = true;
            Quantity.VisibleIndex = 2;
            Quantity.Width = 94;
            // 
            // PurchasePrice
            // 
            PurchasePrice.Caption = "Purchase Price";
            PurchasePrice.FieldName = "PurchasePrice";
            PurchasePrice.MinWidth = 25;
            PurchasePrice.Name = "PurchasePrice";
            PurchasePrice.Visible = true;
            PurchasePrice.VisibleIndex = 3;
            PurchasePrice.Width = 94;
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
            // grpInfo
            // 
            grpInfo.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpInfo.Appearance.Options.UseFont = true;
            grpInfo.AppearanceCaption.FontStyleDelta = FontStyle.Bold;
            grpInfo.AppearanceCaption.Options.UseFont = true;
            grpInfo.Controls.Add(txtEmployee);
            grpInfo.Controls.Add(txtReceiptCode);
            grpInfo.Controls.Add(txtSupplier);
            grpInfo.Controls.Add(deReceiptDate);
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
            grpInfo.Size = new Size(606, 203);
            grpInfo.TabIndex = 0;
            grpInfo.Text = "Receipt Info";
            // 
            // txtEmployee
            // 
            txtEmployee.Location = new Point(427, 66);
            txtEmployee.Name = "txtEmployee";
            txtEmployee.Size = new Size(130, 22);
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
            // deReceiptDate
            // 
            deReceiptDate.EditValue = null;
            deReceiptDate.Location = new Point(427, 32);
            deReceiptDate.Name = "deReceiptDate";
            deReceiptDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            deReceiptDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            deReceiptDate.Size = new Size(130, 22);
            deReceiptDate.TabIndex = 2;
            // 
            // meNote
            // 
            meNote.Location = new Point(126, 111);
            meNote.Name = "meNote";
            meNote.Properties.ScrollBars = ScrollBars.Horizontal;
            meNote.Size = new Size(431, 70);
            meNote.TabIndex = 5;
            // 
            // labelControl3
            // 
            labelControl3.Location = new Point(37, 111);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(26, 16);
            labelControl3.TabIndex = 0;
            labelControl3.Text = "Note";
            // 
            // labelControl5
            // 
            labelControl5.Location = new Point(339, 69);
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
            grpSum.Controls.Add(btnCancel);
            grpSum.Controls.Add(btnAdd);
            grpSum.Controls.Add(label3);
            grpSum.Controls.Add(labelControl8);
            grpSum.Dock = DockStyle.Bottom;
            grpSum.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            grpSum.Location = new Point(2, 384);
            grpSum.Name = "grpSum";
            grpSum.Size = new Size(606, 97);
            grpSum.TabIndex = 2;
            grpSum.Text = "Summary";
            // 
            // btnCancel
            // 
            btnCancel.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btnAdd.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(528, 29);
            label3.Name = "label3";
            label3.Size = new Size(32, 16);
            label3.TabIndex = 1;
            label3.Text = "0.00";
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.Location = new Point(414, 29);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(32, 16);
            labelControl8.TabIndex = 0;
            labelControl8.Text = "Total";
            // 
            // frmNewGoodsReceipt
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 487);
            Controls.Add(panelControl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNewGoodsReceipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNewGoodsReceipt";
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grpDetails).EndInit();
            grpDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)grpInfo).EndInit();
            grpInfo.ResumeLayout(false);
            grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtEmployee.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtReceiptCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSupplier.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)deReceiptDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)deReceiptDate.Properties).EndInit();
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
        private DevExpress.XtraEditors.DateEdit deReceiptDate;
        private DevExpress.XtraEditors.MemoEdit meNote;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Commodity;
        private DevExpress.XtraGrid.Columns.GridColumn Batch;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn PurchasePrice;
        private DevExpress.XtraGrid.Columns.GridColumn Amount;
        private Label label3;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.TextEdit txtEmployee;
        private DevExpress.XtraEditors.TextEdit txtSupplier;
        private DevExpress.XtraEditors.TextEdit txtReceiptCode;
        private DevExpress.XtraEditors.SimpleButton btnAddBatch;
    }
}