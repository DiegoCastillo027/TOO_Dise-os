using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSanFrancisco.RegistroMedico.EN
{
    public class Cargo
    {
        public Int64 ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Cargo() { }

        public Cargo(Int64 pID, string pNombre, string pDescripcion)
        {
            ID = pID;
            Nombre = pNombre;
            Descripcion = pDescripcion;
        }

    }
}
