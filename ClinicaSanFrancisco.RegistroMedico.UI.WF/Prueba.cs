using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaSanFrancisco.RegistroMedico.Soporte.Cache;
namespace ClinicaSanFrancisco.RegistroMedico.UI.WF
{
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar sesion?",
                "Advetencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void CargarDatosUsuario()
        {
            lblNombre.Text = CacheInicioSesionUsuario.Nombres + " " + CacheInicioSesionUsuario.Apellidos;
            lblCargo.Text = CacheInicioSesionUsuario.Nombre;
            lblEmail.Text = CacheInicioSesionUsuario.Email;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatosUsuario();
        }
    }
}

