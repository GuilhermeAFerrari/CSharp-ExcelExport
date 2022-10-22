using CSharp_ExcelExport.Entities;
using System.Globalization;

namespace CSharp_ExcelExport
{
    static class SeedData
    {
        public static List<ShopCart> SeedCart()
        {
            List<ShopCart> purchases = new List<ShopCart>();

            purchases.Add(new ShopCart { Id = 1, CartNumber = 105, TotalValue = decimal.Parse("599.59", CultureInfo.InvariantCulture), LastUpdate = DateTime.Now });
            purchases.Add(new ShopCart { Id = 2, CartNumber = 206, TotalValue = decimal.Parse("699.99", CultureInfo.InvariantCulture), LastUpdate = DateTime.Now });
            purchases.Add(new ShopCart { Id = 3, CartNumber = 307, TotalValue = decimal.Parse("1299.89", CultureInfo.InvariantCulture), LastUpdate = DateTime.Now });
            purchases.Add(new ShopCart { Id = 4, CartNumber = 408, TotalValue = decimal.Parse("999.99", CultureInfo.InvariantCulture), LastUpdate = DateTime.Now });
            purchases.Add(new ShopCart { Id = 5, CartNumber = 509, TotalValue = decimal.Parse("1599.59", CultureInfo.InvariantCulture), LastUpdate = DateTime.Now });

            return purchases;
        }
    }
}
