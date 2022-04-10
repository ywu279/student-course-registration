<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterCourse.aspx.cs" Inherits="lab8.RegisterCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register Course</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Registrations</h1>
            <hr />
            <div class="row form-group">
                <label for="drpStudent" class="col-md-2 col-form-label">Student: </label>
                <div class="col-md-6">
                    <asp:DropDownList ID="drpStudent" runat="server" AutoPostBack="true" OnSelectedIndexChanged="drpStudent_SelectedIndexChanged" CssClass="form-control">
                        <asp:ListItem Value="-1" Text="Select ..."></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <asp:RequiredFieldValidator ID="rfvDrpStudent" runat="server" ControlToValidate="drpStudent" Display="Dynamic" EnableClientScript="true" InitialValue="-1" ErrorMessage="Must select one!" CssClass="col-md-2 invalid-feedback"></asp:RequiredFieldValidator>
            </div>

            <asp:Label ID="lblSummary" runat="server" Visible="false" Font-Bold="true" ForeColor="#007bff"></asp:Label><br />

            <p>Following courses are currently available for registration</p>
            <asp:label ID="lblCheckListError" runat="server" Text="You need to select at least one course" Visible="false" CssClass="alert-danger"></asp:label>
            <asp:CheckBoxList ID="checkList" runat="server" CssClass="form-checked"></asp:CheckBoxList>

            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" CssClass="col-md-2 mb-3 btn btn-primary"/>
            <br />
            <u><a href="AddStudent.aspx">Add Students</a></u>

        </div>
    </form>
</body>
</html>
