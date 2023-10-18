using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSanFrancisco.RegistroMedico.EN
{
    public class DetalleReceta
    {
        public Int64 ID { get; set; }
        public string Medicamento { get; set; }
        public int Cantidad { get; set; }
        public string Dosis { get; set; }



        //Constructor vacio
        public DetalleReceta() { }

        //ConstructorLleno
        public DetalleReceta(Int64 pID, string pMedicamento, int pCantidad, string pDosis)
        {
            ID = pID;
            Medicamento = pMedicamento;
            Cantidad = pCantidad;
            Dosis = pDosis;
        }

    }
}
