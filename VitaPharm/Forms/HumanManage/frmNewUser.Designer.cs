namespace VitaPharm.Forms.HumanManage
{
    partial class frmNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewUser));
            chkIsActive = new DevExpress.XtraEditors.CheckEdit();
            dtpBirthday = new DevExpress.XtraEditors.DateEdit();
            chkFemale = new DevExpress.XtraEditors.CheckEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            txtName = new DevExpress.XtraEditors.TextEdit();
            cboRole = new DevExpress.XtraEditors.ComboBoxEdit();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            txtContact = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            txtUsername = new DevExpress.XtraEditors.TextEdit();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtAddress = new DevExpress.XtraEditors.TextEdit();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)chkIsActive.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtpBirthday.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtpBirthday.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkFemale.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboRole.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtContact.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtAddress.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            SuspendLayout();
            // 
            // chkIsActive
            // 
            chkIsActive.Location = new Point(374, 117);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Properties.Appearance.BackColor = Color.YellowGreen;
            chkIsActive.Properties.Appearance.Options.UseBackColor = true;
            chkIsActive.Properties.Caption = "Is Active?";
            chkIsActive.Size = new Size(81, 24);
            chkIsActive.TabIndex = 5;
            // 
            // dtpBirthday
            // 
            dtpBirthday.EditValue = null;
            dtpBirthday.Location = new Point(174, 189);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtpBirthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtpBirthday.Size = new Size(150, 22);
            dtpBirthday.TabIndex = 7;
            // 
            // chkFemale
            // 
            chkFemale.Location = new Point(374, 188);
            chkFemale.Name = "chkFemale";
            chkFemale.Properties.Caption = "Female";
            chkFemale.Size = new Size(81, 24);
            chkFemale.TabIndex = 8;
            // 
            // labelControl5
            // 
            labelControl5.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            labelControl5.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("labelControl5.ImageOptions.SvgImage");
            labelControl5.ImageOptions.SvgImageSize = new Size(16, 16);
            labelControl5.Location = new Point(23, 188);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(77, 24);
            labelControl5.TabIndex = 24;
            labelControl5.Text = "Birthday:";
            // 
            // txtName
            // 
            txtName.Location = new Point(174, 154);
            txtName.Name = "txtName";
            txtName.Size = new Size(281, 22);
            txtName.TabIndex = 6;
            // 
            // cboRole
            // 
            cboRole.EditValue = "";
            cboRole.Location = new Point(174, 119);
            cboRole.Name = "cboRole";
            cboRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboRole.Size = new Size(66, 22);
            cboRole.TabIndex = 4;
            // 
            // labelControl8
            // 
            labelControl8.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            labelControl8.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("labelControl8.ImageOptions.SvgImage");
            labelControl8.ImageOptions.SvgImageSize = new Size(16, 16);
            labelControl8.Location = new Point(22, 116);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(56, 24);
            labelControl8.TabIndex = 25;
            labelControl8.Text = "Role:";
            // 
            // labelControl4
            // 
            labelControl4.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            labelControl4.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("labelControl4.ImageOptions.SvgImage");
            labelControl4.ImageOptions.SvgImageSize = new Size(16, 16);
            labelControl4.Location = new Point(22, 260);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(77, 24);
            labelControl4.TabIndex = 23;
            labelControl4.Text = "Address:";
            // 
            // labelControl3
            // 
            labelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            labelControl3.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("labelControl3.ImageOptions.SvgImage");
            labelControl3.ImageOptions.SvgImageSize = new Size(16, 16);
            labelControl3.Location = new Point(22, 224);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(78, 24);
            labelControl3.TabIndex = 22;
            labelControl3.Text = "Contact: ";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(174, 224);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(154, 22);
            txtContact.TabIndex = 9;
            // 
            // labelControl2
            // 
            labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            labelControl2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("labelControl2.ImageOptions.SvgImage");
            labelControl2.ImageOptions.SvgImageSize = new Size(16, 16);
            labelControl2.Location = new Point(23, 152);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(88, 24);
            labelControl2.TabIndex = 20;
            labelControl2.Text = "Full Name:";
            // 
            // labelControl1
            // 
            labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            labelControl1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("labelControl1.ImageOptions.SvgImage");
            labelControl1.ImageOptions.SvgImageSize = new Size(16, 16);
            labelControl1.Location = new Point(22, 8);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(89, 24);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(174, 12);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(281, 22);
            txtUsername.TabIndex = 1;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(txtConfirmPassword);
            panelControl1.Controls.Add(txtPassword);
            panelControl1.Controls.Add(txtAddress);
            panelControl1.Controls.Add(dtpBirthday);
            panelControl1.Controls.Add(labelControl7);
            panelControl1.Controls.Add(labelControl5);
            panelControl1.Controls.Add(labelControl4);
            panelControl1.Controls.Add(labelControl6);
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Controls.Add(chkIsActive);
            panelControl1.Controls.Add(chkFemale);
            panelControl1.Controls.Add(txtUsername);
            panelControl1.Controls.Add(cboRole);
            panelControl1.Controls.Add(txtName);
            panelControl1.Controls.Add(labelControl3);
            panelControl1.Controls.Add(labelControl8);
            panelControl1.Controls.Add(txtContact);
            panelControl1.Controls.Add(labelControl2);
            panelControl1.Dock = DockStyle.Fill;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(519, 372);
            panelControl1.TabIndex = 33;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.White;
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Location = new Point(174, 83);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(144, 23);
            txtConfirmPassword.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(174, 47);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(144, 23);
            txtPassword.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(174, 259);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(281, 22);
            txtAddress.TabIndex = 10;
            // 
            // labelControl7
            // 
            labelControl7.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            labelControl7.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("labelControl7.ImageOptions.SvgImage");
            labelControl7.ImageOptions.SvgImageSize = new Size(16, 16);
            labelControl7.Location = new Point(22, 80);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(135, 24);
            labelControl7.TabIndex = 35;
            labelControl7.Text = "Confirm Password:";
            // 
            // labelControl6
            // 
            labelControl6.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            labelControl6.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("labelControl6.ImageOptions.SvgImage");
            labelControl6.ImageOptions.SvgImageSize = new Size(16, 16);
            labelControl6.Location = new Point(22, 44);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(86, 24);
            labelControl6.TabIndex = 33;
            labelControl6.Text = "Password:";
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(btnCancel);
            panelControl2.Controls.Add(btnAdd);
            panelControl2.Dock = DockStyle.Bottom;
            panelControl2.Location = new Point(0, 308);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(519, 64);
            panelControl2.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            btnCancel.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Appearance.Options.UseBackColor = true;
            btnCancel.Appearance.Options.UseFont = true;
            btnCancel.Location = new Point(226, 18);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(84, 28);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            btnAdd.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Appearance.Options.UseBackColor = true;
            btnAdd.Appearance.Options.UseFont = true;
            btnAdd.Location = new Point(130, 18);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(81, 28);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // frmNewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 372);
            Controls.Add(panelControl2);
            Controls.Add(panelControl1);
            Name = "frmNewUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New User";
            Load += frmNewUser_Load;
            Click += frmNewUser_Load;
            ((System.ComponentModel.ISupportInitialize)chkIsActive.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtpBirthday.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtpBirthday.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkFemale.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboRole.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtContact.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtAddress.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit chkIsActive;
        private DevExpress.XtraEditors.DateEdit dtpBirthday;
        private DevExpress.XtraEditors.CheckEdit chkFemale;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.ComboBoxEdit cboRole;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtContact;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
    }
}