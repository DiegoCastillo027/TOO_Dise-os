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
    public class FichaMedicaDAL
    {
        public static List<FichaMedicaDoctorSecretariaMedicamentoPacienteReceta> ObtenerFichaMedica()
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ConsultarFichaMedica", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader _reader = _command.ExecuteReader();
                    List<FichaMedicaDoctorSecretariaMedicamentoPacienteReceta> _listaFicha = new List<FichaMedicaDoctorSecretariaMedicamentoPacienteReceta>();

                    while (_reader.Read())
                    {
                        FichaMedicaDoctorSecretariaMedicamentoPacienteReceta _FM = new FichaMedicaDoctorSecretariaMedicamentoPacienteReceta();

                        _FM.ID = _reader.GetInt64(0);
                        _FM.FechaCita = _reader.GetDateTime(1);
                        _FM.TipoCita = _reader.GetString(2);
                        _FM.Doctor = _reader.GetString(3);
                        _FM.Secretaria = _reader.GetString(4);
                        _FM.Medicamento = _reader.GetString(5);
                        _FM.NombrePaciente = _reader.GetString(6);
                        _FM.ApellidoPaciente = _reader.GetString(7);
                        _FM.CodigoReceta = _reader.GetInt64(8);
                        _FM.ConsultaPor = _reader.GetString(9);
                        _FM.PresenteEnfermedad = _reader.GetString(10);
                        _FM.Temperatura = _reader.GetDecimal(11);
                        _FM.FrecuenciaCardiaca = _reader.GetDecimal(12);
                        _FM.PresionArterial = _reader.GetDecimal(13);
                        _FM.Peso = _reader.GetDecimal(14);
                        _FM.Altura = _reader.GetDecimal(15);
                        _FM.ExamenLaboratorio = _reader.GetString(16);
                        _FM.DescripcionFisica = _reader.GetString(17);
                        _FM.Diagnostico = _reader.GetString(18);

                        _listaFicha.Add(_FM);

                    }
                    _reader.Close();
                    _connection.Close();
                    return _listaFicha;
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
        public static int AlmacenarFichaMedica(FichaMedica pFichaMedica)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarFichaMedica", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;



                    _command.Parameters.AddWithValue("@FechaCita", pFichaMedica.FechaCita);
                    _command.Parameters.AddWithValue("@TipoCita", pFichaMedica.TipoCita);
                    _command.Parameters.AddWithValue("@IDDoctor", pFichaMedica.IDDoctor);
                    _command.Parameters.AddWithValue("@IDSecretaria", pFichaMedica.IDSecretaria);
                    _command.Parameters.AddWithValue("@IDMedicamento", pFichaMedica.IDMedicamento);
                    _command.Parameters.AddWithValue("@IDPaciente", pFichaMedica.IDPaciente);
                    _command.Parameters.AddWithValue("@IDReceta", pFichaMedica.IDReceta);
                    _command.Parameters.AddWithValue("@ConsultaPor", pFichaMedica.ConsultaPor);
                    _command.Parameters.AddWithValue("@PresenteEnfermedad", pFichaMedica.PresenteEnfermedad);
                    _command.Parameters.AddWithValue("@Temperatura", pFichaMedica.Temperatura);
                    _command.Parameters.AddWithValue("@FrecuenciaCardiaca", pFichaMedica.FrecuenciaCardiaca);
                    _command.Parameters.AddWithValue("@PresionArterial", pFichaMedica.PresionArterial);
                    _command.Parameters.AddWithValue("@Peso", pFichaMedica.Peso);
                    _command.Parameters.AddWithValue("@Altura", pFichaMedica.Altura);
                    _command.Parameters.AddWithValue("@ExamenLaboratorio", pFichaMedica.ExamenLaboratorio);
                    _command.Parameters.AddWithValue("@DescripcionFisica", pFichaMedica.DescripcionFisica);
                    _command.Parameters.AddWithValue("@Diagnostico", pFichaMedica.Diagnostico);



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
        public static int ModificarFichaMedica(FichaMedica pFichaMedica)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ModificarFichaMedica", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;


                    _command.Parameters.AddWithValue("@FechaCita", pFichaMedica.FechaCita);
                    _command.Parameters.AddWithValue("@TipoCita", pFichaMedica.TipoCita);
                    _command.Parameters.AddWithValue("@IDDoctor", pFichaMedica.IDDoctor);
                    _command.Parameters.AddWithValue("@IDSecretaria", pFichaMedica.IDSecretaria);
                    _command.Parameters.AddWithValue("@IDMedicamento", pFichaMedica.IDMedicamento);
                    _command.Parameters.AddWithValue("@IDPaciente", pFichaMedica.IDPaciente);
                    _command.Parameters.AddWithValue("@IDReceta", pFichaMedica.IDReceta);
                    _command.Parameters.AddWithValue("@ConsultaPor", pFichaMedica.ConsultaPor);
                    _command.Parameters.AddWithValue("@PresenteEnfermedad", pFichaMedica.PresenteEnfermedad);
                    _command.Parameters.AddWithValue("@Temperatura", pFichaMedica.Temperatura);
                    _command.Parameters.AddWithValue("@FrecuenciaCardiaca", pFichaMedica.FrecuenciaCardiaca);
                    _command.Parameters.AddWithValue("@PresionArterial", pFichaMedica.PresionArterial);
                    _command.Parameters.AddWithValue("@Peso", pFichaMedica.Peso);
                    _command.Parameters.AddWithValue("@Altura", pFichaMedica.Altura);
                    _command.Parameters.AddWithValue("@ExamenLaboratorio", pFichaMedica.ExamenLaboratorio);
                    _command.Parameters.AddWithValue("@DescripcionFisica", pFichaMedica.DescripcionFisica);
                    _command.Parameters.AddWithValue("@Diagnostico", pFichaMedica.Diagnostico);


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
        public static int EliminarFichaMedica(Int64 pID)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("EliminarFichaMedica", _connection as SqlConnection);
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
