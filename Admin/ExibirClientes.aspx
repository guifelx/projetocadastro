<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ExibirClientes.aspx.cs" Inherits="Projeto3.Admin.ExibirClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="margin-top-60">
        <asp:Button ID="Novo" OnClick="Novo_Click" runat="server" Text="Novo" />

        <asp:Button ID="Fechar" OnClick="Fechar_Click" CssClass="botao-delete" runat="server" Text="Fechar" />

        <hr />
        <div>
            <asp:GridView Width="100%" ID="GridViewClientes" AutoGenerateSelectButton="true" CellPadding="8" BorderColor="Gray" OnSelectedIndexChanged="GridViewClientes_SelectedIndexChanged" runat="server">
            </asp:GridView>
        </div>
    </div>
</asp:Content>
