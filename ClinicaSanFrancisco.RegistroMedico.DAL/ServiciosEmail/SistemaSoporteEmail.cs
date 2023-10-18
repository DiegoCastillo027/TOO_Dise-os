using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSanFrancisco.RegistroMedico.DAL.ServiciosEmail
{
    class SistemaSoporteEmail:ServidorCorreoMaestro
    {
        public SistemaSoporteEmail() {
            EnviarMail = "soportesystemclinicasan@gmail.com";
            contrasena = "Clinica1524";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
