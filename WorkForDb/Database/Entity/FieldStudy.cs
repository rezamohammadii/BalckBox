using System.ComponentModel.DataAnnotations;

namespace WorkForDb.Database.Entity
{
    public class FieldStudy
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
    }
}
