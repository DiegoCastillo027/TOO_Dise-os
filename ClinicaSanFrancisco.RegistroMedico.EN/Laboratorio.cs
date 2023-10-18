using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSanFrancisco.RegistroMedico.EN
{
    public class Laboratorio
    {
        public Int64 ID { get; set; }
        public string NombreVisitadorMedico { get; set; }
        public string ApellidoVisitadorMedico { get; set; }
        public string DUIVisitadorMedico { get; set; }
        public string Direccion { get; set; }
        public string Empresa { get; set; }


        //Constructor vacio
        public Laboratorio() { }

        //Constructor lleno
        public Laboratorio(Int64 pID, string pNombreVisitadorMedico, string pApellidoVisitadorMedico,
            string pDUIVisitadorMedico, string pDireccion, string pEmpresa)
        {
            ID = pID;
            NombreVisitadorMedico = pNombreVisitadorMedico;
            ApellidoVisitadorMedico = pApellidoVisitadorMedico;
            DUIVisitadorMedico = pDUIVisitadorMedico;
            Direccion = pDireccion;
            Empresa = pEmpresa;
        }
    }
}

