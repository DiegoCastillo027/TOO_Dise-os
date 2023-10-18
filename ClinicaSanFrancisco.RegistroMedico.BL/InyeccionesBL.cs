using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaSanFrancisco.RegistroMedico.DAL;
using ClinicaSanFrancisco.RegistroMedico.EN;

namespace ClinicaSanFrancisco.RegistroMedico.BL
{
    public class InyeccionesBL
    {
        
        public int AgregarInyecciones(Inyecciones pInyecciones)
        {
            try
            {
                return InyeccionesDAL.AgregarInyecciones(pInyecciones);
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
        public int ModificarInyecciones(Inyecciones pInyecciones)
        {
            try
            {

                return InyeccionesDAL.ModificarInyecciones(pInyecciones);
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
        public int EliminarInyecciones(Int64 pID)
        {
            try
            {

                return InyeccionesDAL.EliminarInyecciones(pID);
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
