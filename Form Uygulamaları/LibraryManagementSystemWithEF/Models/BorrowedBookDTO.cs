using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemWithEF.Models
{
    internal class BorrowedBookDTO
    {
        public int Id { get; set; }
        public DateTime BorrewedTime { get; set; }
        public DateTime ReturnTime { get; set; }
        public string BookName { get; set; }
    
    }
}
