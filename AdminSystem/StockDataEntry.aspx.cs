using System;
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
        AnStock.StockId = txtStockID.Text;
        AnStock.SupplierId = Convert.ToInt32(txtSupplierID.Text);    
        AnStock.ProductId = Convert.ToInt32(txtProductID.Text);
        AnStock.OrderId = Convert.ToInt32(txtOrderID.Text);
        AnStock.StaffId = Convert.ToInt32(txtStaffID.Text);
        AnStock.LastOrder = Convert.ToDateTime(txtLastOrder.Text);
        AnStock.InStock = chk.Checked;
        Session["AnStock"] = AnStock;
        Response.Redirect("StockViewer.aspx");
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
            chk.Checked = AnStock.InStock;

        }
    }
}