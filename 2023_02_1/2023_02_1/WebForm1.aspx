<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_2023_02_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label><br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /><br /><br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br /> 
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label><br />
            <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
