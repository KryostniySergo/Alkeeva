using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alkeeva.DB.Model
{
    public class Speciality
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MinPoint { get; set; }
        public string NessasaryItem { get; set; }
        public int FacultyId { get; set; }
        public Faculty? Faculty { get; set; }
        public List<Abiturients> Abiturients { get; set; }
    }
}
