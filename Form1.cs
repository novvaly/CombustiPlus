namespace CombustiPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // validar con if. Devuelve false si algo está mal
        private bool Validar()
        {
            if (txtPlaca.Text.Trim().Length != 7)
            {
                MessageBox.Show("La placa debe tener 7 caracteres");
                return false;
            }
            if (nudGalones.Value <= 0)
            {
                MessageBox.Show("Los galones deben ser más de 0");
                return false;
            }
            return true;
        }

        // precio por galón con una expresión switch
        private decimal Precio(string combustible)
        {
            return combustible switch
            {
                "Premium" => 290m,
                "Regular" => 272m,
                "Gasoil" => 225m,
                _ => 0m
            };
        }

        //  calcula el total paso a paso (reglas 3, 4 y 5) y lo muestra en lstDetalle
        private decimal Calcular()
        {
            decimal galones = nudGalones.Value;
            decimal precio = Precio(cmbCombustible.Text);
            decimal total = galones * precio;

            lstDetalle.Items.Clear();
            lstDetalle.Items.Add($"{galones:0.0} gal × RD$ {precio:N2} = RD$ {total:N2}");

            if (galones >= 20)                       // regla 3: primero el descuento
            {
                total = total * 0.98m;
                lstDetalle.Items.Add($"Descuento 20+ galones -2 %: RD$ {total:N2}");
            }
            if (cmbPago.Text == "Tarjeta")           // regla 4 y 5: después el recargo
            {
                total = total * 1.03m;
                lstDetalle.Items.Add($"Tarjeta +3 %: RD$ {total:N2}");
            }
            total = Math.Round(total, 2);
            lstDetalle.Items.Add($"TOTAL: RD$ {total:N2}");
            return total;
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;   // Rsi falla, no sigue
            Calcular();
        }
    }
}
