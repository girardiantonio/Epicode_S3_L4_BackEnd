<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Epicode_S3_L4_BackEnd.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="d-flex flex-column align-items-center mt-3 mb-3">
            <asp:TextBox ID="TextNome" runat="server" placeholder="Nome"></asp:TextBox>
            <asp:TextBox ID="TextCognome" runat="server" placeholder="Cognome"></asp:TextBox>
            <asp:TextBox ID="TextIndirizzo" runat="server" placeholder="Indirizzo"></asp:TextBox>
            <asp:TextBox ID="TextTelefono" runat="server" placeholder="Telefono"></asp:TextBox>
            <asp:TextBox ID="TextEmail" runat="server" placeholder="Email"></asp:TextBox>
            <asp:FileUpload ID="UpFoto" runat="server" />
            <asp:Button ID="Button1" runat="server" Text="Registra" OnClick="Button1_Click" />

            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
