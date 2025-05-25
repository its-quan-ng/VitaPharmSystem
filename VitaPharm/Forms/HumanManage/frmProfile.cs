using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;
using VitaPharm.Data;

namespace VitaPharm.Forms.HumanManage
{
    public partial class frmProfile : XtraForm
    {
        private PharmacyDbContext contextAccount;
        private BindingSource bsAccount;
        private BindingSource bsEmployee;
        private readonly int accountId;

        internal frmProfile(Account account)
        {
            InitializeComponent();
            accountId = account.AccountID;
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            LoadProfileData();    
            ToggleControl(false);
        }

        private void LoadProfileData()
        {
            contextAccount?.Dispose();
            contextAccount = new PharmacyDbContext();

            var acct = contextAccount.Accounts
                        .Include(a => a.Employee)
                        .First(a => a.AccountID == accountId);

            bsAccount = new BindingSource { DataSource = acct };
            bsEmployee = new BindingSource { DataSource = acct.Employee };

            txtEmployeeID.DataBindings.Clear();
            txtEmployeeID.DataBindings.Add(
                "Text", bsEmployee, nameof(acct.Employee.EmployeeID),
                true, DataSourceUpdateMode.Never);

            txtUsername.DataBindings.Clear();
            txtUsername.DataBindings.Add(
                "Text", bsAccount, nameof(acct.Username),
                true, DataSourceUpdateMode.OnPropertyChanged);

            txtFullName.DataBindings.Clear();
            txtFullName.DataBindings.Add(
                "Text", bsEmployee, nameof(acct.Employee.EmployeeName),
                true, DataSourceUpdateMode.OnPropertyChanged);

            ckcFemale.DataBindings.Clear();
            var sexBinding = new Binding("Checked", bsEmployee, nameof(acct.Employee.Sex),
                                         true, DataSourceUpdateMode.OnPropertyChanged);
            sexBinding.Format += (s, e) => e.Value = (e.Value as string) == "F";
            sexBinding.Parse += (s, e) => e.Value = ((bool)e.Value) ? "F" : "M";
            ckcFemale.DataBindings.Add(sexBinding);

            dateBirthday.DataBindings.Clear();
            dateBirthday.DataBindings.Add(
                "EditValue", bsEmployee, nameof(acct.Employee.Birthday),
                true, DataSourceUpdateMode.OnPropertyChanged);

            txtContact.DataBindings.Clear();
            txtContact.DataBindings.Add(
                "Text", bsEmployee, nameof(acct.Employee.Contact),
                true, DataSourceUpdateMode.OnPropertyChanged);

            txtAddress.DataBindings.Clear();
            txtAddress.DataBindings.Add(
                "Text", bsEmployee, nameof(acct.Employee.EmployeeAddress),
                true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void ToggleControl(bool editing)
        {
            txtEmployeeID.Enabled = false;

            txtUsername.Enabled = editing;
            txtFullName.Enabled = editing;
            ckcFemale.Enabled = editing;
            dateBirthday.Enabled = editing;
            txtContact.Enabled = editing;
            txtAddress.Enabled = editing;

            btnEdit.Enabled = !editing;
            btnSave.Enabled = editing;
            btnCancel.Enabled = editing;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ToggleControl(true);      
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bsAccount.EndEdit();
            bsEmployee.EndEdit();

            contextAccount.SaveChanges();

            XtraMessageBox.Show(
                "Profile updated successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LoadProfileData();
            ToggleControl(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(
                "Discard changes and reload original data?",
                "Confirm Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                contextAccount.Entry(bsAccount.Current).Reload();
                contextAccount.Entry(bsEmployee.Current).Reload();
                bsAccount.ResetBindings(false);
                bsEmployee.ResetBindings(false);

                ToggleControl(false);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            contextAccount.Dispose();
        }
    }
}
