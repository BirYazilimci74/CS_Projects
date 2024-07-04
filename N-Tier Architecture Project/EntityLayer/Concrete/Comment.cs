using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public bool Status { get; set; }

        public int LocationID { get; set; }
        public Location Location { get; set; }

        public int MemberID { get; set; }
        public Member Member { get; set; }
    }
}
