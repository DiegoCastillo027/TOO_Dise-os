using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSanFrancisco.RegistroMedico.EN
{
    public class ExpedienteDoctorSecretariaPacienteFichaMedica
    {
        public Int64 ID { get; set; }

        public string Doctor { get; set; }

        public string Secretaria { get; set; }

        public Int64 CodigoUltimaFicha { get; set; }

        public string Paciente { get; set; }

        /*En consultas multitablas solo incluye el constructor vacio*/
        public ExpedienteDoctorSecretariaPacienteFichaMedica() { }
    }


}
