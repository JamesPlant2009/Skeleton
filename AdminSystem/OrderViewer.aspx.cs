using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write(AnOrder.OrderId);
        Response.Write(AnOrder.StockId);
        Response.Write(AnOrder.CustomerId);
        Response.Write(AnOrder.Price);
        Response.Write(AnOrder.DateAdded);
        Response.Write(AnOrder.OrderShipped);
        
    }
}