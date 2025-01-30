using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogWebApp.Server.Models
{
    public class FeedbackData
    {
        [Key]
        public int FeedbackID { get; set; }
        public string FeedbackName { get; set; }
        public string FeedbackDescription { get; set; }
        public string FeedbackEmail { get; set; }

        //[ForeignKey(nameof(Tag.TagID))]
        //public int FeedbackTag { get; set; }
    }
}
