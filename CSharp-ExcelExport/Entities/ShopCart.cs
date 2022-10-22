using System.ComponentModel;

namespace CSharp_ExcelExport.Entities
{
    public class ShopCart
    {
        [Description("Identifier")]
        public int Id { get; set; }

        [Description("Number of cart")]
        public int CartNumber { get; set; }

        [Description("Total value")]
        public decimal TotalValue { get; set; }

        [Description("Last update")]
        public DateTime LastUpdate { get; set; }
    }
}
