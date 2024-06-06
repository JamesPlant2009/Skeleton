<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Data Entry</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Customer Data Entry</h1>
            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID: "></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblFirstName" runat="server" Text="First Name: "></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblLastName" runat="server" Text="Last Name: "></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </div>
    </form>
</body>
</html>
