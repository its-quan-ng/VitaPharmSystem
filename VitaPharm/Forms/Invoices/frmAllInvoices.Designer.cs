namespace VitaPharm.Forms.Invoices
{
    partial class frmAllInvoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllInvoices));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            imageCollection = new DevExpress.Utils.ImageCollection(components);
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            btnReload = new DevExpress.XtraEditors.SimpleButton();
            btnDeactive = new DevExpress.XtraEditors.SimpleButton();
            btnNewInvoice = new DevExpress.XtraEditors.SimpleButton();
            repoImageCboStatus = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            repobtnAction = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            btnView = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colID = new DevExpress.XtraGrid.Columns.GridColumn();
            colInvoiceCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            colEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            colAction = new DevExpress.XtraGrid.Columns.GridColumn();
            gridControl = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)imageCollection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)repoImageCboStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repobtnAction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            SuspendLayout();
            // 
            // imageCollection
            // 
            imageCollection.ImageStream = (DevExpress.Utils.ImageCollectionStreamer)resources.GetObject("imageCollection.ImageStream");
            imageCollection.Images.SetKeyName(0, "canceled.png");
            imageCollection.Images.SetKeyName(1, "success.png");
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(btnCancel);
            panelControl1.Controls.Add(btnReload);
            panelControl1.Controls.Add(btnDeactive);
            panelControl1.Controls.Add(btnNewInvoice);
            panelControl1.Dock = DockStyle.Bottom;
            panelControl1.Location = new Point(0, 351);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(853, 64);
            panelControl1.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            btnCancel.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnCancel.Appearance.Options.UseBackColor = true;
            btnCancel.Appearance.Options.UseFont = true;
            btnCancel.Location = new Point(723, 16);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 36);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            // 
            // btnReload
            // 
            btnReload.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReload.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            btnReload.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnReload.Appearance.Options.UseBackColor = true;
            btnReload.Appearance.Options.UseFont = true;
            btnReload.Location = new Point(599, 16);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(118, 36);
            btnReload.TabIndex = 13;
            btnReload.Text = "Reload";
            // 
            // btnDeactive
            // 
            btnDeactive.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeactive.Appearance.BackColor = Color.FromArgb(78, 109, 156);
            btnDeactive.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnDeactive.Appearance.Options.UseBackColor = true;
            btnDeactive.Appearance.Options.UseFont = true;
            btnDeactive.Location = new Point(475, 16);
            btnDeactive.Name = "btnDeactive";
            btnDeactive.Size = new Size(118, 36);
            btnDeactive.TabIndex = 12;
            btnDeactive.Text = "Deactive";
            // 
            // btnNewInvoice
            // 
            btnNewInvoice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewInvoice.Appearance.BackColor = Color.FromArgb(100, 165, 80);
            btnNewInvoice.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnNewInvoice.Appearance.Options.UseBackColor = true;
            btnNewInvoice.Appearance.Options.UseFont = true;
            btnNewInvoice.Location = new Point(351, 16);
            btnNewInvoice.Name = "btnNewInvoice";
            btnNewInvoice.Size = new Size(118, 36);
            btnNewInvoice.TabIndex = 11;
            btnNewInvoice.Text = "New Invoice";
            btnNewInvoice.Click += btnNewInvoice_Click;
            // 
            // repoImageCboStatus
            // 
            repoImageCboStatus.AutoHeight = false;
            repoImageCboStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repoImageCboStatus.Name = "repoImageCboStatus";
            repoImageCboStatus.SmallImages = imageCollection;
            // 
            // repobtnAction
            // 
            repobtnAction.AutoHeight = false;
            repobtnAction.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            repobtnAction.Name = "repobtnAction";
            // 
            // btnView
            // 
            btnView.AutoHeight = false;
            btnView.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "View Detail", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            btnView.Name = "btnView";
            btnView.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridView
            // 
            gridView.Appearance.FilterPanel.BorderColor = Color.FromArgb(255, 224, 192);
            gridView.Appearance.FilterPanel.Options.UseBorderColor = true;
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colID, colInvoiceCode, colDate, colCustomerName, colEmployeeName, colStatus, colNote, colAction });
            gridView.GridControl = gridControl;
            gridView.Name = "gridView";
            gridView.OptionsEditForm.EditFormColumnCount = 5;
            gridView.OptionsPrint.PrintFilterInfo = true;
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            gridView.OptionsView.ShowGroupedColumns = true;
            // 
            // colID
            // 
            colID.Caption = "ID";
            colID.FieldName = "InvoiceID";
            colID.MinWidth = 25;
            colID.Name = "colID";
            colID.Visible = true;
            colID.VisibleIndex = 0;
            colID.Width = 48;
            // 
            // colInvoiceCode
            // 
            colInvoiceCode.Caption = "Invoice Code";
            colInvoiceCode.FieldName = "InvoiceCode";
            colInvoiceCode.MinWidth = 25;
            colInvoiceCode.Name = "colInvoiceCode";
            colInvoiceCode.Visible = true;
            colInvoiceCode.VisibleIndex = 1;
            colInvoiceCode.Width = 98;
            // 
            // colDate
            // 
            colDate.Caption = "Created Date";
            colDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            colDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colDate.FieldName = "CreatedDate";
            colDate.MinWidth = 25;
            colDate.Name = "colDate";
            colDate.Visible = true;
            colDate.VisibleIndex = 2;
            colDate.Width = 120;
            // 
            // colCustomerName
            // 
            colCustomerName.Caption = "Customer";
            colCustomerName.FieldName = "CustomerName";
            colCustomerName.MinWidth = 25;
            colCustomerName.Name = "colCustomerName";
            colCustomerName.Visible = true;
            colCustomerName.VisibleIndex = 3;
            colCustomerName.Width = 145;
            // 
            // colEmployeeName
            // 
            colEmployeeName.Caption = "Employee";
            colEmployeeName.FieldName = "EmployeeName";
            colEmployeeName.MinWidth = 25;
            colEmployeeName.Name = "colEmployeeName";
            colEmployeeName.Visible = true;
            colEmployeeName.VisibleIndex = 4;
            colEmployeeName.Width = 160;
            // 
            // colStatus
            // 
            colStatus.Caption = "Status";
            colStatus.FieldName = "InvoiceStatus";
            colStatus.MinWidth = 25;
            colStatus.Name = "colStatus";
            colStatus.Visible = true;
            colStatus.VisibleIndex = 5;
            colStatus.Width = 94;
            // 
            // colNote
            // 
            colNote.Caption = "Note";
            colNote.FieldName = "Note";
            colNote.MinWidth = 25;
            colNote.Name = "colNote";
            colNote.Visible = true;
            colNote.VisibleIndex = 6;
            colNote.Width = 136;
            // 
            // colAction
            // 
            colAction.ColumnEdit = btnView;
            colAction.FieldName = "Action";
            colAction.MinWidth = 25;
            colAction.Name = "colAction";
            colAction.OptionsColumn.ShowCaption = false;
            colAction.Visible = true;
            colAction.VisibleIndex = 7;
            colAction.Width = 80;
            // 
            // gridControl
            // 
            gridControl.Dock = DockStyle.Fill;
            gridControl.Location = new Point(0, 0);
            gridControl.MainView = gridView;
            gridControl.Name = "gridControl";
            gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repoImageCboStatus, repobtnAction, btnView });
            gridControl.Size = new Size(853, 351);
            gridControl.TabIndex = 0;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // frmAllInvoices
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 415);
            Controls.Add(gridControl);
            Controls.Add(panelControl1);
            Name = "frmAllInvoices";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "All Invoices";
            Load += frmAllInvoices_Load;
            ((System.ComponentModel.ISupportInitialize)imageCollection).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)repoImageCboStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)repobtnAction).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnView).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraEditors.SimpleButton btnDeactive;
        private DevExpress.XtraEditors.SimpleButton btnNewInvoice;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repoImageCboStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repobtnAction;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colAction;
        private DevExpress.XtraGrid.GridControl gridControl;
    }
}