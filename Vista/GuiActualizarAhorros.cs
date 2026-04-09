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
    public partial class GuiActualizarAhorros : Form
    {
        private IServicePeticiones service;
        public GuiActualizarAhorros()
        {
            InitializeComponent();
            service = new ServicePeticiones();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtNumInput.Text.Trim(), out int numero))
                {
                    MessageBox.Show("Ingrese un número de cuenta válido.");
                    return;
                }

                var cuenta = service.BuscarPorNumeroCuenta(numero);

                if (cuenta == null)
                {
                    MessageBox.Show("Cuenta no encontrada.");
                    LimpiarCampos();
                    return;
                }

                txtNumCuenta.Text = cuenta.NumeroCuenta.ToString();
                txtTitular.Text = cuenta.Titular;
                txtSaldo.Text = cuenta.Saldo.ToString();


                txtFecha.Text = cuenta.FechaApertura.ToString("yyyy-MM-dd");
                BloquearCampos(false);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtNumInput.Text.Trim(), out int numeroBuscar))
                {
                    MessageBox.Show("Número de búsqueda inválido.");
                    return;
                }

                if (!int.TryParse(txtNumCuenta.Text.Trim(), out int numeroCuenta))
                {
                    MessageBox.Show("Número de cuenta inválido.");
                    return;
                }

                if (!double.TryParse(txtSaldo.Text.Trim(), out double saldo))
                {
                    MessageBox.Show("Saldo inválido.");
                    return;
                }



                CuentaAhorrosDto cuentaEditada = new CuentaAhorrosDto
                {
                    NumeroCuenta = numeroCuenta,
                    Titular = txtTitular.Text.Trim(),
                    Saldo = saldo,

                    FechaApertura = DateTime.Parse(txtFecha.Text)

                };

                bool actualizado = service.ActualizarCuenta(numeroBuscar, cuentaEditada);

                if (actualizado)
                {
                    MessageBox.Show("Cuenta actualizada correctamente.");
                    LimpiarCampos();
                    BloquearCampos(true);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la cuenta.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }


        

        private void GuiActualizarAhorros_Load(object sender, EventArgs e)
        {
           
            BloquearCampos(true);
        }
        private void BloquearCampos(bool bloquear)
        {

            txtNumCuenta.ReadOnly = true; 
            txtTitular.ReadOnly = bloquear;
            txtSaldo.ReadOnly = bloquear;
            txtFecha.ReadOnly = bloquear;

            btnActualizar.Enabled = !bloquear;
        }

        private void LimpiarCampos()
        {
            txtNumCuenta.Clear();
            txtTitular.Clear();
            txtSaldo.Clear();
           
           
            txtNumInput.Clear();
            txtFecha.Clear();
        }
    }
}
