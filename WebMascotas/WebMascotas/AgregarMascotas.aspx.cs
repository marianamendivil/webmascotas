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

        private void AgregarMascota()
        {
            string nombre = txtNombre.Text;
            double identificacion = Double.Parse(txtIdCliente.Text);            
            int idRaza = int.Parse(txtIdRaza.Text);

            EN.Cliente client = new EN.Cliente();
            client.IdentCliente = identificacion;

            EN.Raza raza = new EN.Raza();
            raza.IdRaza = idRaza;

            EN.Mascota mascota = new EN.Mascota();
            //mascota.Id = id;
            mascota.NombreMascota = nombre;
            mascota.Cliente = client;
            mascota.Raza = raza;

            CT.Mascota ctMascota = new CT.Mascota();
            ctMascota.AgregarMascota(mascota);

            txtNombre.Text = string.Empty;
            txtIdCliente.Text = string.Empty;
            txtIdRaza.Text = string.Empty;
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            
                ActualizarMascota();
            
                
        }

        private void ActualizarMascota()
        {
            int id = int.Parse(txtId.Text);
            string nombre = txtNombre.Text; //validar que tenga dato
            double identificacion = Double.Parse(txtIdCliente.Text); 
            //int idRaza = int.Parse(txtIdRaza.Text);

            EN.Cliente client = new EN.Cliente();
            client.IdentCliente = identificacion;

            //EN.Raza raza = new EN.Raza();
            //Raza.IdRaza = idRaza;

            EN.Mascota mascota = new EN.Mascota();
            mascota.Id = id;
            //if (txtNombre.Text.Length != 0)
           // {
                mascota.NombreMascota = nombre;
           // }
            if (txtIdCliente.Text.Length != 0)
            {
                mascota.Cliente = client;
            }
            //mascota.Raza = raza;

            CT.Mascota ctMascota = new CT.Mascota();
            ctMascota.ActualizarMascota(mascota);

            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtIdCliente.Text = string.Empty;
            txtIdRaza.Text = string.Empty;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text.Length != 0)
            {
                if (txtIdCliente.Text.Length != 0)
                {
                    if (txtIdRaza.Text.Length != 0)
                    {
                        EliminarMascota();
                    }
                }
            }
        }

        private void EliminarMascota()
        {
            int id = int.Parse(txtId.Text);
            string nombre = txtNombre.Text;
            double identificacion = Double.Parse(txtIdCliente.Text);
            int idRaza = int.Parse(txtIdRaza.Text);

            EN.Cliente client = new EN.Cliente();
            client.IdentCliente = identificacion;

            EN.Raza raza = new EN.Raza();
            raza.IdRaza = idRaza;

            EN.Mascota mascota = new EN.Mascota();
            mascota.Id = id;
            mascota.NombreMascota = nombre;
            mascota.Cliente = client;
            mascota.Raza = raza;

            CT.Mascota ctMascota = new CT.Mascota();
            ctMascota.EliminarMascota(mascota);

            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtIdCliente.Text = string.Empty;
            txtIdRaza.Text = string.Empty;
        }
        
        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            string nMascota = "";
            if (txtNombre.Text.Length != 0)
            {
                nMascota = txtNombre.Text;
            }

            ConsultarMascota1(nMascota);
        }

        /*
        private void ConsultarMascota(int id)
        {
            CT.Mascota mascota = new CT.Mascota();
            EN.Mascota resultado = mascota.ConsultarMascotaId(id);
            List<EN.Mascota> lstResultado = mascota.ConsultarMascota(id);

            gvMascotas.DataSource = lstResultado;
            gvMascotas.DataBind();
        } */

        private void ConsultarMascota1(string nombreMascota)
        {
            CT.Mascota mascota = new CT.Mascota();
            List<EN.Mascota> listado = mascota.ConsultarMascotas(nombreMascota);

            gvMascotas.DataSource = listado;
            gvMascotas.DataBind();
        }
    }
}