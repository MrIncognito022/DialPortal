using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DialPortal.Models.Domain
{
    public class Comments
    {
        [Key]
        public int CommentsId { get; set; }
        public string UniqueId { get; set; }
        public string? Comment { get; set; }
        public string? Tags { get; set; }
        [DisplayName("Date")]
        public DateTime CreatedAt { get; set; }
    }
}
