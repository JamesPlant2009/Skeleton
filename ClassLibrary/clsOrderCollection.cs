using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();

        public clsOrderCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            populateArray(DB);
        }


        public List<clsOrder> OrderList 
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }
        public int Count 
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {
            }
        }
        public clsOrder ThisOrder 
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockId", mThisOrder.StockId);
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@Price", mThisOrder.Price);
            DB.AddParameter("@OrderDate", mThisOrder.DateOrdered);
            DB.AddParameter("@OrderShipped", mThisOrder.OrderShipped);
            return DB.Execute("sproc_tblOrder_Insert");
        }
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderId);
            DB.AddParameter("@StockId", mThisOrder.StockId);
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@Price", mThisOrder.Price);
            DB.AddParameter("@OrderDate", mThisOrder.DateOrdered);
            DB.AddParameter("@OrderShipped", mThisOrder.OrderShipped);

            DB.Execute("dbo.sproc_tblOrder_Update");
        }
        public void populateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 recordCount = 0;
            recordCount = DB.Count;
            mOrderList = new List<clsOrder>();
            while (Index < recordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["order_Id"]);
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["customer_Id"]);
                AnOrder.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["price"]);
                AnOrder.StockId = Convert.ToString(DB.DataTable.Rows[Index]["stock_Id"]);
                AnOrder.OrderShipped = Convert.ToBoolean(DB.DataTable.Rows[Index]["order_shipped"]);
                AnOrder.DateOrdered = Convert.ToDateTime(DB.DataTable.Rows[Index]["order_date"]);
                mOrderList.Add(AnOrder);
                Index++;
            }
        }
    }
}