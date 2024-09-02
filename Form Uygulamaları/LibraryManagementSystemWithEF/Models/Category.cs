using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemWithEF.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        List<Book> books { get; set; }
    }
}
