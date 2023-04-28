namespace EjemploEF.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Nombre { get; set; }

        public List<Cancion> Canciones { get; set; }
    }
}
