<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Welcome.aspx.cs" Inherits="Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2><asp:Label ID="lblWelcome" runat="server" Text=""></asp:Label></h2><br />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView><br />
    </div>
        <asp:LinkButton ID="lbDonate" runat="server" OnClick="lbDonate_Click">Make a Donation</asp:LinkButton><br /><br />
        <asp:LinkButton ID="lbGrant" runat="server" OnClick="lbGrant_Click">Apply for a Grant</asp:LinkButton>

    </form>
</body>
</html>
