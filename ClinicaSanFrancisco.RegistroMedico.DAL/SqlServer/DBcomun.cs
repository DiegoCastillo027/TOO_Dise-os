using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaSanFrancisco.RegistroMedico.EN;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
namespace ClinicaSanFrancisco.RegistroMedico.DAL
{
    public class DBcomun
    {
        public const string _ConnectionString =
        @"Data Source=.;Initial Catalog=ClinicaSanFrancisco;Integrated Security=True";
        public static IDbConnection ObtenerConexion()
        {
            return new SqlConnection(_ConnectionString);
        }

    }
}
