using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        public clsStockCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("dbo.sproc_tblStock_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStock AnStock = new clsStock();

                AnStock.StockId = Convert.ToString(DB.DataTable.Rows[Index]["StockId"]);
                AnStock.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierId"]);
                AnStock.ProductId = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductId"]);
                AnStock.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnStock.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnStock.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["InStock"]);
                AnStock.LastOrder = Convert.ToDateTime(DB.DataTable.Rows[Index]["LastOrder"]);
                mStockList.Add( AnStock );
                Index++;
            }
        }   
        public List<clsStock> mStockList = new List<clsStock>();

        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }

        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {
               
            }
        }

        public clsStock ThisStock { get; set; }
    }
}