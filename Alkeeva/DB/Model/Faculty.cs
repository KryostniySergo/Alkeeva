namespace Alkeeva.DB.Model
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Speciality> Speciality { get; set; } = new();
    }
}
