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
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 31px; top: 214px; position: absolute" Text="UserName:"></asp:Label>
        </p>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 31px; top: 277px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtBoxUserName" runat="server" style="z-index: 1; left: 132px; top: 216px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtBoxPassword" runat="server" style="z-index: 1; left: 131px; top: 277px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 71px; top: 353px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 198px; top: 353px; position: absolute" Text="Cancel" />
        <p>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 49px; top: 141px; position: absolute; height: 95px; width: 337px" Text="Stock Login Page"></asp:Label>
        </p>
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 350px; top: 254px; position: absolute; height: 17px;" Text="{lblError}"></asp:Label>
    </form>
</body>
</html>
