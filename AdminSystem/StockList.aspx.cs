using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStocks();
        }

    }

    void DisplayStocks()
    {
        clsStockCollection AnStock = new clsStockCollection();
        lstStockList.DataSource = AnStock.StockList;
        lstStockList.DataValueField = "StockId";
        lstStockList.DataValueField = "ProductId";
        lstStockList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)//If data type changes this needs to change
    {
        Session["StockId"] = "";
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)//If data type changes this needs to change
    {
        string StockId;
        if (lstStockList.SelectedIndex.Equals(""))//again does this just work?
        { 
            StockId = lstStockList.SelectedValue;
            Session["StockId"] = StockId;
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list";
        }
    }
}
