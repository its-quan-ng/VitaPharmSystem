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
            dateForm = new DevExpress.XtraEditors.DateEdit();
            dateTo = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)dateForm.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateForm.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateTo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateTo.Properties.CalendarTimeProperties).BeginInit();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(42, 1);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(38, 18);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "From";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(382, 1);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(18, 18);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "To";
            // 
            // dateForm
            // 
            dateForm.EditValue = null;
            dateForm.Location = new Point(97, 0);
            dateForm.Name = "dateForm";
            dateForm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateForm.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateForm.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            dateForm.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateForm.Size = new Size(181, 22);
            dateForm.TabIndex = 23;
            // 
            // dateTo
            // 
            dateTo.EditValue = null;
            dateTo.Location = new Point(423, -2);
            dateTo.Name = "dateTo";
            dateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateTo.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            dateTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateTo.Size = new Size(181, 22);
            dateTo.TabIndex = 24;
            // 
            // frmRevenueReportViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 460);
            Controls.Add(dateTo);
            Controls.Add(dateForm);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Name = "frmRevenueReportViewer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Revenue Report Viewer";
            ((System.ComponentModel.ISupportInitialize)dateForm.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateForm.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateTo.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateTo.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateForm;
        private DevExpress.XtraEditors.DateEdit dateTo;
    }
}