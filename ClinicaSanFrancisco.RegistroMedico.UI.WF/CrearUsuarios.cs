using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaSanFrancisco.RegistroMedico.EN;
using ClinicaSanFrancisco.RegistroMedico.BL;
namespace ClinicaSanFrancisco.RegistroMedico.UI.WF
{
    public partial class CrearUsuarios : Form
    {
        public CrearUsuarios()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
           
           
                this.Close();
           
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lklRegresar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
                this.Close();
        }

        private void txtNumTe_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtNombres_Enter(object sender, EventArgs e)
        {
            if (txtNombres.Text == "Nombres")
            {
                txtNombres.Text = "";
                txtNombres.ForeColor = Color.Green;
            }
        }

        private void txtNombres_Leave(object sender, EventArgs e)
        {
            if (txtNombres.Text == "")
            {
                txtNombres.Text = "Nombres";
                txtNombres.ForeColor = Color.DimGray;
            }
        }

        private void txtApelli_Enter(object sender, EventArgs e)
        {
            if (txtApelli.Text == "Apellidos")
            {
                txtApelli.Text = "";
                txtApelli.ForeColor = Color.Green;
            }
        }

        private void txtApelli_Leave(object sender, EventArgs e)
        {
            if (txtApelli.Text == "")
            {
                txtApelli.Text = "Apellidos";
                txtApelli.ForeColor = Color.DimGray;
            }
        }

        private void txtDUI_Enter(object sender, EventArgs e)
        {
            if (txtDUI.Text == "DUI")
            {
                txtDUI.Text = "";
                txtDUI.ForeColor = Color.Green;
            }
        }

        private void txtDUI_Leave(object sender, EventArgs e)
        {
            if (txtApelli.Text == "")
            {
                txtDUI.Text = "DUI";
                txtDUI.ForeColor = Color.DimGray;
            }
        }

        private void txtNumTe_Enter(object sender, EventArgs e)
        {
            if (txtNumTe.Text == "Numero de Teléfono")
            {
                txtNumTe.Text = "";
                txtNumTe.ForeColor = Color.Green;
            }
        }

        private void txtNumTe_Leave(object sender, EventArgs e)
        {
            if (txtNumTe.Text == "")
            {
                txtNumTe.Text = "Numero de Teléfono";
                txtNumTe.ForeColor = Color.DimGray;
            }
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "Dirección")
            {
                txtDireccion.Text = "";
                txtDireccion.ForeColor = Color.Green;
            }
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "")
            {
                txtDireccion.Text = "Dirección";
                txtDireccion.ForeColor = Color.DimGray;
            }
        }

        private void cmbCargo_Enter(object sender, EventArgs e)
        {

        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Green;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.DimGray;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Nombre de Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Green;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Nombre de Usuario";
                txtEmail.ForeColor = Color.DimGray;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "Contraseña")
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
                txtContrasena.Text = "Contraseña";
                txtContrasena.ForeColor = Color.DimGray;
                txtContrasena.UseSystemPasswordChar = false;
            }
        }

        private void txtConfirmContra_Enter(object sender, EventArgs e)
        {
            if (txtConfirmContra.Text == "Confirmar Contraseña")
            {
                txtConfirmContra.Text = "";
                txtConfirmContra.ForeColor = Color.Green;
                txtConfirmContra.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirmContra_Leave(object sender, EventArgs e)
        {
            if (txtConfirmContra.Text == "")
            {
                txtConfirmContra.Text = "Confirmar Contraseña";
                txtConfirmContra.ForeColor = Color.DimGray;
                txtConfirmContra.UseSystemPasswordChar = false;
            }
        }

        private void btnRegistrase_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombres.Text !="" && txtApelli.Text !="" && txtDUI.Text !="" && txtNumTe.Text != ""&& txtDireccion.Text != "" && txtEmail.Text !=""
                    && txtUsuario.Text !="" && txtContrasena.Text != ""&& txtConfirmContra.Text !="")
                {

                     Usuarios _US = new Usuarios();
                    _US.Nombres = txtNombres.Text;
                    _US.Apellidos = txtApelli.Text;
                    _US.DUI = txtDUI.Text;
                    _US.NumeroTelefono = Convert.ToInt32(txtNumTe.Text);
                    _US.Direccion = txtDireccion.Text;
                    _US.IDCargo = Convert.ToInt64(cmbCargo.SelectedValue);
                    _US.Email = txtEmail.Text;
                    _US.NombreUsuario = txtUsuario.Text;
                    _US.Contrasena = txtContrasena.Text;

                    UsuariosBL _usBL = new UsuariosBL();
                    int _resultado = _usBL.AlmacenarUsuario(_US);
                    if (_resultado != 0)
                    {
                        MessageBox.Show("La informacion a sido almacenada con exito.", "Informacion guardada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se aceptan valores en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void lblError_Click(object sender, EventArgs e)
        {

        }
        private void msgError(string msgError)
        {
            lblError.Text = "    " + msgError;
            lblError.Visible = true;
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

        private void pcbVerContraConfir_Click(object sender, EventArgs e)
        {
            if (txtConfirmContra.UseSystemPasswordChar == true)
            {
                txtConfirmContra.UseSystemPasswordChar = false;
            }
            else
            {
                txtConfirmContra.UseSystemPasswordChar = true;
            }
        }
        int m, mx, my;
        private void CrearUsuarios_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void txtConfirmContra_TextChanged(object sender, EventArgs e)
        {
            if (txtContrasena.Text == txtConfirmContra.Text)
            {
                btnRegistrase.Enabled = true;
                lblError.Visible = false;
            }
            else
            {
                btnRegistrase.Enabled = false;
                msgError("Su contraseña no es identica.");
            }
        }

        private void cmbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CrearUsuarios_Load(object sender, EventArgs e)
        {
            CargoBL _cargoBL = new CargoBL();
            cmbCargo.DataSource = _cargoBL.ObtenerCargos();
            cmbCargo.DisplayMember = "Nombre";
            cmbCargo.ValueMember = "ID";
        }

        private void CrearUsuarios_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void CrearUsuarios_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}
