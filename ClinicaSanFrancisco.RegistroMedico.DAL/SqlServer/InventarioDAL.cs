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
    public class InventarioDAL
    {

        public static List<InventarioMedicamentoDoctorLaboratorio> ObtenerInventarioMedicamentos()
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ConsultarInventarioMedicamentos", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader _reader = _command.ExecuteReader();
                    List<InventarioMedicamentoDoctorLaboratorio> _listaInvMe = new List<InventarioMedicamentoDoctorLaboratorio>();

                    while (_reader.Read())
                    {
                        InventarioMedicamentoDoctorLaboratorio _IM = new InventarioMedicamentoDoctorLaboratorio();

                        _IM.ID = _reader.GetInt64(0);
                        _IM.Medicamento = _reader.GetString(1);
                        _IM.Cantidad = _reader.GetInt32(2);
                        _IM.FechaEntrada = _reader.GetDateTime(3);
                        _IM.FechaSalida = _reader.GetDateTime(4);
                        _IM.FechaVencimiento = _reader.GetDateTime(5);
                        _IM.Doctor = _reader.GetString(6);
                        _IM.Laboratorio = _reader.GetString(7);

                        _listaInvMe.Add(_IM);

                    }
                    _reader.Close();
                    _connection.Close();
                    return _listaInvMe;
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
        public static List<InventarioGasasDoctorLaboratorio> ObtenerInventarioGasas()
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ConsultarInventarioGasas", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader _reader = _command.ExecuteReader();
                    List<InventarioGasasDoctorLaboratorio> _listaInvG = new List<InventarioGasasDoctorLaboratorio>();

                    while (_reader.Read())
                    {
                        InventarioGasasDoctorLaboratorio _IG = new InventarioGasasDoctorLaboratorio();

                        _IG.ID = _reader.GetInt64(0);
                        _IG.Gasas = _reader.GetString(1);
                        _IG.Cantidad = _reader.GetInt32(2);
                        _IG.FechaEntrada = _reader.GetDateTime(3);
                        _IG.FechaSalida = _reader.GetDateTime(4);
                        _IG.FechaVencimiento = _reader.GetDateTime(5);
                        _IG.Doctor = _reader.GetString(6);
                        _IG.Laboratorio = _reader.GetString(7);

                        _listaInvG.Add(_IG);

                    }
                    _reader.Close();
                    _connection.Close();
                    return _listaInvG;
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
        public static List<InventarioGuantesDoctorLaboratorio> ObtenerInventarioGuantes()
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ConsultarInventarioGuantes", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader _reader = _command.ExecuteReader();
                    List<InventarioGuantesDoctorLaboratorio> _listaInvPG = new List<InventarioGuantesDoctorLaboratorio>();

                    while (_reader.Read())
                    {
                        InventarioGuantesDoctorLaboratorio _IPG = new InventarioGuantesDoctorLaboratorio();

                        _IPG.ID = _reader.GetInt64(0);
                        _IPG.PaqueteGuantes = _reader.GetString(1);
                        _IPG.Cantidad = _reader.GetInt32(2);
                        _IPG.FechaEntrada = _reader.GetDateTime(3);
                        _IPG.FechaSalida = _reader.GetDateTime(4);
                        _IPG.FechaVencimiento = _reader.GetDateTime(5);
                        _IPG.Doctor = _reader.GetString(6);
                        _IPG.Laboratorio = _reader.GetString(7);

                        _listaInvPG.Add(_IPG);

                    }
                    _reader.Close();
                    _connection.Close();
                    return _listaInvPG;
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
        public static List<InventarioInyeccionesDoctorLaboratorio> ObtenerInventarioInyecciones()
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ConsultarInventarioInyecciones", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader _reader = _command.ExecuteReader();
                    List<InventarioInyeccionesDoctorLaboratorio> _listaInvI = new List<InventarioInyeccionesDoctorLaboratorio>();

                    while (_reader.Read())
                    {
                        InventarioInyeccionesDoctorLaboratorio _II = new InventarioInyeccionesDoctorLaboratorio();

                        _II.ID = _reader.GetInt64(0);
                        _II.Inyecciones = _reader.GetString(1);
                        _II.Cantidad = _reader.GetInt32(2);
                        _II.FechaEntrada = _reader.GetDateTime(3);
                        _II.FechaSalida = _reader.GetDateTime(4);
                        _II.Doctor = _reader.GetString(5);
                        _II.Laboratorio = _reader.GetString(6);

                        _listaInvI.Add(_II);

                    }
                    _reader.Close();
                    _connection.Close();
                    return _listaInvI;
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
        public static List<InventarioAlgodonDoctorLaboratorio> ObtenerInventarioAlgodon()
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ConsultarInventarioAlgodon", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader _reader = _command.ExecuteReader();
                    List<InventarioAlgodonDoctorLaboratorio> _listaInvA = new List<InventarioAlgodonDoctorLaboratorio>();

                    while (_reader.Read())
                    {
                        InventarioAlgodonDoctorLaboratorio _IA = new InventarioAlgodonDoctorLaboratorio();

                        _IA.ID = _reader.GetInt64(0);
                        _IA.CantidadPaquetesAlgodon = _reader.GetString(1);
                        _IA.Cantidad = _reader.GetInt32(2);
                        _IA.FechaEntrada = _reader.GetDateTime(3);
                        _IA.FechaSalida = _reader.GetDateTime(4);
                        _IA.Doctor = _reader.GetString(5);
                        _IA.Laboratorio = _reader.GetString(6);

                        _listaInvA.Add(_IA);

                    }
                    _reader.Close();
                    _connection.Close();
                    return _listaInvA;
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
        public static List<InventarioAlcoholDoctorLaboratorio> ObtenerInventarioAlcohol()
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ConsultarInventarioAlcohol", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader _reader = _command.ExecuteReader();
                    List<InventarioAlcoholDoctorLaboratorio> _listaInvAl = new List<InventarioAlcoholDoctorLaboratorio>();

                    while (_reader.Read())
                    {
                        InventarioAlcoholDoctorLaboratorio _IAl = new InventarioAlcoholDoctorLaboratorio();

                        _IAl.ID = _reader.GetInt64(0);
                        _IAl.Nombre = _reader.GetString(1);
                        _IAl.CantidadBotesAlcohol = _reader.GetInt32(2);
                        _IAl.FechaEntrada = _reader.GetDateTime(3);
                        _IAl.FechaSalida = _reader.GetDateTime(4);
                        _IAl.FechaVencimiento = _reader.GetDateTime(5);
                        _IAl.Doctor = _reader.GetString(6);
                        _IAl.Laboratorio = _reader.GetString(7);

                        _listaInvAl.Add(_IAl);

                    }
                    _reader.Close();
                    _connection.Close();
                    return _listaInvAl;
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
        public static int AlmacenarInventario(Inventario pInvantario)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarInventario", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;



                    _command.Parameters.AddWithValue("@IDDoctor", pInvantario.IDDoctor);
                    _command.Parameters.AddWithValue("@IDMedicamento", pInvantario.IDMedicamento);
                    _command.Parameters.AddWithValue("@IDGasasEsteriles", pInvantario.IDGasasEsteriles);
                    _command.Parameters.AddWithValue("@IDInyecciones", pInvantario.IDInyecciones);
                    _command.Parameters.AddWithValue("@IDPaquetesAlgodon", pInvantario.IDPaquetesAlgodon);
                    _command.Parameters.AddWithValue("@IDPaquetesGuantes", pInvantario.IDPaquetesGuantes);
                    _command.Parameters.AddWithValue("@IDAlcohol", pInvantario.IDAlcohol);
                    


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
        public static int ModificarInventario(Inventario pInvantario)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ModificarInventario", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;


                    _command.Parameters.AddWithValue("@IDDoctor", pInvantario.IDDoctor);
                    _command.Parameters.AddWithValue("@IDMedicamento", pInvantario.IDMedicamento);
                    _command.Parameters.AddWithValue("@IDGasasEsteriles", pInvantario.IDGasasEsteriles);
                    _command.Parameters.AddWithValue("@IDInyecciones", pInvantario.IDInyecciones);
                    _command.Parameters.AddWithValue("@IDPaquetesAlgodon", pInvantario.IDPaquetesAlgodon);
                    _command.Parameters.AddWithValue("@IDPaquetesGuantes", pInvantario.IDPaquetesGuantes);
                    _command.Parameters.AddWithValue("@IDAlcohol", pInvantario.IDAlcohol);


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
        public static int EliminarInventario(Int64 pID)
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("EliminarInventario", _connection as SqlConnection);
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
