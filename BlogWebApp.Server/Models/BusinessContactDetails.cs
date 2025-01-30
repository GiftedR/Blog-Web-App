using System.ComponentModel.DataAnnotations;

namespace BlogWebApp.Server.Models
{
    public class BusinessContactDetails
    {
        [Key]
        public int BusinessContactId { get; set; }
        public string BusinessName { get; set; }
        public string? BusinessEmail { get; set; }
        public string? BusinessPhone { get; set; }
        public string BusinessAddress { get; set; }
    }
}
