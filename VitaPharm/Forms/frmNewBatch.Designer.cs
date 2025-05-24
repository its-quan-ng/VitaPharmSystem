namespace VitaPharm.Forms
{
    partial class frmNewBatch
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
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            cboCommodity = new DevExpress.XtraEditors.ComboBoxEdit();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cboCommodity.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit2.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spinEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(btnCancel);
            groupControl1.Controls.Add(btnAdd);
            groupControl1.Controls.Add(textEdit3);
            groupControl1.Controls.Add(textEdit2);
            groupControl1.Controls.Add(spinEdit1);
            groupControl1.Controls.Add(dateEdit2);
            groupControl1.Controls.Add(dateEdit1);
            groupControl1.Controls.Add(textEdit1);
            groupControl1.Controls.Add(cboCommodity);
            groupControl1.Controls.Add(labelControl7);
            groupControl1.Controls.Add(labelControl6);
            groupControl1.Controls.Add(labelControl5);
            groupControl1.Controls.Add(labelControl4);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Dock = DockStyle.Fill;
            groupControl1.Location = new Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(440, 382);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "Add Batch";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(40, 51);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(76, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Commodity:";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(40, 92);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(78, 16);
            labelControl2.TabIndex = 0;
            labelControl2.Text = "Batch Code:";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(40, 133);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(64, 16);
            labelControl3.TabIndex = 1;
            labelControl3.Text = "Mfg Date:";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(40, 174);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(62, 16);
            labelControl4.TabIndex = 1;
            labelControl4.Text = "Exp Date:";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(40, 215);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(61, 16);
            labelControl5.TabIndex = 2;
            labelControl5.Text = "Quantity:";
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new Point(40, 256);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(101, 16);
            labelControl6.TabIndex = 2;
            labelControl6.Text = "Purchase Price:";
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Location = new Point(40, 297);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(51, 16);
            labelControl7.TabIndex = 2;
            labelControl7.Text = "Amount";
            // 
            // cboCommodity
            // 
            cboCommodity.Location = new Point(147, 48);
            cboCommodity.Name = "cboCommodity";
            cboCommodity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboCommodity.Size = new Size(262, 22);
            cboCommodity.TabIndex = 3;
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(147, 89);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(156, 22);
            textEdit1.TabIndex = 4;
            // 
            // dateEdit1
            // 
            dateEdit1.EditValue = null;
            dateEdit1.Location = new Point(147, 130);
            dateEdit1.Name = "dateEdit1";
            dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Size = new Size(156, 22);
            dateEdit1.TabIndex = 5;
            // 
            // dateEdit2
            // 
            dateEdit2.EditValue = null;
            dateEdit2.Location = new Point(147, 171);
            dateEdit2.Name = "dateEdit2";
            dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit2.Size = new Size(156, 22);
            dateEdit2.TabIndex = 5;
            // 
            // spinEdit1
            // 
            spinEdit1.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spinEdit1.Location = new Point(147, 252);
            spinEdit1.Name = "spinEdit1";
            spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spinEdit1.Size = new Size(156, 24);
            spinEdit1.TabIndex = 6;
            // 
            // textEdit2
            // 
            textEdit2.Location = new Point(147, 212);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new Size(156, 22);
            textEdit2.TabIndex = 7;
            // 
            // textEdit3
            // 
            textEdit3.Location = new Point(147, 294);
            textEdit3.Name = "textEdit3";
            textEdit3.Size = new Size(156, 22);
            textEdit3.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Appearance.BackColor = Color.FromArgb(100, 165, 80);
            btnAdd.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Appearance.Options.UseBackColor = true;
            btnAdd.Appearance.Options.UseFont = true;
            btnAdd.Location = new Point(84, 338);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 31);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            // 
            // btnCancel
            // 
            btnCancel.Appearance.BackColor = Color.FromArgb(195, 49, 49);
            btnCancel.Appearance.FontStyleDelta = FontStyle.Bold;
            btnCancel.Appearance.Options.UseBackColor = true;
            btnCancel.Appearance.Options.UseFont = true;
            btnCancel.Location = new Point(248, 338);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(109, 31);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            // 
            // frmNewBatch
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 382);
            Controls.Add(groupControl1);
            Name = "frmNewBatch";
            Text = "frmNewBatch";
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cboCommodity.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit2.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spinEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cboCommodity;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
    }
}