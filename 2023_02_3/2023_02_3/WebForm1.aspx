<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_2023_02_3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <asp:Image ID="Image1" runat="server" Width="100px" />
        </div>
    </form>
</body>
</html>
