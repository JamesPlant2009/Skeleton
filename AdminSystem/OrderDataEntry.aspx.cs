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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder.StockId = txtStockId.Text;
        AnOrder.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        AnOrder.OrderId = Convert.ToInt32(txtOrderId.Text);
        AnOrder.OrderShipped =chkShipped.Checked;
        AnOrder.DateAdded = Convert.ToDateTime(DateTime.Now);
        AnOrder.Price = Convert.ToInt32(txtPrice.Text);
        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");
    }
}