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
            cboBatchCode = new DevExpress.XtraEditors.LookUpEdit();
            cboCommodity = new DevExpress.XtraEditors.LookUpEdit();
            lblNewBatchCode = new DevExpress.XtraEditors.LabelControl();
            txtQtyAvailable = new DevExpress.XtraEditors.TextEdit();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            txtBatchStatus = new DevExpress.XtraEditors.TextEdit();
            txtPurchasePrice = new DevExpress.XtraEditors.TextEdit();
            spinQuantity = new DevExpress.XtraEditors.SpinEdit();
            dateExp = new DevExpress.XtraEditors.DateEdit();
            dateMfg = new DevExpress.XtraEditors.DateEdit();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            labelControl9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cboBatchCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboCommodity.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtQtyAvailable.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBatchStatus.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPurchasePrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spinQuantity.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateExp.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateExp.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateMfg.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateMfg.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.AppearanceCaption.BorderColor = Color.FromArgb(16, 53, 113);
            groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            groupControl1.Controls.Add(labelControl9);
            groupControl1.Controls.Add(cboBatchCode);
            groupControl1.Controls.Add(cboCommodity);
            groupControl1.Controls.Add(lblNewBatchCode);
            groupControl1.Controls.Add(txtQtyAvailable);
            groupControl1.Controls.Add(labelControl8);
            groupControl1.Controls.Add(txtBatchStatus);
            groupControl1.Controls.Add(txtPurchasePrice);
            groupControl1.Controls.Add(spinQuantity);
            groupControl1.Controls.Add(dateExp);
            groupControl1.Controls.Add(dateMfg);
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
            groupControl1.Size = new Size(784, 249);
            groupControl1.TabIndex = 3;
            groupControl1.Text = "Add Batch";
            // 
            // cboBatchCode
            // 
            cboBatchCode.Location = new Point(155, 81);
            cboBatchCode.Name = "cboBatchCode";
            cboBatchCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboBatchCode.Size = new Size(222, 22);
            cboBatchCode.TabIndex = 2;
            cboBatchCode.EditValueChanged += cboBatchCode_EditValueChanged;
            // 
            // cboCommodity
            // 
            cboCommodity.Location = new Point(155, 42);
            cboCommodity.Name = "cboCommodity";
            cboCommodity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboCommodity.Size = new Size(572, 22);
            cboCommodity.TabIndex = 1;
            cboCommodity.EditValueChanged += cboCommodity_EditValueChanged;
            // 
            // lblNewBatchCode
            // 
            lblNewBatchCode.Appearance.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewBatchCode.Appearance.ForeColor = Color.Blue;
            lblNewBatchCode.Appearance.Options.UseFont = true;
            lblNewBatchCode.Appearance.Options.UseForeColor = true;
            lblNewBatchCode.Location = new Point(413, 84);
            lblNewBatchCode.Name = "lblNewBatchCode";
            lblNewBatchCode.Size = new Size(106, 16);
            lblNewBatchCode.TabIndex = 0;
            lblNewBatchCode.Text = "NewBatchCode";
            // 
            // txtQtyAvailable
            // 
            txtQtyAvailable.Location = new Point(655, 81);
            txtQtyAvailable.Name = "txtQtyAvailable";
            txtQtyAvailable.Size = new Size(72, 22);
            txtQtyAvailable.TabIndex = 3;
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl8.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical;
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.Appearance.Options.UseForeColor = true;
            labelControl8.Location = new Point(585, 84);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(64, 16);
            labelControl8.TabIndex = 0;
            labelControl8.Text = "Available:";
            // 
            // txtBatchStatus
            // 
            txtBatchStatus.Location = new Point(571, 159);
            txtBatchStatus.Name = "txtBatchStatus";
            txtBatchStatus.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtBatchStatus.Properties.Appearance.ForeColor = Color.FromArgb(195, 49, 49);
            txtBatchStatus.Properties.Appearance.Options.UseFont = true;
            txtBatchStatus.Properties.Appearance.Options.UseForeColor = true;
            txtBatchStatus.Size = new Size(156, 22);
            txtBatchStatus.TabIndex = 7;
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Location = new Point(155, 159);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            txtPurchasePrice.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            txtPurchasePrice.Properties.MaskSettings.Set("mask", "N0");
            txtPurchasePrice.Properties.UseMaskAsDisplayFormat = true;
            txtPurchasePrice.Size = new Size(156, 22);
            txtPurchasePrice.TabIndex = 6;
            // 
            // spinQuantity
            // 
            spinQuantity.EditValue = new decimal(new int[] { 1, 0, 0, 0 });
            spinQuantity.Location = new Point(397, 219);
            spinQuantity.Name = "spinQuantity";
            spinQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spinQuantity.Properties.MaxValue = new decimal(new int[] { 1000, 0, 0, 0 });
            spinQuantity.Properties.MinValue = new decimal(new int[] { 1, 0, 0, 0 });
            spinQuantity.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            spinQuantity.Size = new Size(83, 24);
            spinQuantity.TabIndex = 8;
            // 
            // dateExp
            // 
            dateExp.EditValue = null;
            dateExp.Location = new Point(571, 120);
            dateExp.Name = "dateExp";
            dateExp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateExp.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateExp.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            dateExp.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateExp.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            dateExp.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateExp.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            dateExp.Size = new Size(156, 22);
            dateExp.TabIndex = 5;
            // 
            // dateMfg
            // 
            dateMfg.EditValue = null;
            dateMfg.Location = new Point(155, 120);
            dateMfg.Name = "dateMfg";
            dateMfg.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateMfg.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateMfg.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            dateMfg.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateMfg.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            dateMfg.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateMfg.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            dateMfg.Properties.UseMaskAsDisplayFormat = true;
            dateMfg.Size = new Size(156, 22);
            dateMfg.TabIndex = 4;
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new Font("Inter Extra Bold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl7.Appearance.ForeColor = Color.FromArgb(16, 53, 113);
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Appearance.Options.UseForeColor = true;
            labelControl7.Location = new Point(457, 162);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(42, 16);
            labelControl7.TabIndex = 0;
            labelControl7.Text = "Status";
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new Point(38, 162);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(101, 16);
            labelControl6.TabIndex = 0;
            labelControl6.Text = "Purchase Price:";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(330, 222);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(61, 16);
            labelControl5.TabIndex = 0;
            labelControl5.Text = "Quantity:";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(456, 123);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(62, 16);
            labelControl4.TabIndex = 0;
            labelControl4.Text = "Exp Date:";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(40, 123);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(64, 16);
            labelControl3.TabIndex = 0;
            labelControl3.Text = "Mfg Date:";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(40, 84);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(78, 16);
            labelControl2.TabIndex = 0;
            labelControl2.Text = "Batch Code:";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(40, 45);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(76, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Commodity:";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.Appearance.BackColor = Color.FromArgb(195, 49, 49);
            btnCancel.Appearance.FontStyleDelta = FontStyle.Bold;
            btnCancel.Appearance.Options.UseBackColor = true;
            btnCancel.Appearance.Options.UseFont = true;
            btnCancel.Location = new Point(410, 269);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(109, 31);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom;
            btnAdd.Appearance.BackColor = Color.FromArgb(100, 165, 80);
            btnAdd.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Appearance.Options.UseBackColor = true;
            btnAdd.Appearance.Options.UseFont = true;
            btnAdd.Location = new Point(246, 269);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 31);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // panelControl1
            // 
            panelControl1.Dock = DockStyle.Bottom;
            panelControl1.Location = new Point(0, 249);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(784, 67);
            panelControl1.TabIndex = 9;
            // 
            // labelControl9
            // 
            labelControl9.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl9.Appearance.ForeColor = Color.FromArgb(0, 192, 0);
            labelControl9.Appearance.Options.UseFont = true;
            labelControl9.Appearance.Options.UseForeColor = true;
            labelControl9.Location = new Point(353, 162);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new Size(26, 16);
            labelControl9.TabIndex = 0;
            labelControl9.Text = "VND";
            // 
            // frmNewBatch
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 316);
            Controls.Add(groupControl1);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(panelControl1);
            Name = "frmNewBatch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Batch";
            Load += frmNewBatch_Load;
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cboBatchCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboCommodity.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtQtyAvailable.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBatchStatus.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPurchasePrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spinQuantity.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateExp.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateExp.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateMfg.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateMfg.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit dateExp;
        private DevExpress.XtraEditors.DateEdit dateMfg;
        private DevExpress.XtraEditors.TextEdit txtPurchasePrice;
        private DevExpress.XtraEditors.SpinEdit spinQuantity;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit txtBatchStatus;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtQtyAvailable;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblNewBatchCode;
        private DevExpress.XtraEditors.LookUpEdit cboBatchCode;
        private DevExpress.XtraEditors.LookUpEdit cboCommodity;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}