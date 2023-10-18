using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaSanFrancisco.RegistroMedico.DAL;
using ClinicaSanFrancisco.RegistroMedico.EN;
namespace ClinicaSanFrancisco.RegistroMedico.BL
{
    public class PaquetesAlgodonBL
    {


        public int AlmacenarPaquetesAlgodon(PaquetesAlgodon pPaquetesAlgodon)
        {
            try
            {
                return PaquetesAlgodonDAL.AlmacenarPaquetesAlgodon(pPaquetesAlgodon);
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
        public int ModificarPaquetesAlgodon(PaquetesAlgodon pPaquetesAlgodon)
        {
            try
            {
                return PaquetesAlgodonDAL.ModificarPaquetesAlgodon(pPaquetesAlgodon);
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

        public int EliminarPaquetesAlgodon(Int64 pID)
        {
            try
            {
                return PaquetesAlgodonDAL.EliminarPaquetesAlgodon(pID);
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
