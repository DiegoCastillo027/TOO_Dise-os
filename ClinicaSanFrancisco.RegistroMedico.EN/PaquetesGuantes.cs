using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSanFrancisco.RegistroMedico.EN
{
   public class PaquetesGuantes
    {
        public Int64 ID { get; set; }
        public string Nombre { get; set; }
        public string Cantidad { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public Int32 IDLaboratorio { get; set; }
        public Int32 IDDoctor { get; set; }

        //Constructor vacio
        public PaquetesGuantes() { }
        //ConstructorLleno
        public PaquetesGuantes(Int64 pID, string pNombre, string pCantidad,
        DateTime pFechaEntrada, DateTime pFechaSalida, DateTime pFechaVencimiento,
        Int32 pIDLaboratorio, Int32 pIDDoctor)

        {
            ID = pID;
            Nombre = pNombre;
            Cantidad = pCantidad;
            FechaEntrada = pFechaEntrada;
            FechaSalida = pFechaSalida;
            FechaVencimiento = pFechaVencimiento;
            IDLaboratorio = pIDLaboratorio;
            IDDoctor = pIDDoctor;

        }

        public static void Add(PaquetesGuantes paquetesGuantes)
        {
            throw new NotImplementedException();
        }
    }
}