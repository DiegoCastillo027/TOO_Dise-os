using ClinicaSanFrancisco.RegistroMedico.EN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ClinicaSanFrancisco.RegistroMedico.Soporte.Cache;


namespace ClinicaSanFrancisco.RegistroMedico.DAL
{
    public class UsuariosDAL
    {
        public static int AlmacenarUsuario(Usuarios pUsuarios)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AlmacenarUsuario", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Nombres", pUsuarios.Nombres);
                    _command.Parameters.AddWithValue("@Apellidos", pUsuarios.Apellidos);
                    _command.Parameters.AddWithValue("@DUI", pUsuarios.DUI);
                    _command.Parameters.AddWithValue("@NumeroTelefono", pUsuarios.NumeroTelefono);
                    _command.Parameters.AddWithValue("@Direccion", pUsuarios.Direccion);
                    _command.Parameters.AddWithValue("@IDCargo", pUsuarios.IDCargo);
                    _command.Parameters.AddWithValue("@Email", pUsuarios.Email);
                    _command.Parameters.AddWithValue("@NombreUsuario", pUsuarios.NombreUsuario);
                    _command.Parameters.AddWithValue("@Contrasena", pUsuarios.Contrasena);
                    

                    int _resultado = _command.ExecuteNonQuery();
                    _connection.Close();
                    return _resultado;
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
        public static bool Login(string pNombreUsuario, String pContrasena)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("IniciarSesion", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;


                    _command.Parameters.AddWithValue("@NombreUsuario", pNombreUsuario);
                    _command.Parameters.AddWithValue("@Contrasena", pContrasena);

                    SqlDataReader _reader = _command.ExecuteReader();
                    bool _resultado = false;
                    ;
                    if (_reader.HasRows)
                    {
                        while (_reader.Read())
                        {
                            CacheInicioSesionUsuario.ID = _reader.GetInt64(0);
                            CacheInicioSesionUsuario.Nombres = _reader.GetString(1);
                            CacheInicioSesionUsuario.Apellidos = _reader.GetString(2);
                            CacheInicioSesionUsuario.DUI = _reader.GetString(3);
                            CacheInicioSesionUsuario.NumeroTelefono = _reader.GetInt32(4);
                            CacheInicioSesionUsuario.Direccion = _reader.GetString(5);
                            CacheInicioSesionUsuario.Nombre = _reader.GetString(6);
                            CacheInicioSesionUsuario.Email = _reader.GetString(7);
                        }
                        return true;
                    }

                    _connection.Close();
                    return _resultado;
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

        public static string RecuperarContrasena(string userRequesting)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();
                    SqlCommand _command = new SqlCommand("RecuperarContrasena", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;
     
                    _command.Parameters.AddWithValue("@NombreUsuario", userRequesting);
                    _command.Parameters.AddWithValue("@Email", userRequesting);
                    SqlDataReader _reader = _command.ExecuteReader();
                    if (_reader.Read() == true)
                    {
                        string Nombres = _reader.GetString(1)+", "+ _reader.GetString(2);
                        string Email = _reader.GetString(7);
                        String Contrasena = _reader.GetString(9);


                        var ServiciosEmail = new ServiciosEmail.SistemaSoporteEmail();
                        ServiciosEmail.EnviarEmail(
                            subject: "SYSTEM: Solicitud de recuperación de sistema.",
                            body: "Hola, "+Nombres+"\nSolicitas recuperar tu contraseña.\n " +
                            "Tu contraseña actual es: " +Contrasena+
                            "\nSin embargo, le pedimos cambie su contraseña una vez ingrese al sistema.",
                            recipientMail: new List<string> {Email}
                            );
                        return "Hola, " + Nombres + "\nSolicitas recuperar tu contraseña.\n " +
                            "Porfavor revisa tu correo: " + Email +
                            "\nSin embargo, le pedimos cambie su contraseña una vez ingrese al sistema.";
                    }
                    else
                    {
                        return "Lo sentimos, no existe una cuenta con este nombre de usuario con correo electrónico";
                    }
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
        public void Privilegios()
        {
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
    }
}
