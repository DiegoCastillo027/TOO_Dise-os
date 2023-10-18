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
    public class RecetaDAL
    {
        public static int AlmacenarReceta(Receta pReceta)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarReceta", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Fecha", pReceta.Fecha);
                    _command.Parameters.AddWithValue("@IDDoctor", pReceta.IDDoctor);
                    _command.Parameters.AddWithValue("@IDPaciente", pReceta.IDPaciente);
                    _command.Parameters.AddWithValue("@IDDetalleReceta", pReceta.IDDetalleReceta);



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

        public static int ModificarReceta(Receta pReceta)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ModificarReceta", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Fecha", pReceta.Fecha);
                    _command.Parameters.AddWithValue("@IDDoctor", pReceta.IDDoctor);
                    _command.Parameters.AddWithValue("@IDPaciente", pReceta.IDPaciente);
                    _command.Parameters.AddWithValue("@IDDetalleReceta", pReceta.IDDetalleReceta);



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

        public static int EliminarReceta(Int64 pID)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("EliminarReceta", _connection as SqlConnection);
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
