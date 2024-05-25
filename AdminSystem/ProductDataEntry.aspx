<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblproductid" runat="server" style="z-index: 1; left: 12px; top: 18px; position: absolute" Text="Product Id" width="89px"></asp:Label>
            <asp:TextBox ID="txtprice" runat="server" style="z-index: 1; top: 88px; position: absolute; right: 1218px;" width="136px"></asp:TextBox>
            
        </div>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="TxtproductName" runat="server"  style="z-index: 1; top: 50px; position: absolute; right: 1218px;" width="136px"></asp:TextBox>
        <asp:Label ID="lblproductName" runat="server" style="z-index: 1; left: 11px; top: 53px; position: absolute" Text="Product Name"></asp:Label>
        <p>
        <asp:Label ID="lblLastOrder" runat="server" style="z-index: 1; left: 12px; top: 124px; position: absolute" Text="Last Order" width="89px"></asp:Label>
        </p>
        <asp:TextBox ID="txtproductid" runat="server" style="z-index: 1; top: 14px; position: absolute; right: 1218px" width="136px"></asp:TextBox>
        <asp:TextBox ID="TxtLastOrder" runat="server" style="z-index: 1; top: 119px; position: absolute; right: 1218px;" width="136px"></asp:TextBox>
        <asp:TextBox ID="TxtDateAdded" runat="server" style="z-index: 1; top: 158px; position: absolute; right: 1226px;" width="128"></asp:TextBox>
        <p>
        <asp:Label ID="lbldateadded" runat="server" style="z-index: 1; left: 12px; top: 160px; position: absolute" Text="Date Added" width="89px"></asp:Label>
        </p>
        <p>
            <asp:CheckBox ID="chkInStock" runat="server" style="z-index: 1; left: 138px; top: 196px; position: absolute" Text="Stocked" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 76px; top: 235px; position: absolute; height: 17px"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnOk" runat="server"  style="z-index: 1; left: 60px; top: 279px; position: absolute" Text="Ok" OnClick="btnOk_Click1" />
        <asp:Button ID="btnCancel" runat="server"  style="z-index: 1; left: 161px; top: 277px; position: absolute" Text="Cancel" />
        <p>
            <asp:Label ID="lblInStock" runat="server" style="z-index: 1; left: 12px; position: absolute; top: 198px" Text="In Stock" width="89px"></asp:Label>
        </p>
        <asp:Label ID="lblprices" runat="server" style="z-index: 1; left: 12px; top: 89px; position: absolute" Text="price" width="89px"></asp:Label>
    </form>
</body>
</html>
