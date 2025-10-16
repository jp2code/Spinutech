<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Example4.aspx.vb" Inherits="DevTest.Example4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-4">
        <h2>Exercise 4</h2>
        <p>
            <p>
                Write some code that evolves generations through the "game of life".<br />
                The input will be a game board of cells, either alive (1) or dead (0).<br />
                The code should take this board and create a new board for the next generation based on the following rules:<br />
                1) Any live cell with fewer than two live neighbours dies (underpopulation)<br />
                2) Any live cell with two or three live neighbours lives on to the next generation (survival)<br />
                3) Any live cell with more than three live neighbours dies (overcrowding)<br />
                4) Any dead cell with exactly three live neighbours becomes a live cell (reproduction)<br />
                As an example, this game board as input:<br />
                0 1 0 0 0<br />
                1 0 0 1 1<br />
                1 1 0 0 1<br />
                0 1 0 0 0<br />
                1 0 0 0 1<br />
                Will have a subsequent generation of:<br />
                0 0 0 0 0<br />
                1 0 1 1 1<br />
                1 1 1 1 1<br />
                0 1 0 0 0<br />
                0 0 0 0 0<br />
            </p>
        </p>
        <p>
            <label>Value:</label>&nbsp;<asp:TextBox ID="txtValue" runat="server"></asp:TextBox>&nbsp;<asp:Button ID="btnSubmit" runat="server" Text="Submit" /><br />
            <br />
            <br />
            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </p>
    </div>
</asp:Content>
