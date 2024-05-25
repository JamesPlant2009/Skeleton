using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsProducts AnProduct = new clsProducts();
        AnProduct = (clsProducts)Session["anproduct"];
        Response.Write(AnProduct.productId);
        Response.Write(AnProduct.productName);
        Response.Write(AnProduct.price);
        Response.Write(AnProduct.lastOrder);
        Response.Write(AnProduct.dateAdded);
        Response.Write(AnProduct.inStock);
            
    }
}