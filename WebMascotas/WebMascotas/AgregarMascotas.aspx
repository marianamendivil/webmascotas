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
            <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
            <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
            <div>
            <asp:GridView ID="gvMascotas" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id Mascota" />
                    <asp:BoundField DataField="NombreMascota" HeaderText="Nombre Mascota" />
                    <asp:BoundField DataField="Cliente.NombreCliente" HeaderText="Cliente" />
                    <asp:BoundField DataField="Raza.NombreRaza" HeaderText="Raza" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
        </div>
               
        </div>             
    </form>
</body>
</html>
