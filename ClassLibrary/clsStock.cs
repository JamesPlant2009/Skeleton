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
        private int mIdentityID;

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



        public string StockId//If data type changes this needs to change
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


        public int IdentityId//If data type changes this needs to change
        {
            get
            {
                return mIdentityID;
            }
            set
            {
                mIdentityID = value;
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


        public int StaffId//If data type changes this needs to change
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

        public bool Find(int IdentityID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@IdentityID", IdentityID); 
            DB.Execute("dbo.sproc_tblStock_FilteringByStockID");
            if (DB.Count == 1)
            {
                mIdentityID = Convert.ToInt32(DB.DataTable.Rows[0]["IdentityID"]);
                mStockId = Convert.ToString(DB.DataTable.Rows[0]["StockID"]);//If data type changes this needs to change
                mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);
                mLastOrder = Convert.ToDateTime(DB.DataTable.Rows[0]["LastOrder"]);
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);//If data type changes this needs to change
                return true;
            }
            else
            {
                return false;
            }

        }

        public string Valid(string SupplierId, string ProductId, string OrderId, string StaffId, string LastOrder, string StockId)
        {
            DateTime DateTemp;
            string Error = "";
            Int64 max = 2147483647;
            Int64 min = 0;
            

            try
            {
                Int64 Order = Convert.ToInt64(OrderId);
                Int64 Staff = Convert.ToInt64(StaffId);//Need to add a stockId one but will come back to this.
                Int64 Product = Convert.ToInt64(ProductId);
                Int64 Supplier = Convert.ToInt64(SupplierId);

                DateTemp = Convert.ToDateTime(LastOrder);

                if (Order <= min)
                {
                    Error = Error + "The  OrderId must be greater than 0 : ";
                }
                if (Order > max)
                {
                    Error = Error + "The  OrderId must be smaller than 2,147,483,647 : ";
                }

                if (Staff <= min)//If data type changes this needs to change
                {
                    Error = Error + "The  OrderId must be greater than 0 : ";
                }
                if (Staff > max)
                {
                    Error = Error + "The  OrderId must be smaller than 2,147,483,647 : ";
                }

                if (Product <= min)
                {
                    Error = Error + "The  OrderId must be greater than 0 : ";
                }
                if (Product > max)
                {
                    Error = Error + "The  OrderId must be smaller than 2,147,483,647 : ";
                }


                if (Supplier <= min)
                {
                    Error = Error + "The  OrderId must be greater than 0 : ";
                }
                if (Supplier > max)
                {
                    Error = Error + "The  OrderId must be smaller than 2,147,483,647 : ";
                }


                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future";
                }

                if (StockId.Length == 0)
                {
                    Error = Error + "The Stock ID must not be blank";
                }
                if (StockId.Length > 8)
                {
                    Error = Error + "Must be less than 8";
                }

                return Error;
            }
            
            catch
            {
                Error = Error + " Must be an int";
                return Error;
            }



        }
    }
}