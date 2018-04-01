using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EN = upb.tabd.entidades;
using CT = upb.tabd.controladora;

namespace WebMascotas
{
    public partial class AdminClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            CrearCliente();
        }

        private void CrearCliente()
        {
            double identificacion = Double.Parse(txtIdentificacion.Text);
            string nombre = txtNombre.Text;

            EN.Cliente cliente = new EN.Cliente();
            cliente.IdentCliente = identificacion;
            cliente.NombreCliente = nombre;

            CT.Cliente ctCliente = new CT.Cliente();
            ctCliente.CrearCliente(cliente);

            txtIdentificacion.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }

    }
}