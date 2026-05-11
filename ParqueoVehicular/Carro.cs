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
            return Marca;
        }
        public override double DescuentoRegular()
        {
            double costo = Horas * 20;
            double descuento = costo * 0.05;
            return costo - descuento;
        }
        public override double DescuentoPersonalizado(double descuento)
        {
            double costo = Horas * 20;
            double descuentoCalculado = costo * descuento;
            return costo - descuentoCalculado;
        }
    }
}
