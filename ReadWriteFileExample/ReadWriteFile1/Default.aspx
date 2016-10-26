<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ReadWriteFile1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2>Làm việc với File</h2><br />
        <hr />
    
        <br />
        Chọn file:
        <asp:FileUpload ID="fupFile" runat="server" Width="358px" />
        <br />
        <br />
        <asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_Click" Text="Upload" />
        <br />
        <hr />
        <br />
        <asp:Label ID="lblResult" runat="server" ForeColor="Red" Text="Result"></asp:Label>
    
    </div>
    </form>
</body>
</html>
