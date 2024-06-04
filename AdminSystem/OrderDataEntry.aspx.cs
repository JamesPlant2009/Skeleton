﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
        string OrderId = txtOrderId.Text;
        string StockId = txtStockId.Text;
        string CustomerId = txtCustomerId.Text;
        string Price = txtPrice.Text;
        string OrderShipped = chkShipped.Text;
        string DateOrdered = txtOderDate.Text;
        string Error = "";
        Error = AnOrder.Valid(StockId, CustomerId, Price, DateOrdered);
        if (Error == "")
        {
            AnOrder.StockId = StockId;
            AnOrder.CustomerId = Convert.ToInt32(CustomerId);
            AnOrder.OrderShipped = chkShipped.Checked;
            AnOrder.DateOrdered = Convert.ToDateTime(DateOrdered);
            AnOrder.Price = Convert.ToInt32(Price);
            clsOrderCollection OrderList = new clsOrderCollection();
            OrderList.ThisOrder = AnOrder;
            OrderList.Add();
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
}