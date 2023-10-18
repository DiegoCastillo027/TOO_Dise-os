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
    public class PaquetesAlgodonDAL
    {
        public static int AlmacenarPaquetesAlgodon(PaquetesAlgodon pPaquetesAlgodon)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarPaquetesAlgodon", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;




                    _command.Parameters.AddWithValue("@Nombre", pPaquetesAlgodon.Nombre);
                    _command.Parameters.AddWithValue("@Cantidad", pPaquetesAlgodon.Cantidad);
                    _command.Parameters.AddWithValue("@FechaEntrada", pPaquetesAlgodon.FechaEntrada);
                    _command.Parameters.AddWithValue("@FechaSalida", pPaquetesAlgodon.FechaSalida);
                    _command.Parameters.AddWithValue("@IDLaboratorio", pPaquetesAlgodon.IDLaboratorio);
                    _command.Parameters.AddWithValue("@IDDoctor", pPaquetesAlgodon.IDDoctor);



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
        public static int ModificarPaquetesAlgodon(PaquetesAlgodon pPaquetesAlgodon)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ModificarPaquetesAlgodon", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;



                    _command.Parameters.AddWithValue("@Nombre", pPaquetesAlgodon.Nombre);
                    _command.Parameters.AddWithValue("@Cantidad", pPaquetesAlgodon.Cantidad);
                    _command.Parameters.AddWithValue("@FechaEntrada", pPaquetesAlgodon.FechaEntrada);
                    _command.Parameters.AddWithValue("@FechaSalida", pPaquetesAlgodon.FechaSalida);
                    _command.Parameters.AddWithValue("@IDLaboratorio", pPaquetesAlgodon.IDLaboratorio);
                    _command.Parameters.AddWithValue("@IDDoctor", pPaquetesAlgodon.IDDoctor);



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
        public static int EliminarPaquetesAlgodon(Int64 pID)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("EliminarPaquetesAlgodon", _connection as SqlConnection);
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
