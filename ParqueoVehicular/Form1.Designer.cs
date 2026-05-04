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
            button1 = new Button();
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
            label3.Location = new Point(42, 119);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 2;
            label3.Text = "Placa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 178);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 3;
            label4.Text = "Horas de uso:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 265);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 4;
            label5.Text = "Costo:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(156, 265);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(17, 20);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "0";
            // 
            // cbTipoVehiculo
            // 
            cbTipoVehiculo.FormattingEnabled = true;
            cbTipoVehiculo.Items.AddRange(new object[] { "Carro", "Moto", "Bici" });
            cbTipoVehiculo.Location = new Point(166, 68);
            cbTipoVehiculo.Name = "cbTipoVehiculo";
            cbTipoVehiculo.Size = new Size(151, 28);
            cbTipoVehiculo.TabIndex = 6;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(166, 116);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(151, 27);
            txtPlaca.TabIndex = 7;
            // 
            // txtHorasUso
            // 
            txtHorasUso.Location = new Point(166, 171);
            txtHorasUso.Name = "txtHorasUso";
            txtHorasUso.Size = new Size(151, 27);
            txtHorasUso.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(402, 68);
            button1.Name = "button1";
            button1.Size = new Size(90, 71);
            button1.TabIndex = 9;
            button1.Text = "Calcular costo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtHorasUso);
            Controls.Add(txtPlaca);
            Controls.Add(cbTipoVehiculo);
            Controls.Add(lblResultado);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
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
        private Button button1;
    }
}
