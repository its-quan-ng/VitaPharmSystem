public class GoodsReceiptDetailReportModel
{
    public string BatchCode { get; set; }
    public string CommodityName { get; set; }
    public DateTime MfgDate { get; set; }
    public DateTime ExpDate { get; set; }
    public decimal PurchasePrice { get; set; }
    public int Quantity { get; set; }
    public decimal Amount { get; set; }
}