namespace VitaPharm.Forms
{
    partial class frmAllUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllUsers));
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            checkButton1 = new DevExpress.XtraEditors.CheckButton();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.AppearanceCaption.Font = new Font("Inter", 7.8F, FontStyle.Bold);
            groupControl1.AppearanceCaption.ForeColor = Color.FromArgb(16, 53, 113);
            groupControl1.AppearanceCaption.Options.UseFont = true;
            groupControl1.AppearanceCaption.Options.UseForeColor = true;
            groupControl1.Controls.Add(checkButton1);
            groupControl1.Controls.Add(labelControl8);
            groupControl1.Controls.Add(labelControl6);
            groupControl1.Controls.Add(labelControl5);
            groupControl1.Controls.Add(labelControl4);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(textEdit2);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Controls.Add(textEdit1);
            groupControl1.Dock = DockStyle.Top;
            groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            groupControl1.Location = new Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(828, 161);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "User Information";
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(127, 31);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(198, 22);
            textEdit1.TabIndex = 0;
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(22, 34);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(63, 16);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "Username:";
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(391, 98);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(62, 16);
            labelControl2.TabIndex = 2;
            labelControl2.Text = "Full Name:";
            // 
            // textEdit2
            // 
            textEdit2.Location = new Point(511, 120);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new Size(156, 22);
            textEdit2.TabIndex = 3;
            // 
            // labelControl3
            // 
            labelControl3.Location = new Point(331, 126);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(52, 16);
            labelControl3.TabIndex = 4;
            labelControl3.Text = "Contact: ";
            // 
            // labelControl4
            // 
            labelControl4.Location = new Point(34, 109);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(51, 16);
            labelControl4.TabIndex = 5;
            labelControl4.Text = "Address:";
            // 
            // labelControl5
            // 
            labelControl5.Location = new Point(454, 120);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(51, 16);
            labelControl5.TabIndex = 6;
            labelControl5.Text = "Birthday:";
            // 
            // labelControl6
            // 
            labelControl6.Location = new Point(127, 86);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(46, 16);
            labelControl6.TabIndex = 7;
            labelControl6.Text = "Gender:";
            // 
            // labelControl8
            // 
            labelControl8.Location = new Point(374, 34);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(30, 16);
            labelControl8.TabIndex = 9;
            labelControl8.Text = "Role:";
            // 
            // checkButton1
            // 
            checkButton1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("checkButton1.ImageOptions.SvgImage");
            checkButton1.Location = new Point(486, 53);
            checkButton1.Name = "checkButton1";
            checkButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            checkButton1.Size = new Size(110, 30);
            checkButton1.TabIndex = 1;
            checkButton1.Text = "Is Active?";
            // 
            // frmAllUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 460);
            Controls.Add(groupControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmAllUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAllUsers";
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.CheckButton checkButton1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}