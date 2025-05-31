using ClosedXML.Excel;
using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;
using System.Data;
using VitaPharm.Data;

namespace VitaPharm.Forms.Receipt
{
    public partial class frmAllGoodsReceipt : XtraForm
    {
        private PharmacyDbContext context = new PharmacyDbContext();
        private string currentUser;

        public frmAllGoodsReceipt(string username)
        {
            InitializeComponent();
            currentUser = username;
            repobtnViewDetail.ButtonClick += repobtnViewDetail_ButtonClick;
            LoadReceipts();
        }

        private void frmAllGoodsReceipt_Load(object sender, EventArgs e)
        {
            LoadReceipts();

            if (!string.IsNullOrEmpty(CurrentUser.Role) &&
                CurrentUser.Role.Trim().Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                btnDeactive.Enabled = false;
            }
            else
            {
                btnDeactive.Enabled = true;
            }
        }

        private void btnNewGoodsReceipt_Click(object sender, EventArgs e)
        {
            var newBatchForm = new frmNewGoodsReceipt(currentUser);
            newBatchForm.ShowDialog();
            LoadReceipts();
        }

        private void btnDeactive_Click(object sender, EventArgs e)
        {
            int rowHandle = gridView.FocusedRowHandle;
            if (rowHandle < 0)
            {
                XtraMessageBox.Show("Please select a receipt to deactivate.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var receiptID = gridView.GetRowCellValue(rowHandle, "ReceiptID");
            if (receiptID == null)
            {
                XtraMessageBox.Show("Invalid selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (XtraMessageBox.Show("Are you sure you want to deactivate this receipt?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var receipt = context.GoodsReceipts.FirstOrDefault(r => r.ReceiptID == (int)receiptID);
                if (receipt != null)
                {
                    receipt.ReceiptStatus = "Canceled";
                    context.SaveChanges();
                    LoadReceipts();
                    XtraMessageBox.Show("Receipt deactivated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            frmAllGoodsReceipt_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you want to exit this screen?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void LoadReceipts()
        {
            IQueryable<GoodsReceipt> receiptQuery = context.GoodsReceipts;

            if (CurrentUser.Role.Trim().Equals("user", StringComparison.OrdinalIgnoreCase))
            {
                receiptQuery = receiptQuery.Where(r => r.Employee.EmployeeID == CurrentUser.EmployeeID);
            }

            var receipts = receiptQuery
                .AsEnumerable()
                .Select((r, idx) => new
                {
                    ID = idx + 1,
                    r.ReceiptID,
                    r.ReceiptCode,
                    r.ReceiptDate,
                    r.SupplierName,
                    r.Note,
                    r.ReceiptStatus
                })
                .ToList();
            gridControl.DataSource = receipts;
        }

        private void repobtnViewDetail_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int rowHandle = gridView.FocusedRowHandle;
            if (rowHandle < 0) return;

            var receiptID = gridView.GetRowCellValue(rowHandle, "ReceiptID");
            if (receiptID == null) return;

            var detailForm = new frmGoodsReceiptDetail((int)receiptID);
            detailForm.ShowDialog();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Import data from Excel file";
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        #region Process Goods Receipt Sheet (Sheet 1)
                        IXLWorksheet sheet1 = workbook.Worksheet(1);
                        bool firstRowGoodsReceipt = true;
                        string readRangeGoodsReceipt = "1:1";
                        DataTable tableGoodsReceipt = new DataTable();

                        foreach (IXLRow row in sheet1.RowsUsed())
                        {
                            if (firstRowGoodsReceipt)
                            {
                                readRangeGoodsReceipt = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRangeGoodsReceipt))
                                    tableGoodsReceipt.Columns.Add(cell.Value.ToString());
                                firstRowGoodsReceipt = false;
                            }
                            else
                            {
                                tableGoodsReceipt.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRangeGoodsReceipt))
                                {
                                    tableGoodsReceipt.Rows[tableGoodsReceipt.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }

                        if (tableGoodsReceipt.Rows.Count > 0)
                        {
                            using (var transaction = context.Database.BeginTransaction())
                            {
                                foreach (DataRow r in tableGoodsReceipt.Rows)
                                {
                                    string receiptCode = r["ReceiptCode"].ToString();
                                    if (context.GoodsReceipts.Any(gr => gr.ReceiptCode == receiptCode))
                                    {
                                        continue;
                                    }

                                    var employee = context.Employees.FirstOrDefault(e => e.EmployeeID == CurrentUser.EmployeeID);
                                    if (employee == null)
                                    {
                                        XtraMessageBox.Show("Employee not found.",
                                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }

                                    GoodsReceipt gr = new GoodsReceipt();
                                    gr.ReceiptCode = receiptCode;

                                    gr.ReceiptDate = ParseDateTime(r["ReceiptDate"].ToString());

                                    gr.SupplierName = r["SupplierName"].ToString();
                                    gr.Note = r["Note"]?.ToString() ?? "";
                                    gr.ReceiptStatus = r["ReceiptStatus"]?.ToString() ?? "active";
                                    gr.Employee = employee;

                                    context.GoodsReceipts.Add(gr);
                                }
                                context.SaveChanges();
                                transaction.Commit();
                            }
                        }
                        #endregion

                        #region Process Goods Receipt Details Sheet (Sheet 2)
                        if (workbook.Worksheets.Count > 1)
                        {
                            IXLWorksheet sheet2 = workbook.Worksheet(2);
                            bool firstRowGoodsReceiptDetail = true;
                            string readRangeGoodsReceiptDetail = "1:1";
                            DataTable tableGoodsReceiptDetail = new DataTable();

                            foreach (IXLRow row in sheet2.RowsUsed())
                            {
                                if (firstRowGoodsReceiptDetail)
                                {
                                    readRangeGoodsReceiptDetail = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                    foreach (IXLCell cell in row.Cells(readRangeGoodsReceiptDetail))
                                        tableGoodsReceiptDetail.Columns.Add(cell.Value.ToString());
                                    firstRowGoodsReceiptDetail = false;
                                }
                                else
                                {
                                    tableGoodsReceiptDetail.Rows.Add();
                                    int cellIndex = 0;
                                    foreach (IXLCell cell in row.Cells(readRangeGoodsReceiptDetail))
                                    {
                                        tableGoodsReceiptDetail.Rows[tableGoodsReceiptDetail.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                        cellIndex++;
                                    }
                                }
                            }

                            if (tableGoodsReceiptDetail.Rows.Count > 0)
                            {
                                using (var transaction = context.Database.BeginTransaction())
                                {
                                    foreach (DataRow r in tableGoodsReceiptDetail.Rows)
                                    {
                                        string receiptCode = r["ReceiptCode"].ToString();
                                        string batchCode = r["BatchCode"].ToString();

                                        var goodsReceipt = context.GoodsReceipts.FirstOrDefault(gr => gr.ReceiptCode == receiptCode);
                                        if (goodsReceipt == null) continue;

                                        string commodityName = r["CommodityName"].ToString();
                                        string manufacturer = r["Manufacturer"]?.ToString() ?? "";
                                        var commodity = context.Commodities.FirstOrDefault(c =>
                                            c.CommodityName == commodityName &&
                                            (string.IsNullOrEmpty(manufacturer) || c.Manufacturer == manufacturer));
                                        if (commodity == null) continue;

                                        var batch = context.Batches.FirstOrDefault(b => b.BatchCode == batchCode);
                                        if (batch == null)
                                        {
                                            batch = new Batch();
                                            batch.BatchCode = batchCode;

                                            batch.MfgDate = ParseDateTime(r["MfgDate"].ToString());
                                            batch.ExpDate = ParseDateTime(r["ExpDate"].ToString());

                                            batch.BatchDate = DateTime.Now;
                                            batch.QtyAvailable = 0;
                                            batch.PurchasePrice = Convert.ToDecimal(r["PurchasePrice"].ToString());
                                            batch.BatchStatus = "Active";
                                            batch.Commodity = commodity;

                                            context.Batches.Add(batch);
                                            context.SaveChanges();
                                        }

                                        if (context.GoodsReceiptDetails.Any(grd =>
                                            grd.GoodsReceipt.ReceiptID == goodsReceipt.ReceiptID &&
                                            grd.Batch.BatchID == batch.BatchID))
                                        {
                                            continue;
                                        }

                                        int qtyIn = Convert.ToInt32(r["Quantity"].ToString());

                                        GoodsReceiptDetail grd = new GoodsReceiptDetail();
                                        grd.QtyIn = qtyIn;
                                        grd.GoodsReceipt = goodsReceipt;
                                        grd.Batch = batch;

                                        context.GoodsReceiptDetails.Add(grd);

                                        batch.QtyAvailable += qtyIn;
                                    }
                                    context.SaveChanges();
                                    transaction.Commit();
                                }
                            }
                        }
                        #endregion

                        if (firstRowGoodsReceipt && workbook.Worksheets.Count == 1)
                        {
                            XtraMessageBox.Show("Excel file is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            int totalRows = tableGoodsReceipt.Rows.Count;
                            XtraMessageBox.Show($"Successfully imported {totalRows} goods receipt(s).", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadReceipts();
                        }
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"Error importing data: {ex.Message}\n\nStack Trace: {ex.StackTrace}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private DateTime ParseDateTime(string dateString)
        {
            if (string.IsNullOrEmpty(dateString))
                return DateTime.Now;

            string[] dateFormats = {
                "dd/MM/yyyy",
                "dd-MM-yyyy",
                "MM/dd/yyyy",
                "yyyy-MM-dd",
                "dd/MM/yyyy HH:mm:ss",
                "dd-MM-yyyy HH:mm:ss",
                "MM/dd/yyyy HH:mm:ss",
                "yyyy-MM-dd HH:mm:ss",
                "dd/MM/yyyy HH:mm",
                "dd-MM-yyyy HH:mm",
                "MM/dd/yyyy HH:mm",
                "yyyy-MM-dd HH:mm"
            };

            DateTime result;

            foreach (string format in dateFormats)
            {
                if (DateTime.TryParseExact(dateString, format,
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None, out result))
                {
                    return result;
                }
            }

            if (DateTime.TryParse(dateString, out result))
            {
                return result;
            }

            return DateTime.Now;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx;*.xls",
                Title = "Export Receipts to Excel",
                FileName = "GR_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    #region Export DataTables for All Goods Receipts
                    DataTable tableGoodsReceipts = new DataTable();
                    tableGoodsReceipts.Columns.AddRange(new DataColumn[] {
                        new DataColumn("ID", typeof(int)),             
                        new DataColumn("ReceiptCode", typeof(string)),
                        new DataColumn("ReceiptDate", typeof(string)),
                        new DataColumn("SupplierName", typeof(string)),
                        new DataColumn("EmployeeName", typeof(string)),
                        new DataColumn("Note", typeof(string)),
                        new DataColumn("ReceiptStatus", typeof(string))
                    });

                 
                    IQueryable<GoodsReceipt> receiptQuery = context.GoodsReceipts
                        .Include(r => r.Employee);

                    if (CurrentUser.Role.Trim().Equals("user", StringComparison.OrdinalIgnoreCase))
                    {
                        receiptQuery = receiptQuery.Where(r => r.Employee.EmployeeID == CurrentUser.EmployeeID);
                    }

                    var receipts = receiptQuery.ToList();
                    if (receipts != null && receipts.Count > 0)
                    {
                        int index = 1;
                        foreach (var r in receipts)
                        {
                            tableGoodsReceipts.Rows.Add(
                                index++,                            
                                r.ReceiptCode,
                                r.ReceiptDate.ToString("dd/MM/yyyy"),
                                r.SupplierName,
                                r.Employee?.EmployeeName ?? "",
                                r.Note ?? "",
                                r.ReceiptStatus
                            );
                        }
                    }
                    #endregion

                    #region Export DataTables for Goods Receipts Details
                    DataTable tableGoodsReceiptDetails = new DataTable();
                    tableGoodsReceiptDetails.Columns.AddRange(new DataColumn[] {
                        new DataColumn("ReceiptCode", typeof(string)),      
                        new DataColumn("BatchCode", typeof(string)),
                        new DataColumn("CommodityName", typeof(string)),
                        new DataColumn("Manufacturer", typeof(string)),
                        new DataColumn("BaseUnit", typeof(string)),
                        new DataColumn("MfgDate", typeof(string)),
                        new DataColumn("ExpDate", typeof(string)),
                        new DataColumn("PurchasePrice", typeof(decimal)),
                        new DataColumn("Quantity", typeof(int)),
                        new DataColumn("Amount", typeof(decimal))
                    });

                    var receiptIds = receipts.Select(r => r.ReceiptID).ToList();
                    var receiptDetails = context.GoodsReceiptDetails
                        .Include(d => d.GoodsReceipt)
                        .Include(d => d.Batch)
                        .Include(d => d.Batch.Commodity)
                        .Where(d => receiptIds.Contains(d.GoodsReceipt.ReceiptID))
                        .ToList();

                    if (receiptDetails != null && receiptDetails.Count > 0)
                    {
                        foreach (var d in receiptDetails)
                        {
                            tableGoodsReceiptDetails.Rows.Add(
                                d.GoodsReceipt.ReceiptCode,     
                                d.Batch?.BatchCode ?? "",
                                d.Batch?.Commodity?.CommodityName ?? "",
                                d.Batch?.Commodity?.Manufacturer ?? "",
                                d.Batch?.Commodity?.BaseUnit ?? "",
                                d.Batch?.MfgDate.ToString("dd/MM/yyyy"),
                                d.Batch?.ExpDate.ToString("dd/MM/yyyy"),
                                d.Batch?.PurchasePrice ?? 0,
                                d.QtyIn,
                                d.QtyIn * (d.Batch?.PurchasePrice ?? 0)
                            );
                        }
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet1 = wb.Worksheets.Add(tableGoodsReceipts, "GR_" + DateTime.Now.ToString("yyyyMMdd_HHmmss"));
                        sheet1.Columns().AdjustToContents();

                        var sheet2 = wb.Worksheets.Add(tableGoodsReceiptDetails, "GRD_" + DateTime.Now.ToString("yyyyMMdd_HHmmss"));
                        sheet2.Columns().AdjustToContents();

                        wb.SaveAs(saveFileDialog.FileName);
                        XtraMessageBox.Show($"Export completed successfully!",
                            "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"Error exporting data: {ex.Message}\n\nStack Trace: {ex.StackTrace}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion
            }
        }
    }
}
