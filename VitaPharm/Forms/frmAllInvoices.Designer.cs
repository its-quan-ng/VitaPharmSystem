namespace VitaPharm.Forms
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
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            btnReload = new DevExpress.XtraEditors.SimpleButton();
            btnDeactive = new DevExpress.XtraEditors.SimpleButton();
            btnNewGoodsReceipt = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Location = new Point(12, 12);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(500, 250);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(btnCancel);
            panelControl1.Controls.Add(btnReload);
            panelControl1.Controls.Add(btnDeactive);
            panelControl1.Controls.Add(btnNewGoodsReceipt);
            panelControl1.Location = new Point(0, 351);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(856, 64);
            panelControl1.TabIndex = 1;
            // 
            // btnCancel
            // 
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
            // btnNewGoodsReceipt
            // 
            btnNewGoodsReceipt.Appearance.BackColor = Color.FromArgb(100, 165, 80);
            btnNewGoodsReceipt.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnNewGoodsReceipt.Appearance.Options.UseBackColor = true;
            btnNewGoodsReceipt.Appearance.Options.UseFont = true;
            btnNewGoodsReceipt.Location = new Point(351, 16);
            btnNewGoodsReceipt.Name = "btnNewGoodsReceipt";
            btnNewGoodsReceipt.Size = new Size(118, 36);
            btnNewGoodsReceipt.TabIndex = 11;
            btnNewGoodsReceipt.Text = "New Invoice";
            // 
            // frmAllInvoices
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 415);
            Controls.Add(panelControl1);
            Controls.Add(gridControl1);
            Name = "frmAllInvoices";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "All Invoices";
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraEditors.SimpleButton btnDeactive;
        private DevExpress.XtraEditors.SimpleButton btnNewGoodsReceipt;
    }
}