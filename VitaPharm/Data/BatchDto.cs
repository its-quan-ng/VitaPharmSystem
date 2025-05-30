using System;

namespace VitaPharm.Data
{
    public class BatchDto
    {
        public int BatchID { get; set; };
        public string BatchCode { get; set; } = "";
        public int CommodityID { get; set; }
        public string CommodityName { get; set; } = "";
        public DateTime MfgDate { get; set; }
        public DateTime ExpDate { get; set; }
        public decimal PurchasePrice { get; set; }
        public int Qty { get; set; } 
        public decimal Amount => Qty * PurchasePrice;
    }
} 
