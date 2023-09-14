<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Rubrica.aspx.cs" Inherits="Epicode_S3_L4_BackEnd.Rubrica1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="form2" class="d-flex flex-column align-items-center" runat="server">
        <h3 class="mb-3 mt-3">Rubrica</h3>
        <asp:Button ID="Button1" runat="server" CssClass="btn btn-secondary mb-3" Text="Aggiorna" OnClick="Button1_Click" />
        <div class="container">
            <div class="row">
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <div class="col-md-3">
                            <div class="card mb-4">
                                <asp:Image ID="Image2" runat="server" ImageUrl="~/Content/img/rubrica.png" Width="100px" class="card-img-top" />
                                <div class="card-body">
                                    <h5 class="card-title"><%# Eval("Nome") %> <%# Eval("Cognome") %></h5>
                                    <p class="card-text">
                                        Indirizzo: <%# Eval("Indirizzo") %><br />
                                        Telefono: <%# Eval("Telefono") %><br />
                                        Email: <%# Eval("Email") %>
                                    </p>
                                    <asp:Button ID="Button2" runat="server" Text="Modifica" CssClass="btn btn-warning" OnClick="Button2_Click" />
                                    <asp:Button ID="ButtonElimina" runat="server" Text="Elimina" CssClass="btn btn-danger" CommandName="Delete" CommandArgument='<%# Eval("Id") %>' OnClick="Button3_Click" />
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
