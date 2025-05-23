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
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            seTaxRate = new DevExpress.XtraEditors.SpinEdit();
            meNote = new DevExpress.XtraEditors.MemoEdit();
            txtEmployee = new DevExpress.XtraEditors.TextEdit();
            txtAddress = new DevExpress.XtraEditors.TextEdit();
            cboCustomer = new DevExpress.XtraEditors.LookUpEdit();
            deCreatedDate = new DevExpress.XtraEditors.DateEdit();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)seTaxRate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)meNote.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmployee.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAddress.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboCustomer.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deCreatedDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deCreatedDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(textEdit1);
            layoutControl1.Controls.Add(groupControl1);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(1007, 313, 812, 500);
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(601, 603);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(132, 569);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(457, 22);
            textEdit1.StyleController = layoutControl1;
            textEdit1.TabIndex = 5;
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(seTaxRate);
            groupControl1.Controls.Add(meNote);
            groupControl1.Controls.Add(txtEmployee);
            groupControl1.Controls.Add(txtAddress);
            groupControl1.Controls.Add(cboCustomer);
            groupControl1.Controls.Add(deCreatedDate);
            groupControl1.Controls.Add(textEdit2);
            groupControl1.Controls.Add(labelControl7);
            groupControl1.Controls.Add(labelControl8);
            groupControl1.Controls.Add(labelControl4);
            groupControl1.Controls.Add(labelControl5);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Location = new Point(12, 12);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(577, 188);
            groupControl1.TabIndex = 4;
            groupControl1.Text = "Invoice Info";
            // 
            // seTaxRate
            // 
            seTaxRate.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            seTaxRate.Location = new Point(93, 144);
            seTaxRate.Name = "seTaxRate";
            seTaxRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            seTaxRate.Size = new Size(79, 24);
            seTaxRate.TabIndex = 12;
            // 
            // meNote
            // 
            meNote.Location = new Point(384, 110);
            meNote.Name = "meNote";
            meNote.Properties.ScrollBars = ScrollBars.Horizontal;
            meNote.Size = new Size(156, 54);
            meNote.TabIndex = 11;
            // 
            // txtEmployee
            // 
            txtEmployee.Location = new Point(384, 37);
            txtEmployee.Name = "txtEmployee";
            txtEmployee.Size = new Size(156, 22);
            txtEmployee.TabIndex = 10;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(93, 109);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(156, 22);
            txtAddress.TabIndex = 8;
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
            deCreatedDate.TabIndex = 6;
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
            labelControl4.Location = new Point(14, 148);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(26, 16);
            labelControl4.TabIndex = 0;
            labelControl4.Text = "Rate";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Tahoma", 8F);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(300, 112);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(26, 16);
            labelControl5.TabIndex = 0;
            labelControl5.Text = "Note";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 8F);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(14, 112);
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
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, emptySpaceItem1, layoutControlItem2 });
            Root.Name = "Root";
            Root.Size = new Size(601, 603);
            Root.Text = "Invoice";
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = groupControl1;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(581, 192);
            layoutControlItem1.TextSize = new Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(0, 192);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(581, 365);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = textEdit1;
            layoutControlItem2.Location = new Point(0, 557);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(581, 26);
            layoutControlItem2.TextSize = new Size(108, 16);
            // 
            // frmNewInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 603);
            Controls.Add(layoutControl1);
            Name = "frmNewInvoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Invoice";
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)seTaxRate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)meNote.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmployee.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAddress.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboCustomer.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)deCreatedDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)deCreatedDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
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
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LookUpEdit cboCustomer;
        private DevExpress.XtraEditors.DateEdit deCreatedDate;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SpinEdit seTaxRate;
        private DevExpress.XtraEditors.MemoEdit meNote;
        private DevExpress.XtraEditors.TextEdit txtEmployee;
        private DevExpress.XtraEditors.TextEdit txtAddress;
    }
}