<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ReadWriteFileExample.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Đọc ghi file
        <br />
        <asp:FileUpload ID="fupFile" runat="server" />
        <br />
        <asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_Click" Text="Upload" />
        <br />
        <asp:Label ID="lblResult" runat="server" Text="Result"></asp:Label>
    
    </div>
    </form>
</body>
</html>
