using System;
using System.Collections.Generic;
using System.Text;

namespace ParqueoVehicular
{
    public class Moto: Vehiculo
    {
        public override double CalcularCosto()
        {
            return Horas * 10;
        }

        public override string MostrarTipo()
        {
            return "Moto";
        }
    }
}
