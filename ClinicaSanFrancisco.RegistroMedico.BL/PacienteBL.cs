using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaSanFrancisco.RegistroMedico.DAL;
using ClinicaSanFrancisco.RegistroMedico.EN;
namespace ClinicaSanFrancisco.RegistroMedico.BL
{
   public class PacienteBL
    {
        public List<Paciente> ObtenerPacientes()
        {
            try
            {
                return PacienteDAL.ObtenerPacientes();
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
        public  int AlmacenarPaciente(Paciente pPaciente)
        {
            try
            {
                return PacienteDAL.AlmacenarPaciente(pPaciente);
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
        public  int ModificarPaciente(Paciente pPaciente)
        {
            try
            {
                return PacienteDAL.ModificarPaciente(pPaciente);
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
        public  int EliminarPaciente(Int64 pID)
        {
            try
            {
                return PacienteDAL.EliminarPaciente(pID);
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
