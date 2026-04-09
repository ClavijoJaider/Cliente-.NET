namespace WayBankClient
{
    partial class GuiListarAhorros
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.cmbxFiltrar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TasaInteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaApertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 288);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumCuenta,
            this.Titular,
            this.Saldo,
            this.TasaInteres,
            this.FechaApertura,
            this.Estado});
            this.dataGridView1.Location = new System.Drawing.Point(20, 21);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(881, 241);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(821, 327);
            this.btnListar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(92, 41);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbxFiltrar
            // 
            this.cmbxFiltrar.FormattingEnabled = true;
            this.cmbxFiltrar.Items.AddRange(new object[] {
            "Normal",
            "Estado"});
            this.cmbxFiltrar.Location = new System.Drawing.Point(639, 336);
            this.cmbxFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxFiltrar.Name = "cmbxFiltrar";
            this.cmbxFiltrar.Size = new System.Drawing.Size(160, 24);
            this.cmbxFiltrar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 340);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtrar por";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NumCuenta
            // 
            this.NumCuenta.DataPropertyName = "NumeroCuenta";
            this.NumCuenta.HeaderText = "Num Cuenta";
            this.NumCuenta.MinimumWidth = 6;
            this.NumCuenta.Name = "NumCuenta";
            this.NumCuenta.Width = 125;
            // 
            // Titular
            // 
            this.Titular.DataPropertyName = "Titular";
            this.Titular.HeaderText = "Titular";
            this.Titular.MinimumWidth = 6;
            this.Titular.Name = "Titular";
            this.Titular.Width = 125;
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "Saldo";
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.MinimumWidth = 6;
            this.Saldo.Name = "Saldo";
            this.Saldo.Width = 125;
            // 
            // TasaInteres
            // 
            this.TasaInteres.DataPropertyName = "TasaInteres";
            this.TasaInteres.HeaderText = "Tasa Interes";
            this.TasaInteres.MinimumWidth = 6;
            this.TasaInteres.Name = "TasaInteres";
            this.TasaInteres.Width = 125;
            // 
            // FechaApertura
            // 
            this.FechaApertura.DataPropertyName = "FechaApertura";
            this.FechaApertura.HeaderText = "Fecha Apertura";
            this.FechaApertura.MinimumWidth = 6;
            this.FechaApertura.Name = "FechaApertura";
            this.FechaApertura.Width = 125;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 125;
            // 
            // GuiListarAhorros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxFiltrar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GuiListarAhorros";
            this.Text = "GuiListar";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ComboBox cmbxFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TasaInteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}