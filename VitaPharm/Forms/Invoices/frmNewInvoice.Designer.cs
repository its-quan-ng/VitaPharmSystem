namespace VitaPharm.Forms.Invoices
{
    partial class frmNewInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewInvoice));
            Commodity = new DevExpress.XtraGrid.Columns.GridColumn();
            Batch = new DevExpress.XtraGrid.Columns.GridColumn();
            UnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            seTaxRate = new DevExpress.XtraEditors.SpinEdit();
            meNote = new DevExpress.XtraEditors.MemoEdit();
            txtEmployee = new DevExpress.XtraEditors.TextEdit();
            txtContact = new DevExpress.XtraEditors.TextEdit();
            cboCustomer = new DevExpress.XtraEditors.LookUpEdit();
            dateCreatedDate = new DevExpress.XtraEditors.DateEdit();
            txtInvoiceCode = new DevExpress.XtraEditors.TextEdit();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            labelControl14 = new DevExpress.XtraEditors.LabelControl();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            gridControl = new DevExpress.XtraGrid.GridControl();
            gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colID = new DevExpress.XtraGrid.Columns.GridColumn();
            colCommodityName = new DevExpress.XtraGrid.Columns.GridColumn();
            colBatchCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            colBaseUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            groupControl3 = new DevExpress.XtraEditors.GroupControl();
            cboBatchCode = new DevExpress.XtraEditors.LookUpEdit();
            cboCommodity = new DevExpress.XtraEditors.LookUpEdit();
            txtQuantity = new DevExpress.XtraEditors.TextEdit();
            btnRemove = new DevExpress.XtraEditors.SimpleButton();
            btnAddToCart = new DevExpress.XtraEditors.SimpleButton();
            labelControl13 = new DevExpress.XtraEditors.LabelControl();
            txtPrice = new DevExpress.XtraEditors.TextEdit();
            labelControl11 = new DevExpress.XtraEditors.LabelControl();
            txtBaseUnit = new DevExpress.XtraEditors.TextEdit();
            labelControl12 = new DevExpress.XtraEditors.LabelControl();
            labelControl10 = new DevExpress.XtraEditors.LabelControl();
            txtQtyAvailable = new DevExpress.XtraEditors.TextEdit();
            labelControl9 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
            labelControl15 = new DevExpress.XtraEditors.LabelControl();
            labelControl16 = new DevExpress.XtraEditors.LabelControl();
            lblTotal = new DevExpress.XtraEditors.LabelControl();
            lblTax = new DevExpress.XtraEditors.LabelControl();
            btnClear = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)seTaxRate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)meNote.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmployee.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtContact.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboCustomer.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateCreatedDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateCreatedDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtInvoiceCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl3).BeginInit();
            groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cboBatchCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboCommodity.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantity.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBaseUnit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtQtyAvailable.Properties).BeginInit();
            SuspendLayout();
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
            // UnitPrice
            // 
            UnitPrice.Caption = "Unit Price";
            UnitPrice.FieldName = "UnitPrice";
            UnitPrice.MinWidth = 25;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.OptionsFilter.AllowFilter = false;
            UnitPrice.Visible = true;
            UnitPrice.VisibleIndex = 2;
            UnitPrice.Width = 94;
            // 
            // Quantity
            // 
            Quantity.Caption = "Quantity";
            Quantity.FieldName = "Quantity";
            Quantity.MinWidth = 25;
            Quantity.Name = "Quantity";
            Quantity.Visible = true;
            Quantity.VisibleIndex = 3;
            Quantity.Width = 94;
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
            // seTaxRate
            // 
            seTaxRate.EditValue = new decimal(new int[] { 5, 0, 0, 0 });
            seTaxRate.Location = new Point(123, 128);
            seTaxRate.Name = "seTaxRate";
            seTaxRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            seTaxRate.Properties.MaxValue = new decimal(new int[] { 100, 0, 0, 0 });
            seTaxRate.Size = new Size(55, 24);
            seTaxRate.TabIndex = 25;
            seTaxRate.EditValueChanged += seTaxRate_EditValueChanged;
            // 
            // meNote
            // 
            meNote.Location = new Point(607, 102);
            meNote.Name = "meNote";
            meNote.Properties.ScrollBars = ScrollBars.Horizontal;
            meNote.Size = new Size(242, 44);
            meNote.TabIndex = 24;
            // 
            // txtEmployee
            // 
            txtEmployee.Location = new Point(123, 71);
            txtEmployee.Name = "txtEmployee";
            txtEmployee.Size = new Size(257, 22);
            txtEmployee.TabIndex = 20;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(123, 100);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(148, 22);
            txtContact.TabIndex = 23;
            // 
            // cboCustomer
            // 
            cboCustomer.Location = new Point(607, 71);
            cboCustomer.Name = "cboCustomer";
            cboCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboCustomer.Size = new Size(242, 22);
            cboCustomer.TabIndex = 21;
            cboCustomer.EditValueChanged += cboCustomer_EditValueChanged;
            // 
            // dateCreatedDate
            // 
            dateCreatedDate.EditValue = null;
            dateCreatedDate.Location = new Point(607, 43);
            dateCreatedDate.Name = "dateCreatedDate";
            dateCreatedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateCreatedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateCreatedDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            dateCreatedDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateCreatedDate.Size = new Size(181, 22);
            dateCreatedDate.TabIndex = 22;
            // 
            // txtInvoiceCode
            // 
            txtInvoiceCode.Location = new Point(123, 43);
            txtInvoiceCode.Name = "txtInvoiceCode";
            txtInvoiceCode.Size = new Size(257, 22);
            txtInvoiceCode.TabIndex = 19;
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new Font("Tahoma", 8F);
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Location = new Point(514, 46);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(68, 16);
            labelControl7.TabIndex = 17;
            labelControl7.Text = "Create Date";
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Font = new Font("Tahoma", 8F);
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.Location = new Point(28, 74);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(57, 16);
            labelControl8.TabIndex = 18;
            labelControl8.Text = "Making By";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 8F);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(28, 132);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(51, 16);
            labelControl4.TabIndex = 12;
            labelControl4.Text = "Tax Rate";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Tahoma", 8F);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(514, 103);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(26, 16);
            labelControl5.TabIndex = 13;
            labelControl5.Text = "Note";
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Tahoma", 8F);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new Point(28, 103);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(43, 16);
            labelControl6.TabIndex = 14;
            labelControl6.Text = "Contact";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 8F);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(514, 74);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(55, 16);
            labelControl2.TabIndex = 15;
            labelControl2.Text = "Customer";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 8F);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(28, 46);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(73, 16);
            labelControl1.TabIndex = 16;
            labelControl1.Text = "Invoice Code";
            // 
            // groupControl1
            // 
            groupControl1.Anchor = AnchorStyles.Top;
            groupControl1.AppearanceCaption.BorderColor = Color.FromArgb(222, 228, 255);
            groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            groupControl1.Controls.Add(labelControl14);
            groupControl1.Controls.Add(txtInvoiceCode);
            groupControl1.Controls.Add(seTaxRate);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Controls.Add(meNote);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(txtEmployee);
            groupControl1.Controls.Add(labelControl6);
            groupControl1.Controls.Add(txtContact);
            groupControl1.Controls.Add(labelControl5);
            groupControl1.Controls.Add(cboCustomer);
            groupControl1.Controls.Add(labelControl4);
            groupControl1.Controls.Add(dateCreatedDate);
            groupControl1.Controls.Add(labelControl8);
            groupControl1.Controls.Add(labelControl7);
            groupControl1.Location = new Point(28, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(898, 159);
            groupControl1.TabIndex = 26;
            groupControl1.Text = "Invoice Information";
            // 
            // labelControl14
            // 
            labelControl14.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl14.Appearance.Options.UseFont = true;
            labelControl14.Location = new Point(184, 132);
            labelControl14.Name = "labelControl14";
            labelControl14.Size = new Size(14, 16);
            labelControl14.TabIndex = 26;
            labelControl14.Text = "%";
            // 
            // groupControl2
            // 
            groupControl2.Anchor = AnchorStyles.Top;
            groupControl2.AppearanceCaption.BorderColor = Color.FromArgb(250, 230, 230);
            groupControl2.AppearanceCaption.Options.UseBorderColor = true;
            groupControl2.Controls.Add(gridControl);
            groupControl2.Location = new Point(28, 165);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(552, 182);
            groupControl2.TabIndex = 27;
            groupControl2.Text = "Cart";
            // 
            // gridControl
            // 
            gridControl.Dock = DockStyle.Fill;
            gridControl.Location = new Point(2, 28);
            gridControl.MainView = gridView;
            gridControl.Name = "gridControl";
            gridControl.Size = new Size(548, 152);
            gridControl.TabIndex = 0;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // gridView
            // 
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colID, colCommodityName, colBatchCode, colQty, colBaseUnit, colUnitPrice, colAmount });
            gridView.GridControl = gridControl;
            gridView.Name = "gridView";
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.FocusedRowChanged += gridView_FocusedRowChanged_1;
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
            colID.Width = 38;
            // 
            // colCommodityName
            // 
            colCommodityName.Caption = "Commodity Name";
            colCommodityName.FieldName = "CommodityName";
            colCommodityName.MinWidth = 25;
            colCommodityName.Name = "colCommodityName";
            colCommodityName.OptionsColumn.AllowEdit = false;
            colCommodityName.Visible = true;
            colCommodityName.VisibleIndex = 1;
            colCommodityName.Width = 211;
            // 
            // colBatchCode
            // 
            colBatchCode.Caption = "Batch Code";
            colBatchCode.FieldName = "BatchCode";
            colBatchCode.MinWidth = 25;
            colBatchCode.Name = "colBatchCode";
            colBatchCode.OptionsColumn.AllowEdit = false;
            colBatchCode.Visible = true;
            colBatchCode.VisibleIndex = 2;
            colBatchCode.Width = 166;
            // 
            // colQty
            // 
            colQty.Caption = "Qty";
            colQty.FieldName = "Qty";
            colQty.MinWidth = 25;
            colQty.Name = "colQty";
            colQty.OptionsColumn.AllowEdit = false;
            colQty.Visible = true;
            colQty.VisibleIndex = 3;
            colQty.Width = 57;
            // 
            // colBaseUnit
            // 
            colBaseUnit.Caption = "Base Unit";
            colBaseUnit.FieldName = "BaseUnit";
            colBaseUnit.MinWidth = 25;
            colBaseUnit.Name = "colBaseUnit";
            colBaseUnit.OptionsColumn.AllowEdit = false;
            colBaseUnit.Visible = true;
            colBaseUnit.VisibleIndex = 4;
            colBaseUnit.Width = 110;
            // 
            // colUnitPrice
            // 
            colUnitPrice.Caption = "Unit Price";
            colUnitPrice.DisplayFormat.FormatString = "N0";
            colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colUnitPrice.FieldName = "SellingPrice";
            colUnitPrice.GroupFormat.FormatString = "N0";
            colUnitPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colUnitPrice.MinWidth = 25;
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.OptionsColumn.AllowEdit = false;
            colUnitPrice.Visible = true;
            colUnitPrice.VisibleIndex = 5;
            colUnitPrice.Width = 120;
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
            colAmount.Visible = true;
            colAmount.VisibleIndex = 6;
            colAmount.Width = 135;
            // 
            // groupControl3
            // 
            groupControl3.Anchor = AnchorStyles.Top;
            groupControl3.AppearanceCaption.BorderColor = Color.FromArgb(226, 251, 219);
            groupControl3.AppearanceCaption.Options.UseBorderColor = true;
            groupControl3.Controls.Add(cboBatchCode);
            groupControl3.Controls.Add(cboCommodity);
            groupControl3.Controls.Add(txtQuantity);
            groupControl3.Controls.Add(btnRemove);
            groupControl3.Controls.Add(btnAddToCart);
            groupControl3.Controls.Add(labelControl13);
            groupControl3.Controls.Add(txtPrice);
            groupControl3.Controls.Add(labelControl11);
            groupControl3.Controls.Add(txtBaseUnit);
            groupControl3.Controls.Add(labelControl12);
            groupControl3.Controls.Add(labelControl10);
            groupControl3.Controls.Add(txtQtyAvailable);
            groupControl3.Controls.Add(labelControl9);
            groupControl3.Controls.Add(labelControl3);
            groupControl3.Location = new Point(586, 165);
            groupControl3.Name = "groupControl3";
            groupControl3.Size = new Size(340, 248);
            groupControl3.TabIndex = 28;
            groupControl3.Text = "Commodities";
            // 
            // cboBatchCode
            // 
            cboBatchCode.Anchor = AnchorStyles.Top;
            cboBatchCode.Location = new Point(52, 92);
            cboBatchCode.Name = "cboBatchCode";
            cboBatchCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboBatchCode.Size = new Size(190, 22);
            cboBatchCode.TabIndex = 25;
            cboBatchCode.EditValueChanged += cboBatchCode_EditValueChanged;
            // 
            // cboCommodity
            // 
            cboCommodity.Anchor = AnchorStyles.Top;
            cboCommodity.Location = new Point(16, 53);
            cboCommodity.Name = "cboCommodity";
            cboCommodity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboCommodity.Size = new Size(303, 22);
            cboCommodity.TabIndex = 24;
            cboCommodity.EditValueChanged += cboCommodity_EditValueChanged;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(269, 171);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(50, 22);
            txtQuantity.TabIndex = 23;
            // 
            // btnRemove
            // 
            btnRemove.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            btnRemove.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.Appearance.Options.UseBackColor = true;
            btnRemove.Appearance.Options.UseFont = true;
            btnRemove.Location = new Point(207, 209);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(71, 28);
            btnRemove.TabIndex = 22;
            btnRemove.Text = "Remove";
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            btnAddToCart.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddToCart.Appearance.Options.UseBackColor = true;
            btnAddToCart.Appearance.Options.UseFont = true;
            btnAddToCart.Location = new Point(81, 209);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(92, 28);
            btnAddToCart.TabIndex = 21;
            btnAddToCart.Text = "Add to cart";
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // labelControl13
            // 
            labelControl13.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl13.Appearance.ForeColor = Color.Crimson;
            labelControl13.Appearance.Options.UseFont = true;
            labelControl13.Appearance.Options.UseForeColor = true;
            labelControl13.Location = new Point(266, 149);
            labelControl13.Name = "labelControl13";
            labelControl13.Size = new Size(56, 16);
            labelControl13.TabIndex = 19;
            labelControl13.Text = "Quantity";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(98, 160);
            txtPrice.Name = "txtPrice";
            txtPrice.Properties.Appearance.Options.UseTextOptions = true;
            txtPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            txtPrice.Properties.DisplayFormat.FormatString = "N0";
            txtPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            txtPrice.Size = new Size(114, 22);
            txtPrice.TabIndex = 18;
            // 
            // labelControl11
            // 
            labelControl11.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl11.Appearance.ForeColor = Color.Black;
            labelControl11.Appearance.Options.UseFont = true;
            labelControl11.Appearance.Options.UseForeColor = true;
            labelControl11.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            labelControl11.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("labelControl11.ImageOptions.SvgImage");
            labelControl11.ImageOptions.SvgImageSize = new Size(16, 16);
            labelControl11.Location = new Point(14, 158);
            labelControl11.Name = "labelControl11";
            labelControl11.Size = new Size(58, 24);
            labelControl11.TabIndex = 17;
            labelControl11.Text = "Price";
            // 
            // txtBaseUnit
            // 
            txtBaseUnit.Location = new Point(98, 129);
            txtBaseUnit.Name = "txtBaseUnit";
            txtBaseUnit.Properties.Appearance.Options.UseTextOptions = true;
            txtBaseUnit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            txtBaseUnit.Properties.DisplayFormat.FormatString = "N0";
            txtBaseUnit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            txtBaseUnit.Size = new Size(114, 22);
            txtBaseUnit.TabIndex = 16;
            // 
            // labelControl12
            // 
            labelControl12.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl12.Appearance.ForeColor = Color.Black;
            labelControl12.Appearance.Options.UseFont = true;
            labelControl12.Appearance.Options.UseForeColor = true;
            labelControl12.Location = new Point(16, 132);
            labelControl12.Name = "labelControl12";
            labelControl12.Size = new Size(60, 16);
            labelControl12.TabIndex = 15;
            labelControl12.Text = "Base Unit";
            // 
            // labelControl10
            // 
            labelControl10.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl10.Appearance.ForeColor = Color.Blue;
            labelControl10.Appearance.Options.UseFont = true;
            labelControl10.Appearance.Options.UseForeColor = true;
            labelControl10.Location = new Point(260, 95);
            labelControl10.Name = "labelControl10";
            labelControl10.Size = new Size(59, 16);
            labelControl10.TabIndex = 13;
            labelControl10.Text = "Available";
            // 
            // txtQtyAvailable
            // 
            txtQtyAvailable.Location = new Point(266, 117);
            txtQtyAvailable.Name = "txtQtyAvailable";
            txtQtyAvailable.Properties.Appearance.Options.UseTextOptions = true;
            txtQtyAvailable.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            txtQtyAvailable.Size = new Size(50, 22);
            txtQtyAvailable.TabIndex = 12;
            // 
            // labelControl9
            // 
            labelControl9.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl9.Appearance.Options.UseFont = true;
            labelControl9.Location = new Point(15, 95);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new Size(31, 16);
            labelControl9.TabIndex = 10;
            labelControl9.Text = "Batch";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(14, 31);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(64, 16);
            labelControl3.TabIndex = 0;
            labelControl3.Text = "Commodity";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top;
            btnAdd.Appearance.BorderColor = Color.Green;
            btnAdd.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            btnAdd.Appearance.Options.UseBorderColor = true;
            btnAdd.Appearance.Options.UseFont = true;
            btnAdd.Appearance.Options.UseForeColor = true;
            btnAdd.Location = new Point(390, 370);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(85, 36);
            btnAdd.TabIndex = 29;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // labelControl15
            // 
            labelControl15.Anchor = AnchorStyles.Top;
            labelControl15.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl15.Appearance.ForeColor = Color.Blue;
            labelControl15.Appearance.Options.UseFont = true;
            labelControl15.Appearance.Options.UseForeColor = true;
            labelControl15.Location = new Point(31, 361);
            labelControl15.Name = "labelControl15";
            labelControl15.Size = new Size(98, 16);
            labelControl15.TabIndex = 30;
            labelControl15.Text = "Total (tax incl.)";
            // 
            // labelControl16
            // 
            labelControl16.Anchor = AnchorStyles.Top;
            labelControl16.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl16.Appearance.Options.UseFont = true;
            labelControl16.Location = new Point(31, 386);
            labelControl16.Name = "labelControl16";
            labelControl16.Size = new Size(22, 16);
            labelControl16.TabIndex = 31;
            labelControl16.Text = "Tax";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top;
            lblTotal.Appearance.FontStyleDelta = FontStyle.Bold;
            lblTotal.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            lblTotal.Appearance.Options.UseFont = true;
            lblTotal.Appearance.Options.UseForeColor = true;
            lblTotal.Location = new Point(190, 361);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 16);
            lblTotal.TabIndex = 32;
            lblTotal.Text = "0.0 VND";
            // 
            // lblTax
            // 
            lblTax.Anchor = AnchorStyles.Top;
            lblTax.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTax.Appearance.FontStyleDelta = FontStyle.Bold;
            lblTax.Appearance.Options.UseFont = true;
            lblTax.Location = new Point(190, 386);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(50, 16);
            lblTax.TabIndex = 33;
            lblTax.Text = "0.0 VND";
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top;
            btnClear.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            btnClear.Appearance.BorderColor = Color.Red;
            btnClear.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical;
            btnClear.Appearance.Options.UseBackColor = true;
            btnClear.Appearance.Options.UseBorderColor = true;
            btnClear.Appearance.Options.UseFont = true;
            btnClear.Appearance.Options.UseForeColor = true;
            btnClear.Location = new Point(481, 370);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(87, 36);
            btnClear.TabIndex = 34;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // frmNewInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 425);
            Controls.Add(btnClear);
            Controls.Add(lblTax);
            Controls.Add(lblTotal);
            Controls.Add(labelControl16);
            Controls.Add(labelControl15);
            Controls.Add(btnAdd);
            Controls.Add(groupControl3);
            Controls.Add(groupControl2);
            Controls.Add(groupControl1);
            Name = "frmNewInvoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Invoice";
            Load += frmNewInvoice_Load;
            ((System.ComponentModel.ISupportInitialize)seTaxRate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)meNote.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmployee.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtContact.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboCustomer.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateCreatedDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateCreatedDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtInvoiceCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl3).EndInit();
            groupControl3.ResumeLayout(false);
            groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cboBatchCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboCommodity.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantity.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBaseUnit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtQtyAvailable.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraGrid.Columns.GridColumn Commodity;
        private DevExpress.XtraGrid.Columns.GridColumn Batch;
        private DevExpress.XtraGrid.Columns.GridColumn UnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn Amount;
        private DevExpress.XtraEditors.SpinEdit seTaxRate;
        private DevExpress.XtraEditors.MemoEdit meNote;
        private DevExpress.XtraEditors.TextEdit txtEmployee;
        private DevExpress.XtraEditors.TextEdit txtContact;
        private DevExpress.XtraEditors.LookUpEdit cboCustomer;
        private DevExpress.XtraEditors.DateEdit dateCreatedDate;
        private DevExpress.XtraEditors.TextEdit txtInvoiceCode;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtQtyAvailable;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtBaseUnit;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.SimpleButton btnAddToCart;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colCommodityName;
        private DevExpress.XtraGrid.Columns.GridColumn colBatchCode;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseUnit;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraEditors.LabelControl lblTax;
        private DevExpress.XtraEditors.TextEdit txtQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraEditors.LookUpEdit cboCommodity;
        private DevExpress.XtraEditors.LookUpEdit cboBatchCode;
        private DevExpress.XtraEditors.SimpleButton btnClear;
    }
}