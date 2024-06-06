using System;
using System.Web.UI;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Check if the customer object is stored in the session
            if (Session["Customer"] != null)
            {
                // Load the customer data from the session
                Customer customer = (Customer)Session["Customer"];
                DisplayCustomer(customer);
            }
            else
            {
                Response.Redirect("CustomerList.aspx");
            }
        }
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }

    private void DisplayCustomer(Customer customer)
    {
        lblCustomerID.Text = "Customer ID: " + customer.CustomerID;
        lblFirstName.Text = "First Name: " + customer.FirstName;
        lblLastName.Text = "Last Name: " + customer.LastName;
        lblEmail.Text = "Email: " + customer.Email;
    }

    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
