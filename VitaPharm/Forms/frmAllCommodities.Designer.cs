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
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            textEdit4 = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            textEdit5 = new DevExpress.XtraEditors.TextEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit5.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colID, gridColumn1 });
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
            colID.Width = 94;
            // 
            // gridControl1
            // 
            gridControl1.Location = new Point(0, 152);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(831, 252);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "gridColumn1";
            gridColumn1.MinWidth = 25;
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 1;
            gridColumn1.Width = 94;
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
            groupControl1.Size = new Size(831, 146);
            groupControl1.TabIndex = 1;
            groupControl1.Text = "Commodity Information";
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(21, 31);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(42, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Name: ";
            // 
            // textEdit1
            // 
            textEdit1.EditValue = "";
            textEdit1.Location = new Point(122, 28);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(271, 22);
            textEdit1.TabIndex = 1;
            // 
            // textEdit3
            // 
            textEdit3.Location = new Point(122, 63);
            textEdit3.Name = "textEdit3";
            textEdit3.Size = new Size(271, 22);
            textEdit3.TabIndex = 5;
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(20, 66);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(81, 16);
            labelControl2.TabIndex = 4;
            labelControl2.Text = "Manufacturer:";
            // 
            // textEdit4
            // 
            textEdit4.Location = new Point(536, 28);
            textEdit4.Name = "textEdit4";
            textEdit4.Size = new Size(157, 22);
            textEdit4.TabIndex = 7;
            // 
            // labelControl3
            // 
            labelControl3.Location = new Point(434, 31);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(58, 16);
            labelControl3.TabIndex = 6;
            labelControl3.Text = "Base Unit:";
            // 
            // textEdit5
            // 
            textEdit5.Location = new Point(536, 63);
            textEdit5.Name = "textEdit5";
            textEdit5.Size = new Size(156, 22);
            textEdit5.TabIndex = 9;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(434, 66);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(75, 16);
            labelControl4.TabIndex = 8;
            labelControl4.Text = "Selling Price:";
            // 
            // comboBoxEdit1
            // 
            comboBoxEdit1.EditValue = "";
            comboBoxEdit1.Location = new Point(122, 100);
            comboBoxEdit1.Name = "comboBoxEdit1";
            comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxEdit1.Size = new Size(169, 22);
            comboBoxEdit1.TabIndex = 10;
            // 
            // labelControl5
            // 
            labelControl5.Location = new Point(20, 103);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(33, 16);
            labelControl5.TabIndex = 11;
            labelControl5.Text = "Type:";
            // 
            // frmAllCommodities
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 462);
            Controls.Add(gridControl1);
            Controls.Add(groupControl1);
            Name = "frmAllCommodities";
            Text = "frmAllCommodities";
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit5.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
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
    }
}