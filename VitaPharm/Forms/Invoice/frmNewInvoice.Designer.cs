namespace VitaPharm.Forms.Invoice
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
            deCreatedDate = new DevExpress.XtraEditors.DateEdit();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            gridControl = new DevExpress.XtraGrid.GridControl();
            gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colCommodityName = new DevExpress.XtraGrid.Columns.GridColumn();
            colBatchCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            colBaseUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            groupControl3 = new DevExpress.XtraEditors.GroupControl();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            spinQuantity = new DevExpress.XtraEditors.SpinEdit();
            labelControl13 = new DevExpress.XtraEditors.LabelControl();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            labelControl11 = new DevExpress.XtraEditors.LabelControl();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            labelControl12 = new DevExpress.XtraEditors.LabelControl();
            labelControl10 = new DevExpress.XtraEditors.LabelControl();
            txtPurchasePrice = new DevExpress.XtraEditors.TextEdit();
            cboBatchCode = new DevExpress.XtraEditors.ComboBoxEdit();
            labelControl9 = new DevExpress.XtraEditors.LabelControl();
            cboCommodity = new DevExpress.XtraEditors.ComboBoxEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)seTaxRate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)meNote.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmployee.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtContact.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboCustomer.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deCreatedDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deCreatedDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl3).BeginInit();
            groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spinQuantity.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPurchasePrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboBatchCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboCommodity.Properties).BeginInit();
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
            seTaxRate.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            seTaxRate.Location = new Point(414, 99);
            seTaxRate.Name = "seTaxRate";
            seTaxRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            seTaxRate.Size = new Size(55, 24);
            seTaxRate.TabIndex = 25;
            // 
            // meNote
            // 
            meNote.Location = new Point(607, 102);
            meNote.Name = "meNote";
            meNote.Properties.ScrollBars = ScrollBars.Horizontal;
            meNote.Size = new Size(201, 44);
            meNote.TabIndex = 24;
            // 
            // txtEmployee
            // 
            txtEmployee.Location = new Point(123, 71);
            txtEmployee.Name = "txtEmployee";
            txtEmployee.Size = new Size(209, 22);
            txtEmployee.TabIndex = 20;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(123, 100);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(127, 22);
            txtContact.TabIndex = 23;
            // 
            // cboCustomer
            // 
            cboCustomer.Location = new Point(607, 71);
            cboCustomer.Name = "cboCustomer";
            cboCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboCustomer.Size = new Size(201, 22);
            cboCustomer.TabIndex = 21;
            // 
            // deCreatedDate
            // 
            deCreatedDate.EditValue = null;
            deCreatedDate.Location = new Point(607, 43);
            deCreatedDate.Name = "deCreatedDate";
            deCreatedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            deCreatedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            deCreatedDate.Size = new Size(201, 22);
            deCreatedDate.TabIndex = 22;
            // 
            // textEdit2
            // 
            textEdit2.Location = new Point(123, 43);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new Size(209, 22);
            textEdit2.TabIndex = 19;
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
            labelControl4.Location = new Point(348, 103);
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
            groupControl1.AppearanceCaption.BorderColor = Color.FromArgb(222, 228, 255);
            groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            groupControl1.Controls.Add(textEdit2);
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
            groupControl1.Controls.Add(deCreatedDate);
            groupControl1.Controls.Add(labelControl8);
            groupControl1.Controls.Add(labelControl7);
            groupControl1.Location = new Point(26, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(839, 159);
            groupControl1.TabIndex = 26;
            groupControl1.Text = "Invoice Information";
            // 
            // groupControl2
            // 
            groupControl2.AppearanceCaption.BorderColor = Color.FromArgb(250, 230, 230);
            groupControl2.AppearanceCaption.Options.UseBorderColor = true;
            groupControl2.Controls.Add(gridControl);
            groupControl2.Location = new Point(26, 165);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(525, 224);
            groupControl2.TabIndex = 27;
            groupControl2.Text = "Cart";
            // 
            // gridControl
            // 
            gridControl.Dock = DockStyle.Fill;
            gridControl.Location = new Point(2, 28);
            gridControl.MainView = gridView;
            gridControl.Name = "gridControl";
            gridControl.Size = new Size(521, 194);
            gridControl.TabIndex = 0;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // gridView
            // 
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colCommodityName, colBatchCode, colQty, colBaseUnit, colUnitPrice, colAmount });
            gridView.GridControl = gridControl;
            gridView.Name = "gridView";
            // 
            // colCommodityName
            // 
            colCommodityName.Caption = "Product Name";
            colCommodityName.FieldName = "CommodityName";
            colCommodityName.MinWidth = 25;
            colCommodityName.Name = "colCommodityName";
            colCommodityName.Visible = true;
            colCommodityName.VisibleIndex = 0;
            colCommodityName.Width = 282;
            // 
            // colBatchCode
            // 
            colBatchCode.Caption = "Batch Code";
            colBatchCode.FieldName = "BatchCode";
            colBatchCode.MinWidth = 25;
            colBatchCode.Name = "colBatchCode";
            colBatchCode.Visible = true;
            colBatchCode.VisibleIndex = 1;
            colBatchCode.Width = 118;
            // 
            // colQty
            // 
            colQty.Caption = "Qty";
            colQty.FieldName = "Quantity";
            colQty.MinWidth = 25;
            colQty.Name = "colQty";
            colQty.Visible = true;
            colQty.VisibleIndex = 2;
            colQty.Width = 57;
            // 
            // colBaseUnit
            // 
            colBaseUnit.Caption = "Base Unit";
            colBaseUnit.FieldName = "BaseUnit";
            colBaseUnit.MinWidth = 25;
            colBaseUnit.Name = "colBaseUnit";
            colBaseUnit.Visible = true;
            colBaseUnit.VisibleIndex = 3;
            colBaseUnit.Width = 89;
            // 
            // colUnitPrice
            // 
            colUnitPrice.Caption = "Unit Price";
            colUnitPrice.FieldName = "UnitPrice";
            colUnitPrice.MinWidth = 25;
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.Visible = true;
            colUnitPrice.VisibleIndex = 4;
            colUnitPrice.Width = 158;
            // 
            // colAmount
            // 
            colAmount.Caption = "Amount";
            colAmount.FieldName = "Amount";
            colAmount.MinWidth = 25;
            colAmount.Name = "colAmount";
            colAmount.Visible = true;
            colAmount.VisibleIndex = 5;
            colAmount.Width = 147;
            // 
            // groupControl3
            // 
            groupControl3.AppearanceCaption.BorderColor = Color.FromArgb(226, 251, 219);
            groupControl3.AppearanceCaption.Options.UseBorderColor = true;
            groupControl3.Controls.Add(simpleButton2);
            groupControl3.Controls.Add(simpleButton1);
            groupControl3.Controls.Add(spinQuantity);
            groupControl3.Controls.Add(labelControl13);
            groupControl3.Controls.Add(textEdit3);
            groupControl3.Controls.Add(labelControl11);
            groupControl3.Controls.Add(textEdit1);
            groupControl3.Controls.Add(labelControl12);
            groupControl3.Controls.Add(labelControl10);
            groupControl3.Controls.Add(txtPurchasePrice);
            groupControl3.Controls.Add(cboBatchCode);
            groupControl3.Controls.Add(labelControl9);
            groupControl3.Controls.Add(cboCommodity);
            groupControl3.Controls.Add(labelControl3);
            groupControl3.Location = new Point(557, 165);
            groupControl3.Name = "groupControl3";
            groupControl3.Size = new Size(308, 266);
            groupControl3.TabIndex = 28;
            groupControl3.Text = "Commodities";
            // 
            // simpleButton2
            // 
            simpleButton2.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            simpleButton2.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            simpleButton2.Appearance.Options.UseBackColor = true;
            simpleButton2.Appearance.Options.UseFont = true;
            simpleButton2.Location = new Point(173, 208);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(118, 36);
            simpleButton2.TabIndex = 22;
            simpleButton2.Text = "Remove";
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            simpleButton1.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            simpleButton1.Appearance.Options.UseBackColor = true;
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.Location = new Point(16, 208);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(118, 36);
            simpleButton1.TabIndex = 21;
            simpleButton1.Text = "Add to cart";
            // 
            // spinQuantity
            // 
            spinQuantity.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spinQuantity.Location = new Point(235, 158);
            spinQuantity.Name = "spinQuantity";
            spinQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spinQuantity.Size = new Size(56, 24);
            spinQuantity.TabIndex = 20;
            // 
            // labelControl13
            // 
            labelControl13.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl13.Appearance.ForeColor = Color.Crimson;
            labelControl13.Appearance.Options.UseFont = true;
            labelControl13.Appearance.Options.UseForeColor = true;
            labelControl13.Location = new Point(235, 131);
            labelControl13.Name = "labelControl13";
            labelControl13.Size = new Size(56, 16);
            labelControl13.TabIndex = 19;
            labelControl13.Text = "Quantity";
            // 
            // textEdit3
            // 
            textEdit3.Location = new Point(98, 160);
            textEdit3.Name = "textEdit3";
            textEdit3.Size = new Size(96, 22);
            textEdit3.TabIndex = 18;
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
            labelControl11.Location = new Point(14, 159);
            labelControl11.Name = "labelControl11";
            labelControl11.Size = new Size(58, 24);
            labelControl11.TabIndex = 17;
            labelControl11.Text = "Price";
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(98, 128);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(96, 22);
            textEdit1.TabIndex = 16;
            // 
            // labelControl12
            // 
            labelControl12.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl12.Appearance.ForeColor = Color.Black;
            labelControl12.Appearance.Options.UseFont = true;
            labelControl12.Appearance.Options.UseForeColor = true;
            labelControl12.Location = new Point(16, 131);
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
            labelControl10.Location = new Point(171, 95);
            labelControl10.Name = "labelControl10";
            labelControl10.Size = new Size(59, 16);
            labelControl10.TabIndex = 13;
            labelControl10.Text = "Available";
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Location = new Point(241, 92);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.Size = new Size(50, 22);
            txtPurchasePrice.TabIndex = 12;
            // 
            // cboBatchCode
            // 
            cboBatchCode.Location = new Point(63, 92);
            cboBatchCode.Name = "cboBatchCode";
            cboBatchCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboBatchCode.Size = new Size(89, 22);
            cboBatchCode.TabIndex = 11;
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
            // cboCommodity
            // 
            cboCommodity.Location = new Point(14, 53);
            cboCommodity.Name = "cboCommodity";
            cboCommodity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboCommodity.Size = new Size(277, 22);
            cboCommodity.TabIndex = 4;
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
            // simpleButton3
            // 
            simpleButton3.Appearance.BorderColor = Color.Green;
            simpleButton3.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            simpleButton3.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            simpleButton3.Appearance.Options.UseBorderColor = true;
            simpleButton3.Appearance.Options.UseFont = true;
            simpleButton3.Appearance.Options.UseForeColor = true;
            simpleButton3.Location = new Point(466, 395);
            simpleButton3.Name = "simpleButton3";
            simpleButton3.Size = new Size(85, 36);
            simpleButton3.TabIndex = 29;
            simpleButton3.Text = "Add";
            // 
            // frmNewInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 453);
            Controls.Add(simpleButton3);
            Controls.Add(groupControl3);
            Controls.Add(groupControl2);
            Controls.Add(groupControl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNewInvoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Invoice";
            ((System.ComponentModel.ISupportInitialize)seTaxRate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)meNote.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmployee.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtContact.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboCustomer.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)deCreatedDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)deCreatedDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)spinQuantity.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPurchasePrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboBatchCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboCommodity.Properties).EndInit();
            ResumeLayout(false);
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
        private DevExpress.XtraEditors.DateEdit deCreatedDate;
        private DevExpress.XtraEditors.TextEdit textEdit2;
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
        private DevExpress.XtraEditors.ComboBoxEdit cboCommodity;
        private DevExpress.XtraEditors.ComboBoxEdit cboBatchCode;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtPurchasePrice;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SpinEdit spinQuantity;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colCommodityName;
        private DevExpress.XtraGrid.Columns.GridColumn colBatchCode;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseUnit;
    }
}