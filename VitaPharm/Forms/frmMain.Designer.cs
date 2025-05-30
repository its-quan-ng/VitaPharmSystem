namespace VitaPharm.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            btnProfile = new DevExpress.XtraBars.BarButtonItem();
            btnNewUser = new DevExpress.XtraBars.BarButtonItem();
            btnAllUsers = new DevExpress.XtraBars.BarButtonItem();
            btnAllCustomers = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            btnAllCommodities = new DevExpress.XtraBars.BarButtonItem();
            btnNewReceipt = new DevExpress.XtraBars.BarButtonItem();
            btnAllGoodsReceipt = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            btnSignOut = new DevExpress.XtraBars.BarButtonItem();
            tabHumanManage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            tabCommodity = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            tabGoodReceipt = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.BackColor = Color.White;
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, btnProfile, btnNewUser, btnAllUsers, btnAllCustomers, barButtonItem5, btnAllCommodities, btnNewReceipt, btnAllGoodsReceipt, barButtonItem9, barButtonItem10, btnSignOut });
            ribbonControl1.Location = new Point(0, 0);
            ribbonControl1.MaxItemId = 12;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { tabHumanManage, tabCommodity, tabGoodReceipt, ribbonPage1 });
            ribbonControl1.Size = new Size(1278, 183);
            // 
            // btnProfile
            // 
            btnProfile.Caption = "Profile";
            btnProfile.Id = 1;
            btnProfile.ImageOptions.LargeImage = (Image)resources.GetObject("btnProfile.ImageOptions.LargeImage");
            btnProfile.Name = "btnProfile";
            btnProfile.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnProfile.ItemClick += btnProfile_ItemClick;
            // 
            // btnNewUser
            // 
            btnNewUser.Caption = "New User";
            btnNewUser.Id = 2;
            btnNewUser.ImageOptions.LargeImage = (Image)resources.GetObject("btnNewUser.ImageOptions.LargeImage");
            btnNewUser.Name = "btnNewUser";
            btnNewUser.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnNewUser.ItemClick += btnNewUser_ItemClick;
            // 
            // btnAllUsers
            // 
            btnAllUsers.Caption = "All Users";
            btnAllUsers.Id = 3;
            btnAllUsers.ImageOptions.LargeImage = (Image)resources.GetObject("btnAllUsers.ImageOptions.LargeImage");
            btnAllUsers.Name = "btnAllUsers";
            btnAllUsers.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnAllUsers.ItemClick += btnAllUsers_ItemClick;
            // 
            // btnAllCustomers
            // 
            btnAllCustomers.Caption = "All Customers";
            btnAllCustomers.Id = 4;
            btnAllCustomers.ImageOptions.LargeImage = (Image)resources.GetObject("btnAllCustomers.ImageOptions.LargeImage");
            btnAllCustomers.Name = "btnAllCustomers";
            btnAllCustomers.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnAllCustomers.ItemClick += btnAllCustomers_ItemClick;
            // 
            // barButtonItem5
            // 
            barButtonItem5.Caption = "New Commodity";
            barButtonItem5.Id = 5;
            barButtonItem5.ImageOptions.Image = Properties.Resources.medicine_32px;
            barButtonItem5.Name = "barButtonItem5";
            barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnAllCommodities
            // 
            btnAllCommodities.Caption = "All Commmodities";
            btnAllCommodities.Id = 6;
            btnAllCommodities.ImageOptions.Image = Properties.Resources.medical_equipment_32;
            btnAllCommodities.Name = "btnAllCommodities";
            btnAllCommodities.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnAllCommodities.ItemClick += btnAllCommodities_ItemClick;
            // 
            // btnNewReceipt
            // 
            btnNewReceipt.Caption = "New Goods Receipt";
            btnNewReceipt.Id = 7;
            btnNewReceipt.ImageOptions.Image = Properties.Resources.form_blue;
            btnNewReceipt.Name = "btnNewReceipt";
            btnNewReceipt.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnNewReceipt.ItemClick += btnNewReceipt_ItemClick;
            // 
            // btnAllGoodsReceipt
            // 
            btnAllGoodsReceipt.Caption = "All Goods Receipt";
            btnAllGoodsReceipt.Id = 8;
            btnAllGoodsReceipt.ImageOptions.Image = Properties.Resources.receipt;
            btnAllGoodsReceipt.Name = "btnAllGoodsReceipt";
            btnAllGoodsReceipt.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnAllGoodsReceipt.ItemClick += btnAllGoodsReceipt_ItemClick;
            // 
            // barButtonItem9
            // 
            barButtonItem9.Caption = "New Invoice";
            barButtonItem9.Id = 9;
            barButtonItem9.ImageOptions.Image = Properties.Resources.new_invoice;
            barButtonItem9.Name = "barButtonItem9";
            barButtonItem9.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem10
            // 
            barButtonItem10.Caption = "All Invoices";
            barButtonItem10.Id = 10;
            barButtonItem10.ImageOptions.Image = Properties.Resources.all_invoices;
            barButtonItem10.Name = "barButtonItem10";
            barButtonItem10.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnSignOut
            // 
            btnSignOut.Caption = "Sign Out";
            btnSignOut.Id = 11;
            btnSignOut.ImageOptions.Image = Properties.Resources.log_out;
            btnSignOut.Name = "btnSignOut";
            btnSignOut.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnSignOut.ItemClick += btnSignOut_ItemClick;
            // 
            // tabHumanManage
            // 
            tabHumanManage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup5 });
            tabHumanManage.Name = "tabHumanManage";
            tabHumanManage.Text = "Human Manage";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(btnProfile);
            ribbonPageGroup1.ItemLinks.Add(btnNewUser);
            ribbonPageGroup1.ItemLinks.Add(btnAllUsers);
            ribbonPageGroup1.ItemLinks.Add(btnAllCustomers);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup5
            // 
            ribbonPageGroup5.ItemLinks.Add(btnSignOut);
            ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // tabCommodity
            // 
            tabCommodity.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup2 });
            tabCommodity.Name = "tabCommodity";
            tabCommodity.Text = "Commodity";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(barButtonItem5);
            ribbonPageGroup2.ItemLinks.Add(btnAllCommodities);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // tabGoodReceipt
            // 
            tabGoodReceipt.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup3 });
            tabGoodReceipt.Name = "tabGoodReceipt";
            tabGoodReceipt.Text = "Goods Receipt";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(btnNewReceipt);
            ribbonPageGroup3.ItemLinks.Add(btnAllGoodsReceipt);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup4 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Invoice";
            // 
            // ribbonPageGroup4
            // 
            ribbonPageGroup4.ItemLinks.Add(barButtonItem9);
            ribbonPageGroup4.ItemLinks.Add(barButtonItem10);
            ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 680);
            Controls.Add(ribbonControl1);
            IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            IconOptions.Icon = (Icon)resources.GetObject("frmMain.IconOptions.Icon");
            IconOptions.Image = Properties.Resources.vitapharm_transparent;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vita Pharm";
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnProfile;
        private DevExpress.XtraBars.Ribbon.RibbonPage tabHumanManage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnNewUser;
        private DevExpress.XtraBars.BarButtonItem btnAllUsers;
        private DevExpress.XtraBars.BarButtonItem btnAllCustomers;
        private DevExpress.XtraBars.Ribbon.RibbonPage tabCommodity;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem btnAllCommodities;
        private DevExpress.XtraBars.BarButtonItem btnNewReceipt;
        private DevExpress.XtraBars.Ribbon.RibbonPage tabGoodReceipt;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnAllGoodsReceipt;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem btnSignOut;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
    }
}