using System;
using System.Collections.Generic;

namespace ClassLibrary
{

    public class clsStockCollection
    {
        public List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisStock = new clsStock();
        public clsStockCollection()//If data type changes this needs to change
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("dbo.sproc_tblStock_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStock AnStock = new clsStock();

                AnStock.IdentityId = Convert.ToInt32(DB.DataTable.Rows[Index]["IdentityId"]);
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

        public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }


        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            //DB.AddParameter("@IdentityID", mThisStock.IdentityId);
            DB.AddParameter("@StockID", mThisStock.StockId);
            DB.AddParameter("@SupplierId", mThisStock.SupplierId);
            DB.AddParameter("@ProductId", mThisStock.ProductId);
            DB.AddParameter("@OrderId", mThisStock.OrderId);
            DB.AddParameter("@StaffId", mThisStock.StaffId);
            DB.AddParameter("@lastOrder", mThisStock.LastOrder);
            DB.AddParameter("@InStock", mThisStock.InStock);

            return DB.Execute("dbo.sproc_tblStock_Insert");

        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@IdentityId", mThisStock.IdentityId);
            DB.Execute("dbo.sproc_tblStock_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@IdentityID", mThisStock.IdentityId);
            DB.AddParameter("@StockId", mThisStock.StockId);
            DB.AddParameter("@SupplierId", mThisStock.SupplierId);
            DB.AddParameter("@ProductId", mThisStock.ProductId);
            DB.AddParameter("@OrderId", mThisStock.OrderId);
            DB.AddParameter("@StaffId", mThisStock.StaffId);
            DB.AddParameter("@lastOrder", mThisStock.LastOrder);
            DB.AddParameter("@InStock", mThisStock.InStock);

            DB.Execute("dbo.sproc_tblStock_Update");
        }

        
    }
}