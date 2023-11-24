using CodeBits.API.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeBits.API.Models.Dtos
{
    public class ViewCommentDto
    {
        public int Id { get; set; }
        public int ReplyCount { get; set; }
        public string CommentContent { get; set; }
        public string UserId { get; set; }
        public int ArticleId { get; set; }

        public ICollection<Reply> Replies { get; set; }
    }

}
