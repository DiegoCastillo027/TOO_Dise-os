using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSanFrancisco.RegistroMedico.EN
{
    public class Inyecciones
    {
        public Int64 ID { get; set; }
        public string Nombre { get; set; }
        public string Cantidad { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public Int64 IDLaboratorio { get; set; }
        public Int64 IDDoctor { get; set; }

        //Constructor vacio
        public Inyecciones() { }
        //ConstructorLleno
        public Inyecciones(Int64 pID, string pNombre, string pCantidad,
        DateTime pFechaEntrada, DateTime pFechaSalida, Int32 pIDLaboratorio,
        Int32 pIDDoctor)

        {
            ID = pID;
            Nombre = pNombre;
            Cantidad = pCantidad;
            FechaEntrada = pFechaEntrada;
            FechaSalida = pFechaSalida;
            IDLaboratorio = pIDLaboratorio;
            IDDoctor = pIDDoctor;

        }
    }
}