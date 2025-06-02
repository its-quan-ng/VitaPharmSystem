namespace VitaPharm.Forms.HumanManage
{
    partial class frmResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResetPassword));
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.AppearanceCaption.BorderColor = Color.FromArgb(246, 209, 77);
            groupControl1.AppearanceCaption.ForeColor = Color.FromArgb(15, 60, 186);
            groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            groupControl1.AppearanceCaption.Options.UseForeColor = true;
            groupControl1.CaptionImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("groupControl1.CaptionImageOptions.SvgImage");
            groupControl1.Controls.Add(textEdit2);
            groupControl1.Controls.Add(textEdit1);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Dock = DockStyle.Top;
            groupControl1.Location = new Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(479, 149);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "Basic Info.";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl1.Appearance.ForeColor = Color.FromArgb(15, 60, 186);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new Point(27, 62);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(69, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Username:";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl2.Appearance.ForeColor = Color.FromArgb(15, 60, 186);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new Point(27, 99);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(64, 16);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "Full name:";
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(129, 59);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(212, 22);
            textEdit1.TabIndex = 2;
            // 
            // textEdit2
            // 
            textEdit2.Location = new Point(129, 93);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new Size(212, 22);
            textEdit2.TabIndex = 3;
            // 
            // frmResetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 302);
            Controls.Add(groupControl1);
            IconOptions.Image = Properties.Resources.vitapharm_transparent;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmResetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reset Password";
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}