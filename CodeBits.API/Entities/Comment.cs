using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeBits.API.Entities
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public int ReplyCount { get; set; }
        public string CommentContent { get; set; }
        [ForeignKey(nameof(AppUser))]
        public string UserId { get; set; }
        public AppUser AppUser { get; set; }

        [ForeignKey(nameof(Article))]
        public int ArticleId { get; set; }
        public Article Article { get; set; }

        public ICollection<Reply> Replies { get; set; } 
    }
}
