namespace Caja.Entidades
{
    public class RespuestaDominio
    {
        public int IdConfirmacion { get; set; }
        public bool Ok { get; set; }
        public string Mensaje { get; set; }
        public object Objeto { get; set; }
    }
}
