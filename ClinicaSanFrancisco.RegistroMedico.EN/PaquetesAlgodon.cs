using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSanFrancisco.RegistroMedico.EN
{
    public class PaquetesAlgodon
    {
        public Int64 ID { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public Int64 IDLaboratorio { get; set; }
        public Int64 IDDoctor { get; set; }



        //Constructor vacio
        public PaquetesAlgodon() { }

        //ConstructorLleno
        public PaquetesAlgodon(Int64 pID, string pNombre, int pCantidad, DateTime pFechaEntrada, DateTime pFechaSalida, Int64 pIDLaboratorio, Int64 pIDDoctor)
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
