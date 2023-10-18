using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSanFrancisco.RegistroMedico.EN
{
    public class FichaMedicaDoctorSecretariaMedicamentoPacienteReceta
    {
        public Int64 ID { get; set; }
        public DateTime FechaCita { get; set; }
        public string TipoCita { get; set; }
        public string Doctor { get; set; }
        public string Secretaria { get; set; }
        public string Medicamento { get; set; }
        public string NombrePaciente { get; set; }
        public string ApellidoPaciente { get; set; }
        public Int64 CodigoReceta { get; set; }
        public string ConsultaPor { get; set; }
        public string PresenteEnfermedad { get; set; }
        public Decimal Temperatura { get; set; }
        public Decimal FrecuenciaCardiaca { get; set; }
        public Decimal PresionArterial { get; set; }
        public Decimal Peso { get; set; }
        public Decimal Altura { get; set; }
        public string ExamenLaboratorio { get; set; }
        public string DescripcionFisica { get; set; }
        public string Diagnostico { get; set; }


        public FichaMedicaDoctorSecretariaMedicamentoPacienteReceta()
        { }
    }
}
