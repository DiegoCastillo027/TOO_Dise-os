using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSanFrancisco.RegistroMedico.EN
{
    public class MedicamentoLaboratorioDoctor
    {
        public Int64 ID { get; set; }

        public string Nombre { get; set; }

        public string Tipo { get; set; }
        public Int32 Cantidad { get; set; }

        public DateTime FechaEntrada { get; set; }

        public DateTime FechaSalida { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public string Laboratorio { get; set; }

        public string Doctor { get; set; }

        /*En consultas multitablas solo incluye el constructor vacio*/
        public MedicamentoLaboratorioDoctor() { }
    }
}
