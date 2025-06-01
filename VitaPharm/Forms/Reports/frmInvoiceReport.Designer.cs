namespace VitaPharm.Forms.Reports
{
    partial class frmInvoiceReport
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoiceReport));
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            btnExport = new DevExpress.XtraEditors.SimpleButton();
            btnApply = new DevExpress.XtraEditors.SimpleButton();
            dateEditTo = new DevExpress.XtraEditors.DateEdit();
            dateEditFrom = new DevExpress.XtraEditors.DateEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            pivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
            fieldInvoiceID = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldInvoiceCode = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldCreatedDate = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldCustomerName = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldEmployeeName = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldInvoiceStatus = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldTotalAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldTaxRate = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldTaxAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dateEditTo.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEditTo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEditFrom.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEditFrom.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pivotGridControl).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(btnClose);
            panelControl1.Controls.Add(btnExport);
            panelControl1.Controls.Add(btnApply);
            panelControl1.Controls.Add(dateEditTo);
            panelControl1.Controls.Add(dateEditFrom);
            panelControl1.Controls.Add(labelControl2);
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Dock = DockStyle.Top;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(1024, 64);
            panelControl1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            btnClose.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnClose.Appearance.Options.UseBackColor = true;
            btnClose.Appearance.Options.UseFont = true;
            btnClose.Location = new Point(894, 16);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(118, 36);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExport.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            btnExport.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnExport.Appearance.Options.UseBackColor = true;
            btnExport.Appearance.Options.UseFont = true;
            btnExport.Location = new Point(770, 16);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(118, 36);
            btnExport.TabIndex = 5;
            btnExport.Text = "Export";
            btnExport.Click += btnExport_Click;
            // 
            // btnApply
            // 
            btnApply.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnApply.Appearance.BackColor = Color.FromArgb(100, 165, 80);
            btnApply.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnApply.Appearance.Options.UseBackColor = true;
            btnApply.Appearance.Options.UseFont = true;
            btnApply.Location = new Point(646, 16);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(118, 36);
            btnApply.TabIndex = 4;
            btnApply.Text = "Apply";
            btnApply.Click += btnApply_Click;
            // 
            // dateEditTo
            // 
            dateEditTo.EditValue = null;
            dateEditTo.Location = new Point(280, 22);
            dateEditTo.Name = "dateEditTo";
            dateEditTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEditTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEditTo.Size = new Size(150, 24);
            dateEditTo.TabIndex = 3;
            // 
            // dateEditFrom
            // 
            dateEditFrom.EditValue = null;
            dateEditFrom.Location = new Point(80, 22);
            dateEditFrom.Name = "dateEditFrom";
            dateEditFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEditFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEditFrom.Size = new Size(150, 24);
            dateEditFrom.TabIndex = 2;
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(240, 25);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(34, 16);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "To:";
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(40, 25);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(34, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "From:";
            // 
            // pivotGridControl
            // 
            pivotGridControl.Dock = DockStyle.Fill;
            pivotGridControl.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] { fieldInvoiceID, fieldInvoiceCode, fieldCreatedDate, fieldCustomerName, fieldEmployeeName, fieldInvoiceStatus, fieldTotalAmount, fieldTaxRate, fieldTaxAmount });
            pivotGridControl.Location = new Point(0, 64);
            pivotGridControl.Name = "pivotGridControl";
            pivotGridControl.Size = new Size(1024, 536);
            pivotGridControl.TabIndex = 1;
            // 
            // fieldInvoiceID
            // 
            fieldInvoiceID.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            fieldInvoiceID.AreaIndex = 0;
            fieldInvoiceID.Caption = "Invoice ID";
            fieldInvoiceID.FieldName = "InvoiceID";
            fieldInvoiceID.MinWidth = 25;
            fieldInvoiceID.Name = "fieldInvoiceID";
            fieldInvoiceID.Width = 100;
            // 
            // fieldInvoiceCode
            // 
            fieldInvoiceCode.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            fieldInvoiceCode.AreaIndex = 1;
            fieldInvoiceCode.Caption = "Invoice Code";
            fieldInvoiceCode.FieldName = "InvoiceCode";
            fieldInvoiceCode.MinWidth = 25;
            fieldInvoiceCode.Name = "fieldInvoiceCode";
            fieldInvoiceCode.Width = 100;
            // 
            // fieldCreatedDate
            // 
            fieldCreatedDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            fieldCreatedDate.AreaIndex = 0;
            fieldCreatedDate.Caption = "Created Date";
            fieldCreatedDate.FieldName = "CreatedDate";
            fieldCreatedDate.MinWidth = 25;
            fieldCreatedDate.Name = "fieldCreatedDate";
            fieldCreatedDate.Width = 100;
            // 
            // fieldCustomerName
            // 
            fieldCustomerName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            fieldCustomerName.AreaIndex = 2;
            fieldCustomerName.Caption = "Customer";
            fieldCustomerName.FieldName = "CustomerName";
            fieldCustomerName.MinWidth = 25;
            fieldCustomerName.Name = "fieldCustomerName";
            fieldCustomerName.Width = 100;
            // 
            // fieldEmployeeName
            // 
            fieldEmployeeName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            fieldEmployeeName.AreaIndex = 3;
            fieldEmployeeName.Caption = "Employee";
            fieldEmployeeName.FieldName = "EmployeeName";
            fieldEmployeeName.MinWidth = 25;
            fieldEmployeeName.Name = "fieldEmployeeName";
            fieldEmployeeName.Width = 100;
            // 
            // fieldInvoiceStatus
            // 
            fieldInvoiceStatus.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            fieldInvoiceStatus.AreaIndex = 4;
            fieldInvoiceStatus.Caption = "Status";
            fieldInvoiceStatus.FieldName = "InvoiceStatus";
            fieldInvoiceStatus.MinWidth = 25;
            fieldInvoiceStatus.Name = "fieldInvoiceStatus";
            fieldInvoiceStatus.Width = 100;
            // 
            // fieldTotalAmount
            // 
            fieldTotalAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            fieldTotalAmount.AreaIndex = 0;
            fieldTotalAmount.Caption = "Total Amount";
            fieldTotalAmount.FieldName = "TotalAmount";
            fieldTotalAmount.MinWidth = 25;
            fieldTotalAmount.Name = "fieldTotalAmount";
            fieldTotalAmount.Width = 100;
            // 
            // fieldTaxRate
            // 
            fieldTaxRate.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            fieldTaxRate.AreaIndex = 5;
            fieldTaxRate.Caption = "Tax Rate";
            fieldTaxRate.FieldName = "TaxRate";
            fieldTaxRate.MinWidth = 25;
            fieldTaxRate.Name = "fieldTaxRate";
            fieldTaxRate.Width = 100;
            // 
            // fieldTaxAmount
            // 
            fieldTaxAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            fieldTaxAmount.AreaIndex = 1;
            fieldTaxAmount.Caption = "Tax Amount";
            fieldTaxAmount.FieldName = "TaxAmount";
            fieldTaxAmount.MinWidth = 25;
            fieldTaxAmount.Name = "fieldTaxAmount";
            fieldTaxAmount.Width = 100;
            // 
            // frmInvoiceReport
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 600);
            Controls.Add(pivotGridControl);
            Controls.Add(panelControl1);
            Name = "frmInvoiceReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice Report";
            Load += frmInvoiceReport_Load;
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dateEditTo.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEditTo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEditFrom.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEditFrom.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pivotGridControl).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.SimpleButton btnApply;
        private DevExpress.XtraEditors.DateEdit dateEditTo;
        private DevExpress.XtraEditors.DateEdit dateEditFrom;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl;
        private DevExpress.XtraPivotGrid.PivotGridField fieldInvoiceID;
        private DevExpress.XtraPivotGrid.PivotGridField fieldInvoiceCode;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCreatedDate;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCustomerName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldEmployeeName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldInvoiceStatus;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTotalAmount;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTaxRate;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTaxAmount;
    }
} 