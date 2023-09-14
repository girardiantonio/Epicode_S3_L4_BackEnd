﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Rubrica.aspx.cs" Inherits="Epicode_S3_L4_BackEnd.Rubrica1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="form2" class="d-flex flex-column align-items-center" runat="server">
        <h3 class="mb-3 mt-3">Rubrica</h3>
        <asp:Button ID="Button1" runat="server" Text="Aggiorna" OnClick="Button1_Click" />
        <div class="d-flex container row-cols-3">
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <div class="card">
                        <asp:Image ID="Image2" runat="server" ImageUrl="~/Content/img/rubrica.png" Width="100px" class="card-img-top" />
                        <div class="card-body">
                            <h5 class="card-title"><%# Eval("Nome") %> <%# Eval("Cognome") %></h5>
                            <p class="card-text">
                                Indirizzo: <%# Eval("Indirizzo") %><br />
                                Telefono: <%# Eval("Telefono") %><br />
                                Email: <%# Eval("Email") %>
                            </p>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>