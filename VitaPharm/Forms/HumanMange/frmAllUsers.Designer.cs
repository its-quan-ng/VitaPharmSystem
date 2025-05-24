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
            chkIsActive = new DevExpress.XtraEditors.CheckEdit();
            btnResetPassword = new DevExpress.XtraEditors.SimpleButton();
            txtAddress = new DevExpress.XtraEditors.TextEdit();
            dtpBirthday = new DevExpress.XtraEditors.DateEdit();
            chkFemale = new DevExpress.XtraEditors.CheckEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            txt = new DevExpress.XtraEditors.TextEdit();
            cboRole = new DevExpress.XtraEditors.ComboBoxEdit();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            txtContact = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            txtUserName = new DevExpress.XtraEditors.TextEdit();
            gridControl = new DevExpress.XtraGrid.GridControl();
            gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colID = new DevExpress.XtraGrid.Columns.GridColumn();
            colUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            colGender = new DevExpress.XtraGrid.Columns.GridColumn();
            colBirthday = new DevExpress.XtraGrid.Columns.GridColumn();
            colContact = new DevExpress.XtraGrid.Columns.GridColumn();
            colRole = new DevExpress.XtraGrid.Columns.GridColumn();
            colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            repochkEditIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            repotxtPassword = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            btnNewUser = new DevExpress.XtraEditors.SimpleButton();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            btnReload = new DevExpress.XtraEditors.SimpleButton();
            btnEdit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chkIsActive.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAddress.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtpBirthday.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtpBirthday.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkFemale.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboRole.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtContact.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUserName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repochkEditIsActive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repotxtPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.AppearanceCaption.Font = new Font("Inter", 7.8F, FontStyle.Bold);
            groupControl1.AppearanceCaption.ForeColor = Color.FromArgb(16, 53, 113);
            groupControl1.AppearanceCaption.Options.UseFont = true;
            groupControl1.AppearanceCaption.Options.UseForeColor = true;
            groupControl1.Controls.Add(chkIsActive);
            groupControl1.Controls.Add(btnResetPassword);
            groupControl1.Controls.Add(txtAddress);
            groupControl1.Controls.Add(dtpBirthday);
            groupControl1.Controls.Add(chkFemale);
            groupControl1.Controls.Add(labelControl5);
            groupControl1.Controls.Add(txt);
            groupControl1.Controls.Add(cboRole);
            groupControl1.Controls.Add(labelControl8);
            groupControl1.Controls.Add(labelControl4);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(txtContact);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Controls.Add(txtUserName);
            groupControl1.Dock = DockStyle.Top;
            groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            groupControl1.Location = new Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(828, 161);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "User Information";
            // 
            // chkIsActive
            // 
            chkIsActive.Location = new Point(541, 30);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Properties.Appearance.BackColor = Color.YellowGreen;
            chkIsActive.Properties.Appearance.Options.UseBackColor = true;
            chkIsActive.Properties.Caption = "Is Active?";
            chkIsActive.Size = new Size(81, 24);
            chkIsActive.TabIndex = 17;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetPassword.Appearance.Options.UseFont = true;
            btnResetPassword.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton1.ImageOptions.SvgImage");
            btnResetPassword.ImageOptions.SvgImageSize = new Size(20, 20);
            btnResetPassword.Location = new Point(678, 24);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnResetPassword.Size = new Size(138, 36);
            btnResetPassword.TabIndex = 16;
            btnResetPassword.Text = "Reset Password";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(389, 116);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(427, 22);
            txtAddress.TabIndex = 14;
            // 
            // dtpBirthday
            // 
            dtpBirthday.EditValue = null;
            dtpBirthday.Location = new Point(91, 116);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtpBirthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtpBirthday.Size = new Size(155, 22);
            dtpBirthday.TabIndex = 13;
            // 
            // chkFemale
            // 
            chkFemale.Location = new Point(606, 73);
            chkFemale.Name = "chkFemale";
            chkFemale.Properties.Caption = "Female";
            chkFemale.Size = new Size(128, 24);
            chkFemale.TabIndex = 12;
            // 
            // labelControl5
            // 
            labelControl5.Location = new Point(22, 119);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(51, 16);
            labelControl5.TabIndex = 6;
            labelControl5.Text = "Birthday:";
            // 
            // txt
            // 
            txt.Location = new Point(91, 74);
            txt.Name = "txt";
            txt.Size = new Size(189, 22);
            txt.TabIndex = 11;
            // 
            // cboRole
            // 
            cboRole.EditValue = "User";
            cboRole.Location = new Point(389, 31);
            cboRole.Name = "cboRole";
            cboRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboRole.Size = new Size(71, 22);
            cboRole.TabIndex = 10;
            // 
            // labelControl8
            // 
            labelControl8.Location = new Point(327, 34);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(30, 16);
            labelControl8.TabIndex = 9;
            labelControl8.Text = "Role:";
            // 
            // labelControl4
            // 
            labelControl4.Location = new Point(327, 119);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(51, 16);
            labelControl4.TabIndex = 5;
            labelControl4.Text = "Address:";
            // 
            // labelControl3
            // 
            labelControl3.Location = new Point(326, 77);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(52, 16);
            labelControl3.TabIndex = 4;
            labelControl3.Text = "Contact: ";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(389, 74);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(159, 22);
            txtContact.TabIndex = 3;
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(22, 77);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(62, 16);
            labelControl2.TabIndex = 2;
            labelControl2.Text = "Full Name:";
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(22, 34);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(63, 16);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "Username:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(91, 31);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(189, 22);
            txtUserName.TabIndex = 0;
            // 
            // gridControl
            // 
            gridControl.Dock = DockStyle.Fill;
            gridControl.Location = new Point(0, 161);
            gridControl.MainView = gridView;
            gridControl.Name = "gridControl";
            gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repochkEditIsActive, repotxtPassword });
            gridControl.Size = new Size(828, 235);
            gridControl.TabIndex = 1;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // gridView
            // 
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colID, colUsername, colFullName, colGender, colBirthday, colContact, colRole, colIsActive, colPassword });
            gridView.GridControl = gridControl;
            gridView.Name = "gridView";
            // 
            // colID
            // 
            colID.Caption = "ID";
            colID.FieldName = "AccountID";
            colID.MinWidth = 25;
            colID.Name = "colID";
            colID.OptionsColumn.AllowEdit = false;
            colID.Visible = true;
            colID.VisibleIndex = 0;
            colID.Width = 45;
            // 
            // colUsername
            // 
            colUsername.Caption = "Username";
            colUsername.FieldName = "Username";
            colUsername.MinWidth = 25;
            colUsername.Name = "colUsername";
            colUsername.OptionsColumn.AllowEdit = false;
            colUsername.Visible = true;
            colUsername.VisibleIndex = 1;
            colUsername.Width = 88;
            // 
            // colFullName
            // 
            colFullName.Caption = "Full Name";
            colFullName.FieldName = "EmployeeName";
            colFullName.MinWidth = 25;
            colFullName.Name = "colFullName";
            colFullName.OptionsColumn.AllowEdit = false;
            colFullName.Visible = true;
            colFullName.VisibleIndex = 2;
            colFullName.Width = 142;
            // 
            // colGender
            // 
            colGender.Caption = "Gender";
            colGender.FieldName = "Sex";
            colGender.MinWidth = 25;
            colGender.Name = "colGender";
            colGender.OptionsColumn.AllowEdit = false;
            colGender.Visible = true;
            colGender.VisibleIndex = 6;
            colGender.Width = 85;
            // 
            // colBirthday
            // 
            colBirthday.Caption = "Birthday";
            colBirthday.DisplayFormat.FormatString = "\"dd/MM/yyyy\"";
            colBirthday.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colBirthday.FieldName = "Birthday";
            colBirthday.MinWidth = 25;
            colBirthday.Name = "colBirthday";
            colBirthday.OptionsColumn.AllowEdit = false;
            colBirthday.Visible = true;
            colBirthday.VisibleIndex = 7;
            colBirthday.Width = 85;
            // 
            // colContact
            // 
            colContact.Caption = "Contact";
            colContact.FieldName = "Contact";
            colContact.MinWidth = 25;
            colContact.Name = "colContact";
            colContact.OptionsColumn.AllowEdit = false;
            colContact.Visible = true;
            colContact.VisibleIndex = 5;
            colContact.Width = 85;
            // 
            // colRole
            // 
            colRole.AccessibleDescription = "";
            colRole.Caption = "Role";
            colRole.FieldName = "UserRole";
            colRole.MinWidth = 25;
            colRole.Name = "colRole";
            colRole.Visible = true;
            colRole.VisibleIndex = 8;
            colRole.Width = 85;
            // 
            // colIsActive
            // 
            colIsActive.Caption = "IsActive";
            colIsActive.ColumnEdit = repochkEditIsActive;
            colIsActive.FieldName = "IsActive";
            colIsActive.MinWidth = 25;
            colIsActive.Name = "colIsActive";
            colIsActive.OptionsColumn.AllowEdit = false;
            colIsActive.Visible = true;
            colIsActive.VisibleIndex = 4;
            colIsActive.Width = 85;
            // 
            // repochkEditIsActive
            // 
            repochkEditIsActive.AutoHeight = false;
            repochkEditIsActive.Name = "repochkEditIsActive";
            // 
            // colPassword
            // 
            colPassword.AccessibleDescription = "";
            colPassword.Caption = "Password";
            colPassword.ColumnEdit = repotxtPassword;
            colPassword.FieldName = "UserPassword";
            colPassword.MinWidth = 25;
            colPassword.Name = "colPassword";
            colPassword.Visible = true;
            colPassword.VisibleIndex = 3;
            colPassword.Width = 98;
            // 
            // repotxtPassword
            // 
            repotxtPassword.AutoHeight = false;
            repotxtPassword.Name = "repotxtPassword";
            repotxtPassword.PasswordChar = '•';
            repotxtPassword.UseSystemPasswordChar = true;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(btnNewUser);
            panelControl1.Controls.Add(btnSave);
            panelControl1.Controls.Add(btnCancel);
            panelControl1.Controls.Add(btnReload);
            panelControl1.Controls.Add(btnEdit);
            panelControl1.Dock = DockStyle.Bottom;
            panelControl1.Location = new Point(0, 396);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(828, 64);
            panelControl1.TabIndex = 2;
            // 
            // btnNewUser
            // 
            btnNewUser.Appearance.BackColor = Color.FromArgb(100, 165, 80);
            btnNewUser.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnNewUser.Appearance.Options.UseBackColor = true;
            btnNewUser.Appearance.Options.UseFont = true;
            btnNewUser.Location = new Point(5, 16);
            btnNewUser.Name = "btnNewUser";
            btnNewUser.Size = new Size(118, 36);
            btnNewUser.TabIndex = 11;
            btnNewUser.Text = "New User";
            // 
            // btnSave
            // 
            btnSave.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            btnSave.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnSave.Appearance.Options.UseBackColor = true;
            btnSave.Appearance.Options.UseFont = true;
            btnSave.Location = new Point(450, 16);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 36);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            // 
            // btnCancel
            // 
            btnCancel.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            btnCancel.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnCancel.Appearance.Options.UseBackColor = true;
            btnCancel.Appearance.Options.UseFont = true;
            btnCancel.Location = new Point(698, 16);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 36);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            // 
            // btnReload
            // 
            btnReload.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            btnReload.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnReload.Appearance.Options.UseBackColor = true;
            btnReload.Appearance.Options.UseFont = true;
            btnReload.Location = new Point(574, 16);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(118, 36);
            btnReload.TabIndex = 8;
            btnReload.Text = "Reload";
            // 
            // btnEdit
            // 
            btnEdit.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            btnEdit.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnEdit.Appearance.Options.UseBackColor = true;
            btnEdit.Appearance.Options.UseFont = true;
            btnEdit.Location = new Point(129, 16);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(118, 36);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            // 
            // frmAllUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 460);
            Controls.Add(gridControl);
            Controls.Add(panelControl1);
            Controls.Add(groupControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmAllUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "All Users";
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chkIsActive.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAddress.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtpBirthday.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtpBirthday.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkFemale.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboRole.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtContact.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUserName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)repochkEditIsActive).EndInit();
            ((System.ComponentModel.ISupportInitialize)repotxtPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtContact;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ComboBoxEdit cboRole;
        private DevExpress.XtraEditors.TextEdit txt;
        private DevExpress.XtraEditors.CheckEdit chkFemale;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.DateEdit dtpBirthday;
        private DevExpress.XtraEditors.SimpleButton btnResetPassword;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colUsername;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colGender;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthday;
        private DevExpress.XtraGrid.Columns.GridColumn colContact;
        private DevExpress.XtraGrid.Columns.GridColumn colRole;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repochkEditIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repotxtPassword;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.CheckEdit chkIsActive;
        private DevExpress.XtraEditors.SimpleButton btnNewUser;
    }
}