using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaSanFrancisco.RegistroMedico.BL;
namespace ClinicaSanFrancisco.RegistroMedico.UI.WF
{
    public partial class RecuperarContrasenacs : Form
    {
        public RecuperarContrasenacs()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var _Usuarios = new UsuariosBL();
            var _resultado = _Usuarios.RecuperarContrasena(txtEmai.Text);
            lblResultado.Text = _resultado;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtEmai_Enter(object sender, EventArgs e)
        {
            if (txtEmai.Text == "Nombre o Email")
            {
                txtEmai.Text = "";
                txtEmai.ForeColor = Color.Green;
            }
        }

        private void txtEmai_Leave(object sender, EventArgs e)
        {
            if (txtEmai.Text == "")
            {
                txtEmai.Text = "Nombre o Email";
                txtEmai.ForeColor = Color.DimGray;
            }
        }
        int m, mx, my;
        private void RecuperarContrasenacs_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void RecuperarContrasenacs_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void RecuperarContrasenacs_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }
    }
}
