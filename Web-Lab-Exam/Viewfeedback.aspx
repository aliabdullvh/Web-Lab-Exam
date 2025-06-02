<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Viewfeedback.aspx.cs" Inherits="Web_Lab_Exam.Viewfeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
    DataKeyNames="FeedbackID" 
    OnRowEditing="GridView1_RowEditing" 
    OnRowUpdating="GridView1_RowUpdating" 
    OnRowCancelingEdit="GridView1_RowCancelingEdit"
    OnRowDeleting="GridView1_RowDeleting">
    <Columns>
        <asp:BoundField DataField="StudentName" HeaderText="Student Name" />
        <asp:BoundField DataField="CourseName" HeaderText="Course Name" />
        <asp:BoundField DataField="Comments" HeaderText="Comments" />
        <asp:BoundField DataField="Phone" HeaderText="Phone" />
        <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
    </Columns>
</asp:GridView>


        </div>
    </form>
</body>
</html>
