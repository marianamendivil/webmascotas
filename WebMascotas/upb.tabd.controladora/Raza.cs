using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EN = upb.tabd.entidades;
using BR = upb.tabd.broker;

namespace upb.tabd.controladora
{
    public class Raza
    {
        BR.BDMascotasEntities db = new BR.BDMascotasEntities();

        public List<EN.Raza> ConsultarRaza1(int idRaza)
        {
            List<EN.Raza> resultado = new List<EN.Raza>();

            var item = from r in db.Razas
                       join e in db.Especies on r.IdEspecie equals e.IdEspecie
                       where (r.IdRaza == idRaza || idRaza == -1) // si encuentra el id particular, lo trae, si no se usa '-1 ' para traer todos los valores
                       select new { r.IdRaza, r.Raza1, e.IdEspecie, e.Especie1 };


            foreach (var registro in item)
            {
                EN.Raza objRaza = new EN.Raza();
                objRaza.Especie = new EN.Especie();
                objRaza.IdRaza = int.Parse(registro.IdRaza.ToString());
                objRaza.NombreRaza = registro.Raza1;
                objRaza.Especie.IdEspecie = registro.IdEspecie;
                objRaza.Especie.NombreEspecie = registro.Especie1;

                resultado.Add(objRaza);

            }

            return resultado;
        }

        public List<EN.Raza> ConsultarRaza(int idRaza)
        {
            List<EN.Raza> resultado = new List<EN.Raza>();

            List<BR.Raza> item = db.Razas.Where(x => x.IdRaza == idRaza || idRaza == -1).ToList();

            foreach (var registro in item)
            {
                EN.Raza objRaza = new EN.Raza();
                objRaza.Especie = new EN.Especie();
                objRaza.IdRaza = int.Parse(registro.IdRaza.ToString());
                objRaza.NombreRaza = registro.Raza1;
                objRaza.Especie.IdEspecie = registro.Especie.IdEspecie;
                objRaza.Especie.NombreEspecie = registro.Especie.Especie1;

                resultado.Add(objRaza);

            }

            return resultado;

        }
    }
}
