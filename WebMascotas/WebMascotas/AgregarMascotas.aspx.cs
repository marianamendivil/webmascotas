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
    public partial class AgregarMascotas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtId.Text.Length != 0)
            {
                if (txtNombre.Text.Length != 0)
                {
                    if (txtIdCliente.Text.Length != 0)
                    {
                        if (txtIdRaza.Text.Length != 0)
                        {
                            AgregarMascota();
                        }
                    }
                }
            }    
        }

        private void AgregarMascota()
        {
            int id = int.Parse(txtId.Text);
            string nombre = txtNombre.Text;
            double identificacion = Double.Parse(txtIdCliente.Text);            
            int idRaza = int.Parse(txtIdRaza.Text);

            EN.Mascota mascota = new EN.Mascota();
            mascota.Id = id;
            mascota.Nombre = nombre;
            mascota.IdentCliente = identificacion;
            mascota.IdRaza = idRaza;

            CT.Mascota ctMascota = new CT.Mascota();
            ctMascota.AgregarMascota(mascota);

            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtIdCliente.Text = string.Empty;
            txtIdRaza.Text = string.Empty;
        }
    }
}