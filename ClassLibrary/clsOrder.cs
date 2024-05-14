using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private Int32 mOrderId;
        private DateTime mDateOrdered;
        private bool mOrderShipped;
        private string mStockId;
        private string mCustomerId;
        private Int32 mPrice;

        public bool OrderShipped 
        { 
            get; 
            set; 
        }
        public DateTime DateOrdered 
        { 
            get; 
            set; 
        }
        public string StockId { 
            get; 
            set; 
        }
        public Int32 CustomerId 
        { 
            get; 
            set; 
        }
        public Int32 OrderId 
        {
            get
            {
                return mOrderId;
            }
            set
            {
                mOrderId = value;
            }
        }
        public int Price 
        { 
            get; 
            set; 
        }

        public bool Find(int orderId)
        {
            mOrderId = 1;
            mDateOrdered = Convert.ToDateTime("14/05/2024");
            return true;
        }
    }
   
}