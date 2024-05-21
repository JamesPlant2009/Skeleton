using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private Int32 mOrderId;
        private DateTime mDateOrdered;
        private bool mOrderShipped;
        private string mStockId;
        private Int32 mCustomerId;
        private Int32 mPrice;

        public bool OrderShipped 
        {
            get 
            {  
                return mOrderShipped; 
            }
            set
            {
                mOrderShipped = value;
            }
        }
        public DateTime DateOrdered 
        {
            get
            {
                return mDateOrdered;
            }
            set
            {
                mDateOrdered = value;
            }
        }
        public string StockId {
            get
            {
                return mStockId;
            }
            set
            {
                mStockId = value;
            }
        }
        public Int32 CustomerId 
        {
            get
            {
                return mCustomerId;
            }
            set
            {
                mCustomerId = value;
            }
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
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }

        public bool Find(int orderId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrederId", OrderId);
            DB.Execute("sproc_tblOrder_FilterByOrder");
            if(DB.Count == 1 )
            {
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["orderId"]);
                mStockId = Convert.ToString(DB.DataTable.Rows[0]["StockId"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mDateOrdered = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOrdered"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                mOrderShipped = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderShipped"]);
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
   
}