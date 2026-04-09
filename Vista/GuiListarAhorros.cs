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
    public partial class GuiListarAhorros : Form
    {
        private IServicePeticiones service;
        public GuiListarAhorros()
        {
            InitializeComponent();
            service = new ServicePeticiones();
        }

        private void GuiListarAhorros_Load(object sender, EventArgs e)
        {
            cmbxFiltrar.Items.Clear();
            cmbxFiltrar.Items.Add("Todos");
            cmbxFiltrar.Items.Add("Activo");
            cmbxFiltrar.Items.Add("Inactivo");
            cmbxFiltrar.SelectedIndex = 0;

            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = true;

            CargarCuentas();
        }

        private void CargarCuentas()
        {
            var lista = service.ListarCuentas();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string estado = cmbxFiltrar.Text;

            if (estado == "Todos")
            {
                var lista = service.ListarCuentas();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lista;
            }
            else
            {
                var lista = service.ListarCuentasPorEstado(estado);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lista;
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
