using DevExpress.XtraEditors;
using VitaPharm.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace VitaPharm.Forms.Invoices
{
    public partial class frmNewInvoice : DevExpress.XtraEditors.XtraForm
    {
        private PharmacyDbContext context = new PharmacyDbContext();
        BindingList<InvoiceLineDto> detailsList = new BindingList<InvoiceLineDto>();
        private string currentUser;

        public frmNewInvoice(string username)
        {
            currentUser = username;
            InitializeComponent();
        }

        private void frmNewInvoice_Load(object sender, EventArgs e)
        {
            txtInvoiceCode.Text = GenerateNewInvoiceCode();

            dateCreatedDate.DateTime = DateTime.Now;

            var account = context.Accounts
                .Include(a => a.Employee)
                .FirstOrDefault(a => a.Username == currentUser);
            if (account?.Employee != null)
            {
                txtEmployee.Text = account.Employee.EmployeeName;
            }


            var customers = context.Customers
                .Select(c => new { c.CustomerID, c.CustomerName, c.Contact })
                .ToList();
            cboCustomer.Properties.DataSource = customers;
            cboCustomer.Properties.DisplayMember = "CustomerName";
            cboCustomer.Properties.ValueMember = "CustomerID";
            cboCustomer.EditValue = null;

            ToggleControls(false);
            gridControl.DataSource = detailsList;
        }

        #region Generate new invoice code
        private string GenerateNewInvoiceCode()
        {
            string prefix = "INV";
            string datePart = DateTime.Today.ToString("yyMMdd");
            int countToday = context.Invoices
                .Count(i => i.CreatedDate.Date == DateTime.Today) + 1;
            string seqPart = countToday.ToString("D3");

            return $"{prefix}{datePart}{seqPart}";
        }
        #endregion

        #region Handle form events
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (cboCommodity.EditValue == null || cboBatchCode.EditValue == null)
            {
                XtraMessageBox.Show("Please select a commodity and batch code!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var commodityId = (int)cboCommodity.EditValue;
            var batchId = (int)cboBatchCode.EditValue;

            var commodity = context.Commodities
                .FirstOrDefault(c => c.CommodityID == commodityId);
            var batch = context.Batches
                .FirstOrDefault(b => b.BatchID == batchId);

            if (commodity == null || batch == null)
            {
                XtraMessageBox.Show("Invalid commodity or batch selection!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existingLine = detailsList.FirstOrDefault(l => l.BatchID == batchId);

            if (existingLine != null)
            {
                XtraMessageBox.Show("This batch is already in the cart!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newLine = new InvoiceLineDto
            {
                ID = detailsList.Count + 1,
                CommodityID = commodityId,
                CommodityName = commodity.CommodityName,
                BatchID = batchId,
                BatchCode = batch.BatchCode,
                BaseUnit = commodity.BaseUnit,
                SellingPrice = commodity.SellingPrice,
                Qty = 1,
                Amount = commodity.SellingPrice
            };

            detailsList.Add(newLine);
            RecalculateTotals();
        }

        private void RecalculateTotals()
        {
            decimal subtotal = detailsList.Sum(l => l.Amount);
            decimal tax = subtotal * (decimal)(seTaxRate.Value / 100);
            decimal total = subtotal + tax;

            lblTax.Text = tax.ToString("N0");
            lblTotal.Text = total.ToString("N0");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var focusedRow = gridView.GetFocusedRow() as InvoiceLineDto;
            if (focusedRow == null) return;

            if (XtraMessageBox.Show("Remove this item from cart?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            detailsList.Remove(focusedRow);

            for (int i = 0; i < detailsList.Count; i++)
            {
                detailsList[i].ID = i + 1;
            }

            RecalculateTotals();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboCustomer.EditValue == null)
            {
                XtraMessageBox.Show("Please select a customer!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (detailsList.Count == 0)
            {
                XtraMessageBox.Show("Please add at least one item to cart!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var transaction = context.Database.BeginTransaction();
            try
            {
                // Create new invoice
                var invoice = new Invoice
                {
                    InvoiceCode = txtInvoiceCode.Text,
                    CreatedDate = dateCreatedDate.DateTime,
                    Note = meNote.Text,
                    TaxRate = (float)seTaxRate.Value,
                    InvoiceStatus = "Success",
                    Employee = context.Accounts.First(a => a.Username == currentUser).Employee,
                    Customer = context.Customers.First(c => c.CustomerID == (int)cboCustomer.EditValue)
                };
                context.Invoices.Add(invoice);
                context.SaveChanges();

                // Add invoice details
                foreach (var line in detailsList)
                {
                    var detail = new InvoiceDetail
                    {
                        Invoice = invoice,
                        BatchID = line.BatchID,
                        Quantity = line.Qty,
                        UnitPrice = line.SellingPrice
                    };
                    context.InvoiceDetails.Add(detail);

                    // Update batch quantity
                    var batch = context.Batches.First(b => b.BatchID == line.BatchID);
                    batch.OnHand -= line.Qty;
                }

                context.SaveChanges();
                transaction.Commit();

                XtraMessageBox.Show("Invoice saved successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                XtraMessageBox.Show($"Error saving invoice: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure you want to cancel?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Qty")
            {
                var line = gridView.GetFocusedRow() as InvoiceLineDto;
                if (line != null)
                {
                    line.Amount = line.Qty * line.SellingPrice;
                    RecalculateTotals();
                }
            }
        }

        private void seTaxRate_EditValueChanged(object sender, EventArgs e)
        {
            RecalculateTotals();
        }

        private void cboCustomer_EditValueChanged(object sender, EventArgs e)
        {
            if (cboCustomer.EditValue == null)
            {
                txtContact.Text = string.Empty;
                return;
            }

            var customerId = (int)cboCustomer.EditValue;
            var customer = context.Customers
                .FirstOrDefault(c => c.CustomerID == customerId);
            
            if (customer != null)
            {
                txtContact.Text = customer.Contact;
            }
        }

        #endregion

        private void ToggleControls(bool enableEditable)
        {
            txtInvoiceCode.Enabled = false;
            dateCreatedDate.Enabled = false; 
            txtEmployee.Enabled = false; 
            cboCustomer.Enabled = false;
            txtContact.Enabled = false;
            txtQtyAvailable.Enabled = false;
            txtPrice.Enabled = false;       
            txtBaseUnit.Enabled = false;    
            btnAddToCart.Enabled = false;
            btnRemove.Enabled = !false;
            btnAdd.Enabled = !false;
        }

        private void LoadCommodities()
        {
            var commodities = context.Commodities
                .Select(c => new
                {
                    c.CommodityID,
                    c.CommodityName,
                    c.Manufacturer,
                    c.BaseUnit,
                    c.SellingPrice
                })
                .ToList();
            cboCommodity.Properties.DataSource = commodities;
            cboCommodity.Properties.DisplayMember = "CommodityName";
            cboCommodity.Properties.ValueMember = "CommodityID";
            cboCommodity.EditValue = null;
        }

        private void cboCommodity_EditValueChanged(object sender, EventArgs e)
        {
            if (cboCommodity.EditValue == null)
            {
                txtBaseUnit.Text = string.Empty;
                txtPrice.Text = string.Empty;
                cboBatchCode.Properties.DataSource = null;
                return;
            }

            var commodityId = (int)cboCommodity.EditValue;
            var commodity = context.Commodities
                .FirstOrDefault(c => c.CommodityID == commodityId);

            if (commodity != null)
            {
                txtBaseUnit.Text = commodity.BaseUnit;
                txtPrice.Text = commodity.SellingPrice.ToString("N0");

                var batches = context.Batches
                    .Where(b => b.CommodityID == commodityId && b.OnHand > 0)
                    .Select(b => new
                    {
                        b.BatchID,
                        b.BatchCode,
                        b.OnHand
                    })
                    .ToList();

                cboBatchCode.Properties.DataSource = batches;
                cboBatchCode.Properties.DisplayMember = "BatchCode";
                cboBatchCode.Properties.ValueMember = "BatchID";
                cboBatchCode.EditValue = null;
            }
        }

        private void cboBatchCode_EditValueChanged(object sender, EventArgs e)
        {
            if (cboBatchCode.EditValue == null)
            {
                txtQtyAvailable.Text = string.Empty;
                return;
            }

            var batchId = (int)cboBatchCode.EditValue;
            var batch = context.Batches
                .FirstOrDefault(b => b.BatchID == batchId);

            if (batch != null)
            {
                txtQtyAvailable.Text = batch.OnHand.ToString();
                btnAddToCart.Enabled = true;
            }
        }
    }
}