using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystemWithEF.Models
{
    public class BorrowedBook
    {
        [Key]
        public int Id { get; set; }
        public DateTime BorrewedTime { get; set; }
        public DateTime ReturnTime { get; set; }
        public int BookID { get; set; }
    }
}
