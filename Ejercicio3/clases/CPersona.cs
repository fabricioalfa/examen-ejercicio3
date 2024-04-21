using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3.clases
{
    internal class CPersona
    {
        public void mostrarPersonas(DataGridView tablaPersonas)
        {
            try {
                CConexion objetoConexion = new CConexion();

                string query = "select * from persona";

                tablaPersonas.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaPersonas.DataSource = dt;
                objetoConexion.cerrarConexion();

            }
            catch (Exception ex) {
                MessageBox.Show("no se mostraron los datos de la bd, error: ", ex.ToString());
            }
        }

        public void agregarPersonas(TextBox nombre, TextBox apellido, TextBox edad, TextBox rol, TextBox direccion)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string query = "insert into persona (nombre, apellido, edad, rol, direccion)"+
                    "values ('"+ nombre.Text+ "', '"+apellido.Text+"', '"+edad.Text+"', '"+rol.Text+"', '"+direccion.Text+"');";

                MySqlCommand myComand = new MySqlCommand(query,objetoConexion.establecerConexion());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("se guardo los registros");
                while (reader.Read()) { 
                    
                }
                objetoConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("no se mostraron los datos de la bd, error: ", ex.ToString());
            }
        }

        public void seleccionarPersonas(DataGridView tablaPersona,TextBox id, TextBox nombre, TextBox apellido, TextBox edad, TextBox rol, TextBox direccion)
        {
            try
            {
                id.Text = tablaPersona.CurrentRow.Cells[0].Value.ToString();
                nombre.Text = tablaPersona.CurrentRow.Cells[1].Value.ToString();
                apellido.Text = tablaPersona.CurrentRow.Cells[2].Value.ToString();
                edad.Text = tablaPersona.CurrentRow.Cells[3].Value.ToString();
                rol.Text = tablaPersona.CurrentRow.Cells[4].Value.ToString();
                direccion.Text = tablaPersona.CurrentRow.Cells[5].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo seleccionar, error: ", ex.ToString());
            }
        }

        public void modificarPersonas(TextBox id, TextBox nombre, TextBox apellido, TextBox edad, TextBox rol, TextBox direccion)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string query = "update persona set nombre='"
                    + nombre.Text + "', apellido='" + apellido.Text + "',edad='" + edad.Text + "',rol='" + rol.Text + "',direccion='" + direccion.Text + "' where id_persona ='" + id.Text + "';";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("se modifico correctamente");
                while (reader.Read())
                {

                }
                objetoConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("no se actualizaron los datos de la bd, error: ", ex.ToString());
            }
        }

        public void eliminarPersonas(TextBox id)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string query = "delete from persona where id_persona= '" + id.Text + "';";
                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("se elimino correctamente");
                while (reader.Read())
                {

                }
                objetoConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("no se elimino los datos de la bd, error: ", ex.ToString());
            }

        }
    }
}
