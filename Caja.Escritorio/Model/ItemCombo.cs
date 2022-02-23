namespace Caja.Escritorio.Model
{
    public class ItemCombo
    {
        public ItemCombo()
        {
        }

        public ItemCombo( int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public int Id { get; set; }

        public string Nombre { get; set; }        
    }
}
