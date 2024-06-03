<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStockList" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 601px; width: 1462px" OnSelectedIndexChanged="lstStockList_SelectedIndexChanged"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 32px; top: 660px; position: absolute; height: 52px; width: 86px;" Text="Add" />
        <p>
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 142px; top: 659px; position: absolute; height: 54px; width: 88px" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnAdd0" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 32px; top: 660px; position: absolute; height: 52px; width: 86px;" Text="Add" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 442px; top: 729px; position: absolute" Text="[lblError]"></asp:Label>
        <p>
            <asp:Button ID="btnEdit0" runat="server" style="z-index: 1; left: 142px; top: 659px; position: absolute; height: 54px; width: 88px" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Button ID="btnEdit1" runat="server" style="z-index: 1; left: 142px; top: 659px; position: absolute; height: 54px; width: 88px" Text="Edit" OnClick="btnEdit_Click" />
        </p>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 245px; top: 659px; position: absolute; height: 54px; width: 103px" Text="Delete" />
        <asp:Label ID="lblEnter" runat="server" style="z-index: 1; left: 41px; top: 750px; position: absolute" Text="Enter a StockID"></asp:Label>
        <asp:TextBox ID="txtBoxFilter" runat="server" style="z-index: 1; left: 177px; top: 750px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnFilter" runat="server" OnClick="btnFilter_Click" style="z-index: 1; left: 45px; top: 823px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 177px; top: 823px; position: absolute" Text="ClearFilter" />
    </form>
</body>
</html>
