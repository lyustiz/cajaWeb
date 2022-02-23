using Caja.Entidades;
using System.Collections.Generic;

namespace Caja.Datos
{
    public class RepositorioAuditoria: RepositorioBase
    {
        public Auditoria Find(int id)
        {
            Auditoria result = base.FetchObject<Auditoria>($"SELECT * FROM auditoria WHERE IdAuditoria = {id};");

            return result;
        }

        public Usuario Find(string tabla, string filtro)
        {
            return base.FetchObject<Usuario>($"SELECT usua.* FROM auditoria audi, usuarios usua WHERE audi.IdUsuario = usua.IdUsuario AND audi.Tabla = '{tabla}' AND audi.Accion = 'Insertar' AND audi.RegistroNuevo LIKE '%{filtro}%' LIMIT 1;");
        }

        public IEnumerable<Auditoria> Find(string filtro)
        {
            IEnumerable<Auditoria> result = base.FetchObjects<Auditoria>($"SELECT * FROM auditoria WHERE {filtro} ORDER BY FechaAuditoria DESC;");

            return result;
        }
    }
}
