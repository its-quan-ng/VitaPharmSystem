namespace VitaPharm.Forms
{
    partial class frmNewCommodity
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
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            textEdit4 = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).BeginInit();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.AppearanceCaption.BorderColor = Color.FromArgb(222, 228, 255);
            groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            groupControl1.Controls.Add(textEdit4);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(textEdit3);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(textEdit2);
            groupControl1.Controls.Add(textEdit1);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Location = new Point(27, 12);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(403, 234);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "Basic Information";
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(16, 42);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(33, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Name";
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(118, 36);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(271, 22);
            textEdit1.TabIndex = 1;
            // 
            // textEdit2
            // 
            textEdit2.Location = new Point(446, 56);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new Size(156, 22);
            textEdit2.TabIndex = 1;
            // 
            // textEdit3
            // 
            textEdit3.Location = new Point(118, 76);
            textEdit3.Name = "textEdit3";
            textEdit3.Size = new Size(271, 22);
            textEdit3.TabIndex = 3;
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(16, 82);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(33, 16);
            labelControl2.TabIndex = 2;
            labelControl2.Text = "Name";
            // 
            // textEdit4
            // 
            textEdit4.Location = new Point(118, 120);
            textEdit4.Name = "textEdit4";
            textEdit4.Size = new Size(271, 22);
            textEdit4.TabIndex = 5;
            // 
            // labelControl3
            // 
            labelControl3.Location = new Point(16, 126);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(33, 16);
            labelControl3.TabIndex = 4;
            labelControl3.Text = "Name";
            // 
            // frmNewCommodity
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 274);
            Controls.Add(groupControl1);
            Name = "frmNewCommodity";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Commodity";
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}