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
    public class AlcoholDAL
    {
        public static int AlmacenarAlcohol(Alcohol pAlcohol)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarAlcohol", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Nombre", pAlcohol.Nombre);
                    _command.Parameters.AddWithValue("@Cantidad", pAlcohol.Cantidad);
                    _command.Parameters.AddWithValue("@FechaEntrada", pAlcohol.FechaEntrada);
                    _command.Parameters.AddWithValue("@FechaSalida", pAlcohol.FechaSalida);
                    _command.Parameters.AddWithValue("@FechaVencimiento", pAlcohol.FechaVencimiento);
                    _command.Parameters.AddWithValue("@IDLaboratorio", pAlcohol.IDLaboratorio);
                    _command.Parameters.AddWithValue("@IDDoctor", pAlcohol.IDDoctor);


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

        public static int ModificarAlcohol(Alcohol pAlcohol)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ModificarAlcohol", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Nombre", pAlcohol.Nombre);
                    _command.Parameters.AddWithValue("@Cantidad", pAlcohol.Cantidad);
                    _command.Parameters.AddWithValue("@FechaEntrada", pAlcohol.FechaEntrada);
                    _command.Parameters.AddWithValue("@FechaSalida", pAlcohol.FechaSalida);
                    _command.Parameters.AddWithValue("@FechaVencimiento", pAlcohol.FechaVencimiento);
                    _command.Parameters.AddWithValue("@IDLaboratorio", pAlcohol.IDLaboratorio);
                    _command.Parameters.AddWithValue("@IDDoctor", pAlcohol.IDDoctor);



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

        public static int EliminarAlcohol(Int64 pID)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("EliminarAlcohol", _connection as SqlConnection);
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
