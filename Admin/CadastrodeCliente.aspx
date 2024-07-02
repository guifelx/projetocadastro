<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastrodeCliente.aspx.cs" Inherits="Projeto3.Admin.CadastrodeCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row margin-top-120">
        <div class="col-6">
            <div class="box border margin-right-20">
                <h2>Cadastro de Cliente</h2>
                <br />
                <asp:Label ID="MensagemAlerta" runat="server"></asp:Label>
                <br />
                <asp:Label ID="ClienteId" font-size="20px" runat="server" ></asp:Label>
                <br /> 
              
                <label>Nome</label>
                <asp:TextBox ID="NomeCliente" MaxLength="60" runat="server"></asp:TextBox>

                <label>Pessoa Física ou Jurídica</label>
                <asp:DropDownList ID="FisicaJuridica" runat="server">
                    <asp:ListItem Text="Física" Value="0"></asp:ListItem> 
                    <asp:ListItem Text="Jurídica" Value="1"></asp:ListItem>
                </asp:DropDownList>

                <label>E-mail</label>
                <asp:TextBox ID="Email"  MaxLength="45" runat="server"></asp:TextBox>

                <label>Telefone</label>
                <asp:TextBox ID="Telefone" MaxLength="45" runat="server"></asp:TextBox>

                <label>CPF</label>
                <asp:TextBox ID="CPF" MaxLength="45" runat="server"></asp:TextBox>

                <label>CEP</label>
                <asp:TextBox ID="CEP" MaxLength="45" runat="server"></asp:TextBox>

                <label>Número</label>
                <asp:TextBox ID="Numero" MaxLength="45" runat="server"></asp:TextBox>

                <label>Complemento</label>
                <asp:TextBox ID="Complemento" MaxLength="45" runat="server"></asp:TextBox>

                <asp:Button ID="Salvar" OnClick="Salvar_Click" runat="server" Text="Salvar" />
            </div>
        </div>
    </div>
    

    
    
    
</asp:Content>
