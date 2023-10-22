namespace CodeBits.API.Models.Dtos
{
    public class ResponseDto
    {
        public object? Result { get; set; }
        public bool IsSuccesss { get; set; } = true;
        public string Message { get; set; } = "";
    }
}
