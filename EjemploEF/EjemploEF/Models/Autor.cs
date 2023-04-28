namespace EjemploEF.Models
{
    public class Autor
    {
        public int AutorId { get; set; }
        public string Nombre { get; set; }

        public Cancion cancion { get; set; }
    }
}
