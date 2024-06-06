using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    List<Customer> CustomerList;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadCustomers();
            DisplayCustomers();
        }

        clsOrderUser AnUser = (clsOrderUser)Session["AnUser"];
        if (AnUser != null)
        {
            Response.Write("Logged in as: " + AnUser.UserName);
        }
    }

    void LoadCustomers()
    {
        // In reality, load customers from the database
        CustomerList = new List<Customer>
        {
            new Customer { CustomerID = 1, FirstName = "John", LastName = "Doe", Email = "john@example.com" },
            new Customer { CustomerID = 2, FirstName = "Jane", LastName = "Doe", Email = "jane@example.com" }
        };
    }

    void DisplayCustomers()
    {
        lstCustomerList.DataSource = CustomerList;
        lstCustomerList.DataValueField = "CustomerID";
        lstCustomerList.DataTextField = "LastName";
        lstCustomerList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["CustomerID"] = -1;
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        if (lstCustomerList.SelectedIndex != -1)
        {
            int CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustomerID"] = CustomerID;
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select an entry to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        if (lstCustomerList.SelectedIndex != -1)
        {
            int CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            // Implement delete functionality here, e.g., delete from database
            CustomerList.RemoveAll(c => c.CustomerID == CustomerID);
            DisplayCustomers();
        }
        else
        {
            lblError.Text = "Please select an entry to delete";
        }
    }

    protected void btnFilter_Click(object sender, EventArgs e)
    {
        string searchLastName = txtLastNameSearch.Text;
        var filteredList = CustomerList.FindAll(c => c.LastName.Contains(searchLastName));
        lstCustomerList.DataSource = filteredList;
        lstCustomerList.DataValueField = "CustomerID";
        lstCustomerList.DataTextField = "LastName";
        lstCustomerList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtLastNameSearch.Text = "";
        DisplayCustomers();
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
