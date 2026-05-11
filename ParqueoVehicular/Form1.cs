using System.Threading.Tasks.Dataflow;

namespace ParqueoVehicular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double costo = 0;
            string tipo = string.Empty;
            string marca = string.Empty;
            double descuentoRegular = 0;
            double descuentoEspecial = 0;
            if (cbTipoVehiculo.Text == "Carro")
            {
                Carro carro = new Carro("Toyota",int.Parse(txtHorasUso.Text) );
                carro.Placa = txtPlaca.Text;
                // carro.Horas = ;
                marca = carro.MostrarMarca();
                costo = carro.CalcularCosto();
                tipo = carro.MostrarTipo();
                descuentoRegular = carro.CalcularCostoDescuento();
                descuentoEspecial = carro.CalcularCostoDescuento(0.25);

            }
            else if (cbTipoVehiculo.Text == "Moto")
            {   
                Moto moto = new Moto("Honda",int.Parse(txtHorasUso.Text));
                moto.Placa = txtPlaca.Text;
                // moto.Horas = ;
                marca = moto.MostrarMarca();
                costo = moto.CalcularCosto();
                tipo = moto.MostrarTipo();
            }
            else if(cbTipoVehiculo.Text == "Camion")
            {
                Camion camion = new Camion("Mercedes Benz", int.Parse(txtHorasUso.Text));
                camion.Placa = txtPlaca.Text;
                // camion.Horas = ;
                marca = camion.MostrarMarca();
                costo = camion.CalcularCosto();
                tipo = camion.MostrarTipo();
            }
            else
            {
                Bici bici = new Bici("Benotto", int.Parse(txtHorasUso.Text));
                bici.Placa = "Sin placa";
                // bici.Horas = ;
                marca = bici.MostrarMarca();
                costo = bici.CalcularCosto();
                tipo = bici.MostrarTipo();
            }

            lblResultado.Text = $"Tipo {tipo}, DescuentoRegular {descuentoRegular}, DescuentoEspecial {descuentoEspecial} Marca {marca} C$ {costo}";
        }
    }
}
