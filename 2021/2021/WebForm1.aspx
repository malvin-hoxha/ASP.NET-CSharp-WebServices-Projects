<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_2021.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br />
            <asp:Button ID="Button1" runat="server" Text="Τετραφωνική Ρίζα" OnClick="Button1_Click" /><asp:Button ID="Button2" runat="server" Text="Στρογγυλοποίηση" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
