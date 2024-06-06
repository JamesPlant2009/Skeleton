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
            string error = "";
            Int32 TempInt;
            DateTime tempDate1, tempDate2;
            if ( productName.Length == 0 )
            {
                error = error + "do not leave it empty";
            }
            if (productName.Length >=10 )
            {
                error = error + "not more than 10 character";
            }
            try
            {
                TempInt = Convert.ToInt32(price);
                tempDate1 = Convert.ToDateTime(LastOrder);
                tempDate2 = Convert.ToDateTime(DateAdded);
                if ( TempInt < 0 )
                {
                    error = error + "not accepting negative numbers";
                }
                if (TempInt > 10000)
                {
                    error = error + "not more than 10000";
                }
                if (tempDate1 < DateTime.Now.Date)
                {
                    error = error + " The date cannot be in the past";
                }
                if (tempDate1 > DateTime.Now.Date)
                {
                    error = error + " The date cannot be in the future";
                }
                if (tempDate2 < DateTime.Now.Date)
                {
                    error = error + " The date cannot be in the past";
                }
                if (tempDate2 > DateTime.Now.Date)
                {
                    error = error + " The date cannot be in the future";
                }
            }
            catch
            {
                error = error + "must be a valid data type";
            }
            return error; 
        }
    }
}