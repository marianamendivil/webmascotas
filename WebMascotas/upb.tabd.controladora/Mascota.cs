using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EN = upb.tabd.entidades;
using BR = upb.tabd.broker;

namespace upb.tabd.controladora
{
    /// <summary>
    /// Permite agregar una mascota
    /// </summary>
    public class Mascota
    {
        private BR.BDMascotasEntities db = new BR.BDMascotasEntities();
        /// <summary>
        /// Método para la creación de mascotas
        /// </summary>
        /// <param name="objMascota"></param>Objeto mascota a insertar
        /// <returns>Verdadero si se creó correctamente ó falso en caso contrario.</returns>
        
        public bool AgregarMascota(EN.Mascota objMascota){
            bool resultado = false;
            try
            {
                BR.Mascota brMascota = new BR.Mascota();
                brMascota.Id = objMascota.Id;
                brMascota.Nombre = objMascota.Nombre;
                brMascota.IdentCliente = objMascota.IdentCliente;
                brMascota.IdRaza = objMascota.IdRaza;
                db.Mascotas.Add(brMascota);
                db.SaveChanges();

                resultado = true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return resultado;
        }

    }
}