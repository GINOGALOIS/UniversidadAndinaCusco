using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class fmrJefePractica : Form
    {
        public fmrJefePractica()
        {
            InitializeComponent();
        }
        CapaNegocio.JefePractica jefepractica1 = new CapaNegocio.JefePractica();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            string dni = txtDni.Text;
            jefepractica1.Nombres = nombres;
            jefepractica1.Apellidos = apellidos;
            jefepractica1.Dni = dni;
            MessageBox.Show("Se han registrado correctamente los datos de JefePractica 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string nombres = jefepractica1.Nombres;
            string apellidos = jefepractica1.Apellidos;
            string Dni = jefepractica1.Dni;
            MessageBox.Show("Nombres: " + nombres + "Apellidos: " + apellidos + "Dni: " + Dni);
        }

        private void btnSupervisar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefepractica1.Supervisar());
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefepractica1.Enseñar());
        }

        private void btnCorregir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefepractica1.Corregir());
        }
    }
}
