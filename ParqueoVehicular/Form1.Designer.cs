namespace ParqueoVehicular
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblResultado = new Label();
            cbTipoVehiculo = new ComboBox();
            txtPlaca = new TextBox();
            txtHorasUso = new TextBox();
            btnCalcularCosto = new Button();
            label6 = new Label();
            txtMarca = new TextBox();
            label7 = new Label();
            txtDescuento = new TextBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 28);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 0;
            label1.Text = "Sistema de parqueo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 68);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 1;
            label2.Text = "Tipo de vehículo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 162);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 2;
            label3.Text = "Placa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 256);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 3;
            label4.Text = "Horas de uso:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 7);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 4;
            label5.Text = "Costo:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(18, 46);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(17, 20);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "0";
            // 
            // cbTipoVehiculo
            // 
            cbTipoVehiculo.FormattingEnabled = true;
            cbTipoVehiculo.Items.AddRange(new object[] { "Carro", "Moto", "Bici", "Camion" });
            cbTipoVehiculo.Location = new Point(166, 68);
            cbTipoVehiculo.Name = "cbTipoVehiculo";
            cbTipoVehiculo.Size = new Size(151, 28);
            cbTipoVehiculo.TabIndex = 6;
            // 
            // txtPlaca
            // 
            txtPlaca.BorderStyle = BorderStyle.FixedSingle;
            txtPlaca.Location = new Point(166, 160);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(151, 27);
            txtPlaca.TabIndex = 7;
            // 
            // txtHorasUso
            // 
            txtHorasUso.BorderStyle = BorderStyle.FixedSingle;
            txtHorasUso.Location = new Point(166, 254);
            txtHorasUso.Name = "txtHorasUso";
            txtHorasUso.Size = new Size(151, 27);
            txtHorasUso.TabIndex = 8;
            // 
            // btnCalcularCosto
            // 
            btnCalcularCosto.BackColor = Color.LimeGreen;
            btnCalcularCosto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcularCosto.ForeColor = Color.White;
            btnCalcularCosto.Location = new Point(376, 232);
            btnCalcularCosto.Name = "btnCalcularCosto";
            btnCalcularCosto.Size = new Size(250, 49);
            btnCalcularCosto.TabIndex = 9;
            btnCalcularCosto.Text = "Calcular costo";
            btnCalcularCosto.UseVisualStyleBackColor = false;
            btnCalcularCosto.Click += btnCalcularCosto_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 118);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 10;
            label6.Text = "Marca:";
            // 
            // txtMarca
            // 
            txtMarca.BorderStyle = BorderStyle.FixedSingle;
            txtMarca.Location = new Point(166, 115);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(151, 27);
            txtMarca.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 211);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 12;
            label7.Text = "Descuento:";
            // 
            // txtDescuento
            // 
            txtDescuento.BorderStyle = BorderStyle.FixedSingle;
            txtDescuento.Location = new Point(166, 209);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(151, 27);
            txtDescuento.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblResultado);
            panel1.Location = new Point(376, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 158);
            panel1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(666, 317);
            Controls.Add(panel1);
            Controls.Add(txtDescuento);
            Controls.Add(label7);
            Controls.Add(txtMarca);
            Controls.Add(label6);
            Controls.Add(btnCalcularCosto);
            Controls.Add(txtHorasUso);
            Controls.Add(txtPlaca);
            Controls.Add(cbTipoVehiculo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblResultado;
        private ComboBox cbTipoVehiculo;
        private TextBox txtPlaca;
        private TextBox txtHorasUso;
        private Button btnCalcularCosto;
        private Label label6;
        private TextBox txtMarca;
        private Label label7;
        private TextBox txtDescuento;
        private Panel panel1;
    }
}
