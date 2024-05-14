<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateProduct.aspx.cs" Inherits="WebUI.CreateProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <div class="container">
        <h2>Create Product</h2>
        <hr />
        <form id="form1" runat="server">
            <div class="form-group col-4">
                <asp:Label ID="lblName" runat="server" Text="Name" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group col-4">
                <asp:Label ID="lblPrice" runat="server" Text="Price" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group col-4">
                <asp:Label ID="lblImage" runat="server" Text="Price" CssClass="form-label"></asp:Label>
                <asp:FileUpload ID="imgFile" runat="server" CssClass="form-control" />
            </div>
            <asp:Button ID="btnCreate" runat="server" Text="Create"
                CssClass="btn btn-primary" OnClick="btnCreate_Click" />
            | 
        <asp:Button ID="btnClear" runat="server" Text="Clear"
            CssClass="btn btn-info" OnClick="btnClear_Click" />
            <div class="form-group col-4">
                <asp:Label ID="lblMessage" runat="server" CssClass="form-label text-danger"></asp:Label>
            </div>
        </form>
    </div>
    <script src="Scripts/bootstrap.bundle.min.js"></script>
</body>
</html>
