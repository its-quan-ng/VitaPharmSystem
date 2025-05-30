using Microsoft.EntityFrameworkCore;
using System.Data;
using VitaPharm.Data;

namespace VitaPharm.Forms.Invoice
{
    public partial class frmAllInvoices : DevExpress.XtraEditors.XtraForm
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
            context = new PharmacyDbContext();
            bsAllInvoices = new BindingSource
            {
                DataSource = context.Invoices
                                    .Include(i => i.Customer)
                                    .Include(i => i.Employee)
                                    .AsEnumerable()
                                    .Select((i, idx) => new
                                    {
                                        ID = idx + 1,
                                        i.InvoiceID,
                                        i.InvoiceCode,
                                        i.CreatedDate,
                                        i.Customer.CustomerName,
                                        i.Employee.EmployeeName,
                                        i.InvoiceStatus,
                                        i.Note,
                                    })
                                    .ToList()
            };
            gridControl.DataSource = bsAllInvoices;
        }
    }
}