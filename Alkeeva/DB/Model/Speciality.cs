namespace Alkeeva.DB.Model
{
    public enum Items
    {
        Physics,
        Social,
        Informatics
    }
    public class Speciality
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MinPoint { get; set; }
        public Items NessasaryItem { get; set; }
        public int BudgetPlaces { get; set; }
        public int FacultyId { get; set; }
        public Faculty? Faculty { get; set; }
        public List<Abiturients>? Abiturients { get; set; } = new();
    }
}
