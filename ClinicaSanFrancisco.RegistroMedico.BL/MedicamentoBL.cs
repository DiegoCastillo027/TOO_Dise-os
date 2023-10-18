using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaSanFrancisco.RegistroMedico.DAL;
using ClinicaSanFrancisco.RegistroMedico.EN;

namespace ClinicaSanFrancisco.RegistroMedico.BL
{
    public class MedicamentoBL
    {
        public int AgregarMedicamento(Medicamento pMedicamento)
        {
            try
            {
                return MedicamentoDAL.AgregarMedicamento(pMedicamento);
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
        public int ModificarMedicamento(Medicamento pMedicamento)
        {
            try
            {
                return MedicamentoDAL.ModificarMedicamento(pMedicamento);
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

        public int EliminarMedicamento(Int64 pId)
        {
            try
            {
                return MedicamentoDAL.EliminarMedicamento(pId);
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
