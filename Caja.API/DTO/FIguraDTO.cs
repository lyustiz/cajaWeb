namespace Caja.API.DTO
{
    public class FiguraDTO
    {
        public int IdFigura { get; set; }
        public int IdPlenoAutomatico { get; set; }
        public int IdSerie { get; set; }
        public string Nombre { get; set; }
        public string Posiciones { get; set; }
        public string Estado { get; set; }
        public double ValorPremio { get; set; }
    }
}
