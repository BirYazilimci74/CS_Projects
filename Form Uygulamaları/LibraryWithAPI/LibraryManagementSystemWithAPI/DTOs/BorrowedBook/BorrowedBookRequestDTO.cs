
namespace LibraryManagementSystemWithAPI.DTOs.BorrowedBook
{
    public class BorrowedBookRequestDTO
    {
        public int BookID { get; set; }
        public DateTime BorrewedTime { get; set; } = DateTime.Now;
        public DateTime ReturnTime { get; set; } = DateTime.Now.AddDays(15);
    }
}