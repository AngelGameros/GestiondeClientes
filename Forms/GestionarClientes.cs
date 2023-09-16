using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usuariosp.DAO;

namespace Usuariosp
{
    public partial class GestionarClientes : Form
    {
        public GestionarClientes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Id = labelId.Text;
            cliente.Nombre = boxNombre.Text;
            cliente.Apellido = boxApellido.Text;
            cliente.Telefono = boxTelefono.Text;
            cliente.TarjetadeCredito = boxTarjeta.Text;

            

            if (labelId.Text == "")
            {
                ClienteDAO baseDeDatos = new ClienteDAO();
                baseDeDatos.Guardar(cliente);

                string vacio = "";
                labelId.Text = vacio;
            }
            else
            {
                ClienteDAO baseDeDatos = new ClienteDAO();
                baseDeDatos.Actualizar(cliente);

                string vacio = "";
                labelId.Text = vacio;
            }

            ActualizarLista();
            LimpiarTextBoxes();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente) listClientes.SelectedItem;

            ClienteDAO baseDeDatos = new ClienteDAO();
            baseDeDatos.Eliminar(cliente);

            ActualizarLista();
        }

        private void boxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(e);
        }

        private void boxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(e);
        }

        private void boxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumeros(e);
        }

        private void boxTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumeros(e);
        }

        // METODOS PARA VALIDACIONES 

        static void ValidarLetras(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96 || (e.KeyChar >= 123 && e.KeyChar <= 255)))
            {
                MessageBox.Show("Ingrese sólo letras. (SIN TILDES).", "CARÁCTER INVÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        static void ValidarNumeros(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58))
            {
                MessageBox.Show("Ingrese sólo números.", "CARÁCTER INVÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        // METODO PARA LIMPIAR TEXTBOXES
        private void LimpiarTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void GestionarClientes_Load(object sender, EventArgs e)
        {
            ActualizarLista();

        }

        private void ActualizarLista()
        {
            ClienteDAO BaseDeDatos = new ClienteDAO();
            List<Cliente> listaDB = BaseDeDatos.ObtenerListadoDeClientes();

            listClientes.Items.Clear();
            for (int i = 0; i < listaDB.Count; i++) 
            {
                Cliente cliente = listaDB[i]; 
                listClientes.Items.Add(cliente);

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listClientes.SelectedItem;

            labelId.Text = cliente.Id;
            boxNombre.Text = cliente.Nombre;
            boxApellido.Text = cliente.Apellido;
            boxTelefono.Text = cliente.Telefono;
            boxTarjeta.Text = cliente.TarjetadeCredito;
            
        }
    }
}
