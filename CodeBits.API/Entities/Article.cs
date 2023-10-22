using System.ComponentModel.DataAnnotations.Schema;

namespace CodeBits.API.Entities
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string CoverImageUrl{ get; set; }
        public int CommentCount { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        [ForeignKey(nameof(AppUser))]
        public string UserId { get; set; }
        public AppUser AppUser { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<Comment> Comments { get; set; }

    }
}
