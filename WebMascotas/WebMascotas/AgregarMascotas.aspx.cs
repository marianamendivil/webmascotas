﻿using System;
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
            ctMascota.AgregarMascota(mascota);

            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtIdCliente.Text = string.Empty;
            txtIdRaza.Text = string.Empty;
        }

        /*
        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            int id = -1;

            if (txtId.Text.Length != 0)
            {
                id = int.Parse(txtId.Text); //suponemos que el id siempre es numerico y parseamos ese campo a entero
            }

            ConsultarMascota(id);
        }

        
        private void ConsultarMascota(int id)
        {
            CT.Mascota mascota = new CT.Mascota();
            List<EN.Mascota> lstResultado = mascota.ConsultarMascota(id);

            gvRazas.DataSource = lstResultado;
            gvRazas.DataBind();
        } */
    }
}