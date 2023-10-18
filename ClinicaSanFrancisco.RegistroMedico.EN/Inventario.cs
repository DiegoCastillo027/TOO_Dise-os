using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSanFrancisco.RegistroMedico.EN
{
    public class Inventario
    {
        public Int64 ID { get; set; }
        public Int64 IDDoctor { get; set; }
        public Int64 IDMedicamento { get; set; }
        public Int64 IDGasasEsteriles { get; set; }
        public Int64 IDInyecciones { get; set; }
        public Int64 IDPaquetesAlgodon { get; set; }
        public Int64 IDPaquetesGuantes { get; set; }
        public Int64 IDAlcohol { get; set; }

        //Constructor Vacio
        public Inventario() { }

        //Constructor Lleno

        public Inventario(Int64 pID, Int64 pIDDoctor, Int64 pIDMedicamento, Int64 pIDGasasEsteriles, Int64 pIDInyecciones, Int64 pIDPaquetesAlgodon, Int64 pIDPaquetesGuantes, Int64 pIDAlcohol)
        {
            ID = pID;
            IDDoctor = pIDDoctor;
            IDMedicamento = pIDMedicamento;
            IDGasasEsteriles = pIDGasasEsteriles;
            IDInyecciones = pIDInyecciones;
            IDPaquetesAlgodon = pIDPaquetesAlgodon;
            IDPaquetesGuantes = pIDPaquetesGuantes;
            IDAlcohol = pIDAlcohol;
        }

    }
}
