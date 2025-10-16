<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="DevTest._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Dev Interview Programming Test</h1>
        <p class="lead">
            Pick one of the exercises below and build a Visual Studio solution 
using VB.NET, Webforms, and .NET Framework 4.6 or 4.8 with a web front-end to solve it. <br />
The exercises are intended to take about two hours but feel free to put in as much effort
as you feel is appropriate. Upload your solution to GitHub and provide a link when complete.<br />
When we meet to review your solution, please be prepared to do screen share on Zoom and code walkthough.</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Exercise 1</h2>
            <p>
Write some code that will accept an amount and convert it to the appropriate string representation.<br />
Example:<br />
Convert 2523.04 to "Two thousand five hundred twenty-three and 04/100 dollars"
            </p>
            <p>
                <a class="btn" href="Example1.aspx">Exercise 1</a>
            </p>
        </div>
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
                <a class="btn" href="Example2.aspx">Exercise 2</a>
            </p>
        </div>
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
                <a class="btn" href="Example3.aspx">Exercise 3</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Exercise 4</h2>
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
            <p>
                <a class="btn" href="Example4.aspx">Exercise 4</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Exercise 5</h2>
            <p>
Write some code that can be used in a templating engine.<br />
This should take a map of variables ("day" => "Thursday", "name" => "Billy") as well as a string template ("${name} has an appointment on ${Thursday}") and perform substitution as needed.
This needs to be somewhat robust, throwing some kind of error if a template uses a variable that has not been assigned, as well as provide a way to escape the strings ("hello ${${name}}" -> "hello ${Billy}")<br />
Good Luck!
            </p>
            <p>
                <a class="btn" href="Example5.aspx">Exercise 5</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Exercise 6</h2>
            <p>
Please implement a function that checks whether a positive number is a palindrome or not. For example, 121 is a palindrome, but 123 is not.
            </p>
            <p>
                <a class="btn" href="Example6.aspx">Exercise 6</a>
            </p>
        </div>
    </div>

</asp:Content>
