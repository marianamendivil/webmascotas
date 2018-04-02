using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EN = upb.tabd.entidades;
using BR = upb.tabd.broker;

namespace upb.tabd.controladora
{
    /// <summary>
    /// Permite CRUD de mascotas
    /// </summary>
    public class Mascota
    {
        private BR.BDMascotasEntities db = new BR.BDMascotasEntities();

        /// <summary>
        /// Método para la consulta de mascotas
        /// </summary>
        /// <param name="objMascota"></param>Objeto mascota a consultar
        /// <returns>Lista de las mascotas</returns>
        /*
        public List<EN.Mascota> ConsultarMascota1(int id)
        {
            List<EN.Mascota> resultado = new List<EN.Mascota>();

            var item = from m in db.Mascotas
                       join c in db.Clientes on m.IdentCliente equals c.IdentCliente
                       join r in db.Razas on m.IdRaza equals r.IdRaza
                       where (m.Id == id || id == -1) // si encuentra el id particular, lo trae, si no se usa '-1 ' para traer todos los valores
                       select new { m.Id, m.Mascota1, c.IdentCliente, c.Cliente1, r.IdRaza, r.Raza1 };

            foreach (var registro in item)
            {
                EN.Mascota objMascota = new EN.Mascota();
                objMascota.Cliente.IdentCliente = new EN.Cliente();
                objMascota.Raza.IdRaza = new EN.Raza();
                objMascota.NombreMascota = registro.Mascota1;
                objMascota.Raza = int.Parse(registro.IdRaza.ToString());

                resultado.Add(objMascota);

            }

            return resultado;
        }

        public List<EN.Mascota> ConsultarMascota(int id)
        {
            List<EN.Mascota> resultado = new List<EN.Mascota>();

            List<BR.Mascota> item = db.Mascotas.Where(x => x.Id == id || id == -1).ToList();

            foreach (var registro in item)
            {
                EN.Mascota objMascota = new EN.Mascota();
                objMascota.Cliente = new EN.Cliente();
                objMascota.Raza = new EN.Raza(); //int.Parse(registro.IdRaza.ToString());
                objMascota.NombreMascota = registro.Mascota1;
                objRaza.Especie.IdEspecie = registro.Especie.IdEspecie;
                objRaza.Especie.NombreEspecie = registro.Especie.Especie1;

                resultado.Add(objRaza);

            }

            return resultado;

        }


    */





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
                brMascota.Nombre = objMascota.NombreMascota;
                brMascota.IdentCliente = objMascota.Cliente.IdentCliente;
                brMascota.IdRaza = objMascota.Raza.IdRaza;
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