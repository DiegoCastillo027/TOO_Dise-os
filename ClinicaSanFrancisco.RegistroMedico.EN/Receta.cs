using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSanFrancisco.RegistroMedico.EN
{
    public class Receta
    {
            public Int64 ID { get; set; }
            public DateTime Fecha { get; set; }
            public int IDDoctor { get; set; }
            public int IDPaciente { get; set; }
            public int IDDetalleReceta { get; set; }

            //Constructor vacio
            public Receta() { }

            //ConstructorLleno
            public Receta(Int64 pID, DateTime pFecha, int pIDDoctor, int pIDPaciente, int pIDDetalleReceta)
            {
                ID = pID;
                Fecha = pFecha;
                IDDoctor = pIDDoctor;
                IDPaciente = pIDPaciente;
                IDDetalleReceta = pIDDetalleReceta;
            }

        
    }
}
