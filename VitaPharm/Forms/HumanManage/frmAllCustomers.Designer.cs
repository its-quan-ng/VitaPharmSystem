namespace VitaPharm.Forms
{
    partial class frmAllCustomers
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
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            groupControl = new DevExpress.XtraEditors.GroupControl();
            txtAddress = new DevExpress.XtraEditors.TextEdit();
            chkFemale = new DevExpress.XtraEditors.CheckEdit();
            txtFullName = new DevExpress.XtraEditors.TextEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            txtContact = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            btnDelete = new DevExpress.XtraEditors.SimpleButton();
            btnReload = new DevExpress.XtraEditors.SimpleButton();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            btnEdit = new DevExpress.XtraEditors.SimpleButton();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
            panelControl3 = new DevExpress.XtraEditors.PanelControl();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colID = new DevExpress.XtraGrid.Columns.GridColumn();
            colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            colSex = new DevExpress.XtraGrid.Columns.GridColumn();
            colContact = new DevExpress.XtraGrid.Columns.GridColumn();
            colCustomerAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl).BeginInit();
            groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtAddress.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkFemale.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFullName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtContact.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl3).BeginInit();
            panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(groupControl);
            panelControl1.Dock = DockStyle.Top;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(623, 162);
            panelControl1.TabIndex = 0;
            // 
            // groupControl
            // 
            groupControl.AppearanceCaption.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            groupControl.AppearanceCaption.ForeColor = Color.FromArgb(16, 53, 113);
            groupControl.AppearanceCaption.Options.UseFont = true;
            groupControl.AppearanceCaption.Options.UseForeColor = true;
            groupControl.Controls.Add(txtAddress);
            groupControl.Controls.Add(chkFemale);
            groupControl.Controls.Add(txtFullName);
            groupControl.Controls.Add(labelControl4);
            groupControl.Controls.Add(labelControl3);
            groupControl.Controls.Add(txtContact);
            groupControl.Controls.Add(labelControl2);
            groupControl.Dock = DockStyle.Fill;
            groupControl.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            groupControl.Location = new Point(2, 2);
            groupControl.Name = "groupControl";
            groupControl.Size = new Size(619, 158);
            groupControl.TabIndex = 1;
            groupControl.Text = "Customer Information";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(91, 113);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(457, 22);
            txtAddress.TabIndex = 6;
            // 
            // chkFemale
            // 
            chkFemale.Location = new Point(420, 30);
            chkFemale.Name = "chkFemale";
            chkFemale.Properties.Caption = "Female";
            chkFemale.Size = new Size(128, 24);
            chkFemale.TabIndex = 4;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(91, 31);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(189, 22);
            txtFullName.TabIndex = 3;
            // 
            // labelControl4
            // 
            labelControl4.Location = new Point(22, 116);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(51, 16);
            labelControl4.TabIndex = 0;
            labelControl4.Text = "Address:";
            // 
            // labelControl3
            // 
            labelControl3.Location = new Point(22, 75);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(52, 16);
            labelControl3.TabIndex = 0;
            labelControl3.Text = "Contact: ";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(91, 72);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(189, 22);
            txtContact.TabIndex = 5;
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(22, 34);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(62, 16);
            labelControl2.TabIndex = 0;
            labelControl2.Text = "Full Name:";
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(btnDelete);
            panelControl2.Controls.Add(btnReload);
            panelControl2.Controls.Add(btnSave);
            panelControl2.Controls.Add(btnEdit);
            panelControl2.Controls.Add(btnAdd);
            panelControl2.Dock = DockStyle.Bottom;
            panelControl2.Location = new Point(0, 343);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(623, 66);
            panelControl2.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Appearance.BackColor = Color.FromArgb(195, 49, 49);
            btnDelete.Appearance.FontStyleDelta = FontStyle.Bold;
            btnDelete.Appearance.Options.UseBackColor = true;
            btnDelete.Appearance.Options.UseFont = true;
            btnDelete.Location = new Point(477, 18);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 30);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            // 
            // btnReload
            // 
            btnReload.Appearance.FontStyleDelta = FontStyle.Bold;
            btnReload.Appearance.Options.UseFont = true;
            btnReload.Location = new Point(367, 18);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(102, 30);
            btnReload.TabIndex = 3;
            btnReload.Text = "Reload";
            // 
            // btnSave
            // 
            btnSave.Appearance.BackColor = Color.FromArgb(254, 145, 19);
            btnSave.Appearance.FontStyleDelta = FontStyle.Bold;
            btnSave.Appearance.Options.UseBackColor = true;
            btnSave.Appearance.Options.UseFont = true;
            btnSave.Location = new Point(259, 18);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(102, 30);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            // 
            // btnEdit
            // 
            btnEdit.Appearance.BackColor = Color.FromArgb(29, 22, 80);
            btnEdit.Appearance.FontStyleDelta = FontStyle.Bold;
            btnEdit.Appearance.Options.UseBackColor = true;
            btnEdit.Appearance.Options.UseFont = true;
            btnEdit.Location = new Point(151, 18);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(102, 30);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            // 
            // btnAdd
            // 
            btnAdd.Appearance.BackColor = Color.FromArgb(100, 165, 80);
            btnAdd.Appearance.FontStyleDelta = FontStyle.Bold;
            btnAdd.Appearance.Options.UseBackColor = true;
            btnAdd.Appearance.Options.UseFont = true;
            btnAdd.Location = new Point(43, 18);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 30);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            // 
            // panelControl3
            // 
            panelControl3.Controls.Add(gridControl1);
            panelControl3.Dock = DockStyle.Fill;
            panelControl3.Location = new Point(0, 162);
            panelControl3.Name = "panelControl3";
            panelControl3.Size = new Size(623, 181);
            panelControl3.TabIndex = 2;
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(2, 2);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(619, 177);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colID, colCustomerName, colSex, colContact, colCustomerAddress });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // colID
            // 
            colID.Caption = "ID";
            colID.FieldName = "ID";
            colID.MinWidth = 25;
            colID.Name = "colID";
            colID.Visible = true;
            colID.VisibleIndex = 0;
            colID.Width = 94;
            // 
            // colCustomerName
            // 
            colCustomerName.Caption = "Customer";
            colCustomerName.FieldName = "CustomerName";
            colCustomerName.MinWidth = 25;
            colCustomerName.Name = "colCustomerName";
            colCustomerName.Visible = true;
            colCustomerName.VisibleIndex = 1;
            colCustomerName.Width = 94;
            // 
            // colSex
            // 
            colSex.Caption = "Sex";
            colSex.FieldName = "Sex";
            colSex.MinWidth = 25;
            colSex.Name = "colSex";
            colSex.Visible = true;
            colSex.VisibleIndex = 2;
            colSex.Width = 94;
            // 
            // colContact
            // 
            colContact.Caption = "Contact";
            colContact.FieldName = "Contact";
            colContact.MinWidth = 25;
            colContact.Name = "colContact";
            colContact.Visible = true;
            colContact.VisibleIndex = 3;
            colContact.Width = 94;
            // 
            // colCustomerAddress
            // 
            colCustomerAddress.Caption = "Customer Address";
            colCustomerAddress.FieldName = "CustomerAddress";
            colCustomerAddress.MinWidth = 25;
            colCustomerAddress.Name = "colCustomerAddress";
            colCustomerAddress.Visible = true;
            colCustomerAddress.VisibleIndex = 4;
            colCustomerAddress.Width = 94;
            // 
            // frmAllCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 409);
            Controls.Add(panelControl3);
            Controls.Add(panelControl2);
            Controls.Add(panelControl1);
            Name = "frmAllCustomers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "All Customers";
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl).EndInit();
            groupControl.ResumeLayout(false);
            groupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtAddress.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkFemale.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFullName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtContact.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl3).EndInit();
            panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.CheckEdit chkFemale;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtContact;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colSex;
        private DevExpress.XtraGrid.Columns.GridColumn colContact;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerAddress;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
    }
}