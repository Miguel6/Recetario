namespace DataAccess.Models
{
    public class CantidadIngrediente
    {
        public int Id { get; set; }
        public Ingrediente Ingrediente { get; set; }
        public double Cantidad { get; set; }
        public Unidad Unidad { get; set; }
    }
}
