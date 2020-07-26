namespace DataAccess.Models
{
    public class Receta
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Dificultad Dificultad { get; set; }
        public double TiempoCoccion { get; set; }
        public CantidadIngrediente[] Ingredientes { get; set; }
        public Etiqueta[] Etiquetas { get; set; }
        public PasoReceta[] Pasos { get; set; }
    }
}
