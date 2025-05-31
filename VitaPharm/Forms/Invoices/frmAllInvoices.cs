using Microsoft.EntityFrameworkCore;
using System.Data;
using VitaPharm.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace VitaPharm.Forms.Invoices
{
    public partial class frmAllInvoices : XtraForm
    {
        private PharmacyDbContext context;
        private BindingSource bsAllInvoices;
        bool isAdmin = string.Equals(CurrentUser.Role, "admin", StringComparison.OrdinalIgnoreCase);

        public frmAllInvoices()
        {
            InitializeComponent();
            repobtnViewDetail.ButtonClick += repobtnViewDetail_ButtonClick;
        }

        private void frmAllInvoices_Load(object sender, EventArgs e)
        {
            LoadInvoices();
            btnNewInvoice.Enabled = !isAdmin;
        }

        private void LoadInvoices()
        {
            try
            {
                context = new PharmacyDbContext();

                IQueryable<Invoice> query = context.Invoices
                    .Include(i => i.Customer)
                    .Include(i => i.Employee);

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

                HideColumnSafely(gridView, "InvoiceID");
                gridView.OptionsBehavior.Editable = false;
                gridView.OptionsView.ShowGroupPanel = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error loading invoices: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void HideColumnSafely(GridView view, string fieldName)
        {
            var col = view.Columns[fieldName];
            if (col != null)
            {
                col.Visible = false;
                col.OptionsColumn.ShowInCustomizationForm = false;
            }
        }

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            var newInvoiceForm = new frmNewInvoice();
            newInvoiceForm.ShowDialog();
            LoadInvoices();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            frmAllInvoices_Load(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = XtraMessageBox.Show("Are you sure you want to close this form?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void repobtnViewDetail_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int rowHandle = gridView.FocusedRowHandle;
            if (rowHandle < 0) return;

            var invoiceCode = gridView.GetRowCellValue(rowHandle, "InvoiceCode");
            if (invoiceCode == null) return;

            var detailForm = new frmInvoiceDetail((string)invoiceCode);
            detailForm.ShowDialog();
        }
    }
}