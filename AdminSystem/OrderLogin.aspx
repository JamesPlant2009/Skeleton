<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLogin.aspx.cs" Inherits="OrderLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 1045px">
    <form id="form1" runat="server">
        <div>
        </div>
    	<asp:Label ID="lblOrderLoginPage" runat="server" style="z-index: 1; left: 26px; top: 44px; position: absolute; height: 19px" Text="Order Login Page"></asp:Label>
		<asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 43px; top: 125px; position: absolute" Text="User Name"></asp:Label>
		<asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 44px; top: 180px; position: absolute" Text="Password"></asp:Label>
		<asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 159px; top: 123px; position: absolute"></asp:TextBox>
		<asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 155px; top: 180px; position: absolute" TextMode="Password"></asp:TextBox>
		<asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 90px; top: 268px; position: absolute" Text="Login" />
		<asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 190px; top: 271px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
		<asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 411px; top: 172px; position: absolute"></asp:Label>
    </form>
</body>
</html>
