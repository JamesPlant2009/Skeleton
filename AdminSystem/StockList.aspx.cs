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
        Session["IdentityId"] = -1;
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)//If data type changes this needs to change
    {
        Int32 IdentityId;
        if (lstStockList.SelectedIndex != -1 ) 
        {
            IdentityId = Convert.ToInt32(lstStockList.SelectedValue);
            Session["IdentityId"] = IdentityId;
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please Select a record from the list to edit";
        }
    }
}
