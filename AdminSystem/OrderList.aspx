<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 727px">
            <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 336px; top: 617px; position: absolute" Text="Return To Main Menu" />
            <asp:ListBox ID="lstOrderList" runat="server" Height="464px" Width="414px"></asp:ListBox>
        	<asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 23px; top: 499px; position: absolute" Text="Add" />
        	<asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 104px; top: 499px; position: absolute" Text="Edit" />
			<asp:Label ID="lblError" runat="server" style="z-index: 1; left: 37px; top: 686px; position: absolute"></asp:Label>
        	<asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 179px; top: 497px; position: absolute" Text="Delete" />
        	<asp:Label ID="lblStockIdSearch" runat="server" style="z-index: 1; left: 26px; top: 564px; position: absolute" Text="Please enter a stock Id"></asp:Label>
			<asp:TextBox ID="txtStockIdSearch" runat="server" style="z-index: 1; left: 196px; top: 563px; position: absolute"></asp:TextBox>
			<asp:Button ID="btnFilter" runat="server" OnClick="btnFilter_Click" style="z-index: 1; left: 67px; top: 618px; position: absolute" Text="Apply Filter" />
			<asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 219px; top: 617px; position: absolute" Text="Clear" />
        </div>
    </form>
</body>
</html>
