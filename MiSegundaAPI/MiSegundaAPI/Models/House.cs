namespace MiSegundaAPI.Models
{
    public class House
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Size { get; set; }
        public List<Person> Persons { get; set; }
    }
}
