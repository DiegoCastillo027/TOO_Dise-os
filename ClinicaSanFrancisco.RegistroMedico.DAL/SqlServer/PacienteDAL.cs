using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaSanFrancisco.RegistroMedico.EN;
using System.Data;
using System.Data.SqlClient;

namespace ClinicaSanFrancisco.RegistroMedico.DAL
{
    public class PacienteDAL
    {
        public static List<Paciente> ObtenerPacientes()
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ConsultarPaciente", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader _reader = _command.ExecuteReader();
                    List<Paciente> _listaPacientes = new List<Paciente>();

                    while (_reader.Read())
                    {
                        Paciente _pa = new Paciente();

                        _pa.ID = _reader.GetInt64(0);
                        _pa.Nombre = _reader.GetString(1);
                        _pa.Apellido = _reader.GetString(2);
                        _pa.Sexo = _reader.GetString(3);
                        _pa.Edad = _reader.GetInt32(4);
                        _pa.FechaNacimiento = _reader.GetDateTime(5);
                        _pa.DUI = _reader.GetString(6);
                        _pa.NumeroTelefono = _reader.GetInt32(7);
                        _pa.Direccion = _reader.GetString(8);
                        _pa.ZonaDeVivienda = _reader.GetString(9);
                        _pa.Ocupacion = _reader.GetString(10);
                        _pa.EstadoCivil = _reader.GetString(11);
                        _pa.AlergicoAUnMedicamento = _reader.GetString(12);
                        _pa.Encargado = _reader.GetString(13);
                        _pa.TipoDeParto = _reader.GetString(14);

                        _listaPacientes.Add(_pa);

                    }
                    _reader.Close();
                    _connection.Close();
                    return _listaPacientes;
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
        public static int AlmacenarPaciente(Paciente pPaciente)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarPaciente", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;



                    _command.Parameters.AddWithValue("@Nombre", pPaciente.Nombre);
                    _command.Parameters.AddWithValue("@Apellido", pPaciente.Apellido);
                    _command.Parameters.AddWithValue("@Sexo", pPaciente.Sexo);
                    _command.Parameters.AddWithValue("@Edad", pPaciente.Edad);
                    _command.Parameters.AddWithValue("@FechaNacimiento", pPaciente.FechaNacimiento);
                    _command.Parameters.AddWithValue("@DUI", pPaciente.DUI);
                    _command.Parameters.AddWithValue("@NumeroTelefono", pPaciente.NumeroTelefono);
                    _command.Parameters.AddWithValue("@Direccion", pPaciente.Direccion);
                    _command.Parameters.AddWithValue("@ZonaDeVivienda", pPaciente.ZonaDeVivienda);
                    _command.Parameters.AddWithValue("@Ocupacion", pPaciente.Ocupacion);
                    _command.Parameters.AddWithValue("@EstadoCivil", pPaciente.EstadoCivil);
                    _command.Parameters.AddWithValue("@AlergicoAUnMedicamento", pPaciente.AlergicoAUnMedicamento);
                    _command.Parameters.AddWithValue("@Encargado", pPaciente.Encargado);
                    _command.Parameters.AddWithValue("@TipoDeParto", pPaciente.TipoDeParto);


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
        public static int ModificarPaciente(Paciente pPaciente)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ModificarPaciente", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;


                    _command.Parameters.AddWithValue("@Nombre", pPaciente.Nombre);
                    _command.Parameters.AddWithValue("@Apellido", pPaciente.Apellido);
                    _command.Parameters.AddWithValue("@Sexo", pPaciente.Sexo);
                    _command.Parameters.AddWithValue("@Edad", pPaciente.Edad);
                    _command.Parameters.AddWithValue("@FechaNacimiento", pPaciente.FechaNacimiento);
                    _command.Parameters.AddWithValue("@DUI", pPaciente.DUI);
                    _command.Parameters.AddWithValue("@NumeroTelefono", pPaciente.NumeroTelefono);
                    _command.Parameters.AddWithValue("@Direccion", pPaciente.Direccion);
                    _command.Parameters.AddWithValue("@ZonaDeVivienda", pPaciente.ZonaDeVivienda);
                    _command.Parameters.AddWithValue("@Ocupacion", pPaciente.Ocupacion);
                    _command.Parameters.AddWithValue("@EstadoCivil", pPaciente.EstadoCivil);
                    _command.Parameters.AddWithValue("@AlergicoAUnMedicamento", pPaciente.AlergicoAUnMedicamento);
                    _command.Parameters.AddWithValue("@Encargado", pPaciente.Encargado);
                    _command.Parameters.AddWithValue("@TipoDeParto", pPaciente.TipoDeParto);


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
        public static int EliminarPaciente(Int64 pID)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("EliminarPaciente", _connection as SqlConnection);
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
