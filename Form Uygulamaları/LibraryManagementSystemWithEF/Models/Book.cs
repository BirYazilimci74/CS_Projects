using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystemWithEF.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int Stock { get; set; }
    }
}
