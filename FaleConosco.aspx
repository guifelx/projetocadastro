<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FaleConosco.aspx.cs" Inherits="Projeto3.FaleConosco" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="row min-height-300px margin-top-120 margin-bottom-120">
    <!-- CADASTRO -->
    <div class="col-6">
      <div class="box border margin-right-20">
        <h2>Fale Conosco</h2>
        <br />
        <asp:Label ID="Alerta" ForeColor="red" Font-Size="18px" runat="server"></asp:Label>
        <asp:Panel ID="Formulario" runat="server">
          <br />
          <label>Nome</label>
          <asp:TextBox ID="Nome" MaxLength="50" runat="server"></asp:TextBox>
          <label>Email</label>
          <asp:TextBox ID="Email" TextMode="Email" MaxLength="100" runat="server"></asp:TextBox>
          <label>Telefone</label>
          <asp:TextBox ID="Telefone" MaxLength="30" runat="server"></asp:TextBox>
          <label>Mensagem</label>
          <asp:TextBox ID="Mensagem" TextMode="MultiLine" MaxLength="255" Rows="6" runat="server"></asp:TextBox>
          <br />
          <asp:Button OnClick="Enviar_Click" ID="Enviar" runat="server" Text="Enviar" />
          <br />
        </asp:Panel>
      </div>
    </div>

    <!-- COLUNA 2-->
    <div class="col-6">
      <div class="box border">
        <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d14718.768091200638!2d-47.36861532240954!3d-22.739685740532032!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94c89bea5cdb94f9%3A0xffb368bd91ea12ae!2sFatec%20Americana%20-%20Faculdade%20de%20Tecnologia%20de%20Americana%20Ministro%20Ralph%20Biasi!5e0!3m2!1spt-BR!2sbr!4v1711546611113!5m2!1spt-BR!2sbr" width="100%" height="100%" style="border: 0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
      </div>
    </div>
  </div>

</asp:Content>
