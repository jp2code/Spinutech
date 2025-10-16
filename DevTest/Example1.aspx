<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Example1.aspx.vb" Inherits="DevTest.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-4">
        <h2>Exercise 1</h2>
        <p>
            Write some code that will accept an amount and convert it to the appropriate string representation.<br />
            Example:<br />
            Convert 2523.04 to "Two thousand five hundred twenty-three and 04/100 dollars"
        </p>
        <p>
            <label>Value:</label>&nbsp;<asp:TextBox ID="txtValue" runat="server"></asp:TextBox>&nbsp;<asp:Button ID="btnSubmit" runat="server" Text="Submit" /><br />
            <br />
            <br />
            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </p>
    </div>
</asp:Content>
