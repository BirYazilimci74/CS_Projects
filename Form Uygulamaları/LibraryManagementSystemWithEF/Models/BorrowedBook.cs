using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
