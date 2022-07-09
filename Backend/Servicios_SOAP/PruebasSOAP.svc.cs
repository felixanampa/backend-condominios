using Backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Servicios_SOAP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "PruebasSOAP" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione PruebasSOAP.svc o PruebasSOAP.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class PruebasSOAP : IPruebasSOAP
    {
        private DbEntities db = new DbEntities();

        public List<Usuario> ListarUsuarios()
        {

            var x = db.Usuario.ToList();
            Task.Delay(5000);
            return x;
        }
    }
}
