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
    public partial class GUIinicio : Form
    {
        public GUIinicio()
        {
            InitializeComponent();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuiCrearAhorros sc = new GuiCrearAhorros();
            sc.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creado por Carlos Gil, Jaider Clavijo y Santiago Lozano. Ver 0.3");
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuiBuscarAhorros sc = new GuiBuscarAhorros();
            sc.Show();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuiActualizarAhorros sc = new GuiActualizarAhorros();
            sc.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuiEliminarAhorros sc = new GuiEliminarAhorros();
            sc.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuiListarAhorros sc = new GuiListarAhorros();
            sc.Show();
        }

        private void calcularRendimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuiListarAhorros sc = new GuiListarAhorros();
            sc.Show();
        }

        private void healtcheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServicePeticiones sp = new ServicePeticiones();
            sp.Healtcheck();
        }
    }
}
