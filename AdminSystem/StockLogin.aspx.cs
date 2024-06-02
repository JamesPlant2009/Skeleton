using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class StockLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsStockUser AnUser = new clsStockUser();
        string UserName = txtBoxUserName.Text;
        string Password = txtBoxPassword.Text; 
        Boolean Found = false;
        UserName = Convert.ToString(txtBoxUserName.Text);
        Password = Convert.ToString(txtBoxPassword.Text);
        Found = AnUser.FindUser(UserName, Password);
        Session["AnUser"] = AnUser;

        if (txtBoxUserName.Text == "")
        {
            lblError.Text = "Enter a username";
        }
        else if (txtBoxPassword.Text =="")
        {
            lblError.Text = "Enter a password";
        }
        else if (Found == true)
        {
            Response.Redirect("StockList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Login Details are inccorect please try again";
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}