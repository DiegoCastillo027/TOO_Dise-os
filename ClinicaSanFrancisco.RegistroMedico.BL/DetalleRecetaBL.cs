using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaSanFrancisco.RegistroMedico.DAL;
using ClinicaSanFrancisco.RegistroMedico.EN;
namespace ClinicaSanFrancisco.RegistroMedico.BL
{
    public class DetalleRecetaBL
    {

        public int AlmacenarDetalleReceta(DetalleReceta pDetalleReceta)
        {
            try
            {
                return DetalleRecetaDAL.AlmacenarDetalleReceta(pDetalleReceta);
            }
            catch (NullReferenceException ex1)
            {
                throw;
            }
            catch (FormatException ex2)
            {
                throw;
            }
            catch (Exception ex3)
            {
                throw;
            }
        }
        public int ModificarDetalleReceta(DetalleReceta pDetalleReceta)
        {
            try
            {
                return DetalleRecetaDAL.ModificarDetalleReceta(pDetalleReceta);
            }
            catch (NullReferenceException ex1)
            {
                throw;
            }
            catch (FormatException ex2)
            {
                throw;
            }
            catch (Exception ex3)
            {
                throw;
            }
        }

    }
}
