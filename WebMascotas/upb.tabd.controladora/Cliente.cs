using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EN = upb.tabd.entidades;
using BR = upb.tabd.broker;

namespace upb.tabd.controladora
{
    /// <summary>
    /// Permite Crear un cliente
    /// </summary>
    public class Cliente
    {
        private BR.BDMascotasEntities db = new BR.BDMascotasEntities();
        /// <summary>
        /// Método para la creación de clientes
        /// </summary>
        /// <param name="objCliente"></param>Objeto cliente a insertar
        /// <returns>Verdadero si se creó correctamente ó falso en caso contrario.</returns>
        
        public bool CrearCliente(EN.Cliente objCliente){
            bool resultado = false;
            try
            {
                BR.Cliente brCliente = new BR.Cliente();
                brCliente.IdentCliente = objCliente.IdenCliente;
                brCliente.NombreCliente = objCliente.NombreCliente;
                db.Clientes.Add(brCliente);
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
