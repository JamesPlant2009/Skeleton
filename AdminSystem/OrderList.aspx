<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 727px">
            <asp:ListBox ID="lstOrderList" runat="server" Height="464px" Width="414px"></asp:ListBox>
        	<asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 23px; top: 499px; position: absolute" Text="Add" />
        </div>
    </form>
</body>
</html>
