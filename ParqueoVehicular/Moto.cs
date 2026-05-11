using System;
using System.Collections.Generic;
using System.Text;

namespace ParqueoVehicular
{
    public class Moto: Vehiculo
    {
        public Moto(string marca, int horas) : base(marca, horas)
        {

        }
        public override double CalcularCosto()
        {
            return Horas * 10;
        }

        public override string MostrarTipo()
        {
            return "Moto";
        }
        public string MostrarMarca()
        {
            return Marca;
        }
    }
}
