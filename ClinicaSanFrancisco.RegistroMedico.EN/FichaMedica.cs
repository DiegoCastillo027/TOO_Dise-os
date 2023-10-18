using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSanFrancisco.RegistroMedico.EN
{
    public class FichaMedica
    {
        public Int64 ID { get; set; }
        public DateTime FechaCita { get; set; }
        public string TipoCita { get; set; }
        public Int64 IDDoctor { get; set; }
        public Int64 IDSecretaria { get; set; }
        public Int64 IDMedicamento { get; set; }
        public Int64 IDPaciente { get; set; }
        public Int64 IDReceta { get; set; }
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


        public FichaMedica()
        { }


        public FichaMedica (Int64 pID, DateTime pFechaCita, string pTipoCita, Int64 pIDDoctor, Int64 pIDSecretaria, Int64 pIDMedicamento, Int64 pIDPaciente, Int64 pIDReceta, string pConsultaPor, string pPresenteEnfermedad, Decimal pTemperatura, Decimal pFrecuenciaCardiaca, Decimal pPresionArterial, Decimal pPeso, Decimal pAltura, string pExamenLaboratorio, string pDescripcionFisica, string pDiagnostico)
        {
            ID = pID;
            FechaCita = pFechaCita;
            TipoCita = pTipoCita;
            IDDoctor = pIDDoctor;
            IDSecretaria = pIDSecretaria;
            IDMedicamento = pIDMedicamento;
            IDPaciente = pIDPaciente;
            IDReceta = pIDReceta;
            ConsultaPor = pConsultaPor;
            PresenteEnfermedad = pPresenteEnfermedad;
            Temperatura = pTemperatura;
            FrecuenciaCardiaca = pFrecuenciaCardiaca;
            PresionArterial = pPresionArterial;
            Peso = pPeso;
            Altura = pAltura;
            ExamenLaboratorio = pExamenLaboratorio;
            DescripcionFisica = pDescripcionFisica;
            Diagnostico = pDiagnostico;
        }
    }
}
