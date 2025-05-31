using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitaPharm.Data
{
    public class InvoiceLineDto
    {
        public int ID { get; set; }   
        public int CommodityID { get; set; }
        public string CommodityName { get; set; }  
        public int BatchID { get; set; }
        public string BatchCode { get; set; }
        public string BaseUnit { get; set; } 
        public decimal SellingPrice { get; set; } 
        public int Qty { get; set; }
        public decimal Amount { get; set; }  
    }
}
