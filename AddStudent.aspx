<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="lab8.AddStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Student</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Students</h1>
            <hr />
            <div class="row form-group">
                <label for="txtStudentName" class="col-md-2 col-form-label">Student Name: </label>
                <div class="col-md-6">
                    <asp:TextBox ID="txtStudentName" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <asp:RequiredFieldValidator ID="rfvStudentName" runat="server" ControlToValidate="txtStudentName" Display="Dynamic" EnableClientScript="true" ErrorMessage="Required!" CssClass="col-md-2 invalid-feedback"></asp:RequiredFieldValidator>
            </div>

            <div class="row form-group">
                <label for="drpStudentType" class="col-md-2 col-form-label">Student Type: </label>
                <div class="col-md-6">
                    <asp:DropDownList ID="drpStudentType" runat="server" CssClass="form-control">
                        <asp:ListItem Value="-1" Text="Select ..."></asp:ListItem>
                        <asp:ListItem Value="fulltime" Text="Full Time"></asp:ListItem>
                        <asp:ListItem Value="partime" Text="Part Time"></asp:ListItem>
                        <asp:ListItem Value="coop" Text="Coop"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <asp:RequiredFieldValidator ID="rfvStudentType" runat="server" ControlToValidate="drpStudentType" Display="Dynamic" EnableClientScript="true" InitialValue="-1" ErrorMessage="Must select one!" CssClass="col-md-2 invalid-feedback"></asp:RequiredFieldValidator>
            </div>

            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" CssClass="col-md-2 mb-3 btn btn-primary "/>
            
            <asp:Table ID="tblStudent" runat="server" CssClass="table table-hover">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell>ID</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Name</asp:TableHeaderCell>
                </asp:TableHeaderRow>
                <asp:TableRow ID="noStudentError" CssClass="alert-danger">
                    <asp:TableCell></asp:TableCell>
                    <asp:TableCell>No Student Yet!</asp:TableCell>
                </asp:TableRow>
            </asp:Table>

            <u><a href="RegisterCourse.aspx">Register Course</a></u>

        </div>
    </form>
</body>
</html>
