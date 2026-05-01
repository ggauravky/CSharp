//🧾 1.WebForm1.aspx(Frontend UI)


//<%@ Page Language = "C#" AutoEventWireup="true" CodeFile="WebForm1.aspx.cs" Inherits="WebForm1" %>

//<!DOCTYPE html>
//<html>
//<head runat="server">
//    <title>ASP.NET All-in-One Demo</title>
//</head>
//<body>
//    <form id="form1" runat="server">

//        <h2>ASP.NET Web Form Demo</h2>

//        <!-- NAME INPUT -->
//        <asp:TextBox ID = "txtName" runat="server" Placeholder="Enter your name"></asp:TextBox >

//        < asp:Button ID = "btnGreet" runat="server" Text="Greet" OnClick="btnGreet_Click" />

//        <br /><br />

//        <asp:Label ID = "lblMessage" runat="server"></asp:Label >

//        < hr />

//        < !--CALCULATOR SECTION-- >
//        < asp:TextBox ID = "txtNum1" runat="server" Placeholder="Number 1"></asp:TextBox >
//        < asp:TextBox ID = "txtNum2" runat="server" Placeholder="Number 2"></asp:TextBox >

//        < asp:Button ID = "btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />

//        <br /><br />

//        <asp:Label ID = "lblResult" runat="server"></asp:Label >

//    </ form >
//</ body >
//</ html >




//💻 2.WebForm1.aspx.cs(Backend C# Code)

using System;

// Code-behind class
public partial class WebForm1 : System.Web.UI.Page
{
    // Page Load Event (Page Life Cycle)
    protected void Page_Load(object sender, EventArgs e)
    {
        // Runs every time page loads
        if (!IsPostBack)
        {
            lblMessage.Text = "Page Loaded Successfully!";
        }
    }

    // ============================
    // GREET BUTTON EVENT
    // ============================
    protected void btnGreet_Click(object sender, EventArgs e)
    {
        // Get input from textbox
        string name = txtName.Text;

        // Display greeting
        lblMessage.Text = "Hello, " + name + " 👋";
    }

    // ============================
    // ADD BUTTON EVENT
    // ============================
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            // Convert input to integer
            int num1 = Convert.ToInt32(txtNum1.Text);
            int num2 = Convert.ToInt32(txtNum2.Text);

            int sum = num1 + num2;

            // Display result
            lblResult.Text = "Result = " + sum;
        }
        catch (Exception)
        {
            lblResult.Text = "Enter valid numbers!";
        }
    }
}