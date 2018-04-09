<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarMascotas.aspx.cs" Inherits="WebMascotas.AgregarMascotas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class ="container">
        <div>
            <h1> Maestro Mascotas</h1>    
        </div>
        <div class ="formgroup">
            <asp:Label ID="lblId" runat="server" Text="Id"></asp:Label>
            <asp:TextBox ID="txtId" runat="server" CssClass ="form-control"></asp:TextBox>
             <asp:RequiredFieldValidator ID="idmascota" runat="server" ErrorMessage="Campo Requerido" ControlToValidate ="txtId" ForeColor =" Red" ValidationGroup ="AdminMascotas"></asp:RequiredFieldValidator>
        </div>
        <div class ="formgroup">
            <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"  CssClass ="form-control"></asp:TextBox>
             <asp:RequiredFieldValidator ID="nombre" runat="server" ErrorMessage="Campo Requerido" ControlToValidate ="txtNombre" ForeColor =" Red" ValidationGroup ="AdminMascotas"></asp:RequiredFieldValidator>
        </div>
        <div class ="formgroup">
            <asp:Label ID="lblIdCliente" runat="server" Text="IdCliente"></asp:Label>
            <asp:TextBox ID="txtIdCliente" runat="server"  CssClass ="form-control"></asp:TextBox>
             <asp:RequiredFieldValidator ID="cliente" runat="server" ErrorMessage="Campo Requerido" ControlToValidate ="txtIdCliente" ForeColor =" Red" ValidationGroup ="AdminMascotas"></asp:RequiredFieldValidator>

        </div>
        <div class="formgroup">
            <asp:Label ID="lblIdRaza" runat="server" Text="IdRaza"></asp:Label>
            <asp:TextBox ID="txtIdRaza" runat="server"  CssClass ="form-control"></asp:TextBox>
             <asp:RequiredFieldValidator ID="raza" runat="server" ErrorMessage="Campo Requerido" ControlToValidate ="txtIdRaza" ForeColor =" Red" ValidationGroup ="AdminMascotas"></asp:RequiredFieldValidator>

        </div>
        <div>
          
            <asp:Button ID="btnConsultar" runat="server" Text="Consultar"  OnClick="btnConsultar_Click" CssClass="btn btn-primary" />
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar"  OnClick="btnAgregar_Click" CssClass="btn btn-success" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" CssClass="btn btn-danger"/>
            <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" CssClass="btn btn-info"/>
            
            <div>
            <br/>
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
    </div>            
    </form>
</body>
</html>
