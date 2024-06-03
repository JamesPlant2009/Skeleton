using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    Int32 IdentityId;
    protected void Page_Load(object sender, EventArgs e)
    {
        IdentityId = Convert.ToInt32(Session["IdenitityId"]);
        if (IsPostBack == false)
        {
            if(IdentityId != -1)
            {
                DisplayStocks();
            }
            
        }
        clsStockUser AnUser = new clsStockUser();
        AnUser = (clsStockUser)Session["AnUser"];
        Response.Write("Logged in as: " + AnUser.UserName);

    }

    void DisplayStocks()
    {
        clsStockCollection AnStock = new clsStockCollection();
        lstStockList.DataSource = AnStock.StockList;
        lstStockList.DataValueField = "ProductId";
        lstStockList.DataValueField = "StockId";
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

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 IdentityId;

        if(lstStockList.SelectedIndex != -1 )
        {
            IdentityId = Convert.ToInt32(lstStockList.SelectedValue);
            Session["IdentityId"] = IdentityId;
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnFilter_Click(object sender, EventArgs e)
    {
        clsStockCollection AnStock = new clsStockCollection();
        AnStock.ReportByStockId(txtBoxFilter.Text);
        lstStockList.DataSource = AnStock.StockList;
        lstStockList.DataValueField = "IdentityId";
        lstStockList.DataValueField = "StockId";
        lstStockList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStockCollection AnStock = new clsStockCollection();
        AnStock.ReportByStockId("");
        txtBoxFilter.Text = "";
        lstStockList.DataSource = AnStock.StockList;
        lstStockList.DataValueField = "IdentityId";
        lstStockList.DataValueField = "StockId";
        lstStockList.DataBind();
    }

    protected void lstStockList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
