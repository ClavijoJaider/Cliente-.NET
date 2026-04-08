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
            this.NumCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TasaInteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaApertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbxFitrar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(9, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 234);
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
            this.dataGridView1.Location = new System.Drawing.Point(15, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(661, 196);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(616, 266);
            this.btnListar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(69, 33);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumCuenta
            // 
            this.NumCuenta.HeaderText = "Num Cuenta";
            this.NumCuenta.Name = "NumCuenta";
            // 
            // Titular
            // 
            this.Titular.HeaderText = "Titular";
            this.Titular.Name = "Titular";
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            // 
            // TasaInteres
            // 
            this.TasaInteres.HeaderText = "Tasa Interes";
            this.TasaInteres.Name = "TasaInteres";
            // 
            // FechaApertura
            // 
            this.FechaApertura.HeaderText = "Fecha Apertura";
            this.FechaApertura.Name = "FechaApertura";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // cmbxFitrar
            // 
            this.cmbxFitrar.FormattingEnabled = true;
            this.cmbxFitrar.Items.AddRange(new object[] {
            "Normal",
            "Estado"});
            this.cmbxFitrar.Location = new System.Drawing.Point(479, 273);
            this.cmbxFitrar.Name = "cmbxFitrar";
            this.cmbxFitrar.Size = new System.Drawing.Size(121, 21);
            this.cmbxFitrar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtrar por";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GuiListarAhorros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 310);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxFitrar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn NumCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TasaInteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.ComboBox cmbxFitrar;
        private System.Windows.Forms.Label label1;
    }
}