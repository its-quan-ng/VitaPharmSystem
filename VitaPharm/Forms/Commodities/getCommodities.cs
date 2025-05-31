using Microsoft.EntityFrameworkCore;
using VitaPharm.Data;
using System.Data;

namespace VitaPharm.Forms.Commodities
{
    internal class getCommodities
    {
        private PharmacyDbContext context;

        internal getCommodities(PharmacyDbContext dbContext)
        {
            context = dbContext;
        }

        internal List<dynamic> GetCommoditiesData()
        {
            return context.Commodities
                          .Include(c => c.Categories)
                          .AsEnumerable()
                          .Select((c, idx) => new
                          {
                              ID = idx + 1,
                              c.CommodityID,
                              c.CommodityName,
                              c.Manufacturer,
                              c.BaseUnit,
                              c.SellingPrice,
                              Status = c.IsTerminated,
                              CategoryName = c.Categories?.CategoryName
                          })
                          .Cast<dynamic>()
                          .ToList();
        }
    }
}