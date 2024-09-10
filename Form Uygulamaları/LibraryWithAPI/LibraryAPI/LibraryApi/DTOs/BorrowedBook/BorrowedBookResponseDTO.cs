using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.DTOs.BorrowedBook
{
    public class BorrowedBookResponseDTO
    {
        public string BookName { get; set; } = string.Empty;
        public DateTime BorrewedTime { get; set; } = DateTime.Now;
        public DateTime ReturnTime { get; set; } = DateTime.Now.AddDays(15);
    }
}