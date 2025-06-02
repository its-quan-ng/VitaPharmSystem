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
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.Location = new Point(79, 12);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(250, 125);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "groupControl1";
            // 
            // frmResetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 296);
            Controls.Add(groupControl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmResetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reset Password";
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}