using System.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using Microsoft.EntityFrameworkCore;
using VitaPharm.Data;

namespace VitaPharm.Forms.HumanManage
{
    public partial class frmAllCustomers : XtraForm
    {
        private PharmacyDbContext context;
        private BindingSource bsCustomers;
        public frmAllCustomers()
        {
            InitializeComponent();
            bsCustomers = new BindingSource();
            gridControl.DataSource = bsCustomers;
            gridView.FocusedRowChanged += GridView_FocusedRowChanged;
        }

        private void frmAllCustomers_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
            ToggleControls(false);
        }

        private void LoadCustomerData()
        {
            context?.Dispose();
            context = new PharmacyDbContext();
            var cus = context.Customers.Select(
                c => new
                {
                    c.CustomerName,
                    c.CustomerAddress,
                    c.Contact,
                    c.Sex,
                }).AsEnumerable()
                .Select((item, index) => new
                {
                    ID = index + 1,
                    item.CustomerName,
                    item.Sex,
                    item.Contact,
                    item.CustomerAddress
                })
                .ToList(); ;
            gridControl.DataSource = cus.ToList();
        }

        private void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            var row = gridView.GetRow(e.FocusedRowHandle) as dynamic;
            if (row == null) return;

            txtFullName.Text = row.CustomerName;
            chkFemale.Checked = (row.Sex == "F");
            txtContact.Text = row.Contact;
            txtAddress.Text = row.CustomerAddress;
        }

        private void ToggleControls(bool enabled)
        {
            txtFullName.Enabled = enabled;
            chkFemale.Enabled = enabled;
            txtContact.Enabled = enabled;
            txtAddress.Enabled = enabled;
        }
    }
}