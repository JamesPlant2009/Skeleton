<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockLogin.aspx.cs" Inherits="StockLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 6px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 808px; top: 225px; position: absolute" Text="UserName:"></asp:Label>
        </p>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 811px; top: 288px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtBoxUserName" runat="server" style="z-index: 1; left: 956px; top: 225px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtBoxPassword" runat="server" style="z-index: 1; left: 955px; top: 287px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 892px; top: 375px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 1023px; top: 374px; position: absolute" Text="Cancel" />
        <p>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 928px; top: 139px; position: absolute; height: 95px; width: 337px" Text="Stock Login Page"></asp:Label>
        </p>
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 1203px; top: 265px; position: absolute" Text="{lblError}"></asp:Label>
    </form>
</body>
</html>
