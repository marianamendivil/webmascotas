﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminClientes.aspx.cs" Inherits="WebMascotas.AdminClientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1> Registro Clientes</h1>    
        </div>
        <div>
            <asp:Label ID="lblIdentificacion" runat="server" Text="Identificación"></asp:Label>
            <asp:TextBox ID="txtIdentificacion" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblNombreCliente" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        </div><br />
        <div>
            <asp:Button ID="btnCrear" runat="server" Text="Crear Cliente" OnClick="btnCrear_Click" />
        </div>
    </form>
</body>
</html>