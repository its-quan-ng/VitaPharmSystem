using VitaPharm.Data;
using Microsoft.EntityFrameworkCore;
using DevExpress.XtraEditors;

namespace VitaPharm.Reports
{
    public partial class rptRevenueReport : DevExpress.XtraReports.UI.XtraReport
    {
        public rptRevenueReport()
        {
            InitializeComponent();
        }

        public void LoadData(DateTime fromDate, DateTime toDate, string describeResultFilter, string currentUser)
        {
            using (var context = new PharmacyDbContext())
            {
                var invoices = context.Invoices
                    .Include(i => i.Employee)
                    .Include(i => i.Customer)
                    .Include(i => i.InvoiceDetail)
                    .Where(i => i.CreatedDate >= fromDate && i.CreatedDate <= toDate)
                    .ToList();

                XtraMessageBox.Show($"Found {invoices.Count} invoices");

                var ds = new PharmacyManageDataSet();
                var dtInvoice = ds.Invoice;

                foreach (var i in invoices)
                {
                    dtInvoice.Rows.Add(
                        i.InvoiceID,
                        i.InvoiceCode,
                        i.CreatedDate,
                        i.Customer?.CustomerName ?? "",
                        i.Employee?.EmployeeName ?? "",
                        i.InvoiceStatus,
                        i.Note,
                        i.InvoiceDetail.Sum(d => d.Quantity * d.UnitPrice)
                    );
                }

                XtraMessageBox.Show($"Rows in DataTable: {dtInvoice.Rows.Count}");

                this.DataSource = ds;
                this.DataMember = "Invoice";

                this.Parameters["pDescribeResultFilter"].Value = describeResultFilter;
                this.Parameters["pDescribeResultFilter"].Visible = false;

                this.Parameters["pCurrentUser"].Value = currentUser;
                this.Parameters["pCurrentUser"].Visible = false;
                foreach (var param in this.Parameters)
                    param.Visible = false;
            }
        }
    }
}
