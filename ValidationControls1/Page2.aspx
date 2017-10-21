<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="Cookies.Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    	<asp:Label ID="promptLabel" runat="server" Font-Bold="True"
	               Font-Size="Large" Text="Enter your ID:"></asp:Label>

        <br />
        <input id="id" type="text" runat="server"/><br />
        <asp:Button ID="submitButton" runat="server" Text="Submit" 
            onclick="submitButton_Click" />
    
    </div>
    
	<div>
	    <asp:Label ID="responseLabel" runat="server" Font-Bold="True"
	               Font-Size="Large" Text="Welcome to cookies!" Visible="False">
	    </asp:Label>
	    <br /><br />
	    <asp:Label ID="Label1" runat="server"></asp:Label>
	    <br />
	</div>
    </form>
</body>
</html>
