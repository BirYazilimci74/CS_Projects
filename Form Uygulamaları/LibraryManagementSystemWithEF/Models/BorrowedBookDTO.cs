using System;

namespace LibraryManagementSystemWithEF.Models
{
    public class BorrowedBookDTO
    {
        public int Id { get; set; }
        public DateTime BorrewedTime { get; set; }
        public DateTime ReturnTime { get; set; }
        public string BookName { get; set; }
    
    }
}
