<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Example6.aspx.vb" Inherits="DevTest.Example6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-4">
        <h2>Exercise 6</h2>
        <p>
Please implement a function that checks whether a positive number is a palindrome or not. For example, 121 is a palindrome, but 123 is not.
        </p>
        <p>
            <label>Positive Number:</label>&nbsp;<asp:TextBox ID="txtValue" runat="server"></asp:TextBox>&nbsp;<asp:Button ID="btnSubmit" runat="server" Text="Submit" /><br />
            <br />
            <br />
            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </p>
    </div>
</asp:Content>
