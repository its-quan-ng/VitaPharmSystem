using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using Microsoft.EntityFrameworkCore;
using System.Data;
using VitaPharm.Data;

namespace VitaPharm.Forms.Reports
{
    public partial class frmInvoiceReport : XtraForm
    {
        private PharmacyDbContext context;
        private DateTime fromDate;
        private DateTime toDate;

        public frmInvoiceReport()
        {
            InitializeComponent();
            fromDate = DateTime.Today.AddMonths(-1);
            toDate = DateTime.Today;
            dateEditFrom.DateTime = fromDate;
            dateEditTo.DateTime = toDate;
        }

        private void frmInvoiceReport_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                context = new PharmacyDbContext();

                var query = context.Invoices
                    .Include(i => i.Customer)
                    .Include(i => i.Employee)
                    .Include(i => i.InvoiceDetail)
                    .Where(i => i.CreatedDate >= fromDate && i.CreatedDate <= toDate);

                var invoiceData = query
                    .AsEnumerable()
                    .Select(i => new
                    {
                        i.InvoiceID,
                        i.InvoiceCode,
                        i.CreatedDate,
                        CustomerName = i.Customer?.CustomerName ?? "N/A",
                        EmployeeName = i.Employee?.EmployeeName ?? "N/A",
                        i.InvoiceStatus,
                        TotalAmount = i.InvoiceDetail.Sum(d => d.Quantity * d.UnitPrice),
                        i.TaxRate,
                        TaxAmount = i.InvoiceDetail.Sum(d => d.Quantity * d.UnitPrice) * (i.TaxRate / 100)
                    })
                    .ToList();

                pivotGridControl.DataSource = invoiceData;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error loading data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            fromDate = dateEditFrom.DateTime;
            toDate = dateEditTo.DateTime;
            LoadData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|PDF files (*.pdf)|*.pdf";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                string extension = Path.GetExtension(filePath).ToLower();

                if (extension == ".xlsx")
                {
                    pivotGridControl.ExportToXlsx(filePath);
                }
                else if (extension == ".pdf")
                {
                    pivotGridControl.ExportToPdf(filePath);
                }

                XtraMessageBox.Show("Export completed successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 