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
    internal class CCuenta
    {
        public void mostrarCuentas(DataGridView tablaCuentas)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string query = "select * from cuentabancaria";

                tablaCuentas.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaCuentas.DataSource = dt;
                objetoConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("no se mostraron los datos de la bd, error: ", ex.ToString());
            }
        }

        public void agregarCuentas(TextBox id_persona, TextBox nro_cuenta, TextBox saldo, TextBox tipo_cuenta)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string query = "insert into cuentabancaria (id_persona, numero_cuenta, saldo, tipo_cuenta)" +
                    "values ('" + id_persona.Text + "', '" + nro_cuenta.Text + "', '" + saldo.Text + "', '" + tipo_cuenta.Text + "');";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("se guardo los registros");
                while (reader.Read())
                {

                }
                objetoConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("no se mostraron los datos de la bd, error: ", ex.ToString());
            }
        }
        public void seleccionarCuentas(DataGridView tablaCuentas, TextBox id_c, TextBox id_persona, TextBox nro_cuenta, TextBox saldo, TextBox tipo_cuenta)
        {
            try
            {
                id_c.Text = tablaCuentas.CurrentRow.Cells[0].Value.ToString();
                id_persona.Text = tablaCuentas.CurrentRow.Cells[1].Value.ToString();
                nro_cuenta.Text = tablaCuentas.CurrentRow.Cells[2].Value.ToString();
                saldo.Text = tablaCuentas.CurrentRow.Cells[3].Value.ToString();
                tipo_cuenta.Text = tablaCuentas.CurrentRow.Cells[4].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo seleccionar, error: ", ex.ToString());
            }
        }
        public void modificarCuentas(TextBox id_c, TextBox id_persona, TextBox nro_cuenta, TextBox saldo, TextBox tipo_cuenta)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string query = "update cuentabancaria set id_persona='"
                    + id_persona.Text + "', numero_cuenta='" + nro_cuenta.Text + "',saldo='" + saldo.Text + "',tipo_cuenta='" + tipo_cuenta.Text + "' where id_cuenta ='" + id_c.Text + "';";

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
        public void eliminarCuentas(TextBox id_c)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string query = "delete from cuentabancaria where id_cuenta= '" + id_c.Text + "';";
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
