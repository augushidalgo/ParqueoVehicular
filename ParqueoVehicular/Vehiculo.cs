using System;
using System.Collections.Generic;
using System.Text;

namespace ParqueoVehicular
{
    public abstract class Vehiculo
    {
        public string Placa { get; set; }
        private int horas;
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

        public abstract double CalcularCosto();
        public virtual string MostrarTipo()
        {
            return "Vehículo genérico";
        }
    }
}
