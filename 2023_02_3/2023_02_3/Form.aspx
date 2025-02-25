<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="_2023_02_3.Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox><br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br /><br />
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged1" AutoPostBack="true"></asp:DropDownList><br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
