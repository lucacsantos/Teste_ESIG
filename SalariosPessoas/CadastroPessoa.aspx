<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroPessoa.aspx.cs" Inherits="SalariosPessoas.CadastroPessoa" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastrar Pessoa</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Cadastrar Nova Pessoa</h2>
            <asp:Label ID="lblnome" runat="server" Text="Nome: "/>
            <asp:TextBox ID="txtNome" runat="server"/>
            <br /><br />

            <asp:Label ID="lblCargo" runat="server" Text="Cargo: " />
            <asp:DropDownList ID="dCargos" runat="server"/>
            <br /><br />

              <asp:Label ID="lblCidade" runat="server" Text="Cidade: " />
             <asp:TextBox ID="txtCidade" runat="server" />
            <br /><br />
            
              <asp:Label ID="lblEmail" runat="server" Text="Email: " />
             <asp:TextBox ID="txtEmail" runat="server" />
            <br /><br />
            
              <asp:Label ID="lblCEP" runat="server" Text="CEP: " />
             <asp:TextBox ID="txtCEP" runat="server" />
            <br /><br />
            
              <asp:Label ID="lblEndereco" runat="server" Text="Endereco: " />
             <asp:TextBox ID="txtEndereco" runat="server" />
            <br /><br />
            
              <asp:Label ID="lblPais" runat="server" Text="Pais: " />
             <asp:TextBox ID="txtPais" runat="server" />
            <br /><br />
            
              <asp:Label ID="lblUsuario" runat="server" Text="Usuário: " />
             <asp:TextBox ID="txtUsuario" runat="server" />
            <br /><br />
            
              <asp:Label ID="lblTelefone" runat="server" Text="Telefone: " />
             <asp:TextBox ID="txtTelefone" runat="server" />
            <br /><br />

              <asp:Label ID="lblDataNascimento" runat="server" Text="Data de Nascimento: " />
              <asp:TextBox ID="textDataNascimento" runat="server" />
              <br /><br />

            <asp:Button ID="btnSalvarPessoa" runat="server" Text="Salvar" OnClick="btn_Salvar" />
            <br /><br />
            <asp:Label ID="lblMensagem" runat="server" ForeColor="Green" />
        </div>
    </form>
</body>
</html>
