<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 468px; top: 81px; position: absolute" Text="United Phones Main Menu"></asp:Label>
        <asp:Button ID="btnStock" runat="server" OnClick="btnStock_Click" style="z-index: 1; left: 359px; top: 234px; position: absolute" Text="Stock" />
        <asp:Button ID="btnCustomer" runat="server" style="z-index: 1; left: 458px; top: 236px; position: absolute" Text="Customer" />
        <asp:Button ID="btnStaff" runat="server" style="z-index: 1; left: 607px; top: 234px; position: absolute" Text="Staff" />
        <asp:Button ID="btnOrder" runat="server" style="z-index: 1; left: 406px; top: 319px; position: absolute" Text="Order" />
        <asp:Button ID="btnProduct" runat="server" style="z-index: 1; left: 577px; top: 321px; position: absolute" Text="Product" />
    </form>
</body>
</html>
