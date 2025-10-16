<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Example5.aspx.vb" Inherits="DevTest.Example5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-4">
        <h2>Exercise 5</h2>
        <p>
Write some code that can be used in a templating engine.<br />
            This should take a map of variables ("day" => "Thursday", "name" => "Billy") as well as a string template ("${name} has an appointment on ${day}") and perform substitution as needed.
This needs to be somewhat robust, throwing some kind of error if a template uses a variable that has not been assigned, as well as provide a way to escape the strings ("hello ${${name}}" -> "hello ${Billy}")<br />
            Good Luck!
        </p>
        <p>
            <label>Value:</label>&nbsp;<asp:TextBox ID="txtValue" runat="server"></asp:TextBox>&nbsp;<asp:Button ID="btnSubmit" runat="server" Text="Submit" /><br />
            <br />
            <br />
            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </p>
    </div>
</asp:Content>
