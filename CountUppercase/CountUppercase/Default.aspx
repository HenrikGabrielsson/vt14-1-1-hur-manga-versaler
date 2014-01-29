<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CountUppercase.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hur många versaler?</title>
    <link rel="stylesheet" href="~/style/style.css" type="text/css" />
</head>
<body>

    <h1>Hur många versaler?</h1>
    <form id="CountUppercaseForm" runat="server">
    <div>

        <%-- input --%>
        <asp:TextBox ID="UpperCaseTextBox" runat="server" TextMode="MultiLine"></asp:TextBox>
        <asp:Button ID="CapitalCountButton" runat="server" OnClick="CapitalCountButton_Click" Text="Räkna Versaler" />


    </div>
    </form>
    <%-- Här läggs output --%>
    <div id="result_div">
        <asp:Label ID="Result" runat="server" Text="Antal Versaler: "></asp:Label>
    </div>

</body>
</html>
