namespace CodeBits.API.Models.Dtos
{
    public class UpdateArticleDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string CoverImageUrl { get; set; }
        public string UserId { get; set; }
        public int CategoryId { get; set; }
    }
}
