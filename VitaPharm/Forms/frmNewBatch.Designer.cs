namespace VitaPharm.Forms
{
    partial class frmNewBatch
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
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
            txtAmount = new DevExpress.XtraEditors.TextEdit();
            txtPurchasePrice = new DevExpress.XtraEditors.TextEdit();
            spinQuantity = new DevExpress.XtraEditors.SpinEdit();
            dateExp = new DevExpress.XtraEditors.DateEdit();
            dateMfg = new DevExpress.XtraEditors.DateEdit();
            cboCommodity = new DevExpress.XtraEditors.ComboBoxEdit();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            cboBatchCode = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtAmount.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPurchasePrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spinQuantity.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateExp.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateExp.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateMfg.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateMfg.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboCommodity.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboBatchCode.Properties).BeginInit();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(cboBatchCode);
            groupControl1.Controls.Add(btnCancel);
            groupControl1.Controls.Add(btnAdd);
            groupControl1.Controls.Add(txtAmount);
            groupControl1.Controls.Add(txtPurchasePrice);
            groupControl1.Controls.Add(spinQuantity);
            groupControl1.Controls.Add(dateExp);
            groupControl1.Controls.Add(dateMfg);
            groupControl1.Controls.Add(cboCommodity);
            groupControl1.Controls.Add(labelControl7);
            groupControl1.Controls.Add(labelControl6);
            groupControl1.Controls.Add(labelControl5);
            groupControl1.Controls.Add(labelControl4);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Dock = DockStyle.Fill;
            groupControl1.Location = new Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(440, 382);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "Add Batch";
            // 
            // btnCancel
            // 
            btnCancel.Appearance.BackColor = Color.FromArgb(195, 49, 49);
            btnCancel.Appearance.FontStyleDelta = FontStyle.Bold;
            btnCancel.Appearance.Options.UseBackColor = true;
            btnCancel.Appearance.Options.UseFont = true;
            btnCancel.Location = new Point(248, 338);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(109, 31);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            // 
            // btnAdd
            // 
            btnAdd.Appearance.BackColor = Color.FromArgb(100, 165, 80);
            btnAdd.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Appearance.Options.UseBackColor = true;
            btnAdd.Appearance.Options.UseFont = true;
            btnAdd.Location = new Point(84, 338);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 31);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(147, 294);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(156, 22);
            txtAmount.TabIndex = 7;
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Location = new Point(147, 253);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.Size = new Size(156, 22);
            txtPurchasePrice.TabIndex = 7;
            // 
            // spinQuantity
            // 
            spinQuantity.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spinQuantity.Location = new Point(147, 211);
            spinQuantity.Name = "spinQuantity";
            spinQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spinQuantity.Size = new Size(156, 24);
            spinQuantity.TabIndex = 6;
            // 
            // dateExp
            // 
            dateExp.EditValue = null;
            dateExp.Location = new Point(147, 171);
            dateExp.Name = "dateExp";
            dateExp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateExp.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateExp.Size = new Size(156, 22);
            dateExp.TabIndex = 5;
            // 
            // dateMfg
            // 
            dateMfg.EditValue = null;
            dateMfg.Location = new Point(147, 130);
            dateMfg.Name = "dateMfg";
            dateMfg.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateMfg.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateMfg.Size = new Size(156, 22);
            dateMfg.TabIndex = 5;
            // 
            // cboCommodity
            // 
            cboCommodity.Location = new Point(147, 48);
            cboCommodity.Name = "cboCommodity";
            cboCommodity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboCommodity.Size = new Size(245, 22);
            cboCommodity.TabIndex = 3;
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Location = new Point(40, 297);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(51, 16);
            labelControl7.TabIndex = 2;
            labelControl7.Text = "Amount";
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new Point(40, 256);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(101, 16);
            labelControl6.TabIndex = 2;
            labelControl6.Text = "Purchase Price:";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(40, 215);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(61, 16);
            labelControl5.TabIndex = 2;
            labelControl5.Text = "Quantity:";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(40, 174);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(62, 16);
            labelControl4.TabIndex = 1;
            labelControl4.Text = "Exp Date:";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(40, 133);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(64, 16);
            labelControl3.TabIndex = 1;
            labelControl3.Text = "Mfg Date:";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(40, 92);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(78, 16);
            labelControl2.TabIndex = 0;
            labelControl2.Text = "Batch Code:";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(40, 51);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(76, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Commodity:";
            // 
            // cboBatchCode
            // 
            cboBatchCode.Location = new Point(147, 89);
            cboBatchCode.Name = "cboBatchCode";
            cboBatchCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboBatchCode.Size = new Size(156, 22);
            cboBatchCode.TabIndex = 9;
            // 
            // frmNewBatch
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 382);
            Controls.Add(groupControl1);
            Name = "frmNewBatch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Batch";
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtAmount.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPurchasePrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spinQuantity.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateExp.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateExp.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateMfg.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateMfg.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboCommodity.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboBatchCode.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cboCommodity;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit dateExp;
        private DevExpress.XtraEditors.DateEdit dateMfg;
        private DevExpress.XtraEditors.TextEdit txtAmount;
        private DevExpress.XtraEditors.TextEdit txtPurchasePrice;
        private DevExpress.XtraEditors.SpinEdit spinQuantity;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.ComboBoxEdit cboBatchCode;
    }
}