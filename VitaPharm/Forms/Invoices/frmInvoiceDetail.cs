using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VitaPharm.Data;

namespace VitaPharm.Forms.Invoices
{
    public partial class frmInvoiceDetail : XtraForm
    {
        private PharmacyDbContext context = new PharmacyDbContext();
        private string invoiceCode;
        private Invoice currentInvoice;
        private BindingSource bsInvoiceDetails;

        public frmInvoiceDetail(string InvoiceCode)
        {
            this.invoiceCode = InvoiceCode;
            InitializeComponent();
        }

        private void frmInvoiceDetail_Load(object sender, EventArgs e)
        {
            try
            {
                LoadInvoiceData();
                LoadCustomers();
                SetupGridView();
                LoadInvoiceDetails();
                SetControlsReadOnly();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error loading invoice detail: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadInvoiceData()
        {
            context = new PharmacyDbContext();

            currentInvoice = context.Invoices
                .Include(i => i.Customer)
                .Include(i => i.Employee)
                .FirstOrDefault(i => i.InvoiceCode == invoiceCode);

            if (currentInvoice != null)
            {
                txtInvoiceCode.Text = currentInvoice.InvoiceCode;
                txtEmployee.Text = currentInvoice.Employee?.EmployeeName ?? "N/A";
                deCreatedDate.DateTime = currentInvoice.CreatedDate;

                if (currentInvoice.Customer != null)
                {
                    cboCustomer.EditValue = currentInvoice.Customer.CustomerID;
                }
            }
            else
            {
                XtraMessageBox.Show("Invoice not found!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void LoadCustomers()
        {
            try
            {
                var customers = context.Customers
                    .Select(c => new
                    {
                        c.CustomerID,
                        c.CustomerName,
                        c.Contact,
                        c.CustomerAddress
                    })
                    .ToList();

                cboCustomer.Properties.DataSource = customers;
                cboCustomer.Properties.DisplayMember = "CustomerName";
                cboCustomer.Properties.ValueMember = "CustomerID";
                cboCustomer.Properties.PopulateColumns();

                if (cboCustomer.Properties.Columns.Count > 0)
                {
                    cboCustomer.Properties.Columns["CustomerID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error loading customers: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupGridView()
        {
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView.OptionsSelection.EnableAppearanceFocusedRow = true;
        }

        private void LoadInvoiceDetails()
        {
            try
            {
                if (currentInvoice == null) return;

                var invoiceDetails = context.InvoiceDetails
                    .Include(id => id.Batch)
                    .ThenInclude(b => b.Commodity)
                    .Where(id => id.Invoice.InvoiceID == currentInvoice.InvoiceID)
                    .AsEnumerable()
                    .Select((id, idx) => new
                    {
                        ID = idx + 1,
                        id.InvoiceDetailID,
                        CommodityName = id.Batch?.Commodity?.CommodityName ?? "N/A",
                        BatchCode = id.Batch?.BatchCode ?? "N/A",
                        id.Quantity,
                        BaseUnit = id.Batch?.Commodity?.BaseUnit ?? "N/A",
                        id.UnitPrice,
                        Amount = id.Amount,
                        OnHand = id.OnHand,
                        MfgDate = id.Batch?.MfgDate,
                        ExpDate = id.Batch?.ExpDate,
                        QtyAvailable = id.Batch?.QtyAvailable ?? 0,
                        BatchStatus = id.Batch?.BatchStatus ?? "N/A"
                    })
                    .ToList();

                bsInvoiceDetails = new BindingSource
                {
                    DataSource = invoiceDetails
                };

                gridControl.DataSource = bsInvoiceDetails;

                HideColumnSafely("ID");
                HideColumnSafely("InvoiceDetailID");
                HideColumnSafely("OnHand"); 
                HideColumnSafely("MfgDate"); 
                HideColumnSafely("ExpDate"); 
                HideColumnSafely("QtyAvailable"); 
                HideColumnSafely("BatchStatus"); 

                FormatCurrencyColumn("UnitPrice");
                FormatCurrencyColumn("Amount");

                SetColumnCaption("CommodityName", "Product Name");
                SetColumnCaption("BatchCode", "Batch Code");
                SetColumnCaption("Quantity", "Qty");
                SetColumnCaption("BaseUnit", "Unit");
                SetColumnCaption("UnitPrice", "Unit Price");
                SetColumnCaption("Amount", "Amount");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error loading invoice details: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HideColumnSafely(string fieldName)
        {
            var col = gridView.Columns[fieldName];
            if (col != null)
            {
                col.Visible = false;
                col.OptionsColumn.ShowInCustomizationForm = false;
            }
        }

        private void FormatCurrencyColumn(string fieldName)
        {
            var col = gridView.Columns[fieldName];
            if (col != null)
            {
                col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                col.DisplayFormat.FormatString = "c2";
            }
        }

        private void SetColumnCaption(string fieldName, string caption)
        {
            var col = gridView.Columns[fieldName];
            if (col != null)
            {
                col.Caption = caption;
            }
        }

        private void SetControlsReadOnly()
        {
            txtInvoiceCode.Properties.ReadOnly = true;
            txtEmployee.Properties.ReadOnly = true;
            deCreatedDate.Properties.ReadOnly = true;
            cboCustomer.Properties.ReadOnly = true;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            frmInvoiceDetail_Load(sender, e);
        }

    }
}