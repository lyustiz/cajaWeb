using Caja.Entidades;

namespace Caja.Dominio
{
    public class DominioBase
    {
        public RespuestaDominio Error(string pMensaje)
        {
            return new RespuestaDominio() { Ok = false, Mensaje = pMensaje };
        }

        public RespuestaDominio Ok()
        {
            return new RespuestaDominio() { Ok = true };
        }

        public RespuestaDominio Ok(int pCodigoConfirmacion)
        {
            return new RespuestaDominio() { Ok = true, IdConfirmacion = pCodigoConfirmacion };
        }

        public RespuestaDominio Ok(string pMensaje)
        {
            return new RespuestaDominio() { Ok = true, Mensaje = pMensaje };
        }

        public RespuestaDominio Ok(string pMensaje, int pCodigoConfirmacion)
        {
            return new RespuestaDominio() { Ok = true, Mensaje = pMensaje, IdConfirmacion = pCodigoConfirmacion };
        }

        public RespuestaDominio Ok(string pMensaje, int pCodigoConfirmacion, object pRegistro)
        {
            return new RespuestaDominio() { Ok = true, Mensaje = pMensaje, IdConfirmacion = pCodigoConfirmacion, Objeto = pRegistro };
        }
    }
}
