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

        public virtual double CalcularCostoDescuento()
        {
            return Horas * 10;
        }
        public virtual double CalcularCostoDescuento(double descuento)
        {
            return (Horas * 10) * descuento;
        }
    }
}
