using System;

namespace ClassLibrary
{
    public class clsProducts
    {
        public clsProducts()
        {

        }
        public string productName { get; set; }
        public Int32 price {  get; set; }
        public DateTime lastOrder { get; set; }
        public DateTime dateAdded { get; set; }
        public bool inStock { get; set; }
        public Int32 productId { get; set; }
    }
}