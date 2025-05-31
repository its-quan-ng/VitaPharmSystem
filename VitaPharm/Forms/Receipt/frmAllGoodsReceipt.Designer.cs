namespace VitaPharm.Forms.Receipt
{
    partial class frmAllGoodsReceipt
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            panel2 = new Panel();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            btnReload = new DevExpress.XtraEditors.SimpleButton();
            btnDeactive = new DevExpress.XtraEditors.SimpleButton();
            btnNewGoodsReceipt = new DevExpress.XtraEditors.SimpleButton();
            panel3 = new Panel();
            gridControl = new DevExpress.XtraGrid.GridControl();
            gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colID = new DevExpress.XtraGrid.Columns.GridColumn();
            colReceiptCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colReceiptDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colSupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            colReceiptStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            colAction = new DevExpress.XtraGrid.Columns.GridColumn();
            repobtnViewDetail = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repobtnViewDetail).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnReload);
            panel2.Controls.Add(btnDeactive);
            panel2.Controls.Add(btnNewGoodsReceipt);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 344);
            panel2.Name = "panel2";
            panel2.Size = new Size(853, 71);
            panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            btnCancel.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnCancel.Appearance.Options.UseBackColor = true;
            btnCancel.Appearance.Options.UseFont = true;
            btnCancel.Location = new Point(714, 20);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 36);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Close";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnReload
            // 
            btnReload.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnReload.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            btnReload.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnReload.Appearance.Options.UseBackColor = true;
            btnReload.Appearance.Options.UseFont = true;
            btnReload.Location = new Point(590, 20);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(118, 36);
            btnReload.TabIndex = 9;
            btnReload.Text = "Reload";
            btnReload.Click += btnReload_Click;
            // 
            // btnDeactive
            // 
            btnDeactive.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeactive.Appearance.BackColor = Color.FromArgb(78, 109, 156);
            btnDeactive.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnDeactive.Appearance.Options.UseBackColor = true;
            btnDeactive.Appearance.Options.UseFont = true;
            btnDeactive.Location = new Point(466, 20);
            btnDeactive.Name = "btnDeactive";
            btnDeactive.Size = new Size(118, 36);
            btnDeactive.TabIndex = 8;
            btnDeactive.Text = "Deactive";
            btnDeactive.Click += btnDeactive_Click;
            // 
            // btnNewGoodsReceipt
            // 
            btnNewGoodsReceipt.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNewGoodsReceipt.Appearance.BackColor = Color.FromArgb(100, 165, 80);
            btnNewGoodsReceipt.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnNewGoodsReceipt.Appearance.Options.UseBackColor = true;
            btnNewGoodsReceipt.Appearance.Options.UseFont = true;
            btnNewGoodsReceipt.Location = new Point(311, 20);
            btnNewGoodsReceipt.Name = "btnNewGoodsReceipt";
            btnNewGoodsReceipt.Size = new Size(149, 36);
            btnNewGoodsReceipt.TabIndex = 7;
            btnNewGoodsReceipt.Text = "New Goods Receipt";
            btnNewGoodsReceipt.Click += btnNewGoodsReceipt_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(gridControl);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(853, 344);
            panel3.TabIndex = 2;
            // 
            // gridControl
            // 
            gridControl.Dock = DockStyle.Fill;
            gridControl.Location = new Point(0, 0);
            gridControl.MainView = gridView;
            gridControl.Name = "gridControl";
            gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repobtnViewDetail });
            gridControl.Size = new Size(853, 344);
            gridControl.TabIndex = 0;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // gridView
            // 
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colID, colReceiptCode, colReceiptDate, colSupplierName, colNote, colReceiptStatus, colAction });
            gridView.GridControl = gridControl;
            gridView.Name = "gridView";
            gridView.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.True;
            gridView.OptionsView.ShowAutoFilterRow = true;
            // 
            // colID
            // 
            colID.Caption = "ID";
            colID.FieldName = "ID";
            colID.MinWidth = 25;
            colID.Name = "colID";
            colID.OptionsColumn.AllowEdit = false;
            colID.Visible = true;
            colID.VisibleIndex = 0;
            colID.Width = 45;
            // 
            // colReceiptCode
            // 
            colReceiptCode.Caption = "Receipt Code";
            colReceiptCode.FieldName = "ReceiptCode";
            colReceiptCode.MinWidth = 25;
            colReceiptCode.Name = "colReceiptCode";
            colReceiptCode.OptionsColumn.AllowEdit = false;
            colReceiptCode.Visible = true;
            colReceiptCode.VisibleIndex = 1;
            colReceiptCode.Width = 210;
            // 
            // colReceiptDate
            // 
            colReceiptDate.Caption = "Date";
            colReceiptDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            colReceiptDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colReceiptDate.FieldName = "ReceiptDate";
            colReceiptDate.MinWidth = 25;
            colReceiptDate.Name = "colReceiptDate";
            colReceiptDate.OptionsColumn.AllowEdit = false;
            colReceiptDate.Visible = true;
            colReceiptDate.VisibleIndex = 2;
            colReceiptDate.Width = 105;
            // 
            // colSupplierName
            // 
            colSupplierName.Caption = "Supplier Name";
            colSupplierName.FieldName = "SupplierName";
            colSupplierName.MinWidth = 25;
            colSupplierName.Name = "colSupplierName";
            colSupplierName.OptionsColumn.AllowEdit = false;
            colSupplierName.Visible = true;
            colSupplierName.VisibleIndex = 3;
            colSupplierName.Width = 160;
            // 
            // colNote
            // 
            colNote.Caption = "Note";
            colNote.FieldName = "Note";
            colNote.MinWidth = 25;
            colNote.Name = "colNote";
            colNote.OptionsColumn.AllowEdit = false;
            colNote.Visible = true;
            colNote.VisibleIndex = 4;
            colNote.Width = 119;
            // 
            // colReceiptStatus
            // 
            colReceiptStatus.Caption = "Status ";
            colReceiptStatus.FieldName = "ReceiptStatus";
            colReceiptStatus.MinWidth = 25;
            colReceiptStatus.Name = "colReceiptStatus";
            colReceiptStatus.OptionsColumn.AllowEdit = false;
            colReceiptStatus.Visible = true;
            colReceiptStatus.VisibleIndex = 5;
            colReceiptStatus.Width = 97;
            // 
            // colAction
            // 
            colAction.Caption = "Action";
            colAction.ColumnEdit = repobtnViewDetail;
            colAction.FieldName = "colAction";
            colAction.MinWidth = 25;
            colAction.Name = "colAction";
            colAction.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            colAction.UnboundDataType = typeof(object);
            colAction.Visible = true;
            colAction.VisibleIndex = 6;
            colAction.Width = 115;
            // 
            // repobtnViewDetail
            // 
            repobtnViewDetail.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            repobtnViewDetail.Appearance.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            repobtnViewDetail.Appearance.ForeColor = Color.White;
            repobtnViewDetail.Appearance.Options.UseBackColor = true;
            repobtnViewDetail.Appearance.Options.UseFont = true;
            repobtnViewDetail.Appearance.Options.UseForeColor = true;
            repobtnViewDetail.AutoHeight = false;
            repobtnViewDetail.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "View detail", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            repobtnViewDetail.Name = "repobtnViewDetail";
            repobtnViewDetail.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // frmAllGoodsReceipt
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 415);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "frmAllGoodsReceipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "All Goods Receipt";
            Load += frmAllGoodsReceipt_Load;
            Click += frmAllGoodsReceipt_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)repobtnViewDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DevExpress.XtraEditors.ComboBoxEdit cboStatus;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cboEmployee;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cboSupplier;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateCreate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnFilter;
        private Panel panel2;
        private Panel panel3;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiptCode;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiptDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierName;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiptStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colAction;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraEditors.SimpleButton btnDeactive;
        private DevExpress.XtraEditors.SimpleButton btnNewGoodsReceipt;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repobtnViewDetail;
    }
}