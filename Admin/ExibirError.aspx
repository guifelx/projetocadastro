<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ExibirError.aspx.cs" Inherits="Projeto3.ExibirError" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div>
    <asp:Label ID="Erros" runat="server" ></asp:Label>
    <br />
    <hr />
    <asp:Button ID="Limpar" OnClick="Limpar_Click" runat="server" Text="Limpar Arquivo" />
  </div>
</asp:Content>
