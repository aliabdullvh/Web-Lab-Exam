<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddFeedback.aspx.cs" Inherits="Web_Lab_Exam.AddFeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            Student Name: 
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <br />
        <div>
            Course Name: 
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </div>
        <br />
        <div>
            Comments: 
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            
        </div>
        <br />
        Phone: <asp:TextBox ID="TextBox4" runat="server" TextMode="Phone"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click"/>
        <asp:Label ID="lblMessage" runat="server" ForeColor="Green" />

    </form>
</body>
</html>
