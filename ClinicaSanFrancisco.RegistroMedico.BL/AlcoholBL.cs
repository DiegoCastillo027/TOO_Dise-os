using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaSanFrancisco.RegistroMedico.DAL;
using ClinicaSanFrancisco.RegistroMedico.EN;
namespace ClinicaSanFrancisco.RegistroMedico.BL
{
    public class AlcoholBL
    {
        public int AlmacenarAlcohol(Alcohol pAlcohol)
        {
            try
            {
                return AlcoholDAL.AlmacenarAlcohol(pAlcohol);
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
        public int ModificarAlcohol(Alcohol pAlcohol)
        {
            try
            {
                return AlcoholDAL.ModificarAlcohol(pAlcohol);
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
        public int EliminarAlcohol(Int64 pID)
        {
            try
            {
                return AlcoholDAL.EliminarAlcohol(pID);
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
