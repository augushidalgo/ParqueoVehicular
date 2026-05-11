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

        public string MostrarMarca()
        {
            return Marca;
        }
        public override double DescuentoRegular()
        {
            double costo = Horas * 5;
            double descuento = costo * 0.05;
            return costo - descuento;
        }
        public override double DescuentoPersonalizado(double descuento)
        {
            double costo = Horas * 5;
            double descuentoCalculado = costo * descuento;
            return costo - descuentoCalculado;
        }
    }
}
