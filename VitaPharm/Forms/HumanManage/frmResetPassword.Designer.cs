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
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            txtConfirmNewPassword = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            txtNewPassword = new DevExpress.XtraEditors.TextEdit();
            btnEye = new DevExpress.XtraEditors.SimpleButton();
            btnEyeConfirm = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtFullName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textUsername.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtConfirmNewPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNewPassword.Properties).BeginInit();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
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
            groupControl1.ShowCaption = false;
            groupControl1.Size = new Size(435, 99);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "Basic Info.";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(179, 57);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(194, 22);
            txtFullName.TabIndex = 3;
            // 
            // textUsername
            // 
            textUsername.Location = new Point(179, 20);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(194, 22);
            textUsername.TabIndex = 2;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl2.Appearance.ForeColor = Color.FromArgb(15, 60, 186);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new Point(100, 60);
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
            labelControl1.Location = new Point(95, 23);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(69, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Username:";
            // 
            // groupControl2
            // 
            groupControl2.AppearanceCaption.BorderColor = Color.White;
            groupControl2.AppearanceCaption.Options.UseBorderColor = true;
            groupControl2.CaptionImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("groupControl2.CaptionImageOptions.SvgImage");
            groupControl2.CaptionImageOptions.SvgImageSize = new Size(16, 16);
            groupControl2.Controls.Add(btnEyeConfirm);
            groupControl2.Controls.Add(btnEye);
            groupControl2.Controls.Add(btnSave);
            groupControl2.Controls.Add(btnCancel);
            groupControl2.Controls.Add(labelControl4);
            groupControl2.Controls.Add(txtConfirmNewPassword);
            groupControl2.Controls.Add(labelControl3);
            groupControl2.Controls.Add(txtNewPassword);
            groupControl2.Dock = DockStyle.Fill;
            groupControl2.Location = new Point(0, 99);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(435, 181);
            groupControl2.TabIndex = 1;
            groupControl2.Text = "Reset Password";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top;
            btnSave.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            btnSave.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnSave.Appearance.Options.UseBackColor = true;
            btnSave.Appearance.Options.UseFont = true;
            btnSave.Location = new Point(114, 127);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top;
            btnCancel.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            btnCancel.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnCancel.Appearance.Options.UseBackColor = true;
            btnCancel.Appearance.Options.UseFont = true;
            btnCancel.Location = new Point(220, 127);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 30);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl4.Appearance.ForeColor = Color.FromArgb(71, 3, 27);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Appearance.Options.UseForeColor = true;
            labelControl4.Location = new Point(12, 84);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(152, 16);
            labelControl4.TabIndex = 6;
            labelControl4.Text = "Confirm New Password:";
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.Location = new Point(179, 81);
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.Properties.PasswordChar = '•';
            txtConfirmNewPassword.Properties.UseSystemPasswordChar = true;
            txtConfirmNewPassword.Size = new Size(194, 22);
            txtConfirmNewPassword.TabIndex = 5;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl3.Appearance.ForeColor = Color.FromArgb(71, 3, 27);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseForeColor = true;
            labelControl3.Location = new Point(65, 45);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(99, 16);
            labelControl3.TabIndex = 4;
            labelControl3.Text = "New Password:";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(179, 42);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Properties.PasswordChar = '•';
            txtNewPassword.Properties.UseSystemPasswordChar = true;
            txtNewPassword.Size = new Size(194, 22);
            txtNewPassword.TabIndex = 0;
            txtNewPassword.EditValueChanged += txtNewPassword_EditValueChanged;
            // 
            // btnEye
            // 
            btnEye.Appearance.BackColor = Color.Transparent;
            btnEye.Appearance.Options.UseBackColor = true;
            btnEye.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton1.ImageOptions.SvgImage");
            btnEye.ImageOptions.SvgImageSize = new Size(16, 16);
            btnEye.Location = new Point(379, 43);
            btnEye.Name = "btnEye";
            btnEye.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnEye.Size = new Size(25, 21);
            btnEye.TabIndex = 9;
            btnEye.Click += btnEye_Click;
            // 
            // btnEyeConfirm
            // 
            btnEyeConfirm.Appearance.BackColor = Color.Transparent;
            btnEyeConfirm.Appearance.Options.UseBackColor = true;
            btnEyeConfirm.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton2.ImageOptions.SvgImage");
            btnEyeConfirm.ImageOptions.SvgImageSize = new Size(16, 16);
            btnEyeConfirm.Location = new Point(379, 84);
            btnEyeConfirm.Name = "btnEyeConfirm";
            btnEyeConfirm.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnEyeConfirm.Size = new Size(25, 21);
            btnEyeConfirm.TabIndex = 10;
            btnEyeConfirm.Click += btnEyeConfirm_Click;
            // 
            // frmResetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 280);
            Controls.Add(groupControl2);
            Controls.Add(groupControl1);
            IconOptions.Image = Properties.Resources.vitapharm_transparent;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmResetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reset Password";
            Load += frmResetPassword_Load;
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtFullName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textUsername.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtConfirmNewPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNewPassword.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private DevExpress.XtraEditors.TextEdit textUsername;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtConfirmNewPassword;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtNewPassword;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnEye;
        private DevExpress.XtraEditors.SimpleButton btnEyeConfirm;
    }
}