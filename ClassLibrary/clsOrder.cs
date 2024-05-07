using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool OrderShipped { get; set; }
        public DateTime DateAdded { get; set; }
        public string StockId { get; set; }
        public Int32 CustomerId { get; set; }
        public Int32 OrderId { get; set; }
    }
   
}