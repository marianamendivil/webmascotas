using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace upb.tabd.entidades
{
    [Serializable]
    public class Mascota
    { 
        public int Id { get; set; }
        public string NombreMascota { get; set; }
        public Cliente Cliente { get; set; }
        public Raza Raza { get; set; }
    }                
}
