using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ClinicaSanFrancisco.RegistroMedico.EN;
using ClinicaSanFrancisco.RegistroMedico.BL;
using ClinicaSanFrancisco.RegistroMedico.Soporte.Cache;
namespace ClinicaSanFrancisco.RegistroMedico.UI.WF
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*Si el menu vertical tiene un ancho de 250, se cambiara a 70 px*/

            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }
        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int LX, LY;
        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;    
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            iconrestaura.Visible = true;
            iconmaximizar.Visible = false;
        }

        

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {

        }

        

        

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatosUsuario();
            mostrarLogo();
           // this.Size = new Size(1000, 600);

        }
        private void mostrarLogo()
        {
            AbrirFormularioPanel(new FormLogo());

        }
        private void mostrarLogoAlCerrarForm(object sender, FormClosedEventArgs e)
        {
            mostrarLogo();        
        }

       

        private void iconButton7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar sesion?",
               "Advetencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }



        private void iconrestaura_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1200, 706) ;
            this.Location = new Point(LX, LY);
            
            iconrestaura.Visible = false;
            iconmaximizar.Visible = true;
        }

       

        private void btnInvent_Click(object sender, EventArgs e)
        {
            Inventario _fiv = new Inventario();
            _fiv.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrarForm);
            AbrirFormularioPanel(_fiv);

        }

        private void CargarDatosUsuario()
        {
            lblNombre.Text = CacheInicioSesionUsuario.Nombres + " " + CacheInicioSesionUsuario.Apellidos;
            lblCargo.Text = CacheInicioSesionUsuario.Nombre;
            lblEmail.Text = CacheInicioSesionUsuario.Email;
        }

        
        private void AbrirFormularioPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0) 
                this.panelContenedor.Controls.RemoveAt(0);
                Form _fh = Formhijo as Form;
                _fh.TopLevel = false;
                _fh.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(_fh);
                this.panelContenedor.Tag = _fh;
                _fh.Show();
           

        }

        private void MenuVertical_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void MenuVertical_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void MenuVertical_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
        int m, mx, my;

    }
}
