using System.ComponentModel.DataAnnotations;

namespace WorkForDb.Database.Entity
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Names { get; set; }
        public string? Family { get; set; }
        public string? Family2 { get; set; }
        public string? FatherName { get; set; }
        public int Age { get; set; }
        public int Age2 { get; set; }
        public FieldStudy FieldStudy { get; set; } = new FieldStudy();
    }
}
