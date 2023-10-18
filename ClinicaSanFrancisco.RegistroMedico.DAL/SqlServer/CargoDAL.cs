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
    public class CargoDAL
    {
        public static List<Cargo> ObtenerCargos()
        {
            try
            {
                using (IDbConnection _connection = DBcomun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("CargarCargos", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader _reader = _command.ExecuteReader();
                    List<Cargo> _listaCa = new List<Cargo>();

                    while (_reader.Read())
                    {
                        Cargo _Cargo= new Cargo();

                        _Cargo.ID = _reader.GetInt64(0);
                        _Cargo.Nombre = _reader.GetString(1);
                        _Cargo.Descripcion = _reader.GetString(2);
                    

                        _listaCa.Add(_Cargo);

                    }
                    _reader.Close();
                    _connection.Close();
                    return _listaCa;
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
