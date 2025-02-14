<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_2021_02_ΕΘ.WebForm1" %>

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
             <asp:Button ID="Button1" runat="server" Text="Δύναμη του 3" OnClick="Button1_Click" style="height: 26px"/><br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button2" runat="server" Text="Δύναμη x^y " OnClick="Button2_Click"/><br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
