using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using VitaPharm.Data;
using Microsoft.EntityFrameworkCore;

namespace VitaPharm.Reports
{
    public partial class rptReceiptDetail : DevExpress.XtraReports.UI.XtraReport
    {
        public rptReceiptDetail()
        {
            InitializeComponent();
        }

        public void LoadData(int receiptId)
        {
            using (var context = new PharmacyDbContext())
            {
                var receipt = context.GoodsReceipts
                    .Include(r => r.Employee)
                    .FirstOrDefault(r => r.ReceiptID == receiptId);

                var details = context.GoodsReceiptDetails
                    .Include(d => d.Batch)
                    .ThenInclude(b => b.Commodity)
                    .Where(d => d.GoodsReceipt.ReceiptID == receiptId)
                    .ToList();

                var ds = new PharmacyManageDataSet();
                var dtMaster = ds.ReceiptList;
                var dtDetail = ds.ReceiptDetailList;

                // Add master data
                dtMaster.Rows.Add(
                    receipt.ReceiptID,
                    receipt.ReceiptCode,
                    receipt.ReceiptDate,
                    receipt.SupplierName,
                    receipt.Employee?.EmployeeName ?? "",
                    receipt.Note
                );

                // Add detail data
                foreach (var d in details)
                {
                    dtDetail.Rows.Add(
                        d.GoodsReceiptDetailID,
                        d.GoodsReceipt.ReceiptID,
                        d.Batch.BatchCode,
                        d.Batch.Commodity.CommodityName,
                        d.Batch.MfgDate,
                        d.Batch.ExpDate,
                        d.Batch.PurchasePrice,
                        d.QtyIn,
                        d.QtyIn * d.Batch.PurchasePrice
                    );
                }

                // Set data source
                this.DataSource = ds;
                this.DataMember = "ReceiptDetailList";

                // Set parameters
                this.Parameters["pReceiptCode"].Value = receipt.ReceiptCode;
                this.Parameters["pReceiptDate"].Value = receipt.ReceiptDate;
                this.Parameters["pSupplierName"].Value = receipt.SupplierName;
                this.Parameters["pEmployeeName"].Value = receipt.Employee?.EmployeeName ?? "";
                this.Parameters["pNote"].Value = receipt.Note;
                this.Parameters["pCompanyAddress"].Value = "123 Dau Lac, Long Xuyen, An Giang";
                this.Parameters["pCompanyTaxCode"].Value = "1900020407";

                // Hide parameters
                foreach (var param in this.Parameters)
                    param.Visible = false;
            }
        }
    }
}
