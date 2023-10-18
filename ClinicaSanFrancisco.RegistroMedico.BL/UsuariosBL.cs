using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaSanFrancisco.RegistroMedico.DAL;
using ClinicaSanFrancisco.RegistroMedico.EN;
using ClinicaSanFrancisco.RegistroMedico.Soporte.Cache;
namespace ClinicaSanFrancisco.RegistroMedico.BL
{
    public class UsuariosBL
    {
        public int AlmacenarUsuario(Usuarios pusuarios)
        {
            try
            {
                return UsuariosDAL.AlmacenarUsuario(pusuarios);
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
        public bool LoginUsuario(string pNombreUsuario, String pContrasena)
        {
            try
            {
                return UsuariosDAL.Login( pNombreUsuario, pContrasena);
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
        public void Privilegios()
        {
            //Seguridad y permisos ya que la capa de dominio es el corazon del software
            try
            {
                if (CacheInicioSesionUsuario.Nombre == Nombre.Doctor)
                {

                }
                if (CacheInicioSesionUsuario.Nombre == Nombre.Secretaria)
                {

                }
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
        public string RecuperarContrasena(string userRequesting)
        {
            try { 
                return UsuariosDAL.RecuperarContrasena(userRequesting);
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
