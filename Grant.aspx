<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Grant.aspx.cs" Inherits="Grant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>Grant Application</h2>
     <table>
        <tr>
            <td>Select Grant Type</td>
            <td><asp:DropDownList ID="ddlGrantType" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="ServiceName" DataValueField="ServiceKey" ></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CommunityAssistConnectionString %>" SelectCommand="SELECT [ServiceKey], [ServiceName] FROM [CommunityService]">
                    
                </asp:SqlDataSource>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>Enter Requested Amount</td>
            <td><asp:TextBox ID="txtGrantAmount" runat="server"></asp:TextBox></td>
            <td>
            </td>
        </tr>
        <tr>
            <td>Explain your need</td>
            <td><asp:TextBox ID="txtExplanation" runat="server"></asp:TextBox></td>
            <td>
            </td>
        </tr>
        <tr>
            <td><asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /></td>
            <td><asp:Label ID="lblError" runat="server" Text=""></asp:Label></td>
            <td></td>
        </tr>
    </table>
        <a href="Welcome.aspx">Back</a>
    </div>
    </form>
</body>
</html>
