using Backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace Backend.Servicios_Rest
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICrudEjemplo" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICrudEjemplo
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "usuarios", ResponseFormat = WebMessageFormat.Json)]
        Usuario CrearUsuario(Usuario usuarioACrear);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "usuarios/{dni}", ResponseFormat = WebMessageFormat.Json)]
        Usuario ObtenerUsuario(string dni);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "usuarios", ResponseFormat = WebMessageFormat.Json)]
        Usuario ModificarUsuario(Usuario usuarioAModificar);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "usuarios/{dni}", ResponseFormat = WebMessageFormat.Json)]
        void EliminarUsuario(string dni);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "usuarios", ResponseFormat = WebMessageFormat.Json)]
        List<Usuario> ListarUsuarios();
    }
}
