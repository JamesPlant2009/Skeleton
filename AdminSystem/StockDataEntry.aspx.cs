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
        AnStock.SupplierId = txtSupplierID.Text;    
        AnStock.ProductId = Convert.ToInt32(txtProductID.Text);
        AnStock.OrderId = txtOrderID.Text;
        AnStock.StaffId = Convert.ToInt32(txtStaffID.Text);
        AnStock.LastOrder = Convert.ToDateTime(txtLastOrder.Text);
        AnStock.InStock = ChkStock.Checked;
        Session["AnStock"] = AnStock;
        Response.Redirect("StockViewer.aspx");
    }

    protected void txtStockID_TextChanged(object sender, EventArgs e)
    {

    }
}