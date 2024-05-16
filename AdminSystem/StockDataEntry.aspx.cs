using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsStock AnStock = new clsStock();
        //AnStock.StockId = txtStockID.Text;
        string SupplierId = txtSupplierID.Text;
        string ProductId = txtProductID.Text;
        string OrderId = txtOrderID.Text;
        string StaffId = txtStaffID.Text;
        string LastOrder = txtLastOrder.Text;
        string InStock = chkInStock.Text;
        string Error = "";
        Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
        if (Error == "")
        {
            AnStock.SupplierId = Convert.ToInt32(SupplierId);
            AnStock.ProductId = Convert.ToInt32(ProductId);
            AnStock.OrderId = Convert.ToInt32(OrderId);
            AnStock.StaffId = Convert.ToInt32(StaffId);
            AnStock.LastOrder = Convert.ToDateTime(LastOrder);

            Session["AnStock"] = AnStock;
            Response.Redirect("StockViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }
        



    protected void txtStockID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock AnStock = new clsStock();
        String StockID;
        Boolean Found = false;
        StockID = Convert.ToString(txtStockID.Text);
        Found = AnStock.Find(StockID);
        if (Found == true) 
        {
            txtLastOrder.Text = AnStock.LastOrder.ToString();
            txtOrderID.Text = AnStock.OrderId.ToString();
            txtProductID.Text = AnStock.ProductId.ToString();
            txtStaffID.Text = AnStock.StaffId.ToString();
            txtSupplierID.Text = AnStock.SupplierId.ToString();
            chkInStock.Checked = AnStock.InStock;

        }
    }
}