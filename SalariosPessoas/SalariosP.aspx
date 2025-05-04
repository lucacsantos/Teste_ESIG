<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SalariosP.aspx.cs" Inherits="SalariosPessoas.SalariosP" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnCalcular" runat="server" Text="Listar todos" OnClick="btn_Calcular" />
            <br />
            <br />
            <asp:GridView ID="salariosGrid" runat="server" AutoGenerateColumns="false">
    <Columns>
        <asp:BoundField DataField="pessoa_id" HeaderText="ID" />
        <asp:BoundField DataField="pessoa_nome" HeaderText="Nome" />
        <asp:BoundField DataField="cargo_nome" HeaderText="Cargo" />
        
         </Columns>
</asp:GridView>

        </div>
    </form>
</body>
</html>
