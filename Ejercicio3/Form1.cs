using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            clases.CPersona objetoPersona = new clases.CPersona();
            objetoPersona.mostrarPersonas(dgvpersonas);
            clases.CCuenta objetoCuenta = new clases.CCuenta();
            objetoCuenta.mostrarCuentas(dgvCuenta);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            clases.CPersona objetoPersona = new clases.CPersona();
            objetoPersona.agregarPersonas(txtnombre,txtapellido,txtedad,txtrol,txtdireccion);
            objetoPersona.mostrarPersonas(dgvpersonas);
        }

        private void dgvpersonas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            clases.CPersona objetoPersona = new clases.CPersona();
            objetoPersona.seleccionarPersonas(dgvpersonas,txtid, txtnombre, txtapellido, txtedad, txtrol, txtdireccion);
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            clases.CPersona objetoPersona = new clases.CPersona();
            objetoPersona.modificarPersonas(txtid, txtnombre, txtapellido, txtedad, txtrol, txtdireccion);
            objetoPersona.mostrarPersonas(dgvpersonas);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            clases.CPersona objetoPersona = new clases.CPersona();
            objetoPersona.eliminarPersonas(txtid);
            objetoPersona.mostrarPersonas(dgvpersonas);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnagregarc_Click(object sender, EventArgs e)
        {
            clases.CCuenta objetoCuenta = new clases.CCuenta();
            objetoCuenta.agregarCuentas(txtidp, txtnrocuenta, txtsaldo, txttipo);
            objetoCuenta.mostrarCuentas(dgvCuenta);
        }

        private void dgvCuenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clases.CCuenta objetoCuenta = new clases.CCuenta();
            objetoCuenta.seleccionarCuentas(dgvCuenta, txtidc, txtidp, txtnrocuenta, txtsaldo, txttipo);
        }

        private void btnmodificarc_Click(object sender, EventArgs e)
        {
            clases.CCuenta objetoCuenta = new clases.CCuenta();
            objetoCuenta.modificarCuentas(txtidc, txtidp, txtnrocuenta, txtsaldo, txttipo);
            objetoCuenta.mostrarCuentas(dgvCuenta);
        }

        private void btneliminarc_Click(object sender, EventArgs e)
        {
            clases.CCuenta objetoCuenta = new clases.CCuenta();
            objetoCuenta.eliminarCuentas(txtidc);
            objetoCuenta.mostrarCuentas(dgvCuenta);
        }
    }
}
