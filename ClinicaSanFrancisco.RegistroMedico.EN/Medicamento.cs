using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSanFrancisco.RegistroMedico.EN
{
    public class Medicamento
    {
        public Int64 ID { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaVecimiento { get; set; }
        public Int64 IDLaboratorio { get; set; }
        public Int64 IDDoctor { get; set; }

        //constructor vacío

        public Medicamento() { }

        //Constructor lleno
        public Medicamento(Int64 pID, string pNombre, string pTipo, int pCantidad, DateTime pFechaEntrada, DateTime pFechaSalida,
            DateTime pFechaVencimiento, Int64 pIDLaboratorio, Int64 pIDDoctor)
        {
            ID = pID;
            Nombre = pNombre;
            Tipo = pTipo;
            Cantidad = pCantidad;
            FechaEntrada = pFechaEntrada;
            FechaSalida = pFechaSalida;
            FechaVecimiento = pFechaVencimiento;
            IDLaboratorio = pIDLaboratorio;
            IDDoctor = pIDDoctor;

        }
    }
}
 
