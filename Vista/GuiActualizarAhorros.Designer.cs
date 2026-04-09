namespace WayBankClient
{
    partial class GuiActualizarAhorros
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNumInput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRendimiento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonMinApertura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumCuenta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(377, 290);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(67, 31);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNumInput
            // 
            this.txtNumInput.Location = new System.Drawing.Point(257, 261);
            this.txtNumInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumInput.Name = "txtNumInput";
            this.txtNumInput.Size = new System.Drawing.Size(185, 22);
            this.txtNumInput.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.panel1.Location = new System.Drawing.Point(11, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 228);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(169, 191);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(245, 22);
            this.txtFecha.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fecha apertura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto Minimo Apertura";
            // 
            // txtRendimiento
            // 
            this.txtRendimiento.Location = new System.Drawing.Point(169, 151);
            this.txtRendimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRendimiento.Name = "txtRendimiento";
            this.txtRendimiento.Size = new System.Drawing.Size(245, 22);
            this.txtRendimiento.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero Cuenta";
            // 
            // txtMonMinApertura
            // 
            this.txtMonMinApertura.Location = new System.Drawing.Point(169, 116);
            this.txtMonMinApertura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMonMinApertura.Name = "txtMonMinApertura";
            this.txtMonMinApertura.Size = new System.Drawing.Size(245, 22);
            this.txtMonMinApertura.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titular";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(169, 81);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(245, 22);
            this.txtSaldo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo";
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(169, 42);
            this.txtTitular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(245, 22);
            this.txtTitular.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rendimiento";
            // 
            // txtNumCuenta
            // 
            this.txtNumCuenta.Location = new System.Drawing.Point(169, 6);
            this.txtNumCuenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumCuenta.Name = "txtNumCuenta";
            this.txtNumCuenta.ReadOnly = true;
            this.txtNumCuenta.Size = new System.Drawing.Size(245, 22);
            this.txtNumCuenta.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ingrese numero de cuenta";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Location = new System.Drawing.Point(291, 290);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(81, 31);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // GuiActualizarAhorros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 335);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNumInput);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GuiActualizarAhorros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actulizar";
            this.Load += new System.EventHandler(this.GuiActualizarAhorros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNumInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRendimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonMinApertura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumCuenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFecha;
    }
}