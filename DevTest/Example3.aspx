<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Example3.aspx.vb" Inherits="DevTest.Example3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-4">
        <h2>Exercise 3</h2>
        <p>
            Write some code that accepts an integer and prints the integers from 0 to that input integer in a spiral format.<br />
            For example, if I supplied 24 the output would be:<br />
            20 21 22 23 24<br />
            19 6 7 8 9<br />
            18 5 0 1 10<br />
            17 4 3 2 11<br />
            16 15 14 13 12
        </p>
        <p>
            <label>Integer Value:</label>&nbsp;<asp:TextBox ID="txtValue" runat="server"></asp:TextBox>&nbsp;<asp:Button ID="btnSubmit" runat="server" Text="Submit" /><br />
            <label>Clockwise:</label>&nbsp;<asp:CheckBox ID="cbClockwise" runat="server" AutoPostBack="True" />
            <br />
            <br />
            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </p>
    </div>
</asp:Content>
