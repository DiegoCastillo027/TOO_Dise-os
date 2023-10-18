using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClinicaSanFrancisco.RegistroMedico.EN;
using ClinicaSanFrancisco.RegistroMedico.DAL;

namespace ClinicaSanFrancisco.RegistroMedico.BL
{
    public class DoctorBL
    {
        public List<Doctor> ObtenerMedicos()
        {
            try
            {
                return DoctorDAL.ObtenerMedicos();
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
        public int AgregarDoctor(Doctor pDoctor)
        {
            try
            {
                return DoctorDAL.AgregarDoctor(pDoctor);
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
        public int ModificarDoctor(Doctor pDoctor)
            {
                try
                {
                return DoctorDAL.ModificarDoctor(pDoctor);
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
        public int EliminarDoctor(Int64 pID)
        {
            try
            {

                return DoctorDAL.EliminarDoctor(pID);
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
