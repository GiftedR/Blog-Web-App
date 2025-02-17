using BlogWebApp.Server.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogWebApp.Server.Models
{
    public class DynamicContent
    {
        [Key]
        public int DynamicContentID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [ForeignKey(nameof(Author))]
        public string AuthorId { get; set; }
        public BlogUser Author { get; set; }
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
