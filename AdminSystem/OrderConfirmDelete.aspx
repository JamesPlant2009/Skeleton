<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 623px">
    <form id="form1" runat="server">
        <div style="height: 495px">
        	<asp:Label ID="lblDeleteConform" runat="server" style="z-index: 1; left: 50px; top: 45px; position: absolute" Text="Are you sure you want to delete?"></asp:Label>
			<asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 58px; top: 104px; position: absolute" Text="Yes" />
			<asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 139px; top: 102px; position: absolute" Text="No" />
        </div>
    </form>
</body>
</html>
