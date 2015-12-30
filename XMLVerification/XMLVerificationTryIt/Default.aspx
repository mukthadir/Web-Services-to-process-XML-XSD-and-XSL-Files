<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="XMLVerificationTryIt._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>Mukthadir H Choudhury &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp Assignment 4 Part 2</h2>
        <p class="lead">Enter the url of XML here: 
            <asp:TextBox ID="TextBox1" runat="server" Height ="35px" Width="600px" Wrap="True" TextMode="MultiLine" style = "LEFT: 500px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox>
        </p>
        <p> Correct XML Url = http://www.public.asu.edu/~mhchoudh/Airlines.xml </p>
        <p> Incorrect XML Url = http://www.public.asu.edu/~mhchoudh/WrongAirlines.xml </p>
        
        <p class="lead">Enter the url of XSD here: 
            <asp:TextBox ID="TextBox2" runat="server" Height ="35px" Width="600px" Wrap="True" TextMode="MultiLine" style = "LEFT: 500px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox>
        </p>
        <p> XSD Url = http://www.public.asu.edu/~mhchoudh/Airlines.xsd </p>
        <p class="lead">Enter the url of XPath here: 
            <asp:TextBox ID="TextBox3" runat="server" Height ="35px" Width="600px" Wrap="True" TextMode="MultiLine" style = "LEFT: 500px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox>
        </p>
        <p> Examples: /Airlines/Airline, /Airlines/Airline/Name, /Airlines/Airline/@InternationalFlight </p>
        <p class="lead">
            &nbsp;
        </p>
        <p class="lead">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Validate XML" style = "LEFT: 300px; POSITION: absolute;" />
            <asp:Button ID="Button2" runat="server" Text="Search" OnClick="Button2_Click" style = "LEFT: 850px; POSITION: absolute;"/>
        </p>
        <p class="lead">
            &nbsp;
        </p>
        <p class="lead">
            <asp:TextBox ID="TextBox4" runat="server" Height ="150px" Width="400px" Wrap="True" TextMode="MultiLine" style = "LEFT: 200px; POSITION: absolute; Z-INDEX: 101" Rows ="2"></asp:TextBox>
            <asp:TextBox ID="TextBox5" runat="server" Height ="500px" Width="500px" Wrap="True" TextMode="MultiLine" style="LEFT: 650px; POSITION: absolute; Z-INDEX: 101" Rows ="1"></asp:TextBox>
        </p>
        <p class="lead">
            &nbsp;</p>
        <p class="lead">
            &nbsp;</p>
        <p class="lead">
            &nbsp;</p>
        <p class="lead">
            &nbsp;</p>
        <p class="lead">
            &nbsp;</p>
        <p class="lead">
            &nbsp;</p>
        <p class="lead">
            &nbsp;</p>
        <p class="lead">
            &nbsp;</p>
        <p class="lead">
            &nbsp;</p>
        <p class="lead">
            &nbsp;</p>
    </div>
</asp:Content>
