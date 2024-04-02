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
    public partial class PedidosCrud : Form
    {
        public PedidosCrud()
        {
            InitializeComponent();
        }
        PedidoBss bss = new PedidoBss();
        private void PedidosCrud_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=bss.ListarPedidoBss();
        }
    }
}
