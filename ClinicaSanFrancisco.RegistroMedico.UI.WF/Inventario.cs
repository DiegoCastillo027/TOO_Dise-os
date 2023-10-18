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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chbAlcohol_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAlcohol.Checked)
            {
                chbAlgodon.Checked = false;
                chbGasas.Checked = false;
                chbGuantes.Checked = false;
                chbInyecciones.Checked = false;
                chbMedicamento.Checked = false;

                chbAlgodon.Enabled = false;
                chbGasas.Enabled = false;
                chbGuantes.Enabled = false;
                chbInyecciones.Enabled = false;
                chbMedicamento.Enabled = false;

                InventarioBL _InBL = new InventarioBL();
                if (chbAlcohol.Checked)
                {
                    dgvInventario.DataSource = _InBL.ObtenerInventarioAlcohol();
                }
               /* else
                {
                    dgvInventario.DataSource = null;
                }*/
            }
            else
            {
                chbAlgodon.Enabled = true;
                chbGasas.Enabled = true;
                chbGuantes.Enabled = true;
                chbInyecciones.Enabled = true;
                chbMedicamento.Enabled = true;
                dgvInventario.DataSource = null;
            }
        }

        private void Inventario_Load(object sender, EventArgs e)
        {

            //this.Size = new Size(1000, 600);

        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            /*try
            {
                InventarioBL _InBL = new InventarioBL();
                if (chbAlcohol.Checked)
                {
                    dgvInventario.DataSource = _InBL.ObtenerInventarioAlcohol();
                }
                /*else if (chbNIE.Checked && txtBuscar.Text.Trim() != "")
                {
                    dgvEstudiantes.DataSource = _EsBL.BuscarEstudiantesPorNIE(Convert.ToInt32(txtBuscar.Text));
                }
                else if (chbGrado.Checked && txtBuscar.Text.Trim() != "")
                {
                    dgvEstudiantes.DataSource = _EsBL.BuscarEstudiantePorGrado(txtBuscar.Text);
                }
                else
                {
                    dgvInventario.DataSource = null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error en la aplicación. Mensaje: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }*/
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void chbGasas_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
