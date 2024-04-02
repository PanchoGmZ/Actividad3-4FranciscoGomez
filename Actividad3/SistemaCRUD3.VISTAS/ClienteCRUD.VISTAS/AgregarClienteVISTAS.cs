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

namespace SistemaCRUD3.VISTAS.ClienteCRUD.VISTAS
{
    public partial class AgregarClienteVISTAS : Form
    {
        public AgregarClienteVISTAS()
        {
            InitializeComponent();
        }
        public static int IdPersonaSeleccionada = 0;
        ClienteBss bss = new ClienteBss();
        private void AgregarClienteVISTAS_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Nombre = textBox1.Text;
            clientes.Apellido = textBox2.Text;
            clientes.Correo = textBox3.Text;
            clientes.Telefono= textBox4.Text;
            clientes.Direccion= textBox5.Text;

            bss.InsertarClienteBss(clientes);
            MessageBox.Show("Se guardo exitosamente");
        }
    }
}
