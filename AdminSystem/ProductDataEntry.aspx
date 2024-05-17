<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblproductid" runat="server" style="z-index: 1; left: 13px; top: 18px; position: absolute" Text="Product Id"></asp:Label>
            <asp:TextBox ID="txtprice" runat="server" style="z-index: 1; left: 125px; top: 92px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblprice" runat="server" style="z-index: 1; left: 17px; position: absolute; bottom: 564px" Text="Price"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="TxtproductName" runat="server"  style="z-index: 1; left: 124px; top: 49px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblproductName" runat="server" style="z-index: 1; left: 12px; top: 44px; position: absolute" Text="Product Name"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtproductid" runat="server" style="z-index: 1; top: 13px; position: absolute; right: 1260px"></asp:TextBox>
        <asp:Label ID="lblLastOrder" runat="server" style="z-index: 1; left: 11px; top: 124px; position: absolute" Text="Last Order"></asp:Label>
        <asp:Label ID="lbldateadded" runat="server" style="z-index: 1; left: 17px; top: 158px; position: absolute" Text="Date Added"></asp:Label>
        <asp:TextBox ID="TxtLastOrder" runat="server" style="z-index: 1; left: 128px; top: 126px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TxtDateAdded" runat="server" style="z-index: 1; left: 132px; top: 158px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="lblInStock" runat="server" style="z-index: 1; left: 14px; position: absolute; top: 186px" Text="In Stock"></asp:Label>
        </p>
        <p>
            <asp:CheckBox ID="chkInStock" runat="server" style="z-index: 1; left: 138px; top: 196px; position: absolute" Text="Stocked" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 76px; top: 235px; position: absolute; height: 17px"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnOk" runat="server"  style="z-index: 1; left: 60px; top: 279px; position: absolute" Text="Ok" />
        <asp:Button ID="btnCancel" runat="server"  style="z-index: 1; left: 161px; top: 277px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
