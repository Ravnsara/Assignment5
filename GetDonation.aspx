﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GetDonation.aspx.cs" Inherits="GetDonation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Donate Here</h2>
    <p>        
            <asp:Label ID="lblDonate" runat="server" Text="Enter Donation Amount: "></asp:Label>
            <asp:TextBox ID="txtDonation" runat="server"></asp:TextBox>
           
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Must Enter a Donation Amount." ControlToValidate="txtDonation"></asp:RequiredFieldValidator><br />
           
        </p>
        <p>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>        
        </p>       
        <p>
            <a href="Welcome.aspx">Back</a>
        </p>
    </div>
    </form>
</body>
</html>
