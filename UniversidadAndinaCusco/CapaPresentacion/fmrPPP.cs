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
    public partial class fmrPPP : Form
    {
        public fmrPPP()
        {
            InitializeComponent();
        }
        CapaNegocio.PPP ppp1 = new CapaNegocio.PPP();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string nombreAlumno= txtNombreAlumno.Text;
            string apellidoAlumno = txtApellidoAlumno.Text;
            string lugarPractica = txtLugarPractica.Text;
            ppp1.NombreAlumno = nombreAlumno;
            ppp1.ApellidoAlumno = apellidoAlumno;
            ppp1.LugarPractica = lugarPractica;
            MessageBox.Show("Se han registrado correctamente los datos de PPP 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string nombreAlumno = ppp1.NombreAlumno;
            string apellidoAlumno = ppp1.ApellidoAlumno;
            string lugarPractica = ppp1.LugarPractica;
            MessageBox.Show("NombreAlumno: " + nombreAlumno + "ApellidoAlumno: " + apellidoAlumno + "LugarPractica: " + lugarPractica);
        }

        private void btnExperimentar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp1.Experimetar());
        }

        private void btnAprender_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp1.Aprender());
        }

        private void btnTrbajar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp1.Trabajar());
        }
    }
}
