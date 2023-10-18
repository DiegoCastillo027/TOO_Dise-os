using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaSanFrancisco.RegistroMedico.DAL;
using ClinicaSanFrancisco.RegistroMedico.EN;
namespace ClinicaSanFrancisco.RegistroMedico.BL
{
    public class FichaMedicaBL
    {
        public List<FichaMedicaDoctorSecretariaMedicamentoPacienteReceta> ObtenerFichaMedica()
        {
            try
            {
                return FichaMedicaDAL.ObtenerFichaMedica();
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
        public  int AlmacenarFichaMedica(FichaMedica pFichaMedica)
        {
            try
            {
                return FichaMedicaDAL.AlmacenarFichaMedica(pFichaMedica);
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
        public  int ModificarFichaMedica(FichaMedica pFichaMedica)
        {
            try
            {
                return FichaMedicaDAL.ModificarFichaMedica(pFichaMedica);
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
        public  int EliminarFichaMedica(Int64 pID)
        {
            try
            {
                return FichaMedicaDAL.EliminarFichaMedica(pID);
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
