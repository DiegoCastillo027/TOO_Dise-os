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
    public class MedicamentoDAL
    /*Metodo que devuelve todo los registros de la tabla, sin condiciones*/
    {
        public static int AgregarMedicamento(Medicamento pMedicamento)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarMedicamento", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;



                    _command.Parameters.AddWithValue("@Nombre", pMedicamento.Nombre);
                    _command.Parameters.AddWithValue("@Tipo", pMedicamento.Tipo);
                    _command.Parameters.AddWithValue("@Cantidad", pMedicamento.Cantidad);
                    _command.Parameters.AddWithValue("@FechaEntrada", pMedicamento.FechaEntrada);
                    _command.Parameters.AddWithValue("@FechaSalida", pMedicamento.FechaSalida);
                    _command.Parameters.AddWithValue("@FechaVencimiento", pMedicamento.FechaVecimiento);
                    _command.Parameters.AddWithValue("@IDLaboratorio", pMedicamento.IDLaboratorio);
                    _command.Parameters.AddWithValue("@IDDoctor", pMedicamento.IDDoctor);

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

        public static int ModificarMedicamento(Medicamento pMedicamento)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ModificarMedicamento", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;



                    _command.Parameters.AddWithValue("@ID", pMedicamento.ID);
                    _command.Parameters.AddWithValue("@Nombre", pMedicamento.Nombre);
                    _command.Parameters.AddWithValue("Tipo", pMedicamento.Tipo);
                    _command.Parameters.AddWithValue("Cantidad", pMedicamento.Cantidad);
                    _command.Parameters.AddWithValue("FechaEntrada", pMedicamento.FechaEntrada);
                    _command.Parameters.AddWithValue("FechaSalida", pMedicamento.FechaSalida);
                    _command.Parameters.AddWithValue("FechaVencimeinto", pMedicamento.FechaVecimiento);
                    _command.Parameters.AddWithValue("IDLaboratorio", pMedicamento.IDLaboratorio);
                    _command.Parameters.AddWithValue("IDDoctor", pMedicamento.IDDoctor);


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


        public static int EliminarMedicamento(Int64 pID)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("EliminarMedicamento", _connection as SqlConnection);
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

        public static List<MedicamentoLaboratorioDoctor> ConsultarMedicamento()
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ConsultarMedicamento", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader _reader = _command.ExecuteReader();
                    List<MedicamentoLaboratorioDoctor> _listaMedicamento = new List<MedicamentoLaboratorioDoctor>();

                    while (_reader.Read())
                    {
                        MedicamentoLaboratorioDoctor _medicamento = new MedicamentoLaboratorioDoctor();

                        _medicamento.ID = _reader.GetInt64(0);
                        _medicamento.Nombre = _reader.GetString(1);
                        _medicamento.Tipo = _reader.GetString(2);
                        _medicamento.Cantidad = _reader.GetInt32(3);
                        _medicamento.FechaEntrada = _reader.GetDateTime(4);
                        _medicamento.FechaSalida = _reader.GetDateTime(5);
                        _medicamento.FechaVencimiento = _reader.GetDateTime(6);
                        _medicamento.Laboratorio = _reader.GetString(7);
                        _medicamento.Doctor = _reader.GetString(8);




                        _listaMedicamento.Add(_medicamento);

                    }
                    _reader.Close();
                    _connection.Close();
                    return _listaMedicamento;
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
