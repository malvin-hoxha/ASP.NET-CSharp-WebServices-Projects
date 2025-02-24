<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="_2023_02_2.Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList><br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br />
            <asp:Image ID="Image1" runat="server" Width="50px" />
        </div>
    </form>
</body>
</html>
