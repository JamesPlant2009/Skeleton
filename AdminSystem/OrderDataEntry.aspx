<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    	<asp:Label ID="lblPrice" runat="server" height="19px" style="z-index: 1; left: 19px; top: 114px; position: absolute; width: 88px; bottom: 740px" Text="Price"></asp:Label>
		<asp:Label ID="lblOrderId" runat="server" height="19px" style="z-index: 1; left: 19px; top: 37px; position: absolute; margin-bottom: 1px" Text="Order ID" width="88px"></asp:Label>
		<asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 19px; top: 86px; position: absolute; height: 19px" Text="Customer ID" width="88px"></asp:Label>
		<asp:Label ID="lblStockId" runat="server" height="19px" style="z-index: 1; left: 19px; top: 62px; position: absolute" Text="Stock ID" width="88px"></asp:Label>
		<asp:Label ID="lblOrderDate" runat="server" height="19px" style="z-index: 1; left: 19px; top: 146px; position: absolute" Text="Order date" width="88px"></asp:Label>
		<asp:Label ID="lblOrderShipped" runat="server" style="z-index: 1; left: 19px; top: 177px; position: absolute" Text="Order shipped"></asp:Label>
		<p>
			<asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 161px; top: 32px; position: absolute"></asp:TextBox>
			<asp:TextBox ID="txtStockId" runat="server" style="z-index: 1; left: 161px; top: 61px; position: absolute"></asp:TextBox>
		</p>
		<p>
			<asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 161px; top: 87px; position: absolute; margin-top: 0px"></asp:TextBox>
		</p>
		<asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 161px; top: 114px; position: absolute; margin-top: 0px"></asp:TextBox>
		<asp:TextBox ID="txtOderDate" runat="server" style="z-index: 1; left: 161px; top: 141px; position: absolute"></asp:TextBox>
		<p>
			<asp:CheckBox ID="chkShipped" runat="server" style="z-index: 1; left: 161px; top: 173px; position: absolute" Text="Yes" />
		</p>
		<asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 46px; top: 259px; position: absolute" Text="OK" />
		<asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 130px; top: 258px; position: absolute" Text="Cancel" />
		<asp:Label ID="lblError" runat="server" style="z-index: 1; left: 56px; top: 213px; position: absolute"></asp:Label>
    </form>
</body>
</html>
