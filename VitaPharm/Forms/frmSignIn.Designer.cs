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
            textBox2 = new TextBox();
            pictureBox3 = new PictureBox();
            checkButton1 = new DevExpress.XtraEditors.CheckButton();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Inter Semi Bold", 12F, FontStyle.Bold);
            textBox2.ForeColor = Color.FromArgb(16, 53, 113);
            textBox2.Location = new Point(92, 226);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(397, 43);
            textBox2.TabIndex = 10;
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
            // checkButton1
            // 
            checkButton1.Location = new Point(337, 275);
            checkButton1.Name = "checkButton1";
            checkButton1.Size = new Size(20, 20);
            checkButton1.TabIndex = 5;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Inter Semi Bold", 9F, FontStyle.Bold | FontStyle.Italic);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(363, 277);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(117, 18);
            labelControl1.TabIndex = 6;
            labelControl1.Text = "Show password";
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.BackColor = Color.FromArgb(16, 53, 113);
            simpleButton1.Appearance.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            simpleButton1.Appearance.Options.UseBackColor = true;
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.AppearanceHovered.BackColor = Color.FromArgb(170, 188, 217);
            simpleButton1.AppearanceHovered.Options.UseBackColor = true;
            simpleButton1.Location = new Point(49, 314);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(440, 50);
            simpleButton1.TabIndex = 7;
            simpleButton1.Text = "Sign In";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl2.Appearance.ForeColor = Color.FromArgb(66, 176, 109);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new Point(251, 380);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(36, 24);
            labelControl2.TabIndex = 8;
            labelControl2.Text = "Exit";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Inter Semi Bold", 12F, FontStyle.Bold);
            textBox1.ForeColor = Color.FromArgb(16, 53, 113);
            textBox1.Location = new Point(90, 145);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(396, 39);
            textBox1.TabIndex = 9;
            // 
            // frmSignIn
            // 
            Appearance.BackColor = SystemColors.Window;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 416);
            Controls.Add(labelControl2);
            Controls.Add(simpleButton1);
            Controls.Add(labelControl1);
            Controls.Add(checkButton1);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign In";
            Load += frmSignIn_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}