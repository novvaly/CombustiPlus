namespace CombustiPlus
{
    public partial class Form1 : Form
    {
        // =====================================================
        // R1 · CONSTRUCTOR: se ejecuta al abrir el programa
        // =====================================================
        public Form1()
        {
            InitializeComponent();   // crea los controles del diseño

            // Llenar el combo de combustibles (empieza vacío)
            cmbCombustible.Items.Add("Premium");
            cmbCombustible.Items.Add("Regular");
            cmbCombustible.Items.Add("Gasoil");

            // Llenar el combo de pago (empieza vacío)
            cmbPago.Items.Add("Efectivo");
            cmbPago.Items.Add("Tarjeta");
        }

        // =====================================================
        // R3 · VALIDAR: devuelve true si los datos están bien
        // =====================================================
        private bool Validar()
        {
            // Regla 1: la placa debe tener exactamente 7 caracteres
            if (txtPlaca.Text.Trim().Length != 7)
            {
                MessageBox.Show("La placa debe tener 7 caracteres");
                return false;
            }

            // Regla 2: los galones deben ser más de 0
            if (nudGalones.Value <= 0)
            {
                MessageBox.Show("Los galones deben ser más de 0");
                return false;
            }
            // Extra: el usuario debe elegir la forma de pago
            if (cmbPago.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la forma de pago");
                return false;
            }

            return true;   // todo está bien
        }

        // =====================================================
        // R4 · PRECIO POR GALÓN (expresión switch)
        // =====================================================
        private decimal Precio(string combustible)
        {
            return combustible switch
            {
                "Premium" => 290m,
                "Regular" => 272m,
                "Gasoil" => 225m,
                _ => 0m              // cualquier otro valor
            };
        }   // <- aquí termina Precio()

        // =====================================================
        // R4 · CALCULAR: total paso a paso, se muestra en lstDetalle
        // =====================================================
        private decimal Calcular()
        {
            decimal galones = nudGalones.Value;
            decimal precio = Precio(cmbCombustible.Text);
            decimal total = galones * precio;

            lstDetalle.Items.Clear();
            lstDetalle.Items.Add($"{galones:0.0} gal × RD$ {precio:N2} = RD$ {total:N2}");

            // Regla 3: con 20 galones o más, 2 % de descuento (primero)
            if (galones >= 20)
            {
                total = total * 0.98m;
                lstDetalle.Items.Add($"Descuento 20+ galones -2 %: RD$ {total:N2}");
            }

            // Regla 4 y 5: con tarjeta, 3 % de recargo (después)
            if (cmbPago.Text == "Tarjeta")
            {
                total = total * 1.03m;
                lstDetalle.Items.Add($"Tarjeta +3 %: RD$ {total:N2}");
            }

            total = Math.Round(total, 2);   // 2 decimales
            lstDetalle.Items.Add($"TOTAL: RD$ {total:N2}");
            return total;
        }

        // Botón Cotizar: valida y muestra el detalle (no guarda nada)
        private void btnCotizar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;   // si hay error, no sigue
            Calcular();
        }

        // =====================================================
        // R5 · GUARDAR DESPACHOS Y RESUMIR
        // =====================================================

        // Lista donde se guardan todos los despachos del día
        private List<Despacho> despachos = new List<Despacho>();

        // Botón Despachar: valida, calcula, guarda y actualiza el resumen
        private void btnDespachar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            decimal total = Calcular();

            Despacho d = new Despacho();
            d.Numero = despachos.Count + 1;                 // #01, #02, #03...
            d.Placa = txtPlaca.Text.Trim().ToUpper();
            d.Combustible = cmbCombustible.Text;
            d.Galones = nudGalones.Value;
            d.Pago = cmbPago.Text;
            d.Total = total;

            despachos.Add(d);

            ActualizarResumen();
        }

        // Muestra la lista de despachos y el resumen del día
        private void ActualizarResumen()
        {
            lstDespachos.Items.Clear();

            decimal vendido = 0;
            decimal galones = 0;
            Despacho mayor = null;

            foreach (Despacho d in despachos)
            {
                lstDespachos.Items.Add(d);   // usa ToString() de Despacho

                vendido += d.Total;
                galones += d.Galones;

                // guarda el despacho con el mayor total
                if (mayor == null || d.Total > mayor.Total)
                {
                    mayor = d;
                }
            }

            if (mayor != null)
            {
                lblResumen.Text = $"{despachos.Count} despachos · " +
                                  $"Vendido RD$ {vendido:N2} · " +
                                  $"Galones {galones:0.0} · " +
                                  $"Mayor: #{mayor.Numero:00} {mayor.Placa} " +
                                  $"(RD$ {mayor.Total:N2})";
            }
            else
            {
                lblResumen.Text = "Sin despachos registrados";
            }
        }

        // =====================================================
        // R6 · GALONES POR COMBUSTIBLE (Dictionary)
        // Se deja aquí para que el botón ya conectado no dé error
        // =====================================================
        private void btnPorCombustible_Click(object sender, EventArgs e)
        {
            Dictionary<string, decimal> porCombustible = new Dictionary<string, decimal>();

            foreach (Despacho d in despachos)
            {
                if (porCombustible.ContainsKey(d.Combustible))
                    porCombustible[d.Combustible] += d.Galones;   // ya existe: suma
                else
                    porCombustible[d.Combustible] = d.Galones;    // nuevo: asigna
            }

            lstDetalle.Items.Clear();
            foreach (var par in porCombustible)
                lstDetalle.Items.Add($"{par.Key} {par.Value:0.0}");
        }

        // =====================================================
        // Eventos vacíos creados por Visual Studio al hacer doble clic.
        // No los borres: el diseño los usa y daría error.
        // =====================================================
        private void txtPlaca_TextChanged(object sender, EventArgs e) { }
        private void cmbCombustible_SelectedIndexChanged(object sender, EventArgs e) { }
        private void nudGalones_ValueChanged(object sender, EventArgs e) { }
        private void cmbPago_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lstDespacho_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lstDetalle_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}