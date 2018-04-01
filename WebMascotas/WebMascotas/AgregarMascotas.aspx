<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarMascotas.aspx.cs" Inherits="WebMascotas.AgregarMascotas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1> Registro Mascotas</h1>    
        </div>
        <div>
            <asp:Label ID="lblId" runat="server" Text="Id"></asp:Label>
            <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblIdCliente" runat="server" Text="IdCliente"></asp:Label>
            <asp:TextBox ID="txtIdCliente" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblIdRaza" runat="server" Text="IdRaza"></asp:Label>
            <asp:TextBox ID="txtIdRaza" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
        </div>
    </form>
</body>
</html>
