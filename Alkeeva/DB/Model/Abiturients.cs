using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alkeeva.DB.Model
{
    public class Abiturients
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public int Russian { get; set; }
        public int Math { get; set; }
        public int Physics { get; set; }
        public int Social { get; set; }
        public int Informatics { get; set; }
        public int SpecialityId { get; set; }
        public Speciality? Speciality { get; set; }
    }
}
