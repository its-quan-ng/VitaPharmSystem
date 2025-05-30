using Microsoft.EntityFrameworkCore;
using System.Data;
using VitaPharm.Data;
using DevExpress.XtraEditors;

namespace VitaPharm.Forms.Invoices
{
    public partial class frmAllInvoices : XtraForm
    {
        private PharmacyDbContext context;
        private BindingSource bsAllInvoices;

        public frmAllInvoices()
        {
            InitializeComponent();
        }

        private void frmAllInvoices_Load(object sender, EventArgs e)
        {
            LoadInvoices();
        }

        private void LoadInvoices()
        {
            try
            {
                context = new PharmacyDbContext();

                IQueryable<Invoice> query = context.Invoices
                    .Include(i => i.Customer)
                    .Include(i => i.Employee);

                bool isAdmin = string.Equals(CurrentUser.Role, "Admin", StringComparison.OrdinalIgnoreCase);
                if (!isAdmin)
                {
                    query = query.Where(i => i.Employee.EmployeeID == CurrentUser.EmployeeID);
                }

                var invoiceData = query
                    .AsEnumerable()
                    .Select((i, idx) => new
                    {
                        ID = idx + 1,
                        i.InvoiceID,
                        i.InvoiceCode,
                        i.CreatedDate,
                        CustomerName = i.Customer?.CustomerName ?? "N/A",
                        EmployeeName = i.Employee?.EmployeeName ?? "N/A",
                        i.InvoiceStatus,
                        i.Note,
                    })
                    .ToList();

                bsAllInvoices = new BindingSource
                {
                    DataSource = invoiceData
                };

                gridControl.DataSource = bsAllInvoices;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error loading invoices: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {

        }
    }
}