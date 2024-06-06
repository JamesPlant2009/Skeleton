<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer List</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Customer List</h1>
            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
            <asp:ListBox ID="lstCustomerList" runat="server" Width="300px" Height="200px"></asp:ListBox>
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            <br /><br />
            <asp:Label ID="lblSearch" runat="server" Text="Search by Last Name: "></asp:Label>
            <asp:TextBox ID="txtLastNameSearch" runat="server"></asp:TextBox>
            <asp:Button ID="btnFilter" runat="server" Text="Filter" OnClick="btnFilter_Click" />
            <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
            <br /><br />
            <asp:Button ID="btnMainMenu" runat="server" Text="Main Menu" OnClick="btnMainMenu_Click" />
        </div>
    </form>
</body>
</html>
