<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroUsuarios.aspx.cs" Inherits="Projeto3.Admin.CadastroUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="row margin-top-120">
    <div class="col-6">
      <div class="box border margin-right-20 ">
        <h2>Cadastro Usuário</h2>
        <br />
        <asp:Label ID="Alerta" runat="server"></asp:Label>
        <br />

        <asp:Label ID="UsuarioID" Font-Size="20px" runat="server" ></asp:Label>
        <br />

        <label>Nome</label>
        <asp:TextBox ID="Nome" MaxLength="60" runat="server"></asp:TextBox>

        <label>Email</label>
        <asp:TextBox ID="Email" MaxLength="255" runat="server"></asp:TextBox>

        <label>Nome Acesso</label>
        <asp:TextBox ID="NomeAcesso" MaxLength="45" runat="server"></asp:TextBox>

        <label>Senha</label>
        <asp:TextBox ID="Senha" MaxLength="45" runat="server"></asp:TextBox>

        <label>Situação</label>
        <asp:DropDownList ID="Status" runat="server">
          <asp:ListItem Text="Ativo" Value="1"></asp:ListItem>
          <asp:ListItem Text="Inativo" Value="0"></asp:ListItem>
        </asp:DropDownList>

        <asp:Button ID="Salvar" OnClick="Salvar_Click" runat="server" Text="Salvar" />

      </div>
    </div>
    <div class="col-6"> 
      <div class="box border">
        <h2>Registros de Acessos</h2>
        <br />
        <asp:GridView ID="GridViewAcessos" Width="100%" CellPadding="8" BorderColor="#c0c0c0" runat="server"></asp:GridView>
      </div>
    </div>
  </div>

</asp:Content>
