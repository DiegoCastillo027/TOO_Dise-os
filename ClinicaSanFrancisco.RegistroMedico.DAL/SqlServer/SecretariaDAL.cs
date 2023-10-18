using ClinicaSanFrancisco.RegistroMedico.EN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace ClinicaSanFrancisco.RegistroMedico.DAL
{
    public class SecretariaDAL
    {
        public static List<Secretaria> ObtenerSecretaria()
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ConsultarSecretaria", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader _reader = _command.ExecuteReader();
                    List<Secretaria> _listaSecretaria = new List<Secretaria>();

                    while (_reader.Read())
                    {
                        Secretaria _Secretaria = new Secretaria();

                        _Secretaria.ID = _reader.GetInt64(0);
                        _Secretaria.Nombre = _reader.GetString(1);
                        _Secretaria.Apellido = _reader.GetString(2);
                        _Secretaria.DUI = _reader.GetString(3);
                        _Secretaria.NumeroTelefono = _reader.GetInt32(4);
                        _Secretaria.Direccion = _reader.GetString(5);


                        _listaSecretaria.Add(_Secretaria);

                    }
                    _reader.Close();
                    _connection.Close();
                    return _listaSecretaria;
                }
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
        public static int AgregarrSecretaria(Secretaria pSecretaria)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarSecretaria", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Nombre", pSecretaria.Nombre);
                    _command.Parameters.AddWithValue("@Apellido", pSecretaria.Apellido);
                    _command.Parameters.AddWithValue("@DUI", pSecretaria.DUI);
                    _command.Parameters.AddWithValue("@NumeroTelefono", pSecretaria.NumeroTelefono);
                    _command.Parameters.AddWithValue("@Direccion", pSecretaria.Direccion);

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
        public static int ModificarSecretaria(Secretaria pSecretaria)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ModificarSecretaria", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@ID", pSecretaria.ID);
                    _command.Parameters.AddWithValue("@Nombre", pSecretaria.Nombre);
                    _command.Parameters.AddWithValue("@Apellido", pSecretaria.Apellido);
                    _command.Parameters.AddWithValue("@DUI", pSecretaria.DUI);
                    _command.Parameters.AddWithValue("@NumeroTelefono", pSecretaria.NumeroTelefono);
                    _command.Parameters.AddWithValue("@Direccion", pSecretaria.Direccion);

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
        public static int EliminarSecretaria(Int64 pID)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("EliminarSecretaria", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@ID", pID);


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

    }
}