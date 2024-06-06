<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Customer Deletion</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Confirm Customer Deletion</h1>
            <asp:Label ID="lblMessage" runat="server" Text="Are you sure you want to delete this customer?" ForeColor="Red"></asp:Label>
            <br /><br />
            <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click" />
            <asp:Button ID="btnNo" runat="server" Text="No" OnClick="btnNo_Click" />
        </div>
    </form>
</body>
</html>
