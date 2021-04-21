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
    public partial class fmrRector : Form
    {
        public fmrRector()
        {
            InitializeComponent();
        }
        CapaNegocio.Rector rector1 = new CapaNegocio.Rector();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            string lugarNacimiento = txtLugarNacimiento.Text;
            rector1.Nombres = nombres;
            rector1.Apellidos = apellidos;
            rector1.Lugarnacimiento =lugarNacimiento ;
            MessageBox.Show("Se han registrado correctamente los datos de Rector 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string nombres = rector1.Nombres;
            string apellidos = rector1.Apellidos;
            string lugarnacimiento = rector1.Lugarnacimiento;
            MessageBox.Show("Nombres: " + nombres + "Apellidos: " + apellidos + "LugarNacimiento: " + lugarnacimiento);
        }

        private void btnSupervisar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Supervisar());
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Administrar());
        }

        private void btnControlar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Controlar());
        }
    }
}
