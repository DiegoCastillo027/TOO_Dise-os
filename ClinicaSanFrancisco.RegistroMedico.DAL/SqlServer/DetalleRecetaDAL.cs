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
    public class DetalleRecetaDAL
    {
        public static int AlmacenarDetalleReceta(DetalleReceta pDetalleReceta)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarDetalleReceta", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Medicamento", pDetalleReceta.Medicamento);
                    _command.Parameters.AddWithValue("@Cantidad", pDetalleReceta.Cantidad);
                    _command.Parameters.AddWithValue("@Dosis", pDetalleReceta.Dosis);


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

        public static int ModificarDetalleReceta(DetalleReceta pDetalleReceta)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ModificarDetalleReceta", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;
                    _command.Parameters.AddWithValue("@Medicamento", pDetalleReceta.Medicamento);
                    _command.Parameters.AddWithValue("@Cantidad", pDetalleReceta.Cantidad);
                    _command.Parameters.AddWithValue("@Dosis", pDetalleReceta.Dosis);



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
