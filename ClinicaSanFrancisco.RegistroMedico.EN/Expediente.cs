using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSanFrancisco.RegistroMedico.EN
{
    public class Expediente
    {
        public Int64 ID { get; set; }
        public Int64 IDDoctor { get; set; }
        public Int64 IDSecretaria { get; set; }
        public Int64 IDFichaMedica { get; set; }
        public Int64 IDPaciente { get; set; }

        //Constructor vacío
        public Expediente() { }

        //Constructor lleno

        public Expediente(Int64 pID, Int64 pIDDoctor, Int64 pIDSecretaria, Int64 pIDFichaMedica, Int64 pIDPaciente)
        {
            ID = pID;
            IDDoctor = pIDDoctor;
            IDSecretaria = pIDSecretaria;
            IDFichaMedica = pIDFichaMedica;
            IDPaciente = pIDPaciente;
        }
    }

}
