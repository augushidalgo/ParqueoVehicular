using System;
using System.Collections.Generic;
using System.Text;

namespace ParqueoVehicular
{
    public class Carro: Vehiculo
    {
        public Carro(string marca, int horas):base(marca, horas)
        {  
        }
        public override double CalcularCosto()
        {
            return Horas * 20;
        }

        public override string MostrarTipo()
        {
            return "Carro";
        }

        public string MostrarMarca()
        {
            Marca = "Toyota";
            return Marca;
        }
    }
}
