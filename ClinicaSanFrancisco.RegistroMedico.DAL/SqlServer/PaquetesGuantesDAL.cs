using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using ClinicaSanFrancisco.RegistroMedico.EN;

namespace ClinicaSanFrancisco.RegistroMedico.DAL
{
    public class PaquetesGuantesDAL
    {

        public static int AgregarPaquetesGuantes(PaquetesGuantes pPaquetesGuantes)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarPaquetesGuantes", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Nombre", pPaquetesGuantes.Nombre);
                    _command.Parameters.AddWithValue("@Cantidad", pPaquetesGuantes.Cantidad);
                    _command.Parameters.AddWithValue("@FechaEntrada", pPaquetesGuantes.FechaEntrada);
                    _command.Parameters.AddWithValue("@FechaSalida", pPaquetesGuantes.FechaSalida);
                    _command.Parameters.AddWithValue("@FechaVencimiento", pPaquetesGuantes.FechaVencimiento);
                    _command.Parameters.AddWithValue("@IdLaboratorio", pPaquetesGuantes.IDLaboratorio);
                    _command.Parameters.AddWithValue("@IdDoctor", pPaquetesGuantes.IDDoctor);

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
        public static int ModificarPaquetesGuantes(PaquetesGuantes pPaquetesGuantes)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ModificarPaquetesGuantes", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@ID", pPaquetesGuantes.ID);
                    _command.Parameters.AddWithValue("@Nombre", pPaquetesGuantes.Nombre);
                    _command.Parameters.AddWithValue("@Cantidad", pPaquetesGuantes.Cantidad);
                    _command.Parameters.AddWithValue("@FechaEntrada", pPaquetesGuantes.FechaEntrada);
                    _command.Parameters.AddWithValue("@FechaSalida", pPaquetesGuantes.FechaSalida);
                    _command.Parameters.AddWithValue("@FechaVencimiento", pPaquetesGuantes.FechaVencimiento);
                    _command.Parameters.AddWithValue("@IdLaboratorio", pPaquetesGuantes.IDLaboratorio);
                    _command.Parameters.AddWithValue("@IdDoctor", pPaquetesGuantes.IDDoctor);

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
        public static int EliminarPaquetesGuantes(Int64 pID)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("EliminarPaquetesGuantes", _connection as SqlConnection);
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