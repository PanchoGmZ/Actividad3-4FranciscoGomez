using SistemaCRUD3.BSS;
using SistemaCRUD3.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaCRUD3.VISTAS.ClienteCRUD.VISTAS
{
    public partial class AgregarPedidoVISTAS : Form
    {
        public AgregarPedidoVISTAS()
        {
            InitializeComponent();
        }
        public static int IdPedidoSeleccionada = 0;
        PedidoBss bss = new PedidoBss();
        private void Seleccionar_btn_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
