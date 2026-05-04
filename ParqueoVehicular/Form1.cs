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
            if (cbTipoVehiculo.Text == "Carro")
            {
                Vehiculo carro = new Carro();
                carro.Placa = txtPlaca.Text;
                carro.Horas = int.Parse(txtHorasUso.Text);
                costo = carro.CalcularCosto();
                tipo = carro.MostrarTipo();
            }
            else if (cbTipoVehiculo.Text == "Moto")
            {
                Vehiculo moto = new Moto();
                moto.Placa = txtPlaca.Text;
                moto.Horas = int.Parse(txtHorasUso.Text);
                costo = moto.CalcularCosto();
                tipo = moto.MostrarTipo();
            }
            else
            {
                Vehiculo bici = new Bici();
                bici.Placa = "Sin placa";
                bici.Horas = int.Parse(txtHorasUso.Text);
                costo = bici.CalcularCosto();
                tipo = bici.MostrarTipo();
            }

            lblResultado.Text = $"Tipo {tipo}, C$ {costo}";
        }
    }
}
