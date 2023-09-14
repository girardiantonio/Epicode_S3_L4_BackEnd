<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Epicode_S3_L4_BackEnd.Default1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="form2" class="d-flex flex-column align-items-center" runat="server">
        <h3 class="mb-3 mt-3">Aggiungi Contatto</h3>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Content/img/rubrica.png" Width="200px" CssClass="mb-3" />
        <div class="w-25">
            <div class="row mb-3 d-flex justify-content-center">
                <asp:TextBox ID="TextNome" runat="server" placeholder="Nome" CssClass="form-control mb-1"></asp:TextBox>
                <asp:TextBox ID="TextCognome" runat="server" placeholder="Cognome" CssClass="form-control mb-1"></asp:TextBox>
                <asp:TextBox ID="TextIndirizzo" runat="server" placeholder="Indirizzo" CssClass="form-control mb-1"></asp:TextBox>
                <asp:TextBox ID="TextTelefono" runat="server" placeholder="Telefono" CssClass="form-control mb-1"></asp:TextBox>
                <asp:TextBox ID="TextEmail" runat="server" placeholder="Email" CssClass="form-control mb-1"></asp:TextBox>
                <asp:FileUpload ID="UpFoto" runat="server" CssClass="form-control mb-1" />
            </div>
            <div class="d-flex justify-content-center">
                <asp:Button ID="Button1" class="btn btn-primary mb-3" runat="server" Text="Registra" OnClick="Button1_Click" />
            </div>
        </div>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
