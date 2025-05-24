namespace VitaPharm.Forms
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
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colID = new DevExpress.XtraGrid.Columns.GridColumn();
            colCommodityName = new DevExpress.XtraGrid.Columns.GridColumn();
            colManufacturer = new DevExpress.XtraGrid.Columns.GridColumn();
            colBaseUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            colSellingPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            colCommodityStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            textEdit5 = new DevExpress.XtraEditors.TextEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            textEdit4 = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit5.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            SuspendLayout();
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colID, colCommodityName, colManufacturer, colBaseUnit, colSellingPrice, colCommodityStatus });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // colID
            // 
            colID.Caption = "ID";
            colID.FieldName = "CommodityID";
            colID.MinWidth = 25;
            colID.Name = "colID";
            colID.Visible = true;
            colID.VisibleIndex = 0;
            colID.Width = 47;
            // 
            // colCommodityName
            // 
            colCommodityName.Caption = "Name";
            colCommodityName.FieldName = "CommodityName";
            colCommodityName.MinWidth = 25;
            colCommodityName.Name = "colCommodityName";
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
            colBaseUnit.Visible = true;
            colBaseUnit.VisibleIndex = 3;
            colBaseUnit.Width = 94;
            // 
            // colSellingPrice
            // 
            colSellingPrice.Caption = "Selling Price";
            colSellingPrice.FieldName = "SellingPrice";
            colSellingPrice.MinWidth = 25;
            colSellingPrice.Name = "colSellingPrice";
            colSellingPrice.Visible = true;
            colSellingPrice.VisibleIndex = 4;
            colSellingPrice.Width = 94;
            // 
            // colCommodityStatus
            // 
            colCommodityStatus.Caption = "Status";
            colCommodityStatus.FieldName = "IsTerminated";
            colCommodityStatus.MinWidth = 25;
            colCommodityStatus.Name = "colCommodityStatus";
            colCommodityStatus.Visible = true;
            colCommodityStatus.VisibleIndex = 5;
            colCommodityStatus.Width = 94;
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(0, 146);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(828, 250);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // groupControl1
            // 
            groupControl1.AppearanceCaption.Font = new Font("Inter", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupControl1.AppearanceCaption.ForeColor = Color.FromArgb(16, 53, 113);
            groupControl1.AppearanceCaption.Options.UseFont = true;
            groupControl1.AppearanceCaption.Options.UseForeColor = true;
            groupControl1.Controls.Add(labelControl5);
            groupControl1.Controls.Add(comboBoxEdit1);
            groupControl1.Controls.Add(textEdit5);
            groupControl1.Controls.Add(labelControl4);
            groupControl1.Controls.Add(textEdit4);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(textEdit3);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(textEdit1);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Dock = DockStyle.Top;
            groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            groupControl1.Location = new Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(828, 146);
            groupControl1.TabIndex = 1;
            groupControl1.Text = "Commodity Information";
            // 
            // labelControl5
            // 
            labelControl5.Anchor = AnchorStyles.Top;
            labelControl5.Location = new Point(20, 103);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(33, 16);
            labelControl5.TabIndex = 11;
            labelControl5.Text = "Type:";
            // 
            // comboBoxEdit1
            // 
            comboBoxEdit1.Anchor = AnchorStyles.Top;
            comboBoxEdit1.EditValue = "";
            comboBoxEdit1.Location = new Point(122, 100);
            comboBoxEdit1.Name = "comboBoxEdit1";
            comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxEdit1.Size = new Size(169, 22);
            comboBoxEdit1.TabIndex = 10;
            // 
            // textEdit5
            // 
            textEdit5.Anchor = AnchorStyles.Top;
            textEdit5.Location = new Point(577, 60);
            textEdit5.Name = "textEdit5";
            textEdit5.Size = new Size(156, 22);
            textEdit5.TabIndex = 9;
            // 
            // labelControl4
            // 
            labelControl4.Anchor = AnchorStyles.Top;
            labelControl4.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(475, 63);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(75, 16);
            labelControl4.TabIndex = 8;
            labelControl4.Text = "Selling Price:";
            // 
            // textEdit4
            // 
            textEdit4.Anchor = AnchorStyles.Top;
            textEdit4.Location = new Point(577, 25);
            textEdit4.Name = "textEdit4";
            textEdit4.Size = new Size(157, 22);
            textEdit4.TabIndex = 7;
            // 
            // labelControl3
            // 
            labelControl3.Anchor = AnchorStyles.Top;
            labelControl3.Location = new Point(475, 28);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(58, 16);
            labelControl3.TabIndex = 6;
            labelControl3.Text = "Base Unit:";
            // 
            // textEdit3
            // 
            textEdit3.Anchor = AnchorStyles.Top;
            textEdit3.Location = new Point(122, 63);
            textEdit3.Name = "textEdit3";
            textEdit3.Size = new Size(271, 22);
            textEdit3.TabIndex = 5;
            // 
            // labelControl2
            // 
            labelControl2.Anchor = AnchorStyles.Top;
            labelControl2.Location = new Point(20, 66);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(81, 16);
            labelControl2.TabIndex = 4;
            labelControl2.Text = "Manufacturer:";
            // 
            // textEdit1
            // 
            textEdit1.Anchor = AnchorStyles.Top;
            textEdit1.EditValue = "";
            textEdit1.Location = new Point(122, 28);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(271, 22);
            textEdit1.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Anchor = AnchorStyles.Top;
            labelControl1.Location = new Point(21, 31);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(42, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Name: ";
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(simpleButton5);
            panelControl1.Controls.Add(simpleButton4);
            panelControl1.Controls.Add(simpleButton3);
            panelControl1.Controls.Add(simpleButton2);
            panelControl1.Controls.Add(simpleButton1);
            panelControl1.Dock = DockStyle.Bottom;
            panelControl1.Location = new Point(0, 396);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(828, 64);
            panelControl1.TabIndex = 2;
            // 
            // simpleButton4
            // 
            simpleButton4.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            simpleButton4.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            simpleButton4.Appearance.Options.UseBackColor = true;
            simpleButton4.Appearance.Options.UseFont = true;
            simpleButton4.Location = new Point(701, 16);
            simpleButton4.Name = "simpleButton4";
            simpleButton4.Size = new Size(118, 36);
            simpleButton4.TabIndex = 6;
            simpleButton4.Text = "Cancel";
            // 
            // simpleButton3
            // 
            simpleButton3.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            simpleButton3.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            simpleButton3.Appearance.Options.UseBackColor = true;
            simpleButton3.Appearance.Options.UseFont = true;
            simpleButton3.Location = new Point(577, 16);
            simpleButton3.Name = "simpleButton3";
            simpleButton3.Size = new Size(118, 36);
            simpleButton3.TabIndex = 5;
            simpleButton3.Text = "Reload";
            // 
            // simpleButton2
            // 
            simpleButton2.Appearance.BackColor = Color.FromArgb(78, 109, 156);
            simpleButton2.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            simpleButton2.Appearance.Options.UseBackColor = true;
            simpleButton2.Appearance.Options.UseFont = true;
            simpleButton2.Location = new Point(136, 16);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(118, 36);
            simpleButton2.TabIndex = 4;
            simpleButton2.Text = "Deactive";
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.BackColor = Color.FromArgb(100, 165, 80);
            simpleButton1.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            simpleButton1.Appearance.Options.UseBackColor = true;
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.Location = new Point(12, 16);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(118, 36);
            simpleButton1.TabIndex = 3;
            simpleButton1.Text = "Edit";
            // 
            // simpleButton5
            // 
            simpleButton5.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            simpleButton5.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            simpleButton5.Appearance.Options.UseBackColor = true;
            simpleButton5.Appearance.Options.UseFont = true;
            simpleButton5.Location = new Point(453, 16);
            simpleButton5.Name = "simpleButton5";
            simpleButton5.Size = new Size(118, 36);
            simpleButton5.TabIndex = 7;
            simpleButton5.Text = "Save";
            // 
            // frmAllCommodities
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 460);
            Controls.Add(gridControl1);
            Controls.Add(groupControl1);
            Controls.Add(panelControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmAllCommodities";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "All Commodities";
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit5.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colCommodityName;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturer;
        private DevExpress.XtraGrid.Columns.GridColumn colSellingPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCommodityStatus;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
    }
}