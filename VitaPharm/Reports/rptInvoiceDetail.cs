using VitaPharm.Data;
using Microsoft.EntityFrameworkCore;

namespace VitaPharm.Reports
{
    public partial class rptInvoiceDetail : DevExpress.XtraReports.UI.XtraReport
    {
        public rptInvoiceDetail()
        {
            InitializeComponent();
        }

        public void LoadData(string invoiceCode)
        {
            using (var context = new PharmacyDbContext())
            {
                var invoice = context.Invoices
                    .Include(i => i.Customer)
                    .Include(i => i.Employee)
                    .Include(i => i.InvoiceDetail)
                        .ThenInclude(id => id.Batch)
                            .ThenInclude(b => b.Commodity)
                    .FirstOrDefault(i => i.InvoiceCode == invoiceCode);

                var ds = new PharmacyManageDataSet();
                var dtMaster = ds.Invoice;
                var dtDetail = ds.InvoiceDetail;

                // Add master row
                dtMaster.Rows.Add(
                    invoice.InvoiceID,
                    invoice.InvoiceCode,
                    invoice.CreatedDate,
                    invoice.Employee?.EmployeeName ?? "",
                    invoice.Customer?.CustomerName ?? "",
                    invoice.InvoiceStatus,
                    invoice.Note,
                    invoice.InvoiceDetail.Sum(x => x.Amount)
                );

                // Add detail rows
                foreach (var d in invoice.InvoiceDetail)
                {
                    dtDetail.Rows.Add(
                        d.InvoiceDetailID,
                        invoice.InvoiceID,
                        d.Batch?.Commodity?.CommodityName ?? "",
                        d.Quantity,
                        d.UnitPrice,
                        d.Amount
                    );
                }

                this.DataSource = ds;
                this.DataMember = "InvoiceDetail";

                // Set parameters
                this.Parameters["pInvoiceCode"].Value = invoice.InvoiceCode;
                this.Parameters["pCreateDate"].Value = invoice.CreatedDate;
                this.Parameters["pCustomerName"].Value = invoice.Customer?.CustomerName ?? "";
                this.Parameters["pCustomerContact"].Value = invoice.Customer?.Contact ?? "";
                this.Parameters["pEmployeeName"].Value = invoice.Employee?.EmployeeName ?? "";
                this.Parameters["pNote"].Value = invoice.Note;
                this.Parameters["pTaxRate"].Value = invoice.TaxRate;
                decimal subtotal = invoice.InvoiceDetail.Sum(x => x.Amount);
                decimal taxAmount = subtotal * (decimal)invoice.TaxRate / 100;
                decimal totalPayment = subtotal + taxAmount;
                this.Parameters["pSubtotal"].Value = subtotal;
                this.Parameters["pTaxAmount"].Value = taxAmount;
                this.Parameters["pTotalPayment"].Value = totalPayment;

                // Ẩn panel tham số khi in
                foreach (var param in this.Parameters)
                    param.Visible = false;
            }
        }
    }
}
