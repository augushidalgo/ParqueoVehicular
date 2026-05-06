using System;
using System.Collections.Generic;
using System.Text;

namespace ParqueoVehicular
{
    public class Camion: Vehiculo
    {
        public Camion(string marca, int horas):base(marca, horas)
        {

        }
        public override double CalcularCosto()
        {
            return Horas * 40;
        }
        public override string MostrarTipo()
        {
            return "Camión";
        }
    }
}
