using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_1_6.Entidades
{
    internal class Camion
    {
        public string Patente { get; set; }
        public int PesoMax { get; set; }

        public bool Listo { get; set; }

        public List<Cargas> CargasCamion { get; set; }

        public Camion()
        {
            CargasCamion = new List<Cargas>();
        }
        public bool AddCargas(Cargas carga)
        {

            double pesoActual = this.CargaActual();
            if(pesoActual + carga.Peso > this.PesoMax)
            {
                MessageBox.Show("No se puede ingresar la carga, el Camion supera el limite de peso", "Limite Exedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            CargasCamion.Add(carga);
            return true;
        }

        public void RemoveCargas(int item)
        {

            CargasCamion.RemoveAt(item);

        }

        public double CargaActual()
        {
            double peso = 0;
            foreach (Cargas item in CargasCamion)
            {
                peso += Convert.ToInt32(item.Peso);
            }

            return peso;
        }
        
    }
}
