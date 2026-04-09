using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WayBankClient.model;
using WayBankClient.service;

namespace WayBankClient
{
    public partial class GuiCrearAhorros : Form
    {
        private IServicePeticiones service;
        public GuiCrearAhorros()
        {
            InitializeComponent();
            service = new ServicePeticiones();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void GuiCrearAhorros_Load(object sender, EventArgs e)
        {
            pickerTiempo.Format = DateTimePickerFormat.Short;
        }

        private void txtNumCuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTitular_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNumCuenta.Text) ||
                    string.IsNullOrWhiteSpace(txtTasaInteres.Text) ||
                    string.IsNullOrWhiteSpace(txtSaldo.Text) ||
                    string.IsNullOrWhiteSpace(txtTitular.Text))
               
                {
                    MessageBox.Show("Complete todos los campos.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                CuentaAhorrosDto cuenta = new CuentaAhorrosDto
                {
                    NumeroCuenta = int.Parse(txtNumCuenta.Text),
                    Titular = txtTitular.Text,
                    TasaInteres = double.Parse(txtTasaInteres.Text),
                    Saldo = double.Parse(txtSaldo.Text),
                    Estado = "Activo",
                    FechaApertura = pickerTiempo.Value
                };

                bool creado = service.CrearCuenta(cuenta);

                if (creado)
                {
                    MessageBox.Show("Cuenta creada correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo crear la cuenta.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Verifique que Número de cuenta, Tasa de interés y Saldo sean numéricos.",
                    "Error de formato",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void pickerTiempo_ValueChanged(object sender, EventArgs e)
        {

        }
        private void LimpiarCampos()
        {
            txtNumCuenta.Clear();
            txtTasaInteres.Clear();
            txtSaldo.Clear();
            txtTitular.Clear();

            pickerTiempo.Value = DateTime.Now;
            txtNumCuenta.Focus();
        }
    }
}

