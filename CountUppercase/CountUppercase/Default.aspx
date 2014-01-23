﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CountUppercase.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hur många versaler?</title>
</head>
<body>

    <h1>Hur många versaler?</h1>
    <form id="CountUppercaseForm" runat="server">
    <div>
        <asp:TextBox ID="UpperCaseTextBox" runat="server"></asp:TextBox>
    
        <asp:Button ID="CountButton" runat="server" OnClick="CountButton_Click" Text="Räkna Versaler" />

        <asp:Label ID="Result" runat="server"></asp:Label>
    </div>
    </form>
    

</body>
</html>
