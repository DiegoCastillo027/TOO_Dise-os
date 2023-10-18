using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ClinicaSanFrancisco.RegistroMedico.EN;

namespace ClinicaSanFrancisco.RegistroMedico.DAL
{
    public class DoctorDAL
    {
        public static List<Doctor> ObtenerMedicos()
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ConsultarDoctor", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader _reader = _command.ExecuteReader();
                    List<Doctor> _listaDoctor = new List<Doctor>();

                    while (_reader.Read())
                    {
                        Doctor _Doctor = new Doctor();

                        _Doctor.ID = _reader.GetInt64(0);
                        _Doctor.Nombre = _reader.GetString(1);
                        _Doctor.Apellido = _reader.GetString(2);
                        _Doctor.NumeroTelefono = _reader.GetInt32(3);
                        _Doctor.Direccion = _reader.GetString(4);

                        _listaDoctor.Add(_Doctor);

                    }
                    _reader.Close();
                    _connection.Close();
                    return _listaDoctor;
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
        public static int AgregarDoctor(Doctor pDoctor)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarDoctor", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;



                    _command.Parameters.AddWithValue("@Nombre", pDoctor.Nombre);
                    _command.Parameters.AddWithValue("@Apellido", pDoctor.Apellido);
                    _command.Parameters.AddWithValue("@NumeroTelefono", pDoctor.NumeroTelefono);
                    _command.Parameters.AddWithValue("@Direccion", pDoctor.Direccion);

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
        public static int ModificarDoctor(Doctor pDoctor)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ModificarDoctor", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Id", pDoctor.ID);
                    _command.Parameters.AddWithValue("@Nombre", pDoctor.Nombre);
                    _command.Parameters.AddWithValue("@Apellido", pDoctor.Apellido);
                    _command.Parameters.AddWithValue("@NumeroTelefono", pDoctor.NumeroTelefono);
                    _command.Parameters.AddWithValue("@Direccion", pDoctor.Direccion);

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
        public static int EliminarDoctor(Int64 pID)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("EliminarDoctor", _connection as SqlConnection);
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