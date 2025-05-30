namespace VitaPharm.Forms.Commodities
{
    partial class frmAllCommodities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllCommodities));
            gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colID = new DevExpress.XtraGrid.Columns.GridColumn();
            colCommodityName = new DevExpress.XtraGrid.Columns.GridColumn();
            colManufacturer = new DevExpress.XtraGrid.Columns.GridColumn();
            colBaseUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            colSellingPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            colIsTerminated = new DevExpress.XtraGrid.Columns.GridColumn();
            colCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            gridControl = new DevExpress.XtraGrid.GridControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            cboIsTerminated = new DevExpress.XtraEditors.ComboBoxEdit();
            labelControl9 = new DevExpress.XtraEditors.LabelControl();
            txtSellingPrice = new DevExpress.XtraEditors.TextEdit();
            Status = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            cboCategoryName = new DevExpress.XtraEditors.ComboBoxEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            txtBaseUnit = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            txtManufacturer = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            txtCommodityName = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            btnReload = new DevExpress.XtraEditors.SimpleButton();
            btnEdit = new DevExpress.XtraEditors.SimpleButton();
            toolStrip1 = new ToolStrip();
            btnImport = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cboIsTerminated.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSellingPrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboCategoryName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBaseUnit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtManufacturer.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCommodityName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // gridView
            // 
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colID, colCommodityName, colManufacturer, colBaseUnit, colSellingPrice, colIsTerminated, colCategoryName });
            gridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            gridView.GridControl = gridControl;
            gridView.Name = "gridView";
            gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView.OptionsView.RowAutoHeight = true;
            gridView.FocusedRowChanged += gridView_FocusedRowChanged;
            // 
            // colID
            // 
            colID.Caption = "ID";
            colID.FieldName = "CommodityID";
            colID.MinWidth = 25;
            colID.Name = "colID";
            colID.OptionsColumn.AllowEdit = false;
            colID.OptionsColumn.AllowFocus = false;
            colID.OptionsColumn.ReadOnly = true;
            colID.Visible = true;
            colID.VisibleIndex = 0;
            colID.Width = 47;
            // 
            // colCommodityName
            // 
            colCommodityName.Caption = "Commodity Name";
            colCommodityName.FieldName = "CommodityName";
            colCommodityName.MinWidth = 25;
            colCommodityName.Name = "colCommodityName";
            colCommodityName.OptionsColumn.AllowEdit = false;
            colCommodityName.OptionsColumn.AllowFocus = false;
            colCommodityName.OptionsColumn.ReadOnly = true;
            colCommodityName.Visible = true;
            colCommodityName.VisibleIndex = 1;
            colCommodityName.Width = 94;
            // 
            // colManufacturer
            // 
            colManufacturer.Caption = "Manufacturer";
            colManufacturer.FieldName = "Manufacturer";
            colManufacturer.MinWidth = 25;
            colManufacturer.Name = "colManufacturer";
            colManufacturer.OptionsColumn.AllowEdit = false;
            colManufacturer.OptionsColumn.AllowFocus = false;
            colManufacturer.OptionsColumn.ReadOnly = true;
            colManufacturer.Visible = true;
            colManufacturer.VisibleIndex = 2;
            colManufacturer.Width = 94;
            // 
            // colBaseUnit
            // 
            colBaseUnit.Caption = "Base Unit";
            colBaseUnit.FieldName = "BaseUnit";
            colBaseUnit.MinWidth = 25;
            colBaseUnit.Name = "colBaseUnit";
            colBaseUnit.OptionsColumn.AllowEdit = false;
            colBaseUnit.OptionsColumn.AllowFocus = false;
            colBaseUnit.OptionsColumn.ReadOnly = true;
            colBaseUnit.Visible = true;
            colBaseUnit.VisibleIndex = 3;
            colBaseUnit.Width = 94;
            // 
            // colSellingPrice
            // 
            colSellingPrice.Caption = "Selling Price";
            colSellingPrice.DisplayFormat.FormatString = "N0";
            colSellingPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colSellingPrice.FieldName = "SellingPrice";
            colSellingPrice.GroupFormat.FormatString = "N0";
            colSellingPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colSellingPrice.MinWidth = 25;
            colSellingPrice.Name = "colSellingPrice";
            colSellingPrice.OptionsColumn.AllowEdit = false;
            colSellingPrice.OptionsColumn.AllowFocus = false;
            colSellingPrice.OptionsColumn.ReadOnly = true;
            colSellingPrice.Visible = true;
            colSellingPrice.VisibleIndex = 4;
            colSellingPrice.Width = 94;
            // 
            // colIsTerminated
            // 
            colIsTerminated.Caption = "Status";
            colIsTerminated.FieldName = "IsTerminated";
            colIsTerminated.MinWidth = 25;
            colIsTerminated.Name = "colIsTerminated";
            colIsTerminated.OptionsColumn.AllowEdit = false;
            colIsTerminated.OptionsColumn.AllowFocus = false;
            colIsTerminated.OptionsColumn.ReadOnly = true;
            colIsTerminated.Visible = true;
            colIsTerminated.VisibleIndex = 5;
            colIsTerminated.Width = 94;
            // 
            // colCategoryName
            // 
            colCategoryName.Caption = "Type";
            colCategoryName.FieldName = "CategoryName";
            colCategoryName.MinWidth = 25;
            colCategoryName.Name = "colCategoryName";
            colCategoryName.OptionsColumn.AllowEdit = false;
            colCategoryName.OptionsColumn.AllowFocus = false;
            colCategoryName.OptionsColumn.ReadOnly = true;
            colCategoryName.Visible = true;
            colCategoryName.VisibleIndex = 6;
            colCategoryName.Width = 94;
            // 
            // gridControl
            // 
            gridControl.Dock = DockStyle.Fill;
            gridControl.Location = new Point(0, 176);
            gridControl.MainView = gridView;
            gridControl.Name = "gridControl";
            gridControl.Size = new Size(828, 220);
            gridControl.TabIndex = 0;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // groupControl1
            // 
            groupControl1.AppearanceCaption.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupControl1.AppearanceCaption.ForeColor = Color.FromArgb(16, 53, 113);
            groupControl1.AppearanceCaption.Options.UseFont = true;
            groupControl1.AppearanceCaption.Options.UseForeColor = true;
            groupControl1.Controls.Add(toolStrip1);
            groupControl1.Controls.Add(cboIsTerminated);
            groupControl1.Controls.Add(labelControl9);
            groupControl1.Controls.Add(txtSellingPrice);
            groupControl1.Controls.Add(Status);
            groupControl1.Controls.Add(labelControl5);
            groupControl1.Controls.Add(cboCategoryName);
            groupControl1.Controls.Add(labelControl4);
            groupControl1.Controls.Add(txtBaseUnit);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(txtManufacturer);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(txtCommodityName);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Dock = DockStyle.Top;
            groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            groupControl1.Location = new Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(828, 176);
            groupControl1.TabIndex = 1;
            groupControl1.Text = "Commodity Information";
            // 
            // cboIsTerminated
            // 
            cboIsTerminated.Location = new Point(578, 100);
            cboIsTerminated.Name = "cboIsTerminated";
            cboIsTerminated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboIsTerminated.Size = new Size(156, 22);
            cboIsTerminated.TabIndex = 15;
            // 
            // labelControl9
            // 
            labelControl9.Anchor = AnchorStyles.Top;
            labelControl9.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl9.Appearance.ForeColor = Color.FromArgb(0, 192, 0);
            labelControl9.Appearance.Options.UseFont = true;
            labelControl9.Appearance.Options.UseForeColor = true;
            labelControl9.Location = new Point(751, 66);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new Size(26, 16);
            labelControl9.TabIndex = 14;
            labelControl9.Text = "VND";
            // 
            // txtSellingPrice
            // 
            txtSellingPrice.Anchor = AnchorStyles.Top;
            txtSellingPrice.Location = new Point(577, 63);
            txtSellingPrice.Name = "txtSellingPrice";
            txtSellingPrice.Properties.Appearance.Options.UseTextOptions = true;
            txtSellingPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            txtSellingPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            txtSellingPrice.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            txtSellingPrice.Properties.MaskSettings.Set("mask", "N0");
            txtSellingPrice.Properties.UseMaskAsDisplayFormat = true;
            txtSellingPrice.Size = new Size(156, 22);
            txtSellingPrice.TabIndex = 4;
            // 
            // Status
            // 
            Status.Location = new Point(475, 103);
            Status.Name = "Status";
            Status.Size = new Size(41, 16);
            Status.TabIndex = 0;
            Status.Text = "Status:";
            // 
            // labelControl5
            // 
            labelControl5.Anchor = AnchorStyles.Top;
            labelControl5.Location = new Point(20, 103);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(33, 16);
            labelControl5.TabIndex = 0;
            labelControl5.Text = "Type:";
            // 
            // cboCategoryName
            // 
            cboCategoryName.Anchor = AnchorStyles.Top;
            cboCategoryName.EditValue = "";
            cboCategoryName.Location = new Point(137, 100);
            cboCategoryName.Name = "cboCategoryName";
            cboCategoryName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboCategoryName.Size = new Size(169, 22);
            cboCategoryName.TabIndex = 5;
            // 
            // labelControl4
            // 
            labelControl4.Anchor = AnchorStyles.Top;
            labelControl4.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(475, 66);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(75, 16);
            labelControl4.TabIndex = 0;
            labelControl4.Text = "Selling Price:";
            // 
            // txtBaseUnit
            // 
            txtBaseUnit.Anchor = AnchorStyles.Top;
            txtBaseUnit.Location = new Point(577, 25);
            txtBaseUnit.Name = "txtBaseUnit";
            txtBaseUnit.Properties.Appearance.Options.UseTextOptions = true;
            txtBaseUnit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            txtBaseUnit.Size = new Size(157, 22);
            txtBaseUnit.TabIndex = 2;
            // 
            // labelControl3
            // 
            labelControl3.Anchor = AnchorStyles.Top;
            labelControl3.Location = new Point(475, 28);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(58, 16);
            labelControl3.TabIndex = 0;
            labelControl3.Text = "Base Unit:";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Anchor = AnchorStyles.Top;
            txtManufacturer.Location = new Point(137, 63);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(271, 22);
            txtManufacturer.TabIndex = 3;
            // 
            // labelControl2
            // 
            labelControl2.Anchor = AnchorStyles.Top;
            labelControl2.Location = new Point(20, 66);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(81, 16);
            labelControl2.TabIndex = 0;
            labelControl2.Text = "Manufacturer:";
            // 
            // txtCommodityName
            // 
            txtCommodityName.Anchor = AnchorStyles.Top;
            txtCommodityName.EditValue = "";
            txtCommodityName.Location = new Point(137, 28);
            txtCommodityName.Name = "txtCommodityName";
            txtCommodityName.Size = new Size(271, 22);
            txtCommodityName.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Anchor = AnchorStyles.Top;
            labelControl1.Location = new Point(21, 31);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(110, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Commodity Name: ";
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(btnSave);
            panelControl1.Controls.Add(btnCancel);
            panelControl1.Controls.Add(btnReload);
            panelControl1.Controls.Add(btnEdit);
            panelControl1.Dock = DockStyle.Bottom;
            panelControl1.Location = new Point(0, 396);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(828, 64);
            panelControl1.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            btnSave.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnSave.Appearance.Options.UseBackColor = true;
            btnSave.Appearance.Options.UseFont = true;
            btnSave.Location = new Point(453, 16);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 36);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            btnCancel.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnCancel.Appearance.Options.UseBackColor = true;
            btnCancel.Appearance.Options.UseFont = true;
            btnCancel.Location = new Point(701, 16);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 36);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnReload
            // 
            btnReload.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            btnReload.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnReload.Appearance.Options.UseBackColor = true;
            btnReload.Appearance.Options.UseFont = true;
            btnReload.Location = new Point(577, 16);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(118, 36);
            btnReload.TabIndex = 5;
            btnReload.Text = "Reload";
            btnReload.Click += btnReload_Click;
            // 
            // btnEdit
            // 
            btnEdit.Appearance.BackColor = Color.FromArgb(100, 165, 80);
            btnEdit.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnEdit.Appearance.Options.UseBackColor = true;
            btnEdit.Appearance.Options.UseFont = true;
            btnEdit.Location = new Point(329, 16);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(118, 36);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.Click += btnEdit_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton2, btnImport });
            toolStrip1.Location = new Point(2, 147);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(824, 27);
            toolStrip1.TabIndex = 16;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnImport
            // 
            btnImport.Alignment = ToolStripItemAlignment.Right;
            btnImport.Image = Properties.Resources.import32;
            btnImport.ImageTransparentColor = Color.Magenta;
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(78, 24);
            btnImport.Text = "Import";
            btnImport.Click += btnImport_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Alignment = ToolStripItemAlignment.Right;
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 24);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // frmAllCommodities
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 460);
            Controls.Add(gridControl);
            Controls.Add(groupControl1);
            Controls.Add(panelControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmAllCommodities";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "All Commodities";
            Load += frmAllCommodities_Load;
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cboIsTerminated.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSellingPrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboCategoryName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBaseUnit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtManufacturer.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCommodityName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Columns.GridColumn colCommodityName;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtCommodityName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtManufacturer;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtBaseUnit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cboCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturer;
        private DevExpress.XtraGrid.Columns.GridColumn colSellingPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colIsTerminated;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryName;
        private DevExpress.XtraEditors.LabelControl Status;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtSellingPrice;
        private DevExpress.XtraEditors.ComboBoxEdit cboIsTerminated;
        private ToolStrip toolStrip1;
        private ToolStripButton btnImport;
        private ToolStripButton toolStripButton2;
    }
}