using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Location
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
