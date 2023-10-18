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
    public class ExpedienteDAL
    /*Metodo que devuelve todos los registros de la tabla, sin condiciones*/
    {
        public static int AgregarExpediente(Expediente pExpediente)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarExpediente", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;



                    _command.Parameters.AddWithValue("@IDDoctor", pExpediente.IDDoctor);
                    _command.Parameters.AddWithValue("@IDSecretaria", pExpediente.IDSecretaria);
                    _command.Parameters.AddWithValue("@IDFichaMedica", pExpediente.IDFichaMedica);
                    _command.Parameters.AddWithValue("@IDPaciente", pExpediente.IDPaciente);
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

        public static int ModificarExpediente(Expediente pExpediente)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ModificarExpediente", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;



                    _command.Parameters.AddWithValue("@IDDctor", pExpediente.IDDoctor);
                    _command.Parameters.AddWithValue("@IDSecretaria", pExpediente.IDSecretaria);
                    _command.Parameters.AddWithValue("@IDFichaMedica", pExpediente.IDFichaMedica);
                    _command.Parameters.AddWithValue("@IDPaciente", pExpediente.IDPaciente);


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

        public static int EliminarExpediente(Int64 pID)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("EliminarExpediente", _connection as SqlConnection);
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


         public static List<ExpedienteDoctorSecretariaPacienteFichaMedica> ConsultarExpediente()
         {
                try
                {
                    using (IDbConnection _connection = DBcomun.ObtenerConexion())
                    {
                        _connection.Open();

                        SqlCommand _command = new SqlCommand("ConsultarExpediente", _connection as SqlConnection);
                        _command.CommandType = CommandType.StoredProcedure;
                        SqlDataReader _reader = _command.ExecuteReader();
                        List<ExpedienteDoctorSecretariaPacienteFichaMedica> _listaExpediente = new List<ExpedienteDoctorSecretariaPacienteFichaMedica>();

                        while (_reader.Read())
                        {
                            ExpedienteDoctorSecretariaPacienteFichaMedica _expediente = new ExpedienteDoctorSecretariaPacienteFichaMedica();

                            _expediente.ID = _reader.GetInt64(0);
                            _expediente.Doctor = _reader.GetString(1);
                            _expediente.Secretaria = _reader.GetString(2);
                            _expediente.CodigoUltimaFicha = _reader.GetInt64(3);
                            _expediente.Paciente = _reader.GetString(4);


                            _listaExpediente.Add(_expediente);

                        }
                        _reader.Close();
                        _connection.Close();
                        return _listaExpediente;
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

    }
}
      