using System.ComponentModel.DataAnnotations;

namespace BlogWebApp.Server.Models
{
    public class StaticContent
    {
        [Key]
        public int StaticContentID { get; set; }
        public string Name { get; set; }
        public string Content { get; set; } // Inferred as Usage is Ambigous
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
