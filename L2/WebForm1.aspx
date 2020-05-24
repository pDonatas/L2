<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="L2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="css.css" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Ženklo pavadinimas"></asp:Label><br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Dirbam" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Pradiniai duomenys"></asp:Label>
        <br />
        <asp:Label ID="Label7" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label8" runat="server"></asp:Label>
        <asp:Table ID="Table3" runat="server" BorderColor="#FF3399" BorderWidth="5px">
        </asp:Table>
        <asp:Label ID="Label9" runat="server"></asp:Label>
        <asp:Table ID="Table4" runat="server">
        </asp:Table>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Rezultatai"></asp:Label>
        <br />
            <asp:Label ID="Label2" runat="server"></asp:Label><br />
            <asp:Label ID="Label3" runat="server"></asp:Label>
            <asp:Table ID="Table1" runat="server">
            </asp:Table>
        <br />
            <asp:Label ID="Label4" runat="server"></asp:Label>
        <asp:Table ID="Table2" runat="server">
        </asp:Table>
    </form>
</body>
</html>
