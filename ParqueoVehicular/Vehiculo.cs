using System;
using System.Collections.Generic;
using System.Text;

namespace ParqueoVehicular
{
    public abstract class Vehiculo
    {
        protected string Marca { get; set; }
        public string Placa { get; set; }
        protected int horas;
        public int Horas
        {
            get { return horas; }
            set
            {
                if (value > 0)
                {
                    horas = value;
                }
            }
        }

        public Vehiculo(string marca, int horas)
        {
            this.Marca = marca;
            this.Horas = horas;
        }

        public abstract double CalcularCosto();
        public virtual string MostrarTipo()
        {
            return "Vehículo genérico";
        }

        public virtual double DescuentoRegular()
        {
            double costo = Horas * 10;
            double descuento = costo * 0.05;
            return costo - descuento;
        }
        public virtual double DescuentoPersonalizado(double descuento)
        {
            double costo = Horas * 10;
            double descuentoCalculado = costo * descuento;
            return costo - descuentoCalculado;
        }
    }
}
