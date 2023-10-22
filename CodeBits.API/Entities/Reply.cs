using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeBits.API.Entities
{
    public class Reply
    {
        [Key]
        public int Id {  get; set; }
        public string CommentReplyContent { get; set; }
        [ForeignKey(nameof(AppUser))]
        public string UserId { get; set; }
        public AppUser AppUser { get; set; }
        [ForeignKey(nameof(Comment))]
        public int CommentId { get; set; }
        public Comment Comment { get; set; }
    }
}
