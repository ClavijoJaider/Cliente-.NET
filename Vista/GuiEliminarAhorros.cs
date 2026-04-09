using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WayBankClient.service;

namespace WayBankClient
{
    public partial class GuiEliminarAhorros : Form
    {
        private IServicePeticiones service;

        public GuiEliminarAhorros()
        {
            InitializeComponent();
            service = new ServicePeticiones();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNumInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtNumInput.Text.Trim(), out int numero))
                {
                    MessageBox.Show("Número de cuenta inválido.");
                    return;
                }

                DialogResult r = MessageBox.Show(
                    "¿Está seguro de eliminar esta cuenta?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (r != DialogResult.Yes)
                    return;

                bool eliminado = service.EliminarLogico(numero);

                if (eliminado)
                {
                    MessageBox.Show("Cuenta eliminada correctamente.");
                    LimpiarCampos();
                    BloquearCampos(true);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la cuenta.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }

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
                    BloquearCampos(true);
                    return;
                }

                txtNumCuenta.Text = cuenta.NumeroCuenta.ToString();
                txtTitular.Text = cuenta.Titular;
                txtSaldo.Text = cuenta.Saldo.ToString();
               
               
                txtFecha.Text = cuenta.FechaApertura.ToString("yyyy-MM-dd");

                btnEliminar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRendimiento_TextChanged(object sender, EventArgs e)
        {

        }
        private void BloquearCampos(bool bloquear)
        {
            txtNumCuenta.ReadOnly = true;
            txtTitular.ReadOnly = true;
            txtSaldo.ReadOnly = true;
          
            
            txtFecha.ReadOnly = true;

            btnEliminar.Enabled = !bloquear;
        }

        private void LimpiarCampos()
        {
            txtNumCuenta.Clear();
            txtTitular.Clear();
            txtSaldo.Clear();
           
            
            txtFecha.Clear();
            txtNumInput.Clear();
        }
    }
}
