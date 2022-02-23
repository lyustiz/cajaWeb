using Caja.Datos;
using Caja.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Dominio
{
    public class DominioAuditoria
    {
        public void RegistrarAuditoria(AuditoriaHistoria registro)
        {
            new RepositorioAuditoriaHistoria().Insert(registro);
        }

        public List<Auditoria> ConsultarAuditoria()
        {
            return new RepositorioAuditoria().Find(" 1 = 1 ").ToList();
        }

        public Usuario ConsultarUsuarioAccion(string tabla, string filtro)
        {
            return new RepositorioAuditoria().Find(tabla, filtro);
        }

        public Auditoria ObtenerAuditoria(int id)
        {
            return new RepositorioAuditoria().Find(id);
        }
    }
}
