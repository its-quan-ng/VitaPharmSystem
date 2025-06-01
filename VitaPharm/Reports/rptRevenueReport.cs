using VitaPharm.Data;
using Microsoft.EntityFrameworkCore;

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
                        i.Note,
                        i.InvoiceStatus,
                        i.InvoiceDetail.Sum(d => d.Quantity * d.UnitPrice)
                    );
                }

                this.DataSource = ds;
                this.DataMember = "InvoiceList";

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
