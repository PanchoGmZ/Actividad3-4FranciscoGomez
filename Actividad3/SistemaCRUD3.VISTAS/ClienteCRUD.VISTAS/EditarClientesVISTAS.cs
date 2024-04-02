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
    public partial class EditarClientesVISTAS : Form
    {
        int idx = 0;
        Clientes clientes = new Clientes();
        ClienteBss bss = new ClienteBss();
        public EditarClientesVISTAS(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void EditarClientesVISTAS_Load(object sender, EventArgs e)
        {
            clientes = bss.ObtenerIdBss(idx);
            textBox1.Text = clientes.Nombre;
            textBox2.Text = clientes.Apellido;
            textBox3.Text = clientes.Correo;
            textBox4.Text = clientes.Telefono;
            textBox5.Text = clientes.Direccion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientes.Nombre = textBox1.Text;
            clientes.Apellido = textBox2.Text;
            clientes.Correo = textBox3.Text;
            clientes.Telefono = textBox4.Text;
            clientes.Direccion = textBox5.Text;
            bss.EditarClienteBss(clientes);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
