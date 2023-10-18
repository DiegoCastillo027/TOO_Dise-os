using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSanFrancisco.RegistroMedico.EN
{
    public class Paciente
    {
        public Int64 ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; }
        public Int32 Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string DUI { get; set; }
        public Int32 NumeroTelefono { get; set; }
        public string Direccion { get; set; }
        public string ZonaDeVivienda { get; set; }
        public string Ocupacion { get; set; }
        public string EstadoCivil { get; set; }
        public string AlergicoAUnMedicamento { get; set; }
        public string Encargado { get; set; }
        public string TipoDeParto { get; set; }


        public Paciente() { }


        public Paciente(Int64 pID, string pNombre, string pApellido, string pSexo, Int32 pEdad, DateTime pFechaNacimiento, string pDUI, Int32 pNumeroTelefono, string pDireccion, string pZonaDeVivienda, string pOcupacion, string pEstadoCivil, string pAlergicoAUnMedicamento, string pEncargado, string pTipoDePArto)
        {
            ID = pID;
            Nombre = pNombre;
            Apellido = pApellido;
            Sexo = pSexo;
            Edad = pEdad;
            FechaNacimiento = pFechaNacimiento;
            DUI = pDUI;
            NumeroTelefono = pNumeroTelefono;
            Direccion = pDireccion;
            ZonaDeVivienda = pZonaDeVivienda;
            Ocupacion = pOcupacion;
            EstadoCivil = pEstadoCivil;
            AlergicoAUnMedicamento = pAlergicoAUnMedicamento;
            Encargado = pEncargado;
            TipoDeParto = pTipoDePArto;

        }
        
    }
}
