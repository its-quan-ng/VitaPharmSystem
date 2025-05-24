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
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            checkButton1 = new DevExpress.XtraEditors.CheckButton();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            textEdit4 = new DevExpress.XtraEditors.TextEdit();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colID = new DevExpress.XtraGrid.Columns.GridColumn();
            colUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            colGender = new DevExpress.XtraGrid.Columns.GridColumn();
            colBirthday = new DevExpress.XtraGrid.Columns.GridColumn();
            colContact = new DevExpress.XtraGrid.Columns.GridColumn();
            colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            repochkEditIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            repotxtPassword = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            colRole = new DevExpress.XtraGrid.Columns.GridColumn();
            colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repochkEditIsActive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repotxtPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.AppearanceCaption.Font = new Font("Inter", 7.8F, FontStyle.Bold);
            groupControl1.AppearanceCaption.ForeColor = Color.FromArgb(16, 53, 113);
            groupControl1.AppearanceCaption.Options.UseFont = true;
            groupControl1.AppearanceCaption.Options.UseForeColor = true;
            groupControl1.Controls.Add(simpleButton1);
            groupControl1.Controls.Add(textEdit4);
            groupControl1.Controls.Add(dateEdit1);
            groupControl1.Controls.Add(checkEdit1);
            groupControl1.Controls.Add(labelControl5);
            groupControl1.Controls.Add(textEdit3);
            groupControl1.Controls.Add(comboBoxEdit1);
            groupControl1.Controls.Add(checkButton1);
            groupControl1.Controls.Add(labelControl8);
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
            // textEdit3
            // 
            textEdit3.Location = new Point(91, 71);
            textEdit3.Name = "textEdit3";
            textEdit3.Size = new Size(189, 22);
            textEdit3.TabIndex = 11;
            // 
            // comboBoxEdit1
            // 
            comboBoxEdit1.EditValue = "User";
            comboBoxEdit1.Location = new Point(389, 30);
            comboBoxEdit1.Name = "comboBoxEdit1";
            comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxEdit1.Size = new Size(71, 22);
            comboBoxEdit1.TabIndex = 10;
            // 
            // checkButton1
            // 
            checkButton1.ImageOptions.Image = (Image)resources.GetObject("checkButton1.ImageOptions.Image");
            checkButton1.ImageOptions.SvgImageSize = new Size(20, 20);
            checkButton1.Location = new Point(533, 23);
            checkButton1.Name = "checkButton1";
            checkButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            checkButton1.Size = new Size(100, 30);
            checkButton1.TabIndex = 1;
            checkButton1.Text = "Is Active?";
            // 
            // labelControl8
            // 
            labelControl8.Location = new Point(327, 36);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(30, 16);
            labelControl8.TabIndex = 9;
            labelControl8.Text = "Role:";
            // 
            // labelControl5
            // 
            labelControl5.Location = new Point(22, 119);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(51, 16);
            labelControl5.TabIndex = 6;
            labelControl5.Text = "Birthday:";
            // 
            // labelControl4
            // 
            labelControl4.Location = new Point(327, 122);
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
            // textEdit2
            // 
            textEdit2.Location = new Point(389, 71);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new Size(159, 22);
            textEdit2.TabIndex = 3;
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
            // textEdit1
            // 
            textEdit1.Location = new Point(91, 31);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(189, 22);
            textEdit1.TabIndex = 0;
            // 
            // checkEdit1
            // 
            checkEdit1.Location = new Point(606, 69);
            checkEdit1.Name = "checkEdit1";
            checkEdit1.Properties.Caption = "Female";
            checkEdit1.Size = new Size(128, 24);
            checkEdit1.TabIndex = 12;
            // 
            // dateEdit1
            // 
            dateEdit1.EditValue = null;
            dateEdit1.Location = new Point(91, 116);
            dateEdit1.Name = "dateEdit1";
            dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Size = new Size(155, 22);
            dateEdit1.TabIndex = 13;
            // 
            // textEdit4
            // 
            textEdit4.Location = new Point(389, 113);
            textEdit4.Name = "textEdit4";
            textEdit4.Size = new Size(345, 22);
            textEdit4.TabIndex = 14;
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton1.ImageOptions.SvgImage");
            simpleButton1.ImageOptions.SvgImageSize = new Size(20, 20);
            simpleButton1.Location = new Point(678, 23);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton1.Size = new Size(138, 36);
            simpleButton1.TabIndex = 16;
            simpleButton1.Text = "Reset Password";
            // 
            // gridControl1
            // 
            gridControl1.Location = new Point(12, 167);
            gridControl1.MainView = gridView;
            gridControl1.Name = "gridControl1";
            gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repochkEditIsActive, repotxtPassword });
            gridControl1.Size = new Size(500, 215);
            gridControl1.TabIndex = 1;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // gridView
            // 
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colID, colUsername, colFullName, colGender, colBirthday, colContact, colRole, colIsActive, colPassword });
            gridView.GridControl = gridControl1;
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
            colID.Width = 94;
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
            colUsername.Width = 94;
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
            colFullName.Width = 94;
            // 
            // colGender
            // 
            colGender.Caption = "Gender";
            colGender.FieldName = "Sex";
            colGender.MinWidth = 25;
            colGender.Name = "colGender";
            colGender.OptionsColumn.AllowEdit = false;
            colGender.Visible = true;
            colGender.VisibleIndex = 3;
            colGender.Width = 94;
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
            colBirthday.VisibleIndex = 4;
            colBirthday.Width = 94;
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
            colContact.Width = 94;
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
            colIsActive.VisibleIndex = 6;
            colIsActive.Width = 94;
            // 
            // repochkEditIsActive
            // 
            repochkEditIsActive.AutoHeight = false;
            repochkEditIsActive.Name = "repochkEditIsActive";
            // 
            // repotxtPassword
            // 
            repotxtPassword.AutoHeight = false;
            repotxtPassword.Name = "repotxtPassword";
            repotxtPassword.PasswordChar = '•';
            repotxtPassword.UseSystemPasswordChar = true;
            // 
            // colRole
            // 
            colRole.AccessibleDescription = "";
            colRole.Caption = "Role";
            colRole.FieldName = "UserRole";
            colRole.MinWidth = 25;
            colRole.Name = "colRole";
            colRole.Visible = true;
            colRole.VisibleIndex = 7;
            colRole.Width = 94;
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
            colPassword.VisibleIndex = 8;
            colPassword.Width = 94;
            // 
            // panelControl1
            // 
            panelControl1.Dock = DockStyle.Bottom;
            panelControl1.Location = new Point(0, 396);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(828, 64);
            panelControl1.TabIndex = 2;
            // 
            // frmAllUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 460);
            Controls.Add(panelControl1);
            Controls.Add(gridControl1);
            Controls.Add(groupControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmAllUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAllUsers";
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)repochkEditIsActive).EndInit();
            ((System.ComponentModel.ISupportInitialize)repotxtPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.CheckButton checkButton1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
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
    }
}