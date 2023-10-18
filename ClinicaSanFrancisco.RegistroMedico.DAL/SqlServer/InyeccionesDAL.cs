using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using ClinicaSanFrancisco.RegistroMedico.EN;

namespace ClinicaSanFrancisco.RegistroMedico.DAL
{
    public class InyeccionesDAL
    {

        public static int AgregarInyecciones(Inyecciones pInyecciones)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregaRInyecciones", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;

                  
                    _command.Parameters.AddWithValue("@Nombre", pInyecciones.Nombre);
                    _command.Parameters.AddWithValue("@Cantidad", pInyecciones.Cantidad);
                    _command.Parameters.AddWithValue("@FechaEntrada", pInyecciones.FechaEntrada);
                    _command.Parameters.AddWithValue("@FechaSalida", pInyecciones.FechaSalida);
                    _command.Parameters.AddWithValue("@IdLaboratorio", pInyecciones.IDLaboratorio);
                    _command.Parameters.AddWithValue("@IdDoctor", pInyecciones.IDDoctor);

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
        public static int ModificarInyecciones(Inyecciones pInyecciones)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ModificarInyecciones", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@ID", pInyecciones.ID);
                    _command.Parameters.AddWithValue("@Nombre", pInyecciones.Nombre);
                    _command.Parameters.AddWithValue("@Cantidad", pInyecciones.Cantidad);
                    _command.Parameters.AddWithValue("@FechaEntrada", pInyecciones.FechaEntrada);
                    _command.Parameters.AddWithValue("@FechaSalida", pInyecciones.FechaSalida);
                    _command.Parameters.AddWithValue("@IdLaboratorio", pInyecciones.IDLaboratorio);
                    _command.Parameters.AddWithValue("@IdDoctor", pInyecciones.IDDoctor);

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
        public static int EliminarInyecciones(Int64 pID)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("EliminarInyecciones", _connection as SqlConnection);
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