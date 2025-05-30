namespace VitaPharm.Forms.Receipt
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewGoodsReceipt));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            grpDetails = new DevExpress.XtraEditors.GroupControl();
            gridControl = new DevExpress.XtraGrid.GridControl();
            gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colCommodityName = new DevExpress.XtraGrid.Columns.GridColumn();
            colBatchCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colMfgDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colExpDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            repoSpinQty = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            colPurchasePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            repoBtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
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
            lblTotal = new DevExpress.XtraEditors.LabelControl();
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
            ((System.ComponentModel.ISupportInitialize)repoSpinQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repoBtnDelete).BeginInit();
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
            panelControl1.Size = new Size(917, 468);
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
            groupControl1.Size = new Size(913, 464);
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
            grpDetails.Location = new Point(2, 140);
            grpDetails.Name = "grpDetails";
            grpDetails.Size = new Size(909, 247);
            grpDetails.TabIndex = 0;
            grpDetails.Text = "Goods Receipt Details";
            // 
            // gridControl
            // 
            gridControl.Dock = DockStyle.Fill;
            gridControl.Location = new Point(2, 67);
            gridControl.MainView = gridView;
            gridControl.Name = "gridControl";
            gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repoBtnDelete, repoSpinQty });
            gridControl.Size = new Size(905, 178);
            gridControl.TabIndex = 0;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // gridView
            // 
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colCommodityName, colBatchCode, colMfgDate, colExpDate, colQuantity, colPurchasePrice, Amount, colDelete });
            gridView.GridControl = gridControl;
            gridView.Name = "gridView";
            // 
            // colCommodityName
            // 
            colCommodityName.Caption = "Commodity Name";
            colCommodityName.FieldName = "CommodityName";
            colCommodityName.MinWidth = 25;
            colCommodityName.Name = "colCommodityName";
            colCommodityName.OptionsColumn.AllowEdit = false;
            colCommodityName.Visible = true;
            colCommodityName.VisibleIndex = 0;
            colCommodityName.Width = 177;
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
            colBatchCode.Width = 124;
            // 
            // colMfgDate
            // 
            colMfgDate.Caption = "MFG Date";
            colMfgDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            colMfgDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colMfgDate.FieldName = "MfgDate";
            colMfgDate.MinWidth = 25;
            colMfgDate.Name = "colMfgDate";
            colMfgDate.OptionsColumn.AllowEdit = false;
            colMfgDate.Visible = true;
            colMfgDate.VisibleIndex = 2;
            colMfgDate.Width = 100;
            // 
            // colExpDate
            // 
            colExpDate.Caption = "EXP Date";
            colExpDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            colExpDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colExpDate.FieldName = "ExpDate";
            colExpDate.MinWidth = 25;
            colExpDate.Name = "colExpDate";
            colExpDate.OptionsColumn.AllowEdit = false;
            colExpDate.Visible = true;
            colExpDate.VisibleIndex = 3;
            colExpDate.Width = 88;
            // 
            // colQuantity
            // 
            colQuantity.Caption = "Qty";
            colQuantity.ColumnEdit = repoSpinQty;
            colQuantity.FieldName = "Qty";
            colQuantity.MinWidth = 25;
            colQuantity.Name = "colQuantity";
            colQuantity.Visible = true;
            colQuantity.VisibleIndex = 4;
            colQuantity.Width = 31;
            // 
            // repoSpinQty
            // 
            repoSpinQty.AutoHeight = false;
            repoSpinQty.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repoSpinQty.MaskSettings.Set("mask", "N0");
            repoSpinQty.MaxValue = new decimal(new int[] { 100000, 0, 0, 0 });
            repoSpinQty.MinValue = new decimal(new int[] { 1, 0, 0, 0 });
            repoSpinQty.Name = "repoSpinQty";
            repoSpinQty.UseMaskAsDisplayFormat = true;
            // 
            // colPurchasePrice
            // 
            colPurchasePrice.Caption = "Price";
            colPurchasePrice.DisplayFormat.FormatString = "N0";
            colPurchasePrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colPurchasePrice.FieldName = "PurchasePrice";
            colPurchasePrice.MinWidth = 25;
            colPurchasePrice.Name = "colPurchasePrice";
            colPurchasePrice.OptionsColumn.AllowEdit = false;
            colPurchasePrice.Visible = true;
            colPurchasePrice.VisibleIndex = 5;
            colPurchasePrice.Width = 120;
            // 
            // Amount
            // 
            Amount.Caption = "Amount";
            Amount.DisplayFormat.FormatString = "N0";
            Amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            Amount.FieldName = "Amount";
            Amount.MinWidth = 25;
            Amount.Name = "Amount";
            Amount.OptionsColumn.AllowEdit = false;
            Amount.UnboundDataType = typeof(decimal);
            Amount.Visible = true;
            Amount.VisibleIndex = 6;
            Amount.Width = 106;
            // 
            // colDelete
            // 
            colDelete.ColumnEdit = repoBtnDelete;
            colDelete.FieldName = "DeleteAction";
            colDelete.MinWidth = 25;
            colDelete.Name = "colDelete";
            colDelete.OptionsColumn.ShowCaption = false;
            colDelete.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            colDelete.UnboundDataType = typeof(object);
            colDelete.Visible = true;
            colDelete.VisibleIndex = 7;
            colDelete.Width = 105;
            // 
            // repoBtnDelete
            // 
            repoBtnDelete.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            repoBtnDelete.Appearance.Options.UseBackColor = true;
            repoBtnDelete.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("editorButtonImageOptions1.SvgImage");
            editorButtonImageOptions1.SvgImageSize = new Size(16, 16);
            repoBtnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            repoBtnDelete.Name = "repoBtnDelete";
            repoBtnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(btnAddBatch);
            panelControl2.Dock = DockStyle.Top;
            panelControl2.Location = new Point(2, 28);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(905, 39);
            panelControl2.TabIndex = 1;
            // 
            // btnAddBatch
            // 
            btnAddBatch.Anchor = AnchorStyles.Right;
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
            btnAddBatch.TabIndex = 0;
            btnAddBatch.Text = "Add Batch";
            btnAddBatch.Click += btnAddBatch_Click;
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
            grpInfo.Size = new Size(909, 112);
            grpInfo.TabIndex = 0;
            grpInfo.Text = "Receipt Info";
            // 
            // txtEmployee
            // 
            txtEmployee.Anchor = AnchorStyles.Top;
            txtEmployee.Location = new Point(684, 30);
            txtEmployee.Name = "txtEmployee";
            txtEmployee.Size = new Size(185, 22);
            txtEmployee.TabIndex = 3;
            // 
            // txtReceiptCode
            // 
            txtReceiptCode.Anchor = AnchorStyles.Top;
            txtReceiptCode.Location = new Point(126, 30);
            txtReceiptCode.Name = "txtReceiptCode";
            txtReceiptCode.Size = new Size(168, 22);
            txtReceiptCode.TabIndex = 1;
            // 
            // txtSupplier
            // 
            txtSupplier.Anchor = AnchorStyles.Top;
            txtSupplier.Location = new Point(126, 66);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(285, 22);
            txtSupplier.TabIndex = 4;
            // 
            // dateReceiptDate
            // 
            dateReceiptDate.Anchor = AnchorStyles.Top;
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
            meNote.Anchor = AnchorStyles.Top;
            meNote.Location = new Point(596, 67);
            meNote.Name = "meNote";
            meNote.Properties.ScrollBars = ScrollBars.Horizontal;
            meNote.Size = new Size(273, 33);
            meNote.TabIndex = 5;
            // 
            // labelControl3
            // 
            labelControl3.Anchor = AnchorStyles.Top;
            labelControl3.Location = new Point(531, 72);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(26, 16);
            labelControl3.TabIndex = 0;
            labelControl3.Text = "Note";
            // 
            // labelControl5
            // 
            labelControl5.Anchor = AnchorStyles.Top;
            labelControl5.Location = new Point(596, 33);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(55, 16);
            labelControl5.TabIndex = 0;
            labelControl5.Text = "Employee";
            // 
            // labelControl2
            // 
            labelControl2.Anchor = AnchorStyles.Top;
            labelControl2.Location = new Point(37, 69);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(47, 16);
            labelControl2.TabIndex = 0;
            labelControl2.Text = "Supplier";
            // 
            // labelControl4
            // 
            labelControl4.Anchor = AnchorStyles.Top;
            labelControl4.Location = new Point(339, 33);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(72, 16);
            labelControl4.TabIndex = 0;
            labelControl4.Text = "Receipt Date";
            // 
            // labelControl1
            // 
            labelControl1.Anchor = AnchorStyles.Top;
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
            grpSum.Controls.Add(lblTotal);
            grpSum.Controls.Add(btnCancel);
            grpSum.Controls.Add(btnAdd);
            grpSum.Controls.Add(labelControl8);
            grpSum.Dock = DockStyle.Bottom;
            grpSum.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            grpSum.Location = new Point(2, 387);
            grpSum.Name = "grpSum";
            grpSum.Size = new Size(909, 75);
            grpSum.TabIndex = 2;
            grpSum.Text = "Summary";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Appearance.ForeColor = Color.Green;
            lblTotal.Appearance.Options.UseFont = true;
            lblTotal.Appearance.Options.UseForeColor = true;
            lblTotal.Appearance.Options.UseTextOptions = true;
            lblTotal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            lblTotal.Location = new Point(764, 28);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(62, 18);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "0.0 VND";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnCancel.Appearance.Options.UseFont = true;
            btnCancel.Location = new Point(460, 38);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom;
            btnAdd.Appearance.BackColor = Color.FromArgb(50, 112, 188);
            btnAdd.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnAdd.Appearance.ForeColor = Color.Black;
            btnAdd.Appearance.Options.UseBackColor = true;
            btnAdd.Appearance.Options.UseFont = true;
            btnAdd.Appearance.Options.UseForeColor = true;
            btnAdd.Location = new Point(357, 38);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(97, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.Click += btnSave_Click;
            // 
            // labelControl8
            // 
            labelControl8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelControl8.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.Location = new Point(646, 28);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(38, 18);
            labelControl8.TabIndex = 0;
            labelControl8.Text = "Total";
            // 
            // frmNewGoodsReceipt
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 468);
            Controls.Add(panelControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmNewGoodsReceipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Goods Receipt";
            Load += frmNewGoodsReceipt_Load;
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grpDetails).EndInit();
            grpDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)repoSpinQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)repoBtnDelete).EndInit();
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
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colMfgDate;
        private DevExpress.XtraGrid.Columns.GridColumn colExpDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoBtnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repoSpinQty;
    }
}