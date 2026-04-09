namespace WayBankClient
{
    partial class GuiBuscarAhorros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumCuenta = new System.Windows.Forms.TextBox();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtMonMinApertura = new System.Windows.Forms.TextBox();
            this.txtRendimiento = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbxFiltrar = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero Cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto Minimo Apertura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rendimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ingrese el parametro";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtNumCuenta
            // 
            this.txtNumCuenta.Location = new System.Drawing.Point(251, 11);
            this.txtNumCuenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumCuenta.Name = "txtNumCuenta";
            this.txtNumCuenta.ReadOnly = true;
            this.txtNumCuenta.Size = new System.Drawing.Size(200, 22);
            this.txtNumCuenta.TabIndex = 6;
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(251, 46);
            this.txtTitular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.ReadOnly = true;
            this.txtTitular.Size = new System.Drawing.Size(200, 22);
            this.txtTitular.TabIndex = 7;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(251, 75);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(200, 22);
            this.txtSaldo.TabIndex = 8;
            // 
            // txtMonMinApertura
            // 
            this.txtMonMinApertura.Location = new System.Drawing.Point(251, 105);
            this.txtMonMinApertura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMonMinApertura.Name = "txtMonMinApertura";
            this.txtMonMinApertura.ReadOnly = true;
            this.txtMonMinApertura.Size = new System.Drawing.Size(200, 22);
            this.txtMonMinApertura.TabIndex = 9;
            // 
            // txtRendimiento
            // 
            this.txtRendimiento.Location = new System.Drawing.Point(251, 137);
            this.txtRendimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRendimiento.Name = "txtRendimiento";
            this.txtRendimiento.ReadOnly = true;
            this.txtRendimiento.Size = new System.Drawing.Size(200, 22);
            this.txtRendimiento.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFecha);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtRendimiento);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMonMinApertura);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSaldo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTitular);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNumCuenta);
            this.panel1.Location = new System.Drawing.Point(11, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 201);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(251, 166);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(200, 22);
            this.txtFecha.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fecha apertura";
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(158, 245);
            this.txtParametro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(197, 22);
            this.txtParametro.TabIndex = 11;
            this.txtParametro.TextChanged += new System.EventHandler(this.txtParametro_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(368, 240);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 33);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 220);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Buscar por";
            // 
            // cmbxFiltrar
            // 
            this.cmbxFiltrar.FormattingEnabled = true;
            this.cmbxFiltrar.Items.AddRange(new object[] {
            "Numero de cuenta",
            "Nombre"});
            this.cmbxFiltrar.Location = new System.Drawing.Point(165, 217);
            this.cmbxFiltrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbxFiltrar.Name = "cmbxFiltrar";
            this.cmbxFiltrar.Size = new System.Drawing.Size(196, 24);
            this.cmbxFiltrar.TabIndex = 14;
            this.cmbxFiltrar.SelectedIndexChanged += new System.EventHandler(this.cmbxFiltrar_SelectedIndexChanged);
            // 
            // GuiBuscarAhorros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 287);
            this.Controls.Add(this.cmbxFiltrar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GuiBuscarAhorros";
            this.Text = "Buscar Cuenta";
            this.Load += new System.EventHandler(this.GuiBuscarAhorros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumCuenta;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtMonMinApertura;
        private System.Windows.Forms.TextBox txtRendimiento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbxFiltrar;
    }
}