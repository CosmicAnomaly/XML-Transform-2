<!--

Author: Scott Robinson
December 2016
XML Final Project
    Ideally this would be utilized to house a multitude of leagues from different teams. Different templates could be used depending on the league. 
It would have been nice to dynamically select leagues and have it show this information, but I wasn't able to determine how to accomplish that.
-->

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        <br />
        Premiere League Winners</p><!--Text for a title of sorts since the page will only show the Premiere Leage winners.-->
    <form id="form1" runat="server">
    <div>
    <!--This is an XML transform tool used from the Toolbox, linking the style sheet here auto transforms the designated XML file on page load.-->
        <asp:Xml ID="Xml1" runat="server" DocumentSource="~/App_Data/PremTeams1.xml" TransformSource="~/App_Data/styles.xsl"></asp:Xml>
    
    </div>
        <p>
    <!--This button allows the user to see the raw XML code that is being shown in the table.-->
        <asp:Button ID="btnGo" runat="server" OnClick="btnGo_Click" Text="Show XML Code" />
        </p>
        <p>
    <!--Here is the text box that displays the raw XML code.-->
            <asp:TextBox ID="TextBox1" runat="server" Height="416px" Width="252px"></asp:TextBox>
        </p>
    </form>
</body>
</html>