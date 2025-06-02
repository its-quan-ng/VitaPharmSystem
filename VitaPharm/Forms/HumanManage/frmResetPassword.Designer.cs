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
            txtFullName = new DevExpress.XtraEditors.TextEdit();
            textUsername = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtFullName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textUsername.Properties).BeginInit();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.AppearanceCaption.BorderColor = Color.FromArgb(246, 209, 77);
            groupControl1.AppearanceCaption.ForeColor = Color.FromArgb(15, 60, 186);
            groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            groupControl1.AppearanceCaption.Options.UseForeColor = true;
            groupControl1.CaptionImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("groupControl1.CaptionImageOptions.SvgImage");
            groupControl1.CaptionImageOptions.SvgImageSize = new Size(16, 16);
            groupControl1.Controls.Add(txtFullName);
            groupControl1.Controls.Add(textUsername);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Dock = DockStyle.Top;
            groupControl1.Location = new Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(407, 137);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "Basic Info.";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(147, 84);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(212, 22);
            txtFullName.TabIndex = 3;
            // 
            // textUsername
            // 
            textUsername.Location = new Point(147, 47);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(212, 22);
            textUsername.TabIndex = 2;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl2.Appearance.ForeColor = Color.FromArgb(15, 60, 186);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new Point(45, 87);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(64, 16);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "Full name:";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl1.Appearance.ForeColor = Color.FromArgb(15, 60, 186);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new Point(45, 50);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(69, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Username:";
            // 
            // frmResetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 302);
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
            ((System.ComponentModel.ISupportInitialize)txtFullName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textUsername.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private DevExpress.XtraEditors.TextEdit textUsername;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}