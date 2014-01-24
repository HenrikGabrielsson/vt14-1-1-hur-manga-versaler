<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CountUppercase.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hur många versaler?</title>
</head>
<body>

    <h1>Hur många versaler?</h1>
    <form id="CountUppercaseForm" runat="server">
    <div>
        <asp:TextBox ID="UpperCaseTextBox" runat="server" TextMode="MultiLine"></asp:TextBox>
    
        <asp:Button ID="CapitalCountButton" runat="server" OnClick="CapitalCountButton_Click" Text="Räkna Versaler" />

        <asp:Label ID="Result" runat="server" Text="Antal Versaler: "></asp:Label>
    </div>
    </form>
    

</body>
</html>
