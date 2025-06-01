namespace VitaPharm.Reports
{
    partial class frmRevenueReportViewer
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
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            dateEditFrom = new DevExpress.XtraEditors.DateEdit();
            dateEditTo = new DevExpress.XtraEditors.DateEdit();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            btnViewReport = new DevExpress.XtraEditors.SimpleButton();
            documentViewer = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            ((System.ComponentModel.ISupportInitialize)dateEditFrom.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEditFrom.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEditTo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEditTo.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(33, 20);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(38, 18);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "From";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(295, 20);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(18, 18);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "To";
            // 
            // dateEditFrom
            // 
            dateEditFrom.EditValue = null;
            dateEditFrom.Location = new Point(92, 18);
            dateEditFrom.Name = "dateEditFrom";
            dateEditFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEditFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEditFrom.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            dateEditFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateEditFrom.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            dateEditFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateEditFrom.Size = new Size(145, 22);
            dateEditFrom.TabIndex = 23;
            // 
            // dateEditTo
            // 
            dateEditTo.EditValue = null;
            dateEditTo.Location = new Point(343, 18);
            dateEditTo.Name = "dateEditTo";
            dateEditTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEditTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEditTo.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            dateEditTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateEditTo.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            dateEditTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateEditTo.Size = new Size(145, 22);
            dateEditTo.TabIndex = 24;
            // 
            // panelControl1
            // 
            panelControl1.Appearance.BackColor = Color.White;
            panelControl1.Appearance.Options.UseBackColor = true;
            panelControl1.Controls.Add(btnViewReport);
            panelControl1.Controls.Add(dateEditTo);
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Controls.Add(dateEditFrom);
            panelControl1.Controls.Add(labelControl2);
            panelControl1.Dock = DockStyle.Top;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(698, 62);
            panelControl1.TabIndex = 25;
            // 
            // btnViewReport
            // 
            btnViewReport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnViewReport.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            btnViewReport.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewReport.Appearance.Options.UseBackColor = true;
            btnViewReport.Appearance.Options.UseFont = true;
            btnViewReport.Location = new Point(547, 12);
            btnViewReport.Name = "btnViewReport";
            btnViewReport.Size = new Size(119, 34);
            btnViewReport.TabIndex = 25;
            btnViewReport.Text = "View Report";
            btnViewReport.Click += btnViewReport_Click;
            // 
            // documentViewer
            // 
            documentViewer.Dock = DockStyle.Fill;
            documentViewer.IsMetric = false;
            documentViewer.Location = new Point(0, 62);
            documentViewer.Margin = new Padding(4, 4, 4, 4);
            documentViewer.Name = "documentViewer";
            documentViewer.Size = new Size(698, 298);
            documentViewer.TabIndex = 26;
            // 
            // frmRevenueReportViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 360);
            Controls.Add(documentViewer);
            Controls.Add(panelControl1);
            Name = "frmRevenueReportViewer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Revenue Report Viewer";
            ((System.ComponentModel.ISupportInitialize)dateEditFrom.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEditFrom.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEditTo.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEditTo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateEditFrom;
        private DevExpress.XtraEditors.DateEdit dateEditTo;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnViewReport;
        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer;
    }
}