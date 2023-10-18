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
    public class LaboratorioDAL
    /*Metodo que devuelve todos los registros de la tabla, sin condiciones*/
    {
            public static int AgregarLaboratorio(Laboratorio pLaboratorio)
            {
                try
                {
                    using (IDbConnection _connection = DBcomun.ObtenerConexion())
                    {
                        _connection.Open();

                        SqlCommand _command = new SqlCommand("AgregarLaboratorio", _connection as SqlConnection);
                        _command.CommandType = CommandType.StoredProcedure;



                        _command.Parameters.AddWithValue("@NombreVisitadorMedico", pLaboratorio.NombreVisitadorMedico);
                        _command.Parameters.AddWithValue("@ApellidoVisitadorMedico", pLaboratorio.ApellidoVisitadorMedico);
                        _command.Parameters.AddWithValue("@DUIVisitadorMedico", pLaboratorio.DUIVisitadorMedico);
                        _command.Parameters.AddWithValue("@Direccion", pLaboratorio.Direccion);
                        _command.Parameters.AddWithValue("@Empresa", pLaboratorio.Empresa);


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

            public static int ModificarLaboratorio(Laboratorio pLaboratorio)
            {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ModificarLaboratorio", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;



                    _command.Parameters.AddWithValue("@NombreVisitadorMedico", pLaboratorio.NombreVisitadorMedico);
                    _command.Parameters.AddWithValue("@ApellidoVisitadorMedico", pLaboratorio.ApellidoVisitadorMedico);
                    _command.Parameters.AddWithValue("@DUIVisitadorMedico", pLaboratorio.DUIVisitadorMedico);
                    _command.Parameters.AddWithValue("@Direccion", pLaboratorio.Direccion);
                    _command.Parameters.AddWithValue("@Empresa", pLaboratorio.Empresa);


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
            

            public static int EliminarLaboratorio(Int64 pID)
            {
                try
                {
                    using (IDbConnection _connection = DBcomun.ObtenerConexion())
                    {
                        _connection.Open();

                        SqlCommand _command = new SqlCommand("EliminarLaboratorio", _connection as SqlConnection);
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

            public static List<Laboratorio> ConsultarLaboratorio()
            {
                try
                {
                    using (IDbConnection _connection = DBcomun.ObtenerConexion())
                    {
                        _connection.Open();

                        SqlCommand _command = new SqlCommand("ConsultarLaboratorio", _connection as SqlConnection);
                        _command.CommandType = CommandType.StoredProcedure;
                        SqlDataReader _reader = _command.ExecuteReader();
                        List<Laboratorio> _listaLaboratorio = new List<Laboratorio>();

                        while (_reader.Read())
                        {
                            Laboratorio _laboratorio = new Laboratorio();

                            _laboratorio.ID = _reader.GetInt64(0);
                            _laboratorio.NombreVisitadorMedico = _reader.GetString(1);
                            _laboratorio.ApellidoVisitadorMedico = _reader.GetString(2);
                            _laboratorio.DUIVisitadorMedico = _reader.GetString(3);
                            _laboratorio.Direccion = _reader.GetString(4);
                            _laboratorio.Empresa = _reader.GetString(5);

                            _listaLaboratorio.Add(_laboratorio);

                        }
                        _reader.Close();
                        _connection.Close();
                        return _listaLaboratorio;
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
