using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuariosp.DAO
{
     class ClienteDAO
    {
        public MySqlConnection Conectar()
        {
            string servidor = "localhost";
            string usuario = "root";
            string password = "";
            string BaseDeDatos = "Clientes";
            string Conexion = "Database=" + BaseDeDatos + "; Data Source=" + servidor
                + "; User Id=" + usuario + "; Password=" + password + "";

            MySqlConnection conexionDB = new MySqlConnection(Conexion);
            conexionDB.Open();

            return conexionDB;
        }

        public List<Cliente> ObtenerListadoDeClientes()
        {
            List<Cliente> lista = new List<Cliente>();

            string consulta = "SELECT * FROM clientes;";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            MySqlDataReader lecturaDatos = comando.ExecuteReader();

            while (lecturaDatos.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Id = lecturaDatos.GetString("id");
                cliente.Nombre = lecturaDatos.GetString("nombre");
                cliente.Apellido = lecturaDatos.GetString("apellido");
                cliente.Telefono = lecturaDatos.GetString("telefono");
                cliente.TarjetadeCredito = lecturaDatos.GetString("tarjeta_credito");
                lista.Add(cliente);
            }
            comando.Connection.Close();

            return lista;
        }

        internal void Guardar(Cliente cliente)
        {
            string agregar = "INSERT INTO clientes (nombre, apellido, telefono, tarjeta_credito) VALUES ('" 
                + cliente.Nombre + "', '" + cliente.Apellido + "', '" + cliente.Telefono + "', '" + cliente.TarjetadeCredito + "');";
            MySqlCommand comando = new MySqlCommand(agregar);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        internal void Eliminar(Cliente cliente)
        {
            string eliminar = "DELETE FROM clientes WHERE id = '" + cliente.Id + "';";
            MySqlCommand comando = new MySqlCommand(eliminar);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        internal void Actualizar(Cliente cliente)
        {
            string editar = "UPDATE clientes SET nombre = '" + cliente.Nombre + "', apellido = '"
                + cliente.Apellido + "', telefono = '" + cliente.Telefono + "', tarjeta_credito = '" + cliente.TarjetadeCredito + "' WHERE id = '" + cliente.Id + "';";
            MySqlCommand comando = new MySqlCommand(editar);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }
    }
}
