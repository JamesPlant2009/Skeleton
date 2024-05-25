using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click1(object sender, EventArgs e)
    {
        clsProducts anproduct = new clsProducts();
        anproduct.productId = Convert.ToInt32(txtproductid.Text);
        anproduct.productName = TxtproductName.Text;
        anproduct.price = Convert.ToInt32(txtprice.Text);
        anproduct.lastOrder = Convert.ToDateTime(DateTime.Now);
        anproduct.dateAdded = Convert.ToDateTime(DateTime.Now);
        anproduct.inStock = chkInStock.Checked;
        Session["anproduct"] = anproduct;
        Response.Redirect("ProductViewer.aspx");
    }
}