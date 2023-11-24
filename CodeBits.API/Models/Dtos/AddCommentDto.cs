using CodeBits.API.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeBits.API.Models.Dtos
{
    public class AddCommentDto
    {
        public string CommentContent { get; set; }
        public int ArticleId { get; set; }
        public ICollection<Reply> Replies { get; set; }
    }
}
