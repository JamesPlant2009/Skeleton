using System;
using System.Activities.Expressions;
using System.Activities.Validation;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 IdentityID;
    protected void Page_Load(object sender, EventArgs e)
    {
        IdentityID = Convert.ToInt32(Session["IdentityId"]);
        if (IsPostBack == false)
        {
            if (IdentityID != -1)
            {
                DisplayStock();
            }
        }
    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)//If data type changes this needs to change
    {
        clsStock AnStock = new clsStock();

        string StockId = txtStockID.Text;
        string SupplierId = txtSupplierID.Text;
        string ProductId = txtProductID.Text;
        string OrderId = txtOrderID.Text;
        string StaffId = txtStaffID.Text;
        string LastOrder = txtLastOrder.Text;
        string InStock = chkInStock.Text;
        string Error = "";
        Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder, StockId);
        if (Error == "")
        {
            AnStock.IdentityId = IdentityID;
            AnStock.StockId = StockId;
            AnStock.SupplierId = Convert.ToInt32(SupplierId);
            AnStock.ProductId = Convert.ToInt32(ProductId);
            AnStock.OrderId = Convert.ToInt32(OrderId);
            AnStock.StaffId = Convert.ToInt32(StaffId);
            AnStock.LastOrder = Convert.ToDateTime(LastOrder);
            AnStock.InStock = chkInStock.Checked;
            clsStockCollection StockList = new clsStockCollection();

            if (IdentityID == -1)
            {
                StockList.ThisStock = AnStock;
                StockList.Add();
            }

            else
            {
                StockList.ThisStock.Find(IdentityID);
                StockList.ThisStock = AnStock;
                StockList.Update();
            }
            Response.Redirect("StockList.aspx");

        }
        else
        {
            lblError.Text = Error;
        }
    }




    protected void txtStockID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)//If data type changes this needs to change
    {
        clsStock AnStock = new clsStock();
        int IdentityID;
        Boolean Found = false;
        IdentityID = Convert.ToInt32(txtIdentityID.Text);
        Found = AnStock.Find(IdentityID);
        if (Found == true)
        {
            txtStockID.Text = AnStock.StockId.ToString();
            txtLastOrder.Text = AnStock.LastOrder.ToString();
            txtOrderID.Text = AnStock.OrderId.ToString();
            txtProductID.Text = AnStock.ProductId.ToString();
            txtStaffID.Text = AnStock.StaffId.ToString();
            txtSupplierID.Text = AnStock.SupplierId.ToString();
            chkInStock.Checked = AnStock.InStock;

        }
    }
        void DisplayStock()
        {
            

            clsStockCollection StockBook = new clsStockCollection();
            StockBook.ThisStock.Find(IdentityID);
            txtStockID.Text = StockBook.ThisStock.StockId;
            txtLastOrder.Text = StockBook.ThisStock.LastOrder.ToString();
            txtOrderID.Text =   StockBook.ThisStock.OrderId.ToString();
            txtProductID.Text = StockBook.ThisStock.ProductId.ToString();
            txtStaffID.Text = StockBook.ThisStock.StaffId.ToString();
            txtSupplierID.Text = StockBook.ThisStock.SupplierId.ToString();
            chkInStock.Checked = StockBook.ThisStock.InStock;

        }
    
}