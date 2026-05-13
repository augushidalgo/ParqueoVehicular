using System.Threading.Tasks.Dataflow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ParqueoVehicular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            double costo = 0;
            string tipo = string.Empty;
            string marca = string.Empty;
            double descuentoRegular = 0;
            double descuentoEspecial = 0;
            if (cbTipoVehiculo.Text == "Carro")
            {
                Carro carro = new Carro(txtMarca.Text, int.Parse(txtHorasUso.Text));
                Carro carro2 = new Carro(txtMarca.Text, txtPlaca.Text, int.Parse(txtHorasUso.Text));
                carro.Placa = txtPlaca.Text;
                // carro.Horas = ;
                marca = carro.MostrarMarca();
                costo = carro.CalcularCosto();
                tipo = carro.MostrarTipo();
                if(txtDescuento.Text == string.Empty)
                {
                    descuentoRegular = carro.DescuentoRegular();
                }
                else
                {
                    descuentoEspecial = carro.DescuentoPersonalizado(double.Parse(txtDescuento.Text));
                }
            }
            else if (cbTipoVehiculo.Text == "Moto")
            {
                Moto moto = new Moto(txtMarca.Text, int.Parse(txtHorasUso.Text));
                moto.Placa = txtPlaca.Text;
                // moto.Horas = ;
                marca = moto.MostrarMarca();
                costo = moto.CalcularCosto();
                tipo = moto.MostrarTipo();
                if (txtDescuento.Text == string.Empty)
                {
                    descuentoRegular = moto.DescuentoRegular();
                }
                else
                {
                    descuentoEspecial = moto.DescuentoPersonalizado(double.Parse(txtDescuento.Text));
                }
            }
            else if (cbTipoVehiculo.Text == "Camion")
            {
                Camion camion = new Camion(txtMarca.Text, int.Parse(txtHorasUso.Text));
                camion.Placa = txtPlaca.Text;
                // camion.Horas = ;
                marca = camion.MostrarMarca();
                costo = camion.CalcularCosto();
                tipo = camion.MostrarTipo();
                if (txtDescuento.Text == string.Empty)
                {
                    descuentoRegular = camion.DescuentoRegular();
                }
                else
                {
                    descuentoEspecial = camion.DescuentoPersonalizado(double.Parse(txtDescuento.Text));
                }
            }
            else
            {
                Bici bici = new Bici(txtMarca.Text, int.Parse(txtHorasUso.Text));
                bici.Placa = "Sin placa";
                // bici.Horas = ;
                marca = bici.MostrarMarca();
                costo = bici.CalcularCosto();
                tipo = bici.MostrarTipo();
                if (txtDescuento.Text == string.Empty)
                {
                    descuentoRegular = bici.DescuentoRegular();
                }
                else
                {
                    descuentoEspecial = bici.DescuentoPersonalizado(double.Parse(txtDescuento.Text));
                }
            }

            lblResultado.Text = $"Tipo: {tipo}\n Descuento Regular: {descuentoRegular}\n Descuento Especial: {descuentoEspecial}\n Marca: {marca}\n Costo: C$ {costo}";
        }

    }
}
