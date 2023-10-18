using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaSanFrancisco.RegistroMedico.DAL;
using ClinicaSanFrancisco.RegistroMedico.EN;

namespace ClinicaSanFrancisco.RegistroMedico.BL
{
   public class CargoBL
    {

        public  List<Cargo> ObtenerCargos()
        {
            try
            {
                return CargoDAL.ObtenerCargos();
            
            }
            catch (IndexOutOfRangeException ex1)
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
