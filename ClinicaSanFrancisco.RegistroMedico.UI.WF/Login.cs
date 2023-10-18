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
namespace ClinicaSanFrancisco.RegistroMedico.UI.WF
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       /*[DllImport("user32.DLL", EntryPoint = "RelaseCapture")]
        private extern static void RelaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);*/
        private void btnUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Green;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "CONTRASEÑA")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Green;
                txtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "CONTRASEÑA";
                txtContrasena.ForeColor = Color.DimGray;
                txtContrasena.UseSystemPasswordChar = false;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtUsuario.Text != "USUARIO")
                {
                    if (txtContrasena.Text != "CONTRASEÑA")
                    {
                        Usuarios _us = new Usuarios();
                        _us.NombreUsuario = txtUsuario.Text;
                        _us.Contrasena = txtContrasena.Text;

                        UsuariosBL _EsBL = new UsuariosBL();
                        bool _resultado = _EsBL.LoginUsuario(txtUsuario.Text, txtContrasena.Text);
                        if (_resultado == true)
                        {
                            
                            Home _home = new Home();
                            _home.Show();
                            _home.FormClosed += Logout;
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error al ingresar su usuario o contraseña, intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtContrasena.Text ="CONTRASEÑA";
                            txtUsuario.Focus();
                        }
                    }
                    else
                    {
                        msgError("Ingrese su contraseña");
                    }
                }
                else
                {
                    msgError("Ingrese su nombre de usuario");
                }
             
            }
            catch (NullReferenceException ex1)
            {
                MessageBox.Show("A ocurrido un error en la ejecución. Mensaje: " + ex1.Message, "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex2)
            {
                MessageBox.Show("A ocurrido un error en la ejecución. Mensaje: " + ex2.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex3)
            {
                MessageBox.Show("A ocurrido un error en la ejecución. Mensaje: " + ex3.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void msgError(string msgError)
        {
            lblError.Text ="    "+ msgError;
            lblError.Visible = true;
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtContrasena.Text = "CONTRASEÑA";
            txtContrasena.UseSystemPasswordChar = false;
            txtUsuario.Text = "USUARIO";
            lblError.Visible = false;
            this.Show();
           // txtUsuario.Focus();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            CrearUsuarios _crea = new CrearUsuarios();
            _crea.Show();
            _crea.FormClosed += Logout;
            this.Hide();
        }
        int m, mx, my;

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void pcbVerContra_Click(object sender, EventArgs e)
        {
            if (txtContrasena.UseSystemPasswordChar == true)
            {
                txtContrasena.UseSystemPasswordChar = false;
            }
            else
            {
                txtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void lklRecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarContrasenacs _recuperar = new RecuperarContrasenacs();
            _recuperar.ShowDialog();
            _recuperar.FormClosed += Logout;
           
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m ==1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }
    }
}
