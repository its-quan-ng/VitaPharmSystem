namespace VitaPharm.Forms
{
    partial class frmGoodsReceiptDetail
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
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colBatchCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colMfgDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colExpDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colPurchasePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            panel1 = new Panel();
            panel2 = new Panel();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            lblTotalQuantity = new DevExpress.XtraEditors.LabelControl();
            lblTotalAmount = new DevExpress.XtraEditors.LabelControl();
            btnReload = new DevExpress.XtraEditors.SimpleButton();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(gridControl1);
            panelControl1.Dock = DockStyle.Top;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(621, 243);
            panelControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(2, 2);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(617, 239);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colBatchCode, colMfgDate, colExpDate, colPurchasePrice, colQuantity, colAmount });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // colBatchCode
            // 
            colBatchCode.Caption = "Batch Code";
            colBatchCode.FieldName = "BatchCode";
            colBatchCode.MinWidth = 25;
            colBatchCode.Name = "colBatchCode";
            colBatchCode.Visible = true;
            colBatchCode.VisibleIndex = 0;
            colBatchCode.Width = 94;
            // 
            // colMfgDate
            // 
            colMfgDate.Caption = "Mfg Date";
            colMfgDate.FieldName = "MfgDate";
            colMfgDate.MinWidth = 25;
            colMfgDate.Name = "colMfgDate";
            colMfgDate.Visible = true;
            colMfgDate.VisibleIndex = 1;
            colMfgDate.Width = 94;
            // 
            // colExpDate
            // 
            colExpDate.Caption = "Exp Date";
            colExpDate.FieldName = "ExpDate";
            colExpDate.MinWidth = 25;
            colExpDate.Name = "colExpDate";
            colExpDate.Visible = true;
            colExpDate.VisibleIndex = 2;
            colExpDate.Width = 94;
            // 
            // colPurchasePrice
            // 
            colPurchasePrice.Caption = "Purchase Price";
            colPurchasePrice.FieldName = "PurchasePrice";
            colPurchasePrice.MinWidth = 25;
            colPurchasePrice.Name = "colPurchasePrice";
            colPurchasePrice.Visible = true;
            colPurchasePrice.VisibleIndex = 3;
            colPurchasePrice.Width = 94;
            // 
            // colQuantity
            // 
            colQuantity.Caption = "Quantity";
            colQuantity.FieldName = "QtyIn";
            colQuantity.MinWidth = 25;
            colQuantity.Name = "colQuantity";
            colQuantity.Visible = true;
            colQuantity.VisibleIndex = 4;
            colQuantity.Width = 94;
            // 
            // colAmount
            // 
            colAmount.Caption = "Amount";
            colAmount.FieldName = "Amount";
            colAmount.MinWidth = 25;
            colAmount.Name = "colAmount";
            colAmount.Visible = true;
            colAmount.VisibleIndex = 5;
            colAmount.Width = 94;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnReload);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 331);
            panel1.Name = "panel1";
            panel1.Size = new Size(621, 63);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTotalAmount);
            panel2.Controls.Add(labelControl2);
            panel2.Controls.Add(lblTotalQuantity);
            panel2.Controls.Add(labelControl1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 243);
            panel2.Name = "panel2";
            panel2.Size = new Size(621, 88);
            panel2.TabIndex = 2;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(27, 15);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(97, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Total Quantity:";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(27, 47);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(92, 16);
            labelControl2.TabIndex = 0;
            labelControl2.Text = "Total Amount:";
            // 
            // lblTotalQuantity
            // 
            lblTotalQuantity.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            lblTotalQuantity.Appearance.Options.UseFont = true;
            lblTotalQuantity.Location = new Point(567, 15);
            lblTotalQuantity.Name = "lblTotalQuantity";
            lblTotalQuantity.Size = new Size(28, 16);
            lblTotalQuantity.TabIndex = 0;
            lblTotalQuantity.Text = "0.00";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            lblTotalAmount.Appearance.Options.UseFont = true;
            lblTotalAmount.Location = new Point(567, 47);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(28, 16);
            lblTotalAmount.TabIndex = 0;
            lblTotalAmount.Text = "0.00";
            // 
            // btnReload
            // 
            btnReload.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            btnReload.Appearance.FontStyleDelta = FontStyle.Bold;
            btnReload.Appearance.Options.UseBackColor = true;
            btnReload.Appearance.Options.UseFont = true;
            btnReload.Location = new Point(383, 19);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(97, 32);
            btnReload.TabIndex = 0;
            btnReload.Text = "Reload";
            // 
            // btnCancel
            // 
            btnCancel.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            btnCancel.Appearance.FontStyleDelta = FontStyle.Bold;
            btnCancel.Appearance.Options.UseBackColor = true;
            btnCancel.Appearance.Options.UseFont = true;
            btnCancel.Location = new Point(498, 19);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 32);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            // 
            // frmGoodsReceiptDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 394);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelControl1);
            Name = "frmGoodsReceiptDetail";
            Text = "Goods Receipt Detail";
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colBatchCode;
        private DevExpress.XtraGrid.Columns.GridColumn colMfgDate;
        private DevExpress.XtraGrid.Columns.GridColumn colExpDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchasePrice;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private Panel panel1;
        private Panel panel2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblTotalAmount;
        private DevExpress.XtraEditors.LabelControl lblTotalQuantity;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}