using System;
using System.Collections.Generic;
using System.Web.UI;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // If the page is not being loaded as a result of a postback, check if a CustomerID is in the session
            if (Session["CustomerID"] != null)
            {
                int customerId = (int)Session["CustomerID"];
                lblMessage.Text = $"Are you sure you want to delete customer with ID {customerId}?";
            }
            else
            {
                Response.Redirect("CustomerList.aspx");
            }
        }
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        if (Session["CustomerID"] != null)
        {
            int customerId = (int)Session["CustomerID"];
            // Implement delete functionality here, e.g., delete from database
            DeleteCustomer(customerId);
            Response.Redirect("CustomerList.aspx");
        }
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }

    private void DeleteCustomer(int customerId)
    {
        // In reality, delete the customer from the database
        // Here we just display a success message for demonstration
        lblMessage.Text = $"Customer with ID {customerId} deleted successfully!";
    }
}
