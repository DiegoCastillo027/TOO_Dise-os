using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSanFrancisco.RegistroMedico.EN
{
    public class InventarioMedicamentoDoctorLaboratorio
    {
        public Int64 ID { get; set; }
        public string  Medicamento { get; set; }
        public Int32 Cantidad { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Doctor { get; set; }
        public string Laboratorio { get; set; }


        public InventarioMedicamentoDoctorLaboratorio() { }
    }
}
