<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Example2.aspx.vb" Inherits="DevTest.Example2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-4">
        <h2>Exercise 2</h2>
        <p>
Write some code that will evaluate a poker hand and determine its rank.<br />
            Example:<br />
            Hand: Ah As 10c 7d 6s (Pair of Aces)<br />
            Hand: Kh Kc 3s 3h 2d (2 Pair)<br />
            Hand: Kh Qh 6h 2h 9h (Flush)<br />
        </p>
        <p>
            <label>Hand:</label>&nbsp;<asp:TextBox ID="txtValue" runat="server"></asp:TextBox>&nbsp;<asp:Button ID="btnSubmit" runat="server" Text="Submit" /><br />
            <br />
            <br />
            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </p>
    </div>
</asp:Content>
