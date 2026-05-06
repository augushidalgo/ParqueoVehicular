using System;
using System.Collections.Generic;
using System.Text;

namespace ParqueoVehicular
{
    public class Bici: Vehiculo
    {
        public Bici(string marca, int horas) : base(marca, horas)
        {

        }
        public override double CalcularCosto()
        {
            return Horas * 5;
        }

        
    }
}
