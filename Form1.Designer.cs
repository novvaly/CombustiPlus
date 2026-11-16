namespace CombustiPlus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpNuevo = new GroupBox();
            nudGalones = new NumericUpDown();
            cmbPago = new ComboBox();
            cmbCombustible = new ComboBox();
            txtPlaca = new TextBox();
            btnDespachar = new Button();
            btnCotizar = new Button();
            lblPagos = new Label();
            lblGalones = new Label();
            lblCombustible = new Label();
            lblPlaca = new Label();
            grpDespacho = new GroupBox();
            lstDespacho = new ListBox();
            btnPorCombustible = new Button();
            grpDetalle = new GroupBox();
            lstDetalle = new ListBox();
            button4 = new Button();
            label5 = new Label();
            grpNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudGalones).BeginInit();
            grpDespacho.SuspendLayout();
            grpDetalle.SuspendLayout();
            SuspendLayout();
            // 
            // grpNuevo
            // 
            grpNuevo.BackColor = Color.FromArgb(233, 217, 255);
            grpNuevo.Controls.Add(nudGalones);
            grpNuevo.Controls.Add(cmbPago);
            grpNuevo.Controls.Add(cmbCombustible);
            grpNuevo.Controls.Add(txtPlaca);
            grpNuevo.Controls.Add(btnDespachar);
            grpNuevo.Controls.Add(btnCotizar);
            grpNuevo.Controls.Add(lblPagos);
            grpNuevo.Controls.Add(lblGalones);
            grpNuevo.Controls.Add(lblCombustible);
            grpNuevo.Controls.Add(lblPlaca);
            grpNuevo.ForeColor = Color.Black;
            grpNuevo.Location = new Point(24, 21);
            grpNuevo.Name = "grpNuevo";
            grpNuevo.Size = new Size(394, 272);
            grpNuevo.TabIndex = 0;
            grpNuevo.TabStop = false;
            grpNuevo.Text = "Nuevo despacho";
            // 
            // nudGalones
            // 
            nudGalones.BackColor = Color.White;
            nudGalones.DecimalPlaces = 1;
            nudGalones.Location = new Point(120, 133);
            nudGalones.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudGalones.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudGalones.Name = "nudGalones";
            nudGalones.Size = new Size(125, 27);
            nudGalones.TabIndex = 9;
            nudGalones.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // cmbPago
            // 
            cmbPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPago.FormattingEnabled = true;
            cmbPago.Location = new Point(120, 179);
            cmbPago.Name = "cmbPago";
            cmbPago.Size = new Size(125, 28);
            cmbPago.TabIndex = 8;
            // 
            // cmbCombustible
            // 
            cmbCombustible.BackColor = Color.White;
            cmbCombustible.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCombustible.FormattingEnabled = true;
            cmbCombustible.Location = new Point(120, 93);
            cmbCombustible.Name = "cmbCombustible";
            cmbCombustible.Size = new Size(125, 28);
            cmbCombustible.TabIndex = 7;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(120, 46);
            txtPlaca.MaxLength = 7;
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(125, 27);
            txtPlaca.TabIndex = 6;
            // 
            // btnDespachar
            // 
            btnDespachar.BackColor = Color.FromArgb(181, 135, 230);
            btnDespachar.FlatStyle = FlatStyle.Flat;
            btnDespachar.ForeColor = Color.White;
            btnDespachar.Location = new Point(219, 227);
            btnDespachar.Name = "btnDespachar";
            btnDespachar.Size = new Size(111, 29);
            btnDespachar.TabIndex = 5;
            btnDespachar.Text = "Despachar";
            btnDespachar.UseVisualStyleBackColor = false;
            // 
            // btnCotizar
            // 
            btnCotizar.BackColor = Color.FromArgb(181, 135, 230);
            btnCotizar.FlatStyle = FlatStyle.Flat;
            btnCotizar.ForeColor = Color.White;
            btnCotizar.Location = new Point(76, 227);
            btnCotizar.Name = "btnCotizar";
            btnCotizar.Size = new Size(115, 29);
            btnCotizar.TabIndex = 4;
            btnCotizar.Text = "Cotizar";
            btnCotizar.UseVisualStyleBackColor = false;
            // 
            // lblPagos
            // 
            lblPagos.AutoSize = true;
            lblPagos.BackColor = Color.Transparent;
            lblPagos.Location = new Point(6, 187);
            lblPagos.Name = "lblPagos";
            lblPagos.Size = new Size(48, 20);
            lblPagos.TabIndex = 3;
            lblPagos.Text = "Pagos";
            // 
            // lblGalones
            // 
            lblGalones.AutoSize = true;
            lblGalones.BackColor = Color.Transparent;
            lblGalones.Location = new Point(6, 140);
            lblGalones.Name = "lblGalones";
            lblGalones.Size = new Size(62, 20);
            lblGalones.TabIndex = 2;
            lblGalones.Text = "Galones";
            // 
            // lblCombustible
            // 
            lblCombustible.AutoSize = true;
            lblCombustible.BackColor = Color.Transparent;
            lblCombustible.Location = new Point(6, 93);
            lblCombustible.Name = "lblCombustible";
            lblCombustible.Size = new Size(93, 20);
            lblCombustible.TabIndex = 1;
            lblCombustible.Text = "Combustible";
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.BackColor = Color.Transparent;
            lblPlaca.Location = new Point(6, 46);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(44, 20);
            lblPlaca.TabIndex = 0;
            lblPlaca.Text = "Placa";
            // 
            // grpDespacho
            // 
            grpDespacho.BackColor = Color.FromArgb(233, 217, 255);
            grpDespacho.Controls.Add(lstDespacho);
            grpDespacho.Controls.Add(btnPorCombustible);
            grpDespacho.Location = new Point(424, 21);
            grpDespacho.Name = "grpDespacho";
            grpDespacho.Size = new Size(364, 295);
            grpDespacho.TabIndex = 1;
            grpDespacho.TabStop = false;
            grpDespacho.Text = "Despacho del dia";
            // 
            // lstDespacho
            // 
            lstDespacho.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstDespacho.FormattingEnabled = true;
            lstDespacho.Location = new Point(26, 56);
            lstDespacho.Name = "lstDespacho";
            lstDespacho.Size = new Size(317, 164);
            lstDespacho.TabIndex = 6;
            // 
            // btnPorCombustible
            // 
            btnPorCombustible.BackColor = Color.FromArgb(181, 135, 230);
            btnPorCombustible.FlatStyle = FlatStyle.Flat;
            btnPorCombustible.ForeColor = Color.White;
            btnPorCombustible.Location = new Point(36, 243);
            btnPorCombustible.Name = "btnPorCombustible";
            btnPorCombustible.Size = new Size(293, 29);
            btnPorCombustible.TabIndex = 5;
            btnPorCombustible.Text = "Galones por combustible";
            btnPorCombustible.UseVisualStyleBackColor = false;
            // 
            // grpDetalle
            // 
            grpDetalle.Controls.Add(lstDetalle);
            grpDetalle.Controls.Add(button4);
            grpDetalle.Location = new Point(24, 308);
            grpDetalle.Name = "grpDetalle";
            grpDetalle.Size = new Size(394, 130);
            grpDetalle.TabIndex = 2;
            grpDetalle.TabStop = false;
            grpDetalle.Text = "Detalle";
            grpDetalle.Enter += groupBox3_Enter;
            // 
            // lstDetalle
            // 
            lstDetalle.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstDetalle.FormattingEnabled = true;
            lstDetalle.Location = new Point(6, 26);
            lstDetalle.Name = "lstDetalle";
            lstDetalle.Size = new Size(382, 84);
            lstDetalle.TabIndex = 6;
            // 
            // button4
            // 
            button4.Location = new Point(36, 243);
            button4.Name = "button4";
            button4.Size = new Size(293, 29);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(578, 354);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 3;
            label5.Text = "label5";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 244, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(grpDetalle);
            Controls.Add(grpDespacho);
            Controls.Add(grpNuevo);
            Name = "Form1";
            grpNuevo.ResumeLayout(false);
            grpNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudGalones).EndInit();
            grpDespacho.ResumeLayout(false);
            grpDetalle.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpNuevo;
        private GroupBox grpDespacho;
        private ComboBox cmbPago;
        private ComboBox cmbCombustible;
        private TextBox txtPlaca;
        private Button btnDespachar;
        private Button btnCotizar;
        private Label lblPagos;
        private Label lblGalones;
        private Label lblCombustible;
        private Label lblPlaca;
        private NumericUpDown nudGalones;
        private ListBox lstDespacho;
        private Button btnPorCombustible;
        private GroupBox grpDetalle;
        private Button button4;
        private Label label5;
        private ListBox lstDetalle;
    }
}
