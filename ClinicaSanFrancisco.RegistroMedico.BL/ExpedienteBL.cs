using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaSanFrancisco.RegistroMedico.DAL;
using ClinicaSanFrancisco.RegistroMedico.EN;
namespace ClinicaSanFrancisco.RegistroMedico.BL
{
    public class ExpedienteBL
    {
        public int AgregarExpediete(Expediente pExpediente)
        {
            try
            {
                return ExpedienteDAL.AgregarExpediente(pExpediente);
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
        public int ModificarExpediente(Expediente pExpediente)
        {
            try
            {
                return ExpedienteDAL.ModificarExpediente(pExpediente);
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

        public int EliminarExpediente(Int64 pId)
        {
            try
            {
                return ExpedienteDAL.EliminarExpediente(pId);
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

        public List<ExpedienteDoctorSecretariaPacienteFichaMedica> ConsultarExpediente()
        {
            try
            {
                return ExpedienteDAL.ConsultarExpediente();
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
