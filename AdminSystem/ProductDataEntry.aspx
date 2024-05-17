<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="lblproductid" runat="server" style="z-index: 1; left: 14px; top: 14px; position: absolute" Text="Product Id"></asp:Label>
            </p>
        <div>
            <asp:TextBox ID="txtprice" runat="server" style="z-index: 1; left: 125px; top: 92px; position: absolute"></asp:TextBox>
        </div>
        <p>
            Price&nbsp;</p>
        <asp:TextBox ID="TxtproductName" runat="server" style="z-index: 1; left: 124px; top: 49px; position: absolute"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtproductid" runat="server" style="z-index: 1; top: 13px; position: absolute; right: 1260px"></asp:TextBox>
        <asp:Label ID="lblLastOrder" runat="server" style="z-index: 1; left: 11px; top: 124px; position: absolute" Text="Last Order"></asp:Label>
        <asp:Label ID="lbldateadded" runat="server" style="z-index: 1; left: 17px; top: 158px; position: absolute" Text="Date Added"></asp:Label>
        <asp:TextBox ID="TxtLastOrder" runat="server" style="z-index: 1; left: 128px; top: 126px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TxtDateAdded" runat="server" style="z-index: 1; left: 132px; top: 158px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblInStock" runat="server" style="z-index: 1; left: 27px; position: absolute; top: 196px" Text="In Stock"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:CheckBox ID="chkInStock" runat="server" style="z-index: 1; left: 138px; top: 196px; position: absolute" Text="Stocked" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 76px; top: 235px; position: absolute; height: 17px"></asp:Label>
            <asp:Label ID="lblprice" runat="server" style="z-index: 1; left: 19px; position: absolute; bottom: 762px" Text="Price"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 60px; top: 279px; position: absolute; height: 26px;" Text="Ok" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 161px; top: 277px; position: absolute" Text="Cancel" />
        <p>
        <asp:Label ID="lblproductName" runat="server" style="z-index: 1; left: 8px; top: 48px; position: absolute; height: 21px;" Text="Product Name"></asp:Label>
        </p>
    </form>
</body>
</html>
