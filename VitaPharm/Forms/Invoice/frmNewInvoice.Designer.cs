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
            seTaxRate.Location = new Point(414, 117);
            seTaxRate.Name = "seTaxRate";
            seTaxRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            seTaxRate.Size = new Size(55, 24);
            seTaxRate.TabIndex = 25;
            // 
            // meNote
            // 
            meNote.Location = new Point(607, 114);
            meNote.Name = "meNote";
            meNote.Properties.ScrollBars = ScrollBars.Horizontal;
            meNote.Size = new Size(201, 44);
            meNote.TabIndex = 24;
            // 
            // txtEmployee
            // 
            txtEmployee.Location = new Point(123, 79);
            txtEmployee.Name = "txtEmployee";
            txtEmployee.Size = new Size(209, 22);
            txtEmployee.TabIndex = 20;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(123, 115);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(127, 22);
            txtContact.TabIndex = 23;
            // 
            // cboCustomer
            // 
            cboCustomer.Location = new Point(607, 74);
            cboCustomer.Name = "cboCustomer";
            cboCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboCustomer.Size = new Size(201, 22);
            cboCustomer.TabIndex = 21;
            // 
            // deCreatedDate
            // 
            deCreatedDate.EditValue = null;
            deCreatedDate.Location = new Point(607, 37);
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
            labelControl7.Location = new Point(514, 43);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(68, 16);
            labelControl7.TabIndex = 17;
            labelControl7.Text = "Create Date";
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Font = new Font("Tahoma", 8F);
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.Location = new Point(28, 82);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(57, 16);
            labelControl8.TabIndex = 18;
            labelControl8.Text = "Making By";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 8F);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(348, 121);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(51, 16);
            labelControl4.TabIndex = 12;
            labelControl4.Text = "Tax Rate";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Tahoma", 8F);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(514, 121);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(26, 16);
            labelControl5.TabIndex = 13;
            labelControl5.Text = "Note";
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Tahoma", 8F);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new Point(28, 116);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(43, 16);
            labelControl6.TabIndex = 14;
            labelControl6.Text = "Contact";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 8F);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(514, 79);
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
            groupControl1.Size = new Size(839, 177);
            groupControl1.TabIndex = 26;
            groupControl1.Text = "Invoice Information";
            // 
            // groupControl2
            // 
            groupControl2.AppearanceCaption.BorderColor = Color.FromArgb(250, 230, 230);
            groupControl2.AppearanceCaption.Options.UseBorderColor = true;
            groupControl2.Location = new Point(26, 183);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(540, 151);
            groupControl2.TabIndex = 27;
            groupControl2.Text = "Cart";
            // 
            // frmNewInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 389);
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
    }
}