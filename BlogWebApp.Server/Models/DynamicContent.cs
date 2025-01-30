using System.ComponentModel.DataAnnotations;

namespace BlogWebApp.Server.Models
{
    public class DynamicContent
    {
        [Key]
        public int DynamicContentID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
