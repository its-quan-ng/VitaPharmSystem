namespace VitaPharm.Forms.Invoices
{
    partial class frmInvoiceDetail
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
            colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            colBaseUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            colBatchCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colCommodityName = new DevExpress.XtraGrid.Columns.GridColumn();
            gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            gridControl = new DevExpress.XtraGrid.GridControl();
            btnPrint = new DevExpress.XtraEditors.SimpleButton();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            btnReload = new DevExpress.XtraEditors.SimpleButton();
            txtInvoiceCode = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            txtEmployee = new DevExpress.XtraEditors.TextEdit();
            deCreatedDate = new DevExpress.XtraEditors.DateEdit();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            txtCustomer = new DevExpress.XtraEditors.TextEdit();
            panel2 = new Panel();
            lblTotal = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtInvoiceCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmployee.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deCreatedDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deCreatedDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCustomer.Properties).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // colAmount
            // 
            colAmount.Caption = "Amount";
            colAmount.FieldName = "Amount";
            colAmount.MinWidth = 25;
            colAmount.Name = "colAmount";
            colAmount.Visible = true;
            colAmount.VisibleIndex = 5;
            colAmount.Width = 150;
            // 
            // colBaseUnit
            // 
            colBaseUnit.Caption = "Base Unit";
            colBaseUnit.FieldName = "BaseUnit";
            colBaseUnit.MinWidth = 25;
            colBaseUnit.Name = "colBaseUnit";
            colBaseUnit.Visible = true;
            colBaseUnit.VisibleIndex = 3;
            colBaseUnit.Width = 97;
            // 
            // colQuantity
            // 
            colQuantity.Caption = "Qty";
            colQuantity.FieldName = "Quantity";
            colQuantity.MinWidth = 25;
            colQuantity.Name = "colQuantity";
            colQuantity.Visible = true;
            colQuantity.VisibleIndex = 2;
            colQuantity.Width = 55;
            // 
            // colBatchCode
            // 
            colBatchCode.Caption = "Batch Code";
            colBatchCode.FieldName = "BatchCode";
            colBatchCode.MinWidth = 25;
            colBatchCode.Name = "colBatchCode";
            colBatchCode.Visible = true;
            colBatchCode.VisibleIndex = 1;
            colBatchCode.Width = 157;
            // 
            // colCommodityName
            // 
            colCommodityName.Caption = "Product Name";
            colCommodityName.FieldName = "CommodityName";
            colCommodityName.MinWidth = 25;
            colCommodityName.Name = "colCommodityName";
            colCommodityName.Visible = true;
            colCommodityName.VisibleIndex = 0;
            colCommodityName.Width = 262;
            // 
            // gridView
            // 
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colCommodityName, colBatchCode, colQuantity, colBaseUnit, colUnitPrice, colAmount });
            gridView.GridControl = gridControl;
            gridView.Name = "gridView";
            // 
            // colUnitPrice
            // 
            colUnitPrice.Caption = "Unit Price";
            colUnitPrice.FieldName = "UnitPrice";
            colUnitPrice.MinWidth = 25;
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.Visible = true;
            colUnitPrice.VisibleIndex = 4;
            colUnitPrice.Width = 130;
            // 
            // gridControl
            // 
            gridControl.Dock = DockStyle.Fill;
            gridControl.Location = new Point(0, 108);
            gridControl.MainView = gridView;
            gridControl.Name = "gridControl";
            gridControl.Size = new Size(813, 160);
            gridControl.TabIndex = 5;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // btnPrint
            // 
            btnPrint.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            btnPrint.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnPrint.Appearance.Options.UseBackColor = true;
            btnPrint.Appearance.Options.UseFont = true;
            btnPrint.Location = new Point(489, 20);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(106, 32);
            btnPrint.TabIndex = 11;
            btnPrint.Text = "Print";
            btnPrint.Click += btnPrint_Click;
            // 
            // btnCancel
            // 
            btnCancel.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            btnCancel.Appearance.FontStyleDelta = FontStyle.Bold;
            btnCancel.Appearance.Options.UseBackColor = true;
            btnCancel.Appearance.Options.UseFont = true;
            btnCancel.Location = new Point(704, 20);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 32);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new Font("Tahoma", 8F);
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Location = new Point(462, 40);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(68, 16);
            labelControl7.TabIndex = 25;
            labelControl7.Text = "Create Date";
            // 
            // btnReload
            // 
            btnReload.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            btnReload.Appearance.FontStyleDelta = FontStyle.Bold;
            btnReload.Appearance.Options.UseBackColor = true;
            btnReload.Appearance.Options.UseFont = true;
            btnReload.Location = new Point(601, 20);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(97, 32);
            btnReload.TabIndex = 2;
            btnReload.Text = "Reload";
            btnReload.Click += btnReload_Click;
            // 
            // txtInvoiceCode
            // 
            txtInvoiceCode.Location = new Point(152, 37);
            txtInvoiceCode.Name = "txtInvoiceCode";
            txtInvoiceCode.Size = new Size(209, 22);
            txtInvoiceCode.TabIndex = 27;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 8F);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(57, 40);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(73, 16);
            labelControl1.TabIndex = 24;
            labelControl1.Text = "Invoice Code";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 8F);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(462, 68);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(55, 16);
            labelControl2.TabIndex = 23;
            labelControl2.Text = "Customer";
            // 
            // txtEmployee
            // 
            txtEmployee.Location = new Point(152, 65);
            txtEmployee.Name = "txtEmployee";
            txtEmployee.Size = new Size(209, 22);
            txtEmployee.TabIndex = 28;
            // 
            // deCreatedDate
            // 
            deCreatedDate.EditValue = null;
            deCreatedDate.Location = new Point(555, 37);
            deCreatedDate.Name = "deCreatedDate";
            deCreatedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            deCreatedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            deCreatedDate.Size = new Size(201, 22);
            deCreatedDate.TabIndex = 30;
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Font = new Font("Tahoma", 8F);
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.Location = new Point(57, 68);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(57, 16);
            labelControl8.TabIndex = 26;
            labelControl8.Text = "Making By";
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(btnPrint);
            panelControl1.Controls.Add(btnCancel);
            panelControl1.Controls.Add(btnReload);
            panelControl1.Dock = DockStyle.Bottom;
            panelControl1.Location = new Point(0, 316);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(813, 64);
            panelControl1.TabIndex = 4;
            // 
            // groupControl1
            // 
            groupControl1.AppearanceCaption.BorderColor = Color.White;
            groupControl1.AppearanceCaption.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            groupControl1.AppearanceCaption.ForeColor = Color.FromArgb(16, 53, 113);
            groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            groupControl1.AppearanceCaption.Options.UseFont = true;
            groupControl1.AppearanceCaption.Options.UseForeColor = true;
            groupControl1.Controls.Add(txtCustomer);
            groupControl1.Controls.Add(txtInvoiceCode);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(txtEmployee);
            groupControl1.Controls.Add(deCreatedDate);
            groupControl1.Controls.Add(labelControl8);
            groupControl1.Controls.Add(labelControl7);
            groupControl1.Dock = DockStyle.Top;
            groupControl1.Location = new Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(813, 108);
            groupControl1.TabIndex = 3;
            groupControl1.Text = "Basic Information";
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(555, 65);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(202, 22);
            txtCustomer.TabIndex = 31;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(labelControl3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 268);
            panel2.Name = "panel2";
            panel2.Size = new Size(813, 48);
            panel2.TabIndex = 6;
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
            lblTotal.Location = new Point(704, 15);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(62, 18);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "0.0 VND";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(22, 15);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(43, 18);
            labelControl3.TabIndex = 0;
            labelControl3.Text = "Total:";
            // 
            // frmInvoiceDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 380);
            Controls.Add(gridControl);
            Controls.Add(panel2);
            Controls.Add(panelControl1);
            Controls.Add(groupControl1);
            Name = "frmInvoiceDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice Detail";
            Load += frmInvoiceDetail_Load;
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtInvoiceCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmployee.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)deCreatedDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)deCreatedDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCustomer.Properties).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colBatchCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCommodityName;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraEditors.TextEdit txtInvoiceCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtEmployee;
        private DevExpress.XtraEditors.DateEdit deCreatedDate;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Panel panel2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCustomer;
        private DevExpress.XtraEditors.LabelControl lblTotal;
    }
}