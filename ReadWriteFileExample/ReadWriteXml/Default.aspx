<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ReadWriteXml.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Mã
        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
        <br />
        Tên <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        Điện thoại
        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
        <br />
        Điểm<br />
        Môn 1
        <asp:TextBox ID="txtMark1" runat="server"></asp:TextBox>
    
    </div>
        Môn 2
        <asp:TextBox ID="txtMark2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Lưu thông tin" />
        <asp:Button ID="btnReadFromFile" runat="server" OnClick="btnReadFromFile_Click" Text="Đọc từ file" />
        <br />
        <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
