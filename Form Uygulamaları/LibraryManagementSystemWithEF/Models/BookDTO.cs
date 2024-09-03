
namespace LibraryManagementSystemWithEF.Models
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public int Stock { get; set; }
    }
}
