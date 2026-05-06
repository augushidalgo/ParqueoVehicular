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
            if (cbTipoVehiculo.Text == "Carro")
            {
                Carro carro = new Carro("Toyota",int.Parse(txtHorasUso.Text) );
                carro.Placa = txtPlaca.Text;
                // carro.Horas = ;
                marca = carro.MostrarMarca();
                costo = carro.CalcularCosto();
                tipo = carro.MostrarTipo();
            }
            else if (cbTipoVehiculo.Text == "Moto")
            {
                Vehiculo moto = new Moto("Honda",int.Parse(txtHorasUso.Text));
                moto.Placa = txtPlaca.Text;
                // moto.Horas = ;
                costo = moto.CalcularCosto();
                tipo = moto.MostrarTipo();
            }
            else if(cbTipoVehiculo.Text == "Camion")
            {
                Vehiculo camion = new Camion("Mercedes Benz", int.Parse(txtHorasUso.Text));
                camion.Placa = txtPlaca.Text;
                // camion.Horas = ;
                costo = camion.CalcularCosto();
                tipo = camion.MostrarTipo();
            }
            else
            {
                Vehiculo bici = new Bici("Benotto", int.Parse(txtHorasUso.Text));
                bici.Placa = "Sin placa";
                // bici.Horas = ;
                costo = bici.CalcularCosto();
                tipo = bici.MostrarTipo();
            }

            lblResultado.Text = $"Tipo {tipo}, Marca {marca} C$ {costo}";
        }
    }
}
