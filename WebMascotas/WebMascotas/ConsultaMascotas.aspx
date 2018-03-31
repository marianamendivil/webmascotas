<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaMascotas.aspx.cs" Inherits="WebMascotas.ConsultaMascotas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblIdRaza" runat="server" Text="Ingrese la raza a consultar"></asp:Label>
            <asp:TextBox ID="txtIdRaza" runat="server"></asp:TextBox>
            <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
        </div>
        <br /> <!--Salto de línea -->
        <div>
            <asp:GridView ID="gvRazas" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <Columns>
                    <asp:BoundField DataField="IdRaza" HeaderText="Id Raza" />
                    <asp:BoundField DataField="NombreRaza" HeaderText="Nombre Raza" />
                    <asp:BoundField DataField="Especie.NombreEspecie" HeaderText="Especie" />
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
    </form>
</body>
</html>
