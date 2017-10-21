<%@ Page Language="C#" AutoEventWireup="true" Inherits="Page1" Codebehind="Page1.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cookies</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    	<asp:Label ID="promptLabel" runat="server" Font-Bold="True"
	               Font-Size="Large" Text="Enter your details:"></asp:Label>

        <br />
        <input id="id" type="text" runat="server"/>ID<br />
        <input id="firstname" type="text" runat="server"/>First Name<br />
        <input id="lastname" type="text" runat="server"/>Last Name<br />
        <input id="dob" type="text" runat="server"/>Date of birth<br />
        <asp:Button ID="submitButton" runat="server" Text="Submit" 
            onclick="submitButton_Click" />
        <br />
    </div>
    
    </form>
</body>
</html>
