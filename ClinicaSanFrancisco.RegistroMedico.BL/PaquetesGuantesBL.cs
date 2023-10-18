using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClinicaSanFrancisco.RegistroMedico.EN;
using ClinicaSanFrancisco.RegistroMedico.DAL;

namespace ClinicaSanFrancisco.RegistroMedico.BL
{
    public class PquetesGuantesBL
    {
        public int AgregarPaquetesGuantes(PaquetesGuantes pPaquetesGuantes)
        {
            try
            {
                return PaquetesGuantesDAL.AgregarPaquetesGuantes(pPaquetesGuantes);
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
        public int ModificarPaquetesGuantes(PaquetesGuantes pPaquetesGuantes)
        {
            try
            {

                return PaquetesGuantesDAL.ModificarPaquetesGuantes(pPaquetesGuantes);
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
        public int EliminarPaquetesGuantes(Int64 pID)
        {
            try
            {

                return PaquetesGuantesDAL.EliminarPaquetesGuantes(pID);
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
