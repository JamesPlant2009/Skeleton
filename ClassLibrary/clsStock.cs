﻿using System;
using System.Runtime.CompilerServices;

namespace ClassLibrary
{
    public class clsStock
    {
        private string mStockId;
        private Boolean mInStock;
        private DateTime mLastOrder;
        private int mSupplierId;
        private int mProductId;
        private int mOrderId;
        private int mStaffId;

        public bool InStock
        {
            get
            {
                return mInStock;
            }
            set
            {
                mInStock = value;
            }
        }



        public DateTime LastOrder
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



        public string StockId
        {
            get
            {
                return mStockId;
            }
            set
            {
                mStockId = value;
            }
        }




        public int SupplierId
        {
            get
            {
                return mSupplierId;
            }
            set
            {
                mSupplierId = value;
            }
        }




        public int ProductId
        {
            get
            {
                return mProductId;
            }
            set
            {
                mProductId = value;
            }
        }


        public int OrderId
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


        public int StaffId
        {
            get
            {
                return mStaffId;
            }
            set
            {
                mStaffId = value;
            }
        }

        public bool Find(string StockID)
        {
         clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockID", StockID); //should be StockID?
            DB.Execute("dbo.sproc_tblStock_FilteringByStockID");
            if (DB.Count == 1)
            {
                mStockId = Convert.ToString(DB.DataTable.Rows[0]["StockID"]);
                mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);
                mLastOrder = Convert.ToDateTime(DB.DataTable.Rows[0]["LastOrder"]);
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                return true;
            }
            else
            {
                return false;
            }

        }

        public string Valid(string supplierId, string productId, string orderId, string staffId, string lastOrder)
        {
            string Error = "";
            
            Int64 result = Convert.ToInt64(orderId);
            if (OrderId <= 0)
            {
                Error = Error + "The  OrderId must be greater than 0 : ";
            }
            if (OrderId > 2147483647)
                {
                Error = Error + "The  OrderId must be smaller than 2,147,483,647 : ";
            }
            return Error;
        }
    }
}