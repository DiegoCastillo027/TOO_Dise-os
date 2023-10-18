using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaSanFrancisco.RegistroMedico.DAL;
using ClinicaSanFrancisco.RegistroMedico.EN;
namespace ClinicaSanFrancisco.RegistroMedico.BL
{
    public class InventarioBL
    {
        public List<InventarioMedicamentoDoctorLaboratorio> ObtenerInventarioMedicamentos()
        {
            try
            {
                return InventarioDAL.ObtenerInventarioMedicamentos();
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
        public List<InventarioGasasDoctorLaboratorio> ObtenerInventarioGasas()
        {
            try
            {
                return InventarioDAL.ObtenerInventarioGasas();
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
        public List<InventarioGuantesDoctorLaboratorio> ObtenerInventarioGuantes()
        {
            try
            {
                return InventarioDAL.ObtenerInventarioGuantes();
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
        public List<InventarioInyeccionesDoctorLaboratorio> ObtenerInventarioInyecciones()
        {
            try
            {
                return InventarioDAL.ObtenerInventarioInyecciones();
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
        public List<InventarioAlgodonDoctorLaboratorio> ObtenerInventarioAlgodon()
        {
            try
            {
                return InventarioDAL.ObtenerInventarioAlgodon();
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
        public List<InventarioAlcoholDoctorLaboratorio> ObtenerInventarioAlcohol()
        {
            try
            {
                return InventarioDAL.ObtenerInventarioAlcohol();
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
        public static int AlmacenarInventario(Inventario pInvantario)
        {
            try
            {
                return InventarioDAL.AlmacenarInventario(pInvantario);
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
        public static int ModificarInventario(Inventario pInvantario)
        {
            try
            {
                return InventarioDAL.ModificarInventario(pInvantario);
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
        public static int EliminarInventario(Int64 pID)
        {
            try
            {
                return InventarioDAL.EliminarInventario(pID);
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
