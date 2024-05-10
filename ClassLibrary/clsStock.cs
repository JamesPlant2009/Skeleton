using System;
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
        private string mOrderId;
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


        public string OrderId
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

        public bool Find(string stockID)
        {
            mInStock = true;
            mLastOrder = Convert.ToDateTime("10/05/2024");
            mStockId = "AP21";
            mSupplierId = 21;
            mProductId = 21;
            mOrderId = "21";
            mStaffId = 21;

            return true;
        }
    }
}