using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClinicaSanFrancisco.RegistroMedico.EN;
using ClinicaSanFrancisco.RegistroMedico.DAL;

namespace ClinicaSanFrancisco.RegistroMedico.BL
{
    public class SecretariaBL
    {
        public List<Secretaria> ObtenerSecretaria()
        {
            try
            {
                return SecretariaDAL.ObtenerSecretaria();
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
        public int AgregarSecretaria(Secretaria pSecretaria)
        {
            try
            {

                return SecretariaDAL.AgregarrSecretaria(pSecretaria);
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
        public int ModificarSecretaria(Secretaria pSecretaria)
        {
            try 
            { 

                return SecretariaDAL.ModificarSecretaria(pSecretaria);
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
        public int EliminarSecretaria(Int64 pID)
        {
            try
            {
                return SecretariaDAL.EliminarSecretaria(pID);
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

    