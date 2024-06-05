using System;

namespace ClassLibrary
{
    public class clsProducts
    {
        public clsProducts()
        {

        }
        private string mproductname;
        private Int32 mprice;
        private DateTime mLastOrder;
        private DateTime mdateAdded;
        private bool minStock;
        private Int32 mproductId;

        public string productName 
        {
            get
            {
                return mproductname;
            }
            set
            {
                mproductname = value;
            }
        }
        public Int32 price 
        {
            get
            {
                return mprice;
            }
            set
            {
                mprice = value;
            }
        }
        public DateTime lastOrder 
        {
            get
            {
                return mLastOrder;
            }
            set
            {
                mLastOrder = value;
            }
        }
        public DateTime dateAdded 
        {
            get
            {
                return mdateAdded;  

            }
            set
            {
                mdateAdded = value;
            }
        }
        public bool inStock 
        {
            get
            {
                return minStock;
            }
            set
            {
                minStock = value;
            }
        }
        public Int32 productId 
        { get
            {
                return mproductId;
            }
            set
            {
                mproductId = value;
            }
        }
        public string Valid(string productName, string price, string LastOrder, string DateAdded )
        {

        }
    }
}