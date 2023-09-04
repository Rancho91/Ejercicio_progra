using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1_6.Entidades
{
    internal class Cargas
    {
        public int id { get; set; }
        public string Descripcion { get; set; }
        public double Peso { get; set; }
        public TiposCargas Tipo { get; set; }
        
        public Cargas() {
            this.id = 0;
        }
    }
}
