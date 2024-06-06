<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Viewer</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Customer Details</h1>
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID: "></asp:Label>
            <br />
            <asp:Label ID="lblFirstName" runat="server" Text="First Name: "></asp:Label>
            <br />
            <asp:Label ID="lblLastName" runat="server" Text="Last Name: "></asp:Label>
            <br />
            <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
            <br /><br />
            <asp:Button ID="btnBack" runat="server" Text="Back to List" OnClick="btnBack_Click" />
        </div>
    </form>
</body>
</html>
