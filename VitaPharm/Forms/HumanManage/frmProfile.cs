using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using VitaPharm.Data;

namespace VitaPharm.Forms.HumanManage
{
    public partial class frmProfile : DevExpress.XtraEditors.XtraForm
    {
        private readonly Account account;
        internal frmProfile(Account account)
        {
            InitializeComponent();
            this.account = account;
            this.Load += frmProfile_Load;
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            txtEmployeeID.Text = account.Employee.EmployeeID.ToString();
            txtUsername.Text = account.Username;

            txtFullName.Text = account.Employee.EmployeeName;
            ckcFemale.Checked = account.Employee.Sex == "F";
            dateBirthday.DateTime = account.Employee.Birthday;
            txtContact.Text = account.Employee.Contact;
            txtAddress.Text = account.Employee.EmployeeAddress;
        }
    }
}