using Backend.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace Backend.Servicios_Rest
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "CrudEjemplo" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione CrudEjemplo.svc o CrudEjemplo.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CrudEjemplo : ICrudEjemplo
    {
        private DbEntities db = new DbEntities();
        public Usuario CrearUsuario(Usuario usuarioACrear)
        {
            db.Usuario.Add(usuarioACrear);
            db.SaveChanges();
            Usuario usuario = ObtenerUsuario(usuarioACrear.NroDocumento);
            return usuario;
        }

        public Usuario ObtenerUsuario(string dni)
        {
            var qry = from persona in db.Usuario.Where(x => (x.NroDocumento == dni))
                      select persona;
            Usuario resultado = qry.First();
            return resultado;
        }

        public void EliminarUsuario(string dni)
        {
            Usuario usuario = ObtenerUsuario(dni);
            db.Usuario.Remove(usuario);
            db.SaveChanges();
        }

        public List<Usuario> ListarUsuarios()
        {
            return db.Usuario.ToList();
        }

        public Usuario ModificarUsuario(Usuario usuarioAModificar)
        {
            db.Entry(usuarioAModificar).State = EntityState.Modified;
            db.SaveChanges();
            Usuario usuario = ObtenerUsuario(usuarioAModificar.NroDocumento);
            return usuario;
        }

        
    }
}
