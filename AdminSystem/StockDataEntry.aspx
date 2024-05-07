<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="ChkStock">
    <form id="form1" runat="server">
        <div>
        </div>
        
            <asp:Label ID="lblStockId" runat="server" style="z-index: 1; left: 27px; top: 58px; position: absolute" Text="Stock ID"></asp:Label>
        
        
            <asp:Label ID="lblSupplierID" runat="server" style="z-index: 1; left: 16px; top: 98px; position: absolute" Text="Supplier ID"></asp:Label>
        
        
            <asp:TextBox ID="txtSupplierID" runat="server" style="z-index: 1; left: 134px; top: 98px; position: absolute"></asp:TextBox>
        
       
            <asp:Label ID="lblProductID" runat="server" style="z-index: 1; left: 20px; top: 131px; position: absolute" Text="Product ID"></asp:Label>
        
        <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 22px; top: 163px; position: absolute" Text="Order ID"></asp:Label>
        <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 24px; top: 200px; position: absolute" Text="Staff ID"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtProductID" runat="server" style="z-index: 1; left: 132px; top: 133px; position: absolute"></asp:TextBox>
        
       
            </p>
        <p>
            <asp:TextBox ID="txtStockID" runat="server" Style="z-index: 1; left: 133px; top: 59px; position: absolute" OnTextChanged="txtStockID_TextChanged"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 134px; top: 164px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 133px; top: 202px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLastOrder" runat="server" style="z-index: 1; left: 134px; top: 245px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblLastOrder" runat="server" style="z-index: 1; left: 9px; top: 243px; position: absolute" Text="Last Order Date"></asp:Label>
        <asp:Label ID="lblInStock" runat="server" style="z-index: 1; left: 22px; top: 281px; position: absolute" Text="In Stock?"></asp:Label>
        <p>
            <asp:CheckBox ID="ChkStock" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" style="z-index: 1; left: 167px; top: 282px; position: absolute" Text="Yes" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 24px; top: 329px; position: absolute; height: 26px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 132px; top: 374px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 199px; top: 374px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
