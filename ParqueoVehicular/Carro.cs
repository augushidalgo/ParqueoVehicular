using System;
using System.Collections.Generic;
using System.Text;

namespace ParqueoVehicular
{
    public class Carro: Vehiculo
    {
        public override double CalcularCosto()
        {
            return Horas * 20;
        }

        public override string MostrarTipo()
        {
            return "Carro";
        }
    }
}
