using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaSanFrancisco.RegistroMedico.DAL;
using ClinicaSanFrancisco.RegistroMedico.EN;

namespace ClinicaSanFrancisco.RegistroMedico.BL
{
    public class LaboratorioBL
    {
        public int AgregarLaboratorio(Laboratorio pLaboratorio)
        {
            try
            {
                return LaboratorioDAL.AgregarLaboratorio(pLaboratorio);
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
        public int ModificarLaboratorio(Laboratorio pLaboratorio)
        {
            try
            {
                return LaboratorioDAL.ModificarLaboratorio(pLaboratorio);
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

        public int EliminarLaboratorio(Int64 pId)
        {
            try
            {
                return LaboratorioDAL.EliminarLaboratorio(pId);
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

        public List<Laboratorio> ConsultarLaboratorio()
        {
            try
            {
                return LaboratorioDAL.ConsultarLaboratorio();
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
