using SistemaCRUD3.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCRUD3.VISTAS.ClienteCRUD.VISTAS
{
    public partial class ClienteCrud : Form
    {
        public ClienteCrud()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        private void ClienteCrud_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarClienteBss();
        }

        private void Agregar_btn_Click(object sender, EventArgs e)
        {
            AgregarClienteVISTAS fr = new AgregarClienteVISTAS();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarClienteBss();
            }
        }

        private void Editar_btn_Click(object sender, EventArgs e)
        {
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            EditarClientesVISTAS fr = new EditarClientesVISTAS(IdPersonaSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarClienteBss();
            }
        }

        private void Eliminar_btn_Click(object sender, EventArgs e)
        {
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de eliminar a este cliente?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarClienteBss(IdPersonaSeleccionada);
                dataGridView1.DataSource=bss.ListarClienteBss();
            }
        }
    }
}
