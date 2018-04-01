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
        public string Nombre { get; set; }
        public double IdentCliente { get; set; }
        public int IdRaza { get; set; }
    }
}
