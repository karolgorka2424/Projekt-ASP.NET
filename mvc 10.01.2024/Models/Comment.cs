namespace mvc_10._01._2024.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int TaskId { get; set; }
        public int UserId { get; set; }
    }
}
