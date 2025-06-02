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
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                ControlToValidate="TextBox1" ErrorMessage="Name is required." ForeColor="Red" />
        </div>
        <br />
        <div>
            Course Name: 
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                ControlToValidate="TextBox3" ErrorMessage="Course name is required." ForeColor="Red" />
        </div>
        <br />
        <div>
            Comments: 
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                ControlToValidate="TextBox2" ErrorMessage="Comments are required." ForeColor="Red" />
        </div>
        <br />
        Phone:
        <asp:TextBox ID="TextBox4" runat="server" TextMode="Phone" MaxLength="11"></asp:TextBox>
        <asp:RegularExpressionValidator
            ID="RegexValidatorPhone"
            runat="server"
            ControlToValidate="TextBox4"
            ErrorMessage="Phone number must be exactly 11 digits."
            ValidationExpression="^\d{11}$"
            ForeColor="Red">
        </asp:RegularExpressionValidator>

        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        <asp:Label ID="lblMessage" runat="server" ForeColor="Green" />

    </form>
</body>
</html>
