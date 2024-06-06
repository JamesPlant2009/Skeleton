using System;
using System.Collections.Generic;
using System.Web.UI;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // If the page is not being loaded as a result of a postback, check if we're editing an existing customer
            if (Session["CustomerID"] != null)
            {
                int customerId = (int)Session["CustomerID"];
                if (customerId != -1)
                {
                    // Load the customer data for editing
                    LoadCustomerData(customerId);
                }
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Validate and save the customer data
        if (IsValid)
        {
            if (Session["CustomerID"] != null)
            {
                int customerId = (int)Session["CustomerID"];
                if (customerId == -1)
                {
                    // Add new customer
                    AddCustomer();
                }
                else
                {
                    // Edit existing customer
                    EditCustomer(customerId);
                }

                Response.Redirect("CustomerList.aspx");
            }
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        // Redirect to the customer list page without saving
        Response.Redirect("CustomerList.aspx");
    }

    private void LoadCustomerData(int customerId)
    {
        // In reality, load customer data from the database
        // Here we use dummy data for demonstration
        var customer = new Customer
        {
            CustomerID = customerId,
            FirstName = "John",
            LastName = "Doe",
            Email = "john@example.com"
        };

        txtCustomerID.Text = customer.CustomerID.ToString();
        txtFirstName.Text = customer.FirstName;
        txtLastName.Text = customer.LastName;
        txtEmail.Text = customer.Email;
    }

    private void AddCustomer()
    {
        // In reality, add the customer to the database
        // Here we just display a success message
        lblError.Text = "Customer added successfully!";
    }

    private void EditCustomer(int customerId)
    {
        // In reality, update the customer in the database
        // Here we just display a success message
        lblError.Text = "Customer updated successfully!";
    }

    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
