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
    public partial class ConsultaMascotas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            int idRaza = -1;

            if(txtIdRaza.Text.Length != 0)
            {
                idRaza = int.Parse(txtIdRaza.Text); //suponemos que el idRaza siempre es numerico y parseamos ese campo a entero
            }

            ConsultarRazas(idRaza);
        }

        private void ConsultarRazas(int idRaza)
        {
            CT.Raza raza = new CT.Raza();
            List<EN.Raza> lstResultado = raza.ConsultarRaza(idRaza);

            gvRazas.DataSource = lstResultado;
            gvRazas.DataBind();

        }
    }
}