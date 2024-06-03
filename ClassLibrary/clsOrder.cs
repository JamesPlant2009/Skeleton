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
            DB.AddParameter("@OrderId", orderId);
            DB.Execute("sproc_tblOrder_FilterByOrederId");
            if(DB.Count == 1 )
            {
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["order_Id"]);
                mStockId = Convert.ToString(DB.DataTable.Rows[0]["stock_Id"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["customer_Id"]);
                mDateOrdered = Convert.ToDateTime(DB.DataTable.Rows[0]["order_date"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["price"]);
                mOrderShipped = Convert.ToBoolean(DB.DataTable.Rows[0]["order_shipped"]);
                return true;
            }
            else 
            {
                return false;
            }
        }

        public string Valid(string StockId, string CustomerId, string price, string OrderDate)
        {
            string error = "";
            DateTime tempDate;
            Int32 tempInt2, tempInt1;
            if (StockId.Length == 0)
            {
                error = error + " The Stock Id must not be left blank";
            }
            if (StockId.Length > 8) 
            {
                error = error + " The lenght of Stock Id must not be more than 8 chars";
            }
            try
            {
                tempDate = Convert.ToDateTime(OrderDate);
                tempInt1 = Convert.ToInt32(price);
                tempInt2 = Convert.ToInt32(CustomerId);

                if (tempDate < DateTime.Now.Date)
                {
                    error = error + " The date cannot be in the past";
                }
                if (tempDate > DateTime.Now.Date)
                {
                    error = error + " The date cannot be in the future";
                }
                if (tempInt1 < 0)
                {
                    error = error + " The price cannot be below 0";
                }
                if (tempInt1 > 10000)
                {
                    error = error + " The price cannot be over 10000";
                }
                if (tempInt2 < 0)
                {
                    error = error + " The price cannot be below 0";
                }
                if (tempInt2 > 10000)
                {
                    error = error + " The price cannot be over 10000";
                }
                return error;
            }
            catch
            {
                error += " Please input the correct data format";
                return error;
            }
        }

    }
   
}