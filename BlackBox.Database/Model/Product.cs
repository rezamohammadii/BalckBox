using System.ComponentModel.DataAnnotations;

namespace BlackBox.Database.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public int Price { get; set; }
        public string? Name { get; set; }
    }
}
