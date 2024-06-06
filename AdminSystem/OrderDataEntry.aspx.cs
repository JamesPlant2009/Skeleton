using System;
using System.Collections.Generic;
using System.IdentityModel.Metadata;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderID = -1;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["IdentityId"]);
        if (IsPostBack == false)
        {
            if (OrderID != -1)
            {
                displayOrder();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        string StockId = txtStockId.Text;
        string CustomerId = txtCustomerId.Text;
        string Price = txtPrice.Text;
        string OrderShipped = chkShipped.Text;
        string DateOrdered = txtOderDate.Text;
        string Error = "";
        Error = AnOrder.Valid(StockId, CustomerId, Price, DateOrdered);
        if (Error == "")
        {
            AnOrder.OrderId = OrderID;
            AnOrder.StockId = StockId;
            AnOrder.CustomerId = Convert.ToInt32(CustomerId);
            AnOrder.Price = Convert.ToInt32(Price);
            AnOrder.DateOrdered = Convert.ToDateTime(DateOrdered);
            AnOrder.OrderShipped = chkShipped.Checked;
            clsOrderCollection OrderList = new clsOrderCollection();
            if (OrderID == -1)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderID);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnfind_Click(object sender, EventArgs e)
    {
        clsOrder anOrder = new clsOrder();
        Int32 orderId;
        Boolean Found = false;
        orderId = Convert.ToInt32(txtOrderId.Text);
        Found = anOrder.Find(orderId);
        if( Found == true)
        {
            txtStockId.Text = anOrder.StockId;
            txtCustomerId.Text = anOrder.CustomerId.ToString();
            txtPrice.Text = anOrder.Price.ToString();
            txtOderDate.Text = anOrder.DateOrdered.ToString();
            chkShipped.Checked = anOrder.OrderShipped;

        }

        
    }

    void displayOrder()
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        OrderBook.ThisOrder.Find(OrderID);
        txtStockId.Text = OrderBook.ThisOrder.StockId;
        txtCustomerId.Text = OrderBook.ThisOrder.CustomerId.ToString();
        txtPrice.Text = OrderBook.ThisOrder.OrderId.ToString();
        txtOderDate.Text = OrderBook.ThisOrder.DateOrdered.ToString();
        chkShipped.Checked = OrderBook.ThisOrder.OrderShipped;
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}