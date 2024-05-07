using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public clsStock()
        {
        }

        public bool InStock { get; set; }
        public DateTime LastOrder { get; set; }
        public string StockId { get; set; }
        public string SupplierId { get; set; }
        public int ProductId { get; set; }
        public string OrderId { get; set; }
        public int StaffId { get; set; }
    }
}