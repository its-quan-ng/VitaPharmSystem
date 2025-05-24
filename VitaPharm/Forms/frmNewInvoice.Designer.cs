namespace VitaPharm.Forms
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
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            btnSave = new DevExpress.XtraEditors.PanelControl();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            labelControl11 = new DevExpress.XtraEditors.LabelControl();
            labelControl14 = new DevExpress.XtraEditors.LabelControl();
            labelControl13 = new DevExpress.XtraEditors.LabelControl();
            labelControl10 = new DevExpress.XtraEditors.LabelControl();
            labelControl12 = new DevExpress.XtraEditors.LabelControl();
            labelControl9 = new DevExpress.XtraEditors.LabelControl();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            gridControl = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            Commodity = new DevExpress.XtraGrid.Columns.GridColumn();
            Batch = new DevExpress.XtraGrid.Columns.GridColumn();
            UnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            seTaxRate = new DevExpress.XtraEditors.SpinEdit();
            meNote = new DevExpress.XtraEditors.MemoEdit();
            txtEmployee = new DevExpress.XtraEditors.TextEdit();
            txtContact = new DevExpress.XtraEditors.TextEdit();
            txtAddress = new DevExpress.XtraEditors.TextEdit();
            cboCustomer = new DevExpress.XtraEditors.LookUpEdit();
            deCreatedDate = new DevExpress.XtraEditors.DateEdit();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSave).BeginInit();
            btnSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)seTaxRate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)meNote.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmployee.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtContact.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAddress.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboCustomer.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deCreatedDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deCreatedDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(btnSave);
            layoutControl1.Controls.Add(groupControl2);
            layoutControl1.Controls.Add(groupControl1);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(1007, 313, 812, 500);
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(601, 570);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // btnSave
            // 
            btnSave.Controls.Add(btnCancel);
            btnSave.Controls.Add(simpleButton1);
            btnSave.Controls.Add(labelControl11);
            btnSave.Controls.Add(labelControl14);
            btnSave.Controls.Add(labelControl13);
            btnSave.Controls.Add(labelControl10);
            btnSave.Controls.Add(labelControl12);
            btnSave.Controls.Add(labelControl9);
            btnSave.Location = new Point(12, 413);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(567, 145);
            btnSave.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnCancel.Appearance.Options.UseFont = true;
            btnCancel.Location = new Point(291, 116);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(77, 24);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.BackColor = Color.FromArgb(50, 112, 188);
            simpleButton1.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            simpleButton1.Appearance.Options.UseBackColor = true;
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.Location = new Point(199, 116);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(77, 24);
            simpleButton1.TabIndex = 1;
            simpleButton1.Text = "Save";
            // 
            // labelControl11
            // 
            labelControl11.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl11.Appearance.ForeColor = Color.Blue;
            labelControl11.Appearance.Options.UseFont = true;
            labelControl11.Appearance.Options.UseForeColor = true;
            labelControl11.Location = new Point(352, 86);
            labelControl11.Name = "labelControl11";
            labelControl11.Size = new Size(32, 16);
            labelControl11.TabIndex = 0;
            labelControl11.Text = "Total";
            // 
            // labelControl14
            // 
            labelControl14.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl14.Appearance.ForeColor = Color.Blue;
            labelControl14.Appearance.Options.UseFont = true;
            labelControl14.Appearance.Options.UseForeColor = true;
            labelControl14.Location = new Point(503, 86);
            labelControl14.Name = "labelControl14";
            labelControl14.Size = new Size(44, 16);
            labelControl14.TabIndex = 0;
            labelControl14.Text = "385.00";
            // 
            // labelControl13
            // 
            labelControl13.Appearance.ForeColor = Color.FromArgb(0, 192, 0);
            labelControl13.Appearance.Options.UseForeColor = true;
            labelControl13.Location = new Point(515, 54);
            labelControl13.Name = "labelControl13";
            labelControl13.Size = new Size(32, 16);
            labelControl13.TabIndex = 0;
            labelControl13.Text = "35.00";
            // 
            // labelControl10
            // 
            labelControl10.Appearance.ForeColor = Color.FromArgb(0, 192, 0);
            labelControl10.Appearance.Options.UseForeColor = true;
            labelControl10.Location = new Point(352, 54);
            labelControl10.Name = "labelControl10";
            labelControl10.Size = new Size(69, 16);
            labelControl10.TabIndex = 0;
            labelControl10.Text = "Tax Amount";
            // 
            // labelControl12
            // 
            labelControl12.Appearance.ForeColor = Color.Black;
            labelControl12.Appearance.Options.UseForeColor = true;
            labelControl12.Location = new Point(508, 22);
            labelControl12.Name = "labelControl12";
            labelControl12.Size = new Size(39, 16);
            labelControl12.TabIndex = 0;
            labelControl12.Text = "350.00";
            // 
            // labelControl9
            // 
            labelControl9.Appearance.ForeColor = Color.Black;
            labelControl9.Appearance.Options.UseForeColor = true;
            labelControl9.Location = new Point(354, 22);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new Size(47, 16);
            labelControl9.TabIndex = 0;
            labelControl9.Text = "Subtotal";
            // 
            // groupControl2
            // 
            groupControl2.Controls.Add(gridControl);
            groupControl2.Location = new Point(12, 240);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(577, 169);
            groupControl2.TabIndex = 5;
            groupControl2.Text = "Invoice Details";
            // 
            // gridControl
            // 
            gridControl.Dock = DockStyle.Fill;
            gridControl.Location = new Point(2, 28);
            gridControl.MainView = gridView1;
            gridControl.Name = "gridControl";
            gridControl.Size = new Size(573, 139);
            gridControl.TabIndex = 0;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { Commodity, Batch, UnitPrice, Quantity, Amount });
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
            // groupControl1
            // 
            groupControl1.Controls.Add(seTaxRate);
            groupControl1.Controls.Add(meNote);
            groupControl1.Controls.Add(txtEmployee);
            groupControl1.Controls.Add(txtContact);
            groupControl1.Controls.Add(txtAddress);
            groupControl1.Controls.Add(cboCustomer);
            groupControl1.Controls.Add(deCreatedDate);
            groupControl1.Controls.Add(textEdit2);
            groupControl1.Controls.Add(labelControl7);
            groupControl1.Controls.Add(labelControl8);
            groupControl1.Controls.Add(labelControl4);
            groupControl1.Controls.Add(labelControl5);
            groupControl1.Controls.Add(labelControl6);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Location = new Point(12, 12);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(577, 224);
            groupControl1.TabIndex = 4;
            groupControl1.Text = "Invoice Info";
            // 
            // seTaxRate
            // 
            seTaxRate.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            seTaxRate.Location = new Point(93, 177);
            seTaxRate.Name = "seTaxRate";
            seTaxRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            seTaxRate.Size = new Size(79, 24);
            seTaxRate.TabIndex = 11;
            // 
            // meNote
            // 
            meNote.Location = new Point(384, 106);
            meNote.Name = "meNote";
            meNote.Properties.ScrollBars = ScrollBars.Horizontal;
            meNote.Size = new Size(156, 54);
            meNote.TabIndex = 10;
            // 
            // txtEmployee
            // 
            txtEmployee.Location = new Point(384, 37);
            txtEmployee.Name = "txtEmployee";
            txtEmployee.Size = new Size(156, 22);
            txtEmployee.TabIndex = 6;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(93, 107);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(156, 22);
            txtContact.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(93, 142);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(156, 22);
            txtAddress.TabIndex = 9;
            // 
            // cboCustomer
            // 
            cboCustomer.Location = new Point(93, 73);
            cboCustomer.Name = "cboCustomer";
            cboCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboCustomer.Size = new Size(156, 22);
            cboCustomer.TabIndex = 7;
            // 
            // deCreatedDate
            // 
            deCreatedDate.EditValue = null;
            deCreatedDate.Location = new Point(384, 73);
            deCreatedDate.Name = "deCreatedDate";
            deCreatedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            deCreatedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            deCreatedDate.Size = new Size(156, 22);
            deCreatedDate.TabIndex = 8;
            // 
            // textEdit2
            // 
            textEdit2.Location = new Point(93, 37);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new Size(156, 22);
            textEdit2.TabIndex = 5;
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new Font("Tahoma", 8F);
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Location = new Point(300, 76);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(68, 16);
            labelControl7.TabIndex = 3;
            labelControl7.Text = "Create Date";
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Font = new Font("Tahoma", 8F);
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.Location = new Point(300, 40);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(55, 16);
            labelControl8.TabIndex = 4;
            labelControl8.Text = "Employee";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 8F);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(14, 181);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(26, 16);
            labelControl4.TabIndex = 0;
            labelControl4.Text = "Rate";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Tahoma", 8F);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(302, 110);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(26, 16);
            labelControl5.TabIndex = 0;
            labelControl5.Text = "Note";
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Tahoma", 8F);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new Point(14, 110);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(43, 16);
            labelControl6.TabIndex = 0;
            labelControl6.Text = "Contact";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 8F);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(14, 144);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(46, 16);
            labelControl3.TabIndex = 0;
            labelControl3.Text = "Address";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 8F);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(14, 76);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(55, 16);
            labelControl2.TabIndex = 0;
            labelControl2.Text = "Customer";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 8F);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(14, 40);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(73, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Invoice Code";
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, emptySpaceItem1, layoutControlItem2, layoutControlItem4 });
            Root.Name = "Root";
            Root.Size = new Size(601, 570);
            Root.Text = "Invoice";
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = groupControl1;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(581, 228);
            layoutControlItem1.TextSize = new Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(571, 401);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(10, 149);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = groupControl2;
            layoutControlItem2.Location = new Point(0, 228);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(581, 173);
            layoutControlItem2.TextSize = new Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = btnSave;
            layoutControlItem4.Location = new Point(0, 401);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(571, 149);
            layoutControlItem4.TextSize = new Size(0, 0);
            layoutControlItem4.TextVisible = false;
            // 
            // frmNewInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 570);
            Controls.Add(layoutControl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNewInvoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Invoice";
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnSave).EndInit();
            btnSave.ResumeLayout(false);
            btnSave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)seTaxRate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)meNote.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmployee.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtContact.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAddress.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboCustomer.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)deCreatedDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)deCreatedDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit cboCustomer;
        private DevExpress.XtraEditors.DateEdit deCreatedDate;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.SpinEdit seTaxRate;
        private DevExpress.XtraEditors.MemoEdit meNote;
        private DevExpress.XtraEditors.TextEdit txtEmployee;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Commodity;
        private DevExpress.XtraGrid.Columns.GridColumn Batch;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn UnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn Amount;
        private DevExpress.XtraEditors.PanelControl btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit txtContact;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}