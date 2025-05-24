namespace VitaPharm.Forms
{
    partial class frmSignIn
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            txtPassword = new TextBox();
            pictureBox3 = new PictureBox();
            btnSignIn = new DevExpress.XtraEditors.SimpleButton();
            lblExit = new DevExpress.XtraEditors.LabelControl();
            txtUsername = new TextBox();
            chkShowPassword = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkShowPassword.Properties).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.vitapharm_transparent;
            pictureBox1.Location = new Point(206, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(49, 135);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(61, 189, 236);
            panel1.Location = new Point(49, 172);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 2);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(61, 189, 236);
            panel2.Location = new Point(49, 250);
            panel2.Name = "panel2";
            panel2.Size = new Size(440, 2);
            panel2.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Inter Semi Bold", 12F, FontStyle.Bold);
            txtPassword.ForeColor = Color.FromArgb(16, 53, 113);
            txtPassword.Location = new Point(92, 226);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(397, 43);
            txtPassword.TabIndex = 10;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._lock;
            pictureBox3.Location = new Point(44, 206);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 51);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // btnSignIn
            // 
            btnSignIn.Appearance.BackColor = Color.FromArgb(16, 53, 113);
            btnSignIn.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.Appearance.Options.UseBackColor = true;
            btnSignIn.Appearance.Options.UseFont = true;
            btnSignIn.AppearanceHovered.BackColor = Color.FromArgb(170, 188, 217);
            btnSignIn.AppearanceHovered.Options.UseBackColor = true;
            btnSignIn.Location = new Point(147, 312);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(254, 50);
            btnSignIn.TabIndex = 7;
            btnSignIn.Text = "Sign In";
            // 
            // lblExit
            // 
            lblExit.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit.Appearance.ForeColor = Color.FromArgb(66, 176, 109);
            lblExit.Appearance.Options.UseFont = true;
            lblExit.Appearance.Options.UseForeColor = true;
            lblExit.Location = new Point(249, 380);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(37, 25);
            lblExit.TabIndex = 8;
            lblExit.Text = "Exit";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Inter Semi Bold", 12F, FontStyle.Bold);
            txtUsername.ForeColor = Color.FromArgb(16, 53, 113);
            txtUsername.Location = new Point(90, 145);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(396, 39);
            txtUsername.TabIndex = 9;
            // 
            // chkShowPassword
            // 
            chkShowPassword.Location = new Point(344, 258);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Properties.Appearance.Font = new Font("Inter Semi Bold", 9F, FontStyle.Bold | FontStyle.Italic);
            chkShowPassword.Properties.Appearance.Options.UseFont = true;
            chkShowPassword.Properties.Caption = "Show password";
            chkShowPassword.Size = new Size(145, 24);
            chkShowPassword.TabIndex = 11;
            // 
            // frmSignIn
            // 
            Appearance.BackColor = SystemColors.Window;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 416);
            Controls.Add(chkShowPassword);
            Controls.Add(lblExit);
            Controls.Add(btnSignIn);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign In";
            Load += frmSignIn_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkShowPassword.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private DevExpress.XtraEditors.CheckButton checkButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSignIn;
        private DevExpress.XtraEditors.LabelControl lblExit;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private DevExpress.XtraEditors.CheckEdit chkShowPassword;
    }
}