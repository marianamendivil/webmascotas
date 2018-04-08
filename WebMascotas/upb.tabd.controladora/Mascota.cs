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
 
        public List<EN.Mascota> ConsultarMascotas(string nombreMascota)
        {
            List<EN.Mascota> listado = new List<EN.Mascota>();

            var resultado = from m in db.Mascotas
                       join c in db.Clientes on m.IdentCliente equals c.IdentCliente
                       join r in db.Razas on m.IdRaza equals r.IdRaza
                       join e in db.Especies on r.IdEspecie equals e.IdEspecie
                       where (m.Nombre == nombreMascota || nombreMascota == "") // si hay dos o mas mascotas con el mimso nombre, las trae todas en un listado
                       select new { m.Id, m.Nombre, c.IdentCliente, c.NombreCliente, r.IdRaza, r.Raza1, e.IdEspecie, e.Especie1 };

            foreach (var item in resultado)
            {
                EN.Mascota objMascota = new EN.Mascota();

                objMascota.Cliente = new EN.Cliente();
                objMascota.Raza = new EN.Raza();
                objMascota.Raza.Especie = new EN.Especie();

                objMascota.Id = int.Parse(item.Id.ToString());
                objMascota.NombreMascota = item.Nombre;
                objMascota.Cliente.IdentCliente = item.IdentCliente;
                objMascota.Cliente.NombreCliente = item.NombreCliente;
                objMascota.Raza.Especie.IdEspecie = item.IdEspecie;
                objMascota.Raza.Especie.NombreEspecie = item.Especie1;
                objMascota.Raza.IdRaza = int.Parse(item.IdRaza.ToString());
                objMascota.Raza.NombreRaza = item.Raza1;

                listado.Add(objMascota);

            }

            return listado;
        }

        /*
        public List<EN.Mascota> ConsultarMascotaId(int id, string nombre)
        {
            List<EN.Mascota> resultado = new List<EN.Mascota>();

            List<BR.Mascota> item = db.Mascotas.Where((x => x.Id == id || id == -1) && (x.Nombre == nombre || nombre = "")).ToList();

            foreach (var registro in item)
            {
                EN.Mascota objMascota = new EN.Mascota();
                objMascota.Cliente = new EN.Cliente();
                objMascota.Raza = new EN.Raza(); //int.Parse(registro.IdRaza.ToString());
                objMascota.NombreMascota = registro.Nombre;

                resultado.Add(objMascota);

            }

            return resultado;

        }*/

        public bool ActualizarMascota(EN.Mascota objMascota)
        {
            bool resultado = false;
            try
            {
                BR.Mascota brMascota = db.Mascotas.Where(x => x.Id == objMascota.Id).FirstOrDefault();
                brMascota.Nombre = objMascota.NombreMascota;
                brMascota.IdentCliente = objMascota.Cliente.IdentCliente;
                brMascota.IdRaza = objMascota.Raza.IdRaza;
                db.SaveChanges();

                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resultado;
        }
        
        
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

        /// <summary>
        /// Método para la eliminación de mascotas
        /// </summary>
        /// <param name="objMascota"></param>Objeto mascota a eliminar
        /// <returns>Verdadero si se eliminó correctamente ó falso en caso contrario.</returns>

        public bool EliminarMascota(EN.Mascota objMascota)
        {
            bool resultado = false;
            try
            {
                BR.Mascota brMascota = db.Mascotas.Where(x => x.Id == objMascota.Id).FirstOrDefault(); 
                db.Mascotas.Remove(brMascota);
                db.SaveChanges();

                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resultado;
        }
    }
}