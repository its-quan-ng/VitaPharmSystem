namespace VitaPharm.Forms
{
    partial class frmNewGoodsReceipt
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
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            grpInfo = new DevExpress.XtraEditors.GroupControl();
            grpDetails = new DevExpress.XtraEditors.GroupControl();
            grpSum = new DevExpress.XtraEditors.GroupControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridLookUpEdit2 = new DevExpress.XtraEditors.GridLookUpEdit();
            gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            Commodity = new DevExpress.XtraGrid.Columns.GridColumn();
            Batch = new DevExpress.XtraGrid.Columns.GridColumn();
            Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            PurchasePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grpInfo).BeginInit();
            grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grpDetails).BeginInit();
            grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grpSum).BeginInit();
            grpSum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit2View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(groupControl1);
            panelControl1.Dock = DockStyle.Fill;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(614, 566);
            panelControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(grpDetails);
            groupControl1.Controls.Add(grpInfo);
            groupControl1.Controls.Add(grpSum);
            groupControl1.Dock = DockStyle.Fill;
            groupControl1.Location = new Point(2, 2);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(610, 562);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "New Goods Receipt";
            // 
            // grpInfo
            // 
            grpInfo.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpInfo.Appearance.Options.UseFont = true;
            grpInfo.AppearanceCaption.FontStyleDelta = FontStyle.Bold;
            grpInfo.AppearanceCaption.Options.UseFont = true;
            grpInfo.Controls.Add(dateEdit1);
            grpInfo.Controls.Add(memoEdit1);
            grpInfo.Controls.Add(gridLookUpEdit2);
            grpInfo.Controls.Add(gridLookUpEdit1);
            grpInfo.Controls.Add(textEdit1);
            grpInfo.Controls.Add(labelControl3);
            grpInfo.Controls.Add(labelControl5);
            grpInfo.Controls.Add(labelControl2);
            grpInfo.Controls.Add(labelControl4);
            grpInfo.Controls.Add(labelControl1);
            grpInfo.Dock = DockStyle.Top;
            grpInfo.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            grpInfo.Location = new Point(2, 28);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new Size(606, 203);
            grpInfo.TabIndex = 0;
            grpInfo.Text = "Receipt Info";
            // 
            // grpDetails
            // 
            grpDetails.AppearanceCaption.FontStyleDelta = FontStyle.Bold;
            grpDetails.AppearanceCaption.Options.UseFont = true;
            grpDetails.Controls.Add(gridControl1);
            grpDetails.Dock = DockStyle.Fill;
            grpDetails.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            grpDetails.Location = new Point(2, 231);
            grpDetails.Name = "grpDetails";
            grpDetails.Size = new Size(606, 157);
            grpDetails.TabIndex = 1;
            grpDetails.Text = "Good Receipt Details";
            // 
            // grpSum
            // 
            grpSum.AppearanceCaption.FontStyleDelta = FontStyle.Bold;
            grpSum.AppearanceCaption.Options.UseFont = true;
            grpSum.Controls.Add(simpleButton2);
            grpSum.Controls.Add(simpleButton1);
            grpSum.Controls.Add(label3);
            grpSum.Controls.Add(label2);
            grpSum.Controls.Add(label1);
            grpSum.Controls.Add(labelControl8);
            grpSum.Controls.Add(labelControl7);
            grpSum.Controls.Add(labelControl6);
            grpSum.Controls.Add(label4);
            grpSum.Dock = DockStyle.Bottom;
            grpSum.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            grpSum.Location = new Point(2, 388);
            grpSum.Name = "grpSum";
            grpSum.Size = new Size(606, 172);
            grpSum.TabIndex = 2;
            grpSum.Text = "Summary";
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(37, 33);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(75, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Receipt Code";
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(37, 69);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(47, 16);
            labelControl2.TabIndex = 0;
            labelControl2.Text = "Supplier";
            // 
            // labelControl3
            // 
            labelControl3.Location = new Point(37, 111);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(26, 16);
            labelControl3.TabIndex = 0;
            labelControl3.Text = "Note";
            // 
            // labelControl4
            // 
            labelControl4.Location = new Point(339, 33);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(72, 16);
            labelControl4.TabIndex = 0;
            labelControl4.Text = "Receipt Date";
            // 
            // labelControl5
            // 
            labelControl5.Location = new Point(339, 69);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(55, 16);
            labelControl5.TabIndex = 0;
            labelControl5.Text = "Employee";
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(126, 29);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(134, 22);
            textEdit1.TabIndex = 1;
            // 
            // gridLookUpEdit1
            // 
            gridLookUpEdit1.Location = new Point(126, 66);
            gridLookUpEdit1.Name = "gridLookUpEdit1";
            gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            gridLookUpEdit1.Properties.PopupView = gridLookUpEdit1View;
            gridLookUpEdit1.Size = new Size(134, 22);
            gridLookUpEdit1.TabIndex = 2;
            // 
            // gridLookUpEdit1View
            // 
            gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridLookUpEdit2
            // 
            gridLookUpEdit2.Location = new Point(425, 66);
            gridLookUpEdit2.Name = "gridLookUpEdit2";
            gridLookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            gridLookUpEdit2.Properties.PopupView = gridLookUpEdit2View;
            gridLookUpEdit2.Size = new Size(132, 22);
            gridLookUpEdit2.TabIndex = 3;
            // 
            // gridLookUpEdit2View
            // 
            gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // memoEdit1
            // 
            memoEdit1.Location = new Point(126, 111);
            memoEdit1.Name = "memoEdit1";
            memoEdit1.Properties.ScrollBars = ScrollBars.Horizontal;
            memoEdit1.Size = new Size(431, 70);
            memoEdit1.TabIndex = 4;
            // 
            // dateEdit1
            // 
            dateEdit1.EditValue = null;
            dateEdit1.Location = new Point(427, 32);
            dateEdit1.Name = "dateEdit1";
            dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Size = new Size(130, 22);
            dateEdit1.TabIndex = 5;
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(2, 28);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(602, 127);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { Commodity, Batch, Quantity, PurchasePrice, Amount });
            gridView1.GridControl = gridControl1;
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
            // Quantity
            // 
            Quantity.Caption = "Quantity";
            Quantity.FieldName = "Quantity";
            Quantity.MinWidth = 25;
            Quantity.Name = "Quantity";
            Quantity.Visible = true;
            Quantity.VisibleIndex = 2;
            Quantity.Width = 94;
            // 
            // PurchasePrice
            // 
            PurchasePrice.Caption = "Purchase Price";
            PurchasePrice.FieldName = "PurchasePrice";
            PurchasePrice.MinWidth = 25;
            PurchasePrice.Name = "PurchasePrice";
            PurchasePrice.Visible = true;
            PurchasePrice.VisibleIndex = 3;
            PurchasePrice.Width = 94;
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
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new Point(414, 31);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(55, 16);
            labelControl6.TabIndex = 0;
            labelControl6.Text = "Subtotal";
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Location = new Point(414, 67);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(22, 16);
            labelControl7.TabIndex = 0;
            labelControl7.Text = "Tax";
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.Location = new Point(414, 101);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(32, 16);
            labelControl8.TabIndex = 0;
            labelControl8.Text = "Total";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(528, 31);
            label1.Name = "label1";
            label1.Size = new Size(32, 16);
            label1.TabIndex = 1;
            label1.Text = "0.00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(528, 67);
            label2.Name = "label2";
            label2.Size = new Size(32, 16);
            label2.TabIndex = 1;
            label2.Text = "0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(528, 101);
            label3.Name = "label3";
            label3.Size = new Size(32, 16);
            label3.TabIndex = 1;
            label3.Text = "0.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(476, 83);
            label4.Name = "label4";
            label4.Size = new Size(84, 16);
            label4.TabIndex = 2;
            label4.Text = "___________";
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.BackColor = Color.FromArgb(50, 112, 188);
            simpleButton1.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            simpleButton1.Appearance.ForeColor = Color.Black;
            simpleButton1.Appearance.Options.UseBackColor = true;
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.Appearance.Options.UseForeColor = true;
            simpleButton1.Location = new Point(349, 135);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(97, 29);
            simpleButton1.TabIndex = 3;
            simpleButton1.Text = "Save";
            // 
            // simpleButton2
            // 
            simpleButton2.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            simpleButton2.Appearance.Options.UseFont = true;
            simpleButton2.Location = new Point(460, 135);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(97, 29);
            simpleButton2.TabIndex = 3;
            simpleButton2.Text = "Cancel";
            // 
            // frmNewGoodsReceipt
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 566);
            Controls.Add(panelControl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNewGoodsReceipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNewGoodsReceipt";
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grpInfo).EndInit();
            grpInfo.ResumeLayout(false);
            grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grpDetails).EndInit();
            grpDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grpSum).EndInit();
            grpSum.ResumeLayout(false);
            grpSum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit2View).EndInit();
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl grpInfo;
        private DevExpress.XtraEditors.GroupControl grpSum;
        private DevExpress.XtraEditors.GroupControl grpDetails;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Commodity;
        private DevExpress.XtraGrid.Columns.GridColumn Batch;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn PurchasePrice;
        private DevExpress.XtraGrid.Columns.GridColumn Amount;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private Label label3;
        private Label label2;
        private Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private Label label4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}